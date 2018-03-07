﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeaselHelper395.EnterpriseFeeling;

namespace WeaselHelper395.Tests
{
    [TestClass]
    public class BasicProjectRequirements
    {
        [TestMethod]
        public void ShouldHaveEnterpriseFeeling()
        {
            var sut = new AbstractServiceHelperFactoryGeneratorMiddelwarePoolAdapter();

            Assert.IsNotNull(sut);
        }
    }
}
