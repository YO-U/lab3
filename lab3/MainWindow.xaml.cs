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

namespace lab3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>


    public partial class MainWindow : Window
    {
        Poezd p = new Poezd();
      



        public MainWindow()
        {
            InitializeComponent();

        }

        public void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            if (Chas.Text != "")
                p.h = Convert.ToInt32(Chas.Text);


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Otpr o = new Otpr();
            int p1 = 12;
            int p2 = 14;
            int p3 = 16;
            int p4 = 9;
            if (p.h < 12)
            {
                P43.Text = o.Ost(p.h, p1).ToString() + "Часов отъедет";
            }
            else P43.Text = "уже уехал";
            
            if (p.h < 14)
            { 
                P7.Text = o.Ost(p.h, p2).ToString() + "Часов отъедет";
            }
            else P7.Text = "уже уехал";
            if (p.h < 16)
            {
                P55.Text = o.Ost(p.h, p3).ToString() + "Часов отъедет";
            }
            else P55.Text = "уже уехал";
            if (p.h < 9)
            {
             P15.Text = o.Ost(p.h, p4).ToString() + "Часов отъедет";
            }
            else P15.Text = "уже уехал";


        }
       
        
        class Otpr : Poezd
        {
            
            public  int Ost(int a, int b)  
            {
                int ds;
                ds = b - a;
                return ds;
            }

        }
       
    }
    
}


    
    

