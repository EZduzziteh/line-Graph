namespace LineGraph
{
    partial class LineGraphUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Add_Line = new System.Windows.Forms.Button();
            this.btn_Point_Editor_Newpoint = new System.Windows.Forms.Button();
            this.cmb_Select_Point = new System.Windows.Forms.ComboBox();
            this.lbl_pointEditor_inputX = new System.Windows.Forms.Label();
            this.textbox_pointEditor_inputX = new System.Windows.Forms.TextBox();
            this.lbl_pointEditor_inputY = new System.Windows.Forms.Label();
            this.textbox_pointEditor_inputY = new System.Windows.Forms.TextBox();
            this.btn_update_point = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmb_SelectLine = new System.Windows.Forms.ComboBox();
            this.cmb_Select_Color = new System.Windows.Forms.ComboBox();
            this.img_line_editor_color = new System.Windows.Forms.PictureBox();
            this.lbl_scale_Y_high = new System.Windows.Forms.Label();
            this.lbl_scale_y_low = new System.Windows.Forms.Label();
            this.lbl_scale_y_middle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_x_max = new System.Windows.Forms.Label();
            this.lbl_x_mid = new System.Windows.Forms.Label();
            this.lbl_x_min = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_line_editor_color)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Add_Line
            // 
            this.btn_Add_Line.Location = new System.Drawing.Point(6, 19);
            this.btn_Add_Line.Name = "btn_Add_Line";
            this.btn_Add_Line.Size = new System.Drawing.Size(118, 23);
            this.btn_Add_Line.TabIndex = 6;
            this.btn_Add_Line.Text = "Add New Line";
            this.btn_Add_Line.UseVisualStyleBackColor = true;
            this.btn_Add_Line.Click += new System.EventHandler(this.btn_Add_New_Line);
            // 
            // btn_Point_Editor_Newpoint
            // 
            this.btn_Point_Editor_Newpoint.Location = new System.Drawing.Point(160, 26);
            this.btn_Point_Editor_Newpoint.Name = "btn_Point_Editor_Newpoint";
            this.btn_Point_Editor_Newpoint.Size = new System.Drawing.Size(75, 23);
            this.btn_Point_Editor_Newpoint.TabIndex = 8;
            this.btn_Point_Editor_Newpoint.Text = "New Point";
            this.btn_Point_Editor_Newpoint.UseVisualStyleBackColor = true;
            this.btn_Point_Editor_Newpoint.Click += new System.EventHandler(this.btn_Point_Editor_Newpoint_Click);
            // 
            // cmb_Select_Point
            // 
            this.cmb_Select_Point.FormattingEnabled = true;
            this.cmb_Select_Point.Location = new System.Drawing.Point(18, 19);
            this.cmb_Select_Point.Name = "cmb_Select_Point";
            this.cmb_Select_Point.Size = new System.Drawing.Size(121, 21);
            this.cmb_Select_Point.TabIndex = 0;
            this.cmb_Select_Point.Text = "Select A Point";
            this.cmb_Select_Point.SelectedIndexChanged += new System.EventHandler(this.cmb_Select_Point_SelectedIndexChanged);
            // 
            // lbl_pointEditor_inputX
            // 
            this.lbl_pointEditor_inputX.AutoSize = true;
            this.lbl_pointEditor_inputX.Location = new System.Drawing.Point(4, 49);
            this.lbl_pointEditor_inputX.Name = "lbl_pointEditor_inputX";
            this.lbl_pointEditor_inputX.Size = new System.Drawing.Size(17, 13);
            this.lbl_pointEditor_inputX.TabIndex = 6;
            this.lbl_pointEditor_inputX.Text = "X:";
            // 
            // textbox_pointEditor_inputX
            // 
            this.textbox_pointEditor_inputX.Location = new System.Drawing.Point(27, 46);
            this.textbox_pointEditor_inputX.Name = "textbox_pointEditor_inputX";
            this.textbox_pointEditor_inputX.Size = new System.Drawing.Size(100, 20);
            this.textbox_pointEditor_inputX.TabIndex = 5;
            // 
            // lbl_pointEditor_inputY
            // 
            this.lbl_pointEditor_inputY.AutoSize = true;
            this.lbl_pointEditor_inputY.Location = new System.Drawing.Point(4, 74);
            this.lbl_pointEditor_inputY.Name = "lbl_pointEditor_inputY";
            this.lbl_pointEditor_inputY.Size = new System.Drawing.Size(17, 13);
            this.lbl_pointEditor_inputY.TabIndex = 7;
            this.lbl_pointEditor_inputY.Text = "Y:";
            // 
            // textbox_pointEditor_inputY
            // 
            this.textbox_pointEditor_inputY.Location = new System.Drawing.Point(27, 71);
            this.textbox_pointEditor_inputY.Name = "textbox_pointEditor_inputY";
            this.textbox_pointEditor_inputY.Size = new System.Drawing.Size(100, 20);
            this.textbox_pointEditor_inputY.TabIndex = 4;
            // 
            // btn_update_point
            // 
            this.btn_update_point.Location = new System.Drawing.Point(146, 57);
            this.btn_update_point.Name = "btn_update_point";
            this.btn_update_point.Size = new System.Drawing.Size(107, 23);
            this.btn_update_point.TabIndex = 9;
            this.btn_update_point.Text = "Update Point";
            this.btn_update_point.UseVisualStyleBackColor = true;
            this.btn_update_point.Click += new System.EventHandler(this.btn_update_point_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Location = new System.Drawing.Point(50, 175);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 200);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // cmb_SelectLine
            // 
            this.cmb_SelectLine.FormattingEnabled = true;
            this.cmb_SelectLine.Location = new System.Drawing.Point(6, 50);
            this.cmb_SelectLine.Name = "cmb_SelectLine";
            this.cmb_SelectLine.Size = new System.Drawing.Size(121, 21);
            this.cmb_SelectLine.TabIndex = 0;
            this.cmb_SelectLine.Text = "Select A Line";
            this.cmb_SelectLine.SelectedIndexChanged += new System.EventHandler(this.cmb_SelectLine_SelectedIndexChanged);
            // 
            // cmb_Select_Color
            // 
            this.cmb_Select_Color.FormattingEnabled = true;
            this.cmb_Select_Color.Location = new System.Drawing.Point(6, 77);
            this.cmb_Select_Color.Name = "cmb_Select_Color";
            this.cmb_Select_Color.Size = new System.Drawing.Size(121, 21);
            this.cmb_Select_Color.TabIndex = 4;
            this.cmb_Select_Color.Text = "Select A Color";
            this.cmb_Select_Color.SelectedIndexChanged += new System.EventHandler(this.cmb_Line_Color_SelectedIndexChanged);
            // 
            // img_line_editor_color
            // 
            this.img_line_editor_color.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.img_line_editor_color.Location = new System.Drawing.Point(133, 77);
            this.img_line_editor_color.Name = "img_line_editor_color";
            this.img_line_editor_color.Size = new System.Drawing.Size(20, 20);
            this.img_line_editor_color.TabIndex = 6;
            this.img_line_editor_color.TabStop = false;
            // 
            // lbl_scale_Y_high
            // 
            this.lbl_scale_Y_high.AutoSize = true;
            this.lbl_scale_Y_high.Location = new System.Drawing.Point(19, 175);
            this.lbl_scale_Y_high.Name = "lbl_scale_Y_high";
            this.lbl_scale_Y_high.Size = new System.Drawing.Size(25, 13);
            this.lbl_scale_Y_high.TabIndex = 11;
            this.lbl_scale_Y_high.Text = "100";
            this.lbl_scale_Y_high.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_scale_y_low
            // 
            this.lbl_scale_y_low.AutoSize = true;
            this.lbl_scale_y_low.Location = new System.Drawing.Point(19, 362);
            this.lbl_scale_y_low.Name = "lbl_scale_y_low";
            this.lbl_scale_y_low.Size = new System.Drawing.Size(28, 13);
            this.lbl_scale_y_low.TabIndex = 12;
            this.lbl_scale_y_low.Text = "-100";
            this.lbl_scale_y_low.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_scale_y_middle
            // 
            this.lbl_scale_y_middle.AutoSize = true;
            this.lbl_scale_y_middle.Location = new System.Drawing.Point(19, 271);
            this.lbl_scale_y_middle.Name = "lbl_scale_y_middle";
            this.lbl_scale_y_middle.Size = new System.Drawing.Size(13, 13);
            this.lbl_scale_y_middle.TabIndex = 13;
            this.lbl_scale_y_middle.Text = "0";
            this.lbl_scale_y_middle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Controls.Add(this.btn_Add_Line);
            this.groupBox1.Controls.Add(this.cmb_SelectLine);
            this.groupBox1.Controls.Add(this.cmb_Select_Color);
            this.groupBox1.Controls.Add(this.img_line_editor_color);
            this.groupBox1.Location = new System.Drawing.Point(67, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 107);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Line Editor";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Controls.Add(this.cmb_Select_Point);
            this.groupBox2.Controls.Add(this.textbox_pointEditor_inputX);
            this.groupBox2.Controls.Add(this.btn_update_point);
            this.groupBox2.Controls.Add(this.lbl_pointEditor_inputX);
            this.groupBox2.Controls.Add(this.btn_Point_Editor_Newpoint);
            this.groupBox2.Controls.Add(this.textbox_pointEditor_inputY);
            this.groupBox2.Controls.Add(this.lbl_pointEditor_inputY);
            this.groupBox2.Location = new System.Drawing.Point(300, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 107);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Point Editor";
            // 
            // lbl_x_max
            // 
            this.lbl_x_max.AutoSize = true;
            this.lbl_x_max.Location = new System.Drawing.Point(375, 378);
            this.lbl_x_max.Name = "lbl_x_max";
            this.lbl_x_max.Size = new System.Drawing.Size(25, 13);
            this.lbl_x_max.TabIndex = 16;
            this.lbl_x_max.Text = "175";
            this.lbl_x_max.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_x_max.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_x_mid
            // 
            this.lbl_x_mid.AutoSize = true;
            this.lbl_x_mid.Location = new System.Drawing.Point(207, 378);
            this.lbl_x_mid.Name = "lbl_x_mid";
            this.lbl_x_mid.Size = new System.Drawing.Size(13, 13);
            this.lbl_x_mid.TabIndex = 17;
            this.lbl_x_mid.Text = "0";
            this.lbl_x_mid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_x_min
            // 
            this.lbl_x_min.AutoSize = true;
            this.lbl_x_min.Location = new System.Drawing.Point(47, 378);
            this.lbl_x_min.Name = "lbl_x_min";
            this.lbl_x_min.Size = new System.Drawing.Size(28, 13);
            this.lbl_x_min.TabIndex = 18;
            this.lbl_x_min.Text = "-175";
            this.lbl_x_min.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LineGraphUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.lbl_x_min);
            this.Controls.Add(this.lbl_x_mid);
            this.Controls.Add(this.lbl_x_max);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_scale_y_middle);
            this.Controls.Add(this.lbl_scale_y_low);
            this.Controls.Add(this.lbl_scale_Y_high);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LineGraphUserControl";
            this.Size = new System.Drawing.Size(600, 400);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_line_editor_color)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Add_Line;
        private System.Windows.Forms.Button btn_Point_Editor_Newpoint;
        private System.Windows.Forms.ComboBox cmb_Select_Point;
        private System.Windows.Forms.Label lbl_pointEditor_inputX;
        private System.Windows.Forms.TextBox textbox_pointEditor_inputX;
        private System.Windows.Forms.Label lbl_pointEditor_inputY;
        private System.Windows.Forms.TextBox textbox_pointEditor_inputY;
        private System.Windows.Forms.Button btn_update_point;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmb_SelectLine;
        private System.Windows.Forms.ComboBox cmb_Select_Color;
        private System.Windows.Forms.PictureBox img_line_editor_color;
        private System.Windows.Forms.Label lbl_scale_Y_high;
        private System.Windows.Forms.Label lbl_scale_y_low;
        private System.Windows.Forms.Label lbl_scale_y_middle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_x_max;
        private System.Windows.Forms.Label lbl_x_mid;
        private System.Windows.Forms.Label lbl_x_min;
    }
}
