using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstTestApplication
{
    public partial class Form1 : Form
    {
        public string connString;
        public string query;
        public SqlDataAdapter dAdapter;
        public DataTable dTable;
        public SqlCommandBuilder cBuilder;
        public DataView myDataView;


        public Form1() 
        {
            InitializeComponent();
            connString = "Data Source=DataSkeptic;Initial Catalog=AdventureWorks2019;Integrated Security=True;";
            query = "SELECT * FROM HumanResources.Department";
            dAdapter = new SqlDataAdapter(query, connString);
            dTable = new DataTable();
            cBuilder = new SqlCommandBuilder(dAdapter);
            cBuilder.QuotePrefix = "[";
            cBuilder.QuoteSuffix = "]";
            myDataView = dTable.DefaultView;
            dAdapter.Fill(dTable);
            BindingSource bndSource = new BindingSource();
            bndSource.DataSource = dTable;
            this.dataGridView1.DataSource = bndSource;
            for (int q = 0; q <= dataGridView1.ColumnCount - 1; q++)
            {
                this.comboBox1.Items.Add(this.dataGridView1.Columns[q].HeaderText.ToString());
            }
            SqlConnection xyz = new SqlConnection(connString);
            xyz.Open();
            DataTable tbl = xyz.GetSchema("Tables");

            dataGridView2.DataSource = tbl;
            DataView tbl_dv = tbl.DefaultView;
        }

        private void Cell_Update(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dAdapter.Update(dTable);
                this.textBox1.Text = "Updated" + System.DateTime.Now.ToString();
            }
            catch (InvalidOperationException f)
            {
                MessageBox.Show("Operation is not allowed");
                this.textBox1.Text = "Not Updated" + f.Source.ToString();
            }
            catch (SqlException f)
            {
                this.textBox1.Text = "Not Updated" + f.Source.ToString();
            }
        }

        private void filter_click(object sender, EventArgs e)
        {
            string mystr;
            if (myDataView.RowFilter == "")
            {
                mystr = "[" + dataGridView1.CurrentCell.OwningColumn.HeaderText.ToString() + "]";
                mystr += "= '" + dataGridView1.CurrentCell.Value.ToString() + "'";
                myDataView.RowFilter = mystr;
            }
            else
            {
                mystr = myDataView.RowFilter + " and ";
                mystr += "[" + dataGridView1.CurrentCell.OwningColumn.HeaderText.ToString() + "]";
                mystr += "= '" + dataGridView1.CurrentCell.Value.ToString() + "'";
                myDataView.RowFilter = mystr;
            }
        }

        private void clear_filter(object sender, EventArgs e)
        {
            myDataView.RowFilter = "";
        }

        private void change_data_source(object sender, EventArgs e)
        {
            string tbl_str = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            string skema_str = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            query = "SELECT * FROM [" + skema_str + "].[" + tbl_str + "]";
            dAdapter = new SqlDataAdapter(query, connString);
            dTable = new DataTable();
            cBuilder = new SqlCommandBuilder(dAdapter);
            cBuilder.QuotePrefix = "[";
            cBuilder.QuoteSuffix = "]";
            myDataView = dTable.DefaultView;
            dAdapter.Fill(dTable);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = dTable;
            this.dataGridView1.DataSource = bSource;
            for (int q = 0; q <= dataGridView1.ColumnCount - 1; q++)
            {
                this.comboBox1.Items.Add(this.dataGridView1.Columns[q].HeaderText.ToString());
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
