using DomainServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObjectPractice;

namespace ValueObjectTests;

[TestClass]
public class MicroTypesTests
{
    [TestMethod]
    public void Calculate_overtime_hours()
    {
        var hoursWorked = Hours.Create(45);
        var contractedHourse = Hours.Create(40);

        var hoursWorkedx = HourseWorked.Create(hoursWorked);
        var contractedHoursx = ContractedHours.Create(contractedHourse);

        var overtimeCalculator = new OvertimeCalculator();
        var overtimeHours = overtimeCalculator.Calculate(hoursWorkedx, contractedHoursx);

        Assert.AreEqual(OvertimeHours.Create(Hours.Create(5)), overtimeHours);
    }
}
