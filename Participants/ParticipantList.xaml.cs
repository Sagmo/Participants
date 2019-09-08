using System;
using System.Collections.Generic;
using System.IO;
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

namespace Participants
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ParticipantList : Window
    {

        List<Student> students = new List<Student>();

        public ParticipantList()
        {
            InitializeComponent();
        }


        public void Window_Loaded(object sender, RoutedEventArgs e)
        {
           FileStream fs = null;
           StreamReader sr = null;

           try
           {
               fs = new FileStream(@"..\..\..\deltagerliste.csv", FileMode.Open, FileAccess.Read);
               sr = new StreamReader(fs);

               string str;
               string[] tokens;
               char[] seperators = {';'};

               List<string> lines = new List<string>();
               string nextLine = "";
               Student student; 

               str = str.ReadLine();

           }
           catch (Exception ex)
           {
                MessageBox.Show(ex.Message, "Error");

           }

        }
    }
}
