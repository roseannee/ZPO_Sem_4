using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LengthAbove3_btn_Click(object sender, RoutedEventArgs e)
        {
            OutputNewString(GetLinesFromInput.LengthAbove3());
        }
        private void LineIsSentence_btn_Click(object sender, RoutedEventArgs e)
        {
            OutputNewString(GetLinesFromInput.LineIsSentence());
        }
        private void ContainsSpecialCharacters_btn_Click(object sender, RoutedEventArgs e)
        {
            OutputNewString(GetLinesFromInput.ContainsSpecialCharacters());
        }

        private void SortAsc_btn_Click(object sender, RoutedEventArgs e)
        {
            OutputNewString(GetLinesFromInput.SortAsc());
        }
        private void SortDesc_btn_Click(object sender, RoutedEventArgs e)
        {
            OutputNewString(GetLinesFromInput.SortDesc());
        }

        private void ToLowercase_btn_Click(object sender, RoutedEventArgs e)
        {
            OutputNewString(GetLinesFromInput.ToLowercase());
        }
        private void ToUppercase_btn_Click(object sender, RoutedEventArgs e)
        {
            OutputNewString(GetLinesFromInput.ToUppercase());
        }
        private void ReplaceSpaceByUnderscore_btn_Click(object sender, RoutedEventArgs e)
        {
            OutputNewString(GetLinesFromInput.ReplaceSpaceByUnderscore());
        }

        private void IsLengthAbove3_btn_Click(object sender, RoutedEventArgs e)
        {
            OutputNewString(GetLinesFromInput.IsLengthAbove3().BoolToStringArray());
        }
        private void IsASentence_btn_Click(object sender, RoutedEventArgs e)
        {
            OutputNewString(GetLinesFromInput.IsASentence().BoolToStringArray());
        }
        private void HasSpecialCharacters_btn_Click(object sender, RoutedEventArgs e)
        {
            OutputNewString(GetLinesFromInput.HasSpecialCharacters().BoolToStringArray());
        }

        private void GetFirstWord_btn_Click(object sender, RoutedEventArgs e)
        {
            OutputNewString(GetLinesFromInput.GetFirstWord());
        }
        private void GetLastWord_btn_Click(object sender, RoutedEventArgs e)
        {
            OutputNewString(GetLinesFromInput.GetLastWord());
        }
        private void CountWords_btn_Click(object sender, RoutedEventArgs e)
        {
            OutputNewString(GetLinesFromInput.CountWords().IntToStringArray());
        }

        private string[] GetLinesFromInput
        {
            get
            {
                return Input_txb.Text.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            }
        }

        private void OutputNewString(object[] elements)
        {
            Output_txb.Text = string.Join("\n", elements);
        }
    }
}
