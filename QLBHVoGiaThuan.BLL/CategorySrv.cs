using QLBHVoGiaThuan.DAL;
using System;
using System.Collections.Generic;
using System.Text;
using QLBHVoGiaThuan.DAL.Models;
using QLBHVoGiaThuan.Common.BLL;
using QLBHVoGiaThuan.Common.Rsp;

namespace QLBHVoGiaThuan.BLL
{
    public class CategorySrv: GenericSvc<CategoryRep, Category>
    {
        private CategoryRep categoryRep;
        public CategorySrv()
        {
            categoryRep = new CategoryRep();
        }
        public override SingleRsp Read(int id)
        {
            SingleRsp rsp = new SingleRsp();
            rsp.Data = categoryRep.Read(id);
            return rsp;
        }
    }
}
