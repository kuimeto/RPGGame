namespace RPGGame
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
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_ClassChoice = new System.Windows.Forms.ComboBox();
            this.lbl_Wis = new System.Windows.Forms.Label();
            this.lbl_Int = new System.Windows.Forms.Label();
            this.lbl_Cha = new System.Windows.Forms.Label();
            this.lbl_Dex = new System.Windows.Forms.Label();
            this.lbl_Con = new System.Windows.Forms.Label();
            this.lbl_Str = new System.Windows.Forms.Label();
            this.btn_Roll = new System.Windows.Forms.Button();
            this.btn_Accept = new System.Windows.Forms.Button();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(340, 170);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(148, 47);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(340, 277);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(148, 43);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(24, 22);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(39, 15);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.cb_ClassChoice);
            this.panel1.Controls.Add(this.lbl_Wis);
            this.panel1.Controls.Add(this.lbl_Int);
            this.panel1.Controls.Add(this.lbl_Cha);
            this.panel1.Controls.Add(this.lbl_Dex);
            this.panel1.Controls.Add(this.lbl_Con);
            this.panel1.Controls.Add(this.lbl_Str);
            this.panel1.Controls.Add(this.btn_Roll);
            this.panel1.Controls.Add(this.btn_Accept);
            this.panel1.Controls.Add(this.tb_Name);
            this.panel1.Controls.Add(this.lbl_Name);
            this.panel1.Location = new System.Drawing.Point(33, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 399);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // cb_ClassChoice
            // 
            this.cb_ClassChoice.FormattingEnabled = true;
            this.cb_ClassChoice.Location = new System.Drawing.Point(436, 96);
            this.cb_ClassChoice.Name = "cb_ClassChoice";
            this.cb_ClassChoice.Size = new System.Drawing.Size(135, 23);
            this.cb_ClassChoice.TabIndex = 12;
            this.cb_ClassChoice.Visible = false;
            // 
            // lbl_Wis
            // 
            this.lbl_Wis.AutoSize = true;
            this.lbl_Wis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Wis.Location = new System.Drawing.Point(25, 227);
            this.lbl_Wis.Name = "lbl_Wis";
            this.lbl_Wis.Size = new System.Drawing.Size(51, 15);
            this.lbl_Wis.TabIndex = 11;
            this.lbl_Wis.Text = "Wisdom";
            // 
            // lbl_Int
            // 
            this.lbl_Int.AutoSize = true;
            this.lbl_Int.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Int.Location = new System.Drawing.Point(25, 204);
            this.lbl_Int.Name = "lbl_Int";
            this.lbl_Int.Size = new System.Drawing.Size(68, 15);
            this.lbl_Int.TabIndex = 10;
            this.lbl_Int.Text = "Intelligence";
            // 
            // lbl_Cha
            // 
            this.lbl_Cha.AutoSize = true;
            this.lbl_Cha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Cha.Location = new System.Drawing.Point(25, 246);
            this.lbl_Cha.Name = "lbl_Cha";
            this.lbl_Cha.Size = new System.Drawing.Size(57, 15);
            this.lbl_Cha.TabIndex = 9;
            this.lbl_Cha.Text = "Charisma";
            // 
            // lbl_Dex
            // 
            this.lbl_Dex.AutoSize = true;
            this.lbl_Dex.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Dex.Location = new System.Drawing.Point(25, 155);
            this.lbl_Dex.Name = "lbl_Dex";
            this.lbl_Dex.Size = new System.Drawing.Size(54, 15);
            this.lbl_Dex.TabIndex = 8;
            this.lbl_Dex.Text = "Dexterity";
            // 
            // lbl_Con
            // 
            this.lbl_Con.AutoSize = true;
            this.lbl_Con.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Con.Location = new System.Drawing.Point(24, 180);
            this.lbl_Con.Name = "lbl_Con";
            this.lbl_Con.Size = new System.Drawing.Size(73, 15);
            this.lbl_Con.TabIndex = 7;
            this.lbl_Con.Text = "Constitution";
            // 
            // lbl_Str
            // 
            this.lbl_Str.AutoSize = true;
            this.lbl_Str.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Str.Location = new System.Drawing.Point(24, 129);
            this.lbl_Str.Name = "lbl_Str";
            this.lbl_Str.Size = new System.Drawing.Size(52, 15);
            this.lbl_Str.TabIndex = 6;
            this.lbl_Str.Text = "Stregnth";
            // 
            // btn_Roll
            // 
            this.btn_Roll.Location = new System.Drawing.Point(177, 180);
            this.btn_Roll.Name = "btn_Roll";
            this.btn_Roll.Size = new System.Drawing.Size(75, 23);
            this.btn_Roll.TabIndex = 5;
            this.btn_Roll.Text = "Roll";
            this.btn_Roll.UseVisualStyleBackColor = true;
            this.btn_Roll.Click += new System.EventHandler(this.btn_Roll_Click);
            // 
            // btn_Accept
            // 
            this.btn_Accept.Location = new System.Drawing.Point(209, 22);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new System.Drawing.Size(75, 23);
            this.btn_Accept.TabIndex = 4;
            this.btn_Accept.Text = "Accept";
            this.btn_Accept.UseVisualStyleBackColor = true;
            this.btn_Accept.Click += new System.EventHandler(this.btn_Accept_Click);
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(69, 19);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(100, 23);
            this.tb_Name.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 466);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_Start;
        private Button btn_Exit;
        private Label lbl_Name;
        private Panel panel1;
        private Button btn_Accept;
        private TextBox tb_Name;
        private Label lbl_Wis;
        private Label lbl_Int;
        private Label lbl_Cha;
        private Label lbl_Dex;
        private Label lbl_Con;
        private Label lbl_Str;
        private Button btn_Roll;
        private ComboBox cb_ClassChoice;
    }
}