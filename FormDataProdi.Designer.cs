namespace Disconnected_Environtment
{
    partial class FormDataProdi
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
            this.prodiTI1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodiTI1DataSet = new Disconnected_Environtment.ProdiTI1DataSet();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.nmp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prodiTI1DataSet1 = new Disconnected_Environtment.ProdiTI1DataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.prodiTI1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiTI1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiTI1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // prodiTI1DataSetBindingSource
            // 
            this.prodiTI1DataSetBindingSource.DataSource = this.prodiTI1DataSet;
            this.prodiTI1DataSetBindingSource.Position = 0;
            // 
            // prodiTI1DataSet
            // 
            this.prodiTI1DataSet.DataSetName = "ProdiTI1DataSet";
            this.prodiTI1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(142, 344);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(253, 344);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(319, 299);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(378, 126);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "Open\r\n";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // nmp
            // 
            this.nmp.Location = new System.Drawing.Point(182, 299);
            this.nmp.Name = "nmp";
            this.nmp.Size = new System.Drawing.Size(100, 22);
            this.nmp.TabIndex = 5;
            this.nmp.TextChanged += new System.EventHandler(this.nmp_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nama Prodi";
            // 
            // prodiTI1DataSet1
            // 
            this.prodiTI1DataSet1.DataSetName = "ProdiTI1DataSet";
            this.prodiTI1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(108, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // FormDataProdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmp);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Name = "FormDataProdi";
            this.Text = "FormDataProdi";
            this.Load += new System.EventHandler(this.FormDataProdi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prodiTI1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiTI1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiTI1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox nmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource prodiTI1DataSetBindingSource;
        private ProdiTI1DataSet prodiTI1DataSet;
        private ProdiTI1DataSet prodiTI1DataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}