using WebApplication1;

namespace TestProject
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void datab()
		{
			bool expected = true;
			var af = new Tests();
			bool actual = af.datab();
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void checkmanager()
		{
			bool expected = true;
			var af = new Tests();
			bool actual = af.man();
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void newzayavka()
		{
			bool expected = true;
			var af = new Tests();
			bool actual = af.addzayavka("viktor", "898989", "1");
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void checkzayavka()
		{
			bool expected = true;
			var af = new Tests();
			bool actual = af.check("898989");
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void allinone()
		{
			bool expected = true;
			var af = new Tests();
			bool actual = af.all("anton", "123456789", "1");
			Assert.AreEqual(expected, actual);
		}
	}
}