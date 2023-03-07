namespace Wrapper
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        rainDrop drop;
        Graphics g;
        public Form1()
        {
            g = this.CreateGraphics();
            InitializeComponent();
            g = this.CreateGraphics();
            comboBox1.Items.Add("raindrop");
            comboBox1.Items.Add("First");
            comboBox1.Items.Add("Scnd");
            comboBox1.Items.Add("Thrd");
            comboBox2.Items.Add("gravity");
            comboBox2.Items.Add("line");
            comboBox2.Items.Add("sin");
            comboBox2.Items.Add("cos");
            drop = new rainDrop(new Point(random.Next(20, this.Width-32), 0));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 1:
                    drop=new FirstDrop(drop);
                    break;
                case 2:
                    drop = new ScndDrop(drop);
                    break;
                case 3:
                    drop = new ThrdDrop(drop);
                    break;
                default:break;
            }
            switch (comboBox2.SelectedIndex)
            {
                case 1: 
                    drop = new dropsline(drop);
                    break;
                case 2:
                    drop = new sinDrop(drop);
                    break;
                case 3:
                    drop = new cosDrop(drop);
                    break;
                default: break;
            }
            int a;
            a = 10;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.DrawImage(drop.pic, new Rectangle(drop.get_pos().X, drop.get_pos().Y, 20, 20));

            if (drop.pos.Y >= this.Height - 68) { drop.pos.Y =0; g.Clear(Color.White);drop.pos.X = random.Next(20, this.Width - 32); }
            else drop.pos.Y += 5;
        }
    }
}