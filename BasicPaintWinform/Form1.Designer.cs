namespace BasicPaintWinform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Color = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.rbtn_Filled = new Guna.UI2.WinForms.Guna2ImageRadioButton();
            this.rbtn_Pen = new Guna.UI2.WinForms.Guna2ImageRadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Clear = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_Triangle = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_Circle = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_Rectangle = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Color
            // 
            this.btn_Color.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Color.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Color.Image = global::BasicPaintWinform.Properties.Resources.color;
            this.btn_Color.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_Color.ImageRotate = 0F;
            this.btn_Color.Location = new System.Drawing.Point(873, 36);
            this.btn_Color.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_Color.Name = "btn_Color";
            this.btn_Color.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Color.Size = new System.Drawing.Size(119, 80);
            this.btn_Color.TabIndex = 4;
            this.btn_Color.Click += new System.EventHandler(this.btn_Color_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(894, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Colors";
            // 
            // rbtn_Filled
            // 
            this.rbtn_Filled.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.rbtn_Filled.Image = global::BasicPaintWinform.Properties.Resources.filled;
            this.rbtn_Filled.ImageOffset = new System.Drawing.Point(0, 0);
            this.rbtn_Filled.ImageRotate = 0F;
            this.rbtn_Filled.ImageSize = new System.Drawing.Size(100, 100);
            this.rbtn_Filled.Location = new System.Drawing.Point(172, 13);
            this.rbtn_Filled.Name = "rbtn_Filled";
            this.rbtn_Filled.Size = new System.Drawing.Size(76, 91);
            this.rbtn_Filled.TabIndex = 10;
            // 
            // rbtn_Pen
            // 
            this.rbtn_Pen.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.rbtn_Pen.Image = global::BasicPaintWinform.Properties.Resources.penicon;
            this.rbtn_Pen.ImageOffset = new System.Drawing.Point(0, 0);
            this.rbtn_Pen.ImageRotate = 0F;
            this.rbtn_Pen.ImageSize = new System.Drawing.Size(80, 80);
            this.rbtn_Pen.Location = new System.Drawing.Point(49, 13);
            this.rbtn_Pen.Name = "rbtn_Pen";
            this.rbtn_Pen.Size = new System.Drawing.Size(117, 91);
            this.rbtn_Pen.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Clear);
            this.panel1.Controls.Add(this.btn_Triangle);
            this.panel1.Controls.Add(this.btn_Circle);
            this.panel1.Controls.Add(this.rbtn_Pen);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_Rectangle);
            this.panel1.Controls.Add(this.rbtn_Filled);
            this.panel1.Controls.Add(this.btn_Color);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(-2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1290, 145);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1012, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Clear All";
            // 
            // btn_Clear
            // 
            this.btn_Clear.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Clear.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Clear.Image = global::BasicPaintWinform.Properties.Resources.clear;
            this.btn_Clear.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_Clear.ImageRotate = 0F;
            this.btn_Clear.Location = new System.Drawing.Point(1012, 36);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Clear.Size = new System.Drawing.Size(80, 68);
            this.btn_Clear.TabIndex = 19;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Triangle
            // 
            this.btn_Triangle.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Triangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Triangle.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Triangle.Image = global::BasicPaintWinform.Properties.Resources.line;
            this.btn_Triangle.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_Triangle.ImageRotate = 0F;
            this.btn_Triangle.Location = new System.Drawing.Point(592, 26);
            this.btn_Triangle.Name = "btn_Triangle";
            this.btn_Triangle.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Triangle.Size = new System.Drawing.Size(80, 68);
            this.btn_Triangle.TabIndex = 17;
            this.btn_Triangle.Click += new System.EventHandler(this.btn_Line_Click);
            // 
            // btn_Circle
            // 
            this.btn_Circle.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Circle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Circle.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Circle.Image = global::BasicPaintWinform.Properties.Resources.circcle;
            this.btn_Circle.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_Circle.ImageRotate = 0F;
            this.btn_Circle.Location = new System.Drawing.Point(506, 26);
            this.btn_Circle.Name = "btn_Circle";
            this.btn_Circle.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Circle.Size = new System.Drawing.Size(80, 68);
            this.btn_Circle.TabIndex = 18;
            this.btn_Circle.Click += new System.EventHandler(this.btn_Circle_Click);
            // 
            // btn_Rectangle
            // 
            this.btn_Rectangle.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Rectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Rectangle.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Rectangle.Image = global::BasicPaintWinform.Properties.Resources.rectangle;
            this.btn_Rectangle.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_Rectangle.ImageRotate = 0F;
            this.btn_Rectangle.Location = new System.Drawing.Point(420, 26);
            this.btn_Rectangle.Name = "btn_Rectangle";
            this.btn_Rectangle.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Rectangle.Size = new System.Drawing.Size(80, 68);
            this.btn_Rectangle.TabIndex = 16;
            this.btn_Rectangle.Click += new System.EventHandler(this.btn_Rectangle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 562);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ImageButton btn_Color;
        private Label label2;
        private ColorDialog colorDialog1;
        private Guna.UI2.WinForms.Guna2ImageRadioButton rbtn_Filled;
        private Guna.UI2.WinForms.Guna2ImageRadioButton rbtn_Pen;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2ImageButton btn_Rectangle;
        private Guna.UI2.WinForms.Guna2ImageButton btn_Triangle;
        private Guna.UI2.WinForms.Guna2ImageButton btn_Circle;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ImageButton btn_Clear;
    }
}