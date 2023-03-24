namespace StandardcodesCsharp
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label7 = new Label();
            tbWertelisteBis = new TextBox();
            tbWertelisteVon = new TextBox();
            tbWertelisteAnzahl = new TextBox();
            label6 = new Label();
            label5 = new Label();
            btPerform = new Button();
            btClear = new Button();
            btAutoFill = new Button();
            tbValuelist = new TextBox();
            label4 = new Label();
            label3 = new Label();
            tbSearchValue = new TextBox();
            cbSearchAlgo = new ComboBox();
            cbSortAlgo = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            label8 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = SystemColors.ControlLightLight;
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(tbWertelisteBis);
            groupBox1.Controls.Add(tbWertelisteVon);
            groupBox1.Controls.Add(tbWertelisteAnzahl);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btPerform);
            groupBox1.Controls.Add(btClear);
            groupBox1.Controls.Add(btAutoFill);
            groupBox1.Controls.Add(tbValuelist);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbSearchValue);
            groupBox1.Controls.Add(cbSearchAlgo);
            groupBox1.Controls.Add(cbSortAlgo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(798, 285);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Settings";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 219);
            label7.Name = "label7";
            label7.Size = new Size(77, 15);
            label7.TabIndex = 16;
            label7.Text = "Werteliste Bis";
            // 
            // tbWertelisteBis
            // 
            tbWertelisteBis.Location = new Point(156, 216);
            tbWertelisteBis.Name = "tbWertelisteBis";
            tbWertelisteBis.Size = new Size(186, 23);
            tbWertelisteBis.TabIndex = 15;
            // 
            // tbWertelisteVon
            // 
            tbWertelisteVon.Location = new Point(156, 187);
            tbWertelisteVon.Name = "tbWertelisteVon";
            tbWertelisteVon.Size = new Size(186, 23);
            tbWertelisteVon.TabIndex = 14;
            // 
            // tbWertelisteAnzahl
            // 
            tbWertelisteAnzahl.Location = new Point(156, 158);
            tbWertelisteAnzahl.Name = "tbWertelisteAnzahl";
            tbWertelisteAnzahl.Size = new Size(186, 23);
            tbWertelisteAnzahl.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 190);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 12;
            label6.Text = "Werteliste Von";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 161);
            label5.Name = "label5";
            label5.Size = new Size(144, 15);
            label5.TabIndex = 11;
            label5.Text = "Werteliste Anzahl Einträge";
            // 
            // btPerform
            // 
            btPerform.Location = new Point(6, 120);
            btPerform.Name = "btPerform";
            btPerform.Size = new Size(165, 23);
            btPerform.TabIndex = 10;
            btPerform.Text = "Ausführen";
            btPerform.UseVisualStyleBackColor = true;
            btPerform.Click += btPerform_Click;
            // 
            // btClear
            // 
            btClear.Location = new Point(177, 120);
            btClear.Name = "btClear";
            btClear.Size = new Size(165, 23);
            btClear.TabIndex = 9;
            btClear.Text = "Leeren";
            btClear.UseVisualStyleBackColor = true;
            btClear.Click += btClear_Click;
            // 
            // btAutoFill
            // 
            btAutoFill.Location = new Point(216, 245);
            btAutoFill.Name = "btAutoFill";
            btAutoFill.Size = new Size(126, 23);
            btAutoFill.TabIndex = 8;
            btAutoFill.Text = "Autofill Werteliste";
            btAutoFill.UseVisualStyleBackColor = true;
            btAutoFill.Click += btAutoFill_Click;
            // 
            // tbValuelist
            // 
            tbValuelist.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbValuelist.Location = new Point(414, 51);
            tbValuelist.Multiline = true;
            tbValuelist.Name = "tbValuelist";
            tbValuelist.Size = new Size(378, 228);
            tbValuelist.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(414, 25);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 6;
            label4.Text = "Werteliste";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 83);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 5;
            label3.Text = "Suchwert";
            // 
            // tbSearchValue
            // 
            tbSearchValue.Location = new Point(111, 80);
            tbSearchValue.Name = "tbSearchValue";
            tbSearchValue.Size = new Size(231, 23);
            tbSearchValue.TabIndex = 4;
            // 
            // cbSearchAlgo
            // 
            cbSearchAlgo.FormattingEnabled = true;
            cbSearchAlgo.Items.AddRange(new object[] { "Linear Search", "Binary Search" });
            cbSearchAlgo.Location = new Point(111, 51);
            cbSearchAlgo.Name = "cbSearchAlgo";
            cbSearchAlgo.Size = new Size(231, 23);
            cbSearchAlgo.TabIndex = 3;
            // 
            // cbSortAlgo
            // 
            cbSortAlgo.FormattingEnabled = true;
            cbSortAlgo.Items.AddRange(new object[] { "Bubble Sort", "optimierter Bubble Sort", "Selection Sort", "Insertion Sort", "Heap Sort" });
            cbSortAlgo.Location = new Point(111, 22);
            cbSortAlgo.Name = "cbSortAlgo";
            cbSortAlgo.Size = new Size(231, 23);
            cbSortAlgo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 54);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 1;
            label2.Text = "Suchmethode";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "Sortiermethode";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(12, 318);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(798, 218);
            textBox1.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 300);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 18;
            label8.Text = "Protokoll:";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 548);
            Controls.Add(label8);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Name = "frmMain";
            Text = "Standard Codes C#";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private TextBox tbSearchValue;
        private ComboBox cbSearchAlgo;
        private ComboBox cbSortAlgo;
        private Label label2;
        private Label label1;
        private TextBox tbValuelist;
        private Button btPerform;
        private Button btClear;
        private Button btAutoFill;
        private Label label7;
        private TextBox tbWertelisteBis;
        private TextBox tbWertelisteVon;
        private TextBox tbWertelisteAnzahl;
        private Label label6;
        private Label label5;
        private TextBox textBox1;
        private Label label8;
    }
}