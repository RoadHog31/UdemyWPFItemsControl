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

namespace UdemyWPFItemsControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            GetToDoItems();
        }

        private void GetToDoItems()
        {
            List<TODoItem> todoItems = new List<TODoItem>();
            todoItems.Add(new TODoItem() {ItemCompletion = 0, ItemName = "Something"});
            todoItems.Add(new TODoItem() {ItemCompletion = 20, ItemName = "Something else"});
            todoItems.Add(new TODoItem() {ItemCompletion = 40, ItemName = "Something more"});
            todoItems.Add(new TODoItem() {ItemCompletion = 100, ItemName = "Done!"});

            itemsControlToDo.ItemsSource = todoItems;
        }

        public class TODoItem
        {
            public string ItemName { get; set; }
            public int ItemCompletion { get; set; }

            public override string ToString()
            {
                return string.Format("{0}: {1}% completed.", ItemName, ItemCompletion);
            }
        }

        
    }
        
}
