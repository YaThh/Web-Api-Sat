using QLBHVoGiaThuan.Common.BLL;
using QLBHVoGiaThuan.Common.Req;
using QLBHVoGiaThuan.Common.Rsp;
using QLBHVoGiaThuan.DAL;
using QLBHVoGiaThuan.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLBHVoGiaThuan.BLL
{
    public class ProductSrv: GenericSvc<ProductRep, Product>
    {
        ProductRep productRep;
        public ProductSrv()
        {
            productRep = new ProductRep();
        }

        public SingleRsp CreateProduct(ProductReq productReq)
        {
            var res = new SingleRsp();
            Product product = new Product();
            product.ProductId = productReq.ProductId;
            product.ProductName = productReq.ProductName;
            product.SupplierId = productReq.SupplierId;
            product.CategoryId = productReq.CategoryId;
            product.QuantityPerUnit = productReq.QuantityPerUnit;
            product.UnitPrice = productReq.UnitPrice;
            product.UnitsInStock = productReq.UnitsInStock;
            product.ReorderLevel = productReq.ReorderLevel;
            product.Discontinued = productReq.Discontinued;
            res = productRep.CreateProduct(product);
            return res;
        }

        public SingleRsp UpdateProduct(ProductReq productReq)
        {
            var res = new SingleRsp();
            Product product = new Product();
            product.ProductId = productReq.ProductId;
            product.ProductName = productReq.ProductName;
            product.SupplierId = productReq.SupplierId;
            product.CategoryId = productReq.CategoryId;
            product.QuantityPerUnit = productReq.QuantityPerUnit;
            product.UnitPrice = productReq.UnitPrice;
            product.UnitsInStock = productReq.UnitsInStock;
            product.ReorderLevel = productReq.ReorderLevel;
            product.Discontinued = productReq.Discontinued;
            res = productRep.UpdateProduct(product);
            return res;
        }
    }
}
