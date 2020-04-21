using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketModel
{
    /// <summary>
    /// 消费明细
    /// </summary>
    [Serializable]
    public   class SalesListDetail
    {
        /// <summary>
        /// 流水id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 流水号
        /// </summary>
        public string SerialNum { get; set; }
        /// <summary>
        /// 商品编号
        /// </summary>
        public string ProductId { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string ProductName { get; set; }
        /// <summary>
        /// 商品单价
        /// </summary>
        public decimal UnitPrice { get; set; }
        /// <summary>
        /// 折扣
        /// </summary>
        public double Discount { get; set; }
        /// <summary>
        /// 销售数量
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// 小计金额
        /// </summary>
        public decimal SubTotalMoney { get; set; }
    }
}
