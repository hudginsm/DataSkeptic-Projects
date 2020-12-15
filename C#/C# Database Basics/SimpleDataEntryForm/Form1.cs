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
        public BindingSource order_details_bndSource;
        public Boolean saveprompt;

        public Form1()
        {
            InitializeComponent();
            saveprompt = false;
            connString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\hudgi\source\repos\hudginsm\DataSkeptic-Projects\C#\C# Database Basics\Northwind.accdb; Persist Security Info=False;";
            NW_Orders = new DataSet();
            query1 = "SELECT * FROM [Orders]";
            query2 = "SELECT * FROM [Order Details]";
            orders_dAdapter = new OleDbDataAdapter(query1, connString);
            order_details_dAdapter = new OleDbDataAdapter(query2, connString);

            cBuilder = new OleDbCommandBuilder(orders_dAdapter);
            cBuilder.QuotePrefix = "[";
            cBuilder.QuoteSuffix = "]";
            cBuilder1 = new OleDbCommandBuilder(order_details_dAdapter);
            cBuilder1.QuotePrefix = "[";
            cBuilder1.QuoteSuffix = "]";

            orders_dAdapter.Fill(NW_Orders, "Orders");
            order_details_dAdapter.Fill(NW_Orders, "Order Details");
            DataColumn parentcolumn = NW_Orders.Tables["Orders"].Columns["Order ID"];
            DataColumn childcolumn = NW_Orders.Tables["Order Details"].Columns["Order ID"];
            DataRelation relation = new System.Data.DataRelation("OrderstoDetails", parentcolumn, childcolumn);
            NW_Orders.Relations.Add(relation);

            orders_bndSource = new BindingSource();
            orders_bndSource.DataSource = NW_Orders.Tables["Orders"];
            order_details_bndSource = new BindingSource();
            order_details_bndSource.DataSource = orders_bndSource;
            order_details_bndSource.DataMember = "OrderstoDetails";

            order_details_bndSource.CurrentItemChanged += new EventHandler(order_details_bndSource_CurrentItemChanged);
            order_details_bndSource.ListChanged += new ListChangedEventHandler(order_details_bndSource_ListChanged);

            this.textBox1.DataBindings.Add(new Binding("Text", orders_bndSource, "Order ID", true));
            this.dateTimePicker1.DataBindings.Add(new Binding("Text", orders_bndSource, "Order Date", true));
            this.dateTimePicker2.DataBindings.Add(new Binding("Text", orders_bndSource, "Shipped Date", true));
            this.textBox4.DataBindings.Add(new Binding("Text", order_details_bndSource, "ID", true));
            this.textBox5.DataBindings.Add(new Binding("Text", order_details_bndSource, "Order ID", true));
            this.textBox6.DataBindings.Add(new Binding("Text", order_details_bndSource, "Quantity", true));
            this.textBox7.DataBindings.Add(new Binding("Text", order_details_bndSource, "Unit Price", true));
            this.textBox8.DataBindings.Add(new Binding("Text", order_details_bndSource, "Discount", true));
            this.textBox2.Text = "" + (order_details_bndSource.Position + 1);
            this.textBox3.Text = order_details_bndSource.Count.ToString();

            foreach (Control tx in this.Controls)
            {
                if (tx.DataBindings.Count > 0 && tx.Name != "textBox1" && tx.Name != "textBox3")
                {
                    tx.Enter += new EventHandler(tx_Enter);
                }
            }
        }

        void tx_Enter(object sender, EventArgs e)
        {
            saveprompt = true;
        }

        void order_details_bndSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            saveprompt = true;
        }

        private void order_details_bndSource_CurrentItemChanged(object sender, EventArgs e)
        {
            saveprompt = true;
        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            order_details_bndSource.AddNew();
        }

        private void NextParent_Click(object sender, EventArgs e)
        {
            if (saveprompt)
            {
                DialogResult x = MessageBox.Show("Do you want to save the data first?", "Important", MessageBoxButtons.YesNo);
                if (x == DialogResult.Yes)
                {
                    try
                    {
                        orders_bndSource.EndEdit();
                        order_details_bndSource.EndEdit();
                        orders_dAdapter.Update(NW_Orders, "Orders");
                        order_details_dAdapter.Update(NW_Orders, "Order Details");

                        MessageBox.Show("Record Updated");
                    }
                    catch (OleDbException f)
                    {
                        MessageBox.Show("Record Update Failed - Error Code " + f.ErrorCode.ToString());
                    }
                }
            }
            orders_bndSource.MoveNext();
            this.textBox2.Text = "" + (order_details_bndSource.Position + 1);
            this.textBox3.Text = order_details_bndSource.Count.ToString();
            saveprompt = false;
        }

        private void NextChild_Click(object sender, EventArgs e)
        {
            if (saveprompt)
            {
                DialogResult x = MessageBox.Show("Do you want to save the data first?", "Important", MessageBoxButtons.YesNo);
                if (x == DialogResult.Yes)
                {
                    try
                    {
                        orders_bndSource.EndEdit();
                        order_details_bndSource.EndEdit();
                        orders_dAdapter.Update(NW_Orders, "Orders");
                        order_details_dAdapter.Update(NW_Orders, "Order Details");

                        MessageBox.Show("Record Updated");
                    }
                    catch (OleDbException f)
                    {
                        MessageBox.Show("Record Update Failed - Error Code " + f.ErrorCode.ToString());
                    }
                }
            }
            order_details_bndSource.MoveNext();
            this.textBox2.Text = "" + (order_details_bndSource.Position + 1);
            saveprompt = false;
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                orders_bndSource.EndEdit();
                order_details_bndSource.EndEdit();
                orders_dAdapter.Update(NW_Orders, "Orders");
                order_details_dAdapter.Update(NW_Orders, "Order Details");
                saveprompt = false;
                MessageBox.Show("Record Updated");
            }
            catch (OleDbException f)
            {
                MessageBox.Show("RecordUpdate Failed - Error Code " + f.ErrorCode.ToString());
            }
        }
    }
}
