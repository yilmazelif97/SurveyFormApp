using SurveyFormApp.Surveys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormApp.Questions
{

    /// <summary>
    /// short answer quesitons
    /// </summary>
    public class ShortAnswer :  QuestionInterface
    {
        public string TextofQuestion { get; set; }
        public int NumberofQuesiton { get; set; }
        public QuesitonType quesitontype { get; set; }
        public string TextofOption { get; set; }


        public ShortAnswer(string text, int numberofquesti, QuesitonType type,string option)
        {
            NumberofQuesiton = numberofquesti;
            quesitontype = type;
            TextofQuestion = text;
            Check(option);
        }
        
        /// <summary>
        /// Checking input answers character is bigger than 30
        /// </summary>
        /// <param name="data"></param>
        public void Check(string data)
        {
            if ( data.Length > 30)
            {
                throw new Exception("You can not write answer more than 30 character");
            }
            else
            {
                TextofOption = data;
            }
           

        }
    }


}
