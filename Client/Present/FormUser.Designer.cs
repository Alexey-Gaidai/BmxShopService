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
            this.tabPageBasket = new System.Windows.Forms.TabPage();
            this.materialButtonChekout = new MaterialSkin.Controls.MaterialButton();
            this.materialLabelTotalPrice = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelTotal = new MaterialSkin.Controls.MaterialLabel();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeaderName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderPrice = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderCount = new System.Windows.Forms.ColumnHeader();
            this.tabPageProducts = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPageAccount = new System.Windows.Forms.TabPage();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageOrders = new System.Windows.Forms.TabPage();
            this.tabPageBasket.SuspendLayout();
            this.tabPageProducts.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
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
            this.tabPageBasket.Size = new System.Drawing.Size(848, 470);
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
            this.tabPageProducts.Controls.Add(this.flowLayoutPanel1);
            this.tabPageProducts.Location = new System.Drawing.Point(4, 24);
            this.tabPageProducts.Name = "tabPageProducts";
            this.tabPageProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProducts.Size = new System.Drawing.Size(848, 470);
            this.tabPageProducts.TabIndex = 1;
            this.tabPageProducts.Text = "Products";
            this.tabPageProducts.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tabPageAccount
            // 
            this.tabPageAccount.Location = new System.Drawing.Point(4, 24);
            this.tabPageAccount.Name = "tabPageAccount";
            this.tabPageAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAccount.Size = new System.Drawing.Size(848, 470);
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
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.HotTrack = true;
            this.materialTabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialTabControl1.Location = new System.Drawing.Point(6, 67);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(856, 498);
            this.materialTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.materialTabControl1.TabIndex = 2;
            // 
            // tabPageOrders
            // 
            this.tabPageOrders.Location = new System.Drawing.Point(4, 24);
            this.tabPageOrders.Name = "tabPageOrders";
            this.tabPageOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrders.Size = new System.Drawing.Size(848, 470);
            this.tabPageOrders.TabIndex = 3;
            this.tabPageOrders.Text = "Orders";
            this.tabPageOrders.UseVisualStyleBackColor = true;
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(868, 571);
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
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton materialButton1;
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
    }
}