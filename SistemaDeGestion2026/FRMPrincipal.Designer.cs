namespace SistemaDeGestion2026
{
    partial class FRMPrincipal
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
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel2 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar4 = new DevComponents.DotNetBar.RibbonBar();
            this.BTNProveedor = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar3 = new DevComponents.DotNetBar.RibbonBar();
            this.BTNClientes = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar2 = new DevComponents.DotNetBar.RibbonBar();
            this.BTNProductos = new DevComponents.DotNetBar.ButtonItem();
            this.BTNCategoria = new DevComponents.DotNetBar.ButtonItem();
            this.RBPAdministracion = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.BTNPersonas = new DevComponents.DotNetBar.ButtonItem();
            this.BTNUsuarios = new DevComponents.DotNetBar.ButtonItem();
            this.applicationButton1 = new DevComponents.DotNetBar.ApplicationButton();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer3 = new DevComponents.DotNetBar.ItemContainer();
            this.BTNLogin = new DevComponents.DotNetBar.ButtonItem();
            this.BTNLoginHuella = new DevComponents.DotNetBar.ButtonItem();
            this.BTNActualizarPassword = new DevComponents.DotNetBar.ButtonItem();
            this.BTNCerrarSesion = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer4 = new DevComponents.DotNetBar.ItemContainer();
            this.BTNConfigurar = new DevComponents.DotNetBar.ButtonItem();
            this.BTNSalir = new DevComponents.DotNetBar.ButtonItem();
            this.RTBAdministracion = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem2 = new DevComponents.DotNetBar.RibbonTabItem();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.ribbonControl1.SuspendLayout();
            this.ribbonPanel2.SuspendLayout();
            this.RBPAdministracion.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.ribbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.Controls.Add(this.ribbonPanel2);
            this.ribbonControl1.Controls.Add(this.RBPAdministracion);
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonControl1.ForeColor = System.Drawing.Color.Black;
            this.ribbonControl1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.applicationButton1,
            this.RTBAdministracion,
            this.ribbonTabItem2});
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(5, 1);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(2);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.RibbonStripFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonControl1.Size = new System.Drawing.Size(891, 146);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonControl1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.ribbonControl1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.ribbonControl1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.ribbonControl1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.ribbonControl1.SystemText.QatDialogAddButton = "&Add >>";
            this.ribbonControl1.SystemText.QatDialogCancelButton = "Cancel";
            this.ribbonControl1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.ribbonControl1.SystemText.QatDialogOkButton = "OK";
            this.ribbonControl1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatDialogRemoveButton = "&Remove";
            this.ribbonControl1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.ribbonControl1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 0;
            this.ribbonControl1.Text = "ribbonControl1";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel2.Controls.Add(this.ribbonBar4);
            this.ribbonPanel2.Controls.Add(this.ribbonBar3);
            this.ribbonPanel2.Controls.Add(this.ribbonBar2);
            this.ribbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel2.Location = new System.Drawing.Point(0, 54);
            this.ribbonPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.ribbonPanel2.Size = new System.Drawing.Size(891, 92);
            // 
            // 
            // 
            this.ribbonPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel2.TabIndex = 2;
            // 
            // ribbonBar4
            // 
            this.ribbonBar4.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar4.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar4.ContainerControlProcessDialogKey = true;
            this.ribbonBar4.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar4.DragDropSupport = true;
            this.ribbonBar4.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.BTNProveedor});
            this.ribbonBar4.Location = new System.Drawing.Point(404, 0);
            this.ribbonBar4.Margin = new System.Windows.Forms.Padding(2);
            this.ribbonBar4.Name = "ribbonBar4";
            this.ribbonBar4.Size = new System.Drawing.Size(224, 90);
            this.ribbonBar4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar4.TabIndex = 3;
            this.ribbonBar4.Text = "Egresos";
            // 
            // 
            // 
            this.ribbonBar4.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar4.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // BTNProveedor
            // 
            this.BTNProveedor.Image = global::SistemaDeGestion2026.Properties.Resources.Icono_Proveedor3;
            this.BTNProveedor.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.BTNProveedor.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTNProveedor.Name = "BTNProveedor";
            this.BTNProveedor.SubItemsExpandWidth = 14;
            this.BTNProveedor.Text = "Proveedor";
            this.BTNProveedor.Click += new System.EventHandler(this.BTNProveedor_Click);
            // 
            // ribbonBar3
            // 
            this.ribbonBar3.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar3.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar3.ContainerControlProcessDialogKey = true;
            this.ribbonBar3.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar3.DragDropSupport = true;
            this.ribbonBar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonBar3.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.BTNClientes});
            this.ribbonBar3.Location = new System.Drawing.Point(194, 0);
            this.ribbonBar3.Margin = new System.Windows.Forms.Padding(2);
            this.ribbonBar3.Name = "ribbonBar3";
            this.ribbonBar3.Size = new System.Drawing.Size(210, 90);
            this.ribbonBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar3.TabIndex = 2;
            this.ribbonBar3.Text = "Ingresos";
            // 
            // 
            // 
            this.ribbonBar3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar3.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // BTNClientes
            // 
            this.BTNClientes.Image = global::SistemaDeGestion2026.Properties.Resources.Icono_Clientes3;
            this.BTNClientes.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.BTNClientes.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTNClientes.Name = "BTNClientes";
            this.BTNClientes.SubItemsExpandWidth = 14;
            this.BTNClientes.Text = "Clientes";
            this.BTNClientes.Click += new System.EventHandler(this.BTNClientes_Click);
            // 
            // ribbonBar2
            // 
            this.ribbonBar2.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar2.ContainerControlProcessDialogKey = true;
            this.ribbonBar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar2.DragDropSupport = true;
            this.ribbonBar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.BTNProductos,
            this.BTNCategoria});
            this.ribbonBar2.Location = new System.Drawing.Point(2, 0);
            this.ribbonBar2.Margin = new System.Windows.Forms.Padding(2);
            this.ribbonBar2.Name = "ribbonBar2";
            this.ribbonBar2.Size = new System.Drawing.Size(192, 90);
            this.ribbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar2.TabIndex = 1;
            this.ribbonBar2.Text = "Almacén";
            // 
            // 
            // 
            this.ribbonBar2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // BTNProductos
            // 
            this.BTNProductos.Image = global::SistemaDeGestion2026.Properties.Resources.Icono_Producto1;
            this.BTNProductos.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.BTNProductos.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTNProductos.Name = "BTNProductos";
            this.BTNProductos.SubItemsExpandWidth = 14;
            this.BTNProductos.Text = "Productos";
            this.BTNProductos.Click += new System.EventHandler(this.BTNProductos_Click);
            // 
            // BTNCategoria
            // 
            this.BTNCategoria.Image = global::SistemaDeGestion2026.Properties.Resources.Icono_Categoria;
            this.BTNCategoria.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.BTNCategoria.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTNCategoria.Name = "BTNCategoria";
            this.BTNCategoria.SubItemsExpandWidth = 14;
            this.BTNCategoria.Text = "Categorias";
            this.BTNCategoria.Click += new System.EventHandler(this.BTNCategoria_Click);
            // 
            // RBPAdministracion
            // 
            this.RBPAdministracion.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RBPAdministracion.Controls.Add(this.ribbonBar1);
            this.RBPAdministracion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RBPAdministracion.Location = new System.Drawing.Point(0, 54);
            this.RBPAdministracion.Margin = new System.Windows.Forms.Padding(2);
            this.RBPAdministracion.Name = "RBPAdministracion";
            this.RBPAdministracion.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.RBPAdministracion.Size = new System.Drawing.Size(891, 92);
            // 
            // 
            // 
            this.RBPAdministracion.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.RBPAdministracion.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.RBPAdministracion.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RBPAdministracion.TabIndex = 1;
            this.RBPAdministracion.Visible = false;
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar1.DragDropSupport = true;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.BTNPersonas,
            this.BTNUsuarios});
            this.ribbonBar1.Location = new System.Drawing.Point(2, 0);
            this.ribbonBar1.Margin = new System.Windows.Forms.Padding(2);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(373, 90);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar1.TabIndex = 0;
            this.ribbonBar1.Text = "Acceso";
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // BTNPersonas
            // 
            this.BTNPersonas.Image = global::SistemaDeGestion2026.Properties.Resources.Icono_Persona;
            this.BTNPersonas.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.BTNPersonas.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTNPersonas.Name = "BTNPersonas";
            this.BTNPersonas.SubItemsExpandWidth = 14;
            this.BTNPersonas.Text = "Personas";
            this.BTNPersonas.Click += new System.EventHandler(this.BTNPersonas_Click);
            // 
            // BTNUsuarios
            // 
            this.BTNUsuarios.Image = global::SistemaDeGestion2026.Properties.Resources.Icono_Usuario;
            this.BTNUsuarios.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.BTNUsuarios.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTNUsuarios.Name = "BTNUsuarios";
            this.BTNUsuarios.SubItemsExpandWidth = 14;
            this.BTNUsuarios.Text = "Usuarios";
            this.BTNUsuarios.Click += new System.EventHandler(this.BTNUsuarios_Click);
            // 
            // applicationButton1
            // 
            this.applicationButton1.AutoExpandOnClick = true;
            this.applicationButton1.CanCustomize = false;
            this.applicationButton1.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.applicationButton1.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.applicationButton1.ImagePaddingHorizontal = 0;
            this.applicationButton1.ImagePaddingVertical = 1;
            this.applicationButton1.Name = "applicationButton1";
            this.applicationButton1.ShowSubItems = false;
            this.applicationButton1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1});
            this.applicationButton1.Text = "&Inicio";
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.Class = "RibbonFileMenuContainer";
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer2,
            this.itemContainer4});
            // 
            // 
            // 
            this.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // itemContainer2
            // 
            // 
            // 
            // 
            this.itemContainer2.BackgroundStyle.Class = "RibbonFileMenuTwoColumnContainer";
            this.itemContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer2.ItemSpacing = 0;
            this.itemContainer2.Name = "itemContainer2";
            this.itemContainer2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer3});
            // 
            // 
            // 
            this.itemContainer2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // itemContainer3
            // 
            // 
            // 
            // 
            this.itemContainer3.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer";
            this.itemContainer3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer3.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer3.MinimumSize = new System.Drawing.Size(120, 0);
            this.itemContainer3.Name = "itemContainer3";
            this.itemContainer3.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.BTNLogin,
            this.BTNLoginHuella,
            this.BTNActualizarPassword,
            this.BTNCerrarSesion});
            // 
            // 
            // 
            this.itemContainer3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // BTNLogin
            // 
            this.BTNLogin.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BTNLogin.Image = global::SistemaDeGestion2026.Properties.Resources.Icono_Iniciar_Sesón;
            this.BTNLogin.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNLogin.Name = "BTNLogin";
            this.BTNLogin.SubItemsExpandWidth = 24;
            this.BTNLogin.Text = "&Iniciar Sesión";
            this.BTNLogin.Click += new System.EventHandler(this.BTNLogin_Click);
            // 
            // BTNLoginHuella
            // 
            this.BTNLoginHuella.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BTNLoginHuella.Image = global::SistemaDeGestion2026.Properties.Resources.Icono_Sesión_Huella;
            this.BTNLoginHuella.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNLoginHuella.Name = "BTNLoginHuella";
            this.BTNLoginHuella.SubItemsExpandWidth = 24;
            this.BTNLoginHuella.Text = "&Iniciar Sesión";
            this.BTNLoginHuella.Click += new System.EventHandler(this.BTNLoginHuella_Click);
            // 
            // BTNActualizarPassword
            // 
            this.BTNActualizarPassword.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BTNActualizarPassword.Image = global::SistemaDeGestion2026.Properties.Resources.Icono_Password_Restaurar;
            this.BTNActualizarPassword.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNActualizarPassword.Name = "BTNActualizarPassword";
            this.BTNActualizarPassword.SubItemsExpandWidth = 24;
            this.BTNActualizarPassword.Text = "&Actualizar Password";
            // 
            // BTNCerrarSesion
            // 
            this.BTNCerrarSesion.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BTNCerrarSesion.Image = global::SistemaDeGestion2026.Properties.Resources.Icono_Cerrar_Sesión;
            this.BTNCerrarSesion.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNCerrarSesion.Name = "BTNCerrarSesion";
            this.BTNCerrarSesion.SubItemsExpandWidth = 24;
            this.BTNCerrarSesion.Text = "&Cerrar Sesión";
            this.BTNCerrarSesion.Click += new System.EventHandler(this.BTNCerrarSesion_Click);
            // 
            // itemContainer4
            // 
            // 
            // 
            // 
            this.itemContainer4.BackgroundStyle.Class = "RibbonFileMenuBottomContainer";
            this.itemContainer4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer4.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right;
            this.itemContainer4.Name = "itemContainer4";
            this.itemContainer4.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.BTNConfigurar,
            this.BTNSalir});
            // 
            // 
            // 
            this.itemContainer4.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // BTNConfigurar
            // 
            this.BTNConfigurar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BTNConfigurar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNConfigurar.Image = global::SistemaDeGestion2026.Properties.Resources.Icono_Configurar;
            this.BTNConfigurar.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.BTNConfigurar.Name = "BTNConfigurar";
            this.BTNConfigurar.SubItemsExpandWidth = 24;
            this.BTNConfigurar.Text = "Confi&gurar";
            // 
            // BTNSalir
            // 
            this.BTNSalir.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BTNSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNSalir.Image = global::SistemaDeGestion2026.Properties.Resources.Icono_Salir_Aplicacion;
            this.BTNSalir.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.SubItemsExpandWidth = 24;
            this.BTNSalir.Text = "&Salir";
            // 
            // RTBAdministracion
            // 
            this.RTBAdministracion.Name = "RTBAdministracion";
            this.RTBAdministracion.Panel = this.RBPAdministracion;
            this.RTBAdministracion.Text = "&Administración";
            // 
            // ribbonTabItem2
            // 
            this.ribbonTabItem2.Checked = true;
            this.ribbonTabItem2.Name = "ribbonTabItem2";
            this.ribbonTabItem2.Panel = this.ribbonPanel2;
            this.ribbonTabItem2.Text = "Inventario";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerColorTint = System.Drawing.Color.DodgerBlue;
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204))))));
            // 
            // FRMPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 384);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FRMPrincipal";
            this.Opacity = 0D;
            this.Text = "Tienda de Ropa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRMPrincipal_Load);
            this.ribbonControl1.ResumeLayout(false);
            this.ribbonControl1.PerformLayout();
            this.ribbonPanel2.ResumeLayout(false);
            this.RBPAdministracion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.RibbonPanel RBPAdministracion;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel2;
        private DevComponents.DotNetBar.ApplicationButton applicationButton1;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.ItemContainer itemContainer2;
        private DevComponents.DotNetBar.ItemContainer itemContainer3;
        private DevComponents.DotNetBar.ButtonItem BTNLogin;
        private DevComponents.DotNetBar.ButtonItem BTNActualizarPassword;
        private DevComponents.DotNetBar.ButtonItem BTNCerrarSesion;
        private DevComponents.DotNetBar.ItemContainer itemContainer4;
        private DevComponents.DotNetBar.ButtonItem BTNConfigurar;
        private DevComponents.DotNetBar.ButtonItem BTNSalir;
        private DevComponents.DotNetBar.RibbonTabItem RTBAdministracion;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem2;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.ButtonItem BTNPersonas;
        private DevComponents.DotNetBar.ButtonItem BTNUsuarios;
        private DevComponents.DotNetBar.ButtonItem BTNLoginHuella;
        private DevComponents.DotNetBar.RibbonBar ribbonBar4;
        private DevComponents.DotNetBar.ButtonItem BTNProveedor;
        private DevComponents.DotNetBar.RibbonBar ribbonBar3;
        private DevComponents.DotNetBar.ButtonItem BTNClientes;
        private DevComponents.DotNetBar.RibbonBar ribbonBar2;
        private DevComponents.DotNetBar.ButtonItem BTNProductos;
        private DevComponents.DotNetBar.ButtonItem BTNCategoria;
    }
}

