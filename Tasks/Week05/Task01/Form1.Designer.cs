
namespace Task01
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
            this.firstValue = new System.Windows.Forms.NumericUpDown();
            this.secondValue = new System.Windows.Forms.NumericUpDown();
            this.comboBoxOperator = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.btnResult = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.firstValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondValue)).BeginInit();
            this.SuspendLayout();
            // 
            // firstValue
            // 
            this.firstValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstValue.Location = new System.Drawing.Point(108, 50);
            this.firstValue.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.firstValue.Name = "firstValue";
            this.firstValue.Size = new System.Drawing.Size(133, 26);
            this.firstValue.TabIndex = 0;
            this.firstValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // secondValue
            // 
            this.secondValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondValue.Location = new System.Drawing.Point(476, 50);
            this.secondValue.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.secondValue.Name = "secondValue";
            this.secondValue.Size = new System.Drawing.Size(133, 26);
            this.secondValue.TabIndex = 1;
            this.secondValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBoxOperator
            // 
            this.comboBoxOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOperator.FormattingEnabled = true;
            this.comboBoxOperator.Location = new System.Drawing.Point(293, 43);
            this.comboBoxOperator.Name = "comboBoxOperator";
            this.comboBoxOperator.Size = new System.Drawing.Size(141, 33);
            this.comboBoxOperator.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Result:";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(280, 154);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(22, 24);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.Text = "0";
            // 
            // btnResult
            // 
            this.btnResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.Location = new System.Drawing.Point(476, 230);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(120, 41);
            this.btnResult.TabIndex = 5;
            this.btnResult.Text = "Calculate";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 382);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxOperator);
            this.Controls.Add(this.secondValue);
            this.Controls.Add(this.firstValue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.firstValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown firstValue;
        private System.Windows.Forms.NumericUpDown secondValue;
        private System.Windows.Forms.ComboBox comboBoxOperator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button btnResult;
    }
}

