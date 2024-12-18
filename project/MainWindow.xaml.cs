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

namespace project
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void raschet(object sender, RoutedEventArgs e)
        {
            try
            {
                double HP = double.Parse(var_hp.Text);
                bool boolHp;
                bool boolDef;
                double DEF = double.Parse(var_def.Text);
                int lvl;
                double temp1;
                double temp2;
                if (HP > 0)
                {
                    boolHp = true;
                }
                else
                {
                    boolHp = false;
                }
                if (DEF > 0)
                {
                    boolDef = true;
                }
                else
                {
                    boolDef = false;
                }
                if (lvl92.IsChecked==false && lvl95.IsChecked == false )
                {
                    string messageBoxText2 = "Выберите уровень противника";
                    string caption2 = "Effective_HP";
                    MessageBoxButton button2 = MessageBoxButton.OK;
                    MessageBoxImage icon2 = MessageBoxImage.Error;
                    MessageBox.Show(messageBoxText2, caption2, button2, icon2);
                }
                if (lvl92.IsChecked == true && boolDef && boolHp)
                {
                    lvl = 92;
                    temp1 = Srez(HP, DEF, lvl);
                    temp2 = EHP(HP, temp1);
                    temp2 = Math.Round(temp2, 2);
                    MessageBox.Show(temp2.ToString());
                }
                else if (lvl95.IsChecked == true && boolDef && boolHp)
                {
                    lvl = 95;
                    temp1 = Srez(HP, DEF, lvl);
                    temp2 = EHP(HP, temp1);
                    temp2 = Math.Round(temp2, 2);
                    MessageBox.Show(temp2.ToString());
                }
                else
                {
                    MessageBox.Show("введите корректные значения");
                }
            }
            catch
            {
                string messageBoxText1 = "Введите пожалуйста корректные данные в поля, а так же проверьте что вы выбрали уровень противника";
                string caption1 = "Effective_HP";
                MessageBoxButton button1 = MessageBoxButton.OK;
                MessageBoxImage icon1 = MessageBoxImage.Information;
                MessageBox.Show(messageBoxText1, caption1, button1, icon1);
                
            }
            
            
            
        }
        static double Srez(double hp, double def, int lvl)
        {
            double srez;
            srez=1-(def/(def+200+10*lvl));
            return srez;
        }

        static double EHP(double hp,double srez)
        {
            double ehp;
            ehp = hp * ((1 - srez) + 1);
            return ehp;
        }

        private void meme(object sender, RoutedEventArgs e)
        {
            string messageBoxText = "У меня какие-то вопросы";
            string caption = "System32";
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxImage icon = MessageBoxImage.Information;
            MessageBox.Show(messageBoxText, caption, button, icon);
        }
    }
}
