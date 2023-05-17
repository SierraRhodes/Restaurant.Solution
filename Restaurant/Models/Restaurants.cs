using System.Collections.Generic;

namespace Restaurant.Models
{
  public class Restaurants
  {
    public int RestaurantId { get; set; } 
    public string Name { get; set; }
    public List<Cuisine> Cuisines {get; set; }
  
  }
}