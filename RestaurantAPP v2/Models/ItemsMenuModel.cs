using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAPP_v2.Models
{
    public class ItemsMenuModel
    {
        private List<DishDto> Items { get; }

        public ItemsMenuModel(List<DishDto> items)
        {
            Items = items;
        }

        public List<DishDto> GetItems()
        {
            return Items;
        }
    }
}
