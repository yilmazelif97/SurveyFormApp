using SurveyFormApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormApp.Questions
{

    /// <summary>
    /// yes/no question class
    /// </summary>
    public class YesNoQuestion : QuestionInterface
    {
      

        public string TextofQuestion { get;set; }
        public int NumberofQuesiton { get; set; }
        public QuesitonType quesitontype { get; set; }
        public string TextofOption { get; set; }


        public string yesnoChoice { get; private set; }

        /// <summary>
        /// getting answer option from repository as Yes and No
        /// </summary>

        List<YesNoQuestion> list = new YesnoquestionRepository().GetData();



        public YesNoQuestion(string textofQuestion, int numberofQuesiton, QuesitonType quesitontype, string textofOption)
        {
            TextofQuestion = textofQuestion; //partiye gelecek misin
            NumberofQuesiton = numberofQuesiton; //3. soru
            this.quesitontype = quesitontype; //Yes-no
            Check(textofOption);
        }

        /// <summary>
        /// This constructor is using in repository for determine answer option
        /// </summary>
        /// <param name="yesno"></param>
        public YesNoQuestion(string yesno)
        {
            yesnoChoice = yesno;
        }

        /// <summary>
        /// check answer is in correct type like yes or  no
        /// </summary>
        /// <param name="data"></param>
        public void Check(string data)
        {

            if (data != list.ToString())
            {
                throw new Exception("Your answer is unavailable. Please check form of written");
            }
            else
            {
                TextofOption = data;
            }

        }

        /// <summary>
        /// checking answer option count. ıt can not be more than 2 and checking answer list in incluiding yes or no
        /// </summary>
        /// <param name="list"></param>

        public void Checklist(List<YesNoQuestion> list)
        {

            if (list.Count > 2)
            {
                throw new Exception("There must be just TWO chocice ");
            }

            if (!list.ToArray().ToString().Contains("Yes") || !list.ToArray().ToString().Contains("No"))
            {
                throw new Exception("It is Yes/No quesiton. Please check quesiton type");
            }

        }


    }
}
