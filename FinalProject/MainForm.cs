using FinalProject.Final;

namespace FinalProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void mainFormLoad(object sender, EventArgs e)
        {
            Weapon Splattershot = new Weapon("Splattershot", "Suction Bomb", 200);

            textBoxOutput.Text = Splattershot.SubWeapon;
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}