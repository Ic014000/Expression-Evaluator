﻿using NUnit.Framework;
using Vanderbilt.Biostatistics.Wfccm2;

namespace ExpressionEvaluatorTests
{
    [TestFixture]
    public class CeilingTest
    {
        private Expression func;

        [SetUp]
        public void init() { func = new Expression(""); }

        [TearDown]
        public void clear() { func.Clear(); }

        [Test]
        public void Ceiling_InnerCalclationAdd_CorrectValue()
        {
            func.Function = @"ceiling(3+1.5)";
            Assert.AreEqual(5, func.EvaluateNumeric());
        }

        [Test]
        public void Ceiling_InnerCalculation_CorrectValue()
        {
            func.Function = @"ceiling(3.1)";
            Assert.AreEqual(4, func.EvaluateNumeric());
        }

        [Test]
        public void Ceiling_InnerCalculationDevide_CorrectValue()
        {
            func.Function = @"ceiling(5/3)";
            Assert.AreEqual(2, func.EvaluateNumeric());
        }

        [Test]
        public void Ceiling_InnerCalculationMulti_CorrectValue()
        {
            func.Function = @"ceiling(5*1.5)";
            Assert.AreEqual(8, func.EvaluateNumeric());
        }

        [Test]
        public void Ceiling_InnerCalculationSubstract_CorrectValue()
        {
            func.Function = @"ceiling(2.56 -1.5)";
            Assert.AreEqual(2, func.EvaluateNumeric());
        }

        [Test]
        public void Ceiling_MidPoint001_CorrectValue()
        {
            func.Function = @"ceiling(1.5*0)";
            Assert.AreEqual(0, func.EvaluateNumeric());
        }

        [Test]
        public void Ceiling_InnerCalculationNegative_CorrectValue()
        {
            func.Function = @"ceiling(-0.12 )";
            Assert.AreEqual(0, func.EvaluateNumeric());
        }
        [Test]
        public void Ceiling_InnerCalculationNegativeRound_CorrectValue()
        {
            func.Function = @"ceiling(-7.12 )";
            Assert.AreEqual(-7, func.EvaluateNumeric());
        }
    }
}
