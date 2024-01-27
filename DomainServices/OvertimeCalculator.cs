using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObjectPractice;

namespace DomainServices;

public class OvertimeCalculator
{
    public OvertimeHours Calculate(HourseWorked hourseWorked, ContractedHours contractedHours)
    {
        var overtimeHours = hourseWorked.Hours - contractedHours.Hours;
        return OvertimeHours.Create(overtimeHours);
    }
}
