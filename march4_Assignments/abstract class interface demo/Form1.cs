namespace abstract_class_interface_demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public abstract class polygon
        {
           public void testfunction()
            {
                MessageBox.Show("This is test function");
            }
            public abstract void area(int x, int y);
        }

        class triangle : polygon
        {
            public override void area(int x, int y)
            {
                MessageBox.Show("Area of triangle is :" + (0.5 * x * y));
            }
        }

        class square : polygon
        {
            public override void area(int x, int y)
            {
                MessageBox.Show("Area of square is :" + (x * x));
            }
        }
        interface A{
            void area(int x, int y) ;

            //public int age { set; get; }


        }
        class rectangle:polygon
        {
            public override void area(int x, int y)
            {
                MessageBox.Show("Area of rectangle is :" + (x * y));
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            polygon obj;

            obj= new triangle();    
            obj.area(10, 20);

            obj= new rectangle();
            obj.area(10, 20);

            obj= new square();
            obj.area(10, 20);

            obj.testfunction();
        }
    }
}
