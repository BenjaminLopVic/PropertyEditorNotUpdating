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

namespace PropertyEditorNotUpdating
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            EventTriggerer = new EventTriggerer();
            DataFactory = new CustomDataFactory(EventTriggerer);
            TestDataObject = new TestVM();
            InitializeComponent();
        }

        public EventTriggerer EventTriggerer { get; }
        public CustomDataFactory DataFactory { get; }
        public TestVM TestDataObject { get; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EventTriggerer.Trigger();
        }
    }
}
