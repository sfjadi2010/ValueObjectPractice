using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObjectPractice;

namespace ValueObjectTests;

[TestClass]
public class MoneyObjectCombining
{
    [TestMethod]
    public void Money_Supports_native_addtion_syntax()
    {
        var initialDeposit = Money.Create(100m);
        var laterDeposit = Money.Create(200m);

        var total = initialDeposit + laterDeposit;

        Assert.AreEqual(Money.Create(300m), total);
    }

    [TestMethod]
    public void Money_Supports_native_subtraction_syntax()
    {
        var initialDeposit = Money.Create(100m);
        var laterDeposit = Money.Create(200m);

        var total = laterDeposit - initialDeposit;

        Assert.AreEqual(Money.Create(100m), total);
    }
}
