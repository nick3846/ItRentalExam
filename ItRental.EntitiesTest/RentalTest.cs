using ItRental.Entities;
using System;
using Xunit;

namespace ItRental.EntitiesTest
{
    public class RentalTest
    {
        [Fact]
        public void IsRentalOverdue_ReturnsTrueWhenOverdue()
        {
            //Arrange
            Rental rental = new Rental
            {
                ReturnTime = DateTime.Now.AddDays(1)
            };
            //Act

            //Assert
            Assert.True(rental.IsRentalOverdue());
        }
        [Fact]
        public void IsRentalOverdue_ReturnsFalseWhenNotOverdue()
        {
            //Arrange
            Rental rental = new Rental
            {
                ReturnTime = DateTime.Now.AddDays(-1)
            };
            //Act

            //Assert
            Assert.False(rental.IsRentalOverdue());
        }
        
    }
}
