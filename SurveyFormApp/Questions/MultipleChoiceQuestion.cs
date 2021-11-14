using SurveyFormApp.Options;
using SurveyFormApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormApp.Questions
{

    //Multiple choice quesiton class
    public class MultipleChoiceQuestion : QuestionInterface
    {
       

        public string TextofQuestion { get; set; }
        public int NumberofQuesiton { get; set; }
        public QuesitonType quesitontype { get; set; }
        public string TextofOption { get; set; }

        public string multipleq1 { get; private set; }
        public string multipleq2 { get; private set; }
        public string multipleq3 { get; private set; }
        public string multipleq4 { get; private set; }

        List<MultipleChoiceQuestion> list = new MultipleChoiceRepository().GetData();


        public MultipleChoiceQuestion(string textofQuestion, int numberofQuesiton, QuesitonType quesitontype, string textofOption)
        {
            TextofQuestion = textofQuestion;
            NumberofQuesiton = numberofQuesiton;
            this.quesitontype = quesitontype;
            Check(textofOption);
        }

        /// <summary>
        /// This constructor for answer option
        /// </summary>
        /// <param name="multipleq1"></param>
        /// <param name="multipleq2"></param>
        /// <param name="multipleq3"></param>
        /// <param name="multipleq4"></param>

        public MultipleChoiceQuestion(string multipleq1, string multipleq2, string multipleq3, string multipleq4)
        {
            this.multipleq1 = multipleq1;
            this.multipleq2 = multipleq2;
            this.multipleq3 = multipleq3;
            this.multipleq4 = multipleq4;
        }

        /// <summary>
        /// Checking number of element of answer list if it is bigger than 5 exception message is worked
        /// </summary>
        /// <param name="multipleqlist"></param>
        public void Checklist(List<MultipleChoiceQuestion> multipleqlist)
        {
            if (multipleqlist.Count>5)
            {
                throw new Exception("You can add just FOUR answer option");
            }
        }

        /// <summary>
        /// checking input answer is included into answer option list
        /// </summary>
        /// <param name="data"></param>
        public void Check(string data)
        {
            if (!list.ToArray().ToString().Contains(data))
            {

                throw new Exception("You should select answer from given option");
            }
            else
            {
                TextofOption = data;
            }
        }
    }
}
