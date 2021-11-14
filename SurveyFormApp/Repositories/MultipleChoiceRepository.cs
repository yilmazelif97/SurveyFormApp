using SurveyFormApp.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormApp.Repositories
{
    public class MultipleChoiceRepository : IRepository<MultipleChoiceQuestion>
    {
        /// <summary>
        /// It is for multipleanswer option for one question
        /// </summary>
        private HashSet<MultipleChoiceQuestion> _multiplequesiton = new HashSet<MultipleChoiceQuestion>();

        public List<MultipleChoiceQuestion> GetData()
        {

            var multipleanswer = new MultipleChoiceQuestion("a1", "a2", "a3", "a4");
            _multiplequesiton.Add(multipleanswer);

            return _multiplequesiton.ToList();

        }
    }
}
