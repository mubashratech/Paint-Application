namespace Painting
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
            panel1 = new Panel();
            btn_sa = new Button();
            btn_cl = new Button();
            pic_color = new Button();
            color_picker = new PictureBox();
            panel3 = new Panel();
            btn_line = new Button();
            btn_rect = new Button();
            btn_color = new Button();
            btn_fill = new Button();
            btn_pencil = new Button();
            btn_ellipse = new Button();
            btn_eraser = new Button();
            btn_save = new Button();
            btn_clear = new Button();
            panel2 = new Panel();
            pic = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)color_picker).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(pic_color);
            panel1.Controls.Add(btn_sa);
            panel1.Controls.Add(btn_cl);
            panel1.Controls.Add(color_picker);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(901, 93);
            panel1.TabIndex = 0;
            // 
            // btn_sa
            // 
            btn_sa.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_sa.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            btn_sa.FlatStyle = FlatStyle.Flat;
            btn_sa.ForeColor = Color.White;
            btn_sa.ImageAlign = ContentAlignment.TopCenter;
            btn_sa.Location = new Point(818, 21);
            btn_sa.Name = "btn_sa";
            btn_sa.Size = new Size(80, 30);
            btn_sa.TabIndex = 11;
            btn_sa.Text = "Save";
            btn_sa.UseVisualStyleBackColor = true;
            btn_sa.Click += button1_Click_2;
            // 
            // btn_cl
            // 
            btn_cl.Cursor = Cursors.Hand;
            btn_cl.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_cl.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            btn_cl.FlatStyle = FlatStyle.Flat;
            btn_cl.ForeColor = Color.White;
            btn_cl.ImageAlign = ContentAlignment.TopCenter;
            btn_cl.Location = new Point(818, 57);
            btn_cl.Name = "btn_cl";
            btn_cl.Size = new Size(80, 30);
            btn_cl.TabIndex = 10;
            btn_cl.Text = "Clear";
            btn_cl.UseVisualStyleBackColor = true;
            btn_cl.Click += button1_Click_1;
            // 
            // pic_color
            // 
            pic_color.BackColor = Color.White;
            pic_color.Location = new Point(213, 21);
            pic_color.Name = "pic_color";
            pic_color.Size = new Size(51, 44);
            pic_color.TabIndex = 0;
            pic_color.UseVisualStyleBackColor = false;
            // 
            // color_picker
            // 
            color_picker.Cursor = Cursors.Hand;
            color_picker.Image = (Image)resources.GetObject("color_picker.Image");
            color_picker.Location = new Point(3, 0);
            color_picker.Name = "color_picker";
            color_picker.Size = new Size(207, 96);
            color_picker.SizeMode = PictureBoxSizeMode.StretchImage;
            color_picker.TabIndex = 3;
            color_picker.TabStop = false;
            color_picker.MouseClick += color_picker_MouseClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(btn_line);
            panel3.Controls.Add(btn_rect);
            panel3.Controls.Add(btn_color);
            panel3.Controls.Add(btn_fill);
            panel3.Controls.Add(btn_pencil);
            panel3.Controls.Add(btn_ellipse);
            panel3.Controls.Add(btn_eraser);
            panel3.Location = new Point(264, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(548, 82);
            panel3.TabIndex = 3;
            // 
            // btn_line
            // 
            btn_line.Cursor = Cursors.Hand;
            btn_line.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_line.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            btn_line.FlatStyle = FlatStyle.Flat;
            btn_line.ForeColor = Color.White;
            btn_line.Image = (Image)resources.GetObject("btn_line.Image");
            btn_line.ImageAlign = ContentAlignment.TopCenter;
            btn_line.Location = new Point(468, 14);
            btn_line.Name = "btn_line";
            btn_line.Size = new Size(71, 55);
            btn_line.TabIndex = 7;
            btn_line.Text = "Line";
            btn_line.TextAlign = ContentAlignment.BottomCenter;
            btn_line.UseVisualStyleBackColor = true;
            btn_line.Click += btn_line_Click;
            // 
            // btn_rect
            // 
            btn_rect.Cursor = Cursors.Hand;
            btn_rect.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_rect.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            btn_rect.FlatStyle = FlatStyle.Flat;
            btn_rect.ForeColor = Color.White;
            btn_rect.Image = (Image)resources.GetObject("btn_rect.Image");
            btn_rect.ImageAlign = ContentAlignment.TopCenter;
            btn_rect.Location = new Point(391, 14);
            btn_rect.Name = "btn_rect";
            btn_rect.Size = new Size(71, 55);
            btn_rect.TabIndex = 6;
            btn_rect.Text = "Rectangle";
            btn_rect.TextAlign = ContentAlignment.BottomCenter;
            btn_rect.UseVisualStyleBackColor = false;
            btn_rect.Click += btn_rect_Click;
            // 
            // btn_color
            // 
            btn_color.Cursor = Cursors.Hand;
            btn_color.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_color.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            btn_color.FlatStyle = FlatStyle.Flat;
            btn_color.ForeColor = Color.White;
            btn_color.Image = (Image)resources.GetObject("btn_color.Image");
            btn_color.ImageAlign = ContentAlignment.BottomCenter;
            btn_color.Location = new Point(6, 14);
            btn_color.Name = "btn_color";
            btn_color.Size = new Size(71, 55);
            btn_color.TabIndex = 1;
            btn_color.Text = "Color";
            btn_color.TextAlign = ContentAlignment.BottomCenter;
            btn_color.UseVisualStyleBackColor = true;
            btn_color.Click += btn_color_Click;
            // 
            // btn_fill
            // 
            btn_fill.Cursor = Cursors.Hand;
            btn_fill.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_fill.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            btn_fill.FlatStyle = FlatStyle.Flat;
            btn_fill.ForeColor = Color.White;
            btn_fill.Image = (Image)resources.GetObject("btn_fill.Image");
            btn_fill.ImageAlign = ContentAlignment.MiddleLeft;
            btn_fill.Location = new Point(83, 14);
            btn_fill.Name = "btn_fill";
            btn_fill.Size = new Size(71, 55);
            btn_fill.TabIndex = 3;
            btn_fill.Text = "Fill";
            btn_fill.TextAlign = ContentAlignment.BottomCenter;
            btn_fill.UseVisualStyleBackColor = true;
            btn_fill.Click += btn_fill_Click;
            // 
            // btn_pencil
            // 
            btn_pencil.Cursor = Cursors.Hand;
            btn_pencil.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_pencil.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            btn_pencil.FlatStyle = FlatStyle.Flat;
            btn_pencil.ForeColor = Color.White;
            btn_pencil.Image = (Image)resources.GetObject("btn_pencil.Image");
            btn_pencil.ImageAlign = ContentAlignment.MiddleLeft;
            btn_pencil.Location = new Point(160, 14);
            btn_pencil.Name = "btn_pencil";
            btn_pencil.Size = new Size(71, 55);
            btn_pencil.TabIndex = 4;
            btn_pencil.Text = "Pencil";
            btn_pencil.TextAlign = ContentAlignment.BottomCenter;
            btn_pencil.UseVisualStyleBackColor = true;
            btn_pencil.Click += btn_pencil_Click;
            // 
            // btn_ellipse
            // 
            btn_ellipse.Cursor = Cursors.Hand;
            btn_ellipse.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_ellipse.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            btn_ellipse.FlatStyle = FlatStyle.Flat;
            btn_ellipse.ForeColor = Color.White;
            btn_ellipse.Image = (Image)resources.GetObject("btn_ellipse.Image");
            btn_ellipse.ImageAlign = ContentAlignment.TopCenter;
            btn_ellipse.Location = new Point(314, 14);
            btn_ellipse.Name = "btn_ellipse";
            btn_ellipse.Size = new Size(71, 55);
            btn_ellipse.TabIndex = 5;
            btn_ellipse.Text = "Ellipse";
            btn_ellipse.TextAlign = ContentAlignment.BottomCenter;
            btn_ellipse.UseVisualStyleBackColor = true;
            btn_ellipse.Click += btn_ellipse_Click;
            // 
            // btn_eraser
            // 
            btn_eraser.Cursor = Cursors.Hand;
            btn_eraser.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_eraser.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            btn_eraser.FlatStyle = FlatStyle.Flat;
            btn_eraser.ForeColor = Color.White;
            btn_eraser.Image = (Image)resources.GetObject("btn_eraser.Image");
            btn_eraser.ImageAlign = ContentAlignment.MiddleLeft;
            btn_eraser.Location = new Point(237, 14);
            btn_eraser.Name = "btn_eraser";
            btn_eraser.Size = new Size(71, 55);
            btn_eraser.TabIndex = 2;
            btn_eraser.Text = "Eraser";
            btn_eraser.TextAlign = ContentAlignment.BottomCenter;
            btn_eraser.UseVisualStyleBackColor = true;
            btn_eraser.Click += btn_eraser_Click;
            // 
            // btn_save
            // 
            btn_save.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_save.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.ForeColor = Color.White;
            btn_save.ImageAlign = ContentAlignment.TopCenter;
            btn_save.Location = new Point(708, 192);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(76, 30);
            btn_save.TabIndex = 9;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            btn_clear.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_clear.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.ForeColor = Color.Transparent;
            btn_clear.ImageAlign = ContentAlignment.TopCenter;
            btn_clear.Location = new Point(708, 194);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(95, 26);
            btn_clear.TabIndex = 8;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 482);
            panel2.Name = "panel2";
            panel2.Size = new Size(901, 55);
            panel2.TabIndex = 1;
            // 
            // pic
            // 
            pic.BackColor = Color.White;
            pic.Dock = DockStyle.Fill;
            pic.Location = new Point(0, 93);
            pic.Name = "pic";
            pic.Size = new Size(901, 389);
            pic.TabIndex = 2;
            pic.TabStop = false;
            pic.Click += pic_Click;
            pic.Paint += pic_Paint;
            pic.MouseClick += pic_MouseClick;
            pic.MouseDown += pic_MouseDown;
            pic.MouseMove += pic_MouseMove;
            pic.MouseUp += pic_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(901, 537);
            Controls.Add(pic);
            Controls.Add(btn_save);
            Controls.Add(btn_clear);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Paint";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)color_picker).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pic;
        private Button pic_color;
        private Button btn_color;
        private Button btn_pencil;
        private Button btn_fill;
        private Button btn_eraser;
        private Button btn_line;
        private Button btn_rect;
        private Button btn_ellipse;
        private Panel panel3;
        private PictureBox color_picker;
        private Button btn_clear;
        private Button btn_save;
        private Button btn_cl;
        private Button btn_sa;
    }
}
