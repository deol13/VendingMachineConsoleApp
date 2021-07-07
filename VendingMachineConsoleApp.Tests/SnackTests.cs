using System;
using Xunit;
using VendingMachineConsoleApp.Data;

namespace VendingMachineConsoleApp.Tests
{
    public class SnackTests
    {
        /////////////////////////////////////////Constructor Tests
        [Fact]
        public void Constructor_ValidInput()
        {
            //Assign
            string name = "Marsbar";
            string type = "Candy bar";
            int price = 15;
            int weight = 60;

            //Act
            Snack snack = new Snack(name, type, weight, price);

            //Assert
            Assert.NotNull(snack);
            Assert.Equal(name, snack.Name);
            Assert.Equal(type, snack.Type);
            Assert.Equal(price, snack.Price);
            Assert.Equal(weight, snack.Weight);
        }
        [Fact]
        public void Constructor_NullString_Input()
        {
            //Assign
            string name = null;
            string type = "Candy bar";
            int price = 15;
            int weight = 60;
            string expectedExceptionMessage = "Empty or only whitespace is not allowed.";

            //Act
            ArgumentException result = Assert.Throws<ArgumentException>(() => new Snack(name, type, weight, price));

            //Assert
            Assert.Equal(expectedExceptionMessage, result.Message);
        }
        [Fact]
        public void Constructor_WhiteSpaceString_Input()
        {
            //Assign
            string name = " ";
            string type = "Candy bar";
            int price = 15;
            int weight = 60;
            string expectedExceptionMessage = "Empty or only whitespace is not allowed.";

            //Act
            ArgumentException result = Assert.Throws<ArgumentException>(() => new Snack(name, type, weight, price));

            //Assert
            Assert.Equal(expectedExceptionMessage, result.Message);
        }
        [Fact]
        public void Constructor_EmptyString_Input()
        {
            //Assign
            string name = "";
            string type = "Candy bar";
            int price = 15;
            int weight = 60;
            string expectedExceptionMessage = "Empty or only whitespace is not allowed.";

            //Act
            ArgumentException result = Assert.Throws<ArgumentException>(() => new Snack(name, type, weight, price));

            //Assert
            Assert.Equal(expectedExceptionMessage, result.Message);
        }
        [Fact]
        public void Constructor_Zero_Input()
        {
            //Assign
            string name = "Marsbar";
            string type = "Candy bar";
            int price = 0;
            int weight = 60;
            string expectedExceptionMessage = "0 or less price is not allowed.";

            //Act
            ArgumentException result = Assert.Throws<ArgumentException>(() => new Snack(name, type, weight, price));

            //Assert
            Assert.Equal(expectedExceptionMessage, result.Message);
        }
        [Fact]
        public void Constructor_LessThanZero_Input()
        {
            //Assign
            string name = "Marsbar";
            string type = "Candy bar";
            int price = 15;
            int weight = -80;
            string expectedExceptionMessage = "0 or less price is not allowed.";

            //Act
            ArgumentException result = Assert.Throws<ArgumentException>(() => new Snack(name, type, weight, price));

            //Assert
            Assert.Equal(expectedExceptionMessage, result.Message);
        }


        ////////////////////////////////////////////Examine and Use tests
        [Fact]
        public void Examine_Test()
        {
            //Assign
            string name = "Marsbar";
            string type = "Candy bar";
            int price = 15;
            int weight = 60;

            Snack snack = new Snack(name, type, weight, price);

            string expectedString = $"Name: {name}\nPrice: {price}\nType of snack: {type}\nWeighs: {weight}grams\n";

            //Act
            string result = snack.Examine();

            //Assert
            Assert.Equal(expectedString, result);
        }
        [Fact]
        public void Use_Test()
        {
            //Assign
            string name = "Marsbar";
            string type = "Candy bar";
            int price = 15;
            int weight = 60;

            Snack snack = new Snack(name, type, weight, price);

            string expectedString = "Unwrap/Open and start eating.";

            //Act
            string result = snack.Use();

            //Assert
            Assert.Equal(expectedString, result);
        }



        /////////////////////////////////////////////Get method tested
        [Fact]
        public void AllGetMethods_Test()
        {
            //Assign
            string expectedName = "Marsbar";
            string expectedType = "Candy bar";
            int expectedPrice = 15;
            int expectedWeight = 60;

            Snack snack = new Snack(expectedName, expectedType, expectedWeight, expectedPrice);

            //Act
            string actualName = snack.Name;
            string actualType = snack.Type;
            int actualWeight = snack.Weight;
            int actualPrice = snack.Price;

            //Assert
            Assert.Equal(expectedName, actualName);
            Assert.Equal(expectedType, actualType);
            Assert.Equal(expectedWeight, actualWeight);
            Assert.Equal(expectedPrice, actualPrice);
        }
    }
}
