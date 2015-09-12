using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DT.Data.Tests
{
    [TestClass]
    public class DTDbContextTests
    {
        [TestMethod]
        public void Ctor()
        {
            var dbContext = new DTDbContext();
        }
    }
}
