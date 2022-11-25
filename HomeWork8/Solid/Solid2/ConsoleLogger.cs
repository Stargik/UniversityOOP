using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid2
{
    internal class ConsoleLogger : ILogger
    {
        public void LogMessage(Email email)
        {
            Console.WriteLine("Email from '" + email.From + "' to '" + email.To + "' was send");
        }
    }
}
