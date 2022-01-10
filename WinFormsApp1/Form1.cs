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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double seconds = double.Parse(textBox1.Text);
            double minutes;
            double hours;
            double days;
            
                if (seconds >= 60 && seconds < 3600)
                {
                minutes = seconds / 60;
                
                MessageBox.Show("The Converted Seconds is " +minutes+ " Minutes");

                }
                if (seconds >= 3600 && seconds < 86400)
                {
                hours = seconds / 3600;
                minutes = seconds / 60;
                MessageBox.Show("The Converted Seconds is " +hours+ " Hours ");

                }
                if (seconds >= 86400)
                {
                hours = seconds / 3600;
                minutes = seconds / 60;
                days = seconds / 86400;
                MessageBox.Show("The Converted Seconds is " +days+  " Days ");

                }
                if (seconds < 60)
                {
                MessageBox.Show("No Conversion needed " +seconds+ " Seconds");
                }
            
            
                    
                    
           


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double Text; 
            if (double.TryParse(textBox1.Text, out Text)) 
            {                }
            else 
            {MessageBox.Show("Enter a valid double.");
            }

        }
    }
}