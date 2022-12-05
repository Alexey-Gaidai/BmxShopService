namespace Client.Present.Items
{
    partial class ItemOrder
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialLabelOrderNumber = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialLabelOrderStatus = new MaterialSkin.Controls.MaterialLabel();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeaderName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderDescription = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderPrice = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderCount = new System.Windows.Forms.ColumnHeader();
            this.materialLabelTotal = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelDate = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabelOrderNumber
            // 
            this.materialLabelOrderNumber.AutoSize = true;
            this.materialLabelOrderNumber.Depth = 0;
            this.materialLabelOrderNumber.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelOrderNumber.Location = new System.Drawing.Point(3, 14);
            this.materialLabelOrderNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelOrderNumber.Name = "materialLabelOrderNumber";
            this.materialLabelOrderNumber.Size = new System.Drawing.Size(83, 19);
            this.materialLabelOrderNumber.TabIndex = 0;
            this.materialLabelOrderNumber.Text = "Заказ №: 1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Olive;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 11);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.ImageLocation = "C:\\Users\\TheHa\\source\\repos\\BmxShopService\\Client\\Present\\images\\delete.png";
            this.pictureBox1.Location = new System.Drawing.Point(796, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // materialLabelOrderStatus
            // 
            this.materialLabelOrderStatus.AutoSize = true;
            this.materialLabelOrderStatus.Depth = 0;
            this.materialLabelOrderStatus.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelOrderStatus.Location = new System.Drawing.Point(554, 98);
            this.materialLabelOrderStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelOrderStatus.Name = "materialLabelOrderStatus";
            this.materialLabelOrderStatus.Size = new System.Drawing.Size(180, 19);
            this.materialLabelOrderStatus.TabIndex = 4;
            this.materialLabelOrderStatus.Text = "Статус заказа: Оплачен";
            // 
            // materialListView1
            // 
            this.materialListView1.AutoSizeTable = false;
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderDescription,
            this.columnHeaderPrice,
            this.columnHeaderCount});
            this.materialListView1.Depth = 0;
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.Location = new System.Drawing.Point(3, 36);
            this.materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(545, 134);
            this.materialListView1.TabIndex = 5;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 100;
            // 
            // columnHeaderDescription
            // 
            this.columnHeaderDescription.Tag = "";
            this.columnHeaderDescription.Text = "Description";
            this.columnHeaderDescription.Width = 200;
            // 
            // columnHeaderPrice
            // 
            this.columnHeaderPrice.Text = "Price";
            this.columnHeaderPrice.Width = 80;
            // 
            // columnHeaderCount
            // 
            this.columnHeaderCount.Text = "Count";
            this.columnHeaderCount.Width = 80;
            // 
            // materialLabelTotal
            // 
            this.materialLabelTotal.AutoSize = true;
            this.materialLabelTotal.Depth = 0;
            this.materialLabelTotal.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelTotal.Location = new System.Drawing.Point(708, 151);
            this.materialLabelTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelTotal.Name = "materialLabelTotal";
            this.materialLabelTotal.Size = new System.Drawing.Size(82, 19);
            this.materialLabelTotal.TabIndex = 6;
            this.materialLabelTotal.Text = "Total: 500$";
            // 
            // materialLabelDate
            // 
            this.materialLabelDate.AutoSize = true;
            this.materialLabelDate.Depth = 0;
            this.materialLabelDate.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelDate.Location = new System.Drawing.Point(554, 70);
            this.materialLabelDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelDate.Name = "materialLabelDate";
            this.materialLabelDate.Size = new System.Drawing.Size(127, 19);
            this.materialLabelDate.TabIndex = 7;
            this.materialLabelDate.Text = "Дата: 12.12.2022";
            // 
            // ItemOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.materialLabelDate);
            this.Controls.Add(this.materialLabelTotal);
            this.Controls.Add(this.materialListView1);
            this.Controls.Add(this.materialLabelOrderStatus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialLabelOrderNumber);
            this.Name = "ItemOrder";
            this.Size = new System.Drawing.Size(829, 173);
            this.Load += new System.EventHandler(this.ItemOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabelOrderNumber;
        private Panel panel1;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabelOrderStatus;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private ColumnHeader columnHeaderName;
        private ColumnHeader columnHeaderDescription;
        private ColumnHeader columnHeaderPrice;
        private ColumnHeader columnHeaderCount;
        private MaterialSkin.Controls.MaterialLabel materialLabelTotal;
        private MaterialSkin.Controls.MaterialLabel materialLabelDate;
    }
}
