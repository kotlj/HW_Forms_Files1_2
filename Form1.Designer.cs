namespace HW_Forms_Files1
{
    partial class Form1
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
            textBoxFirstName = new TextBox();
            textBoxSecondName = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPhone = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            listBox1 = new ListBox();
            buttonAdd = new Button();
            buttonRemove = new Button();
            buttonRedact = new Button();
            buttonToTxT = new Button();
            buttonToXML = new Button();
            SuspendLayout();
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(87, 31);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(125, 27);
            textBoxFirstName.TabIndex = 0;
            // 
            // textBoxSecondName
            // 
            textBoxSecondName.Location = new Point(87, 86);
            textBoxSecondName.Name = "textBoxSecondName";
            textBoxSecondName.Size = new Size(125, 27);
            textBoxSecondName.TabIndex = 1;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(87, 147);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(125, 27);
            textBoxEmail.TabIndex = 2;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(87, 211);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(125, 27);
            textBoxPhone.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 38);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 4;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 93);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 5;
            label2.Text = "SurName:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 154);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 6;
            label3.Text = "EMail:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 218);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 7;
            label4.Text = "Phone:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(303, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(485, 424);
            listBox1.TabIndex = 8;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(0, 288);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(88, 30);
            buttonAdd.TabIndex = 9;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(0, 324);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(88, 30);
            buttonRemove.TabIndex = 10;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonRedact
            // 
            buttonRedact.Location = new Point(0, 360);
            buttonRedact.Name = "buttonRedact";
            buttonRedact.Size = new Size(88, 30);
            buttonRedact.TabIndex = 11;
            buttonRedact.Text = "Redact";
            buttonRedact.UseVisualStyleBackColor = true;
            buttonRedact.Click += buttonRedact_Click;
            // 
            // buttonToTxT
            // 
            buttonToTxT.Location = new Point(103, 288);
            buttonToTxT.Name = "buttonToTxT";
            buttonToTxT.Size = new Size(94, 30);
            buttonToTxT.TabIndex = 12;
            buttonToTxT.Text = "Save to txt";
            buttonToTxT.UseVisualStyleBackColor = true;
            buttonToTxT.Click += buttonToTxT_Click;
            // 
            // buttonToXML
            // 
            buttonToXML.Location = new Point(203, 288);
            buttonToXML.Name = "buttonToXML";
            buttonToXML.Size = new Size(94, 30);
            buttonToXML.TabIndex = 13;
            buttonToXML.Text = "Save to xml";
            buttonToXML.UseVisualStyleBackColor = true;
            buttonToXML.Click += buttonToXML_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonToXML);
            Controls.Add(buttonToTxT);
            Controls.Add(buttonRedact);
            Controls.Add(buttonRemove);
            Controls.Add(buttonAdd);
            Controls.Add(listBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxSecondName);
            Controls.Add(textBoxFirstName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFirstName;
        private TextBox textBoxSecondName;
        private TextBox textBoxEmail;
        private TextBox textBoxPhone;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox listBox1;
        private Button buttonAdd;
        private Button buttonRemove;
        private Button buttonRedact;
        private Button buttonToTxT;
        private Button buttonToXML;
    }
}