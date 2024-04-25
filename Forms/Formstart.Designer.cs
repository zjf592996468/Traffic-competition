namespace Traffic_competition
{
    partial class Formstart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formstart));
            this.pictureBoxsftlogo = new System.Windows.Forms.PictureBox();
            this.labelsftname = new System.Windows.Forms.Label();
            this.labelinitial = new System.Windows.Forms.Label();
            this.panelbox = new System.Windows.Forms.Panel();
            this.panelprogress = new System.Windows.Forms.Panel();
            this.timerprogress = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxsftlogo)).BeginInit();
            this.panelbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxsftlogo
            // 
            this.pictureBoxsftlogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxsftlogo.Image = global::Traffic_competition.Properties.Resources.交通路线_白128;
            this.pictureBoxsftlogo.Location = new System.Drawing.Point(50, 60);
            this.pictureBoxsftlogo.Name = "pictureBoxsftlogo";
            this.pictureBoxsftlogo.Size = new System.Drawing.Size(547, 150);
            this.pictureBoxsftlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxsftlogo.TabIndex = 0;
            this.pictureBoxsftlogo.TabStop = false;
            // 
            // labelsftname
            // 
            this.labelsftname.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelsftname.Font = new System.Drawing.Font("思源黑体 CN", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelsftname.ForeColor = System.Drawing.Color.White;
            this.labelsftname.Location = new System.Drawing.Point(50, 210);
            this.labelsftname.Name = "labelsftname";
            this.labelsftname.Size = new System.Drawing.Size(547, 60);
            this.labelsftname.TabIndex = 1;
            this.labelsftname.Text = "欢迎使用交叉口信号配时与车道设置协同优化软件";
            this.labelsftname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelinitial
            // 
            this.labelinitial.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelinitial.ForeColor = System.Drawing.Color.White;
            this.labelinitial.Location = new System.Drawing.Point(50, 270);
            this.labelinitial.Name = "labelinitial";
            this.labelinitial.Size = new System.Drawing.Size(547, 90);
            this.labelinitial.TabIndex = 2;
            this.labelinitial.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panelbox
            // 
            this.panelbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.panelbox.Controls.Add(this.panelprogress);
            this.panelbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelbox.Location = new System.Drawing.Point(50, 360);
            this.panelbox.Margin = new System.Windows.Forms.Padding(0);
            this.panelbox.Name = "panelbox";
            this.panelbox.Size = new System.Drawing.Size(547, 5);
            this.panelbox.TabIndex = 3;
            // 
            // panelprogress
            // 
            this.panelprogress.BackColor = System.Drawing.Color.White;
            this.panelprogress.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelprogress.Location = new System.Drawing.Point(0, 0);
            this.panelprogress.Margin = new System.Windows.Forms.Padding(0);
            this.panelprogress.Name = "panelprogress";
            this.panelprogress.Size = new System.Drawing.Size(0, 5);
            this.panelprogress.TabIndex = 0;
            // 
            // timerprogress
            // 
            this.timerprogress.Enabled = true;
            this.timerprogress.Interval = 15;
            this.timerprogress.Tick += new System.EventHandler(this.Timerprogress_Tick);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_RunWorkerCompleted);
            // 
            // Formstart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(647, 400);
            this.Controls.Add(this.panelbox);
            this.Controls.Add(this.labelinitial);
            this.Controls.Add(this.labelsftname);
            this.Controls.Add(this.pictureBoxsftlogo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("思源黑体 CN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Formstart";
            this.Padding = new System.Windows.Forms.Padding(50, 60, 50, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "关于本软件";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxsftlogo)).EndInit();
            this.panelbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxsftlogo;
        private System.Windows.Forms.Label labelsftname;
        private System.Windows.Forms.Label labelinitial;
        private System.Windows.Forms.Panel panelbox;
        private System.Windows.Forms.Panel panelprogress;
        private System.Windows.Forms.Timer timerprogress;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}