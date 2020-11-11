namespace StoktakitDeneme3
{
    partial class StokSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StokSayfasi));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stokTakipOtomasyonuDataSet3 = new StoktakitDeneme3.StokTakipOtomasyonuDataSet3();
            this.stokBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stokBilgiTableAdapter2 = new StoktakitDeneme3.StokTakipOtomasyonuDataSet3TableAdapters.StokBilgiTableAdapter();
            this.seriNumaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.görüntüDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.seriNumaraDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.görüntüDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stoknumeric = new System.Windows.Forms.NumericUpDown();
            this.fiyatnumeric = new System.Windows.Forms.NumericUpDown();
            this.modelcombobox = new System.Windows.Forms.ComboBox();
            this.markacombobox = new System.Windows.Forms.ComboBox();
            this.kategoricombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.serinumaratxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.fototxt = new System.Windows.Forms.TextBox();
            this.fotoekle = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipOtomasyonuDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokBilgiBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stoknumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiyatnumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seriNumaraDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn,
            this.stokDataGridViewTextBoxColumn,
            this.kategoriDataGridViewTextBoxColumn,
            this.görüntüDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stokBilgiBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(723, 418);
            this.dataGridView1.TabIndex = 0;
            // 
            // stokTakipOtomasyonuDataSet3
            // 
            this.stokTakipOtomasyonuDataSet3.DataSetName = "StokTakipOtomasyonuDataSet3";
            this.stokTakipOtomasyonuDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stokBilgiBindingSource
            // 
            this.stokBilgiBindingSource.DataMember = "StokBilgi";
            this.stokBilgiBindingSource.DataSource = this.stokTakipOtomasyonuDataSet3;
            // 
            // stokBilgiTableAdapter2
            // 
            this.stokBilgiTableAdapter2.ClearBeforeFill = true;
            // 
            // seriNumaraDataGridViewTextBoxColumn
            // 
            this.seriNumaraDataGridViewTextBoxColumn.DataPropertyName = "SeriNumara";
            this.seriNumaraDataGridViewTextBoxColumn.HeaderText = "SeriNumara";
            this.seriNumaraDataGridViewTextBoxColumn.Name = "seriNumaraDataGridViewTextBoxColumn";
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "Marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "Marka";
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            // 
            // stokDataGridViewTextBoxColumn
            // 
            this.stokDataGridViewTextBoxColumn.DataPropertyName = "Stok";
            this.stokDataGridViewTextBoxColumn.HeaderText = "Stok";
            this.stokDataGridViewTextBoxColumn.Name = "stokDataGridViewTextBoxColumn";
            // 
            // kategoriDataGridViewTextBoxColumn
            // 
            this.kategoriDataGridViewTextBoxColumn.DataPropertyName = "Kategori";
            this.kategoriDataGridViewTextBoxColumn.HeaderText = "Kategori";
            this.kategoriDataGridViewTextBoxColumn.Name = "kategoriDataGridViewTextBoxColumn";
            // 
            // görüntüDataGridViewTextBoxColumn
            // 
            this.görüntüDataGridViewTextBoxColumn.DataPropertyName = "Görüntü";
            this.görüntüDataGridViewTextBoxColumn.HeaderText = "Görüntü";
            this.görüntüDataGridViewTextBoxColumn.Name = "görüntüDataGridViewTextBoxColumn";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(737, 450);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(729, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Stok Listesi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(729, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Analiz";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seriNumaraDataGridViewTextBoxColumn1,
            this.markaDataGridViewTextBoxColumn1,
            this.modelDataGridViewTextBoxColumn1,
            this.fiyatDataGridViewTextBoxColumn1,
            this.stokDataGridViewTextBoxColumn1,
            this.kategoriDataGridViewTextBoxColumn1,
            this.görüntüDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.stokBilgiBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Location = new System.Drawing.Point(3, 147);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(723, 274);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // seriNumaraDataGridViewTextBoxColumn1
            // 
            this.seriNumaraDataGridViewTextBoxColumn1.DataPropertyName = "SeriNumara";
            this.seriNumaraDataGridViewTextBoxColumn1.HeaderText = "SeriNumara";
            this.seriNumaraDataGridViewTextBoxColumn1.Name = "seriNumaraDataGridViewTextBoxColumn1";
            // 
            // markaDataGridViewTextBoxColumn1
            // 
            this.markaDataGridViewTextBoxColumn1.DataPropertyName = "Marka";
            this.markaDataGridViewTextBoxColumn1.HeaderText = "Marka";
            this.markaDataGridViewTextBoxColumn1.Name = "markaDataGridViewTextBoxColumn1";
            // 
            // modelDataGridViewTextBoxColumn1
            // 
            this.modelDataGridViewTextBoxColumn1.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn1.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn1.Name = "modelDataGridViewTextBoxColumn1";
            // 
            // fiyatDataGridViewTextBoxColumn1
            // 
            this.fiyatDataGridViewTextBoxColumn1.DataPropertyName = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn1.HeaderText = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn1.Name = "fiyatDataGridViewTextBoxColumn1";
            // 
            // stokDataGridViewTextBoxColumn1
            // 
            this.stokDataGridViewTextBoxColumn1.DataPropertyName = "Stok";
            this.stokDataGridViewTextBoxColumn1.HeaderText = "Stok";
            this.stokDataGridViewTextBoxColumn1.Name = "stokDataGridViewTextBoxColumn1";
            // 
            // kategoriDataGridViewTextBoxColumn1
            // 
            this.kategoriDataGridViewTextBoxColumn1.DataPropertyName = "Kategori";
            this.kategoriDataGridViewTextBoxColumn1.HeaderText = "Kategori";
            this.kategoriDataGridViewTextBoxColumn1.Name = "kategoriDataGridViewTextBoxColumn1";
            // 
            // görüntüDataGridViewTextBoxColumn1
            // 
            this.görüntüDataGridViewTextBoxColumn1.DataPropertyName = "Görüntü";
            this.görüntüDataGridViewTextBoxColumn1.HeaderText = "Görüntü";
            this.görüntüDataGridViewTextBoxColumn1.Name = "görüntüDataGridViewTextBoxColumn1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.fotoekle);
            this.groupBox1.Controls.Add(this.stoknumeric);
            this.groupBox1.Controls.Add(this.fiyatnumeric);
            this.groupBox1.Controls.Add(this.modelcombobox);
            this.groupBox1.Controls.Add(this.markacombobox);
            this.groupBox1.Controls.Add(this.kategoricombobox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.fototxt);
            this.groupBox1.Controls.Add(this.serinumaratxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 135);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // stoknumeric
            // 
            this.stoknumeric.Location = new System.Drawing.Point(330, 42);
            this.stoknumeric.Name = "stoknumeric";
            this.stoknumeric.Size = new System.Drawing.Size(121, 20);
            this.stoknumeric.TabIndex = 12;
            // 
            // fiyatnumeric
            // 
            this.fiyatnumeric.Location = new System.Drawing.Point(103, 95);
            this.fiyatnumeric.Name = "fiyatnumeric";
            this.fiyatnumeric.Size = new System.Drawing.Size(121, 20);
            this.fiyatnumeric.TabIndex = 12;
            // 
            // modelcombobox
            // 
            this.modelcombobox.FormattingEnabled = true;
            this.modelcombobox.Location = new System.Drawing.Point(103, 67);
            this.modelcombobox.Name = "modelcombobox";
            this.modelcombobox.Size = new System.Drawing.Size(121, 21);
            this.modelcombobox.TabIndex = 11;
            // 
            // markacombobox
            // 
            this.markacombobox.FormattingEnabled = true;
            this.markacombobox.Location = new System.Drawing.Point(103, 43);
            this.markacombobox.Name = "markacombobox";
            this.markacombobox.Size = new System.Drawing.Size(121, 21);
            this.markacombobox.TabIndex = 10;
            // 
            // kategoricombobox
            // 
            this.kategoricombobox.FormattingEnabled = true;
            this.kategoricombobox.Location = new System.Drawing.Point(330, 18);
            this.kategoricombobox.Name = "kategoricombobox";
            this.kategoricombobox.Size = new System.Drawing.Size(121, 21);
            this.kategoricombobox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seri Numara";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(233, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Kategori";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serinumaratxt
            // 
            this.serinumaratxt.Location = new System.Drawing.Point(103, 16);
            this.serinumaratxt.Name = "serinumaratxt";
            this.serinumaratxt.Size = new System.Drawing.Size(121, 20);
            this.serinumaratxt.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Marka";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(233, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Stok";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Model";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(6, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fiyat:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(469, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 138);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(233, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Görüntü";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fototxt
            // 
            this.fototxt.Location = new System.Drawing.Point(330, 69);
            this.fototxt.Name = "fototxt";
            this.fototxt.Size = new System.Drawing.Size(121, 20);
            this.fototxt.TabIndex = 8;
            // 
            // fotoekle
            // 
            this.fotoekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.fotoekle.Location = new System.Drawing.Point(427, 94);
            this.fotoekle.Name = "fotoekle";
            this.fotoekle.Size = new System.Drawing.Size(24, 23);
            this.fotoekle.TabIndex = 13;
            this.fotoekle.Text = "...";
            this.fotoekle.UseVisualStyleBackColor = true;
            this.fotoekle.Click += new System.EventHandler(this.fotoekle_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // StokSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StokSayfasi";
            this.Text = "Stok Sayfası";
            this.Load += new System.EventHandler(this.StokSayfasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipOtomasyonuDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokBilgiBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stoknumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiyatnumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private StokTakipOtomasyonuDataSet3 stokTakipOtomasyonuDataSet3;
        private System.Windows.Forms.BindingSource stokBilgiBindingSource;
        private StokTakipOtomasyonuDataSet3TableAdapters.StokBilgiTableAdapter stokBilgiTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriNumaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn görüntüDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button fotoekle;
        private System.Windows.Forms.NumericUpDown stoknumeric;
        private System.Windows.Forms.NumericUpDown fiyatnumeric;
        private System.Windows.Forms.ComboBox modelcombobox;
        private System.Windows.Forms.ComboBox markacombobox;
        private System.Windows.Forms.ComboBox kategoricombobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox serinumaratxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriNumaraDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn görüntüDataGridViewTextBoxColumn1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox fototxt;
    }
}