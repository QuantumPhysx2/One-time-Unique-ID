using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace <APP_NAME>.Models
{
  public class <MODEL_NAME>
  {
    [Key]                                                   // Specify the following attribute as the Primary Key for this model
    [DatabaseGenerated(DatabaseGeneratedOptions.Identity)]  // Auto-assign a random unique ID value for custom ID
    public string <MODEL_NAME>Id { get; set; }
    public string PH_Name { get; set; }
  }
}
