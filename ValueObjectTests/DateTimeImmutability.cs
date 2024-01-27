using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObjectTests;

[TestClass]
public class DateTimeImmutability
{
    [TestMethod]
    public void AddMonths_create_new_immutable_DateTime()
    {
        var janlst = new DateTime(2024, 1, 1);
        var feblst = janlst.AddMonths(1);

        Assert.AreEqual(new DateTime(2024, 1,1), janlst);

        Assert.AreEqual(new DateTime(2024, 2, 1), feblst);
    }

    [TestMethod]
    public void AddYear_create_new_immutable_DateTime()
    {
        var janlst = new DateTime(2024, 1, 1);
        var janlstNextYear = janlst.AddYears(1);

        Assert.AreEqual(new DateTime(2024, 1, 1), janlst);

        Assert.AreEqual(new DateTime(2025, 1, 1), janlstNextYear);
    }
}
