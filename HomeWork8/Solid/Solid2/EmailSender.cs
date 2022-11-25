using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid2
{
    internal class EmailSender
    {
        ILogger Logger { get; set; }
        public EmailSender(ILogger logger)
        {
            Logger = logger;
        }

        public void Send(Email email)
        {
            // ... sending...
            logger.LogMessage(email);
        }
    }
}
