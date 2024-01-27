using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObjectPractice;

namespace ValueObjectTests;

[TestClass]
public  class NameValidationTests
{
    [TestMethod]
    public void First_name_cannot_be_empty()
    {
		try
		{
			var name = Name.Create("", "Farsi");
		}
		catch (ApplicationException ex)
		{

			Assert.AreEqual("You must specify a first name.", ex.Message);
		}
    }

	[TestMethod]
	public void Last_name_cannot_be_empty()
	{
        try
		{
            var name = Name.Create("Mehdi", "");
        }
        catch (ApplicationException ex)
		{

            Assert.AreEqual("You must specify a last name.", ex.Message);
        }
    }
}
