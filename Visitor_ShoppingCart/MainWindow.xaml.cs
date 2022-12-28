using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Visitor_ShoppingCart
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Good> Einkaufswagen = new List<Good>();
        List<Good> Einkaufskorb = new List<Good>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAddClicked(object sender, RoutedEventArgs e)
        {
            if (rdoBev.IsChecked == true)
            {
                var beverage = new Beverage();
                beverage.Name = txtName.Text;
                beverage.Weight = Convert.ToInt32(sldWeight.Value);
                beverage.NrUnits = Convert.ToInt32(sldUnits.Value);
                beverage.PricePerUnit = Convert.ToDouble(txtPricePerUnit.Text);
                beverage.Alcohol = Math.Round(Random.Shared.NextDouble() * 100,1);
                beverage.Calories = Random.Shared.Next(50, 500);
                Add(beverage);
            }
            else if (rdoCos.IsChecked == true)
            {
                var cosmetic = new Cosmetic();
                cosmetic.Name = txtName.Text;
                cosmetic.Weight = Convert.ToInt32(sldWeight.Value);
                cosmetic.NrUnits = Convert.ToInt32(sldUnits.Value);
                cosmetic.PricePerUnit = Convert.ToDouble(txtPricePerUnit.Text);
                Add(cosmetic);
            }
            else
            {
                var food = new Food();
                food.Name = txtName.Text;
                food.Weight = Convert.ToInt32(sldWeight.Value);
                food.NrUnits = Convert.ToInt32(sldUnits.Value);
                food.PricePerUnit = Convert.ToDouble(txtPricePerUnit.Text);
                food.Calories = Random.Shared.Next(50, 500);
                Add(food);
            }
        }

        private void Add(Good good)
        {
            if (rdoCart.IsChecked == true)
            {
                Einkaufswagen.Add(good);
            }
            else
            {
                Einkaufskorb.Add(good);
            }

            Refresh();
        }

        private void Refresh()
        {
            lstCart.ItemsSource = null;
            lstCart.ItemsSource = Einkaufswagen;
            lstBag.ItemsSource = null;
            lstBag.ItemsSource = Einkaufskorb;
        }

        private void BtnAlcClicked(object sender, RoutedEventArgs e)
        {
            var visitor = new AlkoholVisitor();
            foreach (var good in Einkaufskorb)
            {
                good.Accept(visitor);
            }
            foreach (var good in Einkaufswagen)
            {
                good.Accept(visitor);
            }
            MessageBox.Show(visitor.ResultString);
        }

        private void BtnCalClicked(object sender, RoutedEventArgs e)
        {
            var visitor = new KalorienVisitor();
            foreach (var good in Einkaufskorb)
            {
                good.Accept(visitor);
            }
            foreach (var good in Einkaufswagen)
            {
                good.Accept(visitor);
            }
            MessageBox.Show(visitor.ResultString);
        }

        private void BtnKasClicked(object sender, RoutedEventArgs e)
        {
            var visitor = new KasseVisitor();
            foreach (var good in Einkaufskorb)
            {
                good.Accept(visitor);
            }
            foreach (var good in Einkaufswagen)
            {
                good.Accept(visitor);
            }
            MessageBox.Show(visitor.ResultString);
        }

        private void BtnHTMClicked(object sender, RoutedEventArgs e)
        {
            var visitor = new HTMLVisitor();
            foreach (var good in Einkaufskorb)
            {
                good.Accept(visitor);
            }
            foreach (var good in Einkaufswagen)
            {
                good.Accept(visitor);
            }
            MessageBox.Show(visitor.ResultString);
        }

        private void BtnWagClicked(object sender, RoutedEventArgs e)
        {
            var visitor = new WaggeVisitor();
            foreach (var good in Einkaufskorb)
            {
                good.Accept(visitor);
            }
            foreach (var good in Einkaufswagen)
            {
                good.Accept(visitor);
            }
            MessageBox.Show(visitor.ResultString);
        }
    }
}