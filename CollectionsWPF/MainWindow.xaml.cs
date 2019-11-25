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
using CollectionsWPF.Hero;

namespace CollectionsWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitHeroes();
        }

        private void InitHeroes()
        {
            //List<ListViewItem> items = new List<ListViewItem>()
            //{
            //    new ListViewItem()
            //    {
            //        Content="Семен"
            //    },
            //    new ListViewItem()
            //    {
            //        Content="Петро"
            //    },
            //    new ListViewItem()
            //    {
            //        Content="Оксана"
            //    },
            //};

            List<Hero.Hero> items = new List<Hero.Hero>()
            {
                new Hero.Hero()
                {
                    Id=1,
                    Name="Семен"
                },
                new Hero.Hero()
                {
                    Id=2,
                    Name="Маг"
                }
            };

            foreach (var item in items)
            {
                lvHeroes.Items.Add(item);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void lvHeroes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show(((Hero.Hero)lvHeroes.SelectedItems[0]).Id.ToString());
        }
    }
}
