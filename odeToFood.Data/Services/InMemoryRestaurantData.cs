using odeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        public List<odeToFood.Data.Models.Restaurant> Restaurants; //{ get; set; }

        public InMemoryRestaurantData()
        {
            Restaurants = new List<Restaurant>()
            {
                new Restaurant{ Id = 1, Name = "I Want Pizza", Cuisine=CuisineType.Italian}
                ,new Restaurant{ Id=2, Name="Iris", Cuisine=CuisineType.French}
                ,new Restaurant{ Id=3, Name="Green Leaf", Cuisine=CuisineType.Indian}
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return Restaurants.OrderBy(r=>r.Name);
        }
    }
}
