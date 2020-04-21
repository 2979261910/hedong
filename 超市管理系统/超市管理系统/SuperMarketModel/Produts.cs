using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketModel
{
    public   class Produts
    {
        /// <summary>
        /// 商品编号商品条码
        /// </summary>
        public string ProductId { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string ProductName { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        public string Unit { get; set; }
        /// <summary>
        /// 计量单位
        /// </summary>
        public decimal UnitPrice { get; set; }
        /// <summary>
        /// 折扣
        /// </summary>
        public double Discount { get; set; }
        /// <summary>
        /// 商品分类
        /// </summary>
        public int CategoryId { get; set; }

        //扩展属性
        /// <summary>
        ///  序号
        /// </summary>
        public int ProductNo { get; set; }
        /// <summary>
        ///销售数量
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        public decimal SubTotal { get; set; }
        /// <summary>
        /// 商品分类
        /// </summary>
        public string CategoryName { get; set; }
    }
}
