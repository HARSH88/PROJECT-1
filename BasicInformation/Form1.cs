using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//ADDED:    for xml
using System.Xml;

namespace BasicInformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This will read valid XML file and then display in richtext box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btndisplay_Click(object sender, EventArgs e)
        {
            XmlDocument myDocument = new XmlDocument();
            try
            {
                myDocument.Load("BasicInfo.xml");   //loading the file
            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show("Can't find file." + Environment.NewLine + ex.Message.ToString());
            }
            catch (SystemException ex)
            {
                MessageBox.Show("Something is wrong: " + ex.Message.ToString());
            }

            
            //READING DATA FROM DOCUMENT and also can be done for multiple nodes and child nodes.
            for (int curIndex = 0; curIndex != myDocument.DocumentElement.ChildNodes.Count; curIndex++)
            {
                XmlNode curNode = myDocument.DocumentElement.ChildNodes[curIndex];

                if (curNode.Name == "name")
                {
                   // this.AddLine("NAME# " + curNode.InnerText.ToString());    //can also add any text particular if you want
                    this.AddLine(curNode.InnerText.ToString());
                }
            
            }
        }
        
            
            /// <summary>
            /// this is for the placement of line in text box.
            /// </summary>
            /// <param name="theText"></param>
            private void AddLine(string theText)
            {
                //this.rtxtshow.Text = this.rtxtshow.Text + Environment.NewLine + theText.ToString();   //if add in new line
                this.rtxtshow.Text = this.rtxtshow.Text + theText.ToString();
            }

            /// <summary>
            /// it saves the data edited in the same file and gives a message box that its done.. and also can be done for multiple nodes
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnsave_Click(object sender, EventArgs e)
            {
                DataSet ds = new DataSet();
                ds.ReadXml("BasicInfo.xml");                 //taking new file and saving in it....
                ds.Tables[0].Rows[0]["name"] = rtxtshow.Text;   //taking node and saving it
                ds.AcceptChanges();
                ds.WriteXml("BasicInfo.xml");

                MessageBox.Show("FILE UPDATED....");
            }

            private void rtxtshow_TextChanged(object sender, EventArgs e)
            {

            }

           


        }
    }

