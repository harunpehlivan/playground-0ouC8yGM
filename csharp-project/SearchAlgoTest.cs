using Answer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.IO;

namespace TechIo
{
    [TestClass]
    public class SearchAlgoTest
    {
	[TestMethod]
	public void comparisonBFS_BMS() 
	{
		SearchAlgoStub.run_comparison();
	}
    }
}
