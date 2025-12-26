namespace Tyuiu.AnisimovNV.Sprint6.Task4.V5
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxTask_NVA = new System.Windows.Forms.GroupBox();
            this.pictureBoxTask_NVA = new System.Windows.Forms.PictureBox();
            this.textBoxTask_NVA = new System.Windows.Forms.TextBox();
            this.groupBoxResult_NVA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_NVA = new System.Windows.Forms.TextBox();
            this.groupBoxGraph_NVA = new System.Windows.Forms.GroupBox();
            this.pictureBoxGraph_NVA = new System.Windows.Forms.PictureBox();
            this.buttonDone_NVA = new System.Windows.Forms.Button();
            this.buttonSave_NVA = new System.Windows.Forms.Button();
            this.buttonHelp_NVA = new System.Windows.Forms.Button();
            this.groupBoxTask_NVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_NVA)).BeginInit();
            this.groupBoxResult_NVA.SuspendLayout();
            this.groupBoxGraph_NVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraph_NVA)).BeginInit();
            this.SuspendLayout();

            // groupBoxTask_NVA
            this.groupBoxTask_NVA.Controls.Add(this.pictureBoxTask_NVA);
            this.groupBoxTask_NVA.Controls.Add(this.textBoxTask_NVA);
            this.groupBoxTask_NVA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_NVA.Name = "groupBoxTask_NVA";
            this.groupBoxTask_NVA.Size = new System.Drawing.Size(450, 150);
            this.groupBoxTask_NVA.TabIndex = 0;
            this.groupBoxTask_NVA.TabStop = false;
            this.groupBoxTask_NVA.Text = "Условие";

            // pictureBoxTask_NVA
            this.pictureBoxTask_NVA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTask_NVA.Image")));
            this.pictureBoxTask_NVA.Location = new System.Drawing.Point(10, 40);
            this.pictureBoxTask_NVA.Name = "pictureBoxTask_NVA";
            this.pictureBoxTask_NVA.Size = new System.Drawing.Size(350, 50);
            this.pictureBoxTask_NVA.TabIndex = 1;
            this.pictureBoxTask_NVA.TabStop = false;

            // textBoxTask_NVA
            this.textBoxTask_NVA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_NVA.Location = new System.Drawing.Point(10, 20);
            this.textBoxTask_NVA.Name = "textBoxTask_NVA";
            this.textBoxTask_NVA.ReadOnly = true;
            this.textBoxTask_NVA.Size = new System.Drawing.Size(400, 13);
            this.textBoxTask_NVA.TabIndex = 0;
            this.textBoxTask_NVA.Text = "Табулировать функцию F(x) = (2*sin(x))/(3*x+1.2) + cos(x) - 7*x*2 на диапазоне [-5; 5] с шагом 1";

            // groupBoxResult_NVA
            this.groupBoxResult_NVA.Controls.Add(this.textBoxResult_NVA);
            this.groupBoxResult_NVA.Location = new System.Drawing.Point(12, 168);
            this.groupBoxResult_NVA.Name = "groupBoxResult_NVA";
            this.groupBoxResult_NVA.Size = new System.Drawing.Size(320, 200);
            this.groupBoxResult_NVA.TabIndex = 1;
            this.groupBoxResult_NVA.TabStop = false;
            this.groupBoxResult_NVA.Text = "Таблица значений";

            // textBoxResult_NVA
            this.textBoxResult_NVA.Location = new System.Drawing.Point(6, 19);
            this.textBoxResult_NVA.Multiline = true;
            this.textBoxResult_NVA.Name = "textBoxResult_NVA";
            this.textBoxResult_NVA.ReadOnly = true;
            this.textBoxResult_NVA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_NVA.Size = new System.Drawing.Size(308, 175);
            this.textBoxResult_NVA.TabIndex = 0;

            // groupBoxGraph_NVA
            this.groupBoxGraph_NVA.Controls.Add(this.pictureBoxGraph_NVA);
            this.groupBoxGraph_NVA.Location = new System.Drawing.Point(338, 168);
            this.groupBoxGraph_NVA.Name = "groupBoxGraph_NVA";
            this.groupBoxGraph_NVA.Size = new System.Drawing.Size(420, 200);
            this.groupBoxGraph_NVA.TabIndex = 2;
            this.groupBoxGraph_NVA.TabStop = false;
            this.groupBoxGraph_NVA.Text = "График функции";

            // pictureBoxGraph_NVA
            this.pictureBoxGraph_NVA.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxGraph_NVA.Name = "pictureBoxGraph_NVA";
            this.pictureBoxGraph_NVA.Size = new System.Drawing.Size(408, 175);
            this.pictureBoxGraph_NVA.TabIndex = 0;
            this.pictureBoxGraph_NVA.TabStop = false;

            // buttonDone_NVA
            this.buttonDone_NVA.Location = new System.Drawing.Point(12, 374);
            this.buttonDone_NVA.Name = "buttonDone_NVA";
            this.buttonDone_NVA.Size = new System.Drawing.Size(100, 38);
            this.buttonDone_NVA.TabIndex = 3;
            this.buttonDone_NVA.Text = "Выполнить";
            this.buttonDone_NVA.UseVisualStyleBackColor = true;
            this.buttonDone_NVA.Click += new System.EventHandler(this.buttonDone_NVA_Click);

            // buttonSave_NVA
            this.buttonSave_NVA.Enabled = false;
            this.buttonSave_NVA.Location = new System.Drawing.Point(118, 374);
            this.buttonSave_NVA.Name = "buttonSave_NVA";
            this.buttonSave_NVA.Size = new System.Drawing.Size(100, 38);
            this.buttonSave_NVA.TabIndex = 4;
            this.buttonSave_NVA.Text = "Сохранить";
            this.buttonSave_NVA.UseVisualStyleBackColor = true;
            this.buttonSave_NVA.Click += new System.EventHandler(this.buttonSave_NVA_Click);

            // buttonHelp_NVA
            this.buttonHelp_NVA.BackColor = System.Drawing.SystemColors.Window;
            this.buttonHelp_NVA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_NVA.Location = new System.Drawing.Point(224, 374);
            this.buttonHelp_NVA.Name = "buttonHelp_NVA";
            this.buttonHelp_NVA.Size = new System.Drawing.Size(37, 37);
            this.buttonHelp_NVA.TabIndex = 5;
            this.buttonHelp_NVA.Text = "?";
            this.buttonHelp_NVA.UseVisualStyleBackColor = false;
            this.buttonHelp_NVA.Click += new System.EventHandler(this.buttonHelp_NVA_Click);

            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 424);
            this.Controls.Add(this.buttonHelp_NVA);
            this.Controls.Add(this.buttonSave_NVA);
            this.Controls.Add(this.buttonDone_NVA);
            this.Controls.Add(this.groupBoxGraph_NVA);
            this.Controls.Add(this.groupBoxResult_NVA);
            this.Controls.Add(this.groupBoxTask_NVA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 5 | Анисимов Н.В.";
            this.groupBoxTask_NVA.ResumeLayout(false);
            this.groupBoxTask_NVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_NVA)).EndInit();
            this.groupBoxResult_NVA.ResumeLayout(false);
            this.groupBoxResult_NVA.PerformLayout();
            this.groupBoxGraph_NVA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraph_NVA)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_NVA;
        private System.Windows.Forms.PictureBox pictureBoxTask_NVA;
        private System.Windows.Forms.TextBox textBoxTask_NVA;
        private System.Windows.Forms.GroupBox groupBoxResult_NVA;
        private System.Windows.Forms.TextBox textBoxResult_NVA;
        private System.Windows.Forms.GroupBox groupBoxGraph_NVA;
        private System.Windows.Forms.PictureBox pictureBoxGraph_NVA;
        private System.Windows.Forms.Button buttonDone_NVA;
        private System.Windows.Forms.Button buttonSave_NVA;
        private System.Windows.Forms.Button buttonHelp_NVA;
    }
}