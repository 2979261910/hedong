using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketModel
{
    [Serializable]
    public class ProductCategory
    {
        /// <summary>
        /// 商品分类ID
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// 商品分类
        /// </summary>
        public string CategoryName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsClock { get; set; }
    }
}
