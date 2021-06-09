using System;
using ConsoleZipper.Core;
using ConsoleZipper.Core.Entities.Interfaces;
using ConsoleZipper.Core.Interfaces;
using Moq;
using NUnit.Framework;

namespace ConsoleZipper.Tests
{
    [TestFixture]
    public class StarterTests
    {
        [Test]
        public void CanCreateInstanceOfStarter()
        {
            var processorMock = new Mock<IProcessor>();
            var starter = new Starter(processorMock.Object);

            Assert.IsNotNull(starter);
            Assert.IsInstanceOf<IServiceStarter>(starter);

        }

        [Test]
        public void CanCallRun()
        {
            var args = new [] {"arg1", "arg2", "arg3", "arg4", "arg5", "arg6"};
            var processorMock = new Mock<IProcessor>();

            var starter = new Starter(processorMock.Object);

            Assert.DoesNotThrow(() => starter.Run(args));
        }

        [Test]
        public void CanCallStartAsync()
        {
            var optionsMock = new Mock<CommandLineOptions>();
            var processorMock = new Mock<IProcessor>();
            var starter = new Starter(processorMock.Object);

            starter.StartAsync(optionsMock.Object);

            processorMock.Verify(p => p.Process(It.IsAny<CommandLineOptions>()), Times.Once());
        }
    }
}
