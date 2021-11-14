using SurveyFormApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormApp.Questions
{

    /// <summary>
    /// Details about Checkbox questions
    /// </summary>
    /// 
    
    public class CheckBoxQuestion : QuestionInterface
    {

        /// <summary>
        /// IBU QUESTİON TYPE I KODLAYAMADIM
        /// </summary>
     
        public string TextofQuestion { get; set; }
        public int NumberofQuesiton { get; set; }
        public QuesitonType quesitontype { get; set; }
        public string TextofOption { get; set; }

        public string option1 { get; private set; }
        public string option2 { get; private set; }
        public string option3 { get; private set; }
        public string option4 { get; private set; }
        public string option5 { get; private set; }

        List<CheckBoxQuestion> list = new CheckboxQuestionRepository().GetData();

  

        public List<string> dene { get; set; }


        public CheckBoxQuestion(string textofQuestion, int numberofQuesiton, QuesitonType quesitontype, string textofOption)
        {
            TextofQuestion = textofQuestion;
            NumberofQuesiton = numberofQuesiton;
            this.quesitontype = quesitontype;
            TextofOption = textofOption;
        }

        /// <summary>
        /// user 
        /// </summary>
        /// <param name="option1"></param>
        /// <param name="option2"></param>
        /// <param name="option3"></param>
        /// <param name="option4"></param>
        /// <param name="option5"></param>
        public CheckBoxQuestion(string option1, string option2, string option3, string option4, string option5)
        {
            this.option1 = option1;
            this.option2 = option2;
            this.option3 = option3;
            this.option4 = option4;
            this.option5 = option5;
        }

        public void Check(string data)
        {

            var items = list.Select(x => new List<string>() { x.option1, x.option2, x.option3, x.option4, x.option5 }).SelectMany(item => item).Distinct();

            foreach (var item in list)
            {
                if (data == item.option1)
                {
                   
                }

            }

            if (data=="Hiçbiri")
            {
                list.Clear();
            }

            if (data != list.ToString())
            {
                throw new Exception("Your answer is unavailable. Please check form of written");
            }
        }

        public void Checklist(List<CheckBoxQuestion> checkboxlist)
        {
            

            if (checkboxlist.Count > 6)
            {
                throw new Exception("There must be just FIVE chocice ");
            }

            
        }

       

    }
}
