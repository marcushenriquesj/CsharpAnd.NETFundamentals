using AccoutingSystem;

namespace AccountTests
{
    [TestClass]
    public class AccountTests
    {
        [TestMethod]
        public void Checking_Deposit_Returns1000AfterAdd500ToStartingBalanceOf500()
        {
            //Arrange
            Checking checkingAcctTest = new Checking(500, 1);

            //Act
            checkingAcctTest.Deposit(500);

            //Assert
            Assert.AreEqual(1000, checkingAcctTest.Balance);
        }

        [TestMethod]
        public void Checking_CalculateInterest_Returns50From1000StartingBalanceAnd5PercentInterest()
        {
            //Arrange
            Checking checkingAcctTest = new Checking(1000, 1);

            //Act
            var result = checkingAcctTest.CalculateInterest(.05m);

            //Assert
            Assert.AreEqual(50, result);
        }

        [TestMethod]
        public void Premium_CalculateInterest_Returns50From1000StartingBalanceAnd4PercentInterest()
        {
            //Arrange
            Premium premiumAcctTest = new Premium(1000, 1);

            //Act
            var result = premiumAcctTest.CalculateInterest(.04m);

            //Assert
            Assert.AreEqual(50, result);
        }
    }
}