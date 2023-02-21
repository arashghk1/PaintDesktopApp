namespace Paint
{
    partial class Paint_MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paint_MainForm));
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelButton = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pic = new System.Windows.Forms.PictureBox();
            this.btn_Line = new System.Windows.Forms.Button();
            this.btn_RoundedSquare = new System.Windows.Forms.Button();
            this.btn_Circle = new System.Windows.Forms.Button();
            this.btn_Eraiser = new System.Windows.Forms.Button();
            this.btn_Pencil = new System.Windows.Forms.Button();
            this.btn_FillColor = new System.Windows.Forms.Button();
            this.btn_ColorPicker = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelHeader.SuspendLayout();
            this.PanelButton.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.PanelHeader.Controls.Add(this.label1);
            this.PanelHeader.Controls.Add(this.pictureBox2);
            this.PanelHeader.Controls.Add(this.pictureBox1);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(1185, 63);
            this.PanelHeader.TabIndex = 1;
            this.PanelHeader.DragOver += new System.Windows.Forms.DragEventHandler(this.PanelHeader_DragOver);
            this.PanelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseDown);
            this.PanelHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(81, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "The Paint Application";
            // 
            // PanelButton
            // 
            this.PanelButton.Controls.Add(this.tableLayoutPanel1);
            this.PanelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelButton.Location = new System.Drawing.Point(0, 63);
            this.PanelButton.Name = "PanelButton";
            this.PanelButton.Size = new System.Drawing.Size(1185, 124);
            this.PanelButton.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Clear, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Line, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_RoundedSquare, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Circle, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Eraiser, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Pencil, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_FillColor, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_ColorPicker, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1185, 124);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Clear.FlatAppearance.BorderSize = 0;
            this.btn_Clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.Brown;
            this.btn_Clear.Location = new System.Drawing.Point(1039, 3);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(143, 118);
            this.btn_Clear.TabIndex = 0;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.Pic);
            this.ContentPanel.Controls.Add(this.panel1);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(0, 187);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(1185, 615);
            this.ContentPanel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1185, 10);
            this.panel1.TabIndex = 0;
            // 
            // Pic
            // 
            this.Pic.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.Pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pic.Location = new System.Drawing.Point(0, 10);
            this.Pic.Name = "Pic";
            this.Pic.Size = new System.Drawing.Size(1185, 605);
            this.Pic.TabIndex = 1;
            this.Pic.TabStop = false;
            this.Pic.Paint += new System.Windows.Forms.PaintEventHandler(this.Pic_Paint);
            this.Pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseClick);
            this.Pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseDown);
            this.Pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseMove);
            this.Pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseUp);
            // 
            // btn_Line
            // 
            this.btn_Line.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Line.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Line.FlatAppearance.BorderSize = 0;
            this.btn_Line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Line.Image = global::Paint.Properties.Resources.line;
            this.btn_Line.Location = new System.Drawing.Point(891, 3);
            this.btn_Line.Name = "btn_Line";
            this.btn_Line.Size = new System.Drawing.Size(142, 118);
            this.btn_Line.TabIndex = 0;
            this.btn_Line.UseVisualStyleBackColor = true;
            this.btn_Line.Click += new System.EventHandler(this.btn_Line_Click);
            // 
            // btn_RoundedSquare
            // 
            this.btn_RoundedSquare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RoundedSquare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_RoundedSquare.FlatAppearance.BorderSize = 0;
            this.btn_RoundedSquare.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_RoundedSquare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_RoundedSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RoundedSquare.Image = global::Paint.Properties.Resources.rectangle;
            this.btn_RoundedSquare.Location = new System.Drawing.Point(743, 3);
            this.btn_RoundedSquare.Name = "btn_RoundedSquare";
            this.btn_RoundedSquare.Size = new System.Drawing.Size(142, 118);
            this.btn_RoundedSquare.TabIndex = 0;
            this.btn_RoundedSquare.UseVisualStyleBackColor = true;
            this.btn_RoundedSquare.Click += new System.EventHandler(this.btn_RoundedSquare_Click);
            // 
            // btn_Circle
            // 
            this.btn_Circle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Circle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Circle.FlatAppearance.BorderSize = 0;
            this.btn_Circle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Circle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Circle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Circle.Image = global::Paint.Properties.Resources.circled;
            this.btn_Circle.Location = new System.Drawing.Point(595, 3);
            this.btn_Circle.Name = "btn_Circle";
            this.btn_Circle.Size = new System.Drawing.Size(142, 118);
            this.btn_Circle.TabIndex = 0;
            this.btn_Circle.UseVisualStyleBackColor = true;
            this.btn_Circle.Click += new System.EventHandler(this.btn_Circle_Click);
            // 
            // btn_Eraiser
            // 
            this.btn_Eraiser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Eraiser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Eraiser.FlatAppearance.BorderSize = 0;
            this.btn_Eraiser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Eraiser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Eraiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eraiser.Image = global::Paint.Properties.Resources.eraser;
            this.btn_Eraiser.Location = new System.Drawing.Point(447, 3);
            this.btn_Eraiser.Name = "btn_Eraiser";
            this.btn_Eraiser.Size = new System.Drawing.Size(142, 118);
            this.btn_Eraiser.TabIndex = 0;
            this.btn_Eraiser.UseVisualStyleBackColor = true;
            this.btn_Eraiser.Click += new System.EventHandler(this.btn_Eraiser_Click);
            // 
            // btn_Pencil
            // 
            this.btn_Pencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Pencil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Pencil.FlatAppearance.BorderSize = 0;
            this.btn_Pencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Pencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pencil.Image = global::Paint.Properties.Resources.pencil_drawing;
            this.btn_Pencil.Location = new System.Drawing.Point(299, 3);
            this.btn_Pencil.Name = "btn_Pencil";
            this.btn_Pencil.Size = new System.Drawing.Size(142, 118);
            this.btn_Pencil.TabIndex = 0;
            this.btn_Pencil.UseVisualStyleBackColor = true;
            this.btn_Pencil.Click += new System.EventHandler(this.btn_Pencil_Click);
            // 
            // btn_FillColor
            // 
            this.btn_FillColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_FillColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_FillColor.FlatAppearance.BorderSize = 0;
            this.btn_FillColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_FillColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_FillColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FillColor.Image = global::Paint.Properties.Resources.fill_color;
            this.btn_FillColor.Location = new System.Drawing.Point(151, 3);
            this.btn_FillColor.Name = "btn_FillColor";
            this.btn_FillColor.Size = new System.Drawing.Size(142, 118);
            this.btn_FillColor.TabIndex = 0;
            this.btn_FillColor.UseVisualStyleBackColor = true;
            this.btn_FillColor.Click += new System.EventHandler(this.btn_FillColor_Click);
            // 
            // btn_ColorPicker
            // 
            this.btn_ColorPicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ColorPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ColorPicker.FlatAppearance.BorderSize = 0;
            this.btn_ColorPicker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_ColorPicker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_ColorPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ColorPicker.Image = global::Paint.Properties.Resources.color_picker;
            this.btn_ColorPicker.Location = new System.Drawing.Point(3, 3);
            this.btn_ColorPicker.Name = "btn_ColorPicker";
            this.btn_ColorPicker.Size = new System.Drawing.Size(142, 118);
            this.btn_ColorPicker.TabIndex = 0;
            this.btn_ColorPicker.UseVisualStyleBackColor = true;
            this.btn_ColorPicker.Click += new System.EventHandler(this.btn_ColorPicker_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Image = global::Paint.Properties.Resources.paint_Header;
            this.pictureBox2.Location = new System.Drawing.Point(4, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Paint.Properties.Resources.Close;
            this.pictureBox1.Location = new System.Drawing.Point(1118, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Paint_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1185, 802);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.PanelButton);
            this.Controls.Add(this.PanelHeader);
            this.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Paint_MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint Application";
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.PanelButton.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ContentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Panel PanelButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Line;
        private System.Windows.Forms.Button btn_RoundedSquare;
        private System.Windows.Forms.Button btn_Circle;
        private System.Windows.Forms.Button btn_Eraiser;
        private System.Windows.Forms.Button btn_Pencil;
        private System.Windows.Forms.Button btn_FillColor;
        private System.Windows.Forms.Button btn_ColorPicker;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Pic;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

