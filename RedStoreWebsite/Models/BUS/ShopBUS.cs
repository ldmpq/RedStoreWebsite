using System;
using ShopConnection;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedStoreWebsite.Models.BUS
{
    public class ShopBUS
    {
        //--User--//
        public static IEnumerable<tbPRODUCT> Danhsach()
        {
            var db = new ShopConnectionDB();
            return db.Query<tbPRODUCT>("select * from tbPRODUCT where Tinhtrang = 0");
        }

        public static tbPRODUCT Chitiet(String a)
        {
            var db = new ShopConnectionDB();
            return db.SingleOrDefault<tbPRODUCT>("select * from tbPRODUCT where MaSP = @0", a);
        }

        //--Admin--//
        public static IEnumerable<tbPRODUCT> DanhsachAdmin()
        {
            var db = new ShopConnectionDB();
            return db.Query<tbPRODUCT>("select * from tbPRODUCT");
        }
        public static void ThemProduct (tbPRODUCT tbproduct)
        {
            var db = new ShopConnectionDB();
            db.Insert(tbproduct);
        }
        public static void SuaProduct(String id, tbPRODUCT tbproduct)
        {
            var db = new ShopConnectionDB();
            db.Update(tbproduct, id);
        }
    }
}