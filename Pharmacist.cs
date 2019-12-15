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
        int SelectedCode = -1;
        Controller controllerObj;
        public Pharmacist()
        {
            InitializeComponent();
            controllerObj = new Controller();
            comboBox1.SelectedItem = "All";
        }

        //fill gridView as chosen in comboBox
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "All")
            {
                dataGridView1.DataSource = controllerObj.SelectAllDrugs();
                dataGridView1.Refresh();
                button3.Enabled = true;
            }
            else if (comboBox1.SelectedItem.ToString() == "Empty")
            {
                dataGridView1.DataSource = controllerObj.SelectEmptyDrugs();
                dataGridView1.Refresh();
                //if this is empty list >> user can't sell any one; so we turn off this button for being useless
                button3.Enabled = false;
            }

        }

        //search button
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "All")
            {
                dataGridView1.DataSource = controllerObj.SearchDrugs(textBox1.Text.ToString());
                dataGridView1.Refresh();
            }
            else if (comboBox1.SelectedItem.ToString() == "Empty")
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

            //clear input textBoxes
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //check if comboBox has value Doctor
            if (comboBox1.SelectedItem.ToString() == "All")
            {
                int indexi = e.RowIndex;     //get clicked row index
                if (indexi >= 0)               //check if this row in table
                {
                    DataGridViewRow selRow = dataGridView1.Rows[indexi];    //store row
                    SelectedCode = Convert.ToInt32(selRow.Cells[0].Value.ToString());    //get cel[0] >> which is location of DSSN
                }
                //if there's no selected drug >> make code=-1 (to avoid manipulation the previous selected row)
                else
                    SelectedCode = -1;
            }

            else if (comboBox1.SelectedItem.ToString() == "Empty")
            {
                int indexi = e.RowIndex;
                if (indexi >= 0)
                {
                    DataGridViewRow selRow = dataGridView1.Rows[indexi];
                    SelectedCode = Convert.ToInt32(selRow.Cells[0].Value.ToString());
                }
                //if there's no selected drug >> make code=-1 (to avoid manipulation the previous selected row)
                else
                    SelectedCode = -1;
            }

        }


        //add quantity button
        private void button2_Click(object sender, EventArgs e)
        {
            int r = controllerObj.AddQuantity(SelectedCode);
            if (r <= 0)
                MessageBox.Show("Failed");
            //update gridView data
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

        //if button sell is clicked
        private void button3_Click(object sender, EventArgs e)
        {
            int r = controllerObj.SellDrug(SelectedCode);
            //check if it's valid to be sold
            if (r > 0)
            {
                int r2 = controllerObj.AddToSold(SelectedCode);
            }
            else
                MessageBox.Show("Not Sold");
            //update gridView Data finally
            dataGridView1.DataSource = controllerObj.SelectAllDrugs();
            dataGridView1.Refresh();
        }
    }
}