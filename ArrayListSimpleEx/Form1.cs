using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayListSimpleEx
{
    public partial class Form1 : Form
    {
        ArrayList message = new ArrayList() { "I", "love", "programming", "so", "much" };
        //a lendroit
        string text1 = string.Empty;
        // a lenvers
        string text2 = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadPhrase();

        }
        private void loadPhrase()
        {
            text1 = string.Empty;
            text2 = string.Empty;
            foreach (string a in message)
            {
                text1 += a + " ";
            }
            message.Reverse();
            foreach (string a in message)
            {
                text2 += a + " ";
            }
            message.Reverse();
        }

        private void btnShowMsg_Click(object sender, EventArgs e)
        {
           
            lblMessage.Text = text1;
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            
            
            lblMessage.Text = text2;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            message.Insert(1, txtSecondPos.Text);
            loadPhrase();
            lblMessage.Text = text1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            message.RemoveAt(1);
            loadPhrase();
            lblMessage.Text = text1;
        }
    }
}
