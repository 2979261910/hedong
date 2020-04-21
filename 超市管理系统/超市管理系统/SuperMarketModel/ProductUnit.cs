using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketModel
{
    [Serializable]
    public class ProductUnit
    {
        /// <summary>
        /// 商品序号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 商品计量单位
        /// </summary>
        public string Unit { get; set; }
    }
}
