using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PersonalityQuiz
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            QuestionStart();
        }

        int convict = 0;
        int hunter = 0;
        int marine = 0;
        int pilot = 0;
        bool trueOrFalse;
        int questionNum;

        //void ShowQuestions(object sender, System.EventArgs e)
        //{
        //    Question1(sender, e);
        //    maybe not
        //}


        void Score(object sender, System.EventArgs e, bool tf)
        {
            switch (questionNum)
            {
                case 1:
                    Question1(sender, e, trueOrFalse);
                    break;
                case 2:
                    Question2(sender, e, trueOrFalse);
                    break;
                case 3:
                    Question3(sender, e, trueOrFalse);
                    break;
                case 4:
                    Question4(sender, e, trueOrFalse);
                    break;
                case 5:
                    Question5(sender, e, trueOrFalse);
                    break;
                case 6:
                    Question6(sender, e, trueOrFalse);
                    break;
                case 7:
                    Question7(sender, e, trueOrFalse);
                    break;
                case 8:
                    //find result
                    question.Text = "";
                    break;

            }
        }
        void ClickedTrue(object sender, System.EventArgs e)
        {
            trueOrFalse = true;

            
        }

        void ClickedFalse(object sender, System.EventArgs e)
        {
            trueOrFalse = false;

        }

        void QuestionStart()
        {
            question.Text = "I get angry easily.";
        }

        void Question1(object sender, System.EventArgs e, bool b)
        {
            if (b == true)
            {
                convict++;
            }
        }

        void Question2(object sender, System.EventArgs e, bool b)
        {
            question.Text = "I'd rather think an action through first than to do it first.";
            //marine hunter not convict
            if (b == true)
            {
                marine++;
                hunter++;
            }
            else
            {
                convict--;
            }
        }

        void Question3(object sender, System.EventArgs e, bool b)
        {
            question.Text = "I always want free stuff.";
            //convict pilot not marine
            if (b == true)
            {
                convict++;
                pilot++;

            }
            else
            {
                marine--;
            }
        }

        void Question4(object sender, System.EventArgs e, bool b)
        {
            question.Text = "I love dogs.";
            //hunter
            if (b == true)
            {
                hunter++;
            }
            
        }

        void Question5(object sender, System.EventArgs e, bool b)
        {
            question.Text = "I like it when things are unpredictable.";
            //marine pilot 
            if (b == true)
            {
                marine++;
                pilot++;
            }
          
        }

        void Question6(object sender, System.EventArgs e, bool b)
        {
            question.Text = "I care about my hairdue a lot.";
            //pilot not marine or convict
            if (b == true)
            {
                pilot++;
            }
            else
            {
                marine--;
                convict--;
            }
        }

        void Question7(object sender, System.EventArgs e, bool b)
        {
            question.Text = "I have used a bow and arrow before.";
            //hunter not pilot or convict
            if (b == true)
            {
                hunter++;
            }
            else
            {
                pilot--;
                convict--;
            }
        }

        void ShowResults()
        {
            int win;
            win = (Math.Max(Math.Max(Math.Max(hunter, marine), pilot), convict));
            if (win == pilot)
            {
                question.Text = "You are the Pilot!";
            } else if (win == hunter)
            {
                question.Text = "You are the Hunter!";
            } else if (win == marine)
            {
                question.Text = "You are the Marine!";
            } else if (win == convict)
            {
                question.Text = "You are the Convict!";
            }
        }
        //void Question8(object sender, System.EventArgs e)
        //{
        //    question.Text = "";
        //}
    }
}
