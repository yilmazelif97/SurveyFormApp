using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormApp.Questions
{

    /// <summary>
    /// Paragraph question
    /// </summary>
    public class ParagraphQuestion : QuestionInterface
    {
       

        public string TextofQuestion { get; set; }
        public int NumberofQuesiton { get; set; }
        public QuesitonType quesitontype { get; set; }
        public string TextofOption { get; set; }

        public ParagraphQuestion(string textofQuestion, int numberofQuesiton, QuesitonType quesitontype, string textofOption)
        {
            TextofQuestion = textofQuestion;
            NumberofQuesiton = numberofQuesiton;
            this.quesitontype = quesitontype;

            Check(textofOption);
        }


        /// <summary>
        /// Checking input answers character size.
        /// </summary>
        /// <param name="data"></param>

        public void Check(string data)
        {
            if (data.Length > 200)
            {
                throw new Exception("You can not write answer more than 200 character");
            }
            else
            {
                TextofOption = data;
            }
        }
    }
}
