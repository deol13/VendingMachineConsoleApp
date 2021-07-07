using System;
using Xunit;
using VendingMachineConsoleApp.Data;

namespace VendingMachineConsoleApp.Tests
{
    public class ToyTests
    {
        /////////////////////////////////////////Constructor Tests
        [Fact]
        public void Constructor_ValidInput()
        {
            //Assign
            string name = "Winnie the Pooh";
            string type = "Stuffed Bear";
            int price = 20;

            //Act
            Toy toy = new Toy(name, type, price);

            //Assert
            Assert.NotNull(toy);
            Assert.Equal(name, toy.Name);
            Assert.Equal(type, toy.Type);
            Assert.Equal(price, toy.Price);
            Assert.NotEqual(name, toy.Type);
            Assert.NotEqual(type, toy.Name);
        }
        [Fact]
        public void Constructor_NullString_Input()
        {
            //Assign
            string name = "Winnie the Pooh";
            string type = null;
            int price = 20;
            string expectedExceptionMessage = "Empty or only whitespace is not allowed.";

            //Act
            ArgumentException result = Assert.Throws<ArgumentException>(() => new Toy(name, type, price));

            //Assert
            Assert.Equal(expectedExceptionMessage, result.Message);
        }
        [Fact]
        public void Constructor_WhiteSpaceString_Input()
        {
            //Assign
            string name = " ";
            string type = "Stuffed Bear";
            int price = 20;
            string expectedExceptionMessage = "Empty or only whitespace is not allowed.";

            //Act
            ArgumentException result = Assert.Throws<ArgumentException>(() => new Toy(name, type, price));

            //Assert
            Assert.Equal(expectedExceptionMessage, result.Message);
        }
        [Fact]
        public void Constructor_EmptyString_Input()
        {
            //Assign
            string name = "";
            string type = "";
            int price = 20;
            string expectedExceptionMessage = "Empty or only whitespace is not allowed.";

            //Act
            ArgumentException result = Assert.Throws<ArgumentException>(() => new Toy(name, type, price));

            //Assert
            Assert.Equal(expectedExceptionMessage, result.Message);
        }
        [Fact]
        public void Constructor_Zero_Input()
        {
            //Assign
            string name = "Winnie the Pooh";
            string type = "Stuffed Bear";
            int price = 0;
            string expectedExceptionMessage = "0 or less price is not allowed.";

            //Act
            ArgumentException result = Assert.Throws<ArgumentException>(() => new Toy(name, type, price));

            //Assert
            Assert.Equal(expectedExceptionMessage, result.Message);
        }
        [Fact]
        public void Constructor_LessThanZero_Input()
        {
            //Assign
            string name = "Winnie the Pooh";
            string type = "Stuffed Bear";
            int price = -10;
            string expectedExceptionMessage = "0 or less price is not allowed.";

            //Act
            ArgumentException result = Assert.Throws<ArgumentException>(() => new Toy(name, type, price));

            //Assert
            Assert.Equal(expectedExceptionMessage, result.Message);
        }


        ////////////////////////////////////////////Examine and Use tests
        [Fact]
        public void Examine_Test()
        {
            string name = "Winnie the Pooh";
            string type = "Stuffed Bear";
            int price = 20;

            Toy toy = new Toy(name, type, price);

            string expectedString = $"Name: {name}\nPrice: {price}\nType of toy: {type}\n";

            //Act
            string result = toy.Examine();

            //Assert
            Assert.Equal(expectedString, result);
        }
        [Fact]
        public void Use_Test()
        {
            string name = "Winnie the Pooh";
            string type = "Stuffed Bear";
            int price = 20;

            Toy toy = new Toy(name, type, price);

            string expectedString = "You can play with it";

            //Act
            string result = toy.Use();

            //Assert
            Assert.Equal(expectedString, result);
        }


        /////////////////////////////////////////////Get method tested
        [Fact]
        public void AllGetMethods_Test()
        {
            //Assign
            string expectedName = "Winnie the Pooh";
            string expectedType = "Stuffed Bear";
            int expectedPrice = 20;

            Toy toy = new Toy(expectedName, expectedType, expectedPrice);

            //Act
            string actualName = toy.Name;
            string actualType = toy.Type;
            int actualPrice = toy.Price;

            //Assert
            Assert.Equal(expectedName, actualName);
            Assert.Equal(expectedType, actualType);
            Assert.Equal(expectedPrice, actualPrice);
        }
    }
}
