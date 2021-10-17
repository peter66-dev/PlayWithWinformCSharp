using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public List<string> CheckQuantity(List<ProductObject> cart) => ProductDAO.Instance.CheckQuantity(cart);
        public void DeleteProduct(int id) => ProductDAO.Instance.DeleteProduct(id);
        public ProductObject GetProductByID(int id) => ProductDAO.Instance.GetProductByID(id);
        public ProductObject GetProductByIDAndName(int id, string name) => ProductDAO.Instance.GetProductByIDAndName(id, name);
        public IEnumerable<ProductObject> GetProducts() => ProductDAO.Instance.GetProductList();
        public IEnumerable<ProductObject> GetProductsByName(string name) => ProductDAO.Instance.GetProductByName(name);
        public void InsertProduct(int cateID, string proName, string weight, decimal unitPrice, int stocks) => ProductDAO.Instance.InsertProduct(cateID, proName, weight, unitPrice, stocks);
        public void UpdateProduct(ProductObject pro) => ProductDAO.Instance.UpdateProduct(pro);
    }
}
