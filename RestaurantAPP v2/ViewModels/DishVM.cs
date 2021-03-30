using RestaurantAPP_v2.Models;
using Simplified;

namespace RestaurantAPP_v2.ViewModels
{
    public class DishVM : BaseInpc
    {
        private int count;
        private string title;
        public int price;
        private bool isSelected;
        private DishDto DishItem;



        public DishVM(DishDto dishItem, int count, bool isSelected)           
        {
            DishItem = dishItem;
            IsSelected = isSelected;
            Count = count;
        }

        public string Title
        {
            get { return DishItem.Title; }
            set
            {
                title = DishItem.Title;
            }
        }
        public int Price
        {
            get { return DishItem.Price; }
            set
            {
                price = DishItem.Price;
            }
        }
        public int Count { get => count; set => Set(ref count, value); }
        public bool IsSelected { get => isSelected; set => Set(ref isSelected, value); }

    }
}
