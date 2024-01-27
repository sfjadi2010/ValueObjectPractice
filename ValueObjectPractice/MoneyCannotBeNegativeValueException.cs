using System.Runtime.Serialization;

namespace ValueObjectPractice
{
    [Serializable]
    internal class MoneyCannotBeNegativeValueException : Exception
    {
        public MoneyCannotBeNegativeValueException()
        {
        }

        public MoneyCannotBeNegativeValueException(string? message) : base(message)
        {
        }

        public MoneyCannotBeNegativeValueException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected MoneyCannotBeNegativeValueException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}