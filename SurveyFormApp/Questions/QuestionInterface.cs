using SurveyFormApp.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormApp.Questions
{

    /// <summary>
    /// this interface for questions. All question types are getting main features and method from this interface.
    /// </summary>
    public interface QuestionInterface
    {
        public string TextofQuestion { get; set; }
        public int NumberofQuesiton { get; set; }
        public QuesitonType quesitontype { get; set; }

        public string TextofOption { get; set; }

        void Check(string data);


    }
}

