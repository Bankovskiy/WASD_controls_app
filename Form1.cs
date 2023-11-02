namespace WASD_controls_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hero_Click(object sender, EventArgs e)
        {
            int speed = 30;
            hero.Left += speed;
            hero.Top += speed;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show($"You have pressed {e.KeyChar}");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.A)
            {
                hero.Left -= 10;
            }
            else if (e.KeyCode == Keys.D)
            {
                hero.Left += 10;
            }
            else if(e.KeyCode == Keys.W)
            {
                hero.Top -= 10;
            }
            else if(e.KeyCode == Keys.S)
            {
                hero.Top += 10;
            }
        }
    }
}