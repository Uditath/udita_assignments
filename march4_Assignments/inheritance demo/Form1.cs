namespace inheritance_demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        // global section
        class Father
        {
               public void maruthicar()
            {
                MessageBox.Show("Maruthi Car");
            }
        }

        class Son : Father
        {
            public void bmwcar()
            {
                MessageBox.Show("BMW Car");
            }
        }
        class GrandSon : Son
        {
            public void audiCar()
            {
                MessageBox.Show("Audi Car");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GrandSon gs = new GrandSon();
            gs.maruthicar();
            gs.bmwcar();
            gs.audiCar();

            //son can access all the cars


        }
    }
}
