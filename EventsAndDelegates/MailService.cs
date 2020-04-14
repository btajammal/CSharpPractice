using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAnsDelegates
{
    // This class will send email, once videos are encoded
    public class MailService
    {
        //Event Handler
        public void OnVideoEncoded(Object source, EventArgs args)
        {
            Console.WriteLine("MailService:  Sending Email");

        }
    }
}
