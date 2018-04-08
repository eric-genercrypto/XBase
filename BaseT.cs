using System;

namespace XBase
{
    public class BaseT
    {
        private readonly string _line;
        public BaseT(string line)
        {
            _line = line;    
        }

        public BaseT()
        {
            _line = "2018-05-14 12:00:00";    
        }

        public long ToMilliSeconds()
        {
            var line = DateTime.Parse(_line);
            var diff = line.Subtract(DateTime.Now);
            var msecs = diff.TotalMilliseconds;

            return (long)Math.Truncate(msecs);
        }

        public int ToSeconds()
        {
            var line = DateTime.Parse(_line);
            var diff = line.Subtract(DateTime.Now);
            var secs = diff.TotalSeconds;

            return (int)Math.Truncate(secs);
        }
    }
}