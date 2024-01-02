using ShopConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedStoreWebsite.Models.BUS
{
    public class HomeBUS
    {
        public static IEnumerable<tbPRODUCT> DanhsachFeatured()
        {
            var db = new ShopConnectionDB();
            return db.Query<tbPRODUCT>("select * from tbPRODUCT where Featured = 0");
        }

        public static IEnumerable<tbPRODUCT> DanhsachLastest()
        {
            var db = new ShopConnectionDB();
            return db.Query<tbPRODUCT>("select * from tbPRODUCT where Lastest = 0");
        }

        public static tbPRODUCT Chitiet(String a)
        {
            var db = new ShopConnectionDB();
            return db.SingleOrDefault<tbPRODUCT>("select * from tbPRODUCT where MaSP = @0", a);
        }
    }
}