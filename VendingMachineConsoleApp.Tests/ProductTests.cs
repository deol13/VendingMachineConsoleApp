using System;
using Xunit;
using VendingMachineConsoleApp.Data;

namespace VendingMachineConsoleApp.Tests
{
    public class ProductTests
    {
        //////////////////////////////////////////CheckStringFields
        [Fact]
        public void CheckStringFields_ValidString()
        {
            //Assign
            string newName = "Winnie the Pooh";
            Toy toy = new Toy("Jack in the box", "Box", 555);
            string expectedExceptionMessage = "";

            //Act
            string result = toy.CheckStringFields(newName);

            //Assert
            Assert.Equal(newName, result);
        }
        [Fact]
        public void CheckStringFields_NullString()
        {
            //Assign
            Toy toy = new Toy("Jack in the box", "Box", 555);
            string newName = null;
            string expectedExceptionMessage = "Empty or only whitespace is not allowed.";

            //Act
            //1 in SetStringFields is the case for name
            ArgumentException result = Assert.Throws<ArgumentException>(() => toy.CheckStringFields(newName));

            //Assert
            Assert.Equal(expectedExceptionMessage, result.Message);
        }
        [Fact]
        public void CheckStringFields_WhiteSpaceString()
        {
            //Assign
            Toy toy = new Toy("Jack in the box", "Box", 555);
            string newName = " ";
            string expectedExceptionMessage = "Empty or only whitespace is not allowed.";

            //Act
            //1 in SetStringFields is the case for name
            ArgumentException result = Assert.Throws<ArgumentException>(() => toy.CheckStringFields(newName));

            //Assert
            Assert.Equal(expectedExceptionMessage, result.Message);
        }
        [Fact]
        public void CheckStringFields_EmptyString()
        {
            //Assign
            Toy toy = new Toy("Jack in the box", "Box", 555);
            string newName = "";
            string expectedExceptionMessage = "Empty or only whitespace is not allowed.";

            //Act
            //1 in SetStringFields is the case for name
            ArgumentException result = Assert.Throws<ArgumentException>(() => toy.CheckStringFields(newName));

            //Assert
            Assert.Equal(expectedExceptionMessage, result.Message);
        }


        //////////////////////////////////////////CheckIntFields
        [Fact]
        public void CheckIntFields_ValidInt() 
        {
            //Assign
            int newPrice = 44;
            int oldPrice = 555;
            Toy toy = new Toy("Jack in the box", "Box", oldPrice);

            //Act
            int result = toy.CheckIntFields(newPrice);

            //Assert
            Assert.Equal(newPrice, result);

        }
        [Fact]
        public void CheckIntFields_LessThanZero() 
        {
            //Assign
            Toy toy = new Toy("Jack in the box", "Box", 555);
            int newPrice = 0;
            string expectedExceptionMessage = "0 or less price is not allowed.";

            //Act
            ArgumentException result = Assert.Throws<ArgumentException>(() => toy.CheckIntFields(newPrice));

            //Assert
            Assert.Equal(expectedExceptionMessage, result.Message);
        }
        [Fact]
        public void CheckIntFields_Zero() 
        {
            //Assign
            Toy toy = new Toy("Jack in the box", "Box", 555);
            int newPrice = -123;
            string expectedExceptionMessage = "0 or less price is not allowed.";

            //Act
            ArgumentException result = Assert.Throws<ArgumentException>(() => toy.CheckIntFields(newPrice));

            //Assert
            Assert.Equal(expectedExceptionMessage, result.Message);
        }
    }
}
