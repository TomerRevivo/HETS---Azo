using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;
using HETS1Design.HETS_Classes;
using System.Collections.Generic;
using System.Linq;
using System.Text;




namespace HETS1Design.UnitTests.HETS_Test_Classes
{
    [TestClass]
    public class checkCommandTests
    {
        OpenFileDialog openInputDialog;
        TextBox txtArchivePath;
        DataGridView dataGridResults;

        [TestInitialize]
        public void TestInit()
        {
            txtArchivePath = new System.Windows.Forms.TextBox();
            openInputDialog = new System.Windows.Forms.OpenFileDialog();
            dataGridResults = new System.Windows.Forms.DataGridView();
        }


       
        [TestMethod]
        public void CommandsCheckTest_checkcommand_true()
        {
            openInputDialog.FileName = @"..\..\..\Assets\Test Required FIles\ZipArchiveHandlerTest\AHM67ED\shelly_revivo.c";
            txtArchivePath.Text = openInputDialog.FileName;
            bool commandchecked = checkCommands.CommandsCheck(openInputDialog.FileName);
            //string r = commandchecked.ToString();
           // MessageBox.Show(r);
            Assert.IsTrue(commandchecked);
        }


        
        [TestMethod]
        public void CommandsCheckTest_checkcommand_False()
        {
            openInputDialog.FileName = @"..\..\..\Assets\Test Required FIles\ZipArchiveHandlerTest\Codes To Check\איימן שפסו_7085_assignsubmission_file_ (2).zip";
            txtArchivePath.Text = openInputDialog.FileName;
            bool commandchecked = checkCommands.CommandsCheck(openInputDialog.FileName);
            //string r = commandchecked.ToString();
            //MessageBox.Show(r);
           
            Assert.IsFalse(commandchecked);
        }

        [TestMethod]
        public void fileExist_True()
        {
            openInputDialog.FileName = @"..\..\..\Assets\Test Required FIles\ZipArchiveHandlerTest\AHM67ED.zip";
            txtArchivePath.Text = openInputDialog.FileName;
            bool fileExist = File.Exists(txtArchivePath.Text);
            Assert.IsTrue(fileExist);
        }


        [TestMethod]
        public void returnTheCommandslist_true()
        {
            List<string> listOfCommands = new List<string>();
            openInputDialog.FileName = @"..\..\..\Assets\Test Required FIles\ZipArchiveHandlerTest\AHM67ED\shelly_revivo.c";
            txtArchivePath.Text = openInputDialog.FileName;
            listOfCommands = checkCommands.returnTheCommandslist(openInputDialog.FileName); //it should return list of commands from the file shelly_revivo.c
            Assert.IsNotNull(listOfCommands); 
        }

        [TestMethod]
        public void returnTheCommandslist_false()
        {
            List<string> listOfCommands = new List<string>();
            openInputDialog.FileName = @"..\..\..\Assets\Test Required FIles\ZipArchiveHandlerTest\ZipForTest.zip\אחמד סכראן_7092_assignsubmission_file_\mtla3.c";
            txtArchivePath.Text = openInputDialog.FileName;
            listOfCommands = checkCommands.returnTheCommandslist(openInputDialog.FileName); //it should return list of commands from the file shelly_revivo.c
            Assert.IsNull(listOfCommands);
        }





        [TestMethod]
        public void returnIdNumber_true()
        {
            List<string> listOfCommands = new List<string>();
            string returnIdNumber = "";

            openInputDialog.FileName = @"..\..\..\Assets\Test Required FIles\ZipArchiveHandlerTest\Codes To Check\AHM67ED\shelly_revivo.c";
            listOfCommands = checkCommands.returnTheCommandslist(openInputDialog.FileName);
            returnIdNumber = checkCommands.returnIdNumber(listOfCommands);
           
            Assert.IsNotNull(returnIdNumber);

        }



            [TestMethod]
        public void find_name_true()
        {
            List<string> listOfCommands = new List<string>(); 
            bool findTheName = false;

          
            openInputDialog.FileName = @"..\..\..\Assets\Test Required FIles\ZipArchiveHandlerTest\AHM67ED\shelly_revivo.c";
           


            listOfCommands = checkCommands.returnTheCommandslist(openInputDialog.FileName);

            if (listOfCommands != null)
            {
               // MessageBox.Show("not null list ! ");
              //  MessageBox.Show(listOfCommands[0]);
                string findName = checkCommands.findTheName(listOfCommands);
                if (findName != null)
                    findTheName = true;
            }
          /*  else
            {
               // MessageBox.Show("not find name");
                findTheName = false;
            }*/

            
                
            //string r = findTheName.ToString();
           // MessageBox.Show(r);

            Assert.IsTrue(findTheName); 


        }
    }
}
