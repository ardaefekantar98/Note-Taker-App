using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Note_Taker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int noteCount = 0;

        public static string note1 = "";
        public static string note2 = "";
        public static string note3 = "";

        public static string title1 = "";
        public static string title2 = "";
        public static string title3 = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please enter a valid title and note...");
            }

            else if (noteCount == 0)
            {
                note1 = textBox2.Text.ToString();
                title1 = textBox1.Text.ToString();
                comboBox1.Items.Add(title1);
                MessageBox.Show("Your note has successfully added to the list.");
                noteCount++;
            }
            else if (noteCount == 1)
            {
                note2 = textBox2.Text.ToString();
                title2 = textBox1.Text.ToString();
                comboBox1.Items.Add(title2);
                MessageBox.Show("Your note has successfully added to the list.");
                noteCount++;
            }
            else if (noteCount == 2)
            {
                note3 = textBox2.Text.ToString();
                title3 = textBox1.Text.ToString();
                comboBox1.Items.Add(title3);
                MessageBox.Show("Your note has successfully added to the list.");
                noteCount++;
            }
            else
            {
                MessageBox.Show("You can't add more than 3 notes!");
            }
            textBox1.Clear();
            textBox2.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == title1)
            {
                textBox1.Text = title1;
                textBox2.Text = note1;
            }
            if (comboBox1.SelectedItem == title2)
            {
                textBox1.Text = title2;
                textBox2.Text = note2;
            }
            if (comboBox1.SelectedItem == title3)
            {
                textBox1.Text = title3;
                textBox2.Text = note3;
            }
        }
    }
}
