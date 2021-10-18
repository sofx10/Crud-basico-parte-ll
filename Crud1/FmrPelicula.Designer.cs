
namespace Crud1
{
    partial class FmrPelicula
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peliculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelPeliculadirigida = new MetroFramework.Controls.MetroLabel();
            this.LabelNombre = new MetroFramework.Controls.MetroLabel();
            this.LabelFechaestreno = new MetroFramework.Controls.MetroLabel();
            this.txtPeliculadirigida = new MetroFramework.Controls.MetroTextBox();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.BtnAgregar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnSalir = new MetroFramework.Controls.MetroButton();
            this.dtfechaesteno = new MetroFramework.Controls.MetroDateTime();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.peliculaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // peliculaToolStripMenuItem
            // 
            this.peliculaToolStripMenuItem.Name = "peliculaToolStripMenuItem";
            this.peliculaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.peliculaToolStripMenuItem.Text = "Pelicula";
            this.peliculaToolStripMenuItem.Click += new System.EventHandler(this.peliculaToolStripMenuItem_Click);
            // 
            // LabelPeliculadirigida
            // 
            this.LabelPeliculadirigida.AutoSize = true;
            this.LabelPeliculadirigida.Location = new System.Drawing.Point(12, 68);
            this.LabelPeliculadirigida.Name = "LabelPeliculadirigida";
            this.LabelPeliculadirigida.Size = new System.Drawing.Size(102, 19);
            this.LabelPeliculadirigida.TabIndex = 3;
            this.LabelPeliculadirigida.Text = "Pelicula Dirigida";
            // 
            // LabelNombre
            // 
            this.LabelNombre.AutoSize = true;
            this.LabelNombre.Location = new System.Drawing.Point(12, 141);
            this.LabelNombre.Name = "LabelNombre";
            this.LabelNombre.Size = new System.Drawing.Size(140, 19);
            this.LabelNombre.TabIndex = 4;
            this.LabelNombre.Text = "Nombre de la pelicula";
            // 
            // LabelFechaestreno
            // 
            this.LabelFechaestreno.AutoSize = true;
            this.LabelFechaestreno.Location = new System.Drawing.Point(12, 233);
            this.LabelFechaestreno.Name = "LabelFechaestreno";
            this.LabelFechaestreno.Size = new System.Drawing.Size(109, 19);
            this.LabelFechaestreno.TabIndex = 5;
            this.LabelFechaestreno.Text = "Fecha de estreno";
            // 
            // txtPeliculadirigida
            // 
            // 
            // 
            // 
            this.txtPeliculadirigida.CustomButton.Image = null;
            this.txtPeliculadirigida.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtPeliculadirigida.CustomButton.Name = "";
            this.txtPeliculadirigida.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPeliculadirigida.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPeliculadirigida.CustomButton.TabIndex = 1;
            this.txtPeliculadirigida.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPeliculadirigida.CustomButton.UseSelectable = true;
            this.txtPeliculadirigida.CustomButton.Visible = false;
            this.txtPeliculadirigida.Lines = new string[0];
            this.txtPeliculadirigida.Location = new System.Drawing.Point(181, 68);
            this.txtPeliculadirigida.MaxLength = 32767;
            this.txtPeliculadirigida.Name = "txtPeliculadirigida";
            this.txtPeliculadirigida.PasswordChar = '\0';
            this.txtPeliculadirigida.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPeliculadirigida.SelectedText = "";
            this.txtPeliculadirigida.SelectionLength = 0;
            this.txtPeliculadirigida.SelectionStart = 0;
            this.txtPeliculadirigida.ShortcutsEnabled = true;
            this.txtPeliculadirigida.Size = new System.Drawing.Size(200, 23);
            this.txtPeliculadirigida.TabIndex = 6;
            this.txtPeliculadirigida.UseSelectable = true;
            this.txtPeliculadirigida.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPeliculadirigida.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNombre
            // 
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(181, 141);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(200, 23);
            this.txtNombre.TabIndex = 7;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(81, 347);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(95, 33);
            this.BtnAgregar.TabIndex = 9;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseSelectable = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(286, 346);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(95, 34);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(594, 376);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 31);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseSelectable = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dtfechaesteno
            // 
            this.dtfechaesteno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtfechaesteno.Location = new System.Drawing.Point(181, 223);
            this.dtfechaesteno.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtfechaesteno.Name = "dtfechaesteno";
            this.dtfechaesteno.Size = new System.Drawing.Size(200, 29);
            this.dtfechaesteno.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(400, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(388, 284);
            this.dataGridView1.TabIndex = 17;
            // 
            // FmrPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtfechaesteno);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtPeliculadirigida);
            this.Controls.Add(this.LabelFechaestreno);
            this.Controls.Add(this.LabelNombre);
            this.Controls.Add(this.LabelPeliculadirigida);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FmrPelicula";
            this.Text = "Cartelera";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peliculaToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel LabelPeliculadirigida;
        private MetroFramework.Controls.MetroLabel LabelNombre;
        private MetroFramework.Controls.MetroLabel LabelFechaestreno;
        private MetroFramework.Controls.MetroTextBox txtPeliculadirigida;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroButton BtnAgregar;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnSalir;
        private MetroFramework.Controls.MetroDateTime dtfechaesteno;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

