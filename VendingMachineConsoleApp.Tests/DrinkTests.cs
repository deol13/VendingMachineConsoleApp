using System;
using Xunit;
using VendingMachineConsoleApp.Data;

namespace VendingMachineConsoleApp.Tests
{
    public class DrinkTests
    {
        /////////////////////////////////////////Constructor Tests
        [Fact]
        public void Constructor_ValidInput()
        {
            //Assign
            string name = "Fanta";
            string flavor = "Exotic";
            string company = "Coca-Cola";
            int containsInCL = 33;
            int price = 20;

            //Act
            Drink drink = new Drink(name, flavor, company, containsInCL, price);

            //Assert
            Assert.NotNull(drink);
            Assert.Equal(name, drink.Name);
            Assert.Equal(flavor, drink.Flavor);
            Assert.Equal(company, drink.Company);
            Assert.Equal(containsInCL, drink.ContainsInCL);
            Assert.Equal(price, drink.Price);
        }
        [Fact]
        public void Constructor_NullString_Input()
        {
            //Assign
            string name = null;
            string flavor = "Exotic";
            string company = "Coca-Cola";
            int containsInCL = 33;
            int price = 20;
            string expectedExceptionMessage = "Empty or only whitespace is not allowed.";

            //Act
            ArgumentException result = Assert.Throws<ArgumentException>(() => new Drink(name, flavor, company, containsInCL, price));

            //Assert
            Assert.Equal(expectedExceptionMessage, result.Message);
        }
        [Fact]
        public void Constructor_WhiteSpaceString_Input()
        {
            //Assign
            string name = " ";
            string flavor = "Exotic";
            string company = "Coca-Cola";
            int containsInCL = 33;
            int price = 20;
            string expectedExceptionMessage = "Empty or only whitespace is not allowed.";

            //Act
            ArgumentException result = Assert.Throws<ArgumentException>(() => new Drink(name, flavor, company, containsInCL, price));

            //Assert
            Assert.Equal(expectedExceptionMessage, result.Message);
        }
        [Fact]
        public void Constructor_EmptyString_Input()
        {
            //Assign
            string name = "";
            string flavor = "Exotic";
            string company = "Coca-Cola";
            int containsInCL = 33;
            int price = 20;
            string expectedExceptionMessage = "Empty or only whitespace is not allowed.";

            //Act
            ArgumentException result = Assert.Throws<ArgumentException>(() => new Drink(name, flavor, company, containsInCL, price));

            //Assert
            Assert.Equal(expectedExceptionMessage, result.Message);
        }
        [Fact]
        public void Constructor_Zero_Input()
        {
            //Assign
            string name = "Fanta";
            string flavor = "Exotic";
            string company = "Coca-Cola";
            int containsInCL = 0;
            int price = 20;
            string expectedExceptionMessage = "0 or less price is not allowed.";

            //Act
            ArgumentException result = Assert.Throws<ArgumentException>(() => new Drink(name, flavor, company, containsInCL, price));

            //Assert
            Assert.Equal(expectedExceptionMessage, result.Message);
        }
        [Fact]
        public void Constructor_LessThanZero_Input()
        {
            //Assign
            string name = "Fanta";
            string flavor = "Exotic";
            string company = "Coca-Cola";
            int containsInCL = 33;
            int price = -20;
            string expectedExceptionMessage = "0 or less price is not allowed.";

            //Act
            ArgumentException result = Assert.Throws<ArgumentException>(() => new Drink(name, flavor, company, containsInCL, price));

            //Assert
            Assert.Equal(expectedExceptionMessage, result.Message);
        }


        ////////////////////////////////////////////Examine and Use tests
        [Fact]
        public void Examine_Test()
        {
            //Assign
            string name = "Fanta";
            string flavor = "Exotic";
            string company = "Coca-Cola";
            int containsInCL = 33;
            int price = 20;

            Drink drink = new Drink(name, flavor, company, containsInCL, price);

            string expectedString = $"Name: {name}\nPrice: {price}\nFlavor: {flavor}\nMade by: {company}\nVolume: {containsInCL}cl\n";

            //Act
            string result = drink.Examine();

            //Assert
            Assert.Equal(expectedString, result);
        }
        [Fact]
        public void Use_Test()
        {
            //Assign
            string name = "Fanta";
            string flavor = "Exotic";
            string company = "Coca-Cola";
            int containsInCL = 33;
            int price = 20;

            Drink drink = new Drink(name, flavor, company, containsInCL, price);

            string expectedString = "Open it up and drink.";

            //Act
            string result = drink.Use();

            //Assert
            Assert.Equal(expectedString, result);
        }



        /////////////////////////////////////////////Get method tested
        [Fact]
        public void AllGetMethods_Test()
        {
            //Assign
            string expectedName = "Fanta";
            string expectedFlavor = "Exotic";
            string expectedCompany = "Coca-Cola";
            int expectedContainsInCL = 33;
            int expectedPrice = 20;

            //Act
            Drink drink = new Drink(expectedName, expectedFlavor, expectedCompany, expectedContainsInCL, expectedPrice);

            //Act
            string actualName = drink.Name;
            string actualFlavor = drink.Flavor;
            string actualCompany = drink.Company;
            int actualContainsInCL = drink.ContainsInCL;
            int actualPrice = drink.Price;

            //Assert
            Assert.Equal(expectedName, actualName);
            Assert.Equal(expectedFlavor, actualFlavor);
            Assert.Equal(expectedCompany, actualCompany);
            Assert.Equal(expectedContainsInCL, actualContainsInCL);
            Assert.Equal(expectedPrice, actualPrice);
        }
    }
}
