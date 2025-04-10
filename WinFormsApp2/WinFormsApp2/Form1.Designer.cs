namespace WinFormsApp2
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
            groupBox1 = new GroupBox();
            txtBronzeMedals = new TextBox();
            txtSilverMedals = new TextBox();
            txtGoldMedals = new TextBox();
            txtAthletes = new TextBox();
            txtCountry = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            lblResult = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtBronzeMedals);
            groupBox1.Controls.Add(txtSilverMedals);
            groupBox1.Controls.Add(txtGoldMedals);
            groupBox1.Controls.Add(txtAthletes);
            groupBox1.Controls.Add(txtCountry);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(521, 198);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // txtBronzeMedals
            // 
            txtBronzeMedals.Location = new Point(233, 163);
            txtBronzeMedals.Name = "txtBronzeMedals";
            txtBronzeMedals.Size = new Size(223, 27);
            txtBronzeMedals.TabIndex = 10;
            // 
            // txtSilverMedals
            // 
            txtSilverMedals.Location = new Point(249, 130);
            txtSilverMedals.Name = "txtSilverMedals";
            txtSilverMedals.Size = new Size(223, 27);
            txtSilverMedals.TabIndex = 9;
            // 
            // txtGoldMedals
            // 
            txtGoldMedals.Location = new Point(212, 97);
            txtGoldMedals.Name = "txtGoldMedals";
            txtGoldMedals.Size = new Size(223, 27);
            txtGoldMedals.TabIndex = 8;
            // 
            // txtAthletes
            // 
            txtAthletes.Location = new Point(183, 64);
            txtAthletes.Name = "txtAthletes";
            txtAthletes.Size = new Size(218, 27);
            txtAthletes.TabIndex = 7;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(81, 33);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(223, 27);
            txtCountry.TabIndex = 6;
            txtCountry.TextChanged += textBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 98);
            label6.Name = "label6";
            label6.Size = new Size(191, 20);
            label6.TabIndex = 5;
            label6.Text = "Кол - во золотых медалей";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 159);
            label5.Name = "label5";
            label5.Size = new Size(212, 20);
            label5.TabIndex = 4;
            label5.Text = "Кол - во бронзовых медалей";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 129);
            label4.Name = "label4";
            label4.Size = new Size(228, 20);
            label4.TabIndex = 3;
            label4.Text = "Кол - во серебрянных медалей";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 98);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 67);
            label2.Name = "label2";
            label2.Size = new Size(162, 20);
            label2.TabIndex = 1;
            label2.Text = "Кол - во спортсменов";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 36);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Страна";
            // 
            // button1
            // 
            button1.Location = new Point(12, 216);
            button1.Name = "button1";
            button1.Size = new Size(521, 29);
            button1.TabIndex = 6;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblResult
            // 
            lblResult.Location = new Point(539, 12);
            lblResult.Multiline = true;
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(314, 233);
            lblResult.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 258);
            Controls.Add(lblResult);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtGoldMedals;
        private TextBox txtAthletes;
        private TextBox txtCountry;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private TextBox txtBronzeMedals;
        private TextBox txtSilverMedals;
        private TextBox lblResult;
    }
}
