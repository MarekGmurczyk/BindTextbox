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
using BindTextbox.ModelView;
namespace BindTextbox
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ModifiedText m = new ModifiedText();
        public MainWindow()
        {
            InitializeComponent();
            PassText = myBindedText_Write.Text;
            DataContext = this;
        }

        public string PassText
        {
            get
            {
                return m.TextFromModel;
            }
            set
            {
                m.TextFromModel = value;
            }
        }
    }
}
