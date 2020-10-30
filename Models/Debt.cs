using System;
using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
  public class Debt
  {
    public int id { get; set; }
    public int maxPortions { get; set; }
    public decimal commissionPercentage { get; set; }
    public DateTime dueDate { get; set; }
    public decimal originalValue { get; set; }
    public decimal interestValue { get; set; }
    public decimal calculatedValue { get; set; }
    public InterestType interestType { get; set; }
    public int customerId { get; set; }
    public string customerName { get; set; }
    public string coworkerPhone { get; set; }
  }
}