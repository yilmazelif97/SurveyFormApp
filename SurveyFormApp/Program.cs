using SurveyFormApp.Questions;
using SurveyFormApp.Repositories;
using SurveyFormApp.Surveys;
using SurveyFormApp.Users;
using System;

namespace SurveyFormApp
{
    class Program
    {
        static void Main(string[] args)
        {
           //Creating questions 


            var shortAnswer = new ShortAnswer("İsminizi Yazın", 1, QuesitonType.Shortanswer, "Elif");

            var paragraphQuestion = new ParagraphQuestion("Eğitim geçmişinizi yazınız", 2, QuesitonType.Paragraph, "okul");

            var datetimequestion = new DatetimeFormatQuestion("Doğum tarihini giriniz", 3, QuesitonType.DatetimeFormat, "14/11/2021");

            var yesnoquestion = new YesNoQuestion("Seminere katılıyor musunuz", 4, QuesitonType.YesNo, "Yes");

            var multiplechoicequesiton = new MultipleChoiceQuestion("Hangi harfi istersiniz", 5, QuesitonType.MultipleChoice, "a1");

            //multiplechoice gelmeli


            CheckBoxQuestion q = new CheckBoxQuestion("deneme", 5, QuesitonType.CheckBoxFormat, "Elma,armut");
            string[] d = q.TextofOption.Split(',');
            string a = d.ToString();
            q.dene.Add(a); // Accept answer more than one

            if (d.Length > 5)
            {
                throw new Exception("You can select FOUR option");
            }

            ///creating survey and adding question to survey

            var survey = new Surveyy( new DateTime(14 / 11 / 2021), "Survey 1", "Description Part", new User("Elif", "Yılmaz"), 13);

            survey.AddShortAnswerQuestin(shortAnswer);
            survey.AddParagraphQuestion(paragraphQuestion);
            survey.AddDateTimeQue(datetimequestion);
            survey.AddMultipleChoiceQuestion(multiplechoicequesiton);
            survey.AddyesNoQuesiton(yesnoquestion);



            //her soru tipi için quesiton listi açarım eklediğim soruları o liste atarım o listi de qouestion objesine ekletirim dene

            //abstract ya da interface de hem question listi hem de soru ekleme metodunu tanımlarım
            //her osru tipi için o classtan inheritance yaparım sonra o soru tiplerini quesiton objesinden add yaparım.


        }

    }
}
