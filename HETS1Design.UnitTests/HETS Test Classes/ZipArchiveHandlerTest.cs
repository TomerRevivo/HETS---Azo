using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HETS1Design
{
    [TestClass]
    public class ZipArchiveHandlerTest
    {
        [TestInitialize]
        public void Initialize()
        {
            Submissions.ResetSubmissions();
            TestCases.ResetTestCases();
        }


        // Recieves .zip file and check if it successfully extracted them to a folder.
        [TestMethod]
        public void ZipArchiveHandler_Success()
        {
            string filePath = @"..\..\..\Assets\Test Required FIles\ZipArchiveHandlerTest\FaultyZipForTest.zip";
            ZipArchiveHandler.GetSubmissionData(filePath, true);
            Assert.IsTrue(File.Exists(@"..\..\..\Assets\Test Required FIles\ZipArchiveHandlerTest\Codes To Check\FaultyZipForTest\test_file1\with space.c"));
            Assert.IsTrue(File.Exists(@"..\..\..\Assets\Test Required FIles\ZipArchiveHandlerTest\Codes To Check\FaultyZipForTest\test_file2\Exe\with_hebrew_הי.exe"));
            Assert.IsTrue(File.Exists(@"..\..\..\Assets\Test Required FIles\ZipArchiveHandlerTest\Codes To Check\FaultyZipForTest\test_file2\Exe\with spaces.exe"));

            Submissions.ResetSubmissions();
            TestCases.ResetTestCases();

        }

        /* Testing the first initialization of the global variables we added to the class. ***** */
        [TestMethod]
        public void ZipArchiveHandler_GlobalVariablesTesting()
        {
            /* Reciving our indicator variables about wether the messegebox was shown or not. ***** */
            bool hebrewMessegeboxShow = ZipArchiveHandler.hebrewFault;
            bool spacesMessageboxShow = ZipArchiveHandler.spaceFault;

            /* Testing our indicator variables (testing their first initialization). ***** */
            Assert.IsFalse(hebrewMessegeboxShow); // Should be false. *****
            Assert.IsFalse(spacesMessageboxShow); // Should be false. *****

            /* Reciving the specific range of the hebrew alphabit. ***** */
            char firstHebAlphabit = ZipArchiveHandler.FirstHebChar;
            char lastHebAlphabit = ZipArchiveHandler.LastHebChar;

            /* Testing the specific range of the hebrew alphabit. ***** */
            Assert.AreEqual((char)1488, firstHebAlphabit); // Should be true. *****
            Assert.AreEqual((char)1514, lastHebAlphabit); // Should be true. *****

            /* Reciving the variable that indicate wheter the loop checker run over the inire submmited file name.  ***** */
            bool fileAndloopLength = ZipArchiveHandler.loopAndStringEqualLength;

            /* Testing our indicator variable. ***** */
            Assert.IsFalse(fileAndloopLength); // Should be false. *****
        }

        /* Testint the "IsHebrew" methode. ***** */
        [TestMethod]
        public void ZipArchiveHandler_IsHebrewFunctionTesting()
        {
            /* Reciving the specific range of the hebrew alphabit. ***** */
            char firstHebAlphabit = ZipArchiveHandler.FirstHebChar;
            char lastHebAlphabit = ZipArchiveHandler.LastHebChar;

            /* Testing the function that suppost to identifiy hebrew characters. ***** */
            Assert.IsTrue(ZipArchiveHandler.IsHebrew(firstHebAlphabit)); // should be true. *****
            Assert.IsTrue(ZipArchiveHandler.IsHebrew(lastHebAlphabit)); // should be true. *****
            Assert.IsFalse(ZipArchiveHandler.IsHebrew('A')); // should be false. *****
            Assert.IsFalse(ZipArchiveHandler.IsHebrew('Z')); // should be false. *****
        }


        /* Recieves.zip file with faulty files(file name with hebrew character or with spaces)
        * and check if it successfully extracted them to a folder and show the message box message. ***** */
        [TestMethod]
        public void ZipArchiveHandler_MessegeboxSuccess()
        {
            /* Reciving the specific range of the hebrew alphabit. ***** */
            char firstHebAlphabit = ZipArchiveHandler.FirstHebChar;
            char lastHebAlphabit = ZipArchiveHandler.LastHebChar;

            /* Testing the function that suppost to identifiy hebrew characters. ***** */
            Assert.IsTrue(ZipArchiveHandler.IsHebrew(firstHebAlphabit)); // should be true. *****
            Assert.IsTrue(ZipArchiveHandler.IsHebrew(lastHebAlphabit)); // should be true. *****
            Assert.IsFalse(ZipArchiveHandler.IsHebrew('A')); // should be false. *****
            Assert.IsFalse(ZipArchiveHandler.IsHebrew('Z')); // should be false. *****

            string filePath2 = @"..\..\..\Assets\Test Required FIles\ZipArchiveHandlerTest\FaultyZipForTest.zip"; // Path to .zip folder with testeble files. *****
            ZipArchiveHandler.GetSubmissionData(filePath2, true); // Extracting the entered .zip folder. *****

            /* Checking if the file sucessfully extracted ***** */
            Assert.IsTrue(File.Exists(@"..\..\..\Assets\Test Required FIles\ZipArchiveHandlerTest\Codes To Check\FaultyZipForTest\test_file1\with space.c")); // Should be true. *****
            Assert.IsTrue(File.Exists(@"..\..\..\Assets\Test Required FIles\ZipArchiveHandlerTest\Codes To Check\FaultyZipForTest\test_file1\with_hebrew_הי.c")); // Should be true. *****

            /* Reciving the our indicator variables about wether the messegebox was shown or not. ***** */
            bool hebrewMessegeboxShow = ZipArchiveHandler.hebrewFault;
            bool spacesMessageboxShow = ZipArchiveHandler.spaceFault;

            /* Testing our indicator variables. ***** */
            Assert.IsTrue(hebrewMessegeboxShow); // Should be true. *****
            Assert.IsTrue(spacesMessageboxShow); // Should be true. *****

            /* Reset the original variable to their default. ***** */
            ZipArchiveHandler.hebrewFault = false;
            ZipArchiveHandler.spaceFault = false;

        }


        /* Testing wether the for loop of hebrew/spaces check withing the name run over the intire file name. ***** */
        [TestMethod]
        public void ZipArchiveHandler_SuccessTestOverTheIntireFileName()
        {
            string filePath = @"..\..\..\Assets\Test Required FIles\ZipArchiveHandlerTest\ZipForTest.zip"; // Prepares the path to .zip file. *****
            ZipArchiveHandler.GetSubmissionData(filePath, true); // Extracting the .zip file (important so the loop will run over it's name). *****

            /* Reciving the variable that indicate wheter the loop checker run over the inire submmited file name.  ***** */
            bool fileAndloopLength = ZipArchiveHandler.loopAndStringEqualLength;

            /* Testing our indicator variable. ***** */
            Assert.IsTrue(fileAndloopLength); // Should be true. *****

            /* Reset the original variable to its default. ***** */
            ZipArchiveHandler.loopAndStringEqualLength = false;

            /* Reset the method that was influenced by our test. ******/
            Submissions.ResetSubmissions();
            TestCases.ResetTestCases();
        }


        [TestCleanup]
        public void TestCleanup()
        {
            Submissions.ResetSubmissions();
            TestCases.ResetTestCases();
        }
    }
}
