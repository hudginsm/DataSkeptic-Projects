using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingDataControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.order_DetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet.Order_Details' table. You can move, or remove it, as needed.
            this.order_DetailsTableAdapter.Fill(this.northwindDataSet.Order_Details);
            // TODO: This line of code loads data into the 'northwindDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.northwindDataSet.Orders);
            this.toolStripProgressBar1.Value = this.ordersBindingSource.Position + 1;
            this.toolStripProgressBar1.Maximum = this.ordersBindingSource.Count;
            this.ordersBindingSource.PositionChanged += new EventHandler(ordersBindingSource_PositionChanged);
        }

        void ordersBindingSource_PositionChanged(object sender, EventArgs e)
        {
            this.toolStripProgressBar1.Value = this.ordersBindingSource.Position + 1;
        }
    }
}
