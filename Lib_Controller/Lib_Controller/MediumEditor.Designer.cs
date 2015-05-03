namespace Lib_Controller
{
    public partial class MediumEditor
    {

        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Data = new System.Windows.Forms.GroupBox();
            this.fYear = new System.Windows.Forms.TextBox();
            this.fPublisher = new System.Windows.Forms.TextBox();
            this.fID = new System.Windows.Forms.TextBox();
            this.fAuthor = new System.Windows.Forms.TextBox();
            this.fISBN = new System.Windows.Forms.TextBox();
            this.fName = new System.Windows.Forms.TextBox();
            this.nPublisher = new System.Windows.Forms.Label();
            this.nAuthor = new System.Windows.Forms.Label();
            this.nName = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.nISBN = new System.Windows.Forms.Label();
            this.nYear = new System.Windows.Forms.Label();
            this.nID = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bAddMedium = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.bEditMedium = new System.Windows.Forms.Button();
            this.fBuyDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Data.SuspendLayout();
            this.SuspendLayout();
            // 
            // Data
            // 
            this.Data.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Data.Controls.Add(this.label1);
            this.Data.Controls.Add(this.fBuyDate);
            this.Data.Controls.Add(this.fYear);
            this.Data.Controls.Add(this.fPublisher);
            this.Data.Controls.Add(this.fID);
            this.Data.Controls.Add(this.fAuthor);
            this.Data.Controls.Add(this.fISBN);
            this.Data.Controls.Add(this.fName);
            this.Data.Controls.Add(this.nPublisher);
            this.Data.Controls.Add(this.nAuthor);
            this.Data.Controls.Add(this.nName);
            this.Data.Controls.Add(this.radioButton3);
            this.Data.Controls.Add(this.radioButton2);
            this.Data.Controls.Add(this.radioButton1);
            this.Data.Controls.Add(this.nISBN);
            this.Data.Controls.Add(this.nYear);
            this.Data.Controls.Add(this.nID);
            this.Data.Location = new System.Drawing.Point(12, 0);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(567, 301);
            this.Data.TabIndex = 2;
            this.Data.TabStop = false;
            this.Data.Text = "Data";
            this.Data.Enter += new System.EventHandler(this.Data_Enter);
            // 
            // fYear
            // 
            this.fYear.Location = new System.Drawing.Point(70, 206);
            this.fYear.Name = "fYear";
            this.fYear.Size = new System.Drawing.Size(100, 20);
            this.fYear.TabIndex = 13;
            // 
            // fPublisher
            // 
            this.fPublisher.Location = new System.Drawing.Point(70, 181);
            this.fPublisher.Name = "fPublisher";
            this.fPublisher.Size = new System.Drawing.Size(100, 20);
            this.fPublisher.TabIndex = 12;
            // 
            // fID
            // 
            this.fID.Enabled = false;
            this.fID.Location = new System.Drawing.Point(70, 55);
            this.fID.Name = "fID";
            this.fID.Size = new System.Drawing.Size(100, 20);
            this.fID.TabIndex = 12;
            // 
            // fAuthor
            // 
            this.fAuthor.Location = new System.Drawing.Point(70, 156);
            this.fAuthor.Name = "fAuthor";
            this.fAuthor.Size = new System.Drawing.Size(100, 20);
            this.fAuthor.TabIndex = 11;
            // 
            // fISBN
            // 
            this.fISBN.Location = new System.Drawing.Point(70, 105);
            this.fISBN.Name = "fISBN";
            this.fISBN.Size = new System.Drawing.Size(100, 20);
            this.fISBN.TabIndex = 10;
            // 
            // fName
            // 
            this.fName.Location = new System.Drawing.Point(70, 80);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(100, 20);
            this.fName.TabIndex = 9;
            // 
            // nPublisher
            // 
            this.nPublisher.AutoSize = true;
            this.nPublisher.Location = new System.Drawing.Point(10, 181);
            this.nPublisher.Name = "nPublisher";
            this.nPublisher.Size = new System.Drawing.Size(53, 13);
            this.nPublisher.TabIndex = 8;
            this.nPublisher.Text = "Publisher:";
            // 
            // nAuthor
            // 
            this.nAuthor.AutoSize = true;
            this.nAuthor.Location = new System.Drawing.Point(10, 156);
            this.nAuthor.Name = "nAuthor";
            this.nAuthor.Size = new System.Drawing.Size(41, 13);
            this.nAuthor.TabIndex = 7;
            this.nAuthor.Text = "Author:";
            // 
            // nName
            // 
            this.nName.AutoSize = true;
            this.nName.Location = new System.Drawing.Point(10, 80);
            this.nName.Name = "nName";
            this.nName.Size = new System.Drawing.Size(38, 13);
            this.nName.TabIndex = 6;
            this.nName.Text = "Name:";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(130, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(52, 17);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Audio";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(70, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(48, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "DVD";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(10, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(50, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Book";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // nISBN
            // 
            this.nISBN.AutoSize = true;
            this.nISBN.Location = new System.Drawing.Point(10, 105);
            this.nISBN.Name = "nISBN";
            this.nISBN.Size = new System.Drawing.Size(35, 13);
            this.nISBN.TabIndex = 2;
            this.nISBN.Text = "ISBN:";
            // 
            // nYear
            // 
            this.nYear.AutoSize = true;
            this.nYear.Location = new System.Drawing.Point(10, 206);
            this.nYear.Name = "nYear";
            this.nYear.Size = new System.Drawing.Size(32, 13);
            this.nYear.TabIndex = 1;
            this.nYear.Text = "Year:";
            // 
            // nID
            // 
            this.nID.AutoSize = true;
            this.nID.Location = new System.Drawing.Point(10, 55);
            this.nID.Name = "nID";
            this.nID.Size = new System.Drawing.Size(21, 13);
            this.nID.TabIndex = 0;
            this.nID.Text = "ID:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 307);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(478, 96);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "No Text Found";
            // 
            // bAddMedium
            // 
            this.bAddMedium.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bAddMedium.Location = new System.Drawing.Point(496, 380);
            this.bAddMedium.Name = "bAddMedium";
            this.bAddMedium.Size = new System.Drawing.Size(75, 23);
            this.bAddMedium.TabIndex = 5;
            this.bAddMedium.Text = "Add Medium";
            this.bAddMedium.UseVisualStyleBackColor = true;
            this.bAddMedium.Click += new System.EventHandler(this.bAddMedium_Click);
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancel.AutoEllipsis = true;
            this.bCancel.Location = new System.Drawing.Point(496, 351);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 6;
            this.bCancel.Text = "Close";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bEditMedium
            // 
            this.bEditMedium.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bEditMedium.Location = new System.Drawing.Point(496, 380);
            this.bEditMedium.Name = "bEditMedium";
            this.bEditMedium.Size = new System.Drawing.Size(75, 23);
            this.bEditMedium.TabIndex = 7;
            this.bEditMedium.Text = "Edit Medium";
            this.bEditMedium.UseVisualStyleBackColor = true;
            this.bEditMedium.Click += new System.EventHandler(this.bEditMedium_Click);
            // 
            // fBuyDate
            // 
            this.fBuyDate.Location = new System.Drawing.Point(70, 130);
            this.fBuyDate.Name = "fBuyDate";
            this.fBuyDate.Size = new System.Drawing.Size(100, 20);
            this.fBuyDate.TabIndex = 14;
            this.fBuyDate.Text = "dd.mm.yy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "BuyDate:";
            // 
            // MediumEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 415);
            this.Controls.Add(this.bEditMedium);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bAddMedium);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Data);
            this.MaximizeBox = false;
            this.Name = "MediumEditor";
            this.Text = "AddMedium";
            this.Data.ResumeLayout(false);
            this.Data.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Data;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label nISBN;
        private System.Windows.Forms.Label nYear;
        private System.Windows.Forms.Label nPublisher;
        private System.Windows.Forms.Label nAuthor;
        private System.Windows.Forms.Label nName;
        private System.Windows.Forms.Label nID;
        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button bAddMedium;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.TextBox fName;
        private System.Windows.Forms.TextBox fYear;
        private System.Windows.Forms.TextBox fPublisher;
        private System.Windows.Forms.TextBox fID;
        private System.Windows.Forms.TextBox fAuthor;
        private System.Windows.Forms.TextBox fISBN;
        private System.Windows.Forms.Button bEditMedium;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fBuyDate;
    }
}