using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss.az
{
    class UserNotFoundException:ApplicationException
    {
        public override string Message { get;}
        public UserNotFoundException()
        {

        }
    }
}
