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


        ////////////////////////////////////////////SetStringfields tests
        [Fact]
        public void SetStringFields_ValidInput()
        {
            //Assign
            string name = "Marsbar";
            string type = "Candy bar";
            int price = 15;
            int weight = 60;
            Snack snack = new Snack(name, type, weight, price);

            string newName = "Kit Kat";

            //Act
            snack.SetStringFields(newName, 1);  //1 is the case for name

            //Assert
            Assert.NotNull(snack);
            Assert.Equal(newName, snack.Name);
            Assert.NotEqual(newName, snack.Type);
        }
        [Fact]
        public void SetStringFields_NullString_Input()
        {
            // Assign
            string name = "Marsbar";
            string type = "Candy bar";
            int price = 15;
            int weight = 60;
            Snack snack = new Snack(name, type, weight, price);

            string newName = null;
            string expectedExceptionMessage = "Empty or only whitespace is not allowed.";

            //Act
            //1 in SetStringFields is the case for name
            ArgumentException result = Assert.Throws<ArgumentException>(() => snack.SetStringFields(newName, 1));

            //Assert
            Assert.Equal(expectedExceptionMessage, result.Message);
        }
        [Fact]
        public void SetStringFields_WhiteSpaceString_Input()
        {
            // Assign
            string name = "Marsbar";
            string type = "Candy bar";
            int price = 15;
            int weight = 60;
            Snack snack = new Snack(name, type, weight, price);

            string newName = " ";
            string expectedExceptionMessage = "Empty or only whitespace is not allowed.";

            //Act
            //2 in SetStringFields is the case for name
            ArgumentException result = Assert.Throws<ArgumentException>(() => snack.SetStringFields(newName, 1));

            //Assert
            Assert.Equal(expectedExceptionMessage, result.Message);
        }
        [Fact]
        public void SetStringFields_EmptyString_Input()
        {
            // Assign
            string name = "Marsbar";
            string type = "Candy bar";
            int price = 15;
            int weight = 60;
            Snack snack = new Snack(name, type, weight, price);

            string newName = "";
            string expectedExceptionMessage = "Empty or only whitespace is not allowed.";

            //Act
            //2 in SetStringFields is the case for name
            ArgumentException result = Assert.Throws<ArgumentException>(() => snack.SetStringFields(newName, 1));

            //Assert
            Assert.Equal(expectedExceptionMessage, result.Message);
        }


        ////////////////////////////////////////////SetIntfields tests
        [Fact]
        public void SetIntFields_ValidInput()
        {
            //Assign
            string name = "Marsbar";
            string type = "Candy bar";
            int oldPrice = 15;
            int weight = 60;
            Snack snack = new Snack(name, type, weight, oldPrice);

            int newPrice = 30;

            //Act
            snack.SetIntFields(newPrice, 1);  //1 is the case for price

            //Assert
            Assert.NotNull(snack);
            Assert.Equal(newPrice, snack.Price);
            Assert.NotEqual(oldPrice, snack.Price);
        }
        [Fact]
        public void SetIntFields_Zero_Input()
        {
            //Assign
            string name = "Marsbar";
            string type = "Candy bar";
            int price = 15;
            int weight = 60;
            Snack snack = new Snack(name, type, weight, price);

            int newPrice = 0;
            string expectedExceptionMessage = "0 or less price is not allowed.";

            //Act
            ArgumentException result = Assert.Throws<ArgumentException>(() => snack.SetIntFields(newPrice, 1));

            //Assert
            Assert.Equal(expectedExceptionMessage, result.Message);

        }
        [Fact]
        public void SetIntFields_LessThanZero_Input()
        {
            //Assign
            string name = "Marsbar";
            string type = "Candy bar";
            int price = 15;
            int weight = 60;
            Snack snack = new Snack(name, type, weight, price);

            int newPrice = -43;
            string expectedExceptionMessage = "0 or less price is not allowed.";

            //Act
            ArgumentException result = Assert.Throws<ArgumentException>(() => snack.SetIntFields(newPrice, 1));

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

            string expectedString = $"{type} named {name}, weights {weight} and is priced at {price}.";

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
    }
}
