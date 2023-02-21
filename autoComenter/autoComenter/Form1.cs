using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace autoComenter
{
    public partial class Form1 : Form
    {
        //*********************************************************************************global variables and variables for the struct************************************************************************************************
        public struct method
        {
            public string name;
            public string returnType;
            public string[] args;
            public int argNum;
        }
        //these are the initial variables and components
        int listIndex = 0;
        List<string> TextLines = new List<string>();
        List<int> lineLocation = new List<int>();
        string fileLocation;
        int locationAdded =0;

        //*********************************************************************************Methods******************************************************************************************
        
        //*************************************************************************
        //  Method: private void GetFile(){
        //  Purpose: this opens a file and reads it into a string array
        //  Args:  -- 
        //  returns: void
        //*************************************************************************
        private void GetFile(){
            // local variables
            int lineNum = 0;
            // open the file
            if(OpenICA.ShowDialog() == DialogResult.OK){
                fileLocation = OpenICA.FileName;
                try{
                    // read the file into a string array
                    string[] textDocument = File.ReadAllLines(fileLocation);
                    // add the lines to the list
                    foreach(string line in textDocument){
                        TextLines.Add(line);
                        // check if the line is a method
                        if(line.Contains("private") ||line.Contains("public")||line.Contains("static")){
                            // add the line number to the list
                            lineLocation.Add(lineNum);
                            lbx_methods.Items.Add(line);
                        }
                        lineNum++; // increment the line number
                    }
                    btn_open.Enabled = false;
                    btn_open.Hide();
                    lbl_name.Enabled = true;
                    lbl_projectName.Enabled = true;
                    btn_skip.Enabled = true;
                    btn_header.Enabled = true;
                    btn_comment.Enabled = true;
                    grbx_headerBlock.Enabled = true;
                    btn_writeToFile.Enabled = true;
                    lbx_methods.SelectedIndex = 0;
                    txbx_methodHolder.Text = lbx_methods.SelectedItem.ToString();

                }
                catch{
                    MessageBox.Show("Error: Could not read file from disk. Original error: ");
                }
            }
        }
            
        //*************************************************************************
        //  Method: public void parseComment(string fulText, int lineNum)
        //  Purpose: this parses the comment and gets the method information
        //  Args: string fulText -- the full text of the method
        //        int lineNum -- the line number of the method
        //  returns: void
        //*************************************************************************
        public void parseComment(string fulText, int lineNum)
        {
            //location variables
            int openBracket = fulText.IndexOf("(");
            int closeBracket = fulText.IndexOf(")");
            int comma; // the location of the comma
            int i = 0; // the location in the loop
            int space; // the location of the space

            //new strings to be used 
            string bracketText;// the text between the brackets
            string firstPart = fulText.Substring(0, openBracket-1);// this is the first part of the method

            //this is the struct that will hold the method information
            method methodInfo;// make a new struct called method that will hold the method information of type name and return type and arguments
            methodInfo.args = new string[10];// make a new array of strings to hold the arguments



            // this section returns the Method return type and name
            firstPart = firstPart.Replace("private ", "");
            firstPart = firstPart.Replace("public ", "");
            firstPart = firstPart.Replace("static ", "");
            firstPart = firstPart.Replace("    ", "");
            firstPart = firstPart.Replace("   ", "");
            firstPart = firstPart.Replace("  ", "");
            // locate the space
            space = firstPart.IndexOf(" ");
            // get the return retrunType
            
            methodInfo.returnType = firstPart.Substring(0, space);// this will gove  an error if it is not given a type
            // get the method names
            methodInfo.name = firstPart.Substring(space + 1, firstPart.Length - space - 1);

            // add the arguments to the list
            bracketText = fulText.Substring(openBracket + 1, closeBracket - openBracket - 1);
            
            // check if there are any arguments
            if(fulText.Contains(",")){
                while(true){
                    comma = bracketText.IndexOf(",");
                    //check that there is more than one argument
                    if(comma == -1){ 
                        // add the last argument to the list
                        methodInfo.args[i] = bracketText.Substring(0, bracketText.Length);
                        i++; // increment the location in the loop
                        methodInfo.argNum = i; // set the number of arguments
                        break;
                    }
                    // add the argument to the list
                    methodInfo.args[i] = fulText.Substring(0, comma - 1);
                    // remove the argument from the string
                    bracketText = bracketText.Substring(comma + 1, bracketText.Length-1);
                    i++; // location in the loop
                }
            }
            //if there is only one argument or no arguments
            else{
                try
                {
                methodInfo.args[0] = bracketText;
                }
                catch (System.Exception)
                {
                    methodInfo.args[0] = "";
                }
                finally
                {
                    methodInfo.argNum = 1;
                }
            }
            //send the method information to the method block inserter
            InsertMethodBlock(methodInfo, lineNum);

            // move the selected index to the next item
            listIndex++;
            lbx_methods.SelectedIndex = listIndex;
            txbx_methodHolder.Text = lbx_methods.SelectedItem.ToString();
        }

        
        //*************************************************************************
        //  Method: public void InsertMethodBlock(method methodInfo, int lineNum){
        //  Purpose:  this inserts the method block into the list
        //  Args: method methodInfo -- the method information
        //        int lineNum -- the line number where the method is located
        //  returns: void
        //*************************************************************************
        public void InsertMethodBlock(method methodInfo, int lineNum){
            // local variables
            string headerfooter= "    //*************************************************************************";
            string baseComment = "    // ";
            // add the header
            TextLines.Insert(lineNum + locationAdded, headerfooter);
            locationAdded++;
            TextLines.Insert(lineNum + locationAdded, baseComment + "Method: " + methodInfo.name);
            locationAdded++;
            TextLines.Insert(lineNum + locationAdded, baseComment + "Purpose: ");
            locationAdded++;
            // add the arguments
             for(int i = 0; i < methodInfo.argNum; i++){
                 if (i== 0){
                     TextLines.Insert(lineNum + locationAdded, baseComment + "Args: " + methodInfo.args[i] + " -- ");
                     locationAdded++;
                 }
                 else{
                     TextLines.Insert(lineNum + locationAdded, baseComment + "        " + methodInfo.args[i]+ " -- ");
                     locationAdded++;
                 }
            }
            TextLines.Insert(lineNum + locationAdded, baseComment + "returns: " + methodInfo.returnType);
            locationAdded++;
            TextLines.Insert(lineNum + locationAdded, headerfooter);
            locationAdded++;
        }



        //*************************************************************************
        //  Method: public void HeaderBlock(){
        //  Purpose: this inserts the header block into the list
        //  Args:  -- 
        //  returns: void
        //*************************************************************************
        public void HeaderBlock(){
            // local variables
            string headerfooter= "/////////////////////////////////////////////////////////////////////////";
            string baseComment = "//     ";
            // add the header
            TextLines.Insert(0, headerfooter);
            locationAdded++;
            TextLines.Insert(0, baseComment + "Author: " + txbx_name.Text);
            locationAdded++;
            TextLines.Insert(0, baseComment );// add space
            locationAdded++;
            TextLines.Insert(0, baseComment + "Project: " + txbx_projectName.Text);
            locationAdded++;
            TextLines.Insert(0, baseComment );// add space
            locationAdded++;
            TextLines.Insert(0, baseComment + "Purpose: ");
            locationAdded++;
            TextLines.Insert(0, baseComment );// add space
            locationAdded++;
            TextLines.Insert(0, baseComment + "Date: " + DateTime.Now.ToString("MM/dd/yyyy"));
            locationAdded++;
            TextLines.Insert(0, baseComment );// add space
            locationAdded++;
            TextLines.Insert(0, headerfooter);
            locationAdded++;


            //disable the header button
            btn_header.Enabled = false;
            btn_header.Visible = false;
        }
        public void Write(){
            //write the list to the file
            File.WriteAllLines(fileLocation, TextLines);
            MessageBox.Show("File has been written");
            Form1.ActiveForm.Close();
            
        }

        //************************************************************************* event handlers *************************************************************************


        public Form1()
        {
            InitializeComponent();
            btn_writeToFile.Enabled = false;
        }

        private void ComementFile(object sender, EventArgs e) {
            try
            {// this will try to parse the method
            parseComment(txbx_methodHolder.Text.ToString(), lineLocation[listIndex]);
            }
            catch (System.Exception)// if it fails it will skip the line
            {
                MessageBox.Show("the line is an invalid method");
            }
        }

        private void SkipComment(object sender, EventArgs e) {
            listIndex++;
            lbx_methods.SelectedIndex = listIndex;
            txbx_methodHolder.Text = lbx_methods.SelectedItem.ToString();
        }

        private void InsertHeader(object sender, EventArgs e) => HeaderBlock();

        private void OpenCodeButton(object sender, EventArgs e) => GetFile();

        private void WriteToFile(object sender, EventArgs e) => Write();
    }
}
