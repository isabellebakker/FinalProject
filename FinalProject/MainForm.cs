using FinalProject.Final;

namespace FinalProject
{
    public partial class MainForm : Form
    {
        Headgear Headgear = new Headgear();
        Shirt Shirt = new Shirt();
        Shoes Shoes = new Shoes();

        Weapon Splattershot = new Weapon("Splattershot", "Suction Bomb", 200);

        public MainForm()
        {
            InitializeComponent();
        }

        public void mainFormLoad(object sender, EventArgs e)
        {
            headgearMainDropdown.SelectedIndex = 0;
            headgearSub1Dropdown.SelectedIndex = 0;
            headgearSub2Dropdown.SelectedIndex = 0;
            headgearSub3Dropdown.SelectedIndex = 0;
            shirtMainDropdown.SelectedIndex = 0;
            shirtSub1Dropdown.SelectedIndex = 0;
            shirtSub2Dropdown.SelectedIndex = 0;
            shirtSub3Dropdown.SelectedIndex = 0;
            shoesMainDropdown.SelectedIndex = 0;
            shoesSub1Dropdown.SelectedIndex = 0;
            shoesSub2Dropdown.SelectedIndex = 0;
            shoesSub3Dropdown.SelectedIndex = 0;
        }

        public void buttonCalc_Click(object sender, EventArgs e)
        {

            Headgear.Main = headgearMainDropdown.Items[headgearMainDropdown.SelectedIndex].ToString();
            Headgear.Sub1 = headgearSub1Dropdown.Items[headgearSub1Dropdown.SelectedIndex].ToString();
            Headgear.Sub2 = headgearSub2Dropdown.Items[headgearSub2Dropdown.SelectedIndex].ToString();
            Headgear.Sub3 = headgearSub3Dropdown.Items[headgearSub3Dropdown.SelectedIndex].ToString();

            Shirt.Main = shirtMainDropdown.Items[shirtMainDropdown.SelectedIndex].ToString();
            Shirt.Sub1 = shirtSub1Dropdown.Items[shirtSub1Dropdown.SelectedIndex].ToString();
            Shirt.Sub2 = shirtSub2Dropdown.Items[shirtSub2Dropdown.SelectedIndex].ToString();
            Shirt.Sub3 = shirtSub3Dropdown.Items[shirtSub3Dropdown.SelectedIndex].ToString();

            Shoes.Main = shoesMainDropdown.Items[shoesMainDropdown.SelectedIndex].ToString();
            Shoes.Sub1 = shoesSub1Dropdown.Items[shoesSub1Dropdown.SelectedIndex].ToString();
            Shoes.Sub2 = shoesSub2Dropdown.Items[shoesSub2Dropdown.SelectedIndex].ToString();
            Shoes.Sub3 = shoesSub3Dropdown.Items[shoesSub3Dropdown.SelectedIndex].ToString();

            textBoxOutput.Text = Headgear.Main;
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void headgearSub3Dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}