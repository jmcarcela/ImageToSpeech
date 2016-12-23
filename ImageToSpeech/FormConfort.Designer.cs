namespace ImageToSpeech
{
    partial class FormConfort
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfort));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonPapel = new System.Windows.Forms.Button();
            this.buttonSabanas = new System.Windows.Forms.Button();
            this.buttonSentir = new System.Windows.Forms.Button();
            this.buttonAtras = new System.Windows.Forms.Button();
            this.buttonFecha = new System.Windows.Forms.Button();
            this.buttonBata = new System.Windows.Forms.Button();
            this.buttonHora = new System.Windows.Forms.Button();
            this.buttonDonde = new System.Windows.Forms.Button();
            this.buttonPijama = new System.Windows.Forms.Button();
            this.buttonZapatillas = new System.Windows.Forms.Button();
            this.buttonCamison = new System.Windows.Forms.Button();
            this.buttonOcurrido = new System.Windows.Forms.Button();
            this.buttonAveces = new System.Windows.Forms.Button();
            this.buttonNo = new System.Windows.Forms.Button();
            this.buttonSi = new System.Windows.Forms.Button();
            this.buttonInicio = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buttonFecha, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonHora, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonOcurrido, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonDonde, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonPijama, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonCamison, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonBata, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonZapatillas, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonPapel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonSabanas, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 37);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(287, 403);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // buttonPapel
            // 
            this.buttonPapel.AccessibleDescription = "Papel";
            this.buttonPapel.AccessibleName = "Papel";
            this.buttonPapel.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.buttonPapel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPapel.BackgroundImage = global::ImageToSpeech.Properties.Resources.papellimpiar;
            this.buttonPapel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPapel.Location = new System.Drawing.Point(15, 326);
            this.buttonPapel.Name = "buttonPapel";
            this.buttonPapel.Size = new System.Drawing.Size(112, 71);
            this.buttonPapel.TabIndex = 11;
            this.buttonPapel.UseVisualStyleBackColor = true;
            this.buttonPapel.Click += new System.EventHandler(this.buttonPapel_Click);
            // 
            // buttonSabanas
            // 
            this.buttonSabanas.AccessibleDescription = "Sabanas";
            this.buttonSabanas.AccessibleName = "Sabanas";
            this.buttonSabanas.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.buttonSabanas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSabanas.BackgroundImage = global::ImageToSpeech.Properties.Resources.sabanas;
            this.buttonSabanas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSabanas.Location = new System.Drawing.Point(158, 326);
            this.buttonSabanas.Name = "buttonSabanas";
            this.buttonSabanas.Size = new System.Drawing.Size(113, 71);
            this.buttonSabanas.TabIndex = 10;
            this.buttonSabanas.UseVisualStyleBackColor = true;
            this.buttonSabanas.Click += new System.EventHandler(this.buttonSabanas_Click);
            // 
            // buttonSentir
            // 
            this.buttonSentir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSentir.BackgroundImage = global::ImageToSpeech.Properties.Resources.foward1;
            this.buttonSentir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSentir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSentir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSentir.Location = new System.Drawing.Point(192, 3);
            this.buttonSentir.Name = "buttonSentir";
            this.buttonSentir.Size = new System.Drawing.Size(95, 27);
            this.buttonSentir.TabIndex = 1;
            this.buttonSentir.Text = "Confort 2";
            this.buttonSentir.UseVisualStyleBackColor = true;
            this.buttonSentir.Click += new System.EventHandler(this.buttonSentir_Click);
            // 
            // buttonAtras
            // 
            this.buttonAtras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAtras.BackgroundImage = global::ImageToSpeech.Properties.Resources.back;
            this.buttonAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAtras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtras.Location = new System.Drawing.Point(5, 3);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(97, 27);
            this.buttonAtras.TabIndex = 0;
            this.buttonAtras.Text = "Sentimientos";
            this.buttonAtras.UseVisualStyleBackColor = true;
            this.buttonAtras.Click += new System.EventHandler(this.buttonAtras_Click);
            // 
            // buttonFecha
            // 
            this.buttonFecha.AccessibleDescription = "Fecha";
            this.buttonFecha.AccessibleName = "Fecha";
            this.buttonFecha.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.buttonFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFecha.BackgroundImage = global::ImageToSpeech.Properties.Resources.fecha;
            this.buttonFecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFecha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFecha.Location = new System.Drawing.Point(15, 4);
            this.buttonFecha.Name = "buttonFecha";
            this.buttonFecha.Size = new System.Drawing.Size(113, 71);
            this.buttonFecha.TabIndex = 2;
            this.buttonFecha.UseVisualStyleBackColor = true;
            this.buttonFecha.Click += new System.EventHandler(this.buttonFecha_Click);
            // 
            // buttonBata
            // 
            this.buttonBata.AccessibleDescription = "Bata";
            this.buttonBata.AccessibleName = "Bata";
            this.buttonBata.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.buttonBata.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBata.BackgroundImage = global::ImageToSpeech.Properties.Resources.bata;
            this.buttonBata.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBata.Location = new System.Drawing.Point(15, 243);
            this.buttonBata.Name = "buttonBata";
            this.buttonBata.Size = new System.Drawing.Size(113, 74);
            this.buttonBata.TabIndex = 8;
            this.buttonBata.UseVisualStyleBackColor = true;
            this.buttonBata.Click += new System.EventHandler(this.buttonBata_Click);
            // 
            // buttonHora
            // 
            this.buttonHora.AccessibleDescription = "Hora";
            this.buttonHora.AccessibleName = "Hora";
            this.buttonHora.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.buttonHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonHora.BackgroundImage = global::ImageToSpeech.Properties.Resources.hora;
            this.buttonHora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonHora.Location = new System.Drawing.Point(159, 4);
            this.buttonHora.Name = "buttonHora";
            this.buttonHora.Size = new System.Drawing.Size(112, 71);
            this.buttonHora.TabIndex = 3;
            this.buttonHora.UseVisualStyleBackColor = true;
            this.buttonHora.Click += new System.EventHandler(this.buttonHora_Click);
            // 
            // buttonDonde
            // 
            this.buttonDonde.AccessibleDescription = "Donde";
            this.buttonDonde.AccessibleName = "Donde";
            this.buttonDonde.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.buttonDonde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDonde.BackgroundImage = global::ImageToSpeech.Properties.Resources.dondeEstoy;
            this.buttonDonde.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDonde.Location = new System.Drawing.Point(158, 87);
            this.buttonDonde.Name = "buttonDonde";
            this.buttonDonde.Size = new System.Drawing.Size(113, 66);
            this.buttonDonde.TabIndex = 5;
            this.buttonDonde.UseVisualStyleBackColor = true;
            this.buttonDonde.Click += new System.EventHandler(this.buttonDonde_Click);
            // 
            // buttonPijama
            // 
            this.buttonPijama.AccessibleDescription = "Pijama";
            this.buttonPijama.AccessibleName = "Pijama";
            this.buttonPijama.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.buttonPijama.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPijama.BackgroundImage = global::ImageToSpeech.Properties.Resources.pijama;
            this.buttonPijama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPijama.Location = new System.Drawing.Point(15, 167);
            this.buttonPijama.Name = "buttonPijama";
            this.buttonPijama.Size = new System.Drawing.Size(113, 66);
            this.buttonPijama.TabIndex = 6;
            this.buttonPijama.UseVisualStyleBackColor = true;
            this.buttonPijama.Click += new System.EventHandler(this.buttonPijama_Click);
            // 
            // buttonZapatillas
            // 
            this.buttonZapatillas.AccessibleDescription = "Zapatillas";
            this.buttonZapatillas.AccessibleName = "Zapatillas";
            this.buttonZapatillas.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.buttonZapatillas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonZapatillas.BackgroundImage = global::ImageToSpeech.Properties.Resources.zapatillas;
            this.buttonZapatillas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonZapatillas.Location = new System.Drawing.Point(158, 243);
            this.buttonZapatillas.Name = "buttonZapatillas";
            this.buttonZapatillas.Size = new System.Drawing.Size(113, 74);
            this.buttonZapatillas.TabIndex = 7;
            this.buttonZapatillas.UseVisualStyleBackColor = true;
            this.buttonZapatillas.Click += new System.EventHandler(this.buttonZapatillas_Click);
            // 
            // buttonCamison
            // 
            this.buttonCamison.AccessibleDescription = "Camison";
            this.buttonCamison.AccessibleName = "Camison";
            this.buttonCamison.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.buttonCamison.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCamison.BackgroundImage = global::ImageToSpeech.Properties.Resources.camison;
            this.buttonCamison.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCamison.Location = new System.Drawing.Point(158, 167);
            this.buttonCamison.Name = "buttonCamison";
            this.buttonCamison.Size = new System.Drawing.Size(113, 66);
            this.buttonCamison.TabIndex = 4;
            this.buttonCamison.UseVisualStyleBackColor = true;
            this.buttonCamison.Click += new System.EventHandler(this.buttonCamison_Click);
            // 
            // buttonOcurrido
            // 
            this.buttonOcurrido.AccessibleDescription = "Ocurrido";
            this.buttonOcurrido.AccessibleName = "Ocurrido";
            this.buttonOcurrido.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.buttonOcurrido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOcurrido.BackgroundImage = global::ImageToSpeech.Properties.Resources.quePasado1;
            this.buttonOcurrido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOcurrido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.buttonOcurrido.Location = new System.Drawing.Point(15, 87);
            this.buttonOcurrido.Name = "buttonOcurrido";
            this.buttonOcurrido.Size = new System.Drawing.Size(113, 66);
            this.buttonOcurrido.TabIndex = 9;
            this.buttonOcurrido.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonOcurrido.UseVisualStyleBackColor = true;
            this.buttonOcurrido.Click += new System.EventHandler(this.buttonOcurrido_Click);
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
            this.buttonAveces.Location = new System.Drawing.Point(95, 458);
            this.buttonAveces.Name = "buttonAveces";
            this.buttonAveces.Size = new System.Drawing.Size(103, 46);
            this.buttonAveces.TabIndex = 21;
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
            this.buttonNo.Location = new System.Drawing.Point(213, 458);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(61, 46);
            this.buttonNo.TabIndex = 20;
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
            this.buttonSi.Location = new System.Drawing.Point(15, 458);
            this.buttonSi.Name = "buttonSi";
            this.buttonSi.Size = new System.Drawing.Size(62, 46);
            this.buttonSi.TabIndex = 19;
            this.buttonSi.UseVisualStyleBackColor = true;
            this.buttonSi.Click += new System.EventHandler(this.buttonSi_Click);
            // 
            // buttonInicio
            // 
            this.buttonInicio.AccessibleDescription = "I";
            this.buttonInicio.AccessibleName = "I";
            this.buttonInicio.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.buttonInicio.BackgroundImage = global::ImageToSpeech.Properties.Resources.l_fondo;
            this.buttonInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInicio.Location = new System.Drawing.Point(108, 1);
            this.buttonInicio.Name = "buttonInicio";
            this.buttonInicio.Size = new System.Drawing.Size(79, 30);
            this.buttonInicio.TabIndex = 82;
            this.buttonInicio.Text = "Inicio";
            this.buttonInicio.UseVisualStyleBackColor = true;
            this.buttonInicio.Click += new System.EventHandler(this.buttonInicio_Click);
            // 
            // FormConfort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(291, 511);
            this.Controls.Add(this.buttonInicio);
            this.Controls.Add(this.buttonAveces);
            this.Controls.Add(this.buttonNo);
            this.Controls.Add(this.buttonSentir);
            this.Controls.Add(this.buttonSi);
            this.Controls.Add(this.buttonAtras);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConfort";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paneles de CONFORT 1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormConfort_FormClosed);
            this.Load += new System.EventHandler(this.FormConfort_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAveces;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.Button buttonSi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonPapel;
        private System.Windows.Forms.Button buttonSabanas;
        private System.Windows.Forms.Button buttonSentir;
        private System.Windows.Forms.Button buttonAtras;
        private System.Windows.Forms.Button buttonFecha;
        private System.Windows.Forms.Button buttonBata;
        private System.Windows.Forms.Button buttonHora;
        private System.Windows.Forms.Button buttonDonde;
        private System.Windows.Forms.Button buttonPijama;
        private System.Windows.Forms.Button buttonZapatillas;
        private System.Windows.Forms.Button buttonCamison;
        private System.Windows.Forms.Button buttonOcurrido;
        private System.Windows.Forms.Button buttonInicio;
    }
}