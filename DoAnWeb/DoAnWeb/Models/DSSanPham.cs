using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DoAnWeb.Models
{
    public class DSSanPham
    {
        public IEnumerable<SANPHAM> GetDSSanPham()
        {
            using (KetNoi_DataContext db = new KetNoi_DataContext())
            {
                return db.SANPHAMs.ToList();
            }
        }
       
    }
}