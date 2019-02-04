using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralQuiz
{
    class Quiz
    {
        private string[,] questions = new string[20, 5];
        public Quiz()
        {
            questions[0, 0] = "Which country is Antony Martial from?";
            questions[0, 1] = "France";
            questions[0, 2] = "China";
            questions[0, 3] = "*Germany";
            questions[0, 4] = "Brazil";
            //
            questions[1, 0] = "Which one is not a programming language";
            questions[1, 1] = "C#";
            questions[1, 2] = "*Java";
            questions[1, 3] = "HTML";
            questions[1, 4] = "Python";
            //
            questions[2, 0] = "Zimbabwe is suffering from which outbreak?";
            questions[2, 1] = "*tuberculosis";
            questions[2, 2] = "cholera";
            questions[2, 3] = "malaria";
            questions[2, 4] = "diabetes";
            //
            questions[3, 0] = "A good programmer can not be someone who?";
            questions[3, 1] = "*Positive Attiude";
            questions[3, 2] = "Quick learning ability";
            questions[3, 3] = "Do not engage team work";
            questions[3, 4] = "High End user focus";
            //
            questions[4, 0] = "Which city has the Premier league?";
            questions[4, 1] = "Manchester";
            questions[4, 2] = "Barcelona";
            questions[4, 3] = "*England";
            questions[4, 4] = "London";
            //
            questions[5, 0] = "Wich languuage use pointers between Java and C#";
            questions[5, 1] = "Java only";
            questions[5, 2] = "*C# only";
            questions[5, 3] = "Both";
            questions[5, 4] = "None of the above";
            //
            questions[6, 0] = "Pythagoras was first to ____ the universal validity of geometrical theorem.";
            questions[6, 1] = "give";
            questions[6, 2] = "*prove";
            questions[6, 3] = "both";
            questions[6, 4] = "None of the above";
            //
            questions[7, 0] = "Zimbabwe is Open for?";
            questions[7, 1] = "trading";
            questions[7, 2] = "mining";
            questions[7, 3] = "business";
            questions[7, 4] = "*farming";
            //
            questions[8, 0] = "Zimbabwe has how many classes of license";
            questions[8, 1] = "1";
            questions[8, 2] = "2";
            questions[8, 3] = "3";
            questions[8, 4] = "*4";
            //
            questions[9, 0] = "Zimbabwe has other teams except";
            questions[9, 1] = "*Dynamos";
            questions[9, 2] = "Caps";
            questions[9, 3] = "Chiefs";
            questions[9, 4] = "Platinum";
            //
            questions[10, 0] = "Home of IT solutions";
            questions[10, 1] = "Spectrum";
            questions[10, 2] = "Hospital";
            questions[10, 3] = "University";
            questions[10, 4] = "*Church";
        }
        public string getQuestion(int i)
        {
            return questions[i, 0];
        }
        public string getAnswer(int i,int j)
        {
            return questions[i, j];
        }

    }
}
