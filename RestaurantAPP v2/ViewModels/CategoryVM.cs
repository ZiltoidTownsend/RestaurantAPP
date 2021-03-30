using Common;
using RestaurantAPP_v2.Models;
using Simplified;
using System.Collections.ObjectModel;

namespace RestaurantAPP_v2.ViewModels
{
    public class CategoryVM : BaseInpc
    {

        public CategoryModel Category { get; }

        public CategoryVM(CategoryModel category)
        {
            Category = category;
            Dishs = new DishItemsVM(Category.Items);
        }

        public DishItemsVM Dishs { get; }


        private DishVM _selectedDish;
        public DishVM SelectedDish { get => _selectedDish; set => Set(ref _selectedDish, value); }
    }
}
