using System;
using System.Threading;

namespace EventsAnsDelegates
{ 
    public class VideoEncoder
    {
        // 1 - Define Delegate (Defines Contract between publisher and subscriber)
        public delegate void VideoEncodedEventHandler(Object source, EventArgs args);

        // 2 - Define Event Based on Delegate
        public event VideoEncodedEventHandler VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video");
            Thread.Sleep(3000);

        // 3 - Publish Event(notify subscriber)
            OnVideoEncoded();
        }

        public virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, EventArgs.Empty);
            }
        }
       
    }
}