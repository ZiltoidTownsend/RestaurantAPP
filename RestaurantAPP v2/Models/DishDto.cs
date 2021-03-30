using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAPP_v2.Models
{
    public class DishDto
    {
        public string Title { get; }
        public int Price { get; }

        public DishDto(string title, int price)
        {
            Title = title;
            Price = price;
        }
    }
}
