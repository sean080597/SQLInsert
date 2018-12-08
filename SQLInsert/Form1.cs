using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SQLInsert
{
    public partial class Form1 : Form
    {
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(@"Data Source = .\SQLEXPRESS; Initial Catalog = TestSQLInsert; Integrated Security = True");
        SqlDataAdapter da;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            display_data();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            con.Open();
            //cmd.CommandText = "insert into EmptyData values ('"+textBox_name.Text+"', '"+textBox_age.Text+"', '"+textBox_class.Text+"')";
            cmd = new SqlCommand("INSERT INTO EmptyData (Name, Age, Class) VALUES (@Name, @Age, @Class)", con);
            cmd.Parameters.AddWithValue("@Name", textBox_name.Text);
            cmd.Parameters.AddWithValue("@Age", textBox_age.Text);
            cmd.Parameters.AddWithValue("@Class", textBox_class.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            textBox_name.Text = "";
            textBox_class.Text = "";
            textBox_age.Text = "";
            display_data();
            MessageBox.Show("Record inserted successfully");
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            con.Open();

            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update EmptyData set name='"+textBox_class.Text+"' where name='"+textBox_name.Text+"'";
            cmd.ExecuteNonQuery();
            
            con.Close();
            display_data();
            MessageBox.Show("Record updated successfully");
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            panel_delete.Visible = true;
        }

        private void button_display_Click(object sender, EventArgs e)
        {
            
        }

        //method for showing data of table
        public void copy_data_table()
        {
            con.Open();

            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into TempTable from EmptyData";
            cmd.ExecuteNonQuery();

            con.Close();
        }

		//hiển thị nội dung ra dataGridView
        public void display_data()
        {
            con.Open();

            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from EmptyData";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }
		
		//function for load ListView
		/*void LoadListview()
        {
            sqlConn.Open();

            SqlCommand cmd = sqlConn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from NhanVien";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            lvNhanVien.Items.Clear();
            lvNhanVien.Refresh();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem row = new ListViewItem(dt.Rows[i][0].ToString());
                for (int j = 1; j < dt.Columns.Count; j++)
                {
                    row.SubItems.Add(dt.Rows[i][j].ToString());
                }
                lvNhanVien.Items.Add(row);
            }

            sqlConn.Close();
        }*/

        private void button_deleteInPanel_Click(object sender, EventArgs e)
        {
            con.Open();

            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from EmptyData where name='"+textBox_nameDel.Text+"'";
            cmd.ExecuteNonQuery();
          
            con.Close();
            display_data();
            MessageBox.Show("Record deleted successfully");
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            panel_delete.Visible = false;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            con.Open();

            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from EmptyData where name='"+textBox_name.Text+"'";
            cmd.ExecuteNonQuery();

            //to show table
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }
    }
}
