using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler email = new EmailHandler();
            Handler sms = new SmsHandler();

            email.UstawNastepny(sms);
            email.Obsluz("test@ex.com");
            email.Obsluz("123456");
        }
    }
}
