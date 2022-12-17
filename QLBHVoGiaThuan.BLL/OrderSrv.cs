using QLBHVoGiaThuan.Common.BLL;
using QLBHVoGiaThuan.Common.Rsp;
using QLBHVoGiaThuan.DAL;
using QLBHVoGiaThuan.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLBHVoGiaThuan.BLL
{
    public class OrderSrv: GenericSvc<OrderRep, Order>
    {
        OrderRep orderRep;
        public OrderSrv()
        {
            orderRep = new OrderRep();
        }
        public override SingleRsp Read(string id)
        {
            SingleRsp rsp = new SingleRsp();
            rsp.Data = orderRep.Read(id);
            return rsp;
        }
    }
}
