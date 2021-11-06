using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bakery.Models
{
  public class Treat
  {
    public Treat()
    {
      this.JoinEntityies = new HashSet<FlavorTreat>();
    }

    public int TreatId { get; set; }
    public string Name { get; set; }
    public string Ingredients { get; set; }
    public string Description { get; set; }
    public string Price { get; set; }
    public virtual ApplicationUser User { get; set; }

    public virtual ICollection<FlavorTreat> JoinEntities {get; }
  }
}