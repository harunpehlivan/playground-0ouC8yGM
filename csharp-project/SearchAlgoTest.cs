using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.IO;

namespace SearchAlgo
{
    [TestClass]
    public class SearchAlgoTest
    {
        [TestMethod]
        public void comparisonBFS_BMS() 
        {
            SearchAlgoComparison.run_comparison();
        }
    }
}
