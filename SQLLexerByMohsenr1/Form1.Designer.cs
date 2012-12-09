namespace SQLLexerByMohsenr1
{
    partial class Form1
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblMessages = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnCheckSyntax = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.rtMain = new System.Windows.Forms.RichTextBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.rtResult = new System.Windows.Forms.RichTextBox();
            this.dtgResualts = new System.Windows.Forms.DataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCharacter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLentgh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResualts)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMessages});
            this.statusStrip1.Location = new System.Drawing.Point(0, 578);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(1066, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblMessages
            // 
            this.lblMessages.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblMessages.Name = "lblMessages";
            this.lblMessages.Size = new System.Drawing.Size(146, 17);
            this.lblMessages.Text = "کد اس کیو ال را وارد کنید...";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnCheckSyntax);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1066, 578);
            this.splitContainer1.SplitterDistance = 46;
            this.splitContainer1.TabIndex = 3;
            this.splitContainer1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.splitContainer1_KeyDown);
            // 
            // btnCheckSyntax
            // 
            this.btnCheckSyntax.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnCheckSyntax.Location = new System.Drawing.Point(12, 12);
            this.btnCheckSyntax.Name = "btnCheckSyntax";
            this.btnCheckSyntax.Size = new System.Drawing.Size(153, 26);
            this.btnCheckSyntax.TabIndex = 9;
            this.btnCheckSyntax.Text = "چک کن";
            this.btnCheckSyntax.UseVisualStyleBackColor = true;
            this.btnCheckSyntax.Click += new System.EventHandler(this.btnCheckSyntax_Click);
            this.btnCheckSyntax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtMain_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(658, 14);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(396, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "کد SQL خود را وارد کنید. برای راهنمایی بیشتر F1 را بزنید.";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.rtMain);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(1066, 528);
            this.splitContainer2.SplitterDistance = 355;
            this.splitContainer2.TabIndex = 0;
            // 
            // rtMain
            // 
            this.rtMain.AcceptsTab = true;
            this.rtMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtMain.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtMain.Location = new System.Drawing.Point(0, 0);
            this.rtMain.Name = "rtMain";
            this.rtMain.Size = new System.Drawing.Size(355, 528);
            this.rtMain.TabIndex = 11;
            this.rtMain.Text = "";
            this.rtMain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtMain_KeyDown);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.rtResult);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dtgResualts);
            this.splitContainer3.Size = new System.Drawing.Size(707, 528);
            this.splitContainer3.SplitterDistance = 235;
            this.splitContainer3.TabIndex = 0;
            // 
            // rtResult
            // 
            this.rtResult.AcceptsTab = true;
            this.rtResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtResult.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtResult.Location = new System.Drawing.Point(0, 0);
            this.rtResult.Name = "rtResult";
            this.rtResult.ReadOnly = true;
            this.rtResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtResult.Size = new System.Drawing.Size(707, 235);
            this.rtResult.TabIndex = 14;
            this.rtResult.Text = "";
            this.rtResult.WordWrap = false;
            this.rtResult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtMain_KeyDown);
            // 
            // dtgResualts
            // 
            this.dtgResualts.AllowUserToAddRows = false;
            this.dtgResualts.AllowUserToDeleteRows = false;
            this.dtgResualts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgResualts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dtgResualts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgResualts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmType,
            this.clmValue,
            this.clmLine,
            this.clmCharacter,
            this.clmIndex,
            this.clmLentgh});
            this.dtgResualts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgResualts.Location = new System.Drawing.Point(0, 0);
            this.dtgResualts.Name = "dtgResualts";
            this.dtgResualts.Size = new System.Drawing.Size(707, 289);
            this.dtgResualts.TabIndex = 14;
            this.dtgResualts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtMain_KeyDown);
            // 
            // clmID
            // 
            this.clmID.DataPropertyName = "ID";
            this.clmID.HeaderText = "ردیف";
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            // 
            // clmType
            // 
            this.clmType.DataPropertyName = "Type";
            this.clmType.HeaderText = "نوع";
            this.clmType.Name = "clmType";
            this.clmType.ReadOnly = true;
            // 
            // clmValue
            // 
            this.clmValue.DataPropertyName = "Value";
            this.clmValue.HeaderText = "مقدار";
            this.clmValue.Name = "clmValue";
            this.clmValue.ReadOnly = true;
            // 
            // clmLine
            // 
            this.clmLine.DataPropertyName = "Line";
            this.clmLine.HeaderText = "خط";
            this.clmLine.Name = "clmLine";
            this.clmLine.ReadOnly = true;
            // 
            // clmCharacter
            // 
            this.clmCharacter.DataPropertyName = "Character";
            this.clmCharacter.HeaderText = "کاراکتر";
            this.clmCharacter.Name = "clmCharacter";
            this.clmCharacter.ReadOnly = true;
            // 
            // clmIndex
            // 
            this.clmIndex.DataPropertyName = "Index";
            this.clmIndex.HeaderText = "ایدنکس";
            this.clmIndex.Name = "clmIndex";
            this.clmIndex.ReadOnly = true;
            // 
            // clmLentgh
            // 
            this.clmLentgh.DataPropertyName = "Lentgh";
            this.clmLentgh.HeaderText = "طول";
            this.clmLentgh.Name = "clmLentgh";
            this.clmLentgh.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 600);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL Syntax Checker by Mohsen Rabieai ... JPCS.ir";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgResualts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblMessages;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnCheckSyntax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RichTextBox rtMain;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.RichTextBox rtResult;
        private System.Windows.Forms.DataGridView dtgResualts;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCharacter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLentgh;
    }
}

