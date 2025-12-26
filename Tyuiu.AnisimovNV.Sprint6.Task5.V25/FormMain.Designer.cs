namespace Tyuiu.AnisimovNV.Sprint6.Task5.V25
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridView_NVA = new System.Windows.Forms.DataGridView();
            this.buttonLoad_NVA = new System.Windows.Forms.Button();
            this.buttonHelp_NVA = new System.Windows.Forms.Button();
            this.labelStatus_NVA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NVA)).BeginInit();
            this.SuspendLayout();

            // dataGridView_NVA
            this.dataGridView_NVA.AllowUserToAddRows = false;
            this.dataGridView_NVA.AllowUserToDeleteRows = false;
            this.dataGridView_NVA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_NVA.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_NVA.Name = "dataGridView_NVA";
            this.dataGridView_NVA.ReadOnly = true;
            this.dataGridView_NVA.Size = new System.Drawing.Size(300, 300);
            this.dataGridView_NVA.TabIndex = 0;

            // buttonLoad_NVA
            this.buttonLoad_NVA.Location = new System.Drawing.Point(12, 320);
            this.buttonLoad_NVA.Name = "buttonLoad_NVA";
            this.buttonLoad_NVA.Size = new System.Drawing.Size(100, 30);
            this.buttonLoad_NVA.TabIndex = 1;
            this.buttonLoad_NVA.Text = "Загрузить";
            this.buttonLoad_NVA.UseVisualStyleBackColor = true;
            this.buttonLoad_NVA.Click += new System.EventHandler(this.buttonLoad_NVA_Click);

            // buttonHelp_NVA
            this.buttonHelp_NVA.Location = new System.Drawing.Point(120, 320);
            this.buttonHelp_NVA.Name = "buttonHelp_NVA";
            this.buttonHelp_NVA.Size = new System.Drawing.Size(80, 30);
            this.buttonHelp_NVA.TabIndex = 2;
            this.buttonHelp_NVA.Text = "Справка";
            this.buttonHelp_NVA.UseVisualStyleBackColor = true;
            this.buttonHelp_NVA.Click += new System.EventHandler(this.buttonHelp_NVA_Click);

            // labelStatus_NVA
            this.labelStatus_NVA.AutoSize = true;
            this.labelStatus_NVA.Location = new System.Drawing.Point(12, 360);
            this.labelStatus_NVA.Name = "labelStatus_NVA";
            this.labelStatus_NVA.Size = new System.Drawing.Size(140, 13);
            this.labelStatus_NVA.TabIndex = 3;
            this.labelStatus_NVA.Text = "Нажмите \"Загрузить\"";

            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 382);
            this.Controls.Add(this.labelStatus_NVA);
            this.Controls.Add(this.buttonHelp_NVA);
            this.Controls.Add(this.buttonLoad_NVA);
            this.Controls.Add(this.dataGridView_NVA);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 25 | Анисимов Н.В.";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NVA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridView_NVA;
        private System.Windows.Forms.Button buttonLoad_NVA;
        private System.Windows.Forms.Button buttonHelp_NVA;
        private System.Windows.Forms.Label labelStatus_NVA;
    }
}