namespace Client.Present
{
    partial class Shop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shop));
            this.tabPageBasket = new System.Windows.Forms.TabPage();
            this.materialButtonChekout = new MaterialSkin.Controls.MaterialButton();
            this.materialLabelTotalPrice = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelTotal = new MaterialSkin.Controls.MaterialLabel();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeaderName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderPrice = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderCount = new System.Windows.Forms.ColumnHeader();
            this.tabPageProducts = new System.Windows.Forms.TabPage();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox21 = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialFloatingActionButton1 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPageAccount = new System.Windows.Forms.TabPage();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageOrders = new System.Windows.Forms.TabPage();
            this.materialFloatingActionButton2 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPageAdmin = new System.Windows.Forms.TabPage();
            this.tabControlAdmin = new System.Windows.Forms.TabControl();
            this.tabPageAddSupply = new System.Windows.Forms.TabPage();
            this.materialButtonAddSupply = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox24 = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox23 = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox22 = new MaterialSkin.Controls.MaterialTextBox2();
            this.dataGridViewSupplies = new System.Windows.Forms.DataGridView();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnApplyChange = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPageManufacturers = new System.Windows.Forms.TabPage();
            this.tabPageCategories = new System.Windows.Forms.TabPage();
            this.tabPageUsers = new System.Windows.Forms.TabPage();
            this.tabPageProduct = new System.Windows.Forms.TabPage();
            this.dataImplBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageBasket.SuspendLayout();
            this.tabPageProducts.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.tabPageOrders.SuspendLayout();
            this.tabPageAdmin.SuspendLayout();
            this.tabControlAdmin.SuspendLayout();
            this.tabPageAddSupply.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataImplBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPageBasket
            // 
            this.tabPageBasket.Controls.Add(this.materialButtonChekout);
            this.tabPageBasket.Controls.Add(this.materialLabelTotalPrice);
            this.tabPageBasket.Controls.Add(this.materialLabelTotal);
            this.tabPageBasket.Controls.Add(this.materialListView1);
            this.tabPageBasket.Location = new System.Drawing.Point(4, 24);
            this.tabPageBasket.Name = "tabPageBasket";
            this.tabPageBasket.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBasket.Size = new System.Drawing.Size(971, 497);
            this.tabPageBasket.TabIndex = 2;
            this.tabPageBasket.Text = "Basket";
            this.tabPageBasket.UseVisualStyleBackColor = true;
            // 
            // materialButtonChekout
            // 
            this.materialButtonChekout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonChekout.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonChekout.Depth = 0;
            this.materialButtonChekout.HighEmphasis = true;
            this.materialButtonChekout.Icon = null;
            this.materialButtonChekout.Location = new System.Drawing.Point(683, 425);
            this.materialButtonChekout.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonChekout.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonChekout.Name = "materialButtonChekout";
            this.materialButtonChekout.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonChekout.Size = new System.Drawing.Size(88, 36);
            this.materialButtonChekout.TabIndex = 3;
            this.materialButtonChekout.Text = "Chekout";
            this.materialButtonChekout.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonChekout.UseAccentColor = false;
            this.materialButtonChekout.UseVisualStyleBackColor = true;
            this.materialButtonChekout.Click += new System.EventHandler(this.materialButtonChekout_Click);
            // 
            // materialLabelTotalPrice
            // 
            this.materialLabelTotalPrice.AutoSize = true;
            this.materialLabelTotalPrice.Depth = 0;
            this.materialLabelTotalPrice.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelTotalPrice.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabelTotalPrice.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.materialLabelTotalPrice.Location = new System.Drawing.Point(450, 6);
            this.materialLabelTotalPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelTotalPrice.Name = "materialLabelTotalPrice";
            this.materialLabelTotalPrice.Size = new System.Drawing.Size(1, 0);
            this.materialLabelTotalPrice.TabIndex = 2;
            // 
            // materialLabelTotal
            // 
            this.materialLabelTotal.AutoSize = true;
            this.materialLabelTotal.Depth = 0;
            this.materialLabelTotal.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelTotal.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabelTotal.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.materialLabelTotal.Location = new System.Drawing.Point(382, 6);
            this.materialLabelTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelTotal.Name = "materialLabelTotal";
            this.materialLabelTotal.Size = new System.Drawing.Size(62, 29);
            this.materialLabelTotal.TabIndex = 1;
            this.materialLabelTotal.Text = "Total:";
            // 
            // materialListView1
            // 
            this.materialListView1.AutoSizeTable = false;
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderPrice,
            this.columnHeaderCount});
            this.materialListView1.Depth = 0;
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.Location = new System.Drawing.Point(6, 6);
            this.materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(370, 409);
            this.materialListView1.TabIndex = 0;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            // 
            // columnHeaderPrice
            // 
            this.columnHeaderPrice.Text = "Price";
            // 
            // columnHeaderCount
            // 
            this.columnHeaderCount.Text = "Count";
            // 
            // tabPageProducts
            // 
            this.tabPageProducts.Controls.Add(this.materialLabel1);
            this.tabPageProducts.Controls.Add(this.materialTextBox21);
            this.tabPageProducts.Controls.Add(this.materialFloatingActionButton1);
            this.tabPageProducts.Controls.Add(this.flowLayoutPanel1);
            this.tabPageProducts.Location = new System.Drawing.Point(4, 24);
            this.tabPageProducts.Name = "tabPageProducts";
            this.tabPageProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProducts.Size = new System.Drawing.Size(971, 497);
            this.tabPageProducts.TabIndex = 1;
            this.tabPageProducts.Text = "Products";
            this.tabPageProducts.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(6, 26);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(36, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Find:";
            // 
            // materialTextBox21
            // 
            this.materialTextBox21.AnimateReadOnly = false;
            this.materialTextBox21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox21.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox21.Depth = 0;
            this.materialTextBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox21.HideSelection = true;
            this.materialTextBox21.LeadingIcon = null;
            this.materialTextBox21.Location = new System.Drawing.Point(48, 14);
            this.materialTextBox21.MaxLength = 32767;
            this.materialTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox21.Name = "materialTextBox21";
            this.materialTextBox21.PasswordChar = '\0';
            this.materialTextBox21.PrefixSuffixText = null;
            this.materialTextBox21.ReadOnly = false;
            this.materialTextBox21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox21.SelectedText = "";
            this.materialTextBox21.SelectionLength = 0;
            this.materialTextBox21.SelectionStart = 0;
            this.materialTextBox21.ShortcutsEnabled = true;
            this.materialTextBox21.Size = new System.Drawing.Size(250, 48);
            this.materialTextBox21.TabIndex = 3;
            this.materialTextBox21.TabStop = false;
            this.materialTextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox21.TrailingIcon = null;
            this.materialTextBox21.UseSystemPasswordChar = false;
            // 
            // materialFloatingActionButton1
            // 
            this.materialFloatingActionButton1.Depth = 0;
            this.materialFloatingActionButton1.Icon = ((System.Drawing.Image)(resources.GetObject("materialFloatingActionButton1.Icon")));
            this.materialFloatingActionButton1.Location = new System.Drawing.Point(909, 6);
            this.materialFloatingActionButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton1.Name = "materialFloatingActionButton1";
            this.materialFloatingActionButton1.Size = new System.Drawing.Size(56, 56);
            this.materialFloatingActionButton1.TabIndex = 1;
            this.materialFloatingActionButton1.UseVisualStyleBackColor = true;
            this.materialFloatingActionButton1.Click += new System.EventHandler(this.materialFloatingActionButton1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.Olive;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 75);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(965, 440);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(965, 440);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(965, 440);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tabPageAccount
            // 
            this.tabPageAccount.Location = new System.Drawing.Point(4, 24);
            this.tabPageAccount.Name = "tabPageAccount";
            this.tabPageAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAccount.Size = new System.Drawing.Size(971, 497);
            this.tabPageAccount.TabIndex = 0;
            this.tabPageAccount.Text = "Account";
            this.tabPageAccount.UseVisualStyleBackColor = true;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPageAccount);
            this.materialTabControl1.Controls.Add(this.tabPageProducts);
            this.materialTabControl1.Controls.Add(this.tabPageBasket);
            this.materialTabControl1.Controls.Add(this.tabPageOrders);
            this.materialTabControl1.Controls.Add(this.tabPageAdmin);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.HotTrack = true;
            this.materialTabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialTabControl1.Location = new System.Drawing.Point(6, 67);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(979, 525);
            this.materialTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.materialTabControl1.TabIndex = 2;
            this.materialTabControl1.SelectedIndexChanged += new System.EventHandler(this.materialTabControl1_SelectedIndexChanged);
            // 
            // tabPageOrders
            // 
            this.tabPageOrders.Controls.Add(this.materialFloatingActionButton2);
            this.tabPageOrders.Controls.Add(this.flowLayoutPanel2);
            this.tabPageOrders.Location = new System.Drawing.Point(4, 24);
            this.tabPageOrders.Name = "tabPageOrders";
            this.tabPageOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrders.Size = new System.Drawing.Size(971, 497);
            this.tabPageOrders.TabIndex = 3;
            this.tabPageOrders.Text = "Orders";
            this.tabPageOrders.UseVisualStyleBackColor = true;
            // 
            // materialFloatingActionButton2
            // 
            this.materialFloatingActionButton2.Depth = 0;
            this.materialFloatingActionButton2.Icon = ((System.Drawing.Image)(resources.GetObject("materialFloatingActionButton2.Icon")));
            this.materialFloatingActionButton2.Location = new System.Drawing.Point(912, 3);
            this.materialFloatingActionButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton2.Name = "materialFloatingActionButton2";
            this.materialFloatingActionButton2.Size = new System.Drawing.Size(56, 56);
            this.materialFloatingActionButton2.TabIndex = 2;
            this.materialFloatingActionButton2.UseVisualStyleBackColor = true;
            this.materialFloatingActionButton2.Click += new System.EventHandler(this.materialFloatingActionButton2_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 65);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(965, 476);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // tabPageAdmin
            // 
            this.tabPageAdmin.Controls.Add(this.tabControlAdmin);
            this.tabPageAdmin.Location = new System.Drawing.Point(4, 24);
            this.tabPageAdmin.Name = "tabPageAdmin";
            this.tabPageAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdmin.Size = new System.Drawing.Size(971, 497);
            this.tabPageAdmin.TabIndex = 4;
            this.tabPageAdmin.Text = "Admin";
            this.tabPageAdmin.UseVisualStyleBackColor = true;
            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.Controls.Add(this.tabPageAddSupply);
            this.tabControlAdmin.Controls.Add(this.tabPageManufacturers);
            this.tabControlAdmin.Controls.Add(this.tabPageCategories);
            this.tabControlAdmin.Controls.Add(this.tabPageUsers);
            this.tabControlAdmin.Controls.Add(this.tabPageProduct);
            this.tabControlAdmin.Location = new System.Drawing.Point(6, 6);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.SelectedIndex = 0;
            this.tabControlAdmin.Size = new System.Drawing.Size(962, 485);
            this.tabControlAdmin.TabIndex = 0;
            // 
            // tabPageAddSupply
            // 
            this.tabPageAddSupply.Controls.Add(this.materialButtonAddSupply);
            this.tabPageAddSupply.Controls.Add(this.materialLabel4);
            this.tabPageAddSupply.Controls.Add(this.materialTextBox24);
            this.tabPageAddSupply.Controls.Add(this.materialLabel3);
            this.tabPageAddSupply.Controls.Add(this.materialTextBox23);
            this.tabPageAddSupply.Controls.Add(this.materialLabel2);
            this.tabPageAddSupply.Controls.Add(this.materialTextBox22);
            this.tabPageAddSupply.Controls.Add(this.dataGridViewSupplies);
            this.tabPageAddSupply.Location = new System.Drawing.Point(4, 24);
            this.tabPageAddSupply.Name = "tabPageAddSupply";
            this.tabPageAddSupply.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddSupply.Size = new System.Drawing.Size(954, 457);
            this.tabPageAddSupply.TabIndex = 0;
            this.tabPageAddSupply.Text = "Supplies";
            this.tabPageAddSupply.UseVisualStyleBackColor = true;
            // 
            // materialButtonAddSupply
            // 
            this.materialButtonAddSupply.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonAddSupply.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonAddSupply.Depth = 0;
            this.materialButtonAddSupply.HighEmphasis = true;
            this.materialButtonAddSupply.Icon = null;
            this.materialButtonAddSupply.Location = new System.Drawing.Point(748, 126);
            this.materialButtonAddSupply.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonAddSupply.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonAddSupply.Name = "materialButtonAddSupply";
            this.materialButtonAddSupply.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonAddSupply.Size = new System.Drawing.Size(64, 36);
            this.materialButtonAddSupply.TabIndex = 8;
            this.materialButtonAddSupply.Text = "ADD";
            this.materialButtonAddSupply.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonAddSupply.UseAccentColor = false;
            this.materialButtonAddSupply.UseVisualStyleBackColor = true;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(543, 128);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(47, 19);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "Count:";
            // 
            // materialTextBox24
            // 
            this.materialTextBox24.AnimateReadOnly = false;
            this.materialTextBox24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox24.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox24.Depth = 0;
            this.materialTextBox24.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox24.HideSelection = true;
            this.materialTextBox24.LeadingIcon = null;
            this.materialTextBox24.Location = new System.Drawing.Point(624, 114);
            this.materialTextBox24.MaxLength = 32767;
            this.materialTextBox24.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox24.Name = "materialTextBox24";
            this.materialTextBox24.PasswordChar = '\0';
            this.materialTextBox24.PrefixSuffixText = null;
            this.materialTextBox24.ReadOnly = false;
            this.materialTextBox24.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox24.SelectedText = "";
            this.materialTextBox24.SelectionLength = 0;
            this.materialTextBox24.SelectionStart = 0;
            this.materialTextBox24.ShortcutsEnabled = true;
            this.materialTextBox24.Size = new System.Drawing.Size(82, 48);
            this.materialTextBox24.TabIndex = 6;
            this.materialTextBox24.TabStop = false;
            this.materialTextBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox24.TrailingIcon = null;
            this.materialTextBox24.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(543, 70);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(38, 19);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Date:";
            // 
            // materialTextBox23
            // 
            this.materialTextBox23.AnimateReadOnly = false;
            this.materialTextBox23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox23.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox23.Depth = 0;
            this.materialTextBox23.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox23.HideSelection = true;
            this.materialTextBox23.LeadingIcon = null;
            this.materialTextBox23.Location = new System.Drawing.Point(624, 60);
            this.materialTextBox23.MaxLength = 32767;
            this.materialTextBox23.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox23.Name = "materialTextBox23";
            this.materialTextBox23.PasswordChar = '\0';
            this.materialTextBox23.PrefixSuffixText = null;
            this.materialTextBox23.ReadOnly = false;
            this.materialTextBox23.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox23.SelectedText = "";
            this.materialTextBox23.SelectionLength = 0;
            this.materialTextBox23.SelectionStart = 0;
            this.materialTextBox23.ShortcutsEnabled = true;
            this.materialTextBox23.Size = new System.Drawing.Size(188, 48);
            this.materialTextBox23.TabIndex = 4;
            this.materialTextBox23.TabStop = false;
            this.materialTextBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox23.TrailingIcon = null;
            this.materialTextBox23.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(543, 19);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(75, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "ProductID:";
            // 
            // materialTextBox22
            // 
            this.materialTextBox22.AnimateReadOnly = false;
            this.materialTextBox22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox22.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox22.Depth = 0;
            this.materialTextBox22.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox22.HideSelection = true;
            this.materialTextBox22.LeadingIcon = null;
            this.materialTextBox22.Location = new System.Drawing.Point(624, 6);
            this.materialTextBox22.MaxLength = 32767;
            this.materialTextBox22.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox22.Name = "materialTextBox22";
            this.materialTextBox22.PasswordChar = '\0';
            this.materialTextBox22.PrefixSuffixText = null;
            this.materialTextBox22.ReadOnly = false;
            this.materialTextBox22.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox22.SelectedText = "";
            this.materialTextBox22.SelectionLength = 0;
            this.materialTextBox22.SelectionStart = 0;
            this.materialTextBox22.ShortcutsEnabled = true;
            this.materialTextBox22.Size = new System.Drawing.Size(82, 48);
            this.materialTextBox22.TabIndex = 2;
            this.materialTextBox22.TabStop = false;
            this.materialTextBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox22.TrailingIcon = null;
            this.materialTextBox22.UseSystemPasswordChar = false;
            // 
            // dataGridViewSupplies
            // 
            this.dataGridViewSupplies.AllowUserToAddRows = false;
            this.dataGridViewSupplies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSupplies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnId,
            this.ColumnProductId,
            this.columnDate,
            this.columnCount,
            this.ColumnApplyChange});
            this.dataGridViewSupplies.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewSupplies.Name = "dataGridViewSupplies";
            this.dataGridViewSupplies.RowTemplate.Height = 25;
            this.dataGridViewSupplies.Size = new System.Drawing.Size(534, 454);
            this.dataGridViewSupplies.TabIndex = 0;
            this.dataGridViewSupplies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSupplies_CellContentClick);
            // 
            // columnId
            // 
            this.columnId.HeaderText = "id";
            this.columnId.Name = "columnId";
            // 
            // ColumnProductId
            // 
            this.ColumnProductId.HeaderText = "ProductId";
            this.ColumnProductId.Name = "ColumnProductId";
            // 
            // columnDate
            // 
            this.columnDate.HeaderText = "Date";
            this.columnDate.Name = "columnDate";
            // 
            // columnCount
            // 
            this.columnCount.HeaderText = "Count";
            this.columnCount.Name = "columnCount";
            // 
            // ColumnApplyChange
            // 
            this.ColumnApplyChange.HeaderText = "Apply";
            this.ColumnApplyChange.Name = "ColumnApplyChange";
            this.ColumnApplyChange.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnApplyChange.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnApplyChange.Text = "Apply";
            // 
            // tabPageManufacturers
            // 
            this.tabPageManufacturers.Location = new System.Drawing.Point(4, 24);
            this.tabPageManufacturers.Name = "tabPageManufacturers";
            this.tabPageManufacturers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageManufacturers.Size = new System.Drawing.Size(954, 457);
            this.tabPageManufacturers.TabIndex = 1;
            this.tabPageManufacturers.Text = "Manufacturers";
            this.tabPageManufacturers.UseVisualStyleBackColor = true;
            // 
            // tabPageCategories
            // 
            this.tabPageCategories.Location = new System.Drawing.Point(4, 24);
            this.tabPageCategories.Name = "tabPageCategories";
            this.tabPageCategories.Size = new System.Drawing.Size(954, 457);
            this.tabPageCategories.TabIndex = 2;
            this.tabPageCategories.Text = "Categories";
            this.tabPageCategories.UseVisualStyleBackColor = true;
            // 
            // tabPageUsers
            // 
            this.tabPageUsers.Location = new System.Drawing.Point(4, 24);
            this.tabPageUsers.Name = "tabPageUsers";
            this.tabPageUsers.Size = new System.Drawing.Size(954, 457);
            this.tabPageUsers.TabIndex = 3;
            this.tabPageUsers.Text = "Users";
            this.tabPageUsers.UseVisualStyleBackColor = true;
            // 
            // tabPageProduct
            // 
            this.tabPageProduct.Location = new System.Drawing.Point(4, 24);
            this.tabPageProduct.Name = "tabPageProduct";
            this.tabPageProduct.Size = new System.Drawing.Size(954, 457);
            this.tabPageProduct.TabIndex = 4;
            this.tabPageProduct.Text = "AddProducts";
            this.tabPageProduct.UseVisualStyleBackColor = true;
            // 
            // dataImplBindingSource
            // 
            this.dataImplBindingSource.DataSource = typeof(Client.Data.Service.Data_Impl);
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(991, 598);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerTabControl = this.materialTabControl1;
            this.DrawerUseColors = true;
            this.Name = "Shop";
            this.Load += new System.EventHandler(this.FormUser_Load);
            this.tabPageBasket.ResumeLayout(false);
            this.tabPageBasket.PerformLayout();
            this.tabPageProducts.ResumeLayout(false);
            this.tabPageProducts.PerformLayout();
            this.materialTabControl1.ResumeLayout(false);
            this.tabPageOrders.ResumeLayout(false);
            this.tabPageAdmin.ResumeLayout(false);
            this.tabControlAdmin.ResumeLayout(false);
            this.tabPageAddSupply.ResumeLayout(false);
            this.tabPageAddSupply.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataImplBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TabPage tabPageBasket;
        private TabPage tabPageProducts;
        private TabPage tabPageAccount;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private FlowLayoutPanel flowLayoutPanel1;
        private ITEM item1;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private ColumnHeader columnHeaderName;
        private ColumnHeader columnHeaderPrice;
        private MaterialSkin.Controls.MaterialLabel materialLabelTotal;
        private ColumnHeader columnHeaderCount;
        private MaterialSkin.Controls.MaterialLabel materialLabelTotalPrice;
        private TabPage tabPageOrders;
        private MaterialSkin.Controls.MaterialButton materialButtonChekout;
        private MaterialSkin.Controls.MaterialScrollBar materialScrollBar1;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
        private FlowLayoutPanel flowLayoutPanel2;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton2;
        private TabPage tabPageAdmin;
        private TabControl tabControlAdmin;
        private TabPage tabPageAddSupply;
        private TabPage tabPageManufacturers;
        private DataGridView dataGridViewSupplies;
        private DataGridViewButtonColumn ColumnApply;
        private TabPage tabPageCategories;
        private TabPage tabPageUsers;
        private TabPage tabPageProduct;
        private BindingSource dataImplBindingSource;
        private DataGridViewTextBoxColumn columnId;
        private DataGridViewTextBoxColumn ColumnProductId;
        private DataGridViewTextBoxColumn columnDate;
        private DataGridViewTextBoxColumn columnCount;
        private DataGridViewButtonColumn ColumnApplyChange;
        private MaterialSkin.Controls.MaterialButton materialButtonAddSupply;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox24;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox23;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox22;
    }
}