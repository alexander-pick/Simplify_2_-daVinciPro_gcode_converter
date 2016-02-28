namespace DaVinciConvert
{
    partial class MainWindow
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
            this.convertButton = new System.Windows.Forms.Button();
            this.extTempBox = new System.Windows.Forms.TextBox();
            this.bedTempBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.headerBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.logBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.startTempBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(15, 543);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(469, 41);
            this.convertButton.TabIndex = 0;
            this.convertButton.Text = "Open and convert G-Code";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // extTempBox
            // 
            this.extTempBox.Location = new System.Drawing.Point(126, 34);
            this.extTempBox.Name = "extTempBox";
            this.extTempBox.Size = new System.Drawing.Size(100, 20);
            this.extTempBox.TabIndex = 1;
            this.extTempBox.Text = "200";
            // 
            // bedTempBox
            // 
            this.bedTempBox.Location = new System.Drawing.Point(126, 6);
            this.bedTempBox.Name = "bedTempBox";
            this.bedTempBox.Size = new System.Drawing.Size(100, 20);
            this.bedTempBox.TabIndex = 2;
            this.bedTempBox.Text = "65";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bed Temperature";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Extruder Temprature";
            // 
            // headerBox
            // 
            this.headerBox.Location = new System.Drawing.Point(15, 122);
            this.headerBox.Multiline = true;
            this.headerBox.Name = "headerBox";
            this.headerBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.headerBox.Size = new System.Drawing.Size(469, 303);
            this.headerBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Header Template";
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(15, 431);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(469, 106);
            this.logBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Start Temprature";
            // 
            // startTempBox
            // 
            this.startTempBox.Location = new System.Drawing.Point(126, 63);
            this.startTempBox.Name = "startTempBox";
            this.startTempBox.Size = new System.Drawing.Size(100, 20);
            this.startTempBox.TabIndex = 8;
            this.startTempBox.Text = "200";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 10;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 593);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.startTempBox);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.headerBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bedTempBox);
            this.Controls.Add(this.extTempBox);
            this.Controls.Add(this.convertButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Convert Simplify G-Code for DaVinci Pro - Alexander Pick 2016";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.TextBox extTempBox;
        private System.Windows.Forms.TextBox bedTempBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox headerBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox startTempBox;
        private System.Windows.Forms.Label label5;
    }
}

