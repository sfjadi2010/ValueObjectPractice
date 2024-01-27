using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObjectPractice;
public class Hours : ValueObject<Hours>
{
    public readonly int Amount;
    private Hours() : this(0)
    {
    }
    private Hours(int amount)
    {
        Amount = amount;
    }
    public static Hours Create(int amount)
    {
        return new Hours(amount);
    }

    public static Hours operator -(Hours left, Hours right)
    {
        return new Hours(left.Amount - right.Amount);
    }
    protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
    {
        return new object[] { Amount };
    }
}

public class HourseWorked : ValueObject<HourseWorked>
{
    public readonly Hours Hours;
    private HourseWorked() : this(Hours.Create(0)) { }
    private HourseWorked(Hours hours)
    {
        Hours = hours;
    }
    public static HourseWorked Create(Hours hours)
    {
        return new HourseWorked(hours);
    }
    protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
    {
        return new object[] { Hours };
    }
}

public class ContractedHours : ValueObject<ContractedHours>
{
    public readonly Hours Hours;
    private ContractedHours() : this(Hours.Create(0)) { }
    private ContractedHours(Hours hours)
    {
        Hours = hours;
    }
    public static ContractedHours Create(Hours hours)
    {
        return new ContractedHours(hours);
    }
    protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
    {
        return new object[] { Hours };
    }
}

public class OvertimeHours : ValueObject<OvertimeHours>
{
    public readonly Hours Hours;
    private OvertimeHours() : this(Hours.Create(0)) { }
    private OvertimeHours(Hours hours)
    {
        Hours = hours;
    }
    public static OvertimeHours Create(Hours hours)
    {
        return new OvertimeHours(hours);
    }
    protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
    {
        return new object[] { Hours };
    }
}
