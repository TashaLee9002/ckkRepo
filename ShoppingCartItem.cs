
namespace CKK.Logic.Models
{
   public class ShoppingCartItem
   {
      private Product _Product;
      private int Quantity;

      public ShoppingCartItem(Product product, int quantity)
      {
         _Product = product;
         Quantity = quantity;
      }

      public int GetQuantity()
      {
         return Quantity;
      }
      public void SetQuantity(int quantity)
      {
         Quantity = quantity;
      }
      public Product GetProduct()
      {
         return _Product;
      }
      public void SetProduct(Product product)
      {
         _Product = product;
      }
   }
}
