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

namespace KusrGalimulin.windows
{
    
    /// <summary>
    /// Логика взаимодействия для ServiceWidnow.xaml
    /// </summary>
    public partial class ServiceWidnow : Window
    {
        public ServiceWidnow()
        {
            InitializeComponent();
            this.DataContext = this;
            ServiceList = Core1.DB.Service.ToList();
        }
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
        private List<Service> _ServiceList;

        public List<Service> ServiceList
        {
            get
            {

                return _ServiceList;


            }
            set
            {
                _ServiceList = value;

            }
        }
    }
}
