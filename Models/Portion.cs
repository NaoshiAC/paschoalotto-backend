using System;

namespace backend.Models
{
  public class Portion
  {
    public int id { get; set; }
    public decimal portionValue { get; set; }
    public int overdueDays { get; set; }
    public int debtId { get; set; }
  }
}