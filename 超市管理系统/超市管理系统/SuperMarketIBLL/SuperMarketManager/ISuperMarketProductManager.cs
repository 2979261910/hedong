using SuperMarketModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketIBLL.SuperMarketManager
{
    public  interface ISuperMarketProductManager
    {
        List<ProductCategory> GetCategories();
        List<ProductUnit> GetUnit();

        bool InsertProduct(Produts produt, ProductInventory inventory);
        List<Produts> GetAllProduct();

        Produts GetProductWithId(string pid);
        bool InventoryProduct(string pid, int count);

        bool SetProductDiscount(string pid, float discount);

        bool UpdateProduct(Produts produts);

        List<Produts> GetProductsWithWhere(int categoryId, string where);
    }
}
