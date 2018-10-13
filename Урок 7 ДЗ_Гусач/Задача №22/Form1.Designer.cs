namespace Задача__22
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
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.enterAnswer = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelTries = new System.Windows.Forms.Label();
            this.labelTR = new System.Windows.Forms.Label();
            this.labelGeneral = new System.Windows.Forms.Label();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAnswer.Location = new System.Drawing.Point(18, 129);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.ReadOnly = true;
            this.textBoxAnswer.Size = new System.Drawing.Size(117, 26);
            this.textBoxAnswer.TabIndex = 0;
            this.textBoxAnswer.TextChanged += new System.EventHandler(this.textBoxAnswer_TextChanged);
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stateLabel.Location = new System.Drawing.Point(18, 61);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(55, 20);
            this.stateLabel.TabIndex = 1;
            this.stateLabel.Text = "Result";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(79, 61);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 20);
            this.labelResult.TabIndex = 2;
            // 
            // enterAnswer
            // 
            this.enterAnswer.Location = new System.Drawing.Point(169, 129);
            this.enterAnswer.Name = "enterAnswer";
            this.enterAnswer.Size = new System.Drawing.Size(45, 26);
            this.enterAnswer.TabIndex = 3;
            this.enterAnswer.Text = "Try";
            this.enterAnswer.UseVisualStyleBackColor = true;
            this.enterAnswer.Click += new System.EventHandler(this.enterAnswer_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(437, 131);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(45, 26);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelTries
            // 
            this.labelTries.AutoSize = true;
            this.labelTries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTries.Location = new System.Drawing.Point(277, 136);
            this.labelTries.Name = "labelTries";
            this.labelTries.Size = new System.Drawing.Size(0, 16);
            this.labelTries.TabIndex = 5;
            // 
            // labelTR
            // 
            this.labelTR.AutoSize = true;
            this.labelTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTR.Location = new System.Drawing.Point(220, 135);
            this.labelTR.Name = "labelTR";
            this.labelTR.Size = new System.Drawing.Size(39, 16);
            this.labelTR.TabIndex = 6;
            this.labelTR.Text = "Tries";
            // 
            // labelGeneral
            // 
            this.labelGeneral.AutoSize = true;
            this.labelGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGeneral.Location = new System.Drawing.Point(13, 13);
            this.labelGeneral.Name = "labelGeneral";
            this.labelGeneral.Size = new System.Drawing.Size(491, 25);
            this.labelGeneral.TabIndex = 7;
            this.labelGeneral.Text = "Try to guess random integer number from 1 to 100";
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Location = new System.Drawing.Point(19, 113);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(118, 13);
            this.labelAnswer.TabIndex = 8;
            this.labelAnswer.Text = "Enter Your answer here";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 240);
            this.Controls.Add(this.labelAnswer);
            this.Controls.Add(this.labelGeneral);
            this.Controls.Add(this.labelTR);
            this.Controls.Add(this.labelTries);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.enterAnswer);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.textBoxAnswer);
            this.Name = "Form1";
            this.Text = "Guess";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button enterAnswer;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelTries;
        private System.Windows.Forms.Label labelTR;
        private System.Windows.Forms.Label labelGeneral;
        private System.Windows.Forms.Label labelAnswer;
    }
}

