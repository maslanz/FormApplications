using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PTRFS_Implementation
{
    public partial class Form1 : Form
    {
        List<Panel> list_panel = new List<Panel>();
        string con_str = "Data Source=.; Initial Catalog=VOYAGES; User Id=sa; Password=D*pl9rin; Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Bus");
            comboBox1.Items.Add("Subway");
            comboBox1.Items.Add("Seaway");
            comboBox1.Items.Add("Tramway");
            comboBox2.Items.Add("30");
            comboBox2.Items.Add("58");
            comboBox2.Items.Add("222");
            comboBox3.Items.Add("Karşıyaka-Pasaport-Alsancak");
            comboBox3.Items.Add("Üçkuyular-Göztepe-Konak-Pasaport-Bostanlı");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            list_panel.Add(panel1);
            list_panel.Add(panel2);
            list_panel.Add(panel3);
            list_panel.Add(panel4);
            list_panel.Add(panel5);
            list_panel[0].BringToFront(); //panel1
        }

        private void button3_Click(object sender, EventArgs e)
        {
            list_panel[1].BringToFront(); //panel2
        }

        private void prev_button_Click(object sender, EventArgs e)
        {
            list_panel[0].BringToFront(); //panel1
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection sql_con = new SqlConnection(con_str))
            {
                sql_con.Open();
                if (comboBox1.SelectedItem.ToString() == "Subway")
                {
                    SqlDataAdapter sql_da = new SqlDataAdapter("select * from subway", sql_con);
                    DataTable data_table = new DataTable();
                    sql_da.Fill(data_table);
                    dataGridView1.DataSource = data_table;
                    list_panel[2].BringToFront(); //panel3
                }
                if (comboBox1.SelectedItem.ToString() == "Tramway")
                {
                    SqlDataAdapter sql_da = new SqlDataAdapter("select * from tramway", sql_con);
                    DataTable data_table = new DataTable();
                    sql_da.Fill(data_table);
                    dataGridView1.DataSource = data_table;
                    list_panel[2].BringToFront(); //panel3
                }
                if (comboBox1.SelectedItem.ToString() == "Bus")
                {
                    list_panel[3].BringToFront(); //panel4
                }
                if (comboBox1.SelectedItem.ToString() == "Seaway")
                {
                    list_panel[4].BringToFront(); //panel5
                }
            }
        }

        private void prev_button2_Click(object sender, EventArgs e)
        {
            list_panel[1].BringToFront(); //panel2
        }

        private void prev_button3_Click(object sender, EventArgs e)
        {
            list_panel[1].BringToFront(); //panel2
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection sql_con = new SqlConnection(con_str))
            {
                sql_con.Open();
                if (comboBox2.SelectedItem.ToString() == "30")
                {
                    SqlDataAdapter sql_da = new SqlDataAdapter("select * from bus_30", sql_con);
                    DataTable data_table = new DataTable();
                    sql_da.Fill(data_table);
                    dataGridView2.DataSource = data_table;
                }
                if (comboBox2.SelectedItem.ToString() == "58")
                {
                    SqlDataAdapter sql_da = new SqlDataAdapter("select * from bus_58", sql_con);
                    DataTable data_table = new DataTable();
                    sql_da.Fill(data_table);
                    dataGridView2.DataSource = data_table;
                }
                if (comboBox2.SelectedItem.ToString() == "222")
                {
                    SqlDataAdapter sql_da = new SqlDataAdapter("select * from bus_222", sql_con);
                    DataTable data_table = new DataTable();
                    sql_da.Fill(data_table);
                    dataGridView2.DataSource = data_table;
                }
            }
        }

        private void prev_button4_Click(object sender, EventArgs e)
        {
            list_panel[1].BringToFront(); //panel2
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection sql_con = new SqlConnection(con_str))
            {
                sql_con.Open();
                if (comboBox3.SelectedItem.ToString() == "Üçkuyular-Göztepe-Konak-Pasaport-Bostanlı")
                {
                    SqlDataAdapter sql_da = new SqlDataAdapter("select * from seaway1", sql_con);
                    DataTable data_table = new DataTable();
                    sql_da.Fill(data_table);
                    dataGridView3.DataSource = data_table;
                }
                if (comboBox3.SelectedItem.ToString() == "Karşıyaka-Pasaport-Alsancak")
                {
                    SqlDataAdapter sql_da = new SqlDataAdapter("select * from seaway2", sql_con);
                    DataTable data_table = new DataTable();
                    sql_da.Fill(data_table);
                    dataGridView3.DataSource = data_table;
                }
            }
        }
    }//end of Form1
}//end of namespace
