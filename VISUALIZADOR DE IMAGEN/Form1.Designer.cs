namespace VISUALIZADOR_DE_IMAGEN
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.mostrarimagenButton = new System.Windows.Forms.Button();
            this.borrarlaimagenButton = new System.Windows.Forms.Button();
            this.establecerelcolordefondoButton = new System.Windows.Forms.Button();
            this.cerrarButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(931, 514);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(925, 456);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox1.Location = new System.Drawing.Point(3, 465);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(133, 46);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Stretch";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.mostrarimagenButton);
            this.flowLayoutPanel1.Controls.Add(this.borrarlaimagenButton);
            this.flowLayoutPanel1.Controls.Add(this.establecerelcolordefondoButton);
            this.flowLayoutPanel1.Controls.Add(this.cerrarButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(142, 465);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(786, 46);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // mostrarimagenButton
            // 
            this.mostrarimagenButton.AutoSize = true;
            this.mostrarimagenButton.Location = new System.Drawing.Point(643, 3);
            this.mostrarimagenButton.Name = "mostrarimagenButton";
            this.mostrarimagenButton.Size = new System.Drawing.Size(140, 26);
            this.mostrarimagenButton.TabIndex = 0;
            this.mostrarimagenButton.Text = "MOSTRAR IMAGEN";
            this.mostrarimagenButton.UseVisualStyleBackColor = true;
            this.mostrarimagenButton.Click += new System.EventHandler(this.MostrarimagenButton_Click);
            // 
            // borrarlaimagenButton
            // 
            this.borrarlaimagenButton.AutoSize = true;
            this.borrarlaimagenButton.Location = new System.Drawing.Point(488, 3);
            this.borrarlaimagenButton.Name = "borrarlaimagenButton";
            this.borrarlaimagenButton.Size = new System.Drawing.Size(149, 26);
            this.borrarlaimagenButton.TabIndex = 1;
            this.borrarlaimagenButton.Text = "BORRAR LA IMAGEN";
            this.borrarlaimagenButton.UseVisualStyleBackColor = true;
            this.borrarlaimagenButton.Click += new System.EventHandler(this.BorrarlaimagenButton_Click);
            // 
            // establecerelcolordefondoButton
            // 
            this.establecerelcolordefondoButton.AutoSize = true;
            this.establecerelcolordefondoButton.Location = new System.Drawing.Point(235, 3);
            this.establecerelcolordefondoButton.Name = "establecerelcolordefondoButton";
            this.establecerelcolordefondoButton.Size = new System.Drawing.Size(247, 26);
            this.establecerelcolordefondoButton.TabIndex = 2;
            this.establecerelcolordefondoButton.Text = "ESTABLECER EL COLOR DE FONDO";
            this.establecerelcolordefondoButton.UseVisualStyleBackColor = true;
            this.establecerelcolordefondoButton.Click += new System.EventHandler(this.EstablecerelcolordefondoButton_Click);
            // 
            // cerrarButton
            // 
            this.cerrarButton.AutoSize = true;
            this.cerrarButton.Location = new System.Drawing.Point(154, 3);
            this.cerrarButton.Name = "cerrarButton";
            this.cerrarButton.Size = new System.Drawing.Size(75, 26);
            this.cerrarButton.TabIndex = 3;
            this.cerrarButton.Text = "CERRAR";
            this.cerrarButton.UseVisualStyleBackColor = true;
            this.cerrarButton.Click += new System.EventHandler(this.CerrarButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this.openFileDialog1.Title = "Seleccione un archivo de imagen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 514);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "VISUALIZADOR DE IMAGENES ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button mostrarimagenButton;
        private System.Windows.Forms.Button borrarlaimagenButton;
        private System.Windows.Forms.Button establecerelcolordefondoButton;
        private System.Windows.Forms.Button cerrarButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

