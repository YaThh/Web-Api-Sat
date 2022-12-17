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
    public class OrderController : ControllerBase
    {
        OrderSrv orderSrv;
        public OrderController()
        {
            orderSrv = new OrderSrv();
        }
        [HttpPost("get-by-customer-id")]
        public IActionResult GetOrderByCustomerID([FromBody] SimpleReq simpleReq)
        {
            SingleRsp rsp = orderSrv.Read(simpleReq.Keyword);
            rsp.Data = orderSrv.All.Where(c => c.CustomerId == simpleReq.Keyword);
            return Ok(rsp);
        }
        [HttpPost("get-all-order")]
        public IActionResult GetAllOrder([FromBody] SimpleReq simpleReq)
        {
            SingleRsp rsp = new SingleRsp();
            rsp.Data = orderSrv.All;
            return Ok(rsp);
        }

    }
}
