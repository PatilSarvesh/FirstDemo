using SimpleMathLibrary;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                int fno = int.Parse(textBox1.Text);
                int sno = int.Parse(textBox2.Text);

                
                    SimpleMath sm = new SimpleMath();
                    int total = sm.Sum(fno, sno);
                    MessageBox.Show($"Additio of {fno} and {sno} is {total}");
                
                
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Enter Only Numbers");
            }
            catch(OverflowException ex)
            {
                MessageBox.Show("Enter Snall numver");
            }
            catch(InvalidEvenNumberException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}