using Microsoft.EntityFrameworkCore;
using MicrosoftSqlServer.EF.Connection.Example.EF.Context;
using MicrosoftSqlServer.EF.Connection.Example.EF.Models;
using MicrosoftSqlServer.EF.Connection.Example.Raw;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftSqlServer.EF.Connection.Example
{
    internal class Test
    {
        public static void Test1()
        {
            using var ctx = new PurchasingContext();

            var orders = ctx.PurchaseOrderHeader
                                    .Take(100)
                                    .Select(p => new PurchaseOrderHeader()
                                    {
                                        VendorId = p.VendorId
                                    }).ToList();

            foreach (var item in orders)
            {
                var vendor = ctx.Vendor.AsNoTracking().Where(v => v.BusinessEntityId == item.VendorId).First();

                Console.WriteLine(vendor.Name);
            }

            var query = (from header in ctx.PurchaseOrderHeader
                         join vendor in ctx.Vendor
                            on header.VendorId equals vendor.BusinessEntityId
                         select new
                         {
                             VendorName = vendor.Name
                         }).Take(100);

            foreach (var obj in query)
            {
                Console.WriteLine(obj.VendorName);
            }
        }

        public static void Test2()
        {
            var cnn = new Raw.Connection();
            cnn.Open();

            cnn.Query();

            cnn.Close();
        }
    }
}
