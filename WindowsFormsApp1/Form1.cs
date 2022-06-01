using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            String st;
            
            st = tb1.Text.ToString();
            char[] a = st.ToCharArray();
            char[] b = new char[a.Length];
            char letter = a[1];
            for (int i = 0; i < a.Length; i++)
            {
                int counter = 0;
                letter = a[i];
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[j] == letter)
                    {
                        counter += 1;
                    }
                
                        
                }
                
                if (counter <= 1)
                {
                    b[i] = a[i];
                }
                else if(counter > 1)
                {
                    b[i] = ' ';
                }
                
                counter = 0;

            }

            string str2 = new string(b);
            tb2.Text = str2;

        }
    }
}
