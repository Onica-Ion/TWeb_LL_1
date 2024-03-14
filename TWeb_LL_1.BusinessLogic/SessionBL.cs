using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWeb_LL_1.BusinessLogic.Core;
using TWeb_LL_1.BusinessLogic.Interfaces;
using TWeb_LL_1.Domain.Entities.User;

namespace TWeb_LL_1.BusinessLogic
{
     public class SessionBL : UserApi, ISession
     {
          public ULoginData UserLogin(ULoginData _login)
          {
               return _login;
          }
     }
}
