namespace ImageToSpeech
{
    partial class FormPral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPral));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonComunica = new System.Windows.Forms.Button();
            this.buttonConfort = new System.Windows.Forms.Button();
            this.buttonSentimientos = new System.Windows.Forms.Button();
            this.buttonCuerpo = new System.Windows.Forms.Button();
            this.buttonUrgencias = new System.Windows.Forms.Button();
            this.buttonAveces = new System.Windows.Forms.Button();
            this.buttonNo = new System.Windows.Forms.Button();
            this.buttonSi = new System.Windows.Forms.Button();
            this.buttonAuxilio = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkGreen;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.buttonComunica, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonConfort, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonSentimientos, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonCuerpo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonUrgencias, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 48);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(287, 297);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonComunica
            // 
            this.buttonComunica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonComunica.BackgroundImage = global::ImageToSpeech.Properties.Resources.l_fondo;
            this.buttonComunica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonComunica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonComunica.Font = new System.Drawing.Font("Liberation Sans", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonComunica.Location = new System.Drawing.Point(45, 251);
            this.buttonComunica.Name = "buttonComunica";
            this.buttonComunica.Size = new System.Drawing.Size(196, 35);
            this.buttonComunica.TabIndex = 4;
            this.buttonComunica.Text = "COMUNICA +";
            this.buttonComunica.UseVisualStyleBackColor = true;
            this.buttonComunica.Click += new System.EventHandler(this.buttonComunica_Click);
            // 
            // buttonConfort
            // 
            this.buttonConfort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonConfort.BackgroundImage = global::ImageToSpeech.Properties.Resources.l_fondo;
            this.buttonConfort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonConfort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConfort.Font = new System.Drawing.Font("Liberation Sans", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfort.Location = new System.Drawing.Point(45, 192);
            this.buttonConfort.Name = "buttonConfort";
            this.buttonConfort.Size = new System.Drawing.Size(196, 35);
            this.buttonConfort.TabIndex = 3;
            this.buttonConfort.Text = "CONFORT";
            this.buttonConfort.UseVisualStyleBackColor = true;
            this.buttonConfort.Click += new System.EventHandler(this.buttonConfort_Click);
            // 
            // buttonSentimientos
            // 
            this.buttonSentimientos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSentimientos.BackgroundImage = global::ImageToSpeech.Properties.Resources.l_fondo;
            this.buttonSentimientos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSentimientos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSentimientos.Font = new System.Drawing.Font("Liberation Sans", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSentimientos.Location = new System.Drawing.Point(45, 132);
            this.buttonSentimientos.Name = "buttonSentimientos";
            this.buttonSentimientos.Size = new System.Drawing.Size(196, 35);
            this.buttonSentimientos.TabIndex = 2;
            this.buttonSentimientos.Text = "SENTIR";
            this.buttonSentimientos.UseVisualStyleBackColor = true;
            this.buttonSentimientos.Click += new System.EventHandler(this.buttonSentimientos_Click);
            // 
            // buttonCuerpo
            // 
            this.buttonCuerpo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCuerpo.BackgroundImage = global::ImageToSpeech.Properties.Resources.l_fondo;
            this.buttonCuerpo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCuerpo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCuerpo.Font = new System.Drawing.Font("Liberation Sans", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCuerpo.Location = new System.Drawing.Point(45, 72);
            this.buttonCuerpo.Name = "buttonCuerpo";
            this.buttonCuerpo.Size = new System.Drawing.Size(196, 35);
            this.buttonCuerpo.TabIndex = 1;
            this.buttonCuerpo.Text = "CUERPO";
            this.buttonCuerpo.UseVisualStyleBackColor = true;
            this.buttonCuerpo.Click += new System.EventHandler(this.buttonCuerpo_Click);
            // 
            // buttonUrgencias
            // 
            this.buttonUrgencias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUrgencias.BackgroundImage = global::ImageToSpeech.Properties.Resources.l_fondo;
            this.buttonUrgencias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUrgencias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUrgencias.Font = new System.Drawing.Font("Liberation Sans", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUrgencias.Location = new System.Drawing.Point(45, 12);
            this.buttonUrgencias.Name = "buttonUrgencias";
            this.buttonUrgencias.Size = new System.Drawing.Size(196, 35);
            this.buttonUrgencias.TabIndex = 0;
            this.buttonUrgencias.Text = "URGENCIAS";
            this.buttonUrgencias.UseVisualStyleBackColor = true;
            this.buttonUrgencias.Click += new System.EventHandler(this.buttonUrgencias_Click);
            // 
            // buttonAveces
            // 
            this.buttonAveces.AccessibleDescription = "Aveces";
            this.buttonAveces.AccessibleName = "Aveces";
            this.buttonAveces.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.buttonAveces.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAveces.BackgroundImage = global::ImageToSpeech.Properties.Resources.aVeces;
            this.buttonAveces.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAveces.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAveces.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAveces.Location = new System.Drawing.Point(93, 453);
            this.buttonAveces.Name = "buttonAveces";
            this.buttonAveces.Size = new System.Drawing.Size(103, 46);
            this.buttonAveces.TabIndex = 13;
            this.buttonAveces.UseVisualStyleBackColor = true;
            this.buttonAveces.Click += new System.EventHandler(this.buttonAveces_Click);
            // 
            // buttonNo
            // 
            this.buttonNo.AccessibleDescription = "No";
            this.buttonNo.AccessibleName = "No";
            this.buttonNo.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.buttonNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNo.BackgroundImage = global::ImageToSpeech.Properties.Resources.no;
            this.buttonNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNo.Location = new System.Drawing.Point(211, 453);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(61, 46);
            this.buttonNo.TabIndex = 12;
            this.buttonNo.UseVisualStyleBackColor = true;
            this.buttonNo.Click += new System.EventHandler(this.buttonNo_Click);
            // 
            // buttonSi
            // 
            this.buttonSi.AccessibleDescription = "Si";
            this.buttonSi.AccessibleName = "Si";
            this.buttonSi.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.buttonSi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSi.BackgroundImage = global::ImageToSpeech.Properties.Resources.si;
            this.buttonSi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSi.Location = new System.Drawing.Point(13, 453);
            this.buttonSi.Name = "buttonSi";
            this.buttonSi.Size = new System.Drawing.Size(62, 46);
            this.buttonSi.TabIndex = 11;
            this.buttonSi.UseVisualStyleBackColor = true;
            this.buttonSi.Click += new System.EventHandler(this.buttonSi_Click);
            // 
            // buttonAuxilio
            // 
            this.buttonAuxilio.AccessibleDescription = "Auxilio";
            this.buttonAuxilio.AccessibleName = "Auxilio";
            this.buttonAuxilio.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.buttonAuxilio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAuxilio.BackgroundImage = global::ImageToSpeech.Properties.Resources.ayuda;
            this.buttonAuxilio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAuxilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.buttonAuxilio.Location = new System.Drawing.Point(89, 361);
            this.buttonAuxilio.Name = "buttonAuxilio";
            this.buttonAuxilio.Size = new System.Drawing.Size(113, 69);
            this.buttonAuxilio.TabIndex = 14;
            this.buttonAuxilio.Text = "S O S";
            this.buttonAuxilio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAuxilio.UseVisualStyleBackColor = true;
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackgroundImage = global::ImageToSpeech.Properties.Resources.l_fondo;
            this.buttonSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.Location = new System.Drawing.Point(187, -2);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(100, 37);
            this.buttonSalir.TabIndex = 15;
            this.buttonSalir.Text = "SALIR";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // FormPral
            // 
            this.AccessibleDescription = "PanelComunicacionNoVerbal";
            this.AccessibleName = "PanelComunicacionNoVerbal";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(287, 507);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonAuxilio);
            this.Controls.Add(this.buttonAveces);
            this.Controls.Add(this.buttonNo);
            this.Controls.Add(this.buttonSi);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormPral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel de Comunicación";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPral_FormClosed);
            this.Load += new System.EventHandler(this.FormPral_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonUrgencias;
        private System.Windows.Forms.Button buttonComunica;
        private System.Windows.Forms.Button buttonConfort;
        private System.Windows.Forms.Button buttonSentimientos;
        private System.Windows.Forms.Button buttonCuerpo;
        private System.Windows.Forms.Button buttonAveces;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.Button buttonSi;
        private System.Windows.Forms.Button buttonAuxilio;
        private System.Windows.Forms.Button buttonSalir;
    }
}

