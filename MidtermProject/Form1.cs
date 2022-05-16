namespace MidtermProject
{
    public partial class Form1 : Form
    {

        public string competitorAnswer;
        public string correctAnswer;
        public int askedQuestionNumber = 0;
        public int score = 0;
        public int questionId = 0;
        


        

        




        public Form1()
        {
            InitializeComponent();


        }





        private void Answer_Click(object sender, EventArgs e)
        {
            if(askedQuestionNumber == 10)
            {
                MessageBox.Show("The Game is finished You get score of: " + score);

            }
            else { 

            if (competitorAnswer == correctAnswer)
            {
                MessageBox.Show("Correct Answer Keep Going");
                score = score + 10;
            }
            else
                
                MessageBox.Show("Incorrect Answer");
           
            }
        }

        private void answerA_CheckedChanged(object sender, EventArgs e)
        {
            competitorAnswer = answerA.Text;
        }

        private void answerB_CheckedChanged(object sender, EventArgs e)
        {
            competitorAnswer=answerB.Text;
        }

        private void answerC_CheckedChanged(object sender, EventArgs e)
        {
            competitorAnswer = answerC.Text;
        }

        private void answerD_CheckedChanged(object sender, EventArgs e)
        {
            competitorAnswer = answerD.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}