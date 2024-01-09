
namespace CKK.Logic.Models
{
   public class StoreItem
   {
      private Product _product;
      private int _quantity;

      public StoreItem(Product product, int quantity)
      {
         _product = product;
         _quantity = quantity;
      }

      public int GetStoreQuantity()
      {
         return _quantity;
      }
      public void SetStoreQuantity(int quantity)
      {
         _quantity = quantity;
      }
      public Product GetStoreProduct()
      {
         return _product;
      }
      public void SetStoreProduct(Product product)
      {
         _product = product;
      }
   }
}
