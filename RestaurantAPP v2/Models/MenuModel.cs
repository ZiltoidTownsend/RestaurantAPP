using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAPP_v2.Models
{
    public class MenuModel
    {
        public List<CategoryModel> AllItemsMenu { get; }


        public MenuModel()
        {
            var ItemsModelOne = new ItemsMenuModel(new List<DishDto>()
            {
                new DishDto("Луковый суп", 30),
                new DishDto("Томатный суп", 30),
            });

            var ItemsModelTwo = new ItemsMenuModel(new List<DishDto>()
            {
                new DishDto("Гречка с тушенкой", 30),
                new DishDto("Картошка с рыбой", 30),
            });

            List<CategoryModel> allItemsMenu = new List<CategoryModel>()
            {
                new CategoryModel("Супы", ItemsModelOne),
                new CategoryModel("Горячие блюда", ItemsModelTwo)
            };
            AllItemsMenu = allItemsMenu;
        }

        public List<CategoryModel> GetAllMenu()
        {
            return AllItemsMenu;
        }

    }
}
