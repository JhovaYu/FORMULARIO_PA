namespace FORMULARIO_PA
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LB_Titulo = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.LB_AdvertenciaEstatura = new System.Windows.Forms.Label();
            this.LB_AdvertenciaEdad = new System.Windows.Forms.Label();
            this.LB_AdvertenciaTelefono = new System.Windows.Forms.Label();
            this.LB_AdvertenciaApellido = new System.Windows.Forms.Label();
            this.LB_AdvertenciaNombre = new System.Windows.Forms.Label();
            this.LB_Mujer = new System.Windows.Forms.Label();
            this.LB_Hombre = new System.Windows.Forms.Label();
            this.BTN_Cancelar = new System.Windows.Forms.Button();
            this.BTN_Guardar = new System.Windows.Forms.Button();
            this.PB_Female = new System.Windows.Forms.PictureBox();
            this.PB_Male = new System.Windows.Forms.PictureBox();
            this.LB_Genero = new System.Windows.Forms.Label();
            this.PanelLine_Estatura = new System.Windows.Forms.Panel();
            this.PanelLine_Edad = new System.Windows.Forms.Panel();
            this.PanelLine_Telefono = new System.Windows.Forms.Panel();
            this.PanelLine_Apellido = new System.Windows.Forms.Panel();
            this.PanelLine_Nombre = new System.Windows.Forms.Panel();
            this.LB_Apellido = new System.Windows.Forms.Label();
            this.TB_Apellido = new System.Windows.Forms.TextBox();
            this.LB_Telefono = new System.Windows.Forms.Label();
            this.TB_Telefono = new System.Windows.Forms.TextBox();
            this.LB_Estatura = new System.Windows.Forms.Label();
            this.TB_Estatura = new System.Windows.Forms.TextBox();
            this.LB_Edad = new System.Windows.Forms.Label();
            this.TB_Edad = new System.Windows.Forms.TextBox();
            this.LB_Name = new System.Windows.Forms.Label();
            this.TB_Nombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Female)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Male)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(417, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 64);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LB_Titulo
            // 
            this.LB_Titulo.AutoSize = true;
            this.LB_Titulo.Font = new System.Drawing.Font("Cascadia Code", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Titulo.ForeColor = System.Drawing.Color.Gray;
            this.LB_Titulo.Location = new System.Drawing.Point(154, 11);
            this.LB_Titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Titulo.Name = "LB_Titulo";
            this.LB_Titulo.Size = new System.Drawing.Size(171, 43);
            this.LB_Titulo.TabIndex = 1;
            this.LB_Titulo.Text = "REGISTRO";
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Controls.Add(this.LB_AdvertenciaEstatura);
            this.MainPanel.Controls.Add(this.LB_AdvertenciaEdad);
            this.MainPanel.Controls.Add(this.LB_AdvertenciaTelefono);
            this.MainPanel.Controls.Add(this.LB_AdvertenciaApellido);
            this.MainPanel.Controls.Add(this.LB_AdvertenciaNombre);
            this.MainPanel.Controls.Add(this.LB_Mujer);
            this.MainPanel.Controls.Add(this.LB_Hombre);
            this.MainPanel.Controls.Add(this.BTN_Cancelar);
            this.MainPanel.Controls.Add(this.BTN_Guardar);
            this.MainPanel.Controls.Add(this.PB_Female);
            this.MainPanel.Controls.Add(this.PB_Male);
            this.MainPanel.Controls.Add(this.LB_Genero);
            this.MainPanel.Controls.Add(this.PanelLine_Estatura);
            this.MainPanel.Controls.Add(this.PanelLine_Edad);
            this.MainPanel.Controls.Add(this.PanelLine_Telefono);
            this.MainPanel.Controls.Add(this.PanelLine_Apellido);
            this.MainPanel.Controls.Add(this.PanelLine_Nombre);
            this.MainPanel.Controls.Add(this.pictureBox1);
            this.MainPanel.Controls.Add(this.LB_Titulo);
            this.MainPanel.Controls.Add(this.LB_Telefono);
            this.MainPanel.Controls.Add(this.TB_Telefono);
            this.MainPanel.Controls.Add(this.LB_Estatura);
            this.MainPanel.Controls.Add(this.TB_Estatura);
            this.MainPanel.Controls.Add(this.LB_Edad);
            this.MainPanel.Controls.Add(this.TB_Edad);
            this.MainPanel.Controls.Add(this.LB_Name);
            this.MainPanel.Controls.Add(this.TB_Nombre);
            this.MainPanel.Controls.Add(this.LB_Apellido);
            this.MainPanel.Controls.Add(this.TB_Apellido);
            this.MainPanel.Location = new System.Drawing.Point(40, 57);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(475, 618);
            this.MainPanel.TabIndex = 2;
            // 
            // LB_AdvertenciaEstatura
            // 
            this.LB_AdvertenciaEstatura.AutoSize = true;
            this.LB_AdvertenciaEstatura.Font = new System.Drawing.Font("Corbel", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_AdvertenciaEstatura.ForeColor = System.Drawing.Color.Brown;
            this.LB_AdvertenciaEstatura.Location = new System.Drawing.Point(53, 430);
            this.LB_AdvertenciaEstatura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_AdvertenciaEstatura.Name = "LB_AdvertenciaEstatura";
            this.LB_AdvertenciaEstatura.Size = new System.Drawing.Size(119, 13);
            this.LB_AdvertenciaEstatura.TabIndex = 27;
            this.LB_AdvertenciaEstatura.Text = "Solo se aceptan numeros";
            this.LB_AdvertenciaEstatura.Visible = false;
            // 
            // LB_AdvertenciaEdad
            // 
            this.LB_AdvertenciaEdad.AutoSize = true;
            this.LB_AdvertenciaEdad.Font = new System.Drawing.Font("Corbel", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_AdvertenciaEdad.ForeColor = System.Drawing.Color.Brown;
            this.LB_AdvertenciaEdad.Location = new System.Drawing.Point(53, 370);
            this.LB_AdvertenciaEdad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_AdvertenciaEdad.Name = "LB_AdvertenciaEdad";
            this.LB_AdvertenciaEdad.Size = new System.Drawing.Size(119, 13);
            this.LB_AdvertenciaEdad.TabIndex = 26;
            this.LB_AdvertenciaEdad.Text = "Solo se aceptan numeros";
            this.LB_AdvertenciaEdad.Visible = false;
            // 
            // LB_AdvertenciaTelefono
            // 
            this.LB_AdvertenciaTelefono.AutoSize = true;
            this.LB_AdvertenciaTelefono.Font = new System.Drawing.Font("Corbel", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_AdvertenciaTelefono.ForeColor = System.Drawing.Color.Brown;
            this.LB_AdvertenciaTelefono.Location = new System.Drawing.Point(53, 301);
            this.LB_AdvertenciaTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_AdvertenciaTelefono.Name = "LB_AdvertenciaTelefono";
            this.LB_AdvertenciaTelefono.Size = new System.Drawing.Size(119, 13);
            this.LB_AdvertenciaTelefono.TabIndex = 25;
            this.LB_AdvertenciaTelefono.Text = "Solo se aceptan numeros";
            this.LB_AdvertenciaTelefono.Visible = false;
            // 
            // LB_AdvertenciaApellido
            // 
            this.LB_AdvertenciaApellido.AutoSize = true;
            this.LB_AdvertenciaApellido.Font = new System.Drawing.Font("Corbel", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_AdvertenciaApellido.ForeColor = System.Drawing.Color.Brown;
            this.LB_AdvertenciaApellido.Location = new System.Drawing.Point(53, 235);
            this.LB_AdvertenciaApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_AdvertenciaApellido.Name = "LB_AdvertenciaApellido";
            this.LB_AdvertenciaApellido.Size = new System.Drawing.Size(104, 13);
            this.LB_AdvertenciaApellido.TabIndex = 24;
            this.LB_AdvertenciaApellido.Text = "Solo se aceptan letras";
            this.LB_AdvertenciaApellido.Visible = false;
            // 
            // LB_AdvertenciaNombre
            // 
            this.LB_AdvertenciaNombre.AutoSize = true;
            this.LB_AdvertenciaNombre.Font = new System.Drawing.Font("Corbel", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_AdvertenciaNombre.ForeColor = System.Drawing.Color.Brown;
            this.LB_AdvertenciaNombre.Location = new System.Drawing.Point(52, 176);
            this.LB_AdvertenciaNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_AdvertenciaNombre.Name = "LB_AdvertenciaNombre";
            this.LB_AdvertenciaNombre.Size = new System.Drawing.Size(104, 13);
            this.LB_AdvertenciaNombre.TabIndex = 23;
            this.LB_AdvertenciaNombre.Text = "Solo se aceptan letras";
            this.LB_AdvertenciaNombre.Visible = false;
            this.LB_AdvertenciaNombre.Click += new System.EventHandler(this.LB_AdvertenciaNombre_Click);
            // 
            // LB_Mujer
            // 
            this.LB_Mujer.AutoSize = true;
            this.LB_Mujer.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Mujer.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LB_Mujer.Location = new System.Drawing.Point(300, 442);
            this.LB_Mujer.Name = "LB_Mujer";
            this.LB_Mujer.Size = new System.Drawing.Size(54, 19);
            this.LB_Mujer.TabIndex = 22;
            this.LB_Mujer.Text = "Mujer";
            // 
            // LB_Hombre
            // 
            this.LB_Hombre.AutoSize = true;
            this.LB_Hombre.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Hombre.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LB_Hombre.Location = new System.Drawing.Point(212, 442);
            this.LB_Hombre.Name = "LB_Hombre";
            this.LB_Hombre.Size = new System.Drawing.Size(63, 19);
            this.LB_Hombre.TabIndex = 21;
            this.LB_Hombre.Text = "Hombre";
            // 
            // BTN_Cancelar
            // 
            this.BTN_Cancelar.BackColor = System.Drawing.Color.Crimson;
            this.BTN_Cancelar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Cancelar.ForeColor = System.Drawing.SystemColors.Info;
            this.BTN_Cancelar.Location = new System.Drawing.Point(279, 558);
            this.BTN_Cancelar.Name = "BTN_Cancelar";
            this.BTN_Cancelar.Size = new System.Drawing.Size(105, 36);
            this.BTN_Cancelar.TabIndex = 6;
            this.BTN_Cancelar.Text = "Cancelar";
            this.BTN_Cancelar.UseVisualStyleBackColor = false;
            this.BTN_Cancelar.Click += new System.EventHandler(this.BTN_Cancelar_Click);
            // 
            // BTN_Guardar
            // 
            this.BTN_Guardar.BackColor = System.Drawing.Color.YellowGreen;
            this.BTN_Guardar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Guardar.ForeColor = System.Drawing.SystemColors.Info;
            this.BTN_Guardar.Location = new System.Drawing.Point(89, 558);
            this.BTN_Guardar.Name = "BTN_Guardar";
            this.BTN_Guardar.Size = new System.Drawing.Size(105, 36);
            this.BTN_Guardar.TabIndex = 7;
            this.BTN_Guardar.Text = "Aceptar";
            this.BTN_Guardar.UseVisualStyleBackColor = false;
            this.BTN_Guardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // PB_Female
            // 
            this.PB_Female.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PB_Female.Image = ((System.Drawing.Image)(resources.GetObject("PB_Female.Image")));
            this.PB_Female.Location = new System.Drawing.Point(303, 471);
            this.PB_Female.Name = "PB_Female";
            this.PB_Female.Size = new System.Drawing.Size(38, 37);
            this.PB_Female.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Female.TabIndex = 20;
            this.PB_Female.TabStop = false;
            this.PB_Female.Click += new System.EventHandler(this.PB_Female_Click);
            this.PB_Female.MouseEnter += new System.EventHandler(this.PB_Female_MouseEnter);
            this.PB_Female.MouseLeave += new System.EventHandler(this.PB_Female_MouseLeave);
            // 
            // PB_Male
            // 
            this.PB_Male.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_Male.Image = ((System.Drawing.Image)(resources.GetObject("PB_Male.Image")));
            this.PB_Male.Location = new System.Drawing.Point(223, 471);
            this.PB_Male.Name = "PB_Male";
            this.PB_Male.Size = new System.Drawing.Size(34, 37);
            this.PB_Male.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Male.TabIndex = 19;
            this.PB_Male.TabStop = false;
            this.PB_Male.Click += new System.EventHandler(this.PB_Male_Click);
            this.PB_Male.MouseEnter += new System.EventHandler(this.PB_Male_MouseEnter);
            this.PB_Male.MouseLeave += new System.EventHandler(this.PB_Male_MouseLeave);
            // 
            // LB_Genero
            // 
            this.LB_Genero.AutoSize = true;
            this.LB_Genero.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Genero.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LB_Genero.Location = new System.Drawing.Point(51, 459);
            this.LB_Genero.Name = "LB_Genero";
            this.LB_Genero.Size = new System.Drawing.Size(82, 24);
            this.LB_Genero.TabIndex = 18;
            this.LB_Genero.Text = "Genero";
            // 
            // PanelLine_Estatura
            // 
            this.PanelLine_Estatura.BackColor = System.Drawing.Color.Silver;
            this.PanelLine_Estatura.Location = new System.Drawing.Point(55, 423);
            this.PanelLine_Estatura.Name = "PanelLine_Estatura";
            this.PanelLine_Estatura.Size = new System.Drawing.Size(350, 3);
            this.PanelLine_Estatura.TabIndex = 15;
            // 
            // PanelLine_Edad
            // 
            this.PanelLine_Edad.BackColor = System.Drawing.Color.Silver;
            this.PanelLine_Edad.Location = new System.Drawing.Point(55, 364);
            this.PanelLine_Edad.Name = "PanelLine_Edad";
            this.PanelLine_Edad.Size = new System.Drawing.Size(350, 3);
            this.PanelLine_Edad.TabIndex = 12;
            // 
            // PanelLine_Telefono
            // 
            this.PanelLine_Telefono.BackColor = System.Drawing.Color.Silver;
            this.PanelLine_Telefono.Location = new System.Drawing.Point(55, 294);
            this.PanelLine_Telefono.Name = "PanelLine_Telefono";
            this.PanelLine_Telefono.Size = new System.Drawing.Size(350, 3);
            this.PanelLine_Telefono.TabIndex = 9;
            // 
            // PanelLine_Apellido
            // 
            this.PanelLine_Apellido.BackColor = System.Drawing.Color.Silver;
            this.PanelLine_Apellido.Location = new System.Drawing.Point(55, 228);
            this.PanelLine_Apellido.Name = "PanelLine_Apellido";
            this.PanelLine_Apellido.Size = new System.Drawing.Size(350, 3);
            this.PanelLine_Apellido.TabIndex = 6;
            // 
            // PanelLine_Nombre
            // 
            this.PanelLine_Nombre.BackColor = System.Drawing.Color.Silver;
            this.PanelLine_Nombre.Location = new System.Drawing.Point(55, 170);
            this.PanelLine_Nombre.Name = "PanelLine_Nombre";
            this.PanelLine_Nombre.Size = new System.Drawing.Size(350, 3);
            this.PanelLine_Nombre.TabIndex = 2;
            // 
            // LB_Apellido
            // 
            this.LB_Apellido.AutoSize = true;
            this.LB_Apellido.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Apellido.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LB_Apellido.Location = new System.Drawing.Point(51, 201);
            this.LB_Apellido.Name = "LB_Apellido";
            this.LB_Apellido.Padding = new System.Windows.Forms.Padding(0, 0, 262, 0);
            this.LB_Apellido.Size = new System.Drawing.Size(380, 24);
            this.LB_Apellido.TabIndex = 2;
            this.LB_Apellido.Text = "Apellidos";
            this.LB_Apellido.Click += new System.EventHandler(this.LB_Apellido_Click);
            // 
            // TB_Apellido
            // 
            this.TB_Apellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Apellido.Location = new System.Drawing.Point(55, 208);
            this.TB_Apellido.Name = "TB_Apellido";
            this.TB_Apellido.Size = new System.Drawing.Size(350, 13);
            this.TB_Apellido.TabIndex = 3;
            this.TB_Apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Apellido_KeyPress);
            this.TB_Apellido.Leave += new System.EventHandler(this.TB_Apellido_Leave);
            // 
            // LB_Telefono
            // 
            this.LB_Telefono.AutoSize = true;
            this.LB_Telefono.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Telefono.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LB_Telefono.Location = new System.Drawing.Point(51, 267);
            this.LB_Telefono.Name = "LB_Telefono";
            this.LB_Telefono.Padding = new System.Windows.Forms.Padding(0, 0, 262, 0);
            this.LB_Telefono.Size = new System.Drawing.Size(368, 24);
            this.LB_Telefono.TabIndex = 3;
            this.LB_Telefono.Text = "Telefono";
            this.LB_Telefono.Click += new System.EventHandler(this.LB_Telefono_Click_1);
            // 
            // TB_Telefono
            // 
            this.TB_Telefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Telefono.Location = new System.Drawing.Point(55, 274);
            this.TB_Telefono.MaxLength = 10;
            this.TB_Telefono.Name = "TB_Telefono";
            this.TB_Telefono.Size = new System.Drawing.Size(350, 13);
            this.TB_Telefono.TabIndex = 4;
            this.TB_Telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Telefono_KeyPress);
            this.TB_Telefono.Leave += new System.EventHandler(this.TB_Telefono_Leave);
            // 
            // LB_Estatura
            // 
            this.LB_Estatura.AutoSize = true;
            this.LB_Estatura.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Estatura.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LB_Estatura.Location = new System.Drawing.Point(51, 396);
            this.LB_Estatura.Name = "LB_Estatura";
            this.LB_Estatura.Padding = new System.Windows.Forms.Padding(0, 0, 262, 0);
            this.LB_Estatura.Size = new System.Drawing.Size(428, 24);
            this.LB_Estatura.TabIndex = 5;
            this.LB_Estatura.Text = "Estatura (cm)";
            this.LB_Estatura.Click += new System.EventHandler(this.LB_Estatura_Click);
            // 
            // TB_Estatura
            // 
            this.TB_Estatura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Estatura.Location = new System.Drawing.Point(55, 403);
            this.TB_Estatura.MaxLength = 3;
            this.TB_Estatura.Name = "TB_Estatura";
            this.TB_Estatura.Size = new System.Drawing.Size(350, 13);
            this.TB_Estatura.TabIndex = 6;
            this.TB_Estatura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Estatura_KeyPress);
            this.TB_Estatura.Leave += new System.EventHandler(this.TB_Estatura_Leave);
            // 
            // LB_Edad
            // 
            this.LB_Edad.AutoSize = true;
            this.LB_Edad.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Edad.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LB_Edad.Location = new System.Drawing.Point(51, 337);
            this.LB_Edad.Name = "LB_Edad";
            this.LB_Edad.Padding = new System.Windows.Forms.Padding(0, 0, 262, 0);
            this.LB_Edad.Size = new System.Drawing.Size(320, 24);
            this.LB_Edad.TabIndex = 4;
            this.LB_Edad.Text = "Edad";
            this.LB_Edad.Click += new System.EventHandler(this.LB_Edad_Click);
            // 
            // TB_Edad
            // 
            this.TB_Edad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Edad.Location = new System.Drawing.Point(55, 344);
            this.TB_Edad.MaxLength = 2;
            this.TB_Edad.Name = "TB_Edad";
            this.TB_Edad.Size = new System.Drawing.Size(350, 13);
            this.TB_Edad.TabIndex = 5;
            this.TB_Edad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Edad_KeyPress);
            this.TB_Edad.Leave += new System.EventHandler(this.TB_Edad_Leave);
            // 
            // LB_Name
            // 
            this.LB_Name.AutoSize = true;
            this.LB_Name.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Name.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LB_Name.Location = new System.Drawing.Point(51, 143);
            this.LB_Name.Name = "LB_Name";
            this.LB_Name.Padding = new System.Windows.Forms.Padding(0, 0, 262, 0);
            this.LB_Name.Size = new System.Drawing.Size(344, 24);
            this.LB_Name.TabIndex = 1;
            this.LB_Name.Text = "Nombre";
            this.LB_Name.Click += new System.EventHandler(this.LB_Name_Click);
            // 
            // TB_Nombre
            // 
            this.TB_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Nombre.Location = new System.Drawing.Point(55, 150);
            this.TB_Nombre.Name = "TB_Nombre";
            this.TB_Nombre.Size = new System.Drawing.Size(856, 13);
            this.TB_Nombre.TabIndex = 2;
            this.TB_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Nombre_KeyPress);
            this.TB_Nombre.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(552, 718);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Female)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Male)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LB_Titulo;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TextBox TB_Nombre;
        private System.Windows.Forms.Panel PanelLine_Nombre;
        private System.Windows.Forms.Label LB_Name;
        private System.Windows.Forms.Label LB_Apellido;
        private System.Windows.Forms.TextBox TB_Apellido;
        private System.Windows.Forms.Panel PanelLine_Apellido;
        private System.Windows.Forms.Label LB_Telefono;
        private System.Windows.Forms.TextBox TB_Telefono;
        private System.Windows.Forms.Panel PanelLine_Telefono;
        private System.Windows.Forms.Label LB_Edad;
        private System.Windows.Forms.TextBox TB_Edad;
        private System.Windows.Forms.Panel PanelLine_Edad;
        private System.Windows.Forms.Label LB_Genero;
        private System.Windows.Forms.Label LB_Estatura;
        private System.Windows.Forms.TextBox TB_Estatura;
        private System.Windows.Forms.Panel PanelLine_Estatura;
        private System.Windows.Forms.PictureBox PB_Female;
        private System.Windows.Forms.PictureBox PB_Male;
        private System.Windows.Forms.Button BTN_Guardar;
        private System.Windows.Forms.Button BTN_Cancelar;
        private System.Windows.Forms.Label LB_Mujer;
        private System.Windows.Forms.Label LB_Hombre;
        private System.Windows.Forms.Label LB_AdvertenciaNombre;
        private System.Windows.Forms.Label LB_AdvertenciaEstatura;
        private System.Windows.Forms.Label LB_AdvertenciaEdad;
        private System.Windows.Forms.Label LB_AdvertenciaTelefono;
        private System.Windows.Forms.Label LB_AdvertenciaApellido;
    }
}

