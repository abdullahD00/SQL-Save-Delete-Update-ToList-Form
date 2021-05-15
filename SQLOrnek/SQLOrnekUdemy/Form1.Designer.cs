namespace SQLOrnekUdemy
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox_VeriAlma = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_PerMESLEK = new System.Windows.Forms.TextBox();
            this.textBox_PerID = new System.Windows.Forms.TextBox();
            this.textBox_PerSOYAD = new System.Windows.Forms.TextBox();
            this.textBox_PerAD = new System.Windows.Forms.TextBox();
            this.PerMeslek = new System.Windows.Forms.Label();
            this.radioButton_Bekar = new System.Windows.Forms.RadioButton();
            this.radioButton_Evli = new System.Windows.Forms.RadioButton();
            this.PerDurum = new System.Windows.Forms.Label();
            this.maskedTextBox_PerMAAS = new System.Windows.Forms.MaskedTextBox();
            this.PerMaaş = new System.Windows.Forms.Label();
            this.comboBox_PerSEHIR = new System.Windows.Forms.ComboBox();
            this.PerSehir = new System.Windows.Forms.Label();
            this.PerSoyad = new System.Windows.Forms.Label();
            this.PerAd = new System.Windows.Forms.Label();
            this.PerId = new System.Windows.Forms.Label();
            this.groupBox_İşlemler = new System.Windows.Forms.GroupBox();
            this.button_GRAFIKLER = new System.Windows.Forms.Button();
            this.button_ISTATISTIK = new System.Windows.Forms.Button();
            this.button_TEMIZLE = new System.Windows.Forms.Button();
            this.button_GUNCELLE = new System.Windows.Forms.Button();
            this.button_SIL = new System.Windows.Forms.Button();
            this.button_KAYDET = new System.Windows.Forms.Button();
            this.button_LISTELE = new System.Windows.Forms.Button();
            this.groupBox_KAYITLAR = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.perIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personel_BilgisiDataSet = new SQLOrnekUdemy.Personel_BilgisiDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbl_PersonelTableAdapter = new SQLOrnekUdemy.Personel_BilgisiDataSetTableAdapters.Tbl_PersonelTableAdapter();
            this.groupBox_VeriAlma.SuspendLayout();
            this.groupBox_İşlemler.SuspendLayout();
            this.groupBox_KAYITLAR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_BilgisiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_VeriAlma
            // 
            this.groupBox_VeriAlma.Controls.Add(this.label1);
            this.groupBox_VeriAlma.Controls.Add(this.textBox_PerMESLEK);
            this.groupBox_VeriAlma.Controls.Add(this.textBox_PerID);
            this.groupBox_VeriAlma.Controls.Add(this.textBox_PerSOYAD);
            this.groupBox_VeriAlma.Controls.Add(this.textBox_PerAD);
            this.groupBox_VeriAlma.Controls.Add(this.PerMeslek);
            this.groupBox_VeriAlma.Controls.Add(this.radioButton_Bekar);
            this.groupBox_VeriAlma.Controls.Add(this.radioButton_Evli);
            this.groupBox_VeriAlma.Controls.Add(this.PerDurum);
            this.groupBox_VeriAlma.Controls.Add(this.maskedTextBox_PerMAAS);
            this.groupBox_VeriAlma.Controls.Add(this.PerMaaş);
            this.groupBox_VeriAlma.Controls.Add(this.comboBox_PerSEHIR);
            this.groupBox_VeriAlma.Controls.Add(this.PerSehir);
            this.groupBox_VeriAlma.Controls.Add(this.PerSoyad);
            this.groupBox_VeriAlma.Controls.Add(this.PerAd);
            this.groupBox_VeriAlma.Controls.Add(this.PerId);
            this.groupBox_VeriAlma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox_VeriAlma.Location = new System.Drawing.Point(3, 1);
            this.groupBox_VeriAlma.Name = "groupBox_VeriAlma";
            this.groupBox_VeriAlma.Size = new System.Drawing.Size(467, 373);
            this.groupBox_VeriAlma.TabIndex = 0;
            this.groupBox_VeriAlma.TabStop = false;
            this.groupBox_VeriAlma.Text = "VeriAlma";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.TextChanged += new System.EventHandler(this.label1_TextChanged);
            // 
            // textBox_PerMESLEK
            // 
            this.textBox_PerMESLEK.Location = new System.Drawing.Point(118, 300);
            this.textBox_PerMESLEK.Name = "textBox_PerMESLEK";
            this.textBox_PerMESLEK.Size = new System.Drawing.Size(133, 26);
            this.textBox_PerMESLEK.TabIndex = 8;
            // 
            // textBox_PerID
            // 
            this.textBox_PerID.Location = new System.Drawing.Point(118, 33);
            this.textBox_PerID.Name = "textBox_PerID";
            this.textBox_PerID.Size = new System.Drawing.Size(133, 26);
            this.textBox_PerID.TabIndex = 1;
            // 
            // textBox_PerSOYAD
            // 
            this.textBox_PerSOYAD.Location = new System.Drawing.Point(118, 129);
            this.textBox_PerSOYAD.Name = "textBox_PerSOYAD";
            this.textBox_PerSOYAD.Size = new System.Drawing.Size(133, 26);
            this.textBox_PerSOYAD.TabIndex = 3;
            // 
            // textBox_PerAD
            // 
            this.textBox_PerAD.Location = new System.Drawing.Point(118, 86);
            this.textBox_PerAD.Name = "textBox_PerAD";
            this.textBox_PerAD.Size = new System.Drawing.Size(133, 26);
            this.textBox_PerAD.TabIndex = 2;
            // 
            // PerMeslek
            // 
            this.PerMeslek.AutoSize = true;
            this.PerMeslek.Location = new System.Drawing.Point(9, 306);
            this.PerMeslek.Name = "PerMeslek";
            this.PerMeslek.Size = new System.Drawing.Size(103, 20);
            this.PerMeslek.TabIndex = 12;
            this.PerMeslek.Text = "PerMeslek:";
            // 
            // radioButton_Bekar
            // 
            this.radioButton_Bekar.AutoSize = true;
            this.radioButton_Bekar.Location = new System.Drawing.Point(190, 262);
            this.radioButton_Bekar.Name = "radioButton_Bekar";
            this.radioButton_Bekar.Size = new System.Drawing.Size(79, 24);
            this.radioButton_Bekar.TabIndex = 7;
            this.radioButton_Bekar.TabStop = true;
            this.radioButton_Bekar.Text = "Bekar";
            this.radioButton_Bekar.UseVisualStyleBackColor = true;
            this.radioButton_Bekar.CheckedChanged += new System.EventHandler(this.radioButton_Bekar_CheckedChanged);
            // 
            // radioButton_Evli
            // 
            this.radioButton_Evli.AutoSize = true;
            this.radioButton_Evli.Location = new System.Drawing.Point(122, 264);
            this.radioButton_Evli.Name = "radioButton_Evli";
            this.radioButton_Evli.Size = new System.Drawing.Size(61, 24);
            this.radioButton_Evli.TabIndex = 6;
            this.radioButton_Evli.TabStop = true;
            this.radioButton_Evli.Text = "Evli";
            this.radioButton_Evli.UseVisualStyleBackColor = true;
            this.radioButton_Evli.CheckedChanged += new System.EventHandler(this.radioButton_Evli_CheckedChanged);
            // 
            // PerDurum
            // 
            this.PerDurum.AutoSize = true;
            this.PerDurum.Location = new System.Drawing.Point(16, 264);
            this.PerDurum.Name = "PerDurum";
            this.PerDurum.Size = new System.Drawing.Size(100, 20);
            this.PerDurum.TabIndex = 10;
            this.PerDurum.Text = "PerDurum:";
            // 
            // maskedTextBox_PerMAAS
            // 
            this.maskedTextBox_PerMAAS.Location = new System.Drawing.Point(118, 218);
            this.maskedTextBox_PerMAAS.Mask = "0000";
            this.maskedTextBox_PerMAAS.Name = "maskedTextBox_PerMAAS";
            this.maskedTextBox_PerMAAS.Size = new System.Drawing.Size(133, 26);
            this.maskedTextBox_PerMAAS.TabIndex = 5;
            this.maskedTextBox_PerMAAS.ValidatingType = typeof(int);
            // 
            // PerMaaş
            // 
            this.PerMaaş.AutoSize = true;
            this.PerMaaş.Location = new System.Drawing.Point(17, 224);
            this.PerMaaş.Name = "PerMaaş";
            this.PerMaaş.Size = new System.Drawing.Size(89, 20);
            this.PerMaaş.TabIndex = 8;
            this.PerMaaş.Text = "PerMaaş:";
            // 
            // comboBox_PerSEHIR
            // 
            this.comboBox_PerSEHIR.FormattingEnabled = true;
            this.comboBox_PerSEHIR.Location = new System.Drawing.Point(118, 174);
            this.comboBox_PerSEHIR.Name = "comboBox_PerSEHIR";
            this.comboBox_PerSEHIR.Size = new System.Drawing.Size(133, 28);
            this.comboBox_PerSEHIR.TabIndex = 4;
            // 
            // PerSehir
            // 
            this.PerSehir.AutoSize = true;
            this.PerSehir.Location = new System.Drawing.Point(17, 177);
            this.PerSehir.Name = "PerSehir";
            this.PerSehir.Size = new System.Drawing.Size(88, 20);
            this.PerSehir.TabIndex = 6;
            this.PerSehir.Text = "PerŞehir:";
            // 
            // PerSoyad
            // 
            this.PerSoyad.AutoSize = true;
            this.PerSoyad.Location = new System.Drawing.Point(17, 132);
            this.PerSoyad.Name = "PerSoyad";
            this.PerSoyad.Size = new System.Drawing.Size(95, 20);
            this.PerSoyad.TabIndex = 4;
            this.PerSoyad.Text = "PerSoyad:";
            // 
            // PerAd
            // 
            this.PerAd.AutoSize = true;
            this.PerAd.Location = new System.Drawing.Point(46, 86);
            this.PerAd.Name = "PerAd";
            this.PerAd.Size = new System.Drawing.Size(66, 20);
            this.PerAd.TabIndex = 2;
            this.PerAd.Text = "PerAd:";
            // 
            // PerId
            // 
            this.PerId.AutoSize = true;
            this.PerId.Location = new System.Drawing.Point(49, 39);
            this.PerId.Name = "PerId";
            this.PerId.Size = new System.Drawing.Size(63, 20);
            this.PerId.TabIndex = 0;
            this.PerId.Text = "PerID:";
            // 
            // groupBox_İşlemler
            // 
            this.groupBox_İşlemler.Controls.Add(this.button_GRAFIKLER);
            this.groupBox_İşlemler.Controls.Add(this.button_ISTATISTIK);
            this.groupBox_İşlemler.Controls.Add(this.button_TEMIZLE);
            this.groupBox_İşlemler.Controls.Add(this.button_GUNCELLE);
            this.groupBox_İşlemler.Controls.Add(this.button_SIL);
            this.groupBox_İşlemler.Controls.Add(this.button_KAYDET);
            this.groupBox_İşlemler.Controls.Add(this.button_LISTELE);
            this.groupBox_İşlemler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox_İşlemler.Location = new System.Drawing.Point(508, 1);
            this.groupBox_İşlemler.Name = "groupBox_İşlemler";
            this.groupBox_İşlemler.Size = new System.Drawing.Size(467, 373);
            this.groupBox_İşlemler.TabIndex = 1;
            this.groupBox_İşlemler.TabStop = false;
            this.groupBox_İşlemler.Text = "İşlemler";
            // 
            // button_GRAFIKLER
            // 
            this.button_GRAFIKLER.Location = new System.Drawing.Point(172, 330);
            this.button_GRAFIKLER.Name = "button_GRAFIKLER";
            this.button_GRAFIKLER.Size = new System.Drawing.Size(140, 47);
            this.button_GRAFIKLER.TabIndex = 15;
            this.button_GRAFIKLER.Text = "GRAFİKLER";
            this.button_GRAFIKLER.UseVisualStyleBackColor = true;
            // 
            // button_ISTATISTIK
            // 
            this.button_ISTATISTIK.Location = new System.Drawing.Point(172, 277);
            this.button_ISTATISTIK.Name = "button_ISTATISTIK";
            this.button_ISTATISTIK.Size = new System.Drawing.Size(140, 47);
            this.button_ISTATISTIK.TabIndex = 14;
            this.button_ISTATISTIK.Text = "İSTATİSTİK";
            this.button_ISTATISTIK.UseVisualStyleBackColor = true;
            this.button_ISTATISTIK.Click += new System.EventHandler(this.button_ISTATISTIK_Click);
            // 
            // button_TEMIZLE
            // 
            this.button_TEMIZLE.Location = new System.Drawing.Point(172, 224);
            this.button_TEMIZLE.Name = "button_TEMIZLE";
            this.button_TEMIZLE.Size = new System.Drawing.Size(140, 47);
            this.button_TEMIZLE.TabIndex = 13;
            this.button_TEMIZLE.Text = "TEMİZLE";
            this.button_TEMIZLE.UseVisualStyleBackColor = true;
            this.button_TEMIZLE.Click += new System.EventHandler(this.button_TEMIZLE_Click);
            // 
            // button_GUNCELLE
            // 
            this.button_GUNCELLE.Location = new System.Drawing.Point(172, 171);
            this.button_GUNCELLE.Name = "button_GUNCELLE";
            this.button_GUNCELLE.Size = new System.Drawing.Size(140, 47);
            this.button_GUNCELLE.TabIndex = 12;
            this.button_GUNCELLE.Text = "GÜNCELLE";
            this.button_GUNCELLE.UseVisualStyleBackColor = true;
            this.button_GUNCELLE.Click += new System.EventHandler(this.button_GUNCELLE_Click);
            // 
            // button_SIL
            // 
            this.button_SIL.Location = new System.Drawing.Point(172, 118);
            this.button_SIL.Name = "button_SIL";
            this.button_SIL.Size = new System.Drawing.Size(140, 47);
            this.button_SIL.TabIndex = 11;
            this.button_SIL.Text = "SİL";
            this.button_SIL.UseVisualStyleBackColor = true;
            this.button_SIL.Click += new System.EventHandler(this.button_SIL_Click);
            // 
            // button_KAYDET
            // 
            this.button_KAYDET.Location = new System.Drawing.Point(172, 65);
            this.button_KAYDET.Name = "button_KAYDET";
            this.button_KAYDET.Size = new System.Drawing.Size(140, 47);
            this.button_KAYDET.TabIndex = 10;
            this.button_KAYDET.Text = "KAYDET";
            this.button_KAYDET.UseVisualStyleBackColor = true;
            this.button_KAYDET.Click += new System.EventHandler(this.button_KAYDET_Click);
            // 
            // button_LISTELE
            // 
            this.button_LISTELE.Location = new System.Drawing.Point(172, 12);
            this.button_LISTELE.Name = "button_LISTELE";
            this.button_LISTELE.Size = new System.Drawing.Size(140, 47);
            this.button_LISTELE.TabIndex = 9;
            this.button_LISTELE.Text = "LİSTELE";
            this.button_LISTELE.UseVisualStyleBackColor = true;
            this.button_LISTELE.Click += new System.EventHandler(this.button_LISTELE_Click);
            // 
            // groupBox_KAYITLAR
            // 
            this.groupBox_KAYITLAR.Controls.Add(this.dataGridView1);
            this.groupBox_KAYITLAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox_KAYITLAR.Location = new System.Drawing.Point(3, 380);
            this.groupBox_KAYITLAR.Name = "groupBox_KAYITLAR";
            this.groupBox_KAYITLAR.Size = new System.Drawing.Size(1326, 232);
            this.groupBox_KAYITLAR.TabIndex = 2;
            this.groupBox_KAYITLAR.TabStop = false;
            this.groupBox_KAYITLAR.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.perIdDataGridViewTextBoxColumn,
            this.perAdDataGridViewTextBoxColumn,
            this.perSoyadDataGridViewTextBoxColumn,
            this.perSehirDataGridViewTextBoxColumn,
            this.perMaasDataGridViewTextBoxColumn,
            this.perDurumDataGridViewCheckBoxColumn,
            this.perMeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPersonelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1320, 207);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // perIdDataGridViewTextBoxColumn
            // 
            this.perIdDataGridViewTextBoxColumn.DataPropertyName = "PerId";
            this.perIdDataGridViewTextBoxColumn.HeaderText = "PerId";
            this.perIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perIdDataGridViewTextBoxColumn.Name = "perIdDataGridViewTextBoxColumn";
            this.perIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.perIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // perAdDataGridViewTextBoxColumn
            // 
            this.perAdDataGridViewTextBoxColumn.DataPropertyName = "PerAd";
            this.perAdDataGridViewTextBoxColumn.HeaderText = "PerAd";
            this.perAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perAdDataGridViewTextBoxColumn.Name = "perAdDataGridViewTextBoxColumn";
            this.perAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // perSoyadDataGridViewTextBoxColumn
            // 
            this.perSoyadDataGridViewTextBoxColumn.DataPropertyName = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.HeaderText = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perSoyadDataGridViewTextBoxColumn.Name = "perSoyadDataGridViewTextBoxColumn";
            this.perSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // perSehirDataGridViewTextBoxColumn
            // 
            this.perSehirDataGridViewTextBoxColumn.DataPropertyName = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.HeaderText = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perSehirDataGridViewTextBoxColumn.Name = "perSehirDataGridViewTextBoxColumn";
            this.perSehirDataGridViewTextBoxColumn.Width = 125;
            // 
            // perMaasDataGridViewTextBoxColumn
            // 
            this.perMaasDataGridViewTextBoxColumn.DataPropertyName = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.HeaderText = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perMaasDataGridViewTextBoxColumn.Name = "perMaasDataGridViewTextBoxColumn";
            this.perMaasDataGridViewTextBoxColumn.Width = 125;
            // 
            // perDurumDataGridViewCheckBoxColumn
            // 
            this.perDurumDataGridViewCheckBoxColumn.DataPropertyName = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.HeaderText = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.perDurumDataGridViewCheckBoxColumn.Name = "perDurumDataGridViewCheckBoxColumn";
            this.perDurumDataGridViewCheckBoxColumn.Width = 125;
            // 
            // perMeslekDataGridViewTextBoxColumn
            // 
            this.perMeslekDataGridViewTextBoxColumn.DataPropertyName = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.HeaderText = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perMeslekDataGridViewTextBoxColumn.Name = "perMeslekDataGridViewTextBoxColumn";
            this.perMeslekDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblPersonelBindingSource
            // 
            this.tblPersonelBindingSource.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource.DataSource = this.personel_BilgisiDataSet;
            // 
            // personel_BilgisiDataSet
            // 
            this.personel_BilgisiDataSet.DataSetName = "Personel_BilgisiDataSet";
            this.personel_BilgisiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1021, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 274);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tbl_PersonelTableAdapter
            // 
            this.tbl_PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1341, 612);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox_KAYITLAR);
            this.Controls.Add(this.groupBox_İşlemler);
            this.Controls.Add(this.groupBox_VeriAlma);
            this.Name = "Form1";
            this.Text = "Kayıt_Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_VeriAlma.ResumeLayout(false);
            this.groupBox_VeriAlma.PerformLayout();
            this.groupBox_İşlemler.ResumeLayout(false);
            this.groupBox_KAYITLAR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_BilgisiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_VeriAlma;
        private System.Windows.Forms.TextBox textBox_PerMESLEK;
        private System.Windows.Forms.TextBox textBox_PerID;
        private System.Windows.Forms.TextBox textBox_PerSOYAD;
        private System.Windows.Forms.TextBox textBox_PerAD;
        private System.Windows.Forms.Label PerMeslek;
        private System.Windows.Forms.RadioButton radioButton_Bekar;
        private System.Windows.Forms.RadioButton radioButton_Evli;
        private System.Windows.Forms.Label PerDurum;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_PerMAAS;
        private System.Windows.Forms.Label PerMaaş;
        private System.Windows.Forms.ComboBox comboBox_PerSEHIR;
        private System.Windows.Forms.Label PerSehir;
        private System.Windows.Forms.Label PerSoyad;
        private System.Windows.Forms.Label PerAd;
        private System.Windows.Forms.Label PerId;
        private System.Windows.Forms.GroupBox groupBox_İşlemler;
        private System.Windows.Forms.Button button_GRAFIKLER;
        private System.Windows.Forms.Button button_ISTATISTIK;
        private System.Windows.Forms.Button button_TEMIZLE;
        private System.Windows.Forms.Button button_GUNCELLE;
        private System.Windows.Forms.Button button_SIL;
        private System.Windows.Forms.Button button_KAYDET;
        private System.Windows.Forms.Button button_LISTELE;
        private System.Windows.Forms.GroupBox groupBox_KAYITLAR;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Personel_BilgisiDataSet personel_BilgisiDataSet;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private Personel_BilgisiDataSetTableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn perIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}

