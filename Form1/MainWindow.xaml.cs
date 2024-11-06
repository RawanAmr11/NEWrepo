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

namespace Form1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Page
    {
        CompanyEntities db = new CompanyEntities();
        public MainWindow()
        {
            InitializeComponent();
            listDG.ItemsSource = db.Employes.ToList();
        }

        private void Insert(object sender, RoutedEventArgs e)
        {
            Employe rec = new Employe();
            rec.empname = ntxt.Text;
            rec.posstion = ptxt.Text;
            db.Employes.Add(rec);
            db.SaveChanges();

            
        }

        private void Refresh(object sender, RoutedEventArgs e)
        {
            listDG.ItemsSource = db.Employes.ToList();
        }
    }
}
