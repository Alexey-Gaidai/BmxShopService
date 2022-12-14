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
            this.materialTextBoxFindProducts = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialFloatingActionButton1 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPageAccount = new System.Windows.Forms.TabPage();
            this.tbAccountImage = new MaterialSkin.Controls.MaterialTextBox2();
            this.labelAccountImg = new MaterialSkin.Controls.MaterialLabel();
            this.labelAccountImage = new MaterialSkin.Controls.MaterialLabel();
            this.pbAccount = new System.Windows.Forms.PictureBox();
            this.btAccountSave = new MaterialSkin.Controls.MaterialButton();
            this.btAccountEdit = new MaterialSkin.Controls.MaterialButton();
            this.mtbAccountAddress = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.labelAccountAddress = new MaterialSkin.Controls.MaterialLabel();
            this.tbAccountEmail = new MaterialSkin.Controls.MaterialTextBox2();
            this.labelAccountEmail = new MaterialSkin.Controls.MaterialLabel();
            this.tbAccountPhone = new MaterialSkin.Controls.MaterialTextBox2();
            this.labelAccountPhone = new MaterialSkin.Controls.MaterialLabel();
            this.tbAccountLastname = new MaterialSkin.Controls.MaterialTextBox2();
            this.labelAccountLastname = new MaterialSkin.Controls.MaterialLabel();
            this.tbAccountName = new MaterialSkin.Controls.MaterialTextBox2();
            this.labelAccountName = new MaterialSkin.Controls.MaterialLabel();
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
            this.tabPageBasket.SuspendLayout();
            this.tabPageProducts.SuspendLayout();
            this.tabPageAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAccount)).BeginInit();
            this.materialTabControl1.SuspendLayout();
            this.tabPageOrders.SuspendLayout();
            this.tabPageAdmin.SuspendLayout();
            this.tabControlAdmin.SuspendLayout();
            this.tabPageAddSupply.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplies)).BeginInit();
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
            this.materialButtonChekout.Location = new System.Drawing.Point(876, 455);
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
            this.materialLabelTotal.Location = new System.Drawing.Point(389, 6);
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
            this.materialListView1.Size = new System.Drawing.Size(367, 409);
            this.materialListView1.TabIndex = 0;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 150;
            // 
            // columnHeaderPrice
            // 
            this.columnHeaderPrice.Text = "Price";
            this.columnHeaderPrice.Width = 100;
            // 
            // columnHeaderCount
            // 
            this.columnHeaderCount.Text = "Count";
            this.columnHeaderCount.Width = 100;
            // 
            // tabPageProducts
            // 
            this.tabPageProducts.Controls.Add(this.materialLabel1);
            this.tabPageProducts.Controls.Add(this.materialTextBoxFindProducts);
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
            // materialTextBoxFindProducts
            // 
            this.materialTextBoxFindProducts.AnimateReadOnly = false;
            this.materialTextBoxFindProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxFindProducts.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxFindProducts.Depth = 0;
            this.materialTextBoxFindProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxFindProducts.HideSelection = true;
            this.materialTextBoxFindProducts.LeadingIcon = null;
            this.materialTextBoxFindProducts.Location = new System.Drawing.Point(48, 14);
            this.materialTextBoxFindProducts.MaxLength = 32767;
            this.materialTextBoxFindProducts.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxFindProducts.Name = "materialTextBoxFindProducts";
            this.materialTextBoxFindProducts.PasswordChar = '\0';
            this.materialTextBoxFindProducts.PrefixSuffixText = null;
            this.materialTextBoxFindProducts.ReadOnly = false;
            this.materialTextBoxFindProducts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxFindProducts.SelectedText = "";
            this.materialTextBoxFindProducts.SelectionLength = 0;
            this.materialTextBoxFindProducts.SelectionStart = 0;
            this.materialTextBoxFindProducts.ShortcutsEnabled = true;
            this.materialTextBoxFindProducts.Size = new System.Drawing.Size(250, 48);
            this.materialTextBoxFindProducts.TabIndex = 3;
            this.materialTextBoxFindProducts.TabStop = false;
            this.materialTextBoxFindProducts.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxFindProducts.TrailingIcon = null;
            this.materialTextBoxFindProducts.UseSystemPasswordChar = false;
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
            this.tabPageAccount.Controls.Add(this.tbAccountImage);
            this.tabPageAccount.Controls.Add(this.labelAccountImg);
            this.tabPageAccount.Controls.Add(this.labelAccountImage);
            this.tabPageAccount.Controls.Add(this.pbAccount);
            this.tabPageAccount.Controls.Add(this.btAccountSave);
            this.tabPageAccount.Controls.Add(this.btAccountEdit);
            this.tabPageAccount.Controls.Add(this.mtbAccountAddress);
            this.tabPageAccount.Controls.Add(this.labelAccountAddress);
            this.tabPageAccount.Controls.Add(this.tbAccountEmail);
            this.tabPageAccount.Controls.Add(this.labelAccountEmail);
            this.tabPageAccount.Controls.Add(this.tbAccountPhone);
            this.tabPageAccount.Controls.Add(this.labelAccountPhone);
            this.tabPageAccount.Controls.Add(this.tbAccountLastname);
            this.tabPageAccount.Controls.Add(this.labelAccountLastname);
            this.tabPageAccount.Controls.Add(this.tbAccountName);
            this.tabPageAccount.Controls.Add(this.labelAccountName);
            this.tabPageAccount.Location = new System.Drawing.Point(4, 24);
            this.tabPageAccount.Name = "tabPageAccount";
            this.tabPageAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAccount.Size = new System.Drawing.Size(971, 497);
            this.tabPageAccount.TabIndex = 0;
            this.tabPageAccount.Text = "Account";
            this.tabPageAccount.UseVisualStyleBackColor = true;
            // 
            // tbAccountImage
            // 
            this.tbAccountImage.AnimateReadOnly = false;
            this.tbAccountImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbAccountImage.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbAccountImage.Depth = 0;
            this.tbAccountImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbAccountImage.HideSelection = true;
            this.tbAccountImage.LeadingIcon = null;
            this.tbAccountImage.Location = new System.Drawing.Point(8, 446);
            this.tbAccountImage.MaxLength = 32767;
            this.tbAccountImage.MouseState = MaterialSkin.MouseState.OUT;
            this.tbAccountImage.Name = "tbAccountImage";
            this.tbAccountImage.PasswordChar = '\0';
            this.tbAccountImage.PrefixSuffixText = null;
            this.tbAccountImage.ReadOnly = true;
            this.tbAccountImage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbAccountImage.SelectedText = "";
            this.tbAccountImage.SelectionLength = 0;
            this.tbAccountImage.SelectionStart = 0;
            this.tbAccountImage.ShortcutsEnabled = true;
            this.tbAccountImage.Size = new System.Drawing.Size(504, 48);
            this.tbAccountImage.TabIndex = 15;
            this.tbAccountImage.TabStop = false;
            this.tbAccountImage.Text = "Lorem ";
            this.tbAccountImage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbAccountImage.TrailingIcon = null;
            this.tbAccountImage.UseSystemPasswordChar = false;
            // 
            // labelAccountImg
            // 
            this.labelAccountImg.AutoSize = true;
            this.labelAccountImg.Depth = 0;
            this.labelAccountImg.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAccountImg.Location = new System.Drawing.Point(8, 421);
            this.labelAccountImg.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAccountImg.Name = "labelAccountImg";
            this.labelAccountImg.Size = new System.Drawing.Size(45, 19);
            this.labelAccountImg.TabIndex = 14;
            this.labelAccountImg.Text = "Email:";
            // 
            // labelAccountImage
            // 
            this.labelAccountImage.AutoSize = true;
            this.labelAccountImage.Depth = 0;
            this.labelAccountImage.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAccountImage.Location = new System.Drawing.Point(586, 12);
            this.labelAccountImage.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAccountImage.Name = "labelAccountImage";
            this.labelAccountImage.Size = new System.Drawing.Size(51, 19);
            this.labelAccountImage.TabIndex = 13;
            this.labelAccountImage.Text = "Avatar:";
            // 
            // pbAccount
            // 
            this.pbAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAccount.Location = new System.Drawing.Point(586, 34);
            this.pbAccount.Name = "pbAccount";
            this.pbAccount.Size = new System.Drawing.Size(336, 364);
            this.pbAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAccount.TabIndex = 12;
            this.pbAccount.TabStop = false;
            // 
            // btAccountSave
            // 
            this.btAccountSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btAccountSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btAccountSave.Depth = 0;
            this.btAccountSave.HighEmphasis = true;
            this.btAccountSave.Icon = null;
            this.btAccountSave.Location = new System.Drawing.Point(793, 446);
            this.btAccountSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btAccountSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btAccountSave.Name = "btAccountSave";
            this.btAccountSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btAccountSave.Size = new System.Drawing.Size(129, 36);
            this.btAccountSave.TabIndex = 11;
            this.btAccountSave.Text = "Save Changes";
            this.btAccountSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btAccountSave.UseAccentColor = false;
            this.btAccountSave.UseVisualStyleBackColor = true;
            this.btAccountSave.Click += new System.EventHandler(this.btAccountSave_Click);
            // 
            // btAccountEdit
            // 
            this.btAccountEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btAccountEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btAccountEdit.Depth = 0;
            this.btAccountEdit.HighEmphasis = true;
            this.btAccountEdit.Icon = null;
            this.btAccountEdit.Location = new System.Drawing.Point(586, 446);
            this.btAccountEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btAccountEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btAccountEdit.Name = "btAccountEdit";
            this.btAccountEdit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btAccountEdit.Size = new System.Drawing.Size(155, 36);
            this.btAccountEdit.TabIndex = 10;
            this.btAccountEdit.Text = "Edit Information";
            this.btAccountEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btAccountEdit.UseAccentColor = false;
            this.btAccountEdit.UseVisualStyleBackColor = true;
            this.btAccountEdit.Click += new System.EventHandler(this.btAccountEdit_Click);
            // 
            // mtbAccountAddress
            // 
            this.mtbAccountAddress.AnimateReadOnly = false;
            this.mtbAccountAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mtbAccountAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mtbAccountAddress.Depth = 0;
            this.mtbAccountAddress.HideSelection = true;
            this.mtbAccountAddress.Location = new System.Drawing.Point(6, 209);
            this.mtbAccountAddress.MaxLength = 32767;
            this.mtbAccountAddress.MouseState = MaterialSkin.MouseState.OUT;
            this.mtbAccountAddress.Name = "mtbAccountAddress";
            this.mtbAccountAddress.PasswordChar = '\0';
            this.mtbAccountAddress.ReadOnly = true;
            this.mtbAccountAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbAccountAddress.SelectedText = "";
            this.mtbAccountAddress.SelectionLength = 0;
            this.mtbAccountAddress.SelectionStart = 0;
            this.mtbAccountAddress.ShortcutsEnabled = true;
            this.mtbAccountAddress.Size = new System.Drawing.Size(506, 124);
            this.mtbAccountAddress.TabIndex = 9;
            this.mtbAccountAddress.TabStop = false;
            this.mtbAccountAddress.Text = "materialMultiLineTextBox21";
            this.mtbAccountAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mtbAccountAddress.UseSystemPasswordChar = false;
            // 
            // labelAccountAddress
            // 
            this.labelAccountAddress.AutoSize = true;
            this.labelAccountAddress.Depth = 0;
            this.labelAccountAddress.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAccountAddress.Location = new System.Drawing.Point(6, 187);
            this.labelAccountAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAccountAddress.Name = "labelAccountAddress";
            this.labelAccountAddress.Size = new System.Drawing.Size(98, 19);
            this.labelAccountAddress.TabIndex = 8;
            this.labelAccountAddress.Text = "Post Address:";
            // 
            // tbAccountEmail
            // 
            this.tbAccountEmail.AnimateReadOnly = false;
            this.tbAccountEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbAccountEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbAccountEmail.Depth = 0;
            this.tbAccountEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbAccountEmail.HideSelection = true;
            this.tbAccountEmail.LeadingIcon = null;
            this.tbAccountEmail.Location = new System.Drawing.Point(8, 370);
            this.tbAccountEmail.MaxLength = 32767;
            this.tbAccountEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.tbAccountEmail.Name = "tbAccountEmail";
            this.tbAccountEmail.PasswordChar = '\0';
            this.tbAccountEmail.PrefixSuffixText = null;
            this.tbAccountEmail.ReadOnly = true;
            this.tbAccountEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbAccountEmail.SelectedText = "";
            this.tbAccountEmail.SelectionLength = 0;
            this.tbAccountEmail.SelectionStart = 0;
            this.tbAccountEmail.ShortcutsEnabled = true;
            this.tbAccountEmail.Size = new System.Drawing.Size(504, 48);
            this.tbAccountEmail.TabIndex = 7;
            this.tbAccountEmail.TabStop = false;
            this.tbAccountEmail.Text = "Lorem ";
            this.tbAccountEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbAccountEmail.TrailingIcon = null;
            this.tbAccountEmail.UseSystemPasswordChar = false;
            // 
            // labelAccountEmail
            // 
            this.labelAccountEmail.AutoSize = true;
            this.labelAccountEmail.Depth = 0;
            this.labelAccountEmail.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAccountEmail.Location = new System.Drawing.Point(8, 345);
            this.labelAccountEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAccountEmail.Name = "labelAccountEmail";
            this.labelAccountEmail.Size = new System.Drawing.Size(45, 19);
            this.labelAccountEmail.TabIndex = 6;
            this.labelAccountEmail.Text = "Email:";
            // 
            // tbAccountPhone
            // 
            this.tbAccountPhone.AnimateReadOnly = false;
            this.tbAccountPhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbAccountPhone.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbAccountPhone.Depth = 0;
            this.tbAccountPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbAccountPhone.HideSelection = true;
            this.tbAccountPhone.LeadingIcon = null;
            this.tbAccountPhone.Location = new System.Drawing.Point(6, 122);
            this.tbAccountPhone.MaxLength = 32767;
            this.tbAccountPhone.MouseState = MaterialSkin.MouseState.OUT;
            this.tbAccountPhone.Name = "tbAccountPhone";
            this.tbAccountPhone.PasswordChar = '\0';
            this.tbAccountPhone.PrefixSuffixText = null;
            this.tbAccountPhone.ReadOnly = true;
            this.tbAccountPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbAccountPhone.SelectedText = "";
            this.tbAccountPhone.SelectionLength = 0;
            this.tbAccountPhone.SelectionStart = 0;
            this.tbAccountPhone.ShortcutsEnabled = true;
            this.tbAccountPhone.Size = new System.Drawing.Size(250, 48);
            this.tbAccountPhone.TabIndex = 5;
            this.tbAccountPhone.TabStop = false;
            this.tbAccountPhone.Text = "Lorem ";
            this.tbAccountPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbAccountPhone.TrailingIcon = null;
            this.tbAccountPhone.UseSystemPasswordChar = false;
            // 
            // labelAccountPhone
            // 
            this.labelAccountPhone.AutoSize = true;
            this.labelAccountPhone.Depth = 0;
            this.labelAccountPhone.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAccountPhone.Location = new System.Drawing.Point(6, 100);
            this.labelAccountPhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAccountPhone.Name = "labelAccountPhone";
            this.labelAccountPhone.Size = new System.Drawing.Size(110, 19);
            this.labelAccountPhone.TabIndex = 4;
            this.labelAccountPhone.Text = "Phone Number:";
            // 
            // tbAccountLastname
            // 
            this.tbAccountLastname.AnimateReadOnly = false;
            this.tbAccountLastname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbAccountLastname.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbAccountLastname.Depth = 0;
            this.tbAccountLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbAccountLastname.HideSelection = true;
            this.tbAccountLastname.LeadingIcon = null;
            this.tbAccountLastname.Location = new System.Drawing.Point(281, 34);
            this.tbAccountLastname.MaxLength = 32767;
            this.tbAccountLastname.MouseState = MaterialSkin.MouseState.OUT;
            this.tbAccountLastname.Name = "tbAccountLastname";
            this.tbAccountLastname.PasswordChar = '\0';
            this.tbAccountLastname.PrefixSuffixText = null;
            this.tbAccountLastname.ReadOnly = true;
            this.tbAccountLastname.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbAccountLastname.SelectedText = "";
            this.tbAccountLastname.SelectionLength = 0;
            this.tbAccountLastname.SelectionStart = 0;
            this.tbAccountLastname.ShortcutsEnabled = true;
            this.tbAccountLastname.Size = new System.Drawing.Size(250, 48);
            this.tbAccountLastname.TabIndex = 3;
            this.tbAccountLastname.TabStop = false;
            this.tbAccountLastname.Text = "Lorem ";
            this.tbAccountLastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbAccountLastname.TrailingIcon = null;
            this.tbAccountLastname.UseSystemPasswordChar = false;
            // 
            // labelAccountLastname
            // 
            this.labelAccountLastname.AutoSize = true;
            this.labelAccountLastname.Depth = 0;
            this.labelAccountLastname.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAccountLastname.Location = new System.Drawing.Point(281, 12);
            this.labelAccountLastname.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAccountLastname.Name = "labelAccountLastname";
            this.labelAccountLastname.Size = new System.Drawing.Size(76, 19);
            this.labelAccountLastname.TabIndex = 2;
            this.labelAccountLastname.Text = "Lastname:";
            // 
            // tbAccountName
            // 
            this.tbAccountName.AnimateReadOnly = false;
            this.tbAccountName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbAccountName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbAccountName.Depth = 0;
            this.tbAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbAccountName.HideSelection = true;
            this.tbAccountName.LeadingIcon = null;
            this.tbAccountName.Location = new System.Drawing.Point(6, 34);
            this.tbAccountName.MaxLength = 32767;
            this.tbAccountName.MouseState = MaterialSkin.MouseState.OUT;
            this.tbAccountName.Name = "tbAccountName";
            this.tbAccountName.PasswordChar = '\0';
            this.tbAccountName.PrefixSuffixText = null;
            this.tbAccountName.ReadOnly = true;
            this.tbAccountName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbAccountName.SelectedText = "";
            this.tbAccountName.SelectionLength = 0;
            this.tbAccountName.SelectionStart = 0;
            this.tbAccountName.ShortcutsEnabled = true;
            this.tbAccountName.Size = new System.Drawing.Size(250, 48);
            this.tbAccountName.TabIndex = 1;
            this.tbAccountName.TabStop = false;
            this.tbAccountName.Text = "Lorem ";
            this.tbAccountName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbAccountName.TrailingIcon = null;
            this.tbAccountName.UseSystemPasswordChar = false;
            // 
            // labelAccountName
            // 
            this.labelAccountName.AutoSize = true;
            this.labelAccountName.Depth = 0;
            this.labelAccountName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAccountName.Location = new System.Drawing.Point(6, 12);
            this.labelAccountName.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAccountName.Name = "labelAccountName";
            this.labelAccountName.Size = new System.Drawing.Size(47, 19);
            this.labelAccountName.TabIndex = 0;
            this.labelAccountName.Text = "Name:";
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
            this.materialFloatingActionButton2.Location = new System.Drawing.Point(890, 420);
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
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 6);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(965, 491);
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
            this.tabPageAccount.ResumeLayout(false);
            this.tabPageAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAccount)).EndInit();
            this.materialTabControl1.ResumeLayout(false);
            this.tabPageOrders.ResumeLayout(false);
            this.tabPageAdmin.ResumeLayout(false);
            this.tabControlAdmin.ResumeLayout(false);
            this.tabPageAddSupply.ResumeLayout(false);
            this.tabPageAddSupply.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplies)).EndInit();
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
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxFindProducts;
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
        private MaterialSkin.Controls.MaterialLabel labelAccountName;
        private MaterialSkin.Controls.MaterialButton btAccountSave;
        private MaterialSkin.Controls.MaterialButton btAccountEdit;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 mtbAccountAddress;
        private MaterialSkin.Controls.MaterialLabel labelAccountAddress;
        private MaterialSkin.Controls.MaterialTextBox2 tbAccountEmail;
        private MaterialSkin.Controls.MaterialLabel labelAccountEmail;
        private MaterialSkin.Controls.MaterialTextBox2 tbAccountPhone;
        private MaterialSkin.Controls.MaterialLabel labelAccountPhone;
        private MaterialSkin.Controls.MaterialTextBox2 tbAccountLastname;
        private MaterialSkin.Controls.MaterialLabel labelAccountLastname;
        private MaterialSkin.Controls.MaterialTextBox2 tbAccountName;
        private MaterialSkin.Controls.MaterialLabel labelAccountImage;
        private PictureBox pbAccount;
        private MaterialSkin.Controls.MaterialTextBox2 tbAccountImage;
        private MaterialSkin.Controls.MaterialLabel labelAccountImg;
    }
}