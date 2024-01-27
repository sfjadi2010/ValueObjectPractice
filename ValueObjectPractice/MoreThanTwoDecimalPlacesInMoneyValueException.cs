using System.Runtime.Serialization;

namespace ValueObjectPractice;

[Serializable]
internal class MoreThanTwoDecimalPlacesInMoneyValueException : Exception
{
    public MoreThanTwoDecimalPlacesInMoneyValueException()
    {
    }

    public MoreThanTwoDecimalPlacesInMoneyValueException(string? message) : base(message)
    {
    }

    public MoreThanTwoDecimalPlacesInMoneyValueException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected MoreThanTwoDecimalPlacesInMoneyValueException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}