using SurveyFormApp.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormApp.Repositories
{
    public class YesnoquestionRepository : IRepository<YesNoQuestion>
    {
       
        private HashSet<YesNoQuestion> yesnochoice = new HashSet<YesNoQuestion>();

       
        /// <summary>
        /// It is for Yes and no option
        /// </summary>
        /// <returns></returns>
        public List<YesNoQuestion> GetData()
        {

            var choice1 = new YesNoQuestion("Yes");
            var choice2 = new YesNoQuestion("No");


            yesnochoice.Add(choice1);
            yesnochoice.Add(choice2);
            

           
            return yesnochoice.ToList();

        }

        
    }
}
