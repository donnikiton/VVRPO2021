
namespace DB_Kurs
{
    partial class Form_seans
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idseansDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kinozalIdkinozalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biletIdbiletDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seansSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet2 = new DB_Kurs.testDataSet2();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.seansSetTableAdapter = new DB_Kurs.testDataSet2TableAdapters.seansSetTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.seansSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seansSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seansSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idseansDataGridViewTextBoxColumn,
            this.tamedateDataGridViewTextBoxColumn,
            this.kinozalIdkinozalDataGridViewTextBoxColumn,
            this.biletIdbiletDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.seansSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(351, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 158);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idseansDataGridViewTextBoxColumn
            // 
            this.idseansDataGridViewTextBoxColumn.DataPropertyName = "Id_seans";
            this.idseansDataGridViewTextBoxColumn.HeaderText = "Id_seans";
            this.idseansDataGridViewTextBoxColumn.Name = "idseansDataGridViewTextBoxColumn";
            this.idseansDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tamedateDataGridViewTextBoxColumn
            // 
            this.tamedateDataGridViewTextBoxColumn.DataPropertyName = "tame_date";
            this.tamedateDataGridViewTextBoxColumn.HeaderText = "tame_date";
            this.tamedateDataGridViewTextBoxColumn.Name = "tamedateDataGridViewTextBoxColumn";
            // 
            // kinozalIdkinozalDataGridViewTextBoxColumn
            // 
            this.kinozalIdkinozalDataGridViewTextBoxColumn.DataPropertyName = "KinozalId_kinozal";
            this.kinozalIdkinozalDataGridViewTextBoxColumn.HeaderText = "KinozalId_kinozal";
            this.kinozalIdkinozalDataGridViewTextBoxColumn.Name = "kinozalIdkinozalDataGridViewTextBoxColumn";
            // 
            // biletIdbiletDataGridViewTextBoxColumn
            // 
            this.biletIdbiletDataGridViewTextBoxColumn.DataPropertyName = "BiletId_bilet";
            this.biletIdbiletDataGridViewTextBoxColumn.HeaderText = "BiletId_bilet";
            this.biletIdbiletDataGridViewTextBoxColumn.Name = "biletIdbiletDataGridViewTextBoxColumn";
            // 
            // seansSetBindingSource
            // 
            this.seansSetBindingSource.DataMember = "seansSet";
            this.seansSetBindingSource.DataSource = this.testDataSet2;
            // 
            // testDataSet2
            // 
            this.testDataSet2.DataSetName = "testDataSet2";
            this.testDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(190, 299);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 35);
            this.button3.TabIndex = 10;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(190, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(185, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Дата и время сеанса";
            // 
            // seansSetTableAdapter
            // 
            this.seansSetTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(185, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Номер кинозал";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(185, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Номер билета";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(190, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(425, 20);
            this.textBox1.TabIndex = 16;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(190, 340);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 35);
            this.button4.TabIndex = 17;
            this.button4.Text = "Проверить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(651, 66);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(137, 71);
            this.button5.TabIndex = 18;
            this.button5.Text = "Кто идёт на какие сеансы";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(190, 116);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // seansSetBindingSource1
            // 
            this.seansSetBindingSource1.DataMember = "seansSet";
            this.seansSetBindingSource1.DataSource = this.testDataSet2;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.seansSetBindingSource1;
            this.comboBox2.DisplayMember = "BiletId_bilet";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(190, 173);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(157, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "№";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(157, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "№";
            // 
            // Form_seans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form_seans";
            this.Text = "Form_seans";
            this.Load += new System.EventHandler(this.Form_seans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seansSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seansSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private testDataSet2 testDataSet2;
        private System.Windows.Forms.BindingSource seansSetBindingSource;
        private testDataSet2TableAdapters.seansSetTableAdapter seansSetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idseansDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kinozalIdkinozalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn biletIdbiletDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource seansSetBindingSource1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}