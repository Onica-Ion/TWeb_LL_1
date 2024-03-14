using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWeb_LL_1.BusinessLogic.Interfaces;

namespace TWeb_LL_1.BusinessLogic
{
    public class BussinesLogic
    {
          public ISession GetSessionBL()
          {
               return new SessionBL();
          }
    }
}
