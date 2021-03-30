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
    public class MenuVM : BaseInpc
    {
        public MenuModel menuModel { get; } = new MenuModel();
        public ObservableCollection<CategoryVM> categoryVMs { get; } = new ObservableCollection<CategoryVM>();

        public MenuVM()
        {
            foreach (var itemMenu in menuModel.AllItemsMenu)
            {
                categoryVMs.Add(new CategoryVM(itemMenu));
            }
        }

    }
}
