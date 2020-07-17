using System;

namespace BT_xay_dung_lop_StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            StopWatch wacth = new StopWatch();
            wacth.Start();
            int x = 0;
            while (x < 10000)
            {
                Console.WriteLine (x);
                x++;
            }
            wacth.Stop();
            Console.WriteLine("thơi gian chay " + wacth.GetElapsedTime());


        }
        public class StopWatch
        {
            private DateTime _startTime;
            private DateTime _endTime;
            public StopWatch()
            {
                _startTime = DateTime.Now;
            }
            public DateTime Start()
            {
                return _startTime;
            }
            public DateTime Stop()
            {
                return _endTime = DateTime.Now;
            }

            public DateTime getterstartTime()
            {
                return _startTime;
            }
            public DateTime getterendTime()
            {
                return _endTime;
            }
            public int GetElapsedTime()
            {
                var distance = _endTime - _startTime;
                return distance.Milliseconds;

            }
        }


    }
}
