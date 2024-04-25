namespace Traffic_competition.UserControls
{
    partial class UC_info
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpinfo = new System.Windows.Forms.TableLayoutPanel();
            this.panelcenter = new System.Windows.Forms.Panel();
            this.labelmember = new System.Windows.Forms.Label();
            this.labelowner = new System.Windows.Forms.Label();
            this.panelschool = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelproject = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.pictureBoxlogo = new System.Windows.Forms.PictureBox();
            this.labelversion = new System.Windows.Forms.Label();
            this.tlpinfo.SuspendLayout();
            this.panelcenter.SuspendLayout();
            this.panelschool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpinfo
            // 
            this.tlpinfo.ColumnCount = 3;
            this.tlpinfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpinfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 700F));
            this.tlpinfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpinfo.Controls.Add(this.panelcenter, 1, 1);
            this.tlpinfo.Controls.Add(this.labelversion, 1, 2);
            this.tlpinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpinfo.Location = new System.Drawing.Point(0, 0);
            this.tlpinfo.Name = "tlpinfo";
            this.tlpinfo.RowCount = 3;
            this.tlpinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 650F));
            this.tlpinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tlpinfo.Size = new System.Drawing.Size(1420, 820);
            this.tlpinfo.TabIndex = 0;
            // 
            // panelcenter
            // 
            this.panelcenter.Controls.Add(this.labelmember);
            this.panelcenter.Controls.Add(this.labelowner);
            this.panelcenter.Controls.Add(this.panelschool);
            this.panelcenter.Controls.Add(this.labelproject);
            this.panelcenter.Controls.Add(this.labelname);
            this.panelcenter.Controls.Add(this.pictureBoxlogo);
            this.panelcenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcenter.Location = new System.Drawing.Point(360, 59);
            this.panelcenter.Margin = new System.Windows.Forms.Padding(0);
            this.panelcenter.Name = "panelcenter";
            this.panelcenter.Size = new System.Drawing.Size(700, 650);
            this.panelcenter.TabIndex = 0;
            // 
            // labelmember
            // 
            this.labelmember.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelmember.Location = new System.Drawing.Point(0, 570);
            this.labelmember.Name = "labelmember";
            this.labelmember.Size = new System.Drawing.Size(700, 40);
            this.labelmember.TabIndex = 5;
            this.labelmember.Text = "小组成员：佟朝阳    梅晓沛    王铭泽";
            this.labelmember.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelowner
            // 
            this.labelowner.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelowner.Font = new System.Drawing.Font("思源黑体 CN", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelowner.Location = new System.Drawing.Point(0, 490);
            this.labelowner.Name = "labelowner";
            this.labelowner.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.labelowner.Size = new System.Drawing.Size(700, 80);
            this.labelowner.TabIndex = 4;
            this.labelowner.Text = "作者：周基锋        指导老师：张鹏";
            this.labelowner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelschool
            // 
            this.panelschool.Controls.Add(this.pictureBox2);
            this.panelschool.Controls.Add(this.pictureBox1);
            this.panelschool.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelschool.Location = new System.Drawing.Point(0, 380);
            this.panelschool.Name = "panelschool";
            this.panelschool.Padding = new System.Windows.Forms.Padding(142, 0, 0, 0);
            this.panelschool.Size = new System.Drawing.Size(700, 110);
            this.panelschool.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::Traffic_competition.Properties.Resources.江苏大学红字;
            this.pictureBox2.Location = new System.Drawing.Point(267, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(275, 110);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Traffic_competition.Properties.Resources.school_125;
            this.pictureBox1.Location = new System.Drawing.Point(142, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelproject
            // 
            this.labelproject.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelproject.Font = new System.Drawing.Font("思源黑体 CN", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelproject.Location = new System.Drawing.Point(0, 270);
            this.labelproject.Name = "labelproject";
            this.labelproject.Padding = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.labelproject.Size = new System.Drawing.Size(700, 110);
            this.labelproject.TabIndex = 2;
            this.labelproject.Text = "2020交通科技大赛项目";
            this.labelproject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelname
            // 
            this.labelname.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelname.Font = new System.Drawing.Font("思源黑体 CN", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelname.Location = new System.Drawing.Point(0, 200);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(700, 70);
            this.labelname.TabIndex = 1;
            this.labelname.Text = "交叉口信号配时与车道设置协同优化软件";
            this.labelname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxlogo
            // 
            this.pictureBoxlogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxlogo.Image = global::Traffic_competition.Properties.Resources.交通路线_黑;
            this.pictureBoxlogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxlogo.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxlogo.Name = "pictureBoxlogo";
            this.pictureBoxlogo.Size = new System.Drawing.Size(700, 200);
            this.pictureBoxlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxlogo.TabIndex = 0;
            this.pictureBoxlogo.TabStop = false;
            // 
            // labelversion
            // 
            this.labelversion.AutoSize = true;
            this.labelversion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelversion.Font = new System.Drawing.Font("思源黑体 CN", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelversion.ForeColor = System.Drawing.Color.Gray;
            this.labelversion.Location = new System.Drawing.Point(363, 793);
            this.labelversion.Name = "labelversion";
            this.labelversion.Size = new System.Drawing.Size(694, 27);
            this.labelversion.TabIndex = 1;
            this.labelversion.Text = "版本：V1.1.0";
            this.labelversion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // UC_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpinfo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("思源黑体 CN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Name = "UC_info";
            this.Size = new System.Drawing.Size(1420, 820);
            this.tlpinfo.ResumeLayout(false);
            this.tlpinfo.PerformLayout();
            this.panelcenter.ResumeLayout(false);
            this.panelschool.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpinfo;
        private System.Windows.Forms.Panel panelcenter;
        private System.Windows.Forms.Label labelversion;
        private System.Windows.Forms.PictureBox pictureBoxlogo;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelproject;
        private System.Windows.Forms.Panel panelschool;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelmember;
        private System.Windows.Forms.Label labelowner;
    }
}
