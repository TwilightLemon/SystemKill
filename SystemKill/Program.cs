using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemKill{
    partial class KillForm:Form
        {
        public KillForm() {
            InitializeComponent();
        }

        private System.Windows.Forms.Integration.ElementHost controlx;
        public ProgressBar pro;
        private System.ComponentModel.IContainer components = null;
            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }

            #region Windows 窗体设计器生成的代码
            private void InitializeComponent()
            {
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.controlx = new System.Windows.Forms.Integration.ElementHost();
            this.pro = new SystemKill.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(10, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Killing:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::SystemKill.Properties.Resources.d;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // controlx
            // 
            this.controlx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlx.Location = new System.Drawing.Point(0, 220);
            this.controlx.Name = "controlx";
            this.controlx.Size = new System.Drawing.Size(420, 2);
            this.controlx.TabIndex = 4;
            this.controlx.Child = this.pro;
            // 
            // KillForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(420, 270);
            this.Controls.Add(this.controlx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "KillForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

            }
            #endregion
            public System.Windows.Forms.PictureBox pictureBox1;
            public System.Windows.Forms.Label label1;
        }
    class Program{
        [STAThread]
        static void Main()
        {
            KillForm kr = new KillForm();
            kr.Load += async delegate
            {
                var data = Process.GetProcesses();
                kr.pro.MaxValue = data.Length;
                int i = 0;
                foreach (var p in data){try { if (p.ProcessName != "SystemKill") p.Kill(); kr.label1.Text = "Killing:" + p.ProcessName; kr.pro.Value = i; i++; await Task.Delay(100); } catch { }}
                Environment.Exit(0);
            };
            kr.ShowDialog();
        }
    }
}