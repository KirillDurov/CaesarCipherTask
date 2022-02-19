using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CaesarCipherTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            string message = "Hello";
            int key = 3;
            string expected = "Khoor";

            //act
            CaesarCipher c = new CaesarCipher();
            string actual = c.Encrypt(message, key);

            //assert
            Assert.AreEqual(expected, actual);

        }
    }
}
