﻿namespace SVGEditor2.Tools.ToolBoxes
{
    partial class ToolBox
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolBox));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButton_Pointer = new System.Windows.Forms.RadioButton();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.radioButton_rectangle = new System.Windows.Forms.RadioButton();
            this.radioButton_line = new System.Windows.Forms.RadioButton();
            this.radioButton_ellipse = new System.Windows.Forms.RadioButton();
            this.radioButton_pencil = new System.Windows.Forms.RadioButton();
            this.radioButton_path = new System.Windows.Forms.RadioButton();
            this.radioButton_text = new System.Windows.Forms.RadioButton();
            this.radioButton_pan = new System.Windows.Forms.RadioButton();
            this.radioButton_image = new System.Windows.Forms.RadioButton();
            this.btnGravar = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGravar)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.radioButton_Pointer);
            this.flowLayoutPanel1.Controls.Add(this.radioButton_rectangle);
            this.flowLayoutPanel1.Controls.Add(this.radioButton_line);
            this.flowLayoutPanel1.Controls.Add(this.radioButton_ellipse);
            this.flowLayoutPanel1.Controls.Add(this.radioButton_pencil);
            this.flowLayoutPanel1.Controls.Add(this.radioButton_path);
            this.flowLayoutPanel1.Controls.Add(this.radioButton_text);
            this.flowLayoutPanel1.Controls.Add(this.radioButton_pan);
            this.flowLayoutPanel1.Controls.Add(this.radioButton_image);
            this.flowLayoutPanel1.Controls.Add(this.btnGravar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(283, 556);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // radioButton_Pointer
            // 
            this.radioButton_Pointer.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton_Pointer.ImageKey = "Pointer32x32.ico";
            this.radioButton_Pointer.ImageList = this.imageList;
            this.radioButton_Pointer.Location = new System.Drawing.Point(3, 3);
            this.radioButton_Pointer.Name = "radioButton_Pointer";
            this.radioButton_Pointer.Size = new System.Drawing.Size(60, 60);
            this.radioButton_Pointer.TabIndex = 0;
            this.radioButton_Pointer.TabStop = true;
            this.radioButton_Pointer.UseVisualStyleBackColor = true;
            this.radioButton_Pointer.Visible = false;
            this.radioButton_Pointer.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Line32x32.ico");
            this.imageList.Images.SetKeyName(1, "Rectangle32x32.ico");
            this.imageList.Images.SetKeyName(2, "Pointer32x32.ico");
            this.imageList.Images.SetKeyName(3, "Ellipse32x32.ico");
            this.imageList.Images.SetKeyName(4, "PanHand.ico");
            this.imageList.Images.SetKeyName(5, "Pencil.ico");
            this.imageList.Images.SetKeyName(6, "Text23x32.ico");
            this.imageList.Images.SetKeyName(7, "Path32x32.ico");
            this.imageList.Images.SetKeyName(8, "image.png");
            // 
            // radioButton_rectangle
            // 
            this.radioButton_rectangle.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton_rectangle.ImageKey = "Rectangle32x32.ico";
            this.radioButton_rectangle.ImageList = this.imageList;
            this.radioButton_rectangle.Location = new System.Drawing.Point(69, 3);
            this.radioButton_rectangle.Name = "radioButton_rectangle";
            this.radioButton_rectangle.Size = new System.Drawing.Size(60, 60);
            this.radioButton_rectangle.TabIndex = 0;
            this.radioButton_rectangle.TabStop = true;
            this.radioButton_rectangle.UseVisualStyleBackColor = true;
            this.radioButton_rectangle.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton_line
            // 
            this.radioButton_line.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton_line.ImageKey = "Line32x32.ico";
            this.radioButton_line.ImageList = this.imageList;
            this.radioButton_line.Location = new System.Drawing.Point(135, 3);
            this.radioButton_line.Name = "radioButton_line";
            this.radioButton_line.Size = new System.Drawing.Size(60, 60);
            this.radioButton_line.TabIndex = 0;
            this.radioButton_line.TabStop = true;
            this.radioButton_line.UseVisualStyleBackColor = true;
            this.radioButton_line.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton_ellipse
            // 
            this.radioButton_ellipse.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton_ellipse.ImageIndex = 3;
            this.radioButton_ellipse.ImageList = this.imageList;
            this.radioButton_ellipse.Location = new System.Drawing.Point(201, 3);
            this.radioButton_ellipse.Name = "radioButton_ellipse";
            this.radioButton_ellipse.Size = new System.Drawing.Size(60, 60);
            this.radioButton_ellipse.TabIndex = 0;
            this.radioButton_ellipse.TabStop = true;
            this.radioButton_ellipse.UseVisualStyleBackColor = true;
            this.radioButton_ellipse.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton_pencil
            // 
            this.radioButton_pencil.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton_pencil.ImageKey = "Pencil.ico";
            this.radioButton_pencil.ImageList = this.imageList;
            this.radioButton_pencil.Location = new System.Drawing.Point(3, 69);
            this.radioButton_pencil.Name = "radioButton_pencil";
            this.radioButton_pencil.Size = new System.Drawing.Size(60, 60);
            this.radioButton_pencil.TabIndex = 0;
            this.radioButton_pencil.TabStop = true;
            this.radioButton_pencil.UseVisualStyleBackColor = true;
            this.radioButton_pencil.Visible = false;
            this.radioButton_pencil.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton_path
            // 
            this.radioButton_path.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton_path.ImageKey = "Path32x32.ico";
            this.radioButton_path.ImageList = this.imageList;
            this.radioButton_path.Location = new System.Drawing.Point(69, 69);
            this.radioButton_path.Name = "radioButton_path";
            this.radioButton_path.Size = new System.Drawing.Size(60, 60);
            this.radioButton_path.TabIndex = 0;
            this.radioButton_path.TabStop = true;
            this.radioButton_path.UseVisualStyleBackColor = true;
            this.radioButton_path.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton_text
            // 
            this.radioButton_text.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton_text.ImageKey = "Text23x32.ico";
            this.radioButton_text.ImageList = this.imageList;
            this.radioButton_text.Location = new System.Drawing.Point(135, 69);
            this.radioButton_text.Name = "radioButton_text";
            this.radioButton_text.Size = new System.Drawing.Size(60, 60);
            this.radioButton_text.TabIndex = 0;
            this.radioButton_text.TabStop = true;
            this.radioButton_text.UseVisualStyleBackColor = true;
            this.radioButton_text.Visible = false;
            this.radioButton_text.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton_pan
            // 
            this.radioButton_pan.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton_pan.ImageKey = "PanHand.ico";
            this.radioButton_pan.ImageList = this.imageList;
            this.radioButton_pan.Location = new System.Drawing.Point(201, 69);
            this.radioButton_pan.Name = "radioButton_pan";
            this.radioButton_pan.Size = new System.Drawing.Size(60, 60);
            this.radioButton_pan.TabIndex = 0;
            this.radioButton_pan.TabStop = true;
            this.radioButton_pan.UseVisualStyleBackColor = true;
            this.radioButton_pan.Click += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton_image
            // 
            this.radioButton_image.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton_image.ImageKey = "image.png";
            this.radioButton_image.ImageList = this.imageList;
            this.radioButton_image.Location = new System.Drawing.Point(3, 135);
            this.radioButton_image.Name = "radioButton_image";
            this.radioButton_image.Size = new System.Drawing.Size(60, 60);
            this.radioButton_image.TabIndex = 0;
            this.radioButton_image.TabStop = true;
            this.radioButton_image.UseVisualStyleBackColor = true;
            this.radioButton_image.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.SystemColors.Control;
            this.btnGravar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGravar.Image = ((System.Drawing.Image)(resources.GetObject("btnGravar.Image")));
            this.btnGravar.Location = new System.Drawing.Point(69, 135);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Padding = new System.Windows.Forms.Padding(5);
            this.btnGravar.Size = new System.Drawing.Size(60, 60);
            this.btnGravar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnGravar.TabIndex = 1;
            this.btnGravar.TabStop = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // ToolBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(289, 562);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(305, 601);
            this.Name = "ToolBox";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Desenho";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnGravar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton radioButton_line;
        private System.Windows.Forms.RadioButton radioButton_rectangle;
        private System.Windows.Forms.RadioButton radioButton_Pointer;
        private System.Windows.Forms.RadioButton radioButton_ellipse;
        private System.Windows.Forms.RadioButton radioButton_pan;
        private System.Windows.Forms.RadioButton radioButton_pencil;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.RadioButton radioButton_text;
        private System.Windows.Forms.RadioButton radioButton_path;
        private System.Windows.Forms.RadioButton radioButton_image;
        private System.Windows.Forms.PictureBox btnGravar;
    }
}