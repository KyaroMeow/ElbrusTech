using System.Windows.Forms;
using LibraryForET;
namespace ElbrusTech
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Methods methods = new Methods();
            try
            {
                methods.GenereticEmployees(3);
                MessageBox.Show("все хорошо");
            }
            catch
            {
                MessageBox.Show("все полхо");
            }
        }
    }
}
