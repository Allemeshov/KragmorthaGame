using System;

namespace KragmortaApp
{
    public class KragException : Exception
    {
        public KragException()
        {
        }

        public KragException(string message) : base(message)
        {
        }
    }
}