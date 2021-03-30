using Common;
using RestaurantAPP_v2.Models;
using Simplified;
using System.Collections.ObjectModel;

namespace RestaurantAPP_v2.ViewModels
{
    public class WaiterViewModel : BaseInpc
    {
        //public ObservableCollection<ItemMenuModel> ItemsMenu { get; }
        public ObservableCollection<CategoryVM> Categories { get; } = new ObservableCollection<CategoryVM>();
        public ObservableCollection<DishVM> SelectedItemsMenu { get; } = new ObservableCollection<DishVM>();
        public MenuVM ItemsMenuModel { get; }
        public CategoryVM SelectedCategory { get => _selectedCategory; set => Set(ref _selectedCategory, value); }
        private CategoryVM _selectedCategory;

        protected override void OnPropertyChanged(string propertyName, object oldValue, object newValue)
        {
            base.OnPropertyChanged(propertyName, oldValue, newValue);

            // Проверяется имя изменившегося свойства и производятся необходимые действия
            if (propertyName == nameof(SelectedCategory))
            {
                if (oldValue is CategoryVM category)
                    category.SelectedDish = null;
            }
        }
        //public ItemsMenuModel ItemsModel { get; }
        //public OrderModel OrderMenu { get; }

        public ObservableCollection<DishVM> SelectedDishes { get; }
            = new ObservableCollection<DishVM>();

        private RelayCommand _addDishCommand;
        public RelayCommand AddDishCommand => _addDishCommand
            ?? (_addDishCommand = new RelayCommand<DishVM>(AddDishExecute));

        private void AddDishExecute(DishVM dish)
        {
            SelectedItemsMenu.Add(dish);
        }

        private RelayCommand _closeWindCommand;
        public RelayCommand CloseWindCommand => _closeWindCommand
            ?? (_closeWindCommand = new RelayCommand<System.Windows.Window>(CloseWindExecute));

        private void CloseWindExecute(System.Windows.Window window)
        {
            if (window is System.Windows.Window)
            {
                //MainWindow dashboard = new MainWindow();
                //dashboard.Show();
                (window as System.Windows.Window).Close();
            }
        }

        //private RelayCommand showCommand;
        //public RelayCommand ShowCommand
        //{
        //    get
        //    {
        //        return showCommand ??
        //          (showCommand = new RelayCommand(obj =>
        //          {
        //              if (parameter is System.Windows.Window)
        //              {
        //                  MainWindow dashboard = new MainWindow();
        //                  dashboard.Show();
        //                  (parameter as System.Windows.Window).Close();
        //              }
        //          }));
        //    }
        //}


        public WaiterViewModel()
        {

            //OrderMenu = new OrderModel(1, 0.0, null);
            //SelectedItemsMenu = new ObservableCollection<ItemMenuModel>();
            //ItemsMenu = new ObservableCollection<ItemMenuModel>(ItemsModel.GetItems());
            ItemsMenuModel = new MenuVM();
            //SelectedCategory = new CategoryVM();

            foreach (var category in ItemsMenuModel.categoryVMs)
            {
                Categories.Add(category);
            }


            //MessageBox.Show(Categories[0].Name);

        }

    }
}
