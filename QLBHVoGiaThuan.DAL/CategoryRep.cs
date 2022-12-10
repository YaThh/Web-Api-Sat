using System;
using System.Collections.Generic;
using System.Text;
using QLBHVoGiaThuan.Common.DAL;
using QLBHVoGiaThuan.DAL.Models;
using System.Linq;

namespace QLBHVoGiaThuan.DAL
{
    public class CategoryRep: GenericRep<NorthwindContext, Category>
    {
        public override Category Read(int id)
        {
            var s = All.FirstOrDefault(c => c.CategoryId == id);
            return s;
        }
    }
}
