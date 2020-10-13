using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetBanqueOne;
namespace BanqueTest
{
    [TestClass]
    public class BanqueTest
    {
        [TestMethod]
        public void Test_if_Superieur_True()
        {
            Compte c1 = new Compte(12345, "toto", 1000, -500);
            Compte c2 = new Compte(45657, "titi", 2000, -1000);
            bool response = c1.Superieur(c2);
            Assert.IsFalse(response);
        }
        [TestMethod]
        public void Test_if_Superieur_False()
        {
            Compte c1 = new Compte(12345, "toto", 3000, -500);
            Compte c2 = new Compte(45657, "titi", 2000, -1000);
            bool response = c1.Superieur(c2);
            Assert.IsTrue(response);
        }
        [TestMethod]
        public void Test_if_Debit_Is_Wrong()
        {
            Compte c1 = new Compte(12345, "toto", 1000, -500);
            
            float response = c1.Debiter(600);

            Assert.AreNotEqual(500, response);
        }
        [TestMethod]
        public void Test_if_Debit_Is_Good()
        {
            Compte c1 = new Compte(12345, "toto", 1000, -500);

            float response = c1.Debiter(500);

            Assert.AreEqual(500, response);
        }
        [TestMethod]
        public void Test_if_Debit_Is_Not_Allowed()
        {
            Compte c1 = new Compte(12345, "toto", 1000, -500);

            float response = c1.Debiter(2500);

            Assert.AreEqual(1000, response);
        }

        [TestMethod]
        public void Transfer_Is_Allowed()
        {
            Compte c1 = new Compte(12345, "toto", 1000, -500);
            Compte c2 = new Compte(45657, "titi", 2000, -1000);

            float soldeC1 = c1.Transferer(c2, 500);
            float soldeC2 = c2.GetSolde();

            Assert.AreEqual(500, soldeC1);
            Assert.AreEqual(2500, soldeC2);

        }
        [TestMethod]
        public void Transfer_Is_Not_Allowed()
        {
            Compte c1 = new Compte(12345, "toto", 1000, -500);
            Compte c2 = new Compte(45657, "titi", 2000, -1000);

            float soldeC1 = c1.Transferer(c2, 2000);
            float soldeC2 = c2.GetSolde();

            Assert.AreEqual(1000, soldeC1);
            Assert.AreEqual(2000, soldeC2);

        }
    }
}
