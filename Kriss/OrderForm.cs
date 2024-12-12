using System;
using System.Windows.Forms;
using TruckingSystem;  // Добавьте правильное пространство имен, где определен класс CargoOrder

namespace CargoTransportationSystem
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent(); // Инициализация компонентов
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string orderDate = txtOrderDate.Text;
            string senderName = txtSender.Text;
            string pickupAddress = txtPickupAddress.Text;
            string recipientName = txtRecipient.Text;
            string deliveryAddress = txtDeliveryAddress.Text;
            float routeLength = float.Parse(txtRouteLength.Text);
            float cost = float.Parse(txtCost.Text);

            // Создаем объект заказа (CargoOrder)
            // Проверьте, что конструктор в CargoOrder принимает нужные параметры
            CargoOrder order = new CargoOrder(orderDate, senderName, pickupAddress, recipientName, deliveryAddress, routeLength, cost);

            // Сохраняем или выводим сообщение
            MessageBox.Show("Order placed successfully.");
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }
    }
}
