using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLBHVoGiaThuan.BLL;
using QLBHVoGiaThuan.Common.Req;
using QLBHVoGiaThuan.Common.Rsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLBHVoGiaThuan.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        ProductSrv productSrv;
        public ProductController()
        {
            productSrv = new ProductSrv();
        }
        [HttpPost("create-product")]
        public IActionResult CreateProduct([FromBody] ProductReq productReq)
        {
            var res = new SingleRsp();
            res = productSrv.CreateProduct(productReq);
            return Ok(res);
        }

        [HttpPost("update-product")]
        public IActionResult UpdateProduct([FromBody] ProductReq productReq)
        {
            var res = new SingleRsp();
            res = productSrv.UpdateProduct(productReq);
            return Ok(res);
        }
    }
}
