using System.Linq;

namespace XBase 
{
    public class BaseX
    {
        private readonly string _digits;

        public BaseX(string digits)
        {
            _digits = digits;
        }

        public BaseX()
        {
            _digits = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        }
        
        public string ToBaseX(int number)
        {           
            var output = "";
            do
            {                
                output = _digits[number % _digits.Length] + output;
                number = number / _digits.Length;
            }
            while (number > 0);
            return output;
        }

        public string ToBaseXX(long number)
        {           
            var output = "";
            do
            {   var len =  _digits.Length;
                long loc = number % (long)len;            
                output = _digits[(int)loc] + output;
                number = number / _digits.Length;
            }
            while (number > 0);
            return output;
        }

        public long FromBaseX(string number)
        {
            return number.Aggregate(0, (a, c) => a*_digits.Length + _digits.IndexOf(c));
        }
    }
}
