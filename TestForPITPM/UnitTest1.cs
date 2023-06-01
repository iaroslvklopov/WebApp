using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WebApplication1;

namespace ModulTest
{
	[TestClass]
	public class ModulTest
	{

		[TestMethod]
		public void datab()
		{
			bool expected = true;
			var af = new Vhod();
			bool actual = af.db();
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void newzayavka()
		{
			bool expected = true;
			var af = new HomeController();
			bool actual = af.auth("almira", "123");
			Assert.AreEqual(expected, actual);
		}
	}
}
