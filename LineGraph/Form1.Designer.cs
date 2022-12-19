namespace LineGraph
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
            this.lineGraphUserControl1 = new LineGraph.LineGraphUserControl();
            this.SuspendLayout();
            // 
            // lineGraphUserControl1
            // 
            this.lineGraphUserControl1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lineGraphUserControl1.Location = new System.Drawing.Point(127, 77);
            this.lineGraphUserControl1.Name = "lineGraphUserControl1";
            this.lineGraphUserControl1.Size = new System.Drawing.Size(600, 400);
            this.lineGraphUserControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 575);
            this.Controls.Add(this.lineGraphUserControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LineGraphUserControl lineGraphUserControl1;
    }
}

