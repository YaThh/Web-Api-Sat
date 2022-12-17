using QLBHVoGiaThuan.Common.DAL;
using QLBHVoGiaThuan.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace QLBHVoGiaThuan.DAL
{
    public class OrderRep: GenericRep<NorthwindContext, Order>
    {
        public override Order Read(string id)
        {
            var s = All.FirstOrDefault(c => c.CustomerId == id);
            return s;
        }
    }
}
