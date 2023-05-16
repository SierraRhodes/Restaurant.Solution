using Microsoft.EntityFrameworkCore;

namespace Restaurant.Models
{
  public class RestaurantContext : DbContext
  {


    public RestaurantContext(DbContextOptions options) : base(options) { }
  }
}