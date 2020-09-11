using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DoAnWeb.Models
{
    public class ketnoi
    {
        public SqlConnection cn;
        public ketnoi()
        {
            string strcn = System.Configuration.ConfigurationManager.ConnectionStrings["ql"].ConnectionString;
            cn = new SqlConnection(strcn);
        }
    }
}