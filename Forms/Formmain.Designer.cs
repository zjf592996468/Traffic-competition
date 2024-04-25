namespace Traffic_competition
{
    partial class Formmain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formmain));
            this.panelside = new System.Windows.Forms.Panel();
            this.buttoninfo = new System.Windows.Forms.Button();
            this.buttonhome = new System.Windows.Forms.Button();
            this.panellogo = new System.Windows.Forms.Panel();
            this.pictureBoxlogo = new System.Windows.Forms.PictureBox();
            this.labeltitle = new System.Windows.Forms.Label();
            this.paneltop = new System.Windows.Forms.Panel();
            this.buttonmin = new System.Windows.Forms.Button();
            this.buttonmax = new System.Windows.Forms.Button();
            this.buttonclose = new System.Windows.Forms.Button();
            this.toolTipmin = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipmax = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipclose = new System.Windows.Forms.ToolTip(this.components);
            this.panelmain = new System.Windows.Forms.Panel();
            this.panelhome = new System.Windows.Forms.Panel();
            this.paneltopline = new System.Windows.Forms.Panel();
            this.topline = new System.Windows.Forms.Panel();
            this.panelbottom = new System.Windows.Forms.Panel();
            this.buttonback = new System.Windows.Forms.Button();
            this.buttonnext = new System.Windows.Forms.Button();
            this.paneltitle = new System.Windows.Forms.Panel();
            this.labelunit = new System.Windows.Forms.Label();
            this.labelhometitle = new System.Windows.Forms.Label();
            this.panelside.SuspendLayout();
            this.panellogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlogo)).BeginInit();
            this.paneltop.SuspendLayout();
            this.panelmain.SuspendLayout();
            this.paneltopline.SuspendLayout();
            this.panelbottom.SuspendLayout();
            this.paneltitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelside
            // 
            this.panelside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.panelside.Controls.Add(this.buttoninfo);
            this.panelside.Controls.Add(this.buttonhome);
            this.panelside.Controls.Add(this.panellogo);
            this.panelside.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelside.Location = new System.Drawing.Point(0, 0);
            this.panelside.Name = "panelside";
            this.panelside.Size = new System.Drawing.Size(180, 900);
            this.panelside.TabIndex = 0;
            // 
            // buttoninfo
            // 
            this.buttoninfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttoninfo.FlatAppearance.BorderSize = 0;
            this.buttoninfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(64)))), ((int)(((byte)(120)))));
            this.buttoninfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(64)))), ((int)(((byte)(120)))));
            this.buttoninfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoninfo.Font = new System.Drawing.Font("思源黑体 CN", 13F);
            this.buttoninfo.ForeColor = System.Drawing.Color.White;
            this.buttoninfo.Image = global::Traffic_competition.Properties.Resources.icons8_info_64px_1;
            this.buttoninfo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttoninfo.Location = new System.Drawing.Point(0, 260);
            this.buttoninfo.Name = "buttoninfo";
            this.buttoninfo.Size = new System.Drawing.Size(180, 180);
            this.buttoninfo.TabIndex = 2;
            this.buttoninfo.TabStop = false;
            this.buttoninfo.Text = "关于";
            this.buttoninfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttoninfo.UseVisualStyleBackColor = true;
            this.buttoninfo.Click += new System.EventHandler(this.Buttoninfo_Click);
            // 
            // buttonhome
            // 
            this.buttonhome.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonhome.FlatAppearance.BorderSize = 0;
            this.buttonhome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(64)))), ((int)(((byte)(120)))));
            this.buttonhome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(64)))), ((int)(((byte)(120)))));
            this.buttonhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonhome.Font = new System.Drawing.Font("思源黑体 CN", 13F);
            this.buttonhome.ForeColor = System.Drawing.Color.White;
            this.buttonhome.Image = global::Traffic_competition.Properties.Resources.icons8_home_64px_2;
            this.buttonhome.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonhome.Location = new System.Drawing.Point(0, 80);
            this.buttonhome.Name = "buttonhome";
            this.buttonhome.Size = new System.Drawing.Size(180, 180);
            this.buttonhome.TabIndex = 0;
            this.buttonhome.TabStop = false;
            this.buttonhome.Text = "开始";
            this.buttonhome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonhome.UseVisualStyleBackColor = true;
            this.buttonhome.Click += new System.EventHandler(this.Buttonhome_Click);
            // 
            // panellogo
            // 
            this.panellogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.panellogo.Controls.Add(this.pictureBoxlogo);
            this.panellogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellogo.Location = new System.Drawing.Point(0, 0);
            this.panellogo.Name = "panellogo";
            this.panellogo.Padding = new System.Windows.Forms.Padding(8);
            this.panellogo.Size = new System.Drawing.Size(180, 80);
            this.panellogo.TabIndex = 0;
            // 
            // pictureBoxlogo
            // 
            this.pictureBoxlogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxlogo.Image = global::Traffic_competition.Properties.Resources.交通路线_白64;
            this.pictureBoxlogo.Location = new System.Drawing.Point(8, 8);
            this.pictureBoxlogo.Name = "pictureBoxlogo";
            this.pictureBoxlogo.Size = new System.Drawing.Size(164, 64);
            this.pictureBoxlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxlogo.TabIndex = 1;
            this.pictureBoxlogo.TabStop = false;
            // 
            // labeltitle
            // 
            this.labeltitle.BackColor = System.Drawing.Color.White;
            this.labeltitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.labeltitle.Font = new System.Drawing.Font("思源黑体 CN", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labeltitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.labeltitle.Location = new System.Drawing.Point(30, 0);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(740, 80);
            this.labeltitle.TabIndex = 2;
            this.labeltitle.Text = "交叉口信号配时与车道设置协同优化软件";
            this.labeltitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labeltitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Labeltitle_MouseDown);
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.White;
            this.paneltop.Controls.Add(this.buttonmin);
            this.paneltop.Controls.Add(this.buttonmax);
            this.paneltop.Controls.Add(this.labeltitle);
            this.paneltop.Controls.Add(this.buttonclose);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(180, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.paneltop.Size = new System.Drawing.Size(1420, 80);
            this.paneltop.TabIndex = 1;
            this.paneltop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Paneltop_MouseDown);
            // 
            // buttonmin
            // 
            this.buttonmin.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonmin.FlatAppearance.BorderSize = 0;
            this.buttonmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.buttonmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonmin.Image = global::Traffic_competition.Properties.Resources.icons8_minimize_window_32px;
            this.buttonmin.Location = new System.Drawing.Point(1180, 0);
            this.buttonmin.Name = "buttonmin";
            this.buttonmin.Size = new System.Drawing.Size(80, 80);
            this.buttonmin.TabIndex = 0;
            this.buttonmin.TabStop = false;
            this.toolTipmin.SetToolTip(this.buttonmin, "最小化");
            this.buttonmin.UseVisualStyleBackColor = true;
            this.buttonmin.Click += new System.EventHandler(this.Buttonmin_Click);
            // 
            // buttonmax
            // 
            this.buttonmax.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonmax.FlatAppearance.BorderSize = 0;
            this.buttonmax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.buttonmax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonmax.Font = new System.Drawing.Font("思源黑体 CN", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonmax.Image = global::Traffic_competition.Properties.Resources.icons8_enlarge_32px;
            this.buttonmax.Location = new System.Drawing.Point(1260, 0);
            this.buttonmax.Name = "buttonmax";
            this.buttonmax.Size = new System.Drawing.Size(80, 80);
            this.buttonmax.TabIndex = 1;
            this.buttonmax.TabStop = false;
            this.toolTipmax.SetToolTip(this.buttonmax, "最大化");
            this.buttonmax.UseVisualStyleBackColor = true;
            this.buttonmax.Click += new System.EventHandler(this.Buttonmax_Click);
            // 
            // buttonclose
            // 
            this.buttonclose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonclose.FlatAppearance.BorderSize = 0;
            this.buttonclose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.buttonclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonclose.Image = global::Traffic_competition.Properties.Resources.icons8_shutdown_32px_3;
            this.buttonclose.Location = new System.Drawing.Point(1340, 0);
            this.buttonclose.Name = "buttonclose";
            this.buttonclose.Size = new System.Drawing.Size(80, 80);
            this.buttonclose.TabIndex = 2;
            this.buttonclose.TabStop = false;
            this.toolTipclose.SetToolTip(this.buttonclose, "关闭");
            this.buttonclose.UseVisualStyleBackColor = true;
            this.buttonclose.Click += new System.EventHandler(this.Buttonclose_Click);
            this.buttonclose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Buttonclose_MouseDown);
            this.buttonclose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Buttonclose_MouseMove);
            // 
            // panelmain
            // 
            this.panelmain.Controls.Add(this.panelhome);
            this.panelmain.Controls.Add(this.paneltopline);
            this.panelmain.Controls.Add(this.panelbottom);
            this.panelmain.Controls.Add(this.paneltitle);
            this.panelmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmain.Location = new System.Drawing.Point(180, 80);
            this.panelmain.Name = "panelmain";
            this.panelmain.Size = new System.Drawing.Size(1420, 820);
            this.panelmain.TabIndex = 4;
            // 
            // panelhome
            // 
            this.panelhome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelhome.Location = new System.Drawing.Point(0, 70);
            this.panelhome.Name = "panelhome";
            this.panelhome.Size = new System.Drawing.Size(1420, 600);
            this.panelhome.TabIndex = 11;
            // 
            // paneltopline
            // 
            this.paneltopline.Controls.Add(this.topline);
            this.paneltopline.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltopline.Location = new System.Drawing.Point(0, 68);
            this.paneltopline.Name = "paneltopline";
            this.paneltopline.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.paneltopline.Size = new System.Drawing.Size(1420, 2);
            this.paneltopline.TabIndex = 10;
            // 
            // topline
            // 
            this.topline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(187)))), ((int)(((byte)(200)))));
            this.topline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topline.Location = new System.Drawing.Point(30, 0);
            this.topline.Name = "topline";
            this.topline.Size = new System.Drawing.Size(1360, 2);
            this.topline.TabIndex = 0;
            // 
            // panelbottom
            // 
            this.panelbottom.Controls.Add(this.buttonback);
            this.panelbottom.Controls.Add(this.buttonnext);
            this.panelbottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelbottom.Location = new System.Drawing.Point(0, 670);
            this.panelbottom.Name = "panelbottom";
            this.panelbottom.Padding = new System.Windows.Forms.Padding(80, 0, 80, 30);
            this.panelbottom.Size = new System.Drawing.Size(1420, 150);
            this.panelbottom.TabIndex = 9;
            // 
            // buttonback
            // 
            this.buttonback.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonback.FlatAppearance.BorderSize = 0;
            this.buttonback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonback.Font = new System.Drawing.Font("思源黑体 CN", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonback.ForeColor = System.Drawing.Color.DimGray;
            this.buttonback.Image = global::Traffic_competition.Properties.Resources.icons8_back_96px;
            this.buttonback.Location = new System.Drawing.Point(80, 0);
            this.buttonback.Name = "buttonback";
            this.buttonback.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.buttonback.Size = new System.Drawing.Size(120, 120);
            this.buttonback.TabIndex = 2;
            this.buttonback.TabStop = false;
            this.buttonback.Text = "上一步";
            this.buttonback.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonback.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonback.UseVisualStyleBackColor = true;
            this.buttonback.Visible = false;
            this.buttonback.Click += new System.EventHandler(this.Buttonback_Click);
            // 
            // buttonnext
            // 
            this.buttonnext.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonnext.FlatAppearance.BorderSize = 0;
            this.buttonnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonnext.Font = new System.Drawing.Font("思源黑体 CN", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonnext.ForeColor = System.Drawing.Color.DimGray;
            this.buttonnext.Image = global::Traffic_competition.Properties.Resources.icons8_forward_96px;
            this.buttonnext.Location = new System.Drawing.Point(1220, 0);
            this.buttonnext.Name = "buttonnext";
            this.buttonnext.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.buttonnext.Size = new System.Drawing.Size(120, 120);
            this.buttonnext.TabIndex = 1;
            this.buttonnext.TabStop = false;
            this.buttonnext.Text = "   下一步";
            this.buttonnext.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonnext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonnext.UseVisualStyleBackColor = true;
            this.buttonnext.Click += new System.EventHandler(this.Buttonnext_Click);
            // 
            // paneltitle
            // 
            this.paneltitle.Controls.Add(this.labelunit);
            this.paneltitle.Controls.Add(this.labelhometitle);
            this.paneltitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitle.Location = new System.Drawing.Point(0, 0);
            this.paneltitle.Name = "paneltitle";
            this.paneltitle.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.paneltitle.Size = new System.Drawing.Size(1420, 68);
            this.paneltitle.TabIndex = 2;
            // 
            // labelunit
            // 
            this.labelunit.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelunit.Font = new System.Drawing.Font("思源黑体 CN", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelunit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelunit.Location = new System.Drawing.Point(1190, 0);
            this.labelunit.Name = "labelunit";
            this.labelunit.Size = new System.Drawing.Size(200, 68);
            this.labelunit.TabIndex = 1;
            this.labelunit.Text = "单位：辆/小时";
            this.labelunit.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.labelunit.Visible = false;
            // 
            // labelhometitle
            // 
            this.labelhometitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelhometitle.Font = new System.Drawing.Font("思源黑体 CN", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelhometitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelhometitle.Location = new System.Drawing.Point(30, 0);
            this.labelhometitle.Name = "labelhometitle";
            this.labelhometitle.Size = new System.Drawing.Size(300, 68);
            this.labelhometitle.TabIndex = 0;
            this.labelhometitle.Text = "建立道路模型";
            this.labelhometitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Formmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.panelmain);
            this.Controls.Add(this.paneltop);
            this.Controls.Add(this.panelside);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("思源黑体 CN", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Formmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "交叉口信号配时与车道设置协同优化软件";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Formmain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Formmain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Formmain_MouseUp);
            this.panelside.ResumeLayout(false);
            this.panellogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlogo)).EndInit();
            this.paneltop.ResumeLayout(false);
            this.panelmain.ResumeLayout(false);
            this.paneltopline.ResumeLayout(false);
            this.panelbottom.ResumeLayout(false);
            this.paneltitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelside;
        private System.Windows.Forms.PictureBox pictureBoxlogo;
        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.Panel panellogo;
        private System.Windows.Forms.Button buttoninfo;
        private System.Windows.Forms.Button buttonhome;
        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Button buttonmin;
        private System.Windows.Forms.Button buttonmax;
        private System.Windows.Forms.Button buttonclose;
        private System.Windows.Forms.ToolTip toolTipmin;
        private System.Windows.Forms.ToolTip toolTipmax;
        private System.Windows.Forms.ToolTip toolTipclose;
        private System.Windows.Forms.Panel panelmain;
        private System.Windows.Forms.Panel paneltitle;
        private System.Windows.Forms.Label labelhometitle;
        private System.Windows.Forms.Panel panelbottom;
        private System.Windows.Forms.Button buttonback;
        private System.Windows.Forms.Button buttonnext;
        private System.Windows.Forms.Label labelunit;
        private System.Windows.Forms.Panel paneltopline;
        private System.Windows.Forms.Panel topline;
        private System.Windows.Forms.Panel panelhome;
    }
}

