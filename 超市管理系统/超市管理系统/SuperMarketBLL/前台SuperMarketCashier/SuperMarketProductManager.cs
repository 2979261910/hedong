using SuperMarketDAL.前台SuperMarketCashier;
using SuperMarketIBLL.前台SuperMarketCashier;
using SuperMarketIDAL.前台SuperMarketCashier;
using SuperMarketModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketBLL.前台SuperMarketCashier
{
    public class SuperMarketProductManager : ISuperMarketProductManager
    {
        ISuperMarketProductServer server = new SuperMarketProductServer();
        public Produts GetProductWithId(string productId)
        {
            return server.GetProductWithId(productId);
        }

        public bool SaveSalerInfo(SalesList sales, SMMembers members)
        {
            return server.SaveSalerInfo(sales, members);
        }
    }
}
