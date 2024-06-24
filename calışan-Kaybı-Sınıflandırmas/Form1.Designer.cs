namespace calışan_Kaybı_Sınıflandırmas
{
    partial class ana_Frm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.mTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.performansTabPage = new System.Windows.Forms.TabPage();
            this.yasTabPage = new System.Windows.Forms.TabPage();
            this.dataGrıdYas = new System.Windows.Forms.DataGridView();
            this.aysısımLbl = new System.Windows.Forms.Label();
            this.yolTbox = new System.Windows.Forms.TextBox();
            this.yasSave_btn = new MaterialSkin.Controls.MaterialButton();
            this.mHesaplaBtn = new MaterialSkin.Controls.MaterialButton();
            this.mTabControl.SuspendLayout();
            this.yasTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrıdYas)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.mTabControl;
            this.materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(1, 75);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1328, 48);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // mTabControl
            // 
            this.mTabControl.Controls.Add(this.performansTabPage);
            this.mTabControl.Controls.Add(this.yasTabPage);
            this.mTabControl.Depth = 0;
            this.mTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mTabControl.Location = new System.Drawing.Point(1, 123);
            this.mTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.mTabControl.Multiline = true;
            this.mTabControl.Name = "mTabControl";
            this.mTabControl.SelectedIndex = 0;
            this.mTabControl.Size = new System.Drawing.Size(1328, 543);
            this.mTabControl.TabIndex = 1;
            // 
            // performansTabPage
            // 
            this.performansTabPage.BackColor = System.Drawing.Color.Transparent;
            this.performansTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.performansTabPage.Location = new System.Drawing.Point(4, 25);
            this.performansTabPage.Name = "performansTabPage";
            this.performansTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.performansTabPage.Size = new System.Drawing.Size(1320, 514);
            this.performansTabPage.TabIndex = 0;
            this.performansTabPage.Text = "Performansları";
            this.performansTabPage.Click += new System.EventHandler(this.performansTabPage_Click);
            // 
            // yasTabPage
            // 
            this.yasTabPage.Controls.Add(this.dataGrıdYas);
            this.yasTabPage.Controls.Add(this.aysısımLbl);
            this.yasTabPage.Controls.Add(this.yolTbox);
            this.yasTabPage.Controls.Add(this.yasSave_btn);
            this.yasTabPage.Controls.Add(this.mHesaplaBtn);
            this.yasTabPage.Location = new System.Drawing.Point(4, 25);
            this.yasTabPage.Name = "yasTabPage";
            this.yasTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.yasTabPage.Size = new System.Drawing.Size(1320, 514);
            this.yasTabPage.TabIndex = 1;
            this.yasTabPage.Text = "Çalışan yaşları";
            this.yasTabPage.UseVisualStyleBackColor = true;
            this.yasTabPage.Click += new System.EventHandler(this.yasTabPage_Click);
            // 
            // dataGrıdYas
            // 
            this.dataGrıdYas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrıdYas.BackgroundColor = System.Drawing.Color.White;
            this.dataGrıdYas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrıdYas.Location = new System.Drawing.Point(676, 6);
            this.dataGrıdYas.Name = "dataGrıdYas";
            this.dataGrıdYas.RowHeadersWidth = 51;
            this.dataGrıdYas.RowTemplate.Height = 24;
            this.dataGrıdYas.Size = new System.Drawing.Size(638, 502);
            this.dataGrıdYas.TabIndex = 3;
            // 
            // aysısımLbl
            // 
            this.aysısımLbl.AutoSize = true;
            this.aysısımLbl.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aysısımLbl.Location = new System.Drawing.Point(17, 43);
            this.aysısımLbl.Name = "aysısımLbl";
            this.aysısımLbl.Size = new System.Drawing.Size(228, 30);
            this.aysısımLbl.TabIndex = 2;
            this.aysısımLbl.Text = "Bir başlık giriniz ;";
            // 
            // yolTbox
            // 
            this.yolTbox.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yolTbox.Location = new System.Drawing.Point(287, 33);
            this.yolTbox.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.yolTbox.MaxLength = 50;
            this.yolTbox.Name = "yolTbox";
            this.yolTbox.Size = new System.Drawing.Size(248, 51);
            this.yolTbox.TabIndex = 1;
            this.yolTbox.Text = "Max(50)";
            this.yolTbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yolTbox_KeyPress);
            
            // 
            // yasSave_btn
            // 
            this.yasSave_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yasSave_btn.AutoSize = false;
            this.yasSave_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.yasSave_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.yasSave_btn.Depth = 0;
            this.yasSave_btn.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yasSave_btn.HighEmphasis = true;
            this.yasSave_btn.Icon = null;
            this.yasSave_btn.Location = new System.Drawing.Point(224, 128);
            this.yasSave_btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.yasSave_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.yasSave_btn.Name = "yasSave_btn";
            this.yasSave_btn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.yasSave_btn.Size = new System.Drawing.Size(115, 63);
            this.yasSave_btn.TabIndex = 0;
            this.yasSave_btn.Text = "Kaydet";
            this.yasSave_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.yasSave_btn.UseAccentColor = false;
            this.yasSave_btn.UseVisualStyleBackColor = true;
            this.yasSave_btn.Click += new System.EventHandler(this.yasSave_btn_Click);
            // 
            // mHesaplaBtn
            // 
            this.mHesaplaBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mHesaplaBtn.AutoSize = false;
            this.mHesaplaBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mHesaplaBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mHesaplaBtn.Depth = 0;
            this.mHesaplaBtn.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mHesaplaBtn.HighEmphasis = true;
            this.mHesaplaBtn.Icon = null;
            this.mHesaplaBtn.Location = new System.Drawing.Point(76, 128);
            this.mHesaplaBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mHesaplaBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.mHesaplaBtn.Name = "mHesaplaBtn";
            this.mHesaplaBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mHesaplaBtn.Size = new System.Drawing.Size(115, 63);
            this.mHesaplaBtn.TabIndex = 0;
            this.mHesaplaBtn.Text = "Hesapla";
            this.mHesaplaBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mHesaplaBtn.UseAccentColor = false;
            this.mHesaplaBtn.UseVisualStyleBackColor = true;
            this.mHesaplaBtn.Click += new System.EventHandler(this.mHesaplaBtn_Click);
            // 
            // ana_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1332, 669);
            this.Controls.Add(this.mTabControl);
            this.Controls.Add(this.materialTabSelector1);
            this.Name = "ana_Frm";
            this.Padding = new System.Windows.Forms.Padding(1, 75, 3, 3);
            this.Text = "Çalışan Kaybı Sınıflandırması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mTabControl.ResumeLayout(false);
            this.yasTabPage.ResumeLayout(false);
            this.yasTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrıdYas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl mTabControl;
        private System.Windows.Forms.TabPage performansTabPage;
        private System.Windows.Forms.TabPage yasTabPage;
        private MaterialSkin.Controls.MaterialButton mHesaplaBtn;
        private System.Windows.Forms.Label aysısımLbl;
        private System.Windows.Forms.TextBox yolTbox;
        private System.Windows.Forms.DataGridView dataGrıdYas;
        private MaterialSkin.Controls.MaterialButton yasSave_btn;
    }
}

