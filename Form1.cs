using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace New_word
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newWord = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(newWord))
            {
                MessageBox.Show("Please enter a word.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBox1.Contains(textBox1))
            {
                MessageBox.Show("This word has already been added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

         
            MessageBox.Show("New word has been added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void Concatenate_Click(object sender, EventArgs e)
        {
            string selectedWord1 = comboBox1.SelectedItem?.ToString();
            string selectedWord2 = comboBox2.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedWord1) || string.IsNullOrEmpty(selectedWord2))
            {
                MessageBox.Show("Please select two words to concatenate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string concatenatedWord = selectedWord1 + selectedWord2;
            ;
        }

        private void UpdateComboBoxes()
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            
        }
    }
}

