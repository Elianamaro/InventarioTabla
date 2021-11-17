
namespace Inventario
{
    partial class FormHome
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnEncargado = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnTiendas = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.btn_reportProductos = new System.Windows.Forms.Button();
            this.btn_reportTiendas = new System.Windows.Forms.Button();
            this.btn_reportEncargado = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.LightGreen;
            this.panelTop.Controls.Add(this.btnCerrar);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1010, 52);
            this.panelTop.TabIndex = 1;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(935, 0);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 52);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTROL DE INVENTARIO";
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btn_reportProductos);
            this.panelMenu.Controls.Add(this.btn_reportTiendas);
            this.panelMenu.Controls.Add(this.btn_reportEncargado);
            this.panelMenu.Controls.Add(this.btnEncargado);
            this.panelMenu.Controls.Add(this.btnProductos);
            this.panelMenu.Controls.Add(this.btnTiendas);
            this.panelMenu.Controls.Add(this.btnCategorias);
            this.panelMenu.Controls.Add(this.btnMarcas);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 52);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(192, 513);
            this.panelMenu.TabIndex = 2;
            // 
            // btnEncargado
            // 
            this.btnEncargado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEncargado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEncargado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncargado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncargado.Location = new System.Drawing.Point(0, 228);
            this.btnEncargado.Margin = new System.Windows.Forms.Padding(0);
            this.btnEncargado.Name = "btnEncargado";
            this.btnEncargado.Size = new System.Drawing.Size(192, 55);
            this.btnEncargado.TabIndex = 4;
            this.btnEncargado.Text = "Encargados";
            this.btnEncargado.UseVisualStyleBackColor = false;
            this.btnEncargado.Click += new System.EventHandler(this.btnEncargado_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.Location = new System.Drawing.Point(0, 175);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(0);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(192, 53);
            this.btnProductos.TabIndex = 3;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnTiendas
            // 
            this.btnTiendas.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnTiendas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTiendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTiendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiendas.Location = new System.Drawing.Point(0, 117);
            this.btnTiendas.Margin = new System.Windows.Forms.Padding(0);
            this.btnTiendas.Name = "btnTiendas";
            this.btnTiendas.Size = new System.Drawing.Size(192, 58);
            this.btnTiendas.TabIndex = 2;
            this.btnTiendas.Text = "Tiendas";
            this.btnTiendas.UseVisualStyleBackColor = false;
            this.btnTiendas.Click += new System.EventHandler(this.btnTiendas_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnCategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.Location = new System.Drawing.Point(0, 57);
            this.btnCategorias.Margin = new System.Windows.Forms.Padding(0);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(192, 60);
            this.btnCategorias.TabIndex = 1;
            this.btnCategorias.Text = "Categorías";
            this.btnCategorias.UseVisualStyleBackColor = false;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnMarcas
            // 
            this.btnMarcas.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnMarcas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcas.Location = new System.Drawing.Point(0, 0);
            this.btnMarcas.Margin = new System.Windows.Forms.Padding(0);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(192, 57);
            this.btnMarcas.TabIndex = 0;
            this.btnMarcas.Text = "Marcas";
            this.btnMarcas.UseVisualStyleBackColor = false;
            this.btnMarcas.Click += new System.EventHandler(this.btnMarcas_Click);
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(192, 52);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(818, 513);
            this.panelContent.TabIndex = 3;
            // 
            // btn_reportProductos
            // 
            this.btn_reportProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_reportProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_reportProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reportProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reportProductos.Location = new System.Drawing.Point(0, 394);
            this.btn_reportProductos.Margin = new System.Windows.Forms.Padding(0);
            this.btn_reportProductos.Name = "btn_reportProductos";
            this.btn_reportProductos.Size = new System.Drawing.Size(192, 55);
            this.btn_reportProductos.TabIndex = 7;
            this.btn_reportProductos.Text = "Informe Productos";
            this.btn_reportProductos.UseVisualStyleBackColor = false;
            this.btn_reportProductos.Click += new System.EventHandler(this.btn_reportProductos_Click);
            // 
            // btn_reportTiendas
            // 
            this.btn_reportTiendas.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_reportTiendas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_reportTiendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reportTiendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reportTiendas.Location = new System.Drawing.Point(0, 341);
            this.btn_reportTiendas.Margin = new System.Windows.Forms.Padding(0);
            this.btn_reportTiendas.Name = "btn_reportTiendas";
            this.btn_reportTiendas.Size = new System.Drawing.Size(192, 53);
            this.btn_reportTiendas.TabIndex = 6;
            this.btn_reportTiendas.Text = "Informe Tiendas";
            this.btn_reportTiendas.UseVisualStyleBackColor = false;
            this.btn_reportTiendas.Click += new System.EventHandler(this.btn_reportTiendas_Click);
            // 
            // btn_reportEncargado
            // 
            this.btn_reportEncargado.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_reportEncargado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_reportEncargado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reportEncargado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reportEncargado.Location = new System.Drawing.Point(0, 283);
            this.btn_reportEncargado.Margin = new System.Windows.Forms.Padding(0);
            this.btn_reportEncargado.Name = "btn_reportEncargado";
            this.btn_reportEncargado.Size = new System.Drawing.Size(192, 58);
            this.btn_reportEncargado.TabIndex = 5;
            this.btn_reportEncargado.Text = "Informe Encargados";
            this.btn_reportEncargado.UseVisualStyleBackColor = false;
            this.btn_reportEncargado.Click += new System.EventHandler(this.btn_reportEncargado_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 565);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTop);
            this.Name = "FormHome";
            this.Text = "Form1";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnTiendas;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnMarcas;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEncargado;
        private System.Windows.Forms.Button btn_reportProductos;
        private System.Windows.Forms.Button btn_reportTiendas;
        private System.Windows.Forms.Button btn_reportEncargado;
    }
}

