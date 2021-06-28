
namespace Design_Dashboard_Modern
{
    partial class RevisionesFormatoDocentecs
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
            this.CmbSituacion = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmbSituacion
            // 
            this.CmbSituacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSituacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbSituacion.FormattingEnabled = true;
            this.CmbSituacion.Items.AddRange(new object[] {
            "",
            "APROBADA",
            "REPROBADO"});
            this.CmbSituacion.Location = new System.Drawing.Point(445, 349);
            this.CmbSituacion.Name = "CmbSituacion";
            this.CmbSituacion.Size = new System.Drawing.Size(202, 28);
            this.CmbSituacion.TabIndex = 85;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(196, 357);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(243, 20);
            this.label13.TabIndex = 84;
            this.label13.Text = "APROVADA O DESAPROVADA";
            // 
            // RevisionesFormatoDocentecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(845, 501);
            this.Controls.Add(this.CmbSituacion);
            this.Controls.Add(this.label13);
            this.Name = "RevisionesFormatoDocentecs";
            this.Text = "RevisionesFormatoDocentecs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbSituacion;
        private System.Windows.Forms.Label label13;
    }
}