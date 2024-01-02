using ShopConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedStoreWebsite.Models.BUS
{
    public class CartBUS
    {
        private const string Args = "'";

        public static void Them(string masp, string matk, int soluong, int dongia, string tensp)
        {
            using (var db = new ShopConnectionDB())
            {
                var x = db.Query<tbCART>("select * from tbCART where MaTK = '" + matk + "'").ToList();
                if ( x.Count() > 0)
                {
                    int a = (int)x.ElementAt(0).Soluong + soluong;
                    Capnhat(masp, matk, a, dongia, tensp);
                }
                else
                {
                    tbCART cart = new tbCART()
                    {
                        MaSP = masp,
                        MaTK = matk,
                        Soluong = 1,
                        Dongia = dongia,
                        TenSP = tensp,
                        Thanhtien = dongia * soluong
                    };
                    db.Insert(cart);
                }
            }
        }

        public static IEnumerable<tbCART> Danhsach(string matk)
        {
            using ( var db = new ShopConnectionDB())
            {
                return db.Query<tbCART>("select * from tbCART where MaTK = '" + matk + "'");
            }
        }

        public static void Capnhat(string masp, string matk, int soluong, int dongia, string tensp)
        {
            using (var db = new ShopConnectionDB())
            {
                tbCART cart = new tbCART()
                {
                    MaSP = masp,
                    MaTK = matk,
                    Soluong = soluong,
                    Dongia = dongia,
                    TenSP = tensp
                };
                var tamp = db.Query<tbCART>("select idCART from tbCART where MaTK = '" + matk + "' and MaSP = '" + masp + "'").FirstOrDefault();
                db.Update(cart, tamp.idCART);
            }              
        }

        public static void Xoa(string masp, string matk)
        {

        }

        public static int Thanhtien(string matk)
        {
            using (var db = new ShopConnectionDB())
            {
                return db.Query<int>("select sum(Tongtien) from Giohang where MaTk = @MaTk", new { MaTk = matk }).FirstOrDefault();
            }
        }
    }
}