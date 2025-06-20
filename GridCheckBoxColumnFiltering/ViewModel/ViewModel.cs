using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGrid_Demo_4_8
{
    public class OrderInfoCollection
    {
        private ObservableCollection<OrderInfo> _orders;
        public ObservableCollection<OrderInfo> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }
        public OrderInfoCollection()
        {
            _orders = new ObservableCollection<OrderInfo>();
            this.GenerateOrders();
        }
        private void GenerateOrders()
        {
            _orders.Add(new OrderInfo(1001,true, "Maria", "Germany"));
            _orders.Add(new OrderInfo(1002, false, "Trujilo", "Mexico"));
            _orders.Add(new OrderInfo(1003, true, "Moreno", "Mexico"));
            _orders.Add(new OrderInfo(1004, false, "Hardy", "UK"));
            _orders.Add(new OrderInfo(1005, true, "Christina", "Sweden"));
            _orders.Add(new OrderInfo(1006, false, "Hanna", "Germany"));
            _orders.Add(new OrderInfo(1007, true, "Frederique", "France"));
            _orders.Add(new OrderInfo(1008, false, "Martin", "Spain"));
            _orders.Add(new OrderInfo(1009, true, "Laurence", "France"));
            _orders.Add(new OrderInfo(1010, false, "Elizabeth", "Canada"));
        }
    }
}
