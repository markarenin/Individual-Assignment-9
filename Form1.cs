using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Individual_Assignment_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] letters = textBox1.Text.ToUpper().ToCharArray(); 
            Dictionary<char, int> keyValues = new Dictionary<char, int>();
            foreach (char letter in letters)
            {
                if (keyValues.ContainsKey(letter))
                {
                    keyValues[letter]++;
                } else
                {
                    keyValues[letter] = 1;
                }
            }
            KeyValuePair<char, int> some = keyValues.First(kv => kv.Value == keyValues.Values.Max());

            MessageBox.Show($"{some.Key} : {some.Value}");
        }
    }
}
