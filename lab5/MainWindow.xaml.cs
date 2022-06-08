using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace lab5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Order> orders = new List<Order>();

        public MainWindow()
        {
            InitializeComponent();

            FirstDay_cal.SelectedDate = DateTime.Today;
            LastDay_cal.SelectedDate = DateTime.Today;
        }

        private void Save_btn_Click(object sender, RoutedEventArgs e)
        {
            Order tempOrder = new Order();

            if (FirstName_txb.Text.Length < 3)
                throw new Exception("First name is too short!");

            if (LastName_txb.Text.Length < 3)
                throw new Exception("Last name is too short!");

            if (FirstDay_cal.SelectedDate == null)
                throw new Exception("Pick first day!");

            if (LastDay_cal.SelectedDate == null)
                throw new Exception("Pick last day!");

            DateTime tempFirstDate = FirstDay_cal.SelectedDate.Value;
            DateTime tempLastDate = LastDay_cal.SelectedDate.Value;

            if (DateTime.Compare(tempLastDate, tempFirstDate) < 0)
                throw new Exception("Last day cannot be before first day!");

            decimal tempPrice;
            if (decimal.TryParse(BasePrice_txb.Text, out tempPrice) == false)
                throw new Exception("You need to enter a number!");

            tempOrder.FirstName = FirstName_txb.Text;
            tempOrder.LastName = LastName_txb.Text;
            tempOrder.FirstDay = tempFirstDate;
            tempOrder.DaysCount = (int)(tempLastDate - tempFirstDate).Days + 1;
            tempOrder.Price = tempPrice;
            tempOrder.Helmet = (bool)Helmet_ckb.IsChecked;
            tempOrder.Goggles = (bool)Goggles_ckb.IsChecked;
            tempOrder.Poles = (bool)Poles_ckb.IsChecked;

            orders.Add(tempOrder);
            Orders_lbx.Items.Add(tempOrder.ToString());
            ClearBoxes();
        }

        private void Delete_btn_Click(object sender, RoutedEventArgs e)
        {
            int orderIndex = Orders_lbx.SelectedIndex;

            if (orderIndex >= 0)
            {
                Orders_lbx.Items.RemoveAt(orderIndex);
                orders.RemoveAt(orderIndex);
                ClearBoxes();
            }
        }

        private void Clear_btn_Click(object sender, RoutedEventArgs e)
        {
            Orders_lbx.SelectedIndex = -1;
            ClearBoxes();
        }

        private void Orders_lbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int orderIndex = Orders_lbx.SelectedIndex;

            if (orderIndex >= 0)
            {
                Order tempOrder = orders[orderIndex];

                FirstName_txb.Text = tempOrder.FirstName;
                LastName_txb.Text = tempOrder.LastName;
                FirstDay_cal.SelectedDate = tempOrder.FirstDay;
                LastDay_cal.SelectedDate = tempOrder.FirstDay.AddDays(tempOrder.DaysCount - 1);
                DaysCount_txb.Text = tempOrder.DaysCount.ToString();
                BasePrice_txb.Text = tempOrder.Price.ToString();
                Helmet_ckb.IsChecked = tempOrder.Helmet;
                Goggles_ckb.IsChecked = tempOrder.Goggles;
                Poles_ckb.IsChecked = tempOrder.Poles;
            }
        }

        private void ClearBoxes()
        {
            FirstName_txb.Text = "";
            LastName_txb.Text = "";
            FirstDay_cal.SelectedDate = DateTime.Today;
            LastDay_cal.SelectedDate = DateTime.Today;
            DaysCount_txb.Text = "1";
            BasePrice_txb.Text = "50";
            Helmet_ckb.IsChecked = false;
            Goggles_ckb.IsChecked = false;
            Poles_ckb.IsChecked = false;
        }        

        private void FirstDay_cal_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            ChangeCalendars();
        }

        private void LastDay_cal_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            ChangeCalendars();
        }

        private void ChangeCalendars()
        {
            if (FirstDay_cal.SelectedDate == null)
                return;

            if (LastDay_cal.SelectedDate == null)
                return;

            DateTime firstDay = FirstDay_cal.SelectedDate.Value;
            DateTime lastDay = LastDay_cal.SelectedDate.Value;

            DaysCount_txb.Text = ((lastDay - firstDay).Days + 1).ToString();
        }

        private void DaysCountUp_Click(object sender, RoutedEventArgs e)
        {
            ChangeDaysCount(1);
        }

        private void DaysCountDown_Click(object sender, RoutedEventArgs e)
        {
            ChangeDaysCount(-1);
        }

        private void ChangeDaysCount(int change)
        {
            int daysCount = 1;

            try
            {
                daysCount = int.Parse(DaysCount_txb.Text);
            }
            catch { }

            daysCount += change;

            if (daysCount < 1)
                daysCount = 1;
            else if (daysCount > 100)
                daysCount = 100;

            DaysCount_txb.Text = daysCount.ToString();

            if (FirstDay_cal.SelectedDate == null)
                FirstDay_cal.SelectedDate = DateTime.Today;

            DateTime firstDay = FirstDay_cal.SelectedDate.Value;
            LastDay_cal.SelectedDate = firstDay.AddDays(daysCount - 1);
        }        
    }
}
