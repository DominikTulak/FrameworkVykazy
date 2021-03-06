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
using System.Windows.Shapes;

namespace Vykazy.View
{
    /// <summary>
    /// Interakční logika pro Nastavení.xaml
    /// </summary>
    public partial class Nastavení : Window
    {
        private int pocitadlo = 0;
        public Nastavení()
        {
            InitializeComponent();
            TB_Jmeno.Text = Model.Settings.Jmeno;
            TB_Text1.Text = Model.Settings.Text1;
            TB_Text2.Text = Model.Settings.Text2;
            lb_text1.Visibility = Visibility.Hidden;
            lb_text2.Visibility = Visibility.Hidden;

            TB_Text1.Visibility = Visibility.Hidden;
            TB_Text2.Visibility = Visibility.Hidden;
        }

        private void btn_Ulozit_Click(object sender, RoutedEventArgs e)
        {
            Model.Settings.Ulozit(TB_Jmeno.Text, TB_Text1.Text, TB_Text2.Text);
        }

        private void btn_Nahrat_Click(object sender, RoutedEventArgs e)
        {
            Model.Settings.Nacist();
            TB_Jmeno.Text = Model.Settings.Jmeno;
            TB_Text1.Text = Model.Settings.Text1;
            TB_Text2.Text = Model.Settings.Text2;
        }

        private void btn_Vymazat_Click(object sender, RoutedEventArgs e)
        {
            TB_Jmeno.Text = "";
            TB_Text1.Text = "";
            TB_Text2.Text = "";
        }
        private void btn_Nastaveni_Click(object sender, RoutedEventArgs e)
        {
            pocitadlo++;
            if(pocitadlo == 10)
            {

                lb_text1.Visibility = Visibility.Visible;
                lb_text2.Visibility = Visibility.Visible;

                TB_Text1.Visibility = Visibility.Visible;
                TB_Text2.Visibility = Visibility.Visible;
            }
        }
    }
}
