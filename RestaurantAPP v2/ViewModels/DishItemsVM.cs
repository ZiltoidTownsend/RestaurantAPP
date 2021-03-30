using RestaurantAPP_v2.Models;
using Simplified;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAPP_v2.ViewModels
{
    public class DishItemsVM : BaseInpc
    {
        private ItemsMenuModel DishItems;
        public ObservableCollection<DishVM> DishItemsList { get; set; } = new ObservableCollection<DishVM>();

        public DishItemsVM(ItemsMenuModel dishItems)
        {
            DishItems = dishItems;

            foreach (var item in DishItems.GetItems())
            {
                DishItemsList.Add(new DishVM(item, 0, false));
            }
        }

        public ObservableCollection<DishVM> GetItemsDish()
        {
            return DishItemsList;
        }

    }
}
