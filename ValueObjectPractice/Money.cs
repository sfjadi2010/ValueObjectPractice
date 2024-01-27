using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObjectPractice;

public class Money : ValueObject<Money>
{
    protected readonly decimal Value;

    private Money() : this(0m)
    {
    }

    private Money(decimal value)
    {
        Validate(value);

        Value = value;
    }

    public static Money Create(decimal value)
    {
        return new Money(value);
    }

    public Money Add(Money money)
    {
        return new Money(Value + money.Value);
    }

    public static Money operator +(Money left, Money right)
    {
        return new Money(left.Value + right.Value);
    }

    public Money Subtract(Money money)
    {
        return new Money(Value - money.Value);
    }
    public static Money operator -(Money left, Money right)
    {
        return new Money(left.Value - right.Value);
    }

    private void Validate(decimal value)
    {
        if (value % 0.01m != 0)
        {
            throw new MoreThanTwoDecimalPlacesInMoneyValueException();
        }

        if (value < 0)
        {
            throw new MoneyCannotBeNegativeValueException();
        }
    }
    protected override  IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
    {
        return new List<Object> { Value };
    }

    
}