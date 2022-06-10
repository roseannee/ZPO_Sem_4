using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace lab8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static readonly object _locker = new object();

        public int from;
        public int to;
        public int threadSize;

        public int tasks;
        public int finishedTasks;

        public int result;

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Start_btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                from = int.Parse(From_txb.Text);
                to = int.Parse(To_txb.Text);
                tasks = int.Parse(Subranges_txb.Text);
            }
            catch
            {
                MessageBox.Show("Error in input fields!");
                return;
            }

            threadSize = (to - from) / tasks;
            finishedTasks = 0;
            result = 0;

            Status_lbl.Content = "start searching";

            for (int i = 0; i < tasks; i++)
            {
                int min = threadSize * i;
                int max = threadSize * (i + 1);

                await Task.Run(() => SearchForPrimes(min, max));
            }

            Status_lbl.Content = "completed";
        }

        public void SearchForPrimes(int from, int to)
        {
            for (int i = from; i < to; i++)
            {
                if (i.IsPrime())
                {
                    result++;
                }
            }

            lock (_locker)
            {
                finishedTasks++;

                Application.Current.Dispatcher.BeginInvoke(new Action(() =>
                {
                    Result_lbl.Content = $"there are {result} prime numbers";
                    Progress_pbar.Value = (int)((double)finishedTasks / tasks * 100);
                }), DispatcherPriority.Render);
            }
        }

        private void Clear_btn_Click(object sender, RoutedEventArgs e)
        {
            From_txb.Text = "";
            To_txb.Text = "";
            Subranges_txb.Text = "";
            Status_lbl.Content = "";
            Progress_pbar.Value = 0;
            Result_lbl.Content = "";
        }
    }
}
