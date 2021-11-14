using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormApp.Questions
{

    /// <summary>
    /// Datetime format quesitons
    /// </summary>
    public class DatetimeFormatQuestion : QuestionInterface
    {
      

        public string TextofQuestion { get; set; }
        public int NumberofQuesiton { get; set; }
        public QuesitonType quesitontype { get; set; }
        public string TextofOption { get; set; }


        public DatetimeFormatQuestion(string textofQuestion, int numberofQuesiton, QuesitonType quesitontype, string textofOption)
        {
            TextofQuestion = textofQuestion;
            NumberofQuesiton = numberofQuesiton;
            this.quesitontype = quesitontype;
            Check(textofOption);
        }

        /// <summary>
        /// it is checking input is similar as datetime format
        /// </summary>
        /// <param name="data"></param>

        public void Check(string data)
        {
            if(DateTime.TryParse(data, out DateTime Temp) == false)
            {
                throw new Exception("Answer type should be DateTime");
            }
            else
            {
                TextofOption = data;
            }
        }
    }
}
