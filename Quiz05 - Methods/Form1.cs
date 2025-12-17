namespace Quiz05___Methods
{

    //Alex Spicer
    //2025-12-17
    //Quiz 05

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
        }

        private void bonusButton_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.Show();
        }

        private void q1Button_Click(object sender, EventArgs e)
        {
            Random randNum = new Random(); //Creates a random
            int outputNum = randNum.Next(1, 11); //Creates an int that is a random number between 1 and 10
            outputLabel.Text = outputNum.ToString(); //Outputs the number
        }

        private void q2Button_Click(object sender, EventArgs e)
        {
            productNumber(); //calls productNumber
        }

        private void productNumber()
        {
            int totalNum = 1; //the total as an integer
            int addedNum = 1; // the next number you need to add as an integer

            while (addedNum <= 10) //While loop that runs as long as the added number is 10 or below
            {
                totalNum = totalNum * addedNum; //multiplies the current total number by the added number
                addedNum++; //adds one onto the added number
            }
            outputLabel.Text = totalNum.ToString(); //Outputs the total number as a string
        }

        private void q3Button_Click(object sender, EventArgs e)
        {
            double firstNum = Convert.ToDouble(aTextBox.Text); //Makes the first number a double
            double secondNum = Convert.ToDouble(bTextBox.Text); //Makes the second number a double

            pythTheorem(firstNum,secondNum); //Calls on the method
        }

        private void pythTheorem(double a, double b)
        {
            double c = (a * a) + (b * b); //Gets c squared
            double answer = Math.Pow(c, 0.5); //Gets the square root

            outputLabel.Text = answer.ToString(); //Outputs c
        }
    }
}
