namespace SqlTables
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbInitialCat = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dgvDBTables = new System.Windows.Forms.DataGridView();
            this.dgvSQLResult = new System.Windows.Forms.DataGridView();
            this.tbDatSource = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDBTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSQLResult)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(178, 57);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(838, 45);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "(localdb)\\MSsqllocaldb";
            // 
            // tbInitialCat
            // 
            this.tbInitialCat.Location = new System.Drawing.Point(178, 108);
            this.tbInitialCat.Multiline = true;
            this.tbInitialCat.Name = "tbInitialCat";
            this.tbInitialCat.Size = new System.Drawing.Size(711, 45);
            this.tbInitialCat.TabIndex = 1;
            this.tbInitialCat.Text = "CompShop";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(178, 407);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(711, 45);
            this.textBox3.TabIndex = 2;
            // 
            // dgvDBTables
            // 
            this.dgvDBTables.AllowUserToAddRows = false;
            this.dgvDBTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDBTables.Location = new System.Drawing.Point(178, 190);
            this.dgvDBTables.Name = "dgvDBTables";
            this.dgvDBTables.ReadOnly = true;
            this.dgvDBTables.RowHeadersWidth = 62;
            this.dgvDBTables.RowTemplate.Height = 28;
            this.dgvDBTables.Size = new System.Drawing.Size(700, 211);
            this.dgvDBTables.TabIndex = 3;
            // 
            // dgvSQLResult
            // 
            this.dgvSQLResult.AllowUserToAddRows = false;
            this.dgvSQLResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSQLResult.Location = new System.Drawing.Point(178, 458);
            this.dgvSQLResult.Name = "dgvSQLResult";
            this.dgvSQLResult.ReadOnly = true;
            this.dgvSQLResult.RowHeadersWidth = 62;
            this.dgvSQLResult.RowTemplate.Height = 28;
            this.dgvSQLResult.Size = new System.Drawing.Size(700, 235);
            this.dgvSQLResult.TabIndex = 4;
            // 
            // tbDatSource
            // 
            this.tbDatSource.AutoSize = true;
            this.tbDatSource.Location = new System.Drawing.Point(59, 70);
            this.tbDatSource.Name = "tbDatSource";
            this.tbDatSource.Size = new System.Drawing.Size(93, 20);
            this.tbDatSource.TabIndex = 5;
            this.tbDatSource.Text = "data source";
            this.tbDatSource.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "initial catalog";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(906, 111);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(134, 42);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "Connect DB";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(906, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "btn Request";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 771);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDatSource);
            this.Controls.Add(this.dgvSQLResult);
            this.Controls.Add(this.dgvDBTables);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.tbInitialCat);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Database Requets";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDBTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSQLResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbInitialCat;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dgvDBTables;
        private System.Windows.Forms.DataGridView dgvSQLResult;
        private System.Windows.Forms.Label tbDatSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button button1;
    }
}

