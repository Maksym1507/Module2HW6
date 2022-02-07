using System;

namespace Module2HW6.Exceptions
{
    public class BusinessException : Exception
    {
        public BusinessException(string message, double value)
            : base(message)
        {
            Value = value;
        }

        public double Value { get; set; }
    }
}
