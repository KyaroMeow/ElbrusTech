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
            try
            {
                Methods methods = new Methods();
                methods.GenereticEmployees(10);
				MessageBox.Show("все хорошо");
			}
            catch
            {
				MessageBox.Show("ВСЕ ПЛОХО");
			}

        }

		private void Form1_Load(object sender, System.EventArgs e)
		{

		}
	}
}
