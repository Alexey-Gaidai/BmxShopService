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
            this.materialButtonAddToCard.Location = new System.Drawing.Point(0, 181);
            this.materialButtonAddToCard.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonAddToCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonAddToCard.Name = "materialButtonAddToCard";
            this.materialButtonAddToCard.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonAddToCard.Size = new System.Drawing.Size(188, 36);
            this.materialButtonAddToCard.TabIndex = 0;
            this.materialButtonAddToCard.Text = "AddToCard";
            this.materialButtonAddToCard.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonAddToCard.UseAccentColor = false;
            this.materialButtonAddToCard.UseVisualStyleBackColor = true;
            this.materialButtonAddToCard.Click += new System.EventHandler(this.materialButtonAddToCard_Click);
            // 
            // materialLabelName
            // 
            this.materialLabelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabelName.AutoSize = true;
            this.materialLabelName.Depth = 0;
            this.materialLabelName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelName.Location = new System.Drawing.Point(60, 14);
            this.materialLabelName.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelName.Name = "materialLabelName";
            this.materialLabelName.Size = new System.Drawing.Size(62, 19);
            this.materialLabelName.TabIndex = 1;
            this.materialLabelName.Text = "Example";
            // 
            // materialLabelPrice
            // 
            this.materialLabelPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabelPrice.AutoSize = true;
            this.materialLabelPrice.Depth = 0;
            this.materialLabelPrice.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelPrice.Location = new System.Drawing.Point(123, 156);
            this.materialLabelPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelPrice.Name = "materialLabelPrice";
            this.materialLabelPrice.Size = new System.Drawing.Size(37, 19);
            this.materialLabelPrice.TabIndex = 2;
            this.materialLabelPrice.Text = "300$";
            this.materialLabelPrice.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // ItemProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialLabelPrice);
            this.Controls.Add(this.materialLabelName);
            this.Controls.Add(this.materialButtonAddToCard);
            this.Name = "ItemProduct";
            this.Size = new System.Drawing.Size(188, 217);
            this.Load += new System.EventHandler(this.ItemProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButtonAddToCard;
        private MaterialSkin.Controls.MaterialLabel materialLabelName;
        private MaterialSkin.Controls.MaterialLabel materialLabelPrice;
    }
}
