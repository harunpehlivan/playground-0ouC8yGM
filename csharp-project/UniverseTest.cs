using Answer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.IO;

namespace TechIo
{
    [TestClass]
    public class UniverseTest
    {
	[TestMethod]
	public void comparisonBFS_BMS() 
	{
		UniverseStub.run_comparison();
	}
    }
}
