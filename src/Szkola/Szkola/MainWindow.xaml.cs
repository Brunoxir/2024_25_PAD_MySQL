using MySql.Data.MySqlClient;
using System.Data;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace Szkola
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void pobierzDane()
        { 
            string mojePol =
                "SERVER=" + nazwaServeratb.Text + ";" +
                "DATABASE=" + nazwaBazyDanychtb.Text + ";" +
                "UID=" + uzytkowniktb.Text + ";" +
                "PASSWORD=" + haslotb.Password + ";";

            string sql = "SELECT * FROM uczniowie";

            using (MySqlConnection polaczenie = new MySqlConnection(mojePol))
            {
                try
                {
                   using (MySqlCommand  cmdSel = new MySqlCommand(sql, polaczenie))
                    {
                        DataTable dt = new DataTable();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmdSel);
                        da.Fill(dt);
                        dataGrid1.ItemsSource = dt.DefaultView;
                    }

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Błąd podczas połączenia z bazą: " + ex.Message, "ERROR!!!!!!!!!!!!!!");
                }
            }
        }
        private void logowanieBtn_Click(object sender, RoutedEventArgs e)
        {
            pobierzDane();
        }
    }
}