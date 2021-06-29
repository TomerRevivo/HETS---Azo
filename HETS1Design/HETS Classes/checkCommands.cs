using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace HETS1Design.HETS_Classes
{
    public class checkCommands
    {
            public static int CountOfTwoSleshes = 0;
            public static int CountOfLines = 0;
            public static  int lengthOfCommaandLine;
            public static int CountOFSleshKohav = 0;
            public static List<string> listOfCommands;
            public static string IDnumber;
            public static int indexOfIDnumber;
            public static string name;


        public static List<string> returnTheCommandslist(string filepath_c)
        {
            
            listOfCommands = new List<string>();
            
            //filepath = SingleSubmission.tester;
            String shirshur = "";


            if (File.Exists(filepath_c))
            {
                StreamReader sr = new StreamReader(filepath_c);
                string line = sr.ReadLine();

                while (line != null)
                {
                    if (line.Contains("//") || line.Contains("/*"))
                    {
                        if (line.Contains("/*"))
                        {
                            //if there more then one lines in the commands : 
                            while ((line != null) && !line.Contains("*/")) // when the next line dosent have */ move to the next until you find the */ 
                            {
                                shirshur += line; //shirsur the next line with the previous
                                line = sr.ReadLine();
                            }

                            if (line.Contains("*/"))
                            {
                                shirshur += line; // shirshur the last line in the command .
                                if (shirshur.Length > 9)
                                    listOfCommands.Add(shirshur);
                                shirshur = "";
                            }
                            else
                            { 
                            line = sr.ReadLine(); //move to the next line 
                            }
                            //now its find the */ so we need to save the lines inside of /* */ to the list - if it is more then 9 chars 

                        }

                        // MessageBox.Show("IdentifyingDetailsExists is ok and the IDnumber is " + IDnumber );

                        else if (line.Contains("//"))
                        {
                            CountOfTwoSleshes++;  // count the command. 
                        }


                        
                        if (line.Length > 9) // check if the command length bigger then 9 chars . 
                        {
                            listOfCommands.Add(line); // add the command to the list , just if this is a good command. 
                        }
                        else
                        {
                            //do not add the command to the list , don't do nothing 
                        }

                        // MessageBox.Show("line number " + CountOfLines + "  contain // ");
                    }

                    line = sr.ReadLine();
                    CountOfLines++;
                }
                /*for (int i = 0; i < listOfCommands.Count; i++)
                   {
                       MessageBox.Show(i + ":" + listOfCommands[i]);
                   }*/
              
                return listOfCommands;
            }
            return null;


        }


        //check if you have 10 + commands and identify details 
        public static bool CommandsCheck(string filepath_c)
        {

            if (File.Exists(filepath_c))
            {
                List<string> listCommands_afterReturncommands = new List<string>();
                string file2 = SingleSubmission.tester2;
                String shirshur = "";

                bool IdentifyingDetailsExists = false;



                listCommands_afterReturncommands = returnTheCommandslist(filepath_c);

                if (listCommands_afterReturncommands != null)
                {
                    IdentifyingDetailsExists = IdentifyingDetailsExists1(listCommands_afterReturncommands);
                    if (listCommands_afterReturncommands.Count >= 10 && IdentifyingDetailsExists) //if the number of good value(correct value) are bigger then 10 this is ok  
                    {
                        return true;
                    }

                    else
                    {
                        return false;
                    }
                }
            }
            
            return false; 
        }


        //return id number if have one 
        public static string returnIdNumber(List<String> listOfCommands)
        {

            string IDnumber = "";
            if(listOfCommands != null)
            {

                for (int j = 0; j < listOfCommands[0].Length; j++)
                {
                bool flag = char.IsDigit(listOfCommands[0][j]);
                    if (flag)
                    {
                        IDnumber += listOfCommands[0][j];
                    }
                }
            }

            return IDnumber;
        }


        // check if have id number 
        public static bool IdentifyingDetailsExists1(List <string> listOfCommands) 
        {
           string IDnumber = "";
            if(listOfCommands != null )
            {
             for (int j = 0; j < listOfCommands[0].Length; j++)
              {
                    bool flag = char.IsDigit(listOfCommands[0][j]);
                    if (flag)
                    {
                         IDnumber += listOfCommands[0][j]; 
                    }
              }
            }
            else
            {

            }

            if (IDnumber != "")
                return true;
            else 
                return false;
        }

        //return the naame if have one 
        public static string findTheName(List <String> listOfCommands )
        {
           string IDnumber = returnIdNumber(listOfCommands);

            string name = "";
            if(listOfCommands != null)
            { 
                 //MessageBox.Show(listOfCommands[0]);
                indexOfIDnumber = listOfCommands[0].IndexOf(IDnumber);
               // MessageBox.Show("indexofidnum : " + indexOfIDnumber);
                name = listOfCommands[0].Remove(indexOfIDnumber, indexOfIDnumber + 8);
               // MessageBox.Show("name is : " + name);

            
                int indexoffirstsleshes = name.IndexOf("/*");
               // MessageBox.Show("first slesh :" + indexoffirstsleshes);
                name = name.Remove(indexoffirstsleshes, indexoffirstsleshes + 2);
              //  MessageBox.Show("name is : " + name);

                int indexofsecsleshes = name.IndexOf("*/");
              //  MessageBox.Show("indexofsecslesh : " + indexofsecsleshes);
                name = name.Remove(indexofsecsleshes);
               // MessageBox.Show("name is : " + name);
            }

               


            return name;
        }


    }



}

