using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
namespace Tinder
{
    public partial class Form1 : Form
    {
        private int page = 1;
        private bool maleButtonWasClicked = false;
        private bool femaleButtonWasPressed = false;
        Random randGen = new Random();

        public Form1()
        {
            InitializeComponent();
            HideAllControls();
        }

        private void sleep()
        {
            SoundPlayer noti = new SoundPlayer(Properties.Resources.Notification);
            noti.Play();
            this.Refresh();
            Thread.Sleep(1000);
        }
        private void femaleButton_Click(object sender, EventArgs e)
        {
            femaleButtonWasPressed = true;
        }

        private void maleButton_Click(object sender, EventArgs e)
        {
            maleButtonWasClicked = true;

        }
        private void HideAllControls()
        {
            nameLabel.Visible = false;
            birthLabel.Visible = false;
            genderLabel.Visible = false;
            nameInput.Visible = false;
            birthdayInput.Visible = false;
            birthMonthInput.Visible = false;
            birthYearInput.Visible = false;
            maleButton.Visible = false;
            femaleButton.Visible = false;
            option1.Visible = false;
            option2.Visible = false;
            mainLabel.Visible = false;
            modelPicture.Visible = false;
            option1Label.Visible = false;
            option2Label.Visible = false;
            option3Label.Visible = false;
            option3.Visible = false;

        }

        private void ShowAllControls()
        {
            nameLabel.Visible = true;
            birthLabel.Visible = true;
            genderLabel.Visible = true;
            nameInput.Visible = true;
            birthdayInput.Visible = true;
            birthMonthInput.Visible = true;
            birthYearInput.Visible = true;
            maleButton.Visible = true;
            femaleButton.Visible = true;
        }

        private void getStartedButton_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                

                try
                {
                    int birthYear = Convert.ToInt16(birthYearInput.Text);
                    int birthday = Convert.ToInt16(birthdayInput.Text);
                    int birthMonth = Convert.ToInt16(birthMonthInput.Text);

                    if ((2024 - birthYear) < 18)
                    {
                        page = 999;
                    }
                    else if (maleButtonWasClicked)
                    {
                        page = 3;
                    }
                    else if (femaleButtonWasPressed)
                    {
                        page = 18;
                    }

                }
                catch (FormatException)
                {
                    String message = "Please enter a valid number";
                    String title = "Error";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, title, buttons);

                }
            }

            pagesSetting();


            
        }

        private void buttonModelSetting()
        {
            mainLabel.BackColor = Color.Transparent;
            option1.Location = new Point(160, 396);
            option2.Location = new Point(24, 396);
            option1.Size = new Size(110, 35);
            option2.Size = new Size(110, 35);
            option1.Text = "Right";
            option2.Text = "Left";
        }

        private void buttonChatSetting()
        {
            mainLabel.BackColor = Color.FloralWhite;
            modelPicture.Visible = false;
            option1Label.Visible = true;
            option2Label.Visible = true;
            option1.Location = new Point(12, 384);
            option2.Location = new Point(12, 434);
            option1.Size = new Size(43, 28);
            option2.Size = new Size(43, 28);
            option1.Text = "A";
            option2.Text = "B";
            
        }
        private void page1()
        {
            tinderLogo.Visible = true;
            getStartedButton.Visible = true;
            descriptionLabel.Visible = true;
            

        }
        private void pagesSetting()
        {
            switch (page)
            {
                case 1:
                    HideAllControls();
                    page1();
                    break;
                case 2:
                    ShowAllControls();
                    getStartedButton.Text = "Continue";
                    descriptionLabel.Visible = false;
                    break;

                case 999:
                    getStartedButton.Text = "You are not allowed";
                    break;
                case 3:
                    buttonModelSetting();
                    HideAllControls();
                    tinderLogo.Visible = false;
                    getStartedButton.Visible = false;
                    option1.Visible = true;
                    option2.Visible = true;
                    modelPicture.Visible = true;
                    modelPicture.Image = Properties.Resources.Asian_Male;
                    mainLabel.Visible = true;
                    break;

                case 4:
                    buttonChatSetting();
                    option1Label.Text = "Cool, I like hiking and cycling what about you";
                    option2Label.Text = "I like reading and walking, what about you";
                    mainLabel.Text = "Its a match, say something nice!";
                    mainLabel.Text += "\n\n----------------------------------------------------------------";
                    mainLabel.Text += "\n\nYou: Did it hurt when you fell from heaven.";
                    sleep();
                    mainLabel.Text += "\n\nHim: Haha that's cheesy.";
                    sleep();
                    mainLabel.Text += "\n\nYou: Ye, just trying to break the ice. So what do you do for fun.";
                    sleep();
                    mainLabel.Text += "\n\nHim: Not much, hangout with friends mostly.";
                   
                        break;
                case 5:
                    buttonChatSetting();
                    sleep();
                    mainLabel.Text += "\n\nYou: Cool, I like hiking and cycling what about you?";
                    sleep();
                    mainLabel.Text += "\n\nHim: I don't really have a hobby";
                    sleep();
                    mainLabel.Text += "\n\nYou: Oh,OKay.Well it was nice chatting";
                    sleep();
                    mainLabel.Text += "\n\nHim: Ye, you too!";
                    sleep();
                    mainLabel.Text += "\n\n                    Bad Ending.";
                    sleep();
                    option1Label.Text = "View Result?";
                    option2Label.Text = "Play again?";
                    break;
                case 6:
                    buttonChatSetting();
                    mainLabel.Text = "\n\nHim: Haha that's cheesy.";
                    mainLabel.Text += "\n\nYou: Ye, just trying to break the ice. So what do you do for fun.";
                    mainLabel.Text += "\n\nHim: Not much, hangout with friends mostly.";
                    sleep();
                    mainLabel.Text += "\n\nYou: I like reading and walking, what about you.";
                    sleep();
                    mainLabel.Text += "\n\nHim: Cool, I actually like walking.";
                    sleep();
                    option1Label.Text = "Have you been to the park downtown?";
                    option2Label.Text = "Have you been to the new coffee shop downtown?";
                    break;
                case 7:
                    buttonChatSetting();
                    sleep();
                    mainLabel.Text = "\n\nYou: Have you been to the park downtown?";
                    sleep();
                    mainLabel.Text += "\n\nHim: No, It's been snowing recently. I don't know if its a good idea to go there.";
                    sleep();
                    mainLabel.Text += "\n\nYou: have you tried the new coffeeshop downtown?";
                    sleep();
                    mainLabel.Text += "\n\nHim: NO I haven't. Is it any good?";
                    sleep();
                    mainLabel.Text += "\n\nYou: Its fantastic. Would you like to check it out together sometime. How about Sunday evening?";
                    sleep();
                    mainLabel.Text += "\n\nHim: Awesome! I'll send you the details. Can't wait";
                    sleep();
                    mainLabel.Text += "\n\n IN THE DATE, YOU BOTH DID REALLY ENJOY IT";
                    sleep();
                    mainLabel.Text += "\n                              --GOOD END--";
                    sleep();
                    option1Label.Text = "View Result?";
                    option2Label.Text = "Play again?";
                    break;
                case 8:
                    buttonChatSetting();
                    sleep();
                    mainLabel.Text += "\n\nYou: have you tried the new coffeeshop downtown?";
                    sleep();
                    mainLabel.Text += "\n\nHim: NO I haven't. Is it any good?";
                    sleep();
                    mainLabel.Text += "\n\nYou: Its fantastic. Would you like to check it out together sometime. How about Sunday evening?";
                    sleep();
                    mainLabel.Text += "\n\nHim: Awesome! I'll send you the details. Can't wait";
                    sleep();
                    mainLabel.Text += "\n\n IN THE DATE, YOU BOTH DID REALLY ENJOY IT";
                    sleep();
                    mainLabel.Text += "\n                              --GOOD END--";
                    sleep();
                    option1Label.Text = "View Result?";
                    option2Label.Text = "Play again?";
                    break;
                case 9:
                    buttonModelSetting();
                    HideAllControls();
                    tinderLogo.Visible = false;
                    getStartedButton.Visible = false;
                    option1.Visible = true;
                    option2.Visible = true;
                    modelPicture.Visible = true;
                    modelPicture.Image = Properties.Resources.Black_Male;
                    mainLabel.Visible = true;
                    mainLabel.Text = " ";
                    break;
                case 10:
                    buttonChatSetting();
                    option1Label.Text = "Not much, just scrolling through Tinder.\n Hey, speaking of campfire, have you ever been camping?";
                    option2Label.Text = "Not much, just scrolling through Tinder.\n Hey, speaking of pizza, have you tried the new homemade pizzashop downtown??";
                    mainLabel.Text = "Its a match, say something nice!";
                    mainLabel.Text += "\n\n----------------------------------------------------------------";
                    mainLabel.Text += "\n\nYou: If you were a booger, I will pick I'd pick you first.";
                    sleep();
                    mainLabel.Text += "\n\nHim: Haha, smooth. What's up";
                    break;
                case 11:
                    buttonChatSetting();
                    mainLabel.Text += "\n\nYou: Not much, just scrolling through Tinder. Hey, speaking of campfire, have you ever been camping?";
                    sleep();
                    mainLabel.Text += "\n\nHim: Yeah I love camping. Haven't been in a while.";
                    sleep();
                    mainLabel.Text += "\n\nYou: Me neither. How about we change that. Are you free this weekend.";
                    sleep();
                    mainLabel.Text += "\n\nHim: Sounds great! Im in";
                    sleep();
                    mainLabel.Text += "\n\nYou: Cool! I'll plan and send you the details! Can't wait";
                    sleep();
                    option1Label.Text = "View Results";
                    option2Label.Text = "Play Again";
                    break;
                case 12:
                    buttonChatSetting();
                    sleep();
                    mainLabel.Text += "\n\nYou: Not much, just scrolling through Tinder. Hey, speaking of pizza, \nhave you tried the new homemade pizzashop downtown??";
                    sleep();
                    mainLabel.Text += "\n\nHim: Oh really, when are you free?";
                    option1Label.Text = "Tomorow";
                    option2Label.Text = "Next week";
                    break;
                case 13:
                    buttonChatSetting();
                    sleep();
                    mainLabel.Text += "\n\nTomorrow";
                    sleep();
                     mainLabel.Text += "\n\n Him: Ok, See you at Domino tomorrow.";
                    break;

                case 14:
                    buttonChatSetting();
                    option3.Visible = true;
                    option3.BringToFront();
                    option3Label.BringToFront();
                    option3Label.Visible = true;
                    sleep();
                    mainLabel.Text = "\n\nYou: Next week";
                    sleep();
                    mainLabel.Text += "\n\n Him: Ok, See you at Domino next Saturday.";
                    sleep();
                    mainLabel.Text += "\n\n YOU HAVE A PRETTY GOOD TIME WITH HIM. HOWEVER HE DOESNT LIKE YOU, HE SAID THAT WE COULD BE FRIENDS";
                    sleep();
                    option1Label.Text = "Agree to be his friend";
                    option2Label.Text = "Block Him";
                    option3Label.Text = " Take it easy. We still got time";
                    break;
                case 15:
                    buttonModelSetting();
                    HideAllControls();
                    tinderLogo.Visible = false;
                    getStartedButton.Visible = false;
                    option1.Visible = true;
                    option2.Visible = true;
                    modelPicture.Visible = true;
                    modelPicture.Image = Properties.Resources.White_Male;
                    mainLabel.Visible = true;
                    mainLabel.Text = " ";
                    break;
                case 16:
                    buttonChatSetting();
                    sleep();
                    mainLabel.Text = "HE RECEIVED THE MESSAGE BUT NEVER REPLIES.";
                    sleep();
                    mainLabel.Text += "\n\n BAD END";
                    sleep();
                    option1Label.Text = "View results";
                    option2Label.Text = "Play Again";
                    break;
                case 17:
                    buttonChatSetting();
                    sleep(); mainLabel.Text = "You are so picky!";
                    sleep();
                    mainLabel.Text += "\n\nThis app may not be for you";
                    sleep();
                    mainLabel.Text += "\n\n BAD END";
                    sleep();
                    option1Label.Text = "View results";
                    option2Label.Text = "Play Again";
                    break;
                case 18:
                    buttonModelSetting();
                    HideAllControls();
                    tinderLogo.Visible = false;
                    getStartedButton.Visible = false;
                    option1.Visible = true;
                    option2.Visible = true;
                    modelPicture.Visible = true;
                    modelPicture.Image = Properties.Resources.White_Female;
                    mainLabel.Visible = true;
                    mainLabel.Text = " ";
                    break;
                case 19:
                    buttonChatSetting();
                    option1Label.Text = "Hey there";
                    option2Label.Text = "Did it hurt, when you fell from heaven";
                    mainLabel.Text = "Its a match, say something nice!";
                    sleep();
                    mainLabel.Text += "\n\n----------------------------------------------------------------";
                    break;
                case 20:
                    buttonChatSetting();
                    sleep();
                    mainLabel.Text += "You: Hey there!";
                    sleep();
                    mainLabel.Text += "\n\nHer: Hey baby, What's up.";
                    sleep();
                    mainLabel.Text += "\n\nYou:Just browsing, your life seems pretty wild.";
                    sleep();
                    mainLabel.Text += "\n\nHer:Yeah I know, I like to live to my fullest. Wanna join me sometime?";
                    sleep();
                    mainLabel.Text += "\n\nYou:No thanks, I prefer quieter lifestyle.";
                    sleep();
                    mainLabel.Text += "\n\nHer: Thats alright, People got preferences.";
                    sleep();
                    mainLabel.Text += "\n\n            BAD END";
                    option1Label.Text = "View result";
                    option2Label.Text = "Try Again";
                    break;
                case 21:
                    buttonChatSetting();
                    sleep();
                    mainLabel.Text += "\n\nYou: Did it hurt, when you fell from heaven?";
                    sleep();
                    mainLabel.Text += "\n\nHer: Haha, thats a good one. Whats up.";
                    sleep();
                    mainLabel.Text += "\n\nYou: Just browsing. YOur lifestyle seems pretty wild.";
                    sleep();
                    mainLabel.Text += "\n\nHer: Yeah, I like to live it up. Wanna join me sometimes?";
                    sleep();
                    option1Label.Text = "For sure, why not?";
                    option2Label.Text = "I prefer quiter vibes, thanks.";
                    break;
                case 22:
                    buttonChatSetting();
                    sleep();
                    mainLabel.Text += "\n\nYou: For sure, why not?";
                    sleep();
                    mainLabel.Text += "\n\nHer: When are you free?";
                    sleep();
                    mainLabel.Text += "\n\nYou: Tomorrow at 1am?";
                    sleep();
                    mainLabel.Text += "\n\nHer: Cool! I'll plan and send you the details";
                    sleep();
                    mainLabel.Text += "\n\n         GOOD END";
                    option2Label.Text = "Try Again";
                    option1Label.Text = "View result";
                    break;
                case 23:
                    buttonChatSetting();
                    sleep();
                    mainLabel.Text += "\n\nYou: I prefer quiter vibes thanks.";
                    sleep();
                    mainLabel.Text += "\n\nHer: No worries babe. hit me up if you change your mind";
                    sleep();
                    mainLabel.Text += "\n\n          Bad End";
                    sleep();
                    option1Label.Text = "View Result";
                    option2Label.Text = "Try Again";
                    break;
                case 24:
                    buttonModelSetting();
                    HideAllControls();
                    tinderLogo.Visible = false;
                    getStartedButton.Visible = false;
                    option1.Visible = true;
                    option2.Visible = true;
                    modelPicture.Visible = true;
                    modelPicture.Image = Properties.Resources.Asian_Female;
                    mainLabel.Visible = true;
                    mainLabel.Text = " ";
                    break;
                case 25:
                    buttonChatSetting();
                    option1Label.Text = "Hey there, have you seen any movies lately.";
                    option2Label.Text = "Your profile caught my eye. I couldn't help but notice your smile in your photos.\n How's your day going?";
                    mainLabel.Text = "Its a match, say something nice!";
                    sleep();
                    mainLabel.Text += "\n\n----------------------------------------------------------------";
                    break;
                case 26:
                    buttonChatSetting();
                    sleep();
                    mainLabel.Text += "\n\nYou:Hey there, have you seen any movies lately?";
                    sleep();
                    mainLabel.Text += "\n\nHer: Not really?Why?";
                    sleep();
                    mainLabel.Text += "\n\nYou: How about we catch one this Friday";
                    sleep();
                    mainLabel.Text += "\n\nHer: What? Do I know you?";
                    sleep();
                    mainLabel.Text += "\n\nHer: Weirdo!";
                    sleep();
                    mainLabel.Text += "\n\nYOU ARE BLOCKED.";
                    sleep();
                    mainLabel.Text += "\n\nBAD END";
                    option1Label.Text = "View Results";
                    option2Label.Text = "Try Again";
                    break;

                case 27:
                    buttonChatSetting();
                    sleep();
                    mainLabel.Text += "\n\nYou: Your profile caught my eye. I couldn't help but notice your smile in your photos.\n How's your day going?";
                    sleep();
                    mainLabel.Text += "\n\nHer: Aw, thank you! Just another day, busy work you know.How about you?";
                    sleep();
                    option1Label.Text = "\n\nNot bad, just take it easy So, have you seen any good movies lately?\n I'm a bit of a movie buff myself.";
                    option2Label.Text = "\n\nPretty good, can be better with you in the cinema with me tonight. \nI have booked the seats for just the 2 of us.What do you think?";
                    break;

                case 28:
                    buttonChatSetting();
                    sleep();
                    mainLabel.Text += "\n\nYou: Not bad, just take it easy So, have you seen any good movies lately?\n I'm a bit of a movie buff myself.";
                    sleep();
                    mainLabel.Text += "\n\nHer: Not really, I've been wanting to catch a movie though.\n Do you know any good cinema";
                    sleep();
                    mainLabel.Text += "\n\nYou: Of course, I know this great cinema at downtown. How about this Friday night.";
                    sleep();
                    mainLabel.Text += "\n\nHer: Cool! Im down. I'll send you the details later.";
                    sleep();
                    mainLabel.Text += "GOOD END";
                    option1Label.Text = "View Results";
                    option2Label.Text = "Try Again";
                    break;
                case 29:
                    buttonChatSetting();
                    sleep();
                    mainLabel.Text += "\n\nYou: Pretty good, can be better with you in the cinema with me tonight.\n I have booked the seats for just the 2 of us. What do you think?";
                    sleep();
                    mainLabel.Text += "\n\nHer: Sorry Im not into movies thanks. Have fun with your movie.";
                    sleep();
                    mainLabel.Text += "BAD END";
                    option1Label.Text = "View Results";
                    option2Label.Text = "Try Again";
                    break;
                case 30:
                    buttonModelSetting();
                    HideAllControls();
                    tinderLogo.Visible = false;
                    getStartedButton.Visible = false;
                    option1.Visible = true;
                    option2.Visible = true;
                    modelPicture.Visible = true;
                    modelPicture.Image = Properties.Resources.Black_Female;
                    mainLabel.Visible = true;
                    mainLabel.Text = " ";
                    break;
                case 31:
                    buttonChatSetting();
                    sleep();
                    mainLabel.Text = "SHE RECEIVED THE MESSAGE BUT NEVER REPLIES.";
                    sleep();
                    mainLabel.Text += "\n\n BAD END";
                    sleep();
                    option1Label.Text = "View results";
                    option2Label.Text = "Play Again";
                    break;
                case 32:
                    buttonChatSetting();
                    sleep(); mainLabel.Text = "You are so picky!";
                    sleep();
                    mainLabel.Text += "\n\nThis app may not be for you";
                    sleep();
                    mainLabel.Text += "\n\n BAD END";
                    sleep();
                    option1Label.Text = "View results";
                    option2Label.Text = "Play Again";
                    break;
                case 98:
                    HideAllControls();
                    mainLabel.Visible = true;
                    mainLabel.Text = "    --SECRET ENDING--   ";
                    sleep();
                    mainLabel.Text += "\n\n    --He Ghosted And Never Show Up--   ";
                    this.Refresh();
                    Thread.Sleep(3000);
                    Application.Exit();

                    break;
                case 99:
                    HideAllControls();
                    mainLabel.Visible = true;
                    mainLabel.Text = "    --BAD ENDING--   ";
                    sleep();
                    mainLabel.Text += "\n\n    --The app didn't work out. You die of loneliness--   ";
                    this.Refresh();
                    Thread.Sleep(3000);
                    Application.Exit();

                    break;
                case 100:
                    HideAllControls();
                    mainLabel.Visible = true;
                    mainLabel.Text = "    --GOOD ENDING--   ";
                    sleep();
                    mainLabel.Text += "\n\n    --After a couple more dates you both decide to be a couple.--   ";
                    this.Refresh();
                    Thread.Sleep(3000);
                    Application.Exit();

                    break;


            }
        }

        private void option1_Click(object sender, EventArgs e)
        {
            if (page == 3)
            {
                page = 4;
            } 
            else if (page == 4)
            {
                page = 5;
            }
            else if (page == 5)
            {
                page = 99;
            }
            else if (page == 6)
            {
                page = 7;
            }
            else if (page == 7)
            {
                page = 100;
            }
            else if (page == 8)
            {
                page = 100;
            }
            else if (page == 9)
            {
                page = 10;
            }
            else if (page == 10)
            {
                page = 11;
            }
            else if (page == 11)
            {
                page = 100;

            }
            else if (page == 12)
            {
                page = 13;
            }
            else if (page == 13)
            {
                int randValue = randGen.Next(1, 101);

                if (randValue < 30)
                {
                    page = 100;
                }
                else
                {
                    page = 99;
                }
            }
            else if (page == 14)
            {
                page = 98;
            }
            else if (page == 15)
            {
                page = 16;
            }
            else if (page == 16)
            {
                page = 99;
            }
            else if (page == 17)
            {
                page = 99;
            }
            else if (page == 18)
            {
                page = 19;
            }
            else if (page == 19)
            {
                page = 20;
            }
            else if (page == 20)
            {
                page = 99;
            }
            else if (page == 21)
            {
                page = 22;
            }
            else if (page == 22)
            {
                page = 100;
            }
            else if (page == 23)
            {
                page = 99;
            }
            else if (page == 24)
            {
                page = 25;
            }
            else if (page == 25)
            {
                page = 26;
            }
            else if (page == 26)
            {
                page = 99;
            }
            else if (page == 27)
            {
                page = 28;
            }
            else if (page == 28)
            {
                page = 100;
            }
            else if (page == 29)
            {
                page = 99;
            }
            else if (page == 30)
            {
                page = 31;
            }
            else if (page == 31)
            {
                page = 99;
            }
            else if (page == 32)
            {
                page = 99;
            }


            pagesSetting();
        }

        private void option2_Click(object sender, EventArgs e)
        {
            if (page == 3)
            {
                page = 9;
            }
            else if (page == 4)
            {
                page = 6;
            }
            else if (page == 5)
            {
                page = 1;
            }
            else if (page == 6)
            {
                page = 7;
            }
            else if (page == 7)
            {
                page = 1;
            }
            else if (page == 8)
            {
                page = 1;
            }
            else if (page == 9)
            {
                page = 15;
            }
            else if (page == 10)
            {
                page = 12;
            }
            else if (page == 11)
            {
                page = 1;

            }
            else if (page == 12)
            {
                page = 14;
            }
            else if (page == 13)
            {
                int randValue = randGen.Next(1, 101);

                if (randValue < 30)
                {
                    page = 1;
                }
                else
                {
                    page = 1;
                }
            }
            else if (page == 14)
            {
                page = 99;
            }
            else if (page == 15)
            {
                page = 17;
            }
            else if (page == 16)
            {
                page = 1;
            }
            else if (page == 17)
            {
                page = 1;
            }
            else if (page == 18)
            {
                page = 24;
            }
            else if (page == 19)
            {
                page = 21;
            }
            else if (page == 20)
            {
                page = 1;
            }
            else if (page == 21)
            {
                page = 23;
            }
            else if (page == 22)
            {
                page = 1;
            }
            else if (page == 23)
            {
                page = 1;
            }
            else if (page == 24)
            {
                page = 30;
            }
            else if (page == 25)
            {
                page = 27;
            }
            else if (page == 26)
            {
                page = 1;
            }
            else if (page == 27)
            {
                page = 29;
            }
            else if (page == 28)
            {
                page = 1;
            }
            else if (page == 29)
            {
                page = 1;
            }
            else if (page == 30)
            {
                page = 32;
            }
            else if (page == 31)
            {
                page = 1;
            }
            else if (page == 32)
            {
                page = 1;
            }
            pagesSetting();

        }

        private void option3_Click(object sender, EventArgs e)
        {
            if (page == 14)
            {

                page = 100;
            }
            pagesSetting();
        }
    }


}

