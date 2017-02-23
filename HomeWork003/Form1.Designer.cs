namespace HomeWork003
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
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.seq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seq,
            this.name,
            this.tel,
            this.address});
            this.dataGridView1.Location = new System.Drawing.Point(34, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(442, 174);
            this.dataGridView1.TabIndex = 0;
            // 
            // seq
            // 
            this.seq.DataPropertyName = "seq";
            this.seq.HeaderText = "";
            this.seq.Name = "seq";
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "名字";
            this.name.Name = "name";
            // 
            // tel
            // 
            this.tel.DataPropertyName = "tel";
            this.tel.HeaderText = "電話";
            this.tel.Name = "tel";
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "地址";
            this.address.Name = "address";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 240);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "搜尋";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(78, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "電話:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 323);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn seq;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

