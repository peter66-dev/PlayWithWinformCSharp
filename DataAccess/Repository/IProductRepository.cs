using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IProductRepository
    {
        public IEnumerable<ProductObject> GetProducts();

        public IEnumerable<ProductObject> GetProductsByName(string name);

        public ProductObject GetProductByID(int id);

        public ProductObject GetProductByIDAndName(int id, string name);

        public void InsertProduct(int cateID, string proName, string weight, decimal unitPrice, int stocks);

        public void DeleteProduct(int id);

        public void UpdateProduct(ProductObject pro);

        public List<string> CheckQuantity(List<ProductObject> cart);

        public void SubQuantityProduct(List<ProductObject> cart);

    }
}
