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


        ////////////////////////////////////////////SetStringfields tests
        [Fact]
        public void SetStringFields_ValidInput()
        {
            //Assign
            string newName = "Winnie the Pooh";
            string newType = "Stuffed Bear";
            Toy toy = new Toy("Jack in the box", "Box", 555);

            //Act
            toy.SetStringFields(newName, 1);  //1 is the case for name
            toy.SetStringFields(newType, 2);     //2 is the case for type

            //Assert
            Assert.NotNull(toy);
            Assert.Equal(newName, toy.Name);
            Assert.Equal(newType, toy.Type);
            Assert.NotEqual(newName, toy.Type);
            Assert.NotEqual(newType, toy.Name);
        }
        [Fact]
        public void SetStringFields_NullString_Input()
        {
            // Assign
            Toy toy = new Toy("Jack in the box", "Box", 555);
            string newName = null;
            string expectedExceptionMessage = "Empty or only whitespace is not allowed.";

            //Act
            //1 in SetStringFields is the case for name
            ArgumentException result = Assert.Throws<ArgumentException>(() => toy.SetStringFields(newName, 1));

            //Assert
            Assert.Equal(expectedExceptionMessage, result.Message);
        }
        [Fact]
        public void SetStringFields_WhiteSpaceString_Input()
        {
            // Assign
            Toy toy = new Toy("Jack in the box", "Box", 555);
            string newName = " ";
            string expectedExceptionMessage = "Empty or only whitespace is not allowed.";

            //Act
            //1 in SetStringFields is the case for name
            ArgumentException result = Assert.Throws<ArgumentException>(() => toy.SetStringFields(newName, 1));

            //Assert
            Assert.Equal(expectedExceptionMessage, result.Message);
        }
        [Fact]
        public void SetStringFields_EmptyString_Input()
        {
            // Assign
            Toy toy = new Toy("Jack in the box", "Box", 555);
            string newName = "";
            string expectedExceptionMessage = "Empty or only whitespace is not allowed.";

            //Act
            //1 in SetStringFields is the case for name
            ArgumentException result = Assert.Throws<ArgumentException>(() => toy.SetStringFields(newName, 1));

            //Assert
            Assert.Equal(expectedExceptionMessage, result.Message);
        }


        ////////////////////////////////////////////SetIntfields tests
        [Fact]
        public void SetIntFields_ValidInput()
        {
            //Assign
            int newPrice = 44;
            int oldPrice = 555;
            Toy toy = new Toy("Jack in the box", "Box", oldPrice);

            //Act
            toy.SetIntFields(newPrice, 1);  //1 is the case for price

            //Assert
            Assert.NotNull(toy);
            Assert.Equal(newPrice, toy.Price);
            Assert.NotEqual(oldPrice, toy.Price);
        }
        [Fact]
        public void SetIntFields_Zero_Input()
        {
            //Assign
            Toy toy = new Toy("Jack in the box", "Box", 555);
            int newPrice = 0;
            string expectedExceptionMessage = "0 or less price is not allowed.";

            //Act
            ArgumentException result = Assert.Throws<ArgumentException>(() => toy.SetIntFields(newPrice, 1));

            //Assert
            Assert.Equal(expectedExceptionMessage, result.Message);

        }
        [Fact]
        public void SetIntFields_LessThanZero_Input()
        {
            //Assign
            Toy toy = new Toy("Jack in the box", "Box", 555);
            int newPrice = -123;
            string expectedExceptionMessage = "0 or less price is not allowed.";

            //Act
            ArgumentException result = Assert.Throws<ArgumentException>(() => toy.SetIntFields(newPrice, 1));

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

            string expectedString = $"{type} toy named {name}, priced at {price}.";

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
    }
}
