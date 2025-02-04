using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceConsoleApp;
using NUnit.Framework;

namespace ECommerceAppTests
{
    public class ProductTests
    {
        // This method verifies that the constructor correctly stores the lowest valid Product ID (7).
        // This test ensures the system accepts the minimum valid product ID boundary. - Abdihakim Ali
        [Test]
        public void ProdID_ProdIDIsSeven_ShouldStoreProduct()
        {
            // Arrange 
            int prodID = 7;
            int expected = prodID;
            Product product = new Product(prodID, "Valid Product", 100.00m, 10);

            //Act 
            int actual = product.ProdID;

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        // This method verifies that the constructor correctly stores the highest valid Product ID (70000).
        // This test ensures the system accepts the maximum valid product ID boundary. - Abdihakim Ali
        [Test]
        public void ProdID_ProdIDIsSeventyThousand_ShouldStoreProduct()
        {
            // Arrange 
            int prodID = 70000;
            int expected = prodID;
            Product product = new Product(prodID, "Valid Product", 100.00m, 10);

            //Act 
            int actual = product.ProdID;

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        // This method verifies that the constructor correctly stores a Product ID within the valid range (between 7 and 70000).
        // This test ensures the system correctly handles IDs within the acceptable range. - Abdihakim Ali
        [Test]
        public void ProdID_ProdIDIsBetweenSevenandSeventyThousand_ShouldStoreProduct()
        {
            // Arrange 
            int prodID = 35004;
            int expected = prodID;
            Product product = new Product(prodID, "Valid Product", 100.00m, 10);

            //Act 
            int actual = product.ProdID;

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        // This method verifies that the constructor correctly stores a Product Name with the minimum allowed length (1 character).
        // This test ensures the system accepts product names with the shortest allowed length. - Abdihakim Ali
        [Test]
        public void ProdName_ProdNameIsOneCharacter_ShouldStoreProduct()
        {
            // Arrange 
            string prodName = "A";
            string expected = prodName;
            Product product = new Product(7, prodName, 100.00m, 10);

            //Act 
            string actual = product.ProdName;

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        // Verifies that the constructor correctly stores a Product Name with the maximum allowed length (50 characters).
        // This test ensures the system handles the longest product names without issues. - Abdihakim Ali
        [Test]
        public void ProdName_ProdNameIsFiftyCharacters_ShouldStoreProduct()
        {
            // Arrange 
            string prodName = new string('A', 50);
            string expected = prodName;
            Product product = new Product(7, prodName, 100.00m, 10);

            //Act 
            string actual = product.ProdName;

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        // Verifies that the constructor correctly stores a Product Name within the valid length range (between 1 and 50 characters).
        // This test ensures product names outside the valid length range are not accepted. - Abdihakim Ali
        [Test]
        public void ProdName_ProdNameBetweenOneAndFiftyCharacters_ShouldStoreProduct()
        {
            // Arrange 
            string prodName = "Valid product";
            string expected = prodName;
            Product product = new Product(7, prodName, 100.00m, 10);

            //Act 
            string actual = product.ProdName;

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        // Ensures Item Price is correctly stored when set to the minimum valid value ($7).
        // This test checks that the system can store and handle the lowest acceptable price. - Manav Lathiya 
        [Test]
        public void ItemPrice_ItemPriceIsSeven_ShouldStoreProduct()
        {
            // Arrange 
            decimal itemPrice = 7.00m;
            decimal expected = itemPrice;
            Product product = new Product(7, "Valid Product", itemPrice, 10);

            //Act 
            decimal actual = product.ItemPrice;

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        // Ensures Item Price is correctly stored when set to the maximum valid value ($7,000).
        // This test checks that the system can handle the maximum acceptable price. - Manav Lathiya 
        [Test]
        public void ItemPrice_ItemPriceIsSevenThousand_ShouldStoreProduct()
        {
            // Arrange 
            decimal itemPrice = 7000.00m;
            decimal expected = itemPrice;
            Product product = new Product(7, "Valid Product", itemPrice, 10);

            //Act 
            decimal actual = product.ItemPrice;

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        // Ensures Item Price within the valid range ($7 to $7,000) is correctly stored.
        // This test ensures that prices falling between the valid range boundaries are correctly handled. - Manav Lathiya 
        [Test]
        public void ItemPrice_ItemPriceIsBetweenSevenAndSevenThousand_ShouldStoreProduct()
        {
            // Arrange 
            decimal itemPrice = 3503.50m;
            decimal expected = itemPrice;
            Product product = new Product(7, "Valid Product", itemPrice, 10);

            //Act 
            decimal actual = product.ItemPrice;

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        // Ensures Stock Amount is correctly stored when set to the minimum valid value (7).
        // This test ensures the system accepts the smallest valid stock quantity. - Manav Lathiya 
        [Test]
        public void StockAmount_StockAmountIsSeven_ShouldStoreProduct()
        {
            // Arrange 
            int stockAmount = 7;
            int expected = stockAmount;
            Product product = new Product(7, "Valid Product", 100.00m, stockAmount);

            //Act 
            int actual = product.StockAmount;

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        // Ensures Stock Amount is correctly stored when set to the maximum valid value (700,000).
        // This test ensures the system handles large stock quantities effectively. - Manav Lathiya 
        [Test]
        public void StockAmount_StockAmountIsSevenHundredThousand_ShouldStoreProduct()
        {
            // Arrange 
            int stockAmount = 700000;
            int expected = stockAmount;
            Product product = new Product(7, "Valid Product", 100.00m, stockAmount);

            //Act 
            int actual = product.StockAmount;

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        // Ensures Stock Amount within the valid range (7 to 700,000) is correctly stored.
        // This test ensures stock amounts within the valid range are accurately handled - Manav Lathiya 
        [Test]
        public void StockAmount_StockAmountIsBetweenSevenandSeventyThousand_ShouldStoreProduct()
        {
            // Arrange 
            int stockAmount = 350004;
            int expected = stockAmount;
            Product product = new Product(7, "Valid Product", 100.00m, stockAmount);

            //Act 
            int actual = product.StockAmount;

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        // Ensures IncreaseStock does not modify stock when given an increment of 0.
        // The stock amount should remain unchanged. - Jaimin Jigneshkumar Solanki 
        [Test]
        public void IncreaseStock_WhenAddingZero_ShouldNotChangeStock()
        {
            // Arrange
            Product product = new Product(108, "Zero Increment Product", 50.00m, 20);

            // Act
            product.IncreaseStock(0);

            // Assert
            Assert.That(product.StockAmount, Is.EqualTo(20));
        }
        // Verifies that IncreaseStock can handle a large increment without errors.
        // Ensures large stock additions are processed correctly. - Jaimin Jigneshkumar Solanki 
        [Test]
        public void IncreaseStock_WhenAddingLargeAmount_ShouldHandleLargePositiveNumbers()
        {
            // Arrange
            Product product = new Product(103, "Large Stock Product", 100.00m, 500000);

            // Act
            product.IncreaseStock(200000);

            // Assert
            Assert.That(product.StockAmount, Is.EqualTo(700000));
        }
        // Confirms IncreaseStock properly handles a minimal increment of 1.
        // Ensures small stock increases are correctly applied. - Jaimin Jigneshkumar Solanki 
        [Test]
        public void IncreaseStock_WhenAddingSmallAmount_ShouldHandleSmallIncrements()
        {
            // Arrange
            Product product = new Product(104, "Small Increment Product", 30.00m, 10);

            // Act
            product.IncreaseStock(1);

            // Assert
            Assert.That(product.StockAmount, Is.EqualTo(11));
        }
        // Ensures DecreaseStock does not modify stock when given a decrement of 0.
        // The stock amount should remain unchanged. - Jaimin Jigneshkumar Solanki 
        [Test]
        public void DecreaseStock_WhenReducingByZero_ShouldNotChangeStock()
        {
            // Arrange
            Product product = new Product(109, "Zero Decrease Product", 20.00m, 30);

            // Act
            product.DecreaseStock(0);

            // Assert
            Assert.That(product.StockAmount, Is.EqualTo(30));
        }
        // Verifies that DecreaseStock throws an exception when stock is insufficient.
        // Ensures that attempting to remove more stock than available is properly handled. - Jaimin Jigneshkumar Solanki 
        [Test]
        public void DecreaseStock_WhenStockIsInsufficient_ShouldThrowException()
        {
            // Arrange
            Product product = new Product(106, "Exception Product", 20.00m, 10);
            string expected = "Not enough stock to decrease.";

            // Act 
            string actual = Assert.Throws<ArgumentException>(() => product.DecreaseStock(15)).Message;

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        // Ensures that DecreaseStock correctly sets stock to zero when the exact available amount is removed.
        // Stock should be fully depleted when an exact match is deducted. - Jaimin Jigneshkumar Solanki 
        [Test]
        public void DecreaseStock_WhenAmountEqualsStock_ShouldReduceStockToZero()
        {
            // Arrange
            Product product = new Product(107, "Exact Depletion Product", 40.00m, 10);

            // Acts
            product.DecreaseStock(10);

            // Assert
            Assert.That(product.StockAmount, Is.EqualTo(0));
        }
    }
}
