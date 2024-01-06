using Humanizer;
using ProsperDaily.Abstractions;

namespace ProsperDaily.MVVM.Models
{
    public class Transaction : TableData
     {
          public string Name { get; set; }
          public decimal Amount { get; set; }
          public bool IsIncome { get; set; }
          public DateTime OperationDate { get; set; }
          public string HumanDate => OperationDate.Humanize();
     }
}