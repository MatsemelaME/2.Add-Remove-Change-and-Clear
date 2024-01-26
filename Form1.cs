using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.Add_Remove_Change_and_Clear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();

        }

        private void btnREMOVE_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);


        }

        private void btnCHANGE_Click(object sender, EventArgs e)
        {
            //Check if an item is selected in the ListBox
            if (listBox1.SelectedIndex != -1)
            {
                // Get the selected item from the ListBox
                string selectedWord = listBox1.SelectedItem.ToString();

                // Get the new input from the TextBox
                string newInput = textBox1.Text;

                // Change the selected item in the ListBox
                listBox1.Items[listBox1.SelectedIndex] = newInput;

                // Clear the TextBox
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Please select a word to change.", "No Word Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnCLEAR_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}