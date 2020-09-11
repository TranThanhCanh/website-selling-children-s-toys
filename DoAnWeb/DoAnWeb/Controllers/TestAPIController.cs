using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using DoAnWeb.Models;


namespace DoAnWeb.Controllers
{
    public class TestAPIController : ApiController
    {
        private DSSanPham _SanPham = new DSSanPham();

        [Route("~/api/TestAPI")]
        [HttpGet]
        public IEnumerable<SANPHAM> GetDSSanPham()
        {
            return _SanPham.GetDSSanPham();
        }
    }
}
