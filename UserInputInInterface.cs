using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface UserInputInterface
    {
        int userInput(int userId);
    }

    class UserInput: UserInputInterface
    {
        public int userInput(int userId)
        {
            return userId;
        }
    }
}
