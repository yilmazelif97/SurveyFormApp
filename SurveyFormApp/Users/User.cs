using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormApp.Users
{

    /// <summary>
    /// This class for get information about user.
    /// </summary>
    public class User
    {
        

        public string UserName { get; private set; }
        public string UserSurname { get;private set; }

        public User(string userName, string userSurname)
        {
            UserName = userName;
            UserSurname = userSurname;
        }

    }
}
