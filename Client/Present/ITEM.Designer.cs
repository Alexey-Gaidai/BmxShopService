namespace Client.Present
{
    partial class ITEM
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
            this.materialButtonAdd = new MaterialSkin.Controls.MaterialButton();
            this.materialLabelName = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelDesc = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelPrice = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialButtonAdd
            // 
            this.materialButtonAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonAdd.Depth = 0;
            this.materialButtonAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialButtonAdd.HighEmphasis = true;
            this.materialButtonAdd.Icon = null;
            this.materialButtonAdd.Location = new System.Drawing.Point(0, 135);
            this.materialButtonAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonAdd.Name = "materialButtonAdd";
            this.materialButtonAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonAdd.Size = new System.Drawing.Size(175, 36);
            this.materialButtonAdd.TabIndex = 0;
            this.materialButtonAdd.Text = "Add to Basket";
            this.materialButtonAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonAdd.UseAccentColor = false;
            this.materialButtonAdd.UseVisualStyleBackColor = true;
            this.materialButtonAdd.Click += new System.EventHandler(this.materialButtonAdd_Click);
            // 
            // materialLabelName
            // 
            this.materialLabelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabelName.AutoSize = true;
            this.materialLabelName.Depth = 0;
            this.materialLabelName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelName.Location = new System.Drawing.Point(24, 9);
            this.materialLabelName.Margin = new System.Windows.Forms.Padding(0);
            this.materialLabelName.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelName.Name = "materialLabelName";
            this.materialLabelName.Size = new System.Drawing.Size(94, 19);
            this.materialLabelName.TabIndex = 1;
            this.materialLabelName.Text = "Shadow Fork";
            // 
            // materialLabelDesc
            // 
            this.materialLabelDesc.AutoEllipsis = true;
            this.materialLabelDesc.AutoSize = true;
            this.materialLabelDesc.Depth = 0;
            this.materialLabelDesc.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelDesc.Location = new System.Drawing.Point(0, 28);
            this.materialLabelDesc.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelDesc.Name = "materialLabelDesc";
            this.materialLabelDesc.Size = new System.Drawing.Size(183, 19);
            this.materialLabelDesc.TabIndex = 2;
            this.materialLabelDesc.Text = "Low weight bmx forksdsd";
            // 
            // materialLabelPrice
            // 
            this.materialLabelPrice.AutoSize = true;
            this.materialLabelPrice.Depth = 0;
            this.materialLabelPrice.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelPrice.Location = new System.Drawing.Point(3, 110);
            this.materialLabelPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelPrice.Name = "materialLabelPrice";
            this.materialLabelPrice.Size = new System.Drawing.Size(50, 19);
            this.materialLabelPrice.TabIndex = 3;
            this.materialLabelPrice.Text = "14.00$";
            // 
            // ITEM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.materialLabelPrice);
            this.Controls.Add(this.materialLabelDesc);
            this.Controls.Add(this.materialLabelName);
            this.Controls.Add(this.materialButtonAdd);
            this.Name = "ITEM";
            this.Size = new System.Drawing.Size(175, 171);
            this.Load += new System.EventHandler(this.ITEM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButtonAdd;
        private MaterialSkin.Controls.MaterialLabel materialLabelName;
        private MaterialSkin.Controls.MaterialLabel materialLabelDesc;
        private MaterialSkin.Controls.MaterialLabel materialLabelPrice;
    }
}
