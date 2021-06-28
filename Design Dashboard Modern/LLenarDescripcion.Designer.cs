
namespace Design_Dashboard_Modern
{
    partial class LLenarDescripcion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LLenarDescripcion));
            this.FondoRegistro = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtVolverLLenado = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDescripcionFrom = new System.Windows.Forms.TextBox();
            this.FondoConsulta = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtVolver = new Bunifu.Framework.UI.BunifuFlatButton();
            this.FondoRegistro.SuspendLayout();
            this.FondoConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // FondoRegistro
            // 
            this.FondoRegistro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FondoRegistro.BackgroundImage")));
            this.FondoRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FondoRegistro.Controls.Add(this.BtVolverLLenado);
            this.FondoRegistro.GradientBottomLeft = System.Drawing.Color.Lime;
            this.FondoRegistro.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.FondoRegistro.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.FondoRegistro.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.FondoRegistro.Location = new System.Drawing.Point(478, 618);
            this.FondoRegistro.Name = "FondoRegistro";
            this.FondoRegistro.Quality = 10;
            this.FondoRegistro.Size = new System.Drawing.Size(151, 44);
            this.FondoRegistro.TabIndex = 101;
            // 
            // BtVolverLLenado
            // 
            this.BtVolverLLenado.Activecolor = System.Drawing.Color.Transparent;
            this.BtVolverLLenado.BackColor = System.Drawing.Color.Transparent;
            this.BtVolverLLenado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtVolverLLenado.BorderRadius = 0;
            this.BtVolverLLenado.ButtonText = "     VOLVER            LLENADO";
            this.BtVolverLLenado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtVolverLLenado.DisabledColor = System.Drawing.Color.Gray;
            this.BtVolverLLenado.Iconcolor = System.Drawing.Color.Transparent;
            this.BtVolverLLenado.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtVolverLLenado.Iconimage")));
            this.BtVolverLLenado.Iconimage_right = null;
            this.BtVolverLLenado.Iconimage_right_Selected = null;
            this.BtVolverLLenado.Iconimage_Selected = null;
            this.BtVolverLLenado.IconMarginLeft = 8;
            this.BtVolverLLenado.IconMarginRight = 0;
            this.BtVolverLLenado.IconRightVisible = true;
            this.BtVolverLLenado.IconRightZoom = 0D;
            this.BtVolverLLenado.IconVisible = true;
            this.BtVolverLLenado.IconZoom = 80D;
            this.BtVolverLLenado.IsTab = false;
            this.BtVolverLLenado.Location = new System.Drawing.Point(6, 1);
            this.BtVolverLLenado.Name = "BtVolverLLenado";
            this.BtVolverLLenado.Normalcolor = System.Drawing.Color.Transparent;
            this.BtVolverLLenado.OnHovercolor = System.Drawing.Color.Lime;
            this.BtVolverLLenado.OnHoverTextColor = System.Drawing.Color.White;
            this.BtVolverLLenado.selected = false;
            this.BtVolverLLenado.Size = new System.Drawing.Size(139, 44);
            this.BtVolverLLenado.TabIndex = 28;
            this.BtVolverLLenado.Text = "     VOLVER            LLENADO";
            this.BtVolverLLenado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtVolverLLenado.Textcolor = System.Drawing.Color.White;
            this.BtVolverLLenado.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtVolverLLenado.Click += new System.EventHandler(this.BtVolverLLenado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(420, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 44);
            this.label1.TabIndex = 100;
            this.label1.Text = "DESCRIPCION";
            // 
            // TxtDescripcionFrom
            // 
            this.TxtDescripcionFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDescripcionFrom.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcionFrom.Location = new System.Drawing.Point(32, 57);
            this.TxtDescripcionFrom.Multiline = true;
            this.TxtDescripcionFrom.Name = "TxtDescripcionFrom";
            this.TxtDescripcionFrom.Size = new System.Drawing.Size(1010, 555);
            this.TxtDescripcionFrom.TabIndex = 99;
            // 
            // FondoConsulta
            // 
            this.FondoConsulta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FondoConsulta.BackgroundImage")));
            this.FondoConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FondoConsulta.Controls.Add(this.BtVolver);
            this.FondoConsulta.GradientBottomLeft = System.Drawing.Color.Lime;
            this.FondoConsulta.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.FondoConsulta.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.FondoConsulta.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.FondoConsulta.Location = new System.Drawing.Point(81, 619);
            this.FondoConsulta.Name = "FondoConsulta";
            this.FondoConsulta.Quality = 10;
            this.FondoConsulta.Size = new System.Drawing.Size(151, 44);
            this.FondoConsulta.TabIndex = 102;
            // 
            // BtVolver
            // 
            this.BtVolver.Activecolor = System.Drawing.Color.Transparent;
            this.BtVolver.BackColor = System.Drawing.Color.Transparent;
            this.BtVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtVolver.BorderRadius = 0;
            this.BtVolver.ButtonText = "     VOLVER ";
            this.BtVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtVolver.DisabledColor = System.Drawing.Color.Gray;
            this.BtVolver.Iconcolor = System.Drawing.Color.Transparent;
            this.BtVolver.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtVolver.Iconimage")));
            this.BtVolver.Iconimage_right = null;
            this.BtVolver.Iconimage_right_Selected = null;
            this.BtVolver.Iconimage_Selected = null;
            this.BtVolver.IconMarginLeft = 8;
            this.BtVolver.IconMarginRight = 0;
            this.BtVolver.IconRightVisible = true;
            this.BtVolver.IconRightZoom = 0D;
            this.BtVolver.IconVisible = true;
            this.BtVolver.IconZoom = 80D;
            this.BtVolver.IsTab = false;
            this.BtVolver.Location = new System.Drawing.Point(6, 1);
            this.BtVolver.Name = "BtVolver";
            this.BtVolver.Normalcolor = System.Drawing.Color.Transparent;
            this.BtVolver.OnHovercolor = System.Drawing.Color.Lime;
            this.BtVolver.OnHoverTextColor = System.Drawing.Color.White;
            this.BtVolver.selected = false;
            this.BtVolver.Size = new System.Drawing.Size(139, 44);
            this.BtVolver.TabIndex = 28;
            this.BtVolver.Text = "     VOLVER ";
            this.BtVolver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtVolver.Textcolor = System.Drawing.Color.White;
            this.BtVolver.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtVolver.Click += new System.EventHandler(this.BtVolver_Click);
            // 
            // LLenarDescripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1074, 668);
            this.Controls.Add(this.FondoConsulta);
            this.Controls.Add(this.FondoRegistro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtDescripcionFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LLenarDescripcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LLenarDescripcion";
            this.FondoRegistro.ResumeLayout(false);
            this.FondoConsulta.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel FondoRegistro;
        private Bunifu.Framework.UI.BunifuFlatButton BtVolverLLenado;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TxtDescripcionFrom;
        private Bunifu.Framework.UI.BunifuGradientPanel FondoConsulta;
        private Bunifu.Framework.UI.BunifuFlatButton BtVolver;
    }
}