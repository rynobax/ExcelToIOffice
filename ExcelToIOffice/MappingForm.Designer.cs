namespace ExcelToIOffice
{
    partial class MappingForm
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
            this.BigTable = new System.Windows.Forms.TableLayoutPanel();
            this.LabelTable = new System.Windows.Forms.TableLayoutPanel();
            this.excelLabel = new System.Windows.Forms.Label();
            this.databaseLabel = new System.Windows.Forms.Label();
            this.databaseDropdown = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.excelDropdown = new System.Windows.Forms.ComboBox();
            this.addRelationButton = new System.Windows.Forms.Button();
            this.ContinueButton = new System.Windows.Forms.Button();
            this.AddedFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.BigTable.SuspendLayout();
            this.LabelTable.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BigTable
            // 
            this.BigTable.ColumnCount = 1;
            this.BigTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BigTable.Controls.Add(this.LabelTable, 0, 0);
            this.BigTable.Controls.Add(this.ContinueButton, 0, 2);
            this.BigTable.Controls.Add(this.AddedFlowPanel, 0, 1);
            this.BigTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BigTable.Location = new System.Drawing.Point(0, 0);
            this.BigTable.Name = "BigTable";
            this.BigTable.RowCount = 3;
            this.BigTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.BigTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BigTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.BigTable.Size = new System.Drawing.Size(398, 318);
            this.BigTable.TabIndex = 0;
            // 
            // LabelTable
            // 
            this.LabelTable.ColumnCount = 3;
            this.LabelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LabelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LabelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LabelTable.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.LabelTable.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.LabelTable.Controls.Add(this.addRelationButton, 2, 0);
            this.LabelTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelTable.Location = new System.Drawing.Point(3, 3);
            this.LabelTable.Name = "LabelTable";
            this.LabelTable.RowCount = 1;
            this.LabelTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LabelTable.Size = new System.Drawing.Size(392, 100);
            this.LabelTable.TabIndex = 0;
            // 
            // excelLabel
            // 
            this.excelLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.excelLabel.AutoSize = true;
            this.excelLabel.Location = new System.Drawing.Point(3, 0);
            this.excelLabel.Name = "excelLabel";
            this.excelLabel.Size = new System.Drawing.Size(143, 13);
            this.excelLabel.TabIndex = 0;
            this.excelLabel.Text = "Excel Column";
            this.excelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // databaseLabel
            // 
            this.databaseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.databaseLabel.AutoSize = true;
            this.databaseLabel.Location = new System.Drawing.Point(3, 0);
            this.databaseLabel.Name = "databaseLabel";
            this.databaseLabel.Size = new System.Drawing.Size(143, 13);
            this.databaseLabel.TabIndex = 1;
            this.databaseLabel.Text = "Database Field";
            this.databaseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // databaseDropdown
            // 
            this.databaseDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.databaseDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.databaseDropdown.FormattingEnabled = true;
            this.databaseDropdown.Location = new System.Drawing.Point(3, 43);
            this.databaseDropdown.Name = "databaseDropdown";
            this.databaseDropdown.Size = new System.Drawing.Size(143, 21);
            this.databaseDropdown.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.databaseDropdown, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.databaseLabel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(158, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(149, 94);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.excelLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.excelDropdown, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(149, 94);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // excelDropdown
            // 
            this.excelDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.excelDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.excelDropdown.FormattingEnabled = true;
            this.excelDropdown.Location = new System.Drawing.Point(3, 43);
            this.excelDropdown.Name = "excelDropdown";
            this.excelDropdown.Size = new System.Drawing.Size(143, 21);
            this.excelDropdown.TabIndex = 1;
            // 
            // addRelationButton
            // 
            this.addRelationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addRelationButton.Location = new System.Drawing.Point(313, 25);
            this.addRelationButton.Name = "addRelationButton";
            this.addRelationButton.Size = new System.Drawing.Size(76, 50);
            this.addRelationButton.TabIndex = 4;
            this.addRelationButton.Text = "Add Relation";
            this.addRelationButton.UseVisualStyleBackColor = true;
            this.addRelationButton.Click += new System.EventHandler(this.addRelationButton_Click);
            // 
            // ContinueButton
            // 
            this.ContinueButton.Location = new System.Drawing.Point(3, 292);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(75, 23);
            this.ContinueButton.TabIndex = 1;
            this.ContinueButton.Text = "Continue";
            this.ContinueButton.UseVisualStyleBackColor = true;
            this.ContinueButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddedFlowPanel
            // 
            this.AddedFlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddedFlowPanel.AutoScroll = true;
            this.AddedFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.AddedFlowPanel.Location = new System.Drawing.Point(3, 109);
            this.AddedFlowPanel.Name = "AddedFlowPanel";
            this.AddedFlowPanel.Size = new System.Drawing.Size(392, 177);
            this.AddedFlowPanel.TabIndex = 2;
            this.AddedFlowPanel.WrapContents = false;
            // 
            // MappingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 318);
            this.Controls.Add(this.BigTable);
            this.Name = "MappingForm";
            this.Text = "MappingForm";
            this.BigTable.ResumeLayout(false);
            this.LabelTable.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BigTable;
        private System.Windows.Forms.TableLayoutPanel LabelTable;
        private System.Windows.Forms.Label excelLabel;
        private System.Windows.Forms.Label databaseLabel;
        private System.Windows.Forms.ComboBox databaseDropdown;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox excelDropdown;
        private System.Windows.Forms.Button addRelationButton;
        private System.Windows.Forms.Button ContinueButton;
        private System.Windows.Forms.FlowLayoutPanel AddedFlowPanel;
    }
}