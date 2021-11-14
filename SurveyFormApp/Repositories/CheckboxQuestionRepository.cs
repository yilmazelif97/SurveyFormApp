using SurveyFormApp.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormApp.Repositories
{
    public class CheckboxQuestionRepository : IRepository<CheckBoxQuestion>
    {

        HashSet<CheckBoxQuestion> _checkboxquestion = new HashSet<CheckBoxQuestion>();

        /// <summary>
        /// It is for one questions answer option.
        /// </summary>
        /// <returns></returns>
        public List<CheckBoxQuestion> GetData()
        {

            var checkboxw1 = new CheckBoxQuestion("1", "2", "3", "4", "5");
            _checkboxquestion.Add(checkboxw1);

            return _checkboxquestion.ToList();
            
        }
    }
}
