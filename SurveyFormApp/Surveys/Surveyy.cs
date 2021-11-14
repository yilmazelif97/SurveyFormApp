using SurveyFormApp.Questions;
using SurveyFormApp.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormApp.Surveys
{

    /// <summary>
    /// It is Survey class. It includes questions and features about survey like date, user name..
    /// </summary>
    public class Surveyy
    {


        public DateTime DateofSurvey { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public User User { get; private set; }
        public int LimitofQuesitons { get; private set; }

        public ShortAnswer shortAnswer { get; set; }
        public ParagraphQuestion paragraphQuestion { get; set; }
        public DatetimeFormatQuestion DateTime { get; set; }
        public MultipleChoiceQuestion multiple { get; set; }

        public YesNoQuestion yesnoquesiton { get; set; }
        public CheckBoxQuestion checkBoxQuestion { get; set; }

        const int limitofque = 10;

        /// <summary>
        /// This object lists are for access to questions with their own type
        /// </summary>

        private List<ShortAnswer> shortanswerquesitons = new List<ShortAnswer>();
        public IReadOnlyList<ShortAnswer> Shortanswerquesitons => shortanswerquesitons;

        private List<ParagraphQuestion> paragraphquesitons = new List<ParagraphQuestion>();
        public IReadOnlyList<ParagraphQuestion> Paragraphquesitons => paragraphquesitons;

        private List<DatetimeFormatQuestion> datetquesiton = new List<DatetimeFormatQuestion>();
        public IReadOnlyList<DatetimeFormatQuestion> dDtetquesiton => datetquesiton;

        private List<MultipleChoiceQuestion> multiplechoquesiton = new List<MultipleChoiceQuestion>();
        public IReadOnlyList<MultipleChoiceQuestion> Multiplechoquesiton => multiplechoquesiton;


        private List<YesNoQuestion> yesnoques = new List<YesNoQuestion>();
        public IReadOnlyList<YesNoQuestion> Yesnoquesiton => yesnoques;


        private List<CheckBoxQuestion> checkBoxQuestions = new List<CheckBoxQuestion>();
        public IReadOnlyList<CheckBoxQuestion> CheckBoxQuestions => checkBoxQuestions;


        public Surveyy(DateTime dateofSurvey, string title, string description, User user, int limitofquesitons)
        {
            DateofSurvey = dateofSurvey;
            Title = title;
            Description = description;
            User = user;
            LimitofQuesitons = limitofquesitons;
        }

        /// <summary>
        /// Adding shortanswer question to survey
        /// </summary>
        /// <param name="sh"></param>

        public void AddShortAnswerQuestin(ShortAnswer sh)
        {
            shortanswerquesitons.Add(sh);
        }

        /// <summary>
        /// Adding paragrapg question to survey
        /// </summary>
        /// <param name="pq"></param>
        public void AddParagraphQuestion(ParagraphQuestion pq)
        {
            paragraphquesitons.Add(pq);
        }

        /// <summary>
        /// adding datetimeformat question to survey
        /// </summary>
        /// <param name="dq"></param>
        public void AddDateTimeQue(DatetimeFormatQuestion dq)
        {
            datetquesiton.Add(dq);
        }


        /// <summary>
        /// adding multiple choice queiton to survey
        /// </summary>
        /// <param name="mq"></param>
        public void AddMultipleChoiceQuestion(MultipleChoiceQuestion mq)
        {
            multiplechoquesiton.Add(mq);
        }

        /// <summary>
        /// adding yesno quesiton to survey
        /// </summary>
        /// <param name="yq"></param>
        public void AddyesNoQuesiton(YesNoQuestion yq)
        {
            yesnoques.Add(yq);
        }

        /// <summary>
        /// adding checkbox question to survey
        /// </summary>
        /// <param name="cq"></param>

        public void AddCheckboxQuesiton(CheckBoxQuestion cq)
        {
            checkBoxQuestions.Add(cq);
        }


        /// <summary>
        /// I add all question to object list for can count number of question. So checking list size is bigger than 10 question
        /// and compare listsize with determined limit of quesiton
        /// </summary>
        /// <param name="survey"></param>
        public void CheckSurvey(Surveyy survey)
        {
            var objlist = new List<object>();
            objlist.Add(survey.shortAnswer);
            objlist.Add(survey.paragraphquesitons);
            objlist.Add(survey.datetquesiton);
            objlist.Add(survey.checkBoxQuestion);
            objlist.Add(survey.multiplechoquesiton);
            objlist.Add(survey.yesnoques);

            if (objlist.Count < 10)
            {
                throw new Exception("You should add more than 10 quesiton");
            }
            else if (objlist.Count < LimitofQuesitons)
            {
                throw new Exception("You should add quesiton at least as you determined");
            }

        }

        

        /// <summary>
        /// Survey needs user information. Getting information in this method
        /// </summary>
        /// <param name="user"></param>

        public void SetUser(User user)
        {
            this.User = user;
        }

       
    }
}
