
namespace Design_Dashboard_Modern
{
    partial class ConsultaAsignatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaAsignatura));
            this.TxtTotalVotaron = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtConteoNoVotaron = new System.Windows.Forms.TextBox();
            this.TxtConteoVotaron = new System.Windows.Forms.TextBox();
            this.DtgAsignatura = new System.Windows.Forms.DataGridView();
            this.Identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Voto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroVoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmbFiltro = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuGradientPanel6 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtLimpiar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuGradientPanel5 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtConsultar = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.DtgAsignatura)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.bunifuGradientPanel6.SuspendLayout();
            this.bunifuGradientPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtTotalVotaron
            // 
            this.TxtTotalVotaron.Enabled = false;
            this.TxtTotalVotaron.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalVotaron.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TxtTotalVotaron.Location = new System.Drawing.Point(747, 191);
            this.TxtTotalVotaron.Name = "TxtTotalVotaron";
            this.TxtTotalVotaron.Size = new System.Drawing.Size(66, 26);
            this.TxtTotalVotaron.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(627, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 70;
            this.label5.Text = "TOTAL VOTOS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(627, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 69;
            this.label4.Text = "NO VOTARON";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(627, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 68;
            this.label3.Text = "SI VOTARON";
            // 
            // TxtConteoNoVotaron
            // 
            this.TxtConteoNoVotaron.Enabled = false;
            this.TxtConteoNoVotaron.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConteoNoVotaron.Location = new System.Drawing.Point(747, 283);
            this.TxtConteoNoVotaron.Name = "TxtConteoNoVotaron";
            this.TxtConteoNoVotaron.Size = new System.Drawing.Size(66, 26);
            this.TxtConteoNoVotaron.TabIndex = 67;
            // 
            // TxtConteoVotaron
            // 
            this.TxtConteoVotaron.Enabled = false;
            this.TxtConteoVotaron.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConteoVotaron.Location = new System.Drawing.Point(747, 238);
            this.TxtConteoVotaron.Name = "TxtConteoVotaron";
            this.TxtConteoVotaron.Size = new System.Drawing.Size(66, 26);
            this.TxtConteoVotaron.TabIndex = 66;
            // 
            // DtgAsignatura
            // 
            this.DtgAsignatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgAsignatura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identificacion,
            this.Nombre,
            this.Voto,
            this.NumeroVoto});
            this.DtgAsignatura.Location = new System.Drawing.Point(32, 131);
            this.DtgAsignatura.Name = "DtgAsignatura";
            this.DtgAsignatura.Size = new System.Drawing.Size(572, 356);
            this.DtgAsignatura.TabIndex = 65;
            // 
            // Identificacion
            // 
            this.Identificacion.HeaderText = "Identificacion";
            this.Identificacion.Name = "Identificacion";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MaxInputLength = 42767;
            this.Nombre.Name = "Nombre";
            // 
            // Voto
            // 
            this.Voto.HeaderText = "Voto";
            this.Voto.Name = "Voto";
            // 
            // NumeroVoto
            // 
            this.NumeroVoto.HeaderText = "Numero de voto";
            this.NumeroVoto.Name = "NumeroVoto";
            // 
            // CmbFiltro
            // 
            this.CmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbFiltro.FormattingEnabled = true;
            this.CmbFiltro.Items.AddRange(new object[] {
            "SI",
            "NO",
            "TODOS"});
            this.CmbFiltro.Location = new System.Drawing.Point(587, 82);
            this.CmbFiltro.Name = "CmbFiltro";
            this.CmbFiltro.Size = new System.Drawing.Size(111, 28);
            this.CmbFiltro.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(475, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 60;
            this.label7.Text = "Fitro por Voto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(32, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 59;
            this.label2.Text = "Identificacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(209, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 44);
            this.label1.TabIndex = 58;
            this.label1.Text = "CONSULTA ESTUDIANTES";
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdentificacion.Location = new System.Drawing.Point(147, 85);
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(174, 26);
            this.TxtIdentificacion.TabIndex = 57;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.button1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Lime;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(658, 433);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(155, 44);
            this.bunifuGradientPanel1.TabIndex = 72;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(5, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 44);
            this.button1.TabIndex = 13;
            this.button1.Text = "CANCELAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // bunifuGradientPanel6
            // 
            this.bunifuGradientPanel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel6.BackgroundImage")));
            this.bunifuGradientPanel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel6.Controls.Add(this.BtLimpiar);
            this.bunifuGradientPanel6.GradientBottomLeft = System.Drawing.Color.Lime;
            this.bunifuGradientPanel6.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel6.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel6.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel6.Location = new System.Drawing.Point(402, 67);
            this.bunifuGradientPanel6.Name = "bunifuGradientPanel6";
            this.bunifuGradientPanel6.Quality = 10;
            this.bunifuGradientPanel6.Size = new System.Drawing.Size(55, 44);
            this.bunifuGradientPanel6.TabIndex = 61;
            // 
            // BtLimpiar
            // 
            this.BtLimpiar.Activecolor = System.Drawing.Color.Transparent;
            this.BtLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.BtLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtLimpiar.BorderRadius = 0;
            this.BtLimpiar.ButtonText = "";
            this.BtLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtLimpiar.DisabledColor = System.Drawing.Color.Gray;
            this.BtLimpiar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtLimpiar.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtLimpiar.Iconimage")));
            this.BtLimpiar.Iconimage_right = null;
            this.BtLimpiar.Iconimage_right_Selected = null;
            this.BtLimpiar.Iconimage_Selected = null;
            this.BtLimpiar.IconMarginLeft = 8;
            this.BtLimpiar.IconMarginRight = 0;
            this.BtLimpiar.IconRightVisible = true;
            this.BtLimpiar.IconRightZoom = 0D;
            this.BtLimpiar.IconVisible = true;
            this.BtLimpiar.IconZoom = 80D;
            this.BtLimpiar.IsTab = false;
            this.BtLimpiar.Location = new System.Drawing.Point(0, 1);
            this.BtLimpiar.Name = "BtLimpiar";
            this.BtLimpiar.Normalcolor = System.Drawing.Color.Transparent;
            this.BtLimpiar.OnHovercolor = System.Drawing.Color.Lime;
            this.BtLimpiar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtLimpiar.selected = false;
            this.BtLimpiar.Size = new System.Drawing.Size(55, 43);
            this.BtLimpiar.TabIndex = 28;
            this.BtLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtLimpiar.Textcolor = System.Drawing.Color.White;
            this.BtLimpiar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // bunifuGradientPanel5
            // 
            this.bunifuGradientPanel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel5.BackgroundImage")));
            this.bunifuGradientPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel5.Controls.Add(this.BtConsultar);
            this.bunifuGradientPanel5.GradientBottomLeft = System.Drawing.Color.Lime;
            this.bunifuGradientPanel5.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel5.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel5.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel5.Location = new System.Drawing.Point(336, 67);
            this.bunifuGradientPanel5.Name = "bunifuGradientPanel5";
            this.bunifuGradientPanel5.Quality = 10;
            this.bunifuGradientPanel5.Size = new System.Drawing.Size(55, 44);
            this.bunifuGradientPanel5.TabIndex = 62;
            // 
            // BtConsultar
            // 
            this.BtConsultar.Activecolor = System.Drawing.Color.Transparent;
            this.BtConsultar.BackColor = System.Drawing.Color.Transparent;
            this.BtConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtConsultar.BorderRadius = 0;
            this.BtConsultar.ButtonText = "";
            this.BtConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtConsultar.DisabledColor = System.Drawing.Color.Gray;
            this.BtConsultar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtConsultar.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtConsultar.Iconimage")));
            this.BtConsultar.Iconimage_right = null;
            this.BtConsultar.Iconimage_right_Selected = null;
            this.BtConsultar.Iconimage_Selected = null;
            this.BtConsultar.IconMarginLeft = 8;
            this.BtConsultar.IconMarginRight = 0;
            this.BtConsultar.IconRightVisible = true;
            this.BtConsultar.IconRightZoom = 0D;
            this.BtConsultar.IconVisible = true;
            this.BtConsultar.IconZoom = 80D;
            this.BtConsultar.IsTab = false;
            this.BtConsultar.Location = new System.Drawing.Point(1, 2);
            this.BtConsultar.Name = "BtConsultar";
            this.BtConsultar.Normalcolor = System.Drawing.Color.Transparent;
            this.BtConsultar.OnHovercolor = System.Drawing.Color.Lime;
            this.BtConsultar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtConsultar.selected = false;
            this.BtConsultar.Size = new System.Drawing.Size(54, 42);
            this.BtConsultar.TabIndex = 28;
            this.BtConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtConsultar.Textcolor = System.Drawing.Color.White;
            this.BtConsultar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtConsultar.Click += new System.EventHandler(this.BtConsultar_Click);
            // 
            // ConsultaAsignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(845, 501);
            this.Controls.Add(this.bunifuGradientPanel6);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.bunifuGradientPanel5);
            this.Controls.Add(this.TxtTotalVotaron);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtConteoNoVotaron);
            this.Controls.Add(this.TxtConteoVotaron);
            this.Controls.Add(this.DtgAsignatura);
            this.Controls.Add(this.CmbFiltro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtIdentificacion);
            this.Name = "ConsultaAsignatura";
            this.Text = "ConsultaAsignatura";
            ((System.ComponentModel.ISupportInitialize)(this.DtgAsignatura)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel6.ResumeLayout(false);
            this.bunifuGradientPanel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtTotalVotaron;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtConteoNoVotaron;
        private System.Windows.Forms.TextBox TxtConteoVotaron;
        private System.Windows.Forms.DataGridView DtgAsignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Voto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroVoto;
        private System.Windows.Forms.ComboBox CmbFiltro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtIdentificacion;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel6;
        private Bunifu.Framework.UI.BunifuFlatButton BtLimpiar;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel5;
        private Bunifu.Framework.UI.BunifuFlatButton BtConsultar;
    }
}