namespace MyPaintAppWinForm
{
    partial class View
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.DrawMainPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PicBox = new System.Windows.Forms.PictureBox();
            this.BtnColor11 = new MyPaintAppWinForm.MyPersonalPictureBox();
            this.CircleButton = new MyPersonalCustomizeButton.MyPersonalButton();
            this.RectangleButton = new MyPersonalCustomizeButton.MyPersonalButton();
            this.LineButton = new MyPersonalCustomizeButton.MyPersonalButton();
            this.FillColorButton = new MyPersonalCustomizeButton.MyPersonalButton();
            this.ZoomInButton = new MyPersonalCustomizeButton.MyPersonalButton();
            this.ZoomOutButton = new MyPersonalCustomizeButton.MyPersonalButton();
            this.myPersonalButton1 = new MyPersonalCustomizeButton.MyPersonalButton();
            this.mainPanel.SuspendLayout();
            this.DrawMainPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnColor11)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(227)))), ((int)(((byte)(240)))));
            this.mainPanel.Controls.Add(this.DrawMainPanel);
            this.mainPanel.Controls.Add(this.tableLayoutPanel1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1200, 658);
            this.mainPanel.TabIndex = 3;
            // 
            // DrawMainPanel
            // 
            this.DrawMainPanel.Controls.Add(this.PicBox);
            this.DrawMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawMainPanel.Location = new System.Drawing.Point(0, 80);
            this.DrawMainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.DrawMainPanel.Name = "DrawMainPanel";
            this.DrawMainPanel.Padding = new System.Windows.Forms.Padding(5);
            this.DrawMainPanel.Size = new System.Drawing.Size(1200, 578);
            this.DrawMainPanel.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.tableLayoutPanel1.ColumnCount = 24;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.389774F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.389774F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.389774F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.738476F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.389774F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.389774F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.389774F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.738476F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.215425F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.738476F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.389774F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.738476F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.738476F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.738476F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.738476F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.738476F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.738476F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.738476F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.738476F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.738476F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.738476F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.389774F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.066181F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 9, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnColor11, 12, 1);
            this.tableLayoutPanel1.Controls.Add(this.CircleButton, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.RectangleButton, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.LineButton, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.FillColorButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.ZoomInButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ZoomOutButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.myPersonalButton1, 9, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1200, 80);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.label3, 3);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(10, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Zoom";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.label4, 3);
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(270, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Show or hide";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(530, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Display";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PicBox
            // 
            this.PicBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PicBox.Location = new System.Drawing.Point(5, 5);
            this.PicBox.Margin = new System.Windows.Forms.Padding(0);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(1190, 568);
            this.PicBox.TabIndex = 0;
            this.PicBox.TabStop = false;
            this.PicBox.Click += new System.EventHandler(this.PicBox_Click);
            // 
            // BtnColor11
            // 
            this.BtnColor11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnColor11.BackColor = System.Drawing.Color.White;
            this.BtnColor11.BordeGradientBottom = System.Drawing.Color.CadetBlue;
            this.BtnColor11.BorderGradientBottom = System.Drawing.Color.DodgerBlue;
            this.BtnColor11.BorderRadius = 40;
            this.BtnColor11.BorderSize = 0;
            this.BtnColor11.GradientAngle = 90F;
            this.BtnColor11.Location = new System.Drawing.Point(746, 35);
            this.BtnColor11.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.BtnColor11.Name = "BtnColor11";
            this.BtnColor11.Size = new System.Drawing.Size(10, 10);
            this.BtnColor11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnColor11.TabIndex = 21;
            this.BtnColor11.TabStop = false;
            // 
            // CircleButton
            // 
            this.CircleButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CircleButton.BackColor = System.Drawing.Color.Transparent;
            this.CircleButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.CircleButton.BorderColor = System.Drawing.Color.White;
            this.CircleButton.BorderRadius = 1;
            this.CircleButton.BorderSize = 0;
            this.CircleButton.FlatAppearance.BorderSize = 0;
            this.CircleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CircleButton.ForeColor = System.Drawing.Color.White;
            this.CircleButton.Image = global::MyPaintAppWinForm.Properties.Resources.add_bookmark_50;
            this.CircleButton.Location = new System.Drawing.Point(434, 1);
            this.CircleButton.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.CircleButton.Name = "CircleButton";
            this.tableLayoutPanel1.SetRowSpan(this.CircleButton, 2);
            this.CircleButton.Size = new System.Drawing.Size(51, 57);
            this.CircleButton.TabIndex = 8;
            this.CircleButton.TextColor = System.Drawing.Color.White;
            this.CircleButton.UseVisualStyleBackColor = false;
            // 
            // RectangleButton
            // 
            this.RectangleButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RectangleButton.BackColor = System.Drawing.Color.Transparent;
            this.RectangleButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.RectangleButton.BorderColor = System.Drawing.Color.White;
            this.RectangleButton.BorderRadius = 1;
            this.RectangleButton.BorderSize = 0;
            this.RectangleButton.FlatAppearance.BorderSize = 0;
            this.RectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RectangleButton.ForeColor = System.Drawing.Color.White;
            this.RectangleButton.Image = global::MyPaintAppWinForm.Properties.Resources.loading_bar_30;
            this.RectangleButton.Location = new System.Drawing.Point(358, 1);
            this.RectangleButton.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.RectangleButton.Name = "RectangleButton";
            this.tableLayoutPanel1.SetRowSpan(this.RectangleButton, 2);
            this.RectangleButton.Size = new System.Drawing.Size(51, 57);
            this.RectangleButton.TabIndex = 7;
            this.RectangleButton.TextColor = System.Drawing.Color.White;
            this.RectangleButton.UseVisualStyleBackColor = false;
            // 
            // LineButton
            // 
            this.LineButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LineButton.BackColor = System.Drawing.Color.Transparent;
            this.LineButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.LineButton.BorderColor = System.Drawing.Color.White;
            this.LineButton.BorderRadius = 1;
            this.LineButton.BorderSize = 0;
            this.LineButton.FlatAppearance.BorderSize = 0;
            this.LineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LineButton.ForeColor = System.Drawing.Color.White;
            this.LineButton.Image = global::MyPaintAppWinForm.Properties.Resources.ruler_30;
            this.LineButton.Location = new System.Drawing.Point(282, 1);
            this.LineButton.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.LineButton.Name = "LineButton";
            this.tableLayoutPanel1.SetRowSpan(this.LineButton, 2);
            this.LineButton.Size = new System.Drawing.Size(51, 57);
            this.LineButton.TabIndex = 6;
            this.LineButton.TextColor = System.Drawing.Color.White;
            this.LineButton.UseVisualStyleBackColor = false;
            // 
            // FillColorButton
            // 
            this.FillColorButton.BackColor = System.Drawing.Color.Transparent;
            this.FillColorButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.FillColorButton.BorderColor = System.Drawing.Color.White;
            this.FillColorButton.BorderRadius = 1;
            this.FillColorButton.BorderSize = 0;
            this.FillColorButton.FlatAppearance.BorderSize = 0;
            this.FillColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FillColorButton.ForeColor = System.Drawing.Color.White;
            this.FillColorButton.Image = global::MyPaintAppWinForm.Properties.Resources.expand_collapse_arrows_30;
            this.FillColorButton.Location = new System.Drawing.Point(172, 0);
            this.FillColorButton.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.FillColorButton.Name = "FillColorButton";
            this.tableLayoutPanel1.SetRowSpan(this.FillColorButton, 2);
            this.FillColorButton.Size = new System.Drawing.Size(51, 57);
            this.FillColorButton.TabIndex = 4;
            this.FillColorButton.TextColor = System.Drawing.Color.White;
            this.FillColorButton.UseVisualStyleBackColor = false;
            // 
            // ZoomInButton
            // 
            this.ZoomInButton.BackColor = System.Drawing.Color.Transparent;
            this.ZoomInButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.ZoomInButton.BorderColor = System.Drawing.Color.White;
            this.ZoomInButton.BorderRadius = 1;
            this.ZoomInButton.BorderSize = 0;
            this.ZoomInButton.FlatAppearance.BorderSize = 0;
            this.ZoomInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZoomInButton.ForeColor = System.Drawing.Color.White;
            this.ZoomInButton.Image = global::MyPaintAppWinForm.Properties.Resources.zoom_in_30;
            this.ZoomInButton.Location = new System.Drawing.Point(20, 0);
            this.ZoomInButton.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ZoomInButton.Name = "ZoomInButton";
            this.tableLayoutPanel1.SetRowSpan(this.ZoomInButton, 2);
            this.ZoomInButton.Size = new System.Drawing.Size(51, 57);
            this.ZoomInButton.TabIndex = 2;
            this.ZoomInButton.TextColor = System.Drawing.Color.White;
            this.ZoomInButton.UseVisualStyleBackColor = false;
            this.ZoomInButton.Click += new System.EventHandler(this.ZoomInButton_Click);
            // 
            // ZoomOutButton
            // 
            this.ZoomOutButton.BackColor = System.Drawing.Color.Transparent;
            this.ZoomOutButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.ZoomOutButton.BorderColor = System.Drawing.Color.White;
            this.ZoomOutButton.BorderRadius = 1;
            this.ZoomOutButton.BorderSize = 0;
            this.ZoomOutButton.FlatAppearance.BorderSize = 0;
            this.ZoomOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZoomOutButton.ForeColor = System.Drawing.Color.White;
            this.ZoomOutButton.Image = global::MyPaintAppWinForm.Properties.Resources.zoom_out_30;
            this.ZoomOutButton.Location = new System.Drawing.Point(96, 0);
            this.ZoomOutButton.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ZoomOutButton.Name = "ZoomOutButton";
            this.tableLayoutPanel1.SetRowSpan(this.ZoomOutButton, 2);
            this.ZoomOutButton.Size = new System.Drawing.Size(51, 57);
            this.ZoomOutButton.TabIndex = 3;
            this.ZoomOutButton.TextColor = System.Drawing.Color.White;
            this.ZoomOutButton.UseVisualStyleBackColor = false;
            this.ZoomOutButton.Click += new System.EventHandler(this.ZoomOutButton_Click);
            // 
            // myPersonalButton1
            // 
            this.myPersonalButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.myPersonalButton1.BackColor = System.Drawing.Color.Transparent;
            this.myPersonalButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.myPersonalButton1.BorderColor = System.Drawing.Color.White;
            this.myPersonalButton1.BorderRadius = 1;
            this.myPersonalButton1.BorderSize = 0;
            this.myPersonalButton1.FlatAppearance.BorderSize = 0;
            this.myPersonalButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myPersonalButton1.ForeColor = System.Drawing.Color.White;
            this.myPersonalButton1.Image = global::MyPaintAppWinForm.Properties.Resources.full_screen_70;
            this.myPersonalButton1.Location = new System.Drawing.Point(547, 1);
            this.myPersonalButton1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.myPersonalButton1.Name = "myPersonalButton1";
            this.tableLayoutPanel1.SetRowSpan(this.myPersonalButton1, 2);
            this.myPersonalButton1.Size = new System.Drawing.Size(62, 57);
            this.myPersonalButton1.TabIndex = 34;
            this.myPersonalButton1.TextColor = System.Drawing.Color.White;
            this.myPersonalButton1.UseVisualStyleBackColor = false;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "View";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.mainPanel.ResumeLayout(false);
            this.DrawMainPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnColor11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel DrawMainPanel;
        private System.Windows.Forms.PictureBox PicBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private MyPersonalPictureBox BtnColor11;
        private MyPersonalCustomizeButton.MyPersonalButton CircleButton;
        private MyPersonalCustomizeButton.MyPersonalButton RectangleButton;
        private MyPersonalCustomizeButton.MyPersonalButton LineButton;
        private MyPersonalCustomizeButton.MyPersonalButton FillColorButton;
        private MyPersonalCustomizeButton.MyPersonalButton ZoomInButton;
        private MyPersonalCustomizeButton.MyPersonalButton ZoomOutButton;
        private MyPersonalCustomizeButton.MyPersonalButton myPersonalButton1;
    }
}

