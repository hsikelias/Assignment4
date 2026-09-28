namespace InventoryMaintenance
{
    partial class frmNewItem
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
            label1 = new Label();
            txtItemNo = new TextBox();
            label2 = new Label();
            txtDescription = new TextBox();
            label3 = new Label();
            txtPrice = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            cboSizeOrManufacturer = new ComboBox();
            lblSizeOrManufacturer = new Label();
            rdoPlant = new RadioButton();
            rdoSupply = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 65);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Item no:";
            // 
            // txtItemNo
            // 
            txtItemNo.Location = new Point(123, 63);
            txtItemNo.Margin = new Padding(2, 3, 2, 3);
            txtItemNo.Name = "txtItemNo";
            txtItemNo.Size = new Size(121, 27);
            txtItemNo.TabIndex = 3;
            txtItemNo.Tag = "Item no";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 104);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 2;
            label2.Text = "Description:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(123, 101);
            txtDescription.Margin = new Padding(2, 3, 2, 3);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(217, 27);
            txtDescription.TabIndex = 5;
            txtDescription.Tag = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 184);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 4;
            label3.Text = "Price:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(123, 181);
            txtPrice.Margin = new Padding(2, 3, 2, 3);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(121, 27);
            txtPrice.TabIndex = 9;
            txtPrice.Tag = "Price";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(123, 239);
            btnSave.Margin = new Padding(2, 3, 2, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(89, 33);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(250, 239);
            btnCancel.Margin = new Padding(2, 3, 2, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(89, 33);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cboSizeOrManufacturer
            // 
            cboSizeOrManufacturer.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSizeOrManufacturer.FormattingEnabled = true;
            cboSizeOrManufacturer.Location = new Point(123, 141);
            cboSizeOrManufacturer.Margin = new Padding(2, 3, 2, 3);
            cboSizeOrManufacturer.Name = "cboSizeOrManufacturer";
            cboSizeOrManufacturer.Size = new Size(147, 28);
            cboSizeOrManufacturer.TabIndex = 7;
            // 
            // lblSizeOrManufacturer
            // 
            lblSizeOrManufacturer.AutoSize = true;
            lblSizeOrManufacturer.Location = new Point(21, 143);
            lblSizeOrManufacturer.Margin = new Padding(2, 0, 2, 0);
            lblSizeOrManufacturer.Name = "lblSizeOrManufacturer";
            lblSizeOrManufacturer.Size = new Size(39, 20);
            lblSizeOrManufacturer.TabIndex = 9;
            lblSizeOrManufacturer.Text = "Size:";
            // 
            // rdoPlant
            // 
            rdoPlant.AutoSize = true;
            rdoPlant.Checked = true;
            rdoPlant.Location = new Point(123, 19);
            rdoPlant.Margin = new Padding(2, 3, 2, 3);
            rdoPlant.Name = "rdoPlant";
            rdoPlant.Size = new Size(63, 24);
            rdoPlant.TabIndex = 0;
            rdoPlant.TabStop = true;
            rdoPlant.Text = "Plant";
            rdoPlant.UseVisualStyleBackColor = true;
            rdoPlant.CheckedChanged += rdoPlant_CheckedChanged;
            // 
            // rdoSupply
            // 
            rdoSupply.AutoSize = true;
            rdoSupply.Location = new Point(219, 19);
            rdoSupply.Margin = new Padding(2, 3, 2, 3);
            rdoSupply.Name = "rdoSupply";
            rdoSupply.Size = new Size(75, 24);
            rdoSupply.TabIndex = 1;
            rdoSupply.TabStop = true;
            rdoSupply.Text = "Supply";
            rdoSupply.UseVisualStyleBackColor = true;
            // 
            // frmNewItem
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(362, 289);
            ControlBox = false;
            Controls.Add(rdoSupply);
            Controls.Add(rdoPlant);
            Controls.Add(lblSizeOrManufacturer);
            Controls.Add(cboSizeOrManufacturer);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtPrice);
            Controls.Add(label3);
            Controls.Add(txtDescription);
            Controls.Add(label2);
            Controls.Add(txtItemNo);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2, 3, 2, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmNewItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Inventory Item";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboSizeOrManufacturer;
        private System.Windows.Forms.Label lblSizeOrManufacturer;
        private System.Windows.Forms.RadioButton rdoPlant;
        private System.Windows.Forms.RadioButton rdoSupply;
    }
}