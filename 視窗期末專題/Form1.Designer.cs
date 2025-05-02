
namespace 視窗期末專題
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.重新開始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.關卡選擇ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.一ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.二ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.三ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.說明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.a是向左走ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.d是向右走ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.space是翻轉地圖ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.地圖物件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.史萊姆是您操控的角色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.雪怪是終點ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.透明箱子翻轉後才能推歐ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.重新開始ToolStripMenuItem,
            this.關卡選擇ToolStripMenuItem,
            this.說明ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(897, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 重新開始ToolStripMenuItem
            // 
            this.重新開始ToolStripMenuItem.Name = "重新開始ToolStripMenuItem";
            this.重新開始ToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.重新開始ToolStripMenuItem.Text = "重新開始(R)";
            this.重新開始ToolStripMenuItem.Click += new System.EventHandler(this.重新開始ToolStripMenuItem_Click);
            // 
            // 關卡選擇ToolStripMenuItem
            // 
            this.關卡選擇ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.一ToolStripMenuItem,
            this.二ToolStripMenuItem,
            this.三ToolStripMenuItem,
            this.toolStripMenuItem2});
            this.關卡選擇ToolStripMenuItem.Name = "關卡選擇ToolStripMenuItem";
            this.關卡選擇ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.關卡選擇ToolStripMenuItem.Text = "關卡選擇";
            // 
            // 一ToolStripMenuItem
            // 
            this.一ToolStripMenuItem.Name = "一ToolStripMenuItem";
            this.一ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.一ToolStripMenuItem.Text = "一";
            this.一ToolStripMenuItem.Click += new System.EventHandler(this.一ToolStripMenuItem_Click);
            // 
            // 二ToolStripMenuItem
            // 
            this.二ToolStripMenuItem.Name = "二ToolStripMenuItem";
            this.二ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.二ToolStripMenuItem.Text = "二";
            this.二ToolStripMenuItem.Click += new System.EventHandler(this.二ToolStripMenuItem_Click);
            // 
            // 三ToolStripMenuItem
            // 
            this.三ToolStripMenuItem.Name = "三ToolStripMenuItem";
            this.三ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.三ToolStripMenuItem.Text = "三";
            this.三ToolStripMenuItem.Click += new System.EventHandler(this.三ToolStripMenuItem_Click);
            // 
            // 說明ToolStripMenuItem
            // 
            this.說明ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.操作ToolStripMenuItem,
            this.地圖物件ToolStripMenuItem});
            this.說明ToolStripMenuItem.Name = "說明ToolStripMenuItem";
            this.說明ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.說明ToolStripMenuItem.Text = "說明";
            // 
            // 操作ToolStripMenuItem
            // 
            this.操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.a是向左走ToolStripMenuItem,
            this.d是向右走ToolStripMenuItem,
            this.space是翻轉地圖ToolStripMenuItem});
            this.操作ToolStripMenuItem.Name = "操作ToolStripMenuItem";
            this.操作ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.操作ToolStripMenuItem.Text = "操作";
            // 
            // a是向左走ToolStripMenuItem
            // 
            this.a是向左走ToolStripMenuItem.Name = "a是向左走ToolStripMenuItem";
            this.a是向左走ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.a是向左走ToolStripMenuItem.Text = "\"左方向鍵\"是向左走";
            // 
            // d是向右走ToolStripMenuItem
            // 
            this.d是向右走ToolStripMenuItem.Name = "d是向右走ToolStripMenuItem";
            this.d是向右走ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.d是向右走ToolStripMenuItem.Text = "\"左方向鍵\"是向右走";
            // 
            // space是翻轉地圖ToolStripMenuItem
            // 
            this.space是翻轉地圖ToolStripMenuItem.Name = "space是翻轉地圖ToolStripMenuItem";
            this.space是翻轉地圖ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.space是翻轉地圖ToolStripMenuItem.Text = "Space是翻轉地圖";
            // 
            // 地圖物件ToolStripMenuItem
            // 
            this.地圖物件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.史萊姆是您操控的角色ToolStripMenuItem,
            this.雪怪是終點ToolStripMenuItem,
            this.透明箱子翻轉後才能推歐ToolStripMenuItem});
            this.地圖物件ToolStripMenuItem.Name = "地圖物件ToolStripMenuItem";
            this.地圖物件ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.地圖物件ToolStripMenuItem.Text = "地圖物件";
            // 
            // 史萊姆是您操控的角色ToolStripMenuItem
            // 
            this.史萊姆是您操控的角色ToolStripMenuItem.Name = "史萊姆是您操控的角色ToolStripMenuItem";
            this.史萊姆是您操控的角色ToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.史萊姆是您操控的角色ToolStripMenuItem.Text = "綠水靈是您操控的角色";
            // 
            // 雪怪是終點ToolStripMenuItem
            // 
            this.雪怪是終點ToolStripMenuItem.Name = "雪怪是終點ToolStripMenuItem";
            this.雪怪是終點ToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.雪怪是終點ToolStripMenuItem.Text = "雪吉拉是終點";
            // 
            // 透明箱子翻轉後才能推歐ToolStripMenuItem
            // 
            this.透明箱子翻轉後才能推歐ToolStripMenuItem.Name = "透明箱子翻轉後才能推歐ToolStripMenuItem";
            this.透明箱子翻轉後才能推歐ToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.透明箱子翻轉後才能推歐ToolStripMenuItem.Text = "透明箱子翻轉後才能推歐";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::視窗期末專題.Properties.Resources.插圖3;
            this.pictureBox7.Location = new System.Drawing.Point(728, 123);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(100, 50);
            this.pictureBox7.TabIndex = 11;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::視窗期末專題.Properties.Resources.boxnew;
            this.pictureBox6.Location = new System.Drawing.Point(728, 295);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Image = global::視窗期末專題.Properties.Resources.green_slime;
            this.pictureBox4.Location = new System.Drawing.Point(394, 174);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::視窗期末專題.Properties.Resources.rock123;
            this.pictureBox5.Location = new System.Drawing.Point(728, 219);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 50);
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(559, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::視窗期末專題.Properties.Resources.rock123;
            this.pictureBox2.Image = global::視窗期末專題.Properties.Resources.main_carter;
            this.pictureBox2.Location = new System.Drawing.Point(611, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 125);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(344, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 150);
            this.label1.TabIndex = 14;
            this.label1.Text = "通過";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem2.Text = " ";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::視窗期末專題.Properties.Resources._2d_Wallpaper___WallpaperSafari;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(897, 612);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 重新開始ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 關卡選擇ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 一ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 二ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 三ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem 說明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem a是向左走ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem d是向右走ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem space是翻轉地圖ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 地圖物件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 史萊姆是您操控的角色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 雪怪是終點ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 透明箱子翻轉後才能推歐ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

