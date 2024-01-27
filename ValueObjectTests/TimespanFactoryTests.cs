using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObjectTests;

[TestClass]
public class TimespanFactoryTests
{
    [TestMethod]
    public void Timespan_factory_methods()
    {
        var sixDays = TimeSpan.FromDays(6);
        var sixDaysX = new TimeSpan(6, 0, 0, 0, 0);

        var sixHours = TimeSpan.FromHours(6);
        var sixHoursX = new TimeSpan(0, 6, 0, 0, 0);

        var sixMinutes = TimeSpan.FromMinutes(6);
        var sixMinutesX = new TimeSpan(0, 0, 6, 0, 0);

        var sixSeconds = TimeSpan.FromSeconds(6);
        var sixSecondsX = new TimeSpan(0, 0, 0, 6, 0);

        var sixMilliseconds = TimeSpan.FromMilliseconds(6);
        var sixMillisecondsX = new TimeSpan(0, 0, 0, 0, 6);

        Assert.AreEqual(sixDays, sixDaysX);
        Assert.AreEqual(sixHours, sixHoursX);
        Assert.AreEqual(sixMinutes, sixMinutesX);
        Assert.AreEqual(sixSeconds, sixSecondsX);
        Assert.AreEqual(sixMilliseconds, sixMillisecondsX);
    }
}
