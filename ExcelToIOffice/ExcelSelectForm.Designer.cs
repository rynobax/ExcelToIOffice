namespace ExcelToIOffice
{
    partial class ExcelSelectForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FileLabel = new System.Windows.Forms.Label();
            this.SheetLabel = new System.Windows.Forms.Label();
            this.ContinueButton = new System.Windows.Forms.Button();
            this.FileTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.FileText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SheetDropdown = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.FileTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.FileLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SheetLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ContinueButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.FileTableLayout, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.SheetDropdown, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(451, 320);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // FileLabel
            // 
            this.FileLabel.AutoSize = true;
            this.FileLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileLabel.Location = new System.Drawing.Point(3, 0);
            this.FileLabel.Name = "FileLabel";
            this.FileLabel.Size = new System.Drawing.Size(180, 96);
            this.FileLabel.TabIndex = 0;
            this.FileLabel.Text = "Select Excel File:";
            this.FileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FileLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // SheetLabel
            // 
            this.SheetLabel.AutoSize = true;
            this.SheetLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SheetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SheetLabel.Location = new System.Drawing.Point(3, 96);
            this.SheetLabel.Name = "SheetLabel";
            this.SheetLabel.Size = new System.Drawing.Size(180, 96);
            this.SheetLabel.TabIndex = 1;
            this.SheetLabel.Text = "Select Sheet To Use:";
            this.SheetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ContinueButton
            // 
            this.ContinueButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContinueButton.Location = new System.Drawing.Point(216, 222);
            this.ContinueButton.Margin = new System.Windows.Forms.Padding(30);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(205, 68);
            this.ContinueButton.TabIndex = 2;
            this.ContinueButton.Text = "Continue";
            this.ContinueButton.UseVisualStyleBackColor = true;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // FileTableLayout
            // 
            this.FileTableLayout.ColumnCount = 2;
            this.FileTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FileTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FileTableLayout.Controls.Add(this.FileText, 0, 0);
            this.FileTableLayout.Controls.Add(this.button1, 1, 0);
            this.FileTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileTableLayout.Location = new System.Drawing.Point(189, 3);
            this.FileTableLayout.Name = "FileTableLayout";
            this.FileTableLayout.RowCount = 1;
            this.FileTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FileTableLayout.Size = new System.Drawing.Size(259, 90);
            this.FileTableLayout.TabIndex = 3;
            // 
            // FileText
            // 
            this.FileText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FileText.Location = new System.Drawing.Point(3, 35);
            this.FileText.Name = "FileText";
            this.FileText.Size = new System.Drawing.Size(172, 20);
            this.FileText.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(181, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // SheetDropdown
            // 
            this.SheetDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SheetDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SheetDropdown.FormattingEnabled = true;
            this.SheetDropdown.Location = new System.Drawing.Point(189, 133);
            this.SheetDropdown.Name = "SheetDropdown";
            this.SheetDropdown.Size = new System.Drawing.Size(259, 21);
            this.SheetDropdown.TabIndex = 4;
            this.SheetDropdown.SelectedIndexChanged += new System.EventHandler(this.SheetDropdown_SelectedIndexChanged);
            // 
            // ExcelSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 320);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ExcelSelectForm";
            this.Text = "Excel Information";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.FileTableLayout.ResumeLayout(false);
            this.FileTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label FileLabel;
        private System.Windows.Forms.Label SheetLabel;
        private System.Windows.Forms.Button ContinueButton;
        private System.Windows.Forms.TableLayoutPanel FileTableLayout;
        private System.Windows.Forms.TextBox FileText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox SheetDropdown;
    }
}