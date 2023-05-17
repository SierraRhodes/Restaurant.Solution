using System.Collections.Generic;
using MySqlConnector;

namespace Restaurant.Models
{
  public class Cuisine
  {
   public int CuisineId { get; set; }
   public string Description { get; set; }
   public int RestaurantId { get; set; }
   public Restaurants Restaurant {get; set; }
  }
}