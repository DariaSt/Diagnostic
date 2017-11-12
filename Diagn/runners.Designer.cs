namespace Diagn
{
    partial class runners
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
            this.view_UserDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.diagnosticDataSet = new Diagn.DiagnosticDataSet();
            this.viewRegistrationServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_RegistrationServiceTableAdapter = new Diagn.DiagnosticDataSetTableAdapters.View_RegistrationServiceTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.view_UserDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewRegistrationServiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // view_UserDataGridView
            // 
            this.view_UserDataGridView.AutoGenerateColumns = false;
            this.view_UserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_UserDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.view_UserDataGridView.DataSource = this.viewRegistrationServiceBindingSource;
            this.view_UserDataGridView.Location = new System.Drawing.Point(33, 85);
            this.view_UserDataGridView.Name = "view_UserDataGridView";
            this.view_UserDataGridView.Size = new System.Drawing.Size(846, 263);
            this.view_UserDataGridView.TabIndex = 1;
            this.view_UserDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_UserDataGridView_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 43;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // diagnosticDataSet
            // 
            this.diagnosticDataSet.DataSetName = "DiagnosticDataSet";
            this.diagnosticDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewRegistrationServiceBindingSource
            // 
            this.viewRegistrationServiceBindingSource.DataMember = "View_RegistrationService";
            this.viewRegistrationServiceBindingSource.DataSource = this.diagnosticDataSet;
            // 
            // view_RegistrationServiceTableAdapter
            // 
            this.view_RegistrationServiceTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FullName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Service";
            this.dataGridViewTextBoxColumn3.HeaderText = "Service";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn4.HeaderText = "Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // runners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 397);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.view_UserDataGridView);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "runners";
            this.Text = "Diagnostic 2017";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.runners_FormClosing);
            this.Load += new System.EventHandler(this.runners_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view_UserDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewRegistrationServiceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView view_UserDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DiagnosticDataSet diagnosticDataSet;
        private System.Windows.Forms.BindingSource viewRegistrationServiceBindingSource;
        private DiagnosticDataSetTableAdapters.View_RegistrationServiceTableAdapter view_RegistrationServiceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}