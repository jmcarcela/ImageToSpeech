namespace ImageToSpeech
{
    partial class FormUrgencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUrgencias));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEnfermera = new System.Windows.Forms.Button();
            this.buttonMedico = new System.Windows.Forms.Button();
            this.buttonAuxilio = new System.Windows.Forms.Button();
            this.buttonRespirar = new System.Windows.Forms.Button();
            this.buttonMareo = new System.Windows.Forms.Button();
            this.buttonTragar = new System.Windows.Forms.Button();
            this.buttonVomitar = new System.Windows.Forms.Button();
            this.buttonFiebre = new System.Windows.Forms.Button();
            this.buttonAveces = new System.Windows.Forms.Button();
            this.buttonNo = new System.Windows.Forms.Button();
            this.buttonSi = new System.Windows.Forms.Button();
            this.buttonCuerpo = new System.Windows.Forms.Button();
            this.buttonAtras = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buttonEnfermera, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonMedico, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonAuxilio, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonRespirar, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonMareo, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonTragar, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonVomitar, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonFiebre, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 51);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(287, 379);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // buttonEnfermera
            // 
            this.buttonEnfermera.AccessibleDescription = "Enfermera";
            this.buttonEnfermera.AccessibleName = "Enfermera";
            this.buttonEnfermera.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.buttonEnfermera.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEnfermera.BackgroundImage = global::ImageToSpeech.Properties.Resources.enfermera;
            this.buttonEnfermera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEnfermera.Location = new System.Drawing.Point(15, 5);
            this.buttonEnfermera.Name = "buttonEnfermera";
            this.buttonEnfermera.Size = new System.Drawing.Size(113, 84);
            this.buttonEnfermera.TabIndex = 2;
            this.buttonEnfermera.UseVisualStyleBackColor = true;
            this.buttonEnfermera.Click += new System.EventHandler(this.buttonEnfermera_Click);
            // 
            // buttonMedico
            // 
            this.buttonMedico.AccessibleDescription = "Medico";
            this.buttonMedico.AccessibleName = "Medico";
            this.buttonMedico.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.buttonMedico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonMedico.BackgroundImage = global::ImageToSpeech.Properties.Resources.medico;
            this.buttonMedico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMedico.Location = new System.Drawing.Point(159, 5);
            this.buttonMedico.Name = "buttonMedico";
            this.buttonMedico.Size = new System.Drawing.Size(112, 84);
            this.buttonMedico.TabIndex = 3;
            this.buttonMedico.UseVisualStyleBackColor = true;
            this.buttonMedico.Click += new System.EventHandler(this.buttonMedico_Click);
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
            this.buttonAuxilio.Location = new System.Drawing.Point(15, 100);
            this.buttonAuxilio.Name = "buttonAuxilio";
            this.buttonAuxilio.Size = new System.Drawing.Size(113, 84);
            this.buttonAuxilio.TabIndex = 9;
            this.buttonAuxilio.Text = "S O S";
            this.buttonAuxilio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAuxilio.UseVisualStyleBackColor = true;
            this.buttonAuxilio.Click += new System.EventHandler(this.buttonAuxilio_Click);
            // 
            // buttonRespirar
            // 
            this.buttonRespirar.AccessibleDescription = "Respirar";
            this.buttonRespirar.AccessibleName = "Respirar";
            this.buttonRespirar.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.buttonRespirar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRespirar.BackgroundImage = global::ImageToSpeech.Properties.Resources.respirar;
            this.buttonRespirar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRespirar.Location = new System.Drawing.Point(158, 100);
            this.buttonRespirar.Name = "buttonRespirar";
            this.buttonRespirar.Size = new System.Drawing.Size(113, 84);
            this.buttonRespirar.TabIndex = 5;
            this.buttonRespirar.UseVisualStyleBackColor = true;
            this.buttonRespirar.Click += new System.EventHandler(this.buttonRespirar_Click);
            // 
            // buttonMareo
            // 
            this.buttonMareo.AccessibleDescription = "Mareo";
            this.buttonMareo.AccessibleName = "Mareo";
            this.buttonMareo.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.buttonMareo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonMareo.BackgroundImage = global::ImageToSpeech.Properties.Resources.mareo;
            this.buttonMareo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMareo.Location = new System.Drawing.Point(15, 195);
            this.buttonMareo.Name = "buttonMareo";
            this.buttonMareo.Size = new System.Drawing.Size(113, 84);
            this.buttonMareo.TabIndex = 6;
            this.buttonMareo.UseVisualStyleBackColor = true;
            this.buttonMareo.Click += new System.EventHandler(this.buttonMareo_Click);
            // 
            // buttonTragar
            // 
            this.buttonTragar.AccessibleDescription = "Tragar";
            this.buttonTragar.AccessibleName = "Tragar";
            this.buttonTragar.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.buttonTragar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTragar.BackgroundImage = global::ImageToSpeech.Properties.Resources.tragar;
            this.buttonTragar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTragar.Location = new System.Drawing.Point(158, 195);
            this.buttonTragar.Name = "buttonTragar";
            this.buttonTragar.Size = new System.Drawing.Size(113, 84);
            this.buttonTragar.TabIndex = 4;
            this.buttonTragar.UseVisualStyleBackColor = true;
            this.buttonTragar.Click += new System.EventHandler(this.buttonTragar_Click);
            // 
            // buttonVomitar
            // 
            this.buttonVomitar.AccessibleDescription = "Vomitar";
            this.buttonVomitar.AccessibleName = "Vomitar";
            this.buttonVomitar.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.buttonVomitar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonVomitar.BackgroundImage = global::ImageToSpeech.Properties.Resources.vomito;
            this.buttonVomitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonVomitar.Location = new System.Drawing.Point(158, 290);
            this.buttonVomitar.Name = "buttonVomitar";
            this.buttonVomitar.Size = new System.Drawing.Size(113, 84);
            this.buttonVomitar.TabIndex = 7;
            this.buttonVomitar.UseVisualStyleBackColor = true;
            this.buttonVomitar.Click += new System.EventHandler(this.buttonVomitar_Click);
            // 
            // buttonFiebre
            // 
            this.buttonFiebre.AccessibleDescription = "Fiebre";
            this.buttonFiebre.AccessibleName = "Fiebre";
            this.buttonFiebre.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.buttonFiebre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFiebre.BackgroundImage = global::ImageToSpeech.Properties.Resources.fiebre;
            this.buttonFiebre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFiebre.Location = new System.Drawing.Point(15, 290);
            this.buttonFiebre.Name = "buttonFiebre";
            this.buttonFiebre.Size = new System.Drawing.Size(113, 84);
            this.buttonFiebre.TabIndex = 8;
            this.buttonFiebre.UseVisualStyleBackColor = true;
            this.buttonFiebre.Click += new System.EventHandler(this.buttonFiebre_Click);
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
            this.buttonAveces.Location = new System.Drawing.Point(96, 457);
            this.buttonAveces.Name = "buttonAveces";
            this.buttonAveces.Size = new System.Drawing.Size(103, 46);
            this.buttonAveces.TabIndex = 10;
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
            this.buttonNo.Location = new System.Drawing.Point(214, 457);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(61, 46);
            this.buttonNo.TabIndex = 9;
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
            this.buttonSi.Location = new System.Drawing.Point(16, 457);
            this.buttonSi.Name = "buttonSi";
            this.buttonSi.Size = new System.Drawing.Size(62, 46);
            this.buttonSi.TabIndex = 8;
            this.buttonSi.UseVisualStyleBackColor = true;
            this.buttonSi.Click += new System.EventHandler(this.buttonSi_Click);
            // 
            // buttonCuerpo
            // 
            this.buttonCuerpo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCuerpo.BackgroundImage = global::ImageToSpeech.Properties.Resources.foward1;
            this.buttonCuerpo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCuerpo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCuerpo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCuerpo.Location = new System.Drawing.Point(189, 2);
            this.buttonCuerpo.Name = "buttonCuerpo";
            this.buttonCuerpo.Size = new System.Drawing.Size(100, 30);
            this.buttonCuerpo.TabIndex = 12;
            this.buttonCuerpo.Text = "Cuerpo";
            this.buttonCuerpo.UseVisualStyleBackColor = true;
            this.buttonCuerpo.Click += new System.EventHandler(this.buttonCuerpo_Click);
            // 
            // buttonAtras
            // 
            this.buttonAtras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAtras.BackgroundImage = global::ImageToSpeech.Properties.Resources.back;
            this.buttonAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAtras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtras.Location = new System.Drawing.Point(2, 2);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(113, 30);
            this.buttonAtras.TabIndex = 11;
            this.buttonAtras.Text = "Panel Principal";
            this.buttonAtras.UseVisualStyleBackColor = true;
            this.buttonAtras.Click += new System.EventHandler(this.buttonAtras_Click);
            // 
            // FormUrgencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(291, 511);
            this.Controls.Add(this.buttonCuerpo);
            this.Controls.Add(this.buttonAtras);
            this.Controls.Add(this.buttonAveces);
            this.Controls.Add(this.buttonNo);
            this.Controls.Add(this.buttonSi);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUrgencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel de URGENCIAS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormUrgencias_FormClosed);
            this.Load += new System.EventHandler(this.FormUrgencias_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonEnfermera;
        private System.Windows.Forms.Button buttonMedico;
        private System.Windows.Forms.Button buttonTragar;
        private System.Windows.Forms.Button buttonRespirar;
        private System.Windows.Forms.Button buttonMareo;
        private System.Windows.Forms.Button buttonVomitar;
        private System.Windows.Forms.Button buttonFiebre;
        private System.Windows.Forms.Button buttonSi;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.Button buttonAveces;
        private System.Windows.Forms.Button buttonAuxilio;
        private System.Windows.Forms.Button buttonCuerpo;
        private System.Windows.Forms.Button buttonAtras;
    }
}