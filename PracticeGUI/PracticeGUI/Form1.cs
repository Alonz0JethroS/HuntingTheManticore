namespace PracticeGUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private int num = 0;

        private void addButton_Click(object sender, EventArgs e)
        {
            
            num++;
            displayNumLabel.TextAlign = ContentAlignment.MiddleCenter;
            displayNumLabel.Text = num.ToString();
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            num--;
            displayNumLabel.TextAlign = ContentAlignment.MiddleCenter;
            displayNumLabel.Text = num.ToString();
        }


        private void clearButton_Click(object sender, EventArgs e)
        {   num = 0;
            displayNumLabel.TextAlign = ContentAlignment.MiddleCenter;
            displayNumLabel.Text = num.ToString(); 
        }
        private void multiplyButton_Click(object sender, EventArgs e)
        {
            num *= 2;
            displayNumLabel.TextAlign = ContentAlignment.MiddleCenter;
            displayNumLabel.Text = num.ToString();
        }
        private void divideButton_Click(object sender, EventArgs e)
        {
            num /= 2;
            displayNumLabel.TextAlign = ContentAlignment.MiddleCenter;
            displayNumLabel.Text = num.ToString();
        }
        private void undoButton_Click(object sender, EventArgs e)
        {

        }

        private void displayNumLabel_Click(object sender, EventArgs e)
        {


        }


    }
}