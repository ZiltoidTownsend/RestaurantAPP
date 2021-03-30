using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAPP_v2.Models
{
    public class CategoryModel
    {
        public string Name { get; }

        public ItemsMenuModel Items { get; }


        public CategoryModel(string name, ItemsMenuModel items)
        {
            Name = name;
            Items = items;
        }
    }
}
