using RestaurantAPP_v2.ViewModels;
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
    class OrderModel : INotifyPropertyChanged
    {
        public int IdOrder { get; }
        public double Cost { get; set; }
        private List<DishVM> orderItems;
       

        public List<DishVM> OrderItems
        {
            get
            {
                return orderItems;
            }

            set
            {
                orderItems = value;
                OnPropertyChanged("OrderItems");
            }
        }


        public OrderModel(int idOrder, double cost, List<DishVM> orderItems)
        {
            IdOrder = idOrder;
            Cost = cost;
            this.orderItems = orderItems;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
