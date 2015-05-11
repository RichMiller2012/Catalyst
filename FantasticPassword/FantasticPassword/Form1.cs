using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FantasticPassword
{
    public partial class Form1 : Form
    {
        ArrayList checkBoxes;
        Generate generator;


        public Form1()
        {
            InitializeComponent();
            checkBoxes = new ArrayList();
            checkBoxes.Add(checkBox1);
            checkBoxes.Add(checkBox2);
            checkBoxes.Add(checkBox3);
            checkBoxes.Add(checkBox4);
            checkBoxes.Add(checkBox5);
            checkBoxes.Add(checkBox6);
            checkBoxes.Add(checkBox7);
            checkBoxes.Add(checkBox8);         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList checkedChars = new ArrayList();

            foreach (CheckBox cb in checkBoxes)
            {
                if (!cb.Checked)
                {
                    checkedChars.Add((char)(cb.Text)[0]);
                }
            }

            generator = new Generate(checkedChars, Int16.Parse(comboBox1.Text));

            textBox1.Text = generator.create();
        }
    }
}
