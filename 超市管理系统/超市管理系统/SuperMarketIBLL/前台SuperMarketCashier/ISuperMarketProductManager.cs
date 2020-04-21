﻿using SuperMarketModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketIBLL.前台SuperMarketCashier
{
    /// <summary>
    /// 商品业务逻辑
    /// </summary>
    public interface ISuperMarketProductManager
    {
        Produts GetProductWithId(string productId);
        bool SaveSalerInfo(SalesList sales, SMMembers members);
    }
}
