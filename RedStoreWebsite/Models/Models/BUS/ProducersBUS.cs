using ShopConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedStoreWebsite.Models.BUS
{
    public class ProducersBUS
    {
        //--User--//
        public static IEnumerable<tbPRODUCER> Danhsach() 
        {
            var db = new ShopConnectionDB();
            return db.Query<tbPRODUCER>("select * from tbPRODUCER where Tinhtrang = 0");
        }
        public static IEnumerable<tbPRODUCT> Chitiet(String id)
        {
            var db = new ShopConnectionDB();
            return db.Query<tbPRODUCT>("select * from tbPRODUCT where MaNSX = '" + id + "'");
        }

        //--Admin--//
        public static IEnumerable<tbPRODUCER> DanhsachAdmin()
        {
            var db = new ShopConnectionDB();
            return db.Query<tbPRODUCER>("select * from tbPRODUCER");
        }
        public static tbPRODUCER ChitietAdmin(String id)
        {
            var db = new ShopConnectionDB();
            return db.SingleOrDefault<tbPRODUCER>("select * from tbPRODUCER where MaNSX = '" + id + "'");
        }
        public static void ThemProducer (tbPRODUCER tbproducer)
        {
            var db = new ShopConnectionDB();
            db.Insert(tbproducer);
        }
        public static void SuaProducer (String id, tbPRODUCER tbproducer)
        {
            var db = new ShopConnectionDB();
            db.Update(tbproducer, id);
        }

    }
}