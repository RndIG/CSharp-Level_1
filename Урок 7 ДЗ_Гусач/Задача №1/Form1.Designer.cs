namespace Задача__1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCommand1 = new System.Windows.Forms.Button();
            this.btnCommand2 = new System.Windows.Forms.Button();
            this.btnCommand3 = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.clicks = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.Label();
            this.clicksHeader = new System.Windows.Forms.Label();
            this.btnCommand4 = new System.Windows.Forms.Button();
            this.btnCommand5 = new System.Windows.Forms.Button();
            this.aimNumber = new System.Windows.Forms.Label();
            this.aimHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCommand1
            // 
            this.btnCommand1.Location = new System.Drawing.Point(615, 68);
            this.btnCommand1.Name = "btnCommand1";
            this.btnCommand1.Size = new System.Drawing.Size(75, 23);
            this.btnCommand1.TabIndex = 0;
            this.btnCommand1.Text = "+1";
            this.btnCommand1.UseVisualStyleBackColor = true;
            this.btnCommand1.Click += new System.EventHandler(this.btnCommand1_Click);
            // 
            // btnCommand2
            // 
            this.btnCommand2.Location = new System.Drawing.Point(615, 133);
            this.btnCommand2.Name = "btnCommand2";
            this.btnCommand2.Size = new System.Drawing.Size(75, 23);
            this.btnCommand2.TabIndex = 1;
            this.btnCommand2.Text = "x2";
            this.btnCommand2.UseVisualStyleBackColor = true;
            this.btnCommand2.Click += new System.EventHandler(this.btnCommand2_Click);
            // 
            // btnCommand3
            // 
            this.btnCommand3.Location = new System.Drawing.Point(615, 197);
            this.btnCommand3.Name = "btnCommand3";
            this.btnCommand3.Size = new System.Drawing.Size(75, 23);
            this.btnCommand3.TabIndex = 2;
            this.btnCommand3.Text = "reset";
            this.btnCommand3.UseVisualStyleBackColor = true;
            this.btnCommand3.Click += new System.EventHandler(this.btnCommand3_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(125, 77);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(13, 13);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "0";
            // 
            // clicks
            // 
            this.clicks.AutoSize = true;
            this.clicks.Location = new System.Drawing.Point(125, 338);
            this.clicks.Name = "clicks";
            this.clicks.Size = new System.Drawing.Size(13, 13);
            this.clicks.TabIndex = 4;
            this.clicks.Text = "0";
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Location = new System.Drawing.Point(56, 78);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(44, 13);
            this.number.TabIndex = 5;
            this.number.Text = "Number";
            // 
            // clicksHeader
            // 
            this.clicksHeader.AutoSize = true;
            this.clicksHeader.Location = new System.Drawing.Point(59, 337);
            this.clicksHeader.Name = "clicksHeader";
            this.clicksHeader.Size = new System.Drawing.Size(35, 13);
            this.clicksHeader.TabIndex = 6;
            this.clicksHeader.Text = "Clicks";
            // 
            // btnCommand4
            // 
            this.btnCommand4.Location = new System.Drawing.Point(615, 255);
            this.btnCommand4.Name = "btnCommand4";
            this.btnCommand4.Size = new System.Drawing.Size(75, 23);
            this.btnCommand4.TabIndex = 7;
            this.btnCommand4.Text = "Undo";
            this.btnCommand4.UseVisualStyleBackColor = true;
            this.btnCommand4.Click += new System.EventHandler(this.btnCommand4_Click);
            // 
            // btnCommand5
            // 
            this.btnCommand5.Location = new System.Drawing.Point(615, 338);
            this.btnCommand5.Name = "btnCommand5";
            this.btnCommand5.Size = new System.Drawing.Size(75, 23);
            this.btnCommand5.TabIndex = 8;
            this.btnCommand5.Text = "New Game";
            this.btnCommand5.UseVisualStyleBackColor = true;
            this.btnCommand5.Click += new System.EventHandler(this.btnCommand5_Click);
            // 
            // aimNumber
            // 
            this.aimNumber.AutoSize = true;
            this.aimNumber.Location = new System.Drawing.Point(477, 348);
            this.aimNumber.Name = "aimNumber";
            this.aimNumber.Size = new System.Drawing.Size(0, 13);
            this.aimNumber.TabIndex = 9;
            // 
            // aimHeader
            // 
            this.aimHeader.AutoSize = true;
            this.aimHeader.Location = new System.Drawing.Point(400, 348);
            this.aimHeader.Name = "aimHeader";
            this.aimHeader.Size = new System.Drawing.Size(36, 13);
            this.aimHeader.TabIndex = 10;
            this.aimHeader.Text = "Aim at";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.aimHeader);
            this.Controls.Add(this.aimNumber);
            this.Controls.Add(this.btnCommand5);
            this.Controls.Add(this.btnCommand4);
            this.Controls.Add(this.clicksHeader);
            this.Controls.Add(this.number);
            this.Controls.Add(this.clicks);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnCommand3);
            this.Controls.Add(this.btnCommand2);
            this.Controls.Add(this.btnCommand1);
            this.Name = "Form1";
            this.Text = "Doubler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCommand1;
        private System.Windows.Forms.Button btnCommand2;
        private System.Windows.Forms.Button btnCommand3;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label clicks;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Label clicksHeader;
        private System.Windows.Forms.Button btnCommand4;
        private System.Windows.Forms.Button btnCommand5;
        private System.Windows.Forms.Label aimNumber;
        private System.Windows.Forms.Label aimHeader;
    }
}

