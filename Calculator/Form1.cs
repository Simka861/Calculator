namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            if (label1.Text == "00")
            {
                label1.Text = B.Text;
            }
            else { label1.Text = label1.Text + B.Text; }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label1.Text = "00";
        }

        double Number1 = 0, Number2 = 0, Num3 = 0;
        char znak = '+';

        private void button20_Click(object sender, EventArgs e)
        {
            Number2 = Convert.ToDouble(label1.Text);
            if (znak == '+')
            {
                Num3 = Number1 + Number2;
            }
            else if (znak == '-')
            {
                Num3 = Number1 - Number2;
            }
            else if (znak == '/')
            {
                Num3 = Number1 / Number2;
            }
            else if (znak == '*')
            {
                Num3 = Number1 * Number2;
            }
            else if (znak == '%')
            {
                Num3 = (Number1 /100 )* Number2;
            }
            
                label2.Text +=" "+ Number2 + " = " + Num3;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (label1.Text[0] == '-')
            {
                label1.Text = label1.Text.Remove(0, 1);
            }
            else { label1.Text = "-" + label1.Text; }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if(label1.Text != "")
            {
                label1.Text = label1.Text.Remove(label1.Text.Length -1);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            Number1 = Convert.ToDouble(label1.Text);
            Num3 = Number1 * Number1;
            label2.Text = Number1 + "² = " + Num3;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            Number1 = Convert.ToDouble(label1.Text);
            Num3 = Math.Sqrt(Number1);
            label2.Text = "√" + Number1 + " = " + Num3;
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            Number1 = Convert.ToDouble(label1.Text);
            znak = B.Text[0];
            label2.Text = Number1 + " " + znak ;
            label1.Text = "00";
        }
    }
}