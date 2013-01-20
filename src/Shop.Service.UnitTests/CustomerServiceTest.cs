using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Moq;

namespace Shop.Service.UnitTests
{
    [TestFixture]
    public class CustomerServiceTest
    {
        [Test]
        public void GetAll_InvokesRepository()
        {
            // Arrange
            var mockedRepository = new Mock<ICustomerRepository>();
            var service = new CustomerService(mockedRepository.Object);

            // Act
            service.Get(new Customers());

            // Assert
            mockedRepository.Verify(x => x.GetAll(), Times.Once());
        }
    }
}
