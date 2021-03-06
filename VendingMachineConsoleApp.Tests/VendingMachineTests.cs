using System;
using Xunit;
using VendingMachineConsoleApp.Model;
using VendingMachineConsoleApp.Data;
using System.Collections.Generic;

namespace VendingMachineConsoleApp.Tests
{
    public class VendingMachineTests
    {
        [Fact]
        public void GetMoney_Test()
        {
            //Assign
            VendingMachine vMachine = new VendingMachine();
            int expectedAmount = 55;
            vMachine.InsertMoney(50);
            vMachine.InsertMoney(5);

            //Act
            int result = vMachine.Money;

            //Assert
            Assert.Equal(expectedAmount, result);
        }
        

        ////////////////////////////////////Purchase test methods
        [Fact]
        public void Purchase_Success_Test()
        {
            //Assign
            VendingMachine vMachine = new VendingMachine();
            vMachine.InsertMoney(1000);

            Toy expectedType1 = new Toy("Winnie the Pooh", "Stuffed Bear", 150, "Cutton", "Yellow", 20);
            Drink expectedType2 = new Drink("Fanta", "Soda", 20, "Exotic", "Coca-Cola", 33);
            Snack expectedType3 = new Snack("Marsbar", "Candy bar", 15, 60, 300, true);

            //Act
            Product p1 = vMachine.Purchase(1);
            Product p2 = vMachine.Purchase(2);
            Product p3 = vMachine.Purchase(3);

            //Assert
            Assert.NotNull(p1);
            Assert.NotNull(p2);
            Assert.NotNull(p3);
            Assert.Equal(expectedType1.GetType(), p1.GetType());
            Assert.Equal(expectedType2.GetType(), p2.GetType());
            Assert.Equal(expectedType3.GetType(), p3.GetType());
            Assert.True(vMachine.Money > -1);
        }
        [Fact]
        public void Purchase_InvalidPossitivVendingNumber_Test()
        {
            //Assign
            string expectedErrorMessage = "Not a valid vending number.";
            VendingMachine vMachine = new VendingMachine();
            vMachine.InsertMoney(1000);

            //Act
            ArithmeticException result1 = Assert.Throws<ArithmeticException>(() => vMachine.Purchase(0));
            ArithmeticException result2 = Assert.Throws<ArithmeticException>(() => vMachine.Purchase(4));

            //Assert
            Assert.Equal(expectedErrorMessage, result1.Message);
            Assert.Equal(expectedErrorMessage, result2.Message);
        }
        [Fact]
        public void Purchase_InvalidNegativVendingNumber_Test()
        {
            //Assign
            string expectedErrorMessage = "Not a valid vending number.";
            VendingMachine vMachine = new VendingMachine();
            vMachine.InsertMoney(1000);

            //Act
            ArithmeticException result = Assert.Throws<ArithmeticException>(() => vMachine.Purchase(-1));

            //Assert
            Assert.Equal(expectedErrorMessage, result.Message);
        }
        [Fact]
        public void Purchase_NotEnoughMoney_Test()
        {
            //Assign
            string expectedErrorMessage = "Not enough money.";
            VendingMachine vMachine = new VendingMachine();
            Toy toy = new Toy("Winnie the Pooh", "Stuffed Bear", 150, "Cutton", "Yellow", 20);

            //Act
            ArithmeticException result = Assert.Throws<ArithmeticException>(() => vMachine.Purchase(1));


            //Assert
            Assert.Equal(expectedErrorMessage, result.Message);
            Assert.True(vMachine.Money < toy.Price);
        }



        ////////////////////////////////////Show all test method
        [Fact]
        public void ShowAll_Test()
        {
            //Assign
            VendingMachine vMachine = new VendingMachine();

            Toy toy = new Toy("Winnie the Pooh", "Stuffed Bear", 150, "Cutton", "Yellow", 20);
            Drink drink = new Drink("Fanta", "Soda", 20, "Exotic", "Coca-Cola", 33);
            Snack snack = new Snack("Marsbar", "Candy bar", 15, 60, 300, true);

            string expectedStringIndex1 = "------- Products -------";

            string expectedStringIndex2 = $"Vending Number: 1\n{toy.Examine()}";

            string expectedStringIndex3 = $"Vending Number: 2\n{drink.Examine()}";

            string expectedStringIndex4 = $"Vending Number: 3\n{snack.Examine()}";

            //\n
            //Act
            string[] result = vMachine.ShowAll();

            //Assert
            Assert.Equal(expectedStringIndex1, result[0]);
            Assert.Equal(expectedStringIndex2, result[1]);
            Assert.Equal(expectedStringIndex3, result[2]);
            Assert.Equal(expectedStringIndex4, result[3]);
        }


        ////////////////////////////////////InsertMoney test methods
        [Fact]
        public void InsertMoney_Valid_Test()
        {
            //Assign
            VendingMachine vMachine = new VendingMachine();
            int expectedAmount = 1686;

            //Act
            bool result1 = vMachine.InsertMoney(1000);
            bool result2 = vMachine.InsertMoney(500);
            bool result3 = vMachine.InsertMoney(100);
            bool result4 = vMachine.InsertMoney(50);
            bool result5 = vMachine.InsertMoney(20);
            bool result6 = vMachine.InsertMoney(10);
            bool result7 = vMachine.InsertMoney(5);
            bool result8 = vMachine.InsertMoney(1);

            //Assert
            Assert.True(result1);
            Assert.True(result2);
            Assert.True(result3);
            Assert.True(result4);
            Assert.True(result5);
            Assert.True(result6);
            Assert.True(result7);
            Assert.True(result8);
            Assert.Equal(expectedAmount, vMachine.Money);

        }
        [Fact]
        public void InsertMoney_InValid_Test()
        {
            //Assign
            VendingMachine vMachine = new VendingMachine();
            int expectedAmount = vMachine.Money;

            //Act
            bool result1 = vMachine.InsertMoney(1001);
            bool result2 = vMachine.InsertMoney(66);
            bool result3 = vMachine.InsertMoney(666);
            bool result4 = vMachine.InsertMoney(-1);

            //Assert
            Assert.False(result1);
            Assert.False(result2);
            Assert.False(result3);
            Assert.False(result4);
            Assert.Equal(expectedAmount, vMachine.Money);
        }


        ////////////////////////////////////EndTransaction test methods
        [Fact]
        public void EndTransaction__Test()
        {
            //Assign
            VendingMachine vMachine = new VendingMachine();
            vMachine.InsertMoney(500);
            vMachine.InsertMoney(100);
            vMachine.InsertMoney(100);
            vMachine.InsertMoney(1);
            Dictionary<int, int> expectedChangeBack = new Dictionary<int, int>();
            expectedChangeBack.Add(500,1);
            expectedChangeBack.Add(100,2);
            expectedChangeBack.Add(1,1);

            //Act
            Dictionary<int, int> result = vMachine.EndTransaction();

            //Assert
            Assert.Equal(expectedChangeBack, result);
        }
    }
}
