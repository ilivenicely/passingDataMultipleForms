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

 
//////////////////////////////////////////////////////////////////////////////////////////
//RobertMccormick_CE02 
//Class: Visual Frameworks
//3rd Term
//
//

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {

        //Begin Form
        public Form1()
        {
            InitializeComponent();
        }

        //The button that shifts from left to right

        private void btnLeft_Click_1(object sender, EventArgs e)
        {
            MoveSelected(LeftItems, RightItems);
        }

        //The button that shifts from right to left
        private void btnRight_Click_1(object sender, EventArgs e)
        {
            MoveSelected(RightItems, LeftItems);
        }

        // Move selected items from one ListBox to another.
        private void MoveSelected(ListBox leftFrom, ListBox lstTo)
        {
            while (leftFrom.SelectedItems.Count > 0)
            {
                string item = (string)leftFrom.SelectedItems[0];
                lstTo.Items.Add(item);
                leftFrom.Items.Remove(item);
            }
            makeButtonsEditable();
        }
        // reference
        private void lst_SelectedIndexChanged(object sender, EventArgs e)
        {
            makeButtonsEditable();
        }

         //Allows for buttons to be editable
        private void makeButtonsEditable()
        {
            btnSelect.Enabled = (LeftItems.SelectedItems.Count > 0);

            btnDeselect.Enabled = (RightItems.SelectedItems.Count > 0);
        }

        //upon load, buttons can be maintained

        private void Form1_Load(object sender, EventArgs e)
        {
            makeButtonsEditable();
        }

        private void lstSelected_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Adds to list
        private void AddToLeftList_Click(object sender, EventArgs e)
        {
            LeftItems.Items.Add(textBox1.Text);
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //Adds to list
        private void AddToList2_Click(object sender, EventArgs e)
        {
            RightItems.Items.Add(textBox2.Text);
        }

        //Clears left list
        private void clear_Click(object sender, EventArgs e)
        {
            LeftItems.Items.Clear();
        }

        //Clears Right list
        private void clear2_Click(object sender, EventArgs e)
        {
            RightItems.Items.Clear();
        }

        //Tool strip options

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.ShowDialog();
            openfile.Title = "Open Text (.txt) File ";
            openfile.Filter = "Text File |*.txt";
            if (openfile.ShowDialog() == System.Windows.Forms.DialogResult.OK)

            {
                MessageBox.Show(openfile.FileName);
                // richTextBox1.AppendText(openfile.FileName);
 

                List<string> lines = new List<string>();
                using (StreamReader r = new StreamReader(openfile.FileName))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        lines.Add(line);
                        LeftItems.Items.Add(line);
                    }
                }

            }

        }
        //Menu from tooltrip for saving
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {      
            SaveFileDialog savefile = new SaveFileDialog();    
            savefile.ShowDialog();
            string textout = "";      
            foreach (string grab in LeftItems.Items)
            {
                textout = textout + grab + Environment.NewLine;
            }

            textout = textout + Environment.NewLine;

            foreach (string grab in RightItems.Items)
            {
                textout = textout + grab + Environment.NewLine;
            }

            textout = "Saved File on"+ DateTime.MinValue + Environment.NewLine + textout ;
            File.WriteAllText(savefile.FileName, textout);
            MessageBox.Show("Save Complete.");
        }

        //Stats with counter

        private void statsToolStripMenuItem_Click(object sender, EventArgs e)
        {


            
            string stats = Convert.ToString(LeftItems.Items.Count);
            string stats2 = Convert.ToString(RightItems.Items.Count);
            
            statsToolStripMenuItem.Checked = true;

            Form2 f = new Form2(stats);


            f.TopLevel = false;
                f.Parent = this;
                f.Show();
                f.BringToFront();


            // MessageBox.Show( " Number of list items: " + stats);

        }


        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Form f = new Form(); //instanciate your custom Form here
        //    f.TopLevel = false;
        //    f.Parent = this;
        //    f.Show();
        //    f.BringToFront();
        //}

        //Exit app
        private void extToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Application.Exit();
        }
    }
    }
 
 