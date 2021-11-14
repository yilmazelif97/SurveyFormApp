using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormApp.Repositories
{

    /// <summary>
    /// With this repository class ı can reach to inside of other repository, data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T:class
    {
        List<T> GetData();

    }
}
