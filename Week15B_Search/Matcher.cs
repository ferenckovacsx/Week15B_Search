using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week15B_Search
{
    public partial class Matcher : Form
    {
        public Matcher()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            MatchCollection matches = Regex.Matches(richTextBox.Text, @textBoxPattern.Text);

            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    richTextBox.Select(match.Index, match.Length);
                    richTextBox.SelectionBackColor = Color.Pink;
                    richTextBoxMatched.Text = match.ToString();
                }
            }
            else
            {
                MessageBox.Show("Sorry, no matches!");
            }

      
        }
    }
}
