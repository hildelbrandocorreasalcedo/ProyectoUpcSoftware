
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
            this.DtgAsignatura = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Programa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoAsignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Creditos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmbFiltro = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuGradientPanel6 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtLimpiar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuGradientPanel5 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtConsultar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbFiltroPrograma = new System.Windows.Forms.ComboBox();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtFiltroPrograma = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuGradientPanel3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtFiltroAsignatura = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TxtTotalTipoAsignatura = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtTotalPrograma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtTotalAsignaturas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtgAsignatura)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.bunifuGradientPanel6.SuspendLayout();
            this.bunifuGradientPanel5.SuspendLayout();
            this.bunifuGradientPanel2.SuspendLayout();
            this.bunifuGradientPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DtgAsignatura
            // 
            this.DtgAsignatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgAsignatura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Programa,
            this.TipoAsignatura,
            this.Creditos});
            this.DtgAsignatura.Location = new System.Drawing.Point(76, 163);
            this.DtgAsignatura.Name = "DtgAsignatura";
            this.DtgAsignatura.Size = new System.Drawing.Size(697, 265);
            this.DtgAsignatura.TabIndex = 65;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Programa
            // 
            this.Programa.HeaderText = "Programa";
            this.Programa.Name = "Programa";
            // 
            // TipoAsignatura
            // 
            this.TipoAsignatura.HeaderText = "Tipo de asignatura";
            this.TipoAsignatura.Name = "TipoAsignatura";
            // 
            // Creditos
            // 
            this.Creditos.HeaderText = "Creditos";
            this.Creditos.Name = "Creditos";
            // 
            // CmbFiltro
            // 
            this.CmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbFiltro.FormattingEnabled = true;
            this.CmbFiltro.Items.AddRange(new object[] {
            "TODAS LAS ASIGNATURAS",
            "Teorico/Practico",
            "Teorico",
            "Practico"});
            this.CmbFiltro.Location = new System.Drawing.Point(509, 115);
            this.CmbFiltro.Name = "CmbFiltro";
            this.CmbFiltro.Size = new System.Drawing.Size(254, 28);
            this.CmbFiltro.TabIndex = 61;
            this.CmbFiltro.SelectedIndexChanged += new System.EventHandler(this.CmbFiltro_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(363, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 60;
            this.label7.Text = "Fitro por tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(40, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 59;
            this.label2.Text = "Codigo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(177, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 44);
            this.label1.TabIndex = 58;
            this.label1.Text = "CONSULTAR ASIGNATURAS";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.Location = new System.Drawing.Point(105, 72);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(174, 26);
            this.TxtCodigo.TabIndex = 57;
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
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(642, 445);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(155, 44);
            this.bunifuGradientPanel1.TabIndex = 72;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.bunifuGradientPanel6.Location = new System.Drawing.Point(285, 109);
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
            this.BtLimpiar.Click += new System.EventHandler(this.BtLimpiar_Click);
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
            this.bunifuGradientPanel5.Location = new System.Drawing.Point(285, 54);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(363, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 73;
            this.label6.Text = "de asignatura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(363, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 74;
            this.label3.Text = "Fitro por programa";
            // 
            // CmbFiltroPrograma
            // 
            this.CmbFiltroPrograma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFiltroPrograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbFiltroPrograma.FormattingEnabled = true;
            this.CmbFiltroPrograma.Items.AddRange(new object[] {
            "TODAS LAS ASIGNATURAS",
            "ADMINISTRACION DE EMPRESAS",
            "ADMINISTRACION DE EMPRESAS TURISTICAS Y HOTELERAS",
            "COMERCIO INTERNACIONAL",
            "CONTADURIA PUBLICA ",
            "DERECHO",
            "ECONOMIA",
            "ENFERMERIA",
            "INGENIERIA AGROINDUSTRIAL ",
            "INGENIERIA AMBIENTAL Y SANITARIAS",
            "INGENIERIA SISTEMAS",
            "INGENIERIA ELECTRONICA",
            "INSTRUMENTACION QUIRURGICA SOCIOLOGIA",
            "LICENCIATURA EN ARTE",
            "LICENCIATURA EN CIENCIAS NATURALES Y EDUCACION AMBIENTAL",
            "LICENCIATURA EN EDUCACION FISICA, RECREACION Y DEPORTES",
            "LICENCIATURA EN ESPAÑOL E INGLES",
            "LICENCIATURA EN LITERATURA Y LENGUAS CASTELLANAS",
            "LICENCIATURA EN MATEMATICAS",
            "MICROBIOLOGIA",
            "MUSICA",
            "PSICOLOGIA"});
            this.CmbFiltroPrograma.Location = new System.Drawing.Point(509, 60);
            this.CmbFiltroPrograma.Name = "CmbFiltroPrograma";
            this.CmbFiltroPrograma.Size = new System.Drawing.Size(254, 28);
            this.CmbFiltroPrograma.TabIndex = 75;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.BtFiltroPrograma);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.Lime;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(769, 44);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(55, 44);
            this.bunifuGradientPanel2.TabIndex = 76;
            // 
            // BtFiltroPrograma
            // 
            this.BtFiltroPrograma.Activecolor = System.Drawing.Color.Transparent;
            this.BtFiltroPrograma.BackColor = System.Drawing.Color.Transparent;
            this.BtFiltroPrograma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtFiltroPrograma.BorderRadius = 0;
            this.BtFiltroPrograma.ButtonText = "";
            this.BtFiltroPrograma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtFiltroPrograma.DisabledColor = System.Drawing.Color.Gray;
            this.BtFiltroPrograma.Iconcolor = System.Drawing.Color.Transparent;
            this.BtFiltroPrograma.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtFiltroPrograma.Iconimage")));
            this.BtFiltroPrograma.Iconimage_right = null;
            this.BtFiltroPrograma.Iconimage_right_Selected = null;
            this.BtFiltroPrograma.Iconimage_Selected = null;
            this.BtFiltroPrograma.IconMarginLeft = 8;
            this.BtFiltroPrograma.IconMarginRight = 0;
            this.BtFiltroPrograma.IconRightVisible = true;
            this.BtFiltroPrograma.IconRightZoom = 0D;
            this.BtFiltroPrograma.IconVisible = true;
            this.BtFiltroPrograma.IconZoom = 80D;
            this.BtFiltroPrograma.IsTab = false;
            this.BtFiltroPrograma.Location = new System.Drawing.Point(1, 2);
            this.BtFiltroPrograma.Name = "BtFiltroPrograma";
            this.BtFiltroPrograma.Normalcolor = System.Drawing.Color.Transparent;
            this.BtFiltroPrograma.OnHovercolor = System.Drawing.Color.Lime;
            this.BtFiltroPrograma.OnHoverTextColor = System.Drawing.Color.White;
            this.BtFiltroPrograma.selected = false;
            this.BtFiltroPrograma.Size = new System.Drawing.Size(54, 42);
            this.BtFiltroPrograma.TabIndex = 28;
            this.BtFiltroPrograma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtFiltroPrograma.Textcolor = System.Drawing.Color.White;
            this.BtFiltroPrograma.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtFiltroPrograma.Click += new System.EventHandler(this.BtFiltroPrograma_Click);
            // 
            // bunifuGradientPanel3
            // 
            this.bunifuGradientPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel3.BackgroundImage")));
            this.bunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel3.Controls.Add(this.BtFiltroAsignatura);
            this.bunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.Lime;
            this.bunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel3.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel3.Location = new System.Drawing.Point(770, 99);
            this.bunifuGradientPanel3.Name = "bunifuGradientPanel3";
            this.bunifuGradientPanel3.Quality = 10;
            this.bunifuGradientPanel3.Size = new System.Drawing.Size(55, 44);
            this.bunifuGradientPanel3.TabIndex = 63;
            // 
            // BtFiltroAsignatura
            // 
            this.BtFiltroAsignatura.Activecolor = System.Drawing.Color.Transparent;
            this.BtFiltroAsignatura.BackColor = System.Drawing.Color.Transparent;
            this.BtFiltroAsignatura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtFiltroAsignatura.BorderRadius = 0;
            this.BtFiltroAsignatura.ButtonText = "";
            this.BtFiltroAsignatura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtFiltroAsignatura.DisabledColor = System.Drawing.Color.Gray;
            this.BtFiltroAsignatura.Iconcolor = System.Drawing.Color.Transparent;
            this.BtFiltroAsignatura.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtFiltroAsignatura.Iconimage")));
            this.BtFiltroAsignatura.Iconimage_right = null;
            this.BtFiltroAsignatura.Iconimage_right_Selected = null;
            this.BtFiltroAsignatura.Iconimage_Selected = null;
            this.BtFiltroAsignatura.IconMarginLeft = 8;
            this.BtFiltroAsignatura.IconMarginRight = 0;
            this.BtFiltroAsignatura.IconRightVisible = true;
            this.BtFiltroAsignatura.IconRightZoom = 0D;
            this.BtFiltroAsignatura.IconVisible = true;
            this.BtFiltroAsignatura.IconZoom = 80D;
            this.BtFiltroAsignatura.IsTab = false;
            this.BtFiltroAsignatura.Location = new System.Drawing.Point(1, 2);
            this.BtFiltroAsignatura.Name = "BtFiltroAsignatura";
            this.BtFiltroAsignatura.Normalcolor = System.Drawing.Color.Transparent;
            this.BtFiltroAsignatura.OnHovercolor = System.Drawing.Color.Lime;
            this.BtFiltroAsignatura.OnHoverTextColor = System.Drawing.Color.White;
            this.BtFiltroAsignatura.selected = false;
            this.BtFiltroAsignatura.Size = new System.Drawing.Size(54, 42);
            this.BtFiltroAsignatura.TabIndex = 28;
            this.BtFiltroAsignatura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtFiltroAsignatura.Textcolor = System.Drawing.Color.White;
            this.BtFiltroAsignatura.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtFiltroAsignatura.Click += new System.EventHandler(this.BtFiltroAsignatura_Click);
            // 
            // TxtTotalTipoAsignatura
            // 
            this.TxtTotalTipoAsignatura.Enabled = false;
            this.TxtTotalTipoAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalTipoAsignatura.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TxtTotalTipoAsignatura.Location = new System.Drawing.Point(514, 470);
            this.TxtTotalTipoAsignatura.Name = "TxtTotalTipoAsignatura";
            this.TxtTotalTipoAsignatura.Size = new System.Drawing.Size(66, 26);
            this.TxtTotalTipoAsignatura.TabIndex = 102;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(313, 473);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 20);
            this.label8.TabIndex = 101;
            this.label8.Text = "Total por tipo de asignatura";
            // 
            // TxtTotalPrograma
            // 
            this.TxtTotalPrograma.Enabled = false;
            this.TxtTotalPrograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalPrograma.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TxtTotalPrograma.Location = new System.Drawing.Point(514, 434);
            this.TxtTotalPrograma.Name = "TxtTotalPrograma";
            this.TxtTotalPrograma.Size = new System.Drawing.Size(66, 26);
            this.TxtTotalPrograma.TabIndex = 100;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(372, 439);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 99;
            this.label4.Text = "Total por programa";
            // 
            // TxtTotalAsignaturas
            // 
            this.TxtTotalAsignaturas.Enabled = false;
            this.TxtTotalAsignaturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalAsignaturas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TxtTotalAsignaturas.Location = new System.Drawing.Point(241, 453);
            this.TxtTotalAsignaturas.Name = "TxtTotalAsignaturas";
            this.TxtTotalAsignaturas.Size = new System.Drawing.Size(66, 26);
            this.TxtTotalAsignaturas.TabIndex = 98;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(80, 456);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 20);
            this.label5.TabIndex = 97;
            this.label5.Text = "Total de Asignaturas";
            // 
            // ConsultaAsignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(845, 501);
            this.Controls.Add(this.TxtTotalTipoAsignatura);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtTotalPrograma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtTotalAsignaturas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bunifuGradientPanel3);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.CmbFiltroPrograma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bunifuGradientPanel6);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.bunifuGradientPanel5);
            this.Controls.Add(this.DtgAsignatura);
            this.Controls.Add(this.CmbFiltro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCodigo);
            this.Name = "ConsultaAsignatura";
            this.Text = "ConsultaAsignatura";
            this.Load += new System.EventHandler(this.ConsultaAsignatura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgAsignatura)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel6.ResumeLayout(false);
            this.bunifuGradientPanel5.ResumeLayout(false);
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DtgAsignatura;
        private System.Windows.Forms.ComboBox CmbFiltro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCodigo;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel6;
        private Bunifu.Framework.UI.BunifuFlatButton BtLimpiar;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel5;
        private Bunifu.Framework.UI.BunifuFlatButton BtConsultar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbFiltroPrograma;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuFlatButton BtFiltroPrograma;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel3;
        private Bunifu.Framework.UI.BunifuFlatButton BtFiltroAsignatura;
        private System.Windows.Forms.TextBox TxtTotalTipoAsignatura;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtTotalPrograma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtTotalAsignaturas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Programa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoAsignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Creditos;
    }
}