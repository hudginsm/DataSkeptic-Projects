namespace UsingDataControls
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label order_IDLabel;
            System.Windows.Forms.Label order_DateLabel;
            System.Windows.Forms.Label shipped_DateLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label order_IDLabel1;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label unit_PriceLabel;
            System.Windows.Forms.Label discountLabel;
            this.northwindDataSet = new UsingDataControls.NorthwindDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new UsingDataControls.NorthwindDataSetTableAdapters.OrdersTableAdapter();
            this.tableAdapterManager = new UsingDataControls.NorthwindDataSetTableAdapters.TableAdapterManager();
            this.ordersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.ordersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.order_IDTextBox = new System.Windows.Forms.TextBox();
            this.order_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.shipped_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.order_DetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_DetailsTableAdapter = new UsingDataControls.NorthwindDataSetTableAdapters.Order_DetailsTableAdapter();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.order_IDTextBox1 = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.unit_PriceTextBox = new System.Windows.Forms.TextBox();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            order_IDLabel = new System.Windows.Forms.Label();
            order_DateLabel = new System.Windows.Forms.Label();
            shipped_DateLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            order_IDLabel1 = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            unit_PriceLabel = new System.Windows.Forms.Label();
            discountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingNavigator)).BeginInit();
            this.ordersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_DetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.northwindDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Order_DetailsTableAdapter = this.order_DetailsTableAdapter;
            this.tableAdapterManager.OrdersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.UpdateOrder = UsingDataControls.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ordersBindingNavigator
            // 
            this.ordersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ordersBindingNavigator.BindingSource = this.ordersBindingSource;
            this.ordersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ordersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ordersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.ordersBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.toolStripProgressBar1});
            this.ordersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ordersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ordersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ordersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ordersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ordersBindingNavigator.Name = "ordersBindingNavigator";
            this.ordersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ordersBindingNavigator.Size = new System.Drawing.Size(388, 25);
            this.ordersBindingNavigator.TabIndex = 0;
            this.ordersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // ordersBindingNavigatorSaveItem
            // 
            this.ordersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ordersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ordersBindingNavigatorSaveItem.Image")));
            this.ordersBindingNavigatorSaveItem.Name = "ordersBindingNavigatorSaveItem";
            this.ordersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.ordersBindingNavigatorSaveItem.Text = "Save Data";
            this.ordersBindingNavigatorSaveItem.Click += new System.EventHandler(this.ordersBindingNavigatorSaveItem_Click);
            // 
            // order_IDLabel
            // 
            order_IDLabel.AutoSize = true;
            order_IDLabel.Location = new System.Drawing.Point(12, 36);
            order_IDLabel.Name = "order_IDLabel";
            order_IDLabel.Size = new System.Drawing.Size(50, 13);
            order_IDLabel.TabIndex = 1;
            order_IDLabel.Text = "Order ID:";
            // 
            // order_IDTextBox
            // 
            this.order_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "Order ID", true));
            this.order_IDTextBox.Location = new System.Drawing.Point(93, 33);
            this.order_IDTextBox.Name = "order_IDTextBox";
            this.order_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.order_IDTextBox.TabIndex = 2;
            // 
            // order_DateLabel
            // 
            order_DateLabel.AutoSize = true;
            order_DateLabel.Location = new System.Drawing.Point(12, 69);
            order_DateLabel.Name = "order_DateLabel";
            order_DateLabel.Size = new System.Drawing.Size(62, 13);
            order_DateLabel.TabIndex = 3;
            order_DateLabel.Text = "Order Date:";
            // 
            // order_DateDateTimePicker
            // 
            this.order_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "Order Date", true));
            this.order_DateDateTimePicker.Location = new System.Drawing.Point(93, 63);
            this.order_DateDateTimePicker.Name = "order_DateDateTimePicker";
            this.order_DateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.order_DateDateTimePicker.TabIndex = 4;
            // 
            // shipped_DateLabel
            // 
            shipped_DateLabel.AutoSize = true;
            shipped_DateLabel.Location = new System.Drawing.Point(12, 98);
            shipped_DateLabel.Name = "shipped_DateLabel";
            shipped_DateLabel.Size = new System.Drawing.Size(75, 13);
            shipped_DateLabel.TabIndex = 5;
            shipped_DateLabel.Text = "Shipped Date:";
            // 
            // shipped_DateDateTimePicker
            // 
            this.shipped_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "Shipped Date", true));
            this.shipped_DateDateTimePicker.Location = new System.Drawing.Point(93, 94);
            this.shipped_DateDateTimePicker.Name = "shipped_DateDateTimePicker";
            this.shipped_DateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.shipped_DateDateTimePicker.TabIndex = 6;
            // 
            // order_DetailsBindingSource
            // 
            this.order_DetailsBindingSource.DataMember = "New_OrderDetails";
            this.order_DetailsBindingSource.DataSource = this.ordersBindingSource;
            // 
            // order_DetailsTableAdapter
            // 
            this.order_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(131, 184);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 7;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_DetailsBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(193, 181);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDTextBox.TabIndex = 8;
            // 
            // order_IDLabel1
            // 
            order_IDLabel1.AutoSize = true;
            order_IDLabel1.Location = new System.Drawing.Point(131, 213);
            order_IDLabel1.Name = "order_IDLabel1";
            order_IDLabel1.Size = new System.Drawing.Size(50, 13);
            order_IDLabel1.TabIndex = 9;
            order_IDLabel1.Text = "Order ID:";
            // 
            // order_IDTextBox1
            // 
            this.order_IDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_DetailsBindingSource, "Order ID", true));
            this.order_IDTextBox1.Location = new System.Drawing.Point(193, 210);
            this.order_IDTextBox1.Name = "order_IDTextBox1";
            this.order_IDTextBox1.Size = new System.Drawing.Size(100, 20);
            this.order_IDTextBox1.TabIndex = 10;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(131, 241);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(49, 13);
            quantityLabel.TabIndex = 11;
            quantityLabel.Text = "Quantity:";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_DetailsBindingSource, "Quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(193, 238);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 12;
            // 
            // unit_PriceLabel
            // 
            unit_PriceLabel.AutoSize = true;
            unit_PriceLabel.Location = new System.Drawing.Point(131, 269);
            unit_PriceLabel.Name = "unit_PriceLabel";
            unit_PriceLabel.Size = new System.Drawing.Size(56, 13);
            unit_PriceLabel.TabIndex = 13;
            unit_PriceLabel.Text = "Unit Price:";
            // 
            // unit_PriceTextBox
            // 
            this.unit_PriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_DetailsBindingSource, "Unit Price", true));
            this.unit_PriceTextBox.Location = new System.Drawing.Point(193, 266);
            this.unit_PriceTextBox.Name = "unit_PriceTextBox";
            this.unit_PriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.unit_PriceTextBox.TabIndex = 14;
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Location = new System.Drawing.Point(135, 295);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new System.Drawing.Size(52, 13);
            discountLabel.TabIndex = 15;
            discountLabel.Text = "Discount:";
            // 
            // discountTextBox
            // 
            this.discountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_DetailsBindingSource, "Discount", true));
            this.discountTextBox.Location = new System.Drawing.Point(193, 292);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(100, 20);
            this.discountTextBox.TabIndex = 16;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bindingNavigator1.BindingSource = this.order_DetailsBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1});
            this.bindingNavigator1.Location = new System.Drawing.Point(93, 127);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigator1.Size = new System.Drawing.Size(255, 25);
            this.bindingNavigator1.TabIndex = 17;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem1.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem1.Text = "Delete";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 22);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 358);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(discountLabel);
            this.Controls.Add(this.discountTextBox);
            this.Controls.Add(unit_PriceLabel);
            this.Controls.Add(this.unit_PriceTextBox);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(order_IDLabel1);
            this.Controls.Add(this.order_IDTextBox1);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(shipped_DateLabel);
            this.Controls.Add(this.shipped_DateDateTimePicker);
            this.Controls.Add(order_DateLabel);
            this.Controls.Add(this.order_DateDateTimePicker);
            this.Controls.Add(order_IDLabel);
            this.Controls.Add(this.order_IDTextBox);
            this.Controls.Add(this.ordersBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingNavigator)).EndInit();
            this.ordersBindingNavigator.ResumeLayout(false);
            this.ordersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_DetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private NorthwindDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ordersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton ordersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox order_IDTextBox;
        private NorthwindDataSetTableAdapters.Order_DetailsTableAdapter order_DetailsTableAdapter;
        private System.Windows.Forms.DateTimePicker order_DateDateTimePicker;
        private System.Windows.Forms.DateTimePicker shipped_DateDateTimePicker;
        private System.Windows.Forms.BindingSource order_DetailsBindingSource;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox order_IDTextBox1;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox unit_PriceTextBox;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    }
}

