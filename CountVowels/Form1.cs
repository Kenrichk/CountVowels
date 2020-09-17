using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CountVowels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtPhrase_TextChanged(object sender, EventArgs e)
        {
            int vowels = 0; string phrase = txtPhrase.Text.ToLower();
            for (int i = 0; i < phrase.Length; i++)
            {
                if (phrase[i] == 'a' || phrase[i] == 'e' || phrase[i] == 'i' || phrase[i] == 'o' || phrase[i] == 'u')
                {
                    vowels++;
                }
            }
            txtVowelCount.Text = Convert.ToString(vowels);
        }
    }
}
