using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWeb_LL_1.Domain.Entities.User;

namespace TWeb_LL_1.BusinessLogic.Interfaces
{
     public interface ISession
     {
          ULoginData UserLogin(ULoginData _login);
     }
}
