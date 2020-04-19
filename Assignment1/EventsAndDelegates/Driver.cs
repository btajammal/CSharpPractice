using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAnsDelegates
{
    class Driver
    {
        static void Main (String[] args)
        {
            var Video = new Video { Title = "Track1" };
            var videoEncoder = new VideoEncoder(); // Publisher
            var mailService = new MailService(); // Subscriber
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded; // Register Handler to an event
            videoEncoder.Encode(Video);
        }
    }


}
