using System;
using System.ComponentModel.DataAnnotations;

namespace Store.Models
{
  public class Products
  {
      [Key]
      public int Id { get; set; }
      public string Title { get; set; }
      public string Description { get; set; }
      public decimal Price { get; set; }
      public int Quantity { get; set; }
      public DateTime CreateDate { get; set; }
      public DateTime LastUpdateDate { get; set; }
      public int CategoryId { get; set; }
      public Category Category { get; set; }
  }
}