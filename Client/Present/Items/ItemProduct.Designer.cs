namespace Client.Present.Items
{
    partial class ItemProduct
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
            this.materialButtonAddToCard = new MaterialSkin.Controls.MaterialButton();
            this.materialLabelName = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelPrice = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialButtonAddToCard
            // 
            this.materialButtonAddToCard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonAddToCard.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonAddToCard.Depth = 0;
            this.materialButtonAddToCard.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialButtonAddToCard.HighEmphasis = true;
            this.materialButtonAddToCard.Icon = null;
            this.materialButtonAddToCard.Location = new System.Drawing.Point(0, 215);
            this.materialButtonAddToCard.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonAddToCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonAddToCard.Name = "materialButtonAddToCard";
            this.materialButtonAddToCard.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonAddToCard.Size = new System.Drawing.Size(201, 36);
            this.materialButtonAddToCard.TabIndex = 0;
            this.materialButtonAddToCard.Text = "AddToCard";
            this.materialButtonAddToCard.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonAddToCard.UseAccentColor = false;
            this.materialButtonAddToCard.UseVisualStyleBackColor = true;
            this.materialButtonAddToCard.Click += new System.EventHandler(this.materialButtonAddToCard_Click);
            this.materialButtonAddToCard.MouseEnter += new System.EventHandler(this.materialButtonAddToCard_MouseEnter);
            // 
            // materialLabelName
            // 
            this.materialLabelName.Depth = 0;
            this.materialLabelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabelName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelName.Location = new System.Drawing.Point(0, 0);
            this.materialLabelName.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelName.Name = "materialLabelName";
            this.materialLabelName.Size = new System.Drawing.Size(201, 25);
            this.materialLabelName.TabIndex = 1;
            this.materialLabelName.Text = "Example";
            this.materialLabelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabelPrice
            // 
            this.materialLabelPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabelPrice.AutoSize = true;
            this.materialLabelPrice.Depth = 0;
            this.materialLabelPrice.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelPrice.Location = new System.Drawing.Point(80, 190);
            this.materialLabelPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelPrice.Name = "materialLabelPrice";
            this.materialLabelPrice.Size = new System.Drawing.Size(37, 19);
            this.materialLabelPrice.TabIndex = 2;
            this.materialLabelPrice.Text = "300$";
            this.materialLabelPrice.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Olive;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 10);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.materialLabelName);
            this.panel2.Location = new System.Drawing.Point(0, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 25);
            this.panel2.TabIndex = 5;
            // 
            // ItemProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialLabelPrice);
            this.Controls.Add(this.materialButtonAddToCard);
            this.Name = "ItemProduct";
            this.Size = new System.Drawing.Size(201, 251);
            this.Load += new System.EventHandler(this.ItemProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButtonAddToCard;
        private MaterialSkin.Controls.MaterialLabel materialLabelName;
        private MaterialSkin.Controls.MaterialLabel materialLabelPrice;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
    }
}
