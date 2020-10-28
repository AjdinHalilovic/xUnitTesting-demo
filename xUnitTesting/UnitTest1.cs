using Moq;
using System;
using WebApplication1.Controllers;
using Xunit;

namespace xUnitTesting
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(2,3)]
        public void Sabiranje(int a,int b)
        {
            //Arrange
            var expected = 5;
            Mock<IValuesService> valuesService = new Mock<IValuesService>();
            valuesService.Setup(x => x.Add(a, b)).Returns(5);
            ValuesController valuesController = new ValuesController(valuesService.Object);

            // Act
            var actual = valuesController.Get(a,b);

            //Assert
            Assert.Equal(expected, actual);
        }


        
    }
}
