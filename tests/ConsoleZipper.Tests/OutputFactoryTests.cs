using System;
using System.Collections.Generic;
using System.Text;
using ConsoleZipper.Factory;
using ConsoleZipper.Factory.Concrete;
using ConsoleZipper.Factory.Interfaces;
using NUnit.Framework;

namespace ConsoleZipper.Tests
{
    [TestFixture]
    public class OutputFactoryTests
    {
        [Test]
        public void CanCreateInstanceOfOutputFactory()
        {
            var factory = new OutputFactory();

            Assert.IsInstanceOf<IOutputFactory>(factory);
        }
    }
}
