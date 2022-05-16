namespace MidtermProject
{
    public partial class Form1 : Form
    {

        public string competitorAnswer;
        public string correctAnswer;
        List<Question> questions = new List<Question>();
        public int askedQuestionNumber = 0;
        public int score = 0;
        public int questionId = 0;
        Random random = new Random();



        public List<Question> populateData()
        {
            List<Question> data = new List<Question>();

            Question question = new Question
            {
                Desc = "Which Disney character famously leaves a glass slipper behind at a royal ball?",
                AnswerA = "Pocahontas",
                AnswerB = "Sleeping Beauty",
                AnswerC = "Cinderella",
                AnswerD = "Elsa",
                CorrectAnswer = "Cinderella"
            };
            data.Add(question);

            Question question2 = new Question
            {
                Desc = "What name is given to the revolving belt machinery in an airport that delivers checked luggage from the plane to baggage reclaim?",
                AnswerA = "Carousel",
                AnswerB = "Hangar",
                AnswerC = "Terminal",
                AnswerD = "Concourse",
                CorrectAnswer = "Carousel"
            };
            data.Add(question2);

            Question question3 = new Question
            {
                Desc = "The hammer and sickle is one of the most recognisable symbols of which political ideology?",
                AnswerA = "Republicanism",
                AnswerB = "Liberalism",
                AnswerC = "Conservatism",
                AnswerD = "Communism",
                CorrectAnswer = "Communism"
            };
            data.Add(question3);

            Question question4 = new Question
            {
                Desc = "Which toys have been marketed with the phrase “robots in disguise”?",
                AnswerA = "Transformers",
                AnswerB = "Bratz Dolls",
                AnswerC = "Sylvanian Families",
                AnswerD = "Hatchimals",
                CorrectAnswer = "Transformers"
            };
            data.Add(question4);

            Question question5 = new Question
            {
                Desc = "What does the word loquacious mean",
                AnswerA = "Angry",
                AnswerB = "Chatty",
                AnswerC = "Beautiful",
                AnswerD = "Shy",
                CorrectAnswer = "Chatty"
            };
            data.Add(question5);

            Question question6 = new Question
            {
                Desc = "A person with well-developed abdominal muscles is said to have a what",
                AnswerA = "Family-pack",
                AnswerB = "12-pack",
                AnswerC = "Six-pack",
                AnswerD = "One-pack",
                CorrectAnswer = "Six-pack"
            };
            data.Add(question6);

            Question question7 = new Question
            {
                Desc = "Which two words traditionally appear onscreen at the termination of a feature film?",
                AnswerA = "The Finish",
                AnswerB = "The End",
                AnswerC = "The Conclusion",
                AnswerD = "The Pizza Rolls Are Done",
                CorrectAnswer = "The End"
            };
            data.Add(question7);

            Question question8 = new Question
            {
                Desc = "A magnet would most likely attract which of the following?",
                AnswerA = "Plastic",
                AnswerB = "The wrong man",
                AnswerC = "Metal",
                AnswerD = "Wood",
                CorrectAnswer = "Metal"
            };
            data.Add(question8);

            Question question9 = new Question
            {
                Desc = "Which of these names is not in the title of a Shakespeare play?",
                AnswerA = "Macbeth",
                AnswerB = "Hamlet",
                AnswerC = "Darren",
                AnswerD = "Romeo",
                CorrectAnswer = "Darren"
            };
            data.Add(question9);

            Question question10 = new Question
            {
                Desc = "Where did Scotch whisky originate?",
                AnswerA = "The United States",
                AnswerB = "Cyprus",
                AnswerC = "Wales",
                AnswerD = "Scotland",
                CorrectAnswer = "Scotland"
            };
            data.Add(question10);

            Question question11 = new Question
            {
                Desc = "What name is traditionally given to the party held for a woman who is expecting a baby?",
                AnswerA = "Baby Shower",
                AnswerB = "Baby drizzle",
                AnswerC = "Baby downpour",
                AnswerD = "Baby deluge",
                CorrectAnswer = "Baby Shower"
            };
            data.Add(question11);

            Question question12 = new Question
            {
                Desc = "In fancy hotels, it is traditional for what tantalizing treat to be left on your pillow?",
                AnswerA = "A pretzel",
                AnswerB = "An Apple",
                AnswerC = "A mint",
                AnswerD = "A photo of Wolf Blitzer",
                CorrectAnswer = "A mint"
            };
            data.Add(question12);

            Question question13 = new Question
            {
                Desc = "In the United States, what is traditionally the proper way to address a judge?",
                AnswerA = "You Da man!",
                AnswerB = "Your Honor",
                AnswerC = "Your Holiness",
                AnswerD = "Your Eminence",
                CorrectAnswer = "Your Honor"
            };
            data.Add(question13);

            Question question14 = new Question
            {
                Desc = "Which of these pairs of apps offers roughly the same type of service?",
                AnswerA = "Snapchat and Grubhub",
                AnswerB = "Whatsapp and SHAREit",
                AnswerC = "Tiktok and Spotify",
                AnswerD = "Lyft and Uber",
                CorrectAnswer = "Lyft and Uber"
            };
            data.Add(question14);

            Question question15 = new Question
            {
                Desc = "The popular children's song 'It's Raining, It's Pouring' mentions an 'old man' doing what?",
                AnswerA = "Snoring",
                AnswerB = "Cooking",
                AnswerC = "Tiktok and Spotify",
                AnswerD = "Yelling at squirrels",
                CorrectAnswer = "Snoring"
            };
            data.Add(question15);

            Question question16 = new Question
            {
                Desc = "At a restaurant, someone who 'foots the bill' does what?",
                AnswerA = "Pays it",
                AnswerB = "Kisses it",
                AnswerC = "Rips it up",
                AnswerD = "Hopes to get lucky",
                CorrectAnswer = "Pays it"
            };
            data.Add(question16);

            Question question17 = new Question
            {
                Desc = "In which of these films does Whoopi Goldberg dress up as a nun?",
                AnswerA = "Ghost",
                AnswerB = "Sister Act",
                AnswerC = "The Color Purple",
                AnswerD = "How Judas Got His Groove Bacl",
                CorrectAnswer = "Sister Act"
            };
            data.Add(question17);

            Question question18 = new Question
            {
                Desc = "If someone asked to see your ID, what might you show them?",
                AnswerA = "Your tongue",
                AnswerB = "Your teeth",
                AnswerC = "Your Passport",
                AnswerD = "The Door",
                CorrectAnswer = "Your Passport"
            };
            data.Add(question18);

            Question question19 = new Question
            {
                Desc = "According to a common phrase, a person who takes chances is 'going out on a' what?",
                AnswerA = "Limb",
                AnswerB = "Horse",
                AnswerC = "Nude Beach",
                AnswerD = "Skateboard",
                CorrectAnswer = "Limb"
            };
            data.Add(question19);

            Question question20 = new Question
            {
                Desc = "Due to the geographical areas they represented, the opposing sides of the US Civil War were known by what names?",
                AnswerA = "The Hills and the Valleys",
                AnswerB = "The Kool and the Gang",
                AnswerC = "The Cities and the Farms",
                AnswerD = "The North and the South",
                CorrectAnswer = "The North and the South"
            };
            data.Add(question20);

            Question question21 = new Question
            {
                Desc = "According to the old saying, 'love of' what 'is the root of all evil'?",
                AnswerA = "Food",
                AnswerB = "Clothing",
                AnswerC = "Money",
                AnswerD = "Reality television",
                CorrectAnswer = "Money"
            };
            data.Add(question21);

            Question question22 = new Question
            {
                Desc = "A geologist would likely be LEAST helpful for answering questions about which of the following?",
                AnswerA = "Granite boulders",
                AnswerB = "Precious stones",
                AnswerC = "Igneous rocks",
                AnswerD = "Fruity Pebbles",
                CorrectAnswer = "Fruity Pebbles"
            };
            data.Add(question22);

            Question question23 = new Question
            {
                Desc = "A feisty train is the hero of a classic children's book titled The Little Engine That what?",
                AnswerA = "Ran",
                AnswerB = "Cried",
                AnswerC = "Could",
                AnswerD = "Opened a can of whupass",
                CorrectAnswer = "Could"
            };
            data.Add(question23);

            Question question24 = new Question
            {
                Desc = "A person who is not a banker and lends money at an extremely high interest rate is known as what?",
                AnswerA = "Loan shark",
                AnswerB = "Green snake",
                AnswerC = "Paper tiger",
                AnswerD = "Brother-in-law",
                CorrectAnswer = "Loan shark"
            };
            data.Add(question24);

            Question question25 = new Question
            {
                Desc = "A well-known lyric in the holiday song 'Silver Bells' promises that 'soon it will be' what?",
                AnswerA = "July 4th weekend",
                AnswerB = "Halloween night",
                AnswerC = "Christmas Day",
                AnswerD = "National Burrito Month",
                CorrectAnswer = "Christmas Day"
            };
            data.Add(question25);

            Question question26 = new Question
            {
                Desc = "When a person is rudely ignored, he is said to be getting what?",
                AnswerA = "Hot knee",
                AnswerB = "Warm toe",
                AnswerC = "Cold shoulder",
                AnswerD = "His car fixed",
                CorrectAnswer = "Cold shoulder"
            };

            data.Add(question26);


            Question question27 = new Question
            {
                Desc = "A common piece of advice goes, 'Be there or be' what?",
                AnswerA = "Bare",
                AnswerB = "Square",
                AnswerC = "Aware",
                AnswerD = "All alone as usual",
                CorrectAnswer = "Square"
            };
            data.Add(question27);


            return data;
        }







        public Form1()
        {
            InitializeComponent();

            questionLabel.BackColor = Color.FromArgb(34, 26, 53);
            questionLabel.ForeColor = Color.FromArgb(255, 215, 94);
            answerA.BackColor = Color.FromArgb(34, 26, 53);
            answerA.ForeColor = Color.FromArgb(255, 215, 94);
            answerB.BackColor = Color.FromArgb(34, 26, 53);
            answerB.ForeColor = Color.FromArgb(255, 215, 94);
            answerC.BackColor = Color.FromArgb(34, 26, 53);
            answerC.ForeColor = Color.FromArgb(255, 215, 94);
            answerD.BackColor = Color.FromArgb(34, 26, 53);
            answerD.ForeColor = Color.FromArgb(255, 215, 94);

            questions = populateData();
            questionId = random.Next(questions.Count);
            questionLabel.Text = questions.ElementAt(questionId).Desc;
            answerA.Text = questions.ElementAt(questionId).AnswerA;
            answerB.Text = questions.ElementAt(questionId).AnswerB;
            answerC.Text = questions.ElementAt(questionId).AnswerC;
            answerD.Text = questions[questionId].AnswerD;
            correctAnswer = questions[questionId].CorrectAnswer;


        }





        private void Answer_Click(object sender, EventArgs e)
        {
            if (askedQuestionNumber == 10)
            {
                MessageBox.Show("The Game is finished You get score of:" + score);

            }
            else
            {

                if (competitorAnswer == correctAnswer)
                {
                    MessageBox.Show("Correct Answer Keep Going");
                    score = score + 10;
                }
                else

                    MessageBox.Show("Incorrect Answer");

                questionId = random.Next(questions.Count);
                questionLabel.Text = questions.ElementAt(questionId).Desc;
                answerA.Text = questions.ElementAt(questionId).AnswerA;
                answerB.Text = questions.ElementAt(questionId).AnswerB;
                answerC.Text = questions.ElementAt(questionId).AnswerC;
                answerD.Text = questions[questionId].AnswerD;
                correctAnswer = questions[questionId].CorrectAnswer;
                askedQuestionNumber++;
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

        private void questionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}