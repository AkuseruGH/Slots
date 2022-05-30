namespace WinFormsAppSlots
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int times;
        int a, b, c;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            button_play.Image = Properties.Resources.slots_button21;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            times++;
            if (times < 30)
            {
                a = rnd.Next(5);
                b = rnd.Next(5);
                c = rnd.Next(5);

                switch (a)
                {
                    case 1:
                        a_box.Image = Properties.Resources.cherry;
                        break;
                    case 2:
                        a_box.Image = Properties.Resources.grape;
                        break;
                    case 3:
                        a_box.Image = Properties.Resources.lemon;
                        break;

                }
                switch (b)
                {
                    case 1:
                        b_box.Image = Properties.Resources.cherry;
                        break;
                    case 2:
                        b_box.Image = Properties.Resources.grape;
                        break;
                    case 3:
                        b_box.Image = Properties.Resources.lemon;
                        break;

                }
                switch (c)
                {
                    case 1:
                        c_box.Image = Properties.Resources.cherry;
                        break;
                    case 2:
                        c_box.Image = Properties.Resources.grape;
                        break;
                    case 3:
                        c_box.Image = Properties.Resources.lemon;
                        break;

                }
            }
            else
            {
                timer1.Enabled = false;
                times = 0;
                button_play.Image = Properties.Resources.slots_button;
            }
        }
    }
}