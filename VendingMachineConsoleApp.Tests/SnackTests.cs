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
            int calories = 300;
            bool peanutsOrNot = true;

            //Act
            Snack snack = new Snack(name, type, price, weight, calories, peanutsOrNot);

            //Assert
            Assert.NotNull(snack);
            Assert.Equal(name, snack.Name);
            Assert.Equal(type, snack.Type);
            Assert.Equal(price, snack.Price);
            Assert.Equal(calories, snack.Calories);
            Assert.Equal(peanutsOrNot, snack.PeanutsOrNot);
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
            int calories = 300;
            bool peanutsOrNot = true;
            string expectedExceptionMessage = "Empty or only whitespace is not allowed.";

            //Act
            ArgumentException result = Assert.Throws<ArgumentException>(() => new Snack(name, type, price, weight, calories, peanutsOrNot));

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
            int calories = 300;
            bool peanutsOrNot = true;
            string expectedExceptionMessage = "Empty or only whitespace is not allowed.";

            //Act
            ArgumentException result = Assert.Throws<ArgumentException>(() => new Snack(name, type, price, weight, calories, peanutsOrNot));

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
            int calories = 300;
            bool peanutsOrNot = true;
            string expectedExceptionMessage = "Empty or only whitespace is not allowed.";

            //Act
            ArgumentException result = Assert.Throws<ArgumentException>(() => new Snack(name, type, price, weight, calories, peanutsOrNot));

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
            int calories = 300;
            bool peanutsOrNot = true;
            string expectedExceptionMessage = "0 or less price is not allowed.";

            //Act
            ArgumentException result = Assert.Throws<ArgumentException>(() => new Snack(name, type, price, weight, calories, peanutsOrNot));

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
            int weight = -60;
            int calories = 300;
            bool peanutsOrNot = true;
            string expectedExceptionMessage = "0 or less price is not allowed.";

            //Act
            ArgumentException result = Assert.Throws<ArgumentException>(() => new Snack(name, type, price, weight, calories, peanutsOrNot));

            //Assert
            Assert.Equal(expectedExceptionMessage, result.Message);
        }


        ////////////////////////////////////////////Examine and Use tests
        [Fact]
        public void Examine_Peanuts_Test()
        {
            //Assign
            string name = "Marsbar";
            string type = "Candy bar";
            int price = 15;
            int weight = 60;
            int calories = 300;
            bool peanutsOrNot = true;

            Snack snack = new Snack(name, type, price, weight, calories, peanutsOrNot);

            string expectedString = "---- Snack ----\n";
            expectedString += $"Name: {name}\nType: {type}\nPrice: {price}kr\n";
            expectedString += $"Weighs: {weight}grams\nCalories: {calories}\n";
            expectedString += " Do contain peanuts.\n";

            //Act
            string result = snack.Examine();

            //Assert
            Assert.Equal(expectedString, result);
        }
        [Fact]
        public void Examine_noPeanuts_Test()
        {
            //Assign
            string name = "Marsbar";
            string type = "Candy bar";
            int price = 15;
            int weight = 60;
            int calories = 300;
            bool peanutsOrNot = false;

            Snack snack = new Snack(name, type, price, weight, calories, peanutsOrNot);

            string expectedString = "---- Snack ----\n";
            expectedString += $"Name: {name}\nType: {type}\nPrice: {price}kr\n";
            expectedString += $"Weighs: {weight}grams\nCalories: {calories}\n";
            expectedString += " Do not contain peanuts.\n";

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
            int calories = 300;
            bool peanutsOrNot = true;

            Snack snack = new Snack(name, type, price, weight, calories, peanutsOrNot);

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
            int expectedCalories = 300;
            bool expectedPeanutsOrNot = true;

            Snack snack = new Snack(expectedName, expectedType, expectedPrice, expectedWeight, expectedCalories, expectedPeanutsOrNot);

            //Act
            string actualName = snack.Name;
            string actualType = snack.Type;
            int actualWeight = snack.Weight;
            int actualPrice = snack.Price;
            int actualCalories = snack.Calories;
            bool actualPeanuts = snack.PeanutsOrNot;

            //Assert
            Assert.Equal(expectedName, actualName);
            Assert.Equal(expectedType, actualType);
            Assert.Equal(expectedWeight, actualWeight);
            Assert.Equal(expectedPrice, actualPrice);
            Assert.Equal(expectedCalories, actualCalories);
            Assert.Equal(expectedPeanutsOrNot, actualPeanuts);
        }
    }
}
