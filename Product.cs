﻿

namespace CKK.Logic.Models
{
   public class Product
   {
      private int Id;
      private string Name;
      private decimal Price;

      public int GetId()
      {
         return Id;
      }
      public void SetId(int id)
      {
         Id = id;
      }
      public string GetName()
      {
         return Name;
      }
      public void SetName(string name)
      {
         Name = name;
      }
      public decimal GetPrice()
      {
         return Price;
      }
      public void SetAddress(decimal price)
      {
         Price = price;
      }
   } 
   }
