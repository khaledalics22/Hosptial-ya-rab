using DBapplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_ISA
{
    public partial class Pharmacist : Form
    {
        Controller controllerObj;
        public Pharmacist()
        {
            InitializeComponent();
            controllerObj = new Controller();
            comboBox1.SelectedItem = "All";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void Pharmacist_Load(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "All")
            {
                dataGridView1.DataSource = controllerObj.SelectAllDrugs();
                dataGridView1.Refresh();
            }
            else if (comboBox1.SelectedItem.ToString() == "Empty")
            {
                dataGridView1.DataSource = controllerObj.SelectEmptyDrugs();
                dataGridView1.Refresh();
            }

        }

        //search button
        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.ToString()=="All")
            {
                dataGridView1.DataSource = controllerObj.SearchDrugs(textBox1.Text.ToString());
                dataGridView1.Refresh();
            }
            else if(comboBox1.SelectedItem.ToString() == "Empty")
            {
                dataGridView1.DataSource = controllerObj.SearchEmptyDrugs(textBox1.Text.ToString());
                dataGridView1.Refresh();
            }
        }

        //insert drugs button
        private void button4_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(textBox3.Text.ToString());
            string n = textBox2.Text.ToString();
            int q = Convert.ToInt32(textBox5.Text.ToString());
            float p = float.Parse(textBox4.Text.ToString());

            int r = controllerObj.InsertDrugs(c, n, q, p);

            if (r > 0)
            {
                MessageBox.Show("Inserted Successfully");
                if (comboBox1.SelectedItem.ToString() == "All")
                {
                    dataGridView1.DataSource = controllerObj.SelectAllDrugs();
                    dataGridView1.Refresh();
                }
                else if (comboBox1.SelectedItem.ToString() == "Empty")
                {
                    dataGridView1.DataSource = controllerObj.SelectEmptyDrugs();
                    dataGridView1.Refresh();
                }

            }
            else
                MessageBox.Show("Insertion Falied");
        }
    }
}