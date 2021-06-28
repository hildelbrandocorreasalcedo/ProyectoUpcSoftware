namespace ProyectoHotelPensionados
{
    partial class MenuUpcDocente
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuUpcDocente));
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.SidebarWrapper = new System.Windows.Forms.Panel();
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelSideMenu = new System.Windows.Forms.Panel();
            this.BtActualizacionPlanAsignatura = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtConsultarAsignatura = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtConsultarRespuestaComite = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtRegistrarSolicitudActualizacionPlan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtConsultarDocente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtConsultarPlanAsignatura = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LineaSidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PanelHijo = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.CurvaSidebar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.AnimacionSidebarBack = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Restaurar = new System.Windows.Forms.PictureBox();
            this.Maximizar = new System.Windows.Forms.PictureBox();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MenuSidebar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.AnimacionSidebar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.MoverDashboard = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.RadioPanelChart = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SidebarWrapper.SuspendLayout();
            this.Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelSideMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.PanelHijo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSidebar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // SidebarWrapper
            // 
            this.SidebarWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.SidebarWrapper.Controls.Add(this.Sidebar);
            this.AnimacionSidebar.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.SidebarWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarWrapper.Location = new System.Drawing.Point(0, 75);
            this.SidebarWrapper.Name = "SidebarWrapper";
            this.SidebarWrapper.Size = new System.Drawing.Size(280, 563);
            this.SidebarWrapper.TabIndex = 21;
            this.SidebarWrapper.Paint += new System.Windows.Forms.PaintEventHandler(this.SidebarWrapper_Paint);
            // 
            // Sidebar
            // 
            this.Sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sidebar.BackgroundImage")));
            this.Sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sidebar.Controls.Add(this.pictureBox1);
            this.Sidebar.Controls.Add(this.PanelSideMenu);
            this.Sidebar.Controls.Add(this.LineaSidebar);
            this.Sidebar.Controls.Add(this.label4);
            this.AnimacionSidebar.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar.GradientBottomLeft = System.Drawing.Color.Lime;
            this.Sidebar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.Sidebar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.Sidebar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.Sidebar.Location = new System.Drawing.Point(11, 11);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Quality = 10;
            this.Sidebar.Size = new System.Drawing.Size(260, 540);
            this.Sidebar.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // PanelSideMenu
            // 
            this.PanelSideMenu.AutoScroll = true;
            this.PanelSideMenu.BackColor = System.Drawing.Color.Transparent;
            this.PanelSideMenu.Controls.Add(this.BtActualizacionPlanAsignatura);
            this.PanelSideMenu.Controls.Add(this.BtConsultarAsignatura);
            this.PanelSideMenu.Controls.Add(this.BtConsultarRespuestaComite);
            this.PanelSideMenu.Controls.Add(this.BtRegistrarSolicitudActualizacionPlan);
            this.PanelSideMenu.Controls.Add(this.BtConsultarDocente);
            this.PanelSideMenu.Controls.Add(this.BtConsultarPlanAsignatura);
            this.AnimacionSidebar.SetDecoration(this.PanelSideMenu, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.PanelSideMenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelSideMenu.Location = new System.Drawing.Point(8, 75);
            this.PanelSideMenu.Name = "PanelSideMenu";
            this.PanelSideMenu.Size = new System.Drawing.Size(245, 384);
            this.PanelSideMenu.TabIndex = 2;
            // 
            // BtActualizacionPlanAsignatura
            // 
            this.BtActualizacionPlanAsignatura.Activecolor = System.Drawing.Color.Transparent;
            this.BtActualizacionPlanAsignatura.BackColor = System.Drawing.Color.Transparent;
            this.BtActualizacionPlanAsignatura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtActualizacionPlanAsignatura.BorderRadius = 0;
            this.BtActualizacionPlanAsignatura.ButtonText = "           ACTUALIZACION DE                    PLAN DE ASIGNATURA";
            this.BtActualizacionPlanAsignatura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.BtActualizacionPlanAsignatura, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.BtActualizacionPlanAsignatura, BunifuAnimatorNS.DecorationType.None);
            this.BtActualizacionPlanAsignatura.DisabledColor = System.Drawing.Color.Gray;
            this.BtActualizacionPlanAsignatura.Iconcolor = System.Drawing.Color.Transparent;
            this.BtActualizacionPlanAsignatura.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtActualizacionPlanAsignatura.Iconimage")));
            this.BtActualizacionPlanAsignatura.Iconimage_right = null;
            this.BtActualizacionPlanAsignatura.Iconimage_right_Selected = null;
            this.BtActualizacionPlanAsignatura.Iconimage_Selected = null;
            this.BtActualizacionPlanAsignatura.IconMarginLeft = 12;
            this.BtActualizacionPlanAsignatura.IconMarginRight = 0;
            this.BtActualizacionPlanAsignatura.IconRightVisible = true;
            this.BtActualizacionPlanAsignatura.IconRightZoom = 0D;
            this.BtActualizacionPlanAsignatura.IconVisible = true;
            this.BtActualizacionPlanAsignatura.IconZoom = 80D;
            this.BtActualizacionPlanAsignatura.IsTab = false;
            this.BtActualizacionPlanAsignatura.Location = new System.Drawing.Point(0, 264);
            this.BtActualizacionPlanAsignatura.Margin = new System.Windows.Forms.Padding(6);
            this.BtActualizacionPlanAsignatura.Name = "BtActualizacionPlanAsignatura";
            this.BtActualizacionPlanAsignatura.Normalcolor = System.Drawing.Color.Transparent;
            this.BtActualizacionPlanAsignatura.OnHovercolor = System.Drawing.Color.Lime;
            this.BtActualizacionPlanAsignatura.OnHoverTextColor = System.Drawing.Color.White;
            this.BtActualizacionPlanAsignatura.selected = false;
            this.BtActualizacionPlanAsignatura.Size = new System.Drawing.Size(244, 48);
            this.BtActualizacionPlanAsignatura.TabIndex = 22;
            this.BtActualizacionPlanAsignatura.Text = "           ACTUALIZACION DE                    PLAN DE ASIGNATURA";
            this.BtActualizacionPlanAsignatura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtActualizacionPlanAsignatura.Textcolor = System.Drawing.Color.LightGray;
            this.BtActualizacionPlanAsignatura.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtActualizacionPlanAsignatura.Click += new System.EventHandler(this.BtGenerarFactura_Click);
            // 
            // BtConsultarAsignatura
            // 
            this.BtConsultarAsignatura.Activecolor = System.Drawing.Color.Transparent;
            this.BtConsultarAsignatura.BackColor = System.Drawing.Color.Transparent;
            this.BtConsultarAsignatura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtConsultarAsignatura.BorderRadius = 0;
            this.BtConsultarAsignatura.ButtonText = "       CONSULTAR ASIGNATURA";
            this.BtConsultarAsignatura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.BtConsultarAsignatura, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.BtConsultarAsignatura, BunifuAnimatorNS.DecorationType.None);
            this.BtConsultarAsignatura.DisabledColor = System.Drawing.Color.Gray;
            this.BtConsultarAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtConsultarAsignatura.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BtConsultarAsignatura.Iconcolor = System.Drawing.Color.Transparent;
            this.BtConsultarAsignatura.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtConsultarAsignatura.Iconimage")));
            this.BtConsultarAsignatura.Iconimage_right = null;
            this.BtConsultarAsignatura.Iconimage_right_Selected = null;
            this.BtConsultarAsignatura.Iconimage_Selected = null;
            this.BtConsultarAsignatura.IconMarginLeft = 9;
            this.BtConsultarAsignatura.IconMarginRight = 0;
            this.BtConsultarAsignatura.IconRightVisible = true;
            this.BtConsultarAsignatura.IconRightZoom = 0D;
            this.BtConsultarAsignatura.IconVisible = true;
            this.BtConsultarAsignatura.IconZoom = 90D;
            this.BtConsultarAsignatura.IsTab = false;
            this.BtConsultarAsignatura.Location = new System.Drawing.Point(-1, 0);
            this.BtConsultarAsignatura.Name = "BtConsultarAsignatura";
            this.BtConsultarAsignatura.Normalcolor = System.Drawing.Color.Transparent;
            this.BtConsultarAsignatura.OnHovercolor = System.Drawing.Color.Lime;
            this.BtConsultarAsignatura.OnHoverTextColor = System.Drawing.Color.White;
            this.BtConsultarAsignatura.selected = false;
            this.BtConsultarAsignatura.Size = new System.Drawing.Size(245, 48);
            this.BtConsultarAsignatura.TabIndex = 26;
            this.BtConsultarAsignatura.Text = "       CONSULTAR ASIGNATURA";
            this.BtConsultarAsignatura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtConsultarAsignatura.Textcolor = System.Drawing.Color.LightGray;
            this.BtConsultarAsignatura.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtConsultarAsignatura.Click += new System.EventHandler(this.BtConsultarAsignatura_Click);
            // 
            // BtConsultarRespuestaComite
            // 
            this.BtConsultarRespuestaComite.Activecolor = System.Drawing.Color.Transparent;
            this.BtConsultarRespuestaComite.BackColor = System.Drawing.Color.Transparent;
            this.BtConsultarRespuestaComite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtConsultarRespuestaComite.BorderRadius = 0;
            this.BtConsultarRespuestaComite.ButtonText = "        CONSULTAR RESPUESTA           DE COMITE CURRICULAR";
            this.BtConsultarRespuestaComite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.BtConsultarRespuestaComite, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.BtConsultarRespuestaComite, BunifuAnimatorNS.DecorationType.None);
            this.BtConsultarRespuestaComite.DisabledColor = System.Drawing.Color.Gray;
            this.BtConsultarRespuestaComite.Iconcolor = System.Drawing.Color.Transparent;
            this.BtConsultarRespuestaComite.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtConsultarRespuestaComite.Iconimage")));
            this.BtConsultarRespuestaComite.Iconimage_right = null;
            this.BtConsultarRespuestaComite.Iconimage_right_Selected = null;
            this.BtConsultarRespuestaComite.Iconimage_Selected = null;
            this.BtConsultarRespuestaComite.IconMarginLeft = 10;
            this.BtConsultarRespuestaComite.IconMarginRight = 0;
            this.BtConsultarRespuestaComite.IconRightVisible = true;
            this.BtConsultarRespuestaComite.IconRightZoom = 0D;
            this.BtConsultarRespuestaComite.IconVisible = true;
            this.BtConsultarRespuestaComite.IconZoom = 78D;
            this.BtConsultarRespuestaComite.IsTab = false;
            this.BtConsultarRespuestaComite.Location = new System.Drawing.Point(0, 212);
            this.BtConsultarRespuestaComite.Margin = new System.Windows.Forms.Padding(6);
            this.BtConsultarRespuestaComite.Name = "BtConsultarRespuestaComite";
            this.BtConsultarRespuestaComite.Normalcolor = System.Drawing.Color.Transparent;
            this.BtConsultarRespuestaComite.OnHovercolor = System.Drawing.Color.Lime;
            this.BtConsultarRespuestaComite.OnHoverTextColor = System.Drawing.Color.White;
            this.BtConsultarRespuestaComite.selected = false;
            this.BtConsultarRespuestaComite.Size = new System.Drawing.Size(245, 48);
            this.BtConsultarRespuestaComite.TabIndex = 23;
            this.BtConsultarRespuestaComite.Text = "        CONSULTAR RESPUESTA           DE COMITE CURRICULAR";
            this.BtConsultarRespuestaComite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtConsultarRespuestaComite.Textcolor = System.Drawing.Color.LightGray;
            this.BtConsultarRespuestaComite.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtConsultarRespuestaComite.Click += new System.EventHandler(this.BtConsultarRespuestaComite_Click);
            // 
            // BtRegistrarSolicitudActualizacionPlan
            // 
            this.BtRegistrarSolicitudActualizacionPlan.Activecolor = System.Drawing.Color.Transparent;
            this.BtRegistrarSolicitudActualizacionPlan.BackColor = System.Drawing.Color.Transparent;
            this.BtRegistrarSolicitudActualizacionPlan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtRegistrarSolicitudActualizacionPlan.BorderRadius = 0;
            this.BtRegistrarSolicitudActualizacionPlan.ButtonText = "      SOLICITUD  ACTUALIZACION         DEL PLAN DE  ASIGNATURA";
            this.BtRegistrarSolicitudActualizacionPlan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.BtRegistrarSolicitudActualizacionPlan, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.BtRegistrarSolicitudActualizacionPlan, BunifuAnimatorNS.DecorationType.None);
            this.BtRegistrarSolicitudActualizacionPlan.DisabledColor = System.Drawing.Color.Gray;
            this.BtRegistrarSolicitudActualizacionPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtRegistrarSolicitudActualizacionPlan.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BtRegistrarSolicitudActualizacionPlan.Iconcolor = System.Drawing.Color.Transparent;
            this.BtRegistrarSolicitudActualizacionPlan.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtRegistrarSolicitudActualizacionPlan.Iconimage")));
            this.BtRegistrarSolicitudActualizacionPlan.Iconimage_right = null;
            this.BtRegistrarSolicitudActualizacionPlan.Iconimage_right_Selected = null;
            this.BtRegistrarSolicitudActualizacionPlan.Iconimage_Selected = null;
            this.BtRegistrarSolicitudActualizacionPlan.IconMarginLeft = 10;
            this.BtRegistrarSolicitudActualizacionPlan.IconMarginRight = 0;
            this.BtRegistrarSolicitudActualizacionPlan.IconRightVisible = true;
            this.BtRegistrarSolicitudActualizacionPlan.IconRightZoom = 0D;
            this.BtRegistrarSolicitudActualizacionPlan.IconVisible = true;
            this.BtRegistrarSolicitudActualizacionPlan.IconZoom = 80D;
            this.BtRegistrarSolicitudActualizacionPlan.IsTab = false;
            this.BtRegistrarSolicitudActualizacionPlan.Location = new System.Drawing.Point(0, 159);
            this.BtRegistrarSolicitudActualizacionPlan.Name = "BtRegistrarSolicitudActualizacionPlan";
            this.BtRegistrarSolicitudActualizacionPlan.Normalcolor = System.Drawing.Color.Transparent;
            this.BtRegistrarSolicitudActualizacionPlan.OnHovercolor = System.Drawing.Color.Lime;
            this.BtRegistrarSolicitudActualizacionPlan.OnHoverTextColor = System.Drawing.Color.White;
            this.BtRegistrarSolicitudActualizacionPlan.selected = false;
            this.BtRegistrarSolicitudActualizacionPlan.Size = new System.Drawing.Size(244, 46);
            this.BtRegistrarSolicitudActualizacionPlan.TabIndex = 30;
            this.BtRegistrarSolicitudActualizacionPlan.Text = "      SOLICITUD  ACTUALIZACION         DEL PLAN DE  ASIGNATURA";
            this.BtRegistrarSolicitudActualizacionPlan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtRegistrarSolicitudActualizacionPlan.Textcolor = System.Drawing.Color.LightGray;
            this.BtRegistrarSolicitudActualizacionPlan.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtRegistrarSolicitudActualizacionPlan.Click += new System.EventHandler(this.BtRegistrarSolicitudActualizacionPlan_Click);
            // 
            // BtConsultarDocente
            // 
            this.BtConsultarDocente.Activecolor = System.Drawing.Color.Transparent;
            this.BtConsultarDocente.BackColor = System.Drawing.Color.Transparent;
            this.BtConsultarDocente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtConsultarDocente.BorderRadius = 0;
            this.BtConsultarDocente.ButtonText = "      CONSULTAR DOCENTE";
            this.BtConsultarDocente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.BtConsultarDocente, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.BtConsultarDocente, BunifuAnimatorNS.DecorationType.None);
            this.BtConsultarDocente.DisabledColor = System.Drawing.Color.Gray;
            this.BtConsultarDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtConsultarDocente.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BtConsultarDocente.Iconcolor = System.Drawing.Color.Transparent;
            this.BtConsultarDocente.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtConsultarDocente.Iconimage")));
            this.BtConsultarDocente.Iconimage_right = null;
            this.BtConsultarDocente.Iconimage_right_Selected = null;
            this.BtConsultarDocente.Iconimage_Selected = null;
            this.BtConsultarDocente.IconMarginLeft = 9;
            this.BtConsultarDocente.IconMarginRight = 0;
            this.BtConsultarDocente.IconRightVisible = true;
            this.BtConsultarDocente.IconRightZoom = 0D;
            this.BtConsultarDocente.IconVisible = true;
            this.BtConsultarDocente.IconZoom = 85D;
            this.BtConsultarDocente.IsTab = false;
            this.BtConsultarDocente.Location = new System.Drawing.Point(-1, 51);
            this.BtConsultarDocente.Name = "BtConsultarDocente";
            this.BtConsultarDocente.Normalcolor = System.Drawing.Color.Transparent;
            this.BtConsultarDocente.OnHovercolor = System.Drawing.Color.Lime;
            this.BtConsultarDocente.OnHoverTextColor = System.Drawing.Color.White;
            this.BtConsultarDocente.selected = false;
            this.BtConsultarDocente.Size = new System.Drawing.Size(246, 48);
            this.BtConsultarDocente.TabIndex = 27;
            this.BtConsultarDocente.Text = "      CONSULTAR DOCENTE";
            this.BtConsultarDocente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtConsultarDocente.Textcolor = System.Drawing.Color.LightGray;
            this.BtConsultarDocente.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtConsultarDocente.Click += new System.EventHandler(this.BtConsultarDocente_Click);
            // 
            // BtConsultarPlanAsignatura
            // 
            this.BtConsultarPlanAsignatura.Activecolor = System.Drawing.Color.Transparent;
            this.BtConsultarPlanAsignatura.BackColor = System.Drawing.Color.Transparent;
            this.BtConsultarPlanAsignatura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtConsultarPlanAsignatura.BorderRadius = 0;
            this.BtConsultarPlanAsignatura.ButtonText = "      CONSULTAR PLAN                                ASIGNATURA";
            this.BtConsultarPlanAsignatura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.BtConsultarPlanAsignatura, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.BtConsultarPlanAsignatura, BunifuAnimatorNS.DecorationType.None);
            this.BtConsultarPlanAsignatura.DisabledColor = System.Drawing.Color.Gray;
            this.BtConsultarPlanAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtConsultarPlanAsignatura.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BtConsultarPlanAsignatura.Iconcolor = System.Drawing.Color.Transparent;
            this.BtConsultarPlanAsignatura.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtConsultarPlanAsignatura.Iconimage")));
            this.BtConsultarPlanAsignatura.Iconimage_right = null;
            this.BtConsultarPlanAsignatura.Iconimage_right_Selected = null;
            this.BtConsultarPlanAsignatura.Iconimage_Selected = null;
            this.BtConsultarPlanAsignatura.IconMarginLeft = 7;
            this.BtConsultarPlanAsignatura.IconMarginRight = 0;
            this.BtConsultarPlanAsignatura.IconRightVisible = true;
            this.BtConsultarPlanAsignatura.IconRightZoom = 0D;
            this.BtConsultarPlanAsignatura.IconVisible = true;
            this.BtConsultarPlanAsignatura.IconZoom = 90D;
            this.BtConsultarPlanAsignatura.IsTab = false;
            this.BtConsultarPlanAsignatura.Location = new System.Drawing.Point(-1, 105);
            this.BtConsultarPlanAsignatura.Name = "BtConsultarPlanAsignatura";
            this.BtConsultarPlanAsignatura.Normalcolor = System.Drawing.Color.Transparent;
            this.BtConsultarPlanAsignatura.OnHovercolor = System.Drawing.Color.Lime;
            this.BtConsultarPlanAsignatura.OnHoverTextColor = System.Drawing.Color.White;
            this.BtConsultarPlanAsignatura.selected = false;
            this.BtConsultarPlanAsignatura.Size = new System.Drawing.Size(245, 48);
            this.BtConsultarPlanAsignatura.TabIndex = 29;
            this.BtConsultarPlanAsignatura.Text = "      CONSULTAR PLAN                                ASIGNATURA";
            this.BtConsultarPlanAsignatura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtConsultarPlanAsignatura.Textcolor = System.Drawing.Color.LightGray;
            this.BtConsultarPlanAsignatura.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtConsultarPlanAsignatura.Click += new System.EventHandler(this.BtConsultarPlanAsignatura_Click_1);
            // 
            // LineaSidebar
            // 
            this.LineaSidebar.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.LineaSidebar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LineaSidebar.LineThickness = 1;
            this.LineaSidebar.Location = new System.Drawing.Point(7, 68);
            this.LineaSidebar.Name = "LineaSidebar";
            this.LineaSidebar.Size = new System.Drawing.Size(245, 1);
            this.LineaSidebar.TabIndex = 7;
            this.LineaSidebar.Transparency = 255;
            this.LineaSidebar.Vertical = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(93, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Docentes";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.PanelHijo);
            this.AnimacionSidebar.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(280, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(879, 563);
            this.panel3.TabIndex = 22;
            // 
            // PanelHijo
            // 
            this.PanelHijo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelHijo.BackColor = System.Drawing.Color.White;
            this.PanelHijo.Controls.Add(this.pictureBox3);
            this.AnimacionSidebar.SetDecoration(this.PanelHijo, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.PanelHijo, BunifuAnimatorNS.DecorationType.None);
            this.PanelHijo.Location = new System.Drawing.Point(6, 11);
            this.PanelHijo.Name = "PanelHijo";
            this.PanelHijo.Size = new System.Drawing.Size(861, 540);
            this.PanelHijo.TabIndex = 4;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(246, 101);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(379, 331);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // CurvaSidebar
            // 
            this.CurvaSidebar.ElipseRadius = 7;
            this.CurvaSidebar.TargetControl = this;
            // 
            // AnimacionSidebarBack
            // 
            this.AnimacionSidebarBack.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.AnimacionSidebarBack.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.AnimacionSidebarBack.DefaultAnimation = animation1;
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimizar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AnimacionSidebarBack.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(1045, 21);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(30, 30);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimizar.TabIndex = 4;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click_2);
            // 
            // Restaurar
            // 
            this.Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Restaurar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AnimacionSidebarBack.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("Restaurar.Image")));
            this.Restaurar.Location = new System.Drawing.Point(1081, 21);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(30, 30);
            this.Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Restaurar.TabIndex = 5;
            this.Restaurar.TabStop = false;
            this.Restaurar.Visible = false;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click_1);
            // 
            // Maximizar
            // 
            this.Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximizar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AnimacionSidebarBack.SetDecoration(this.Maximizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Maximizar, BunifuAnimatorNS.DecorationType.None);
            this.Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("Maximizar.Image")));
            this.Maximizar.Location = new System.Drawing.Point(1081, 21);
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.Size = new System.Drawing.Size(30, 30);
            this.Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Maximizar.TabIndex = 3;
            this.Maximizar.TabStop = false;
            this.Maximizar.Click += new System.EventHandler(this.Maximizar_Click_2);
            // 
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Salir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AnimacionSidebarBack.SetDecoration(this.Salir, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Salir, BunifuAnimatorNS.DecorationType.None);
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.Location = new System.Drawing.Point(1117, 21);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(30, 30);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Salir.TabIndex = 2;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(171, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 36);
            this.label2.TabIndex = 23;
            this.label2.Text = "Universidad Popular del Cesar";
            // 
            // MenuSidebar
            // 
            this.MenuSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.AnimacionSidebarBack.SetDecoration(this.MenuSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.MenuSidebar, BunifuAnimatorNS.DecorationType.None);
            this.MenuSidebar.Image = ((System.Drawing.Image)(resources.GetObject("MenuSidebar.Image")));
            this.MenuSidebar.Location = new System.Drawing.Point(19, 14);
            this.MenuSidebar.Name = "MenuSidebar";
            this.MenuSidebar.Size = new System.Drawing.Size(50, 44);
            this.MenuSidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuSidebar.TabIndex = 24;
            this.MenuSidebar.TabStop = false;
            this.MenuSidebar.Click += new System.EventHandler(this.MenuSidebar_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(91, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox2);
            this.bunifuGradientPanel1.Controls.Add(this.MenuSidebar);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.Salir);
            this.bunifuGradientPanel1.Controls.Add(this.Maximizar);
            this.bunifuGradientPanel1.Controls.Add(this.Restaurar);
            this.bunifuGradientPanel1.Controls.Add(this.Minimizar);
            this.AnimacionSidebar.SetDecoration(this.bunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Lime;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1159, 75);
            this.bunifuGradientPanel1.TabIndex = 3;
            // 
            // AnimacionSidebar
            // 
            this.AnimacionSidebar.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.AnimacionSidebar.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 1;
            animation2.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 2F;
            animation2.TransparencyCoeff = 0F;
            this.AnimacionSidebar.DefaultAnimation = animation2;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // MoverDashboard
            // 
            this.MoverDashboard.Fixed = true;
            this.MoverDashboard.Horizontal = true;
            this.MoverDashboard.TargetControl = this.bunifuGradientPanel1;
            this.MoverDashboard.Vertical = true;
            // 
            // Temporizador
            // 
            this.Temporizador.Enabled = true;
            // 
            // RadioPanelChart
            // 
            this.RadioPanelChart.ElipseRadius = 7;
            this.RadioPanelChart.TargetControl = this;
            // 
            // MenuUpcDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 638);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.SidebarWrapper);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.AnimacionSidebar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuUpcDocente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuHotel";
            this.SidebarWrapper.ResumeLayout(false);
            this.Sidebar.ResumeLayout(false);
            this.Sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelSideMenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.PanelHijo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSidebar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel SidebarWrapper;
        private Bunifu.Framework.UI.BunifuGradientPanel Sidebar;
        private System.Windows.Forms.Panel PanelSideMenu;
        private Bunifu.Framework.UI.BunifuFlatButton BtActualizacionPlanAsignatura;
        private Bunifu.Framework.UI.BunifuSeparator LineaSidebar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel PanelHijo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuFlatButton BtConsultarRespuestaComite;
        private Bunifu.Framework.UI.BunifuFlatButton BtConsultarAsignatura;
        private Bunifu.Framework.UI.BunifuFlatButton BtConsultarPlanAsignatura;
        private Bunifu.Framework.UI.BunifuFlatButton BtRegistrarSolicitudActualizacionPlan;
        private Bunifu.Framework.UI.BunifuFlatButton BtConsultarDocente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebarBack;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebar;
        private Bunifu.Framework.UI.BunifuElipse CurvaSidebar;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Bunifu.Framework.UI.BunifuDragControl MoverDashboard;
        private System.Windows.Forms.Timer Temporizador;
        private Bunifu.Framework.UI.BunifuElipse RadioPanelChart;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox MenuSidebar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Salir;
        private System.Windows.Forms.PictureBox Maximizar;
        private System.Windows.Forms.PictureBox Restaurar;
        private System.Windows.Forms.PictureBox Minimizar;
    }
}

