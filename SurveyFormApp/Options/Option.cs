using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormApp.Options
{
    public interface Option
    {

        string QuesitonText { get; set; }

        string Quesitonoption { get; set; }
        void Evaluateoption(string data);
    }
}
