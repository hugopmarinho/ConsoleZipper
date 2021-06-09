using System.IO;
using ConsoleZipper.Core;
using ConsoleZipper.Core.Entities.Interfaces;
using ConsoleZipper.Core.Interfaces;
using ConsoleZipper.Factory.Interfaces;
using Moq;
using NUnit.Framework;

namespace ConsoleZipper.Tests
{
    [TestFixture]
    public class ProcessorTests
    {
        [Test]
        public void CanCreateInstanceOfProcessor()
        {
            var validatorMock = new Mock<IValidator>();
            var helperMock = new Mock<IHelper>();
            var outputFactoryMock = new Mock<IOutputFactory>();

            var processor = new Processor(validatorMock.Object, helperMock.Object, outputFactoryMock.Object);

            Assert.IsNotNull(processor);
            Assert.IsInstanceOf<IProcessor>(processor);
        }

        
    }
}
