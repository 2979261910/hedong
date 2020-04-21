using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketModel
{
    [Serializable]
    public  class ProductInventory
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// 最小库存
        /// </summary>
        public int MinCount { get; set; }

        /// <summary>
        /// 最大库存
        /// </summary>
        public int MaxCount { get; set; }

        /// <summary>
        /// 库存状态
        /// </summary>
        public int StatusId { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        public string StatusDesc { get; set; }
    }
}
