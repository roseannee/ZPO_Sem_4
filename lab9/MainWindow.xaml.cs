using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;

namespace lab9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> links = new List<string>();

        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Add_btn_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(NewLink_txb.Text))
                throw new Exception("This field cannot be empty!");

            links.Add(NewLink_txb.Text);
            Links_lbx.Items.Add(NewLink_txb.Text);

            NewLink_txb.Clear();
        }

        private void Delete_btn_Click(object sender, RoutedEventArgs e)
        {
            int index = Links_lbx.SelectedIndex;

            if (index >= 0)
            {
                links.RemoveAt(index);
                Links_lbx.Items.RemoveAt(index);
            }
            else
            {
                throw new Exception("Select an item!");
            }
        }

        private async void Download_btn_Click(object sender, RoutedEventArgs e)
        {
            Result_tbl.Items.Clear();

            if (links.Count > 0)
            {
                var tasks = new List<Task>();
                foreach (var url in links)
                {
                    tasks.Add(ProcessUrlAsync(url));
                }

                await Task.WhenAll(tasks.ToArray());
            }
        }

        private async Task<string> ProcessUrlAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                string data = await client.GetStringAsync(new Uri(url));
                Result_tbl.Items.Add($"Completed: {url}");

                return data;
            }
        }
    }
}
