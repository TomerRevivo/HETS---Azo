
using HETS1Design;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HETS_AZO.unitTest
{
    [TestClass]
    public class MainScreenLogicTest
    {
        [TestMethod]
        public void EnableCommantsCheckedChange_checkCommands_returnTRUE()
        {
            //act 
            var result = MainScreenLogic.EnableCommantsCheckedChange();

            //assert 
            Assert.IsTrue(result);
        }


    }
}
