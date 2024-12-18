using System.ComponentModel.DataAnnotations;
namespace CrudSimple.Models;

public class User
{
    [Key]
    public int Id { get; set; }
  
    public string Name { get; set; }
    
    public string Email { get; set; }
        
    public virtual ICollection<Order> Orders { get; set; }
}

