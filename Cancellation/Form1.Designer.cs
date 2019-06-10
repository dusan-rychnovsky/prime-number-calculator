namespace Cancellation
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
            this.maxValueTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.largestPrimeTxt = new System.Windows.Forms.TextBox();
            this.calculatingLbl = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maxValueTxt
            // 
            this.maxValueTxt.Location = new System.Drawing.Point(150, 33);
            this.maxValueTxt.Name = "maxValueTxt";
            this.maxValueTxt.Size = new System.Drawing.Size(227, 26);
            this.maxValueTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Max";
            // 
            // calculateBtn
            // 
            this.calculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateBtn.Location = new System.Drawing.Point(278, 75);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(99, 37);
            this.calculateBtn.TabIndex = 2;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Largest Prime";
            // 
            // largestPrimeTxt
            // 
            this.largestPrimeTxt.Location = new System.Drawing.Point(150, 187);
            this.largestPrimeTxt.Name = "largestPrimeTxt";
            this.largestPrimeTxt.Size = new System.Drawing.Size(227, 26);
            this.largestPrimeTxt.TabIndex = 4;
            // 
            // calculatingLbl
            // 
            this.calculatingLbl.AutoSize = true;
            this.calculatingLbl.Location = new System.Drawing.Point(223, 147);
            this.calculatingLbl.Name = "calculatingLbl";
            this.calculatingLbl.Size = new System.Drawing.Size(103, 20);
            this.calculatingLbl.TabIndex = 5;
            this.calculatingLbl.Text = "Calculating ...";
            this.calculatingLbl.Visible = false;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Enabled = false;
            this.cancelBtn.Location = new System.Drawing.Point(183, 75);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(89, 37);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 241);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.calculatingLbl);
            this.Controls.Add(this.largestPrimeTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxValueTxt);
            this.Name = "Form1";
            this.Text = "Prime Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox maxValueTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox largestPrimeTxt;
        private System.Windows.Forms.Label calculatingLbl;
        private System.Windows.Forms.Button cancelBtn;
    }
}

