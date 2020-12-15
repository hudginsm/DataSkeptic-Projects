using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleDataEntryForm
{
    public partial class Form1 : Form
    {
        public string connString;
        public string query1;
        public string query2;
        public OleDbDataAdapter orders_dAdapter;
        public OleDbDataAdapter order_details_dAdapter;
        public DataSet NW_Orders;
        public OleDbCommandBuilder cBuilder;
        public OleDbCommandBuilder cBuilder1;
        public BindingSource orders_bndSource;
        public BindingSource Order_details_bndSource;
        public Boolean saveprompt;

        public Form1()
        {
            InitializeComponent();
            saveprompt = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
