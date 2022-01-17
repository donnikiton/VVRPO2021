
namespace DB_Kurs
{
    partial class user_seans
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
            this.testDataSet2 = new DB_Kurs.testDataSet2();
            this.testDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kinozalSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kinozalSetTableAdapter = new DB_Kurs.testDataSet2TableAdapters.KinozalSetTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinozalSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(116, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(574, 253);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // testDataSet2
            // 
            this.testDataSet2.DataSetName = "testDataSet2";
            this.testDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testDataSet2BindingSource
            // 
            this.testDataSet2BindingSource.DataSource = this.testDataSet2;
            this.testDataSet2BindingSource.Position = 0;
            // 
            // kinozalSetBindingSource
            // 
            this.kinozalSetBindingSource.DataMember = "KinozalSet";
            this.kinozalSetBindingSource.DataSource = this.testDataSet2;
            // 
            // kinozalSetTableAdapter
            // 
            this.kinozalSetTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 377);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(156, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // user_seans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "user_seans";
            this.Text = "user_seans";
            this.Load += new System.EventHandler(this.user_seans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinozalSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource testDataSet2BindingSource;
        private testDataSet2 testDataSet2;
        private System.Windows.Forms.BindingSource kinozalSetBindingSource;
        private testDataSet2TableAdapters.KinozalSetTableAdapter kinozalSetTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}