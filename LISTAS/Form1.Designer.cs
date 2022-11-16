namespace LISTAS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textCantidad = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.listBoxNum = new System.Windows.Forms.ListBox();
            this.textMedia = new System.Windows.Forms.TextBox();
            this.textMediana = new System.Windows.Forms.TextBox();
            this.textModa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.textDesvStan = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(1)))), ((int)(((byte)(33)))));
            this.BtnSalir.Location = new System.Drawing.Point(450, 449);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(111, 37);
            this.BtnSalir.TabIndex = 7;
            this.BtnSalir.Text = "SALIR";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LISTAS.Properties.Resources.liquid_preloader_dribbble_v2;
            this.pictureBox1.Location = new System.Drawing.Point(121, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(742, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textCantidad
            // 
            this.textCantidad.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textCantidad.Location = new System.Drawing.Point(41, 28);
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.Size = new System.Drawing.Size(111, 33);
            this.textCantidad.TabIndex = 0;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(1)))), ((int)(((byte)(33)))));
            this.BtnAgregar.Location = new System.Drawing.Point(41, 67);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(111, 37);
            this.BtnAgregar.TabIndex = 1;
            this.BtnAgregar.Text = "AGREGAR";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(1)))), ((int)(((byte)(33)))));
            this.BtnNuevo.Location = new System.Drawing.Point(41, 449);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(111, 37);
            this.BtnNuevo.TabIndex = 4;
            this.BtnNuevo.Text = "NUEVO";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // listBoxNum
            // 
            this.listBoxNum.FormattingEnabled = true;
            this.listBoxNum.ItemHeight = 15;
            this.listBoxNum.Location = new System.Drawing.Point(41, 126);
            this.listBoxNum.Name = "listBoxNum";
            this.listBoxNum.Size = new System.Drawing.Size(111, 304);
            this.listBoxNum.TabIndex = 500;
            // 
            // textMedia
            // 
            this.textMedia.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textMedia.Location = new System.Drawing.Point(176, 103);
            this.textMedia.Name = "textMedia";
            this.textMedia.Size = new System.Drawing.Size(174, 33);
            this.textMedia.TabIndex = 300;
            // 
            // textMediana
            // 
            this.textMediana.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textMediana.Location = new System.Drawing.Point(176, 209);
            this.textMediana.Name = "textMediana";
            this.textMediana.Size = new System.Drawing.Size(174, 33);
            this.textMediana.TabIndex = 800;
            // 
            // textModa
            // 
            this.textModa.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textModa.Location = new System.Drawing.Point(176, 309);
            this.textModa.Name = "textModa";
            this.textModa.Size = new System.Drawing.Size(174, 33);
            this.textModa.TabIndex = 1000;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(240, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "MEDIA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(232, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "MEDIANA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(239, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "MODA";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(196, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 15);
            this.label7.TabIndex = 1001;
            this.label7.Text = "DESVIACION ESTANDAR";
            // 
            // textDesvStan
            // 
            this.textDesvStan.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textDesvStan.Location = new System.Drawing.Point(176, 397);
            this.textDesvStan.Name = "textDesvStan";
            this.textDesvStan.Size = new System.Drawing.Size(174, 33);
            this.textDesvStan.TabIndex = 1002;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.BtnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalcular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCalcular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(1)))), ((int)(((byte)(33)))));
            this.BtnCalcular.Location = new System.Drawing.Point(205, 28);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(111, 37);
            this.BtnCalcular.TabIndex = 2;
            this.BtnCalcular.Text = "CALCULAR";
            this.BtnCalcular.UseVisualStyleBackColor = false;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(1)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(629, 498);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textDesvStan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textModa);
            this.Controls.Add(this.textMediana);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.textMedia);
            this.Controls.Add(this.listBoxNum);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.textCantidad);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnSalir;
        private PictureBox pictureBox1;
        private TextBox textCantidad;
        private Button BtnAgregar;
        private Button BtnNuevo;
        private ListBox listBoxNum;
        private TextBox textMedia;
        private TextBox textMediana;
        private TextBox textModa;
        private Label label1;
        private Label label2;
        private Label label3;
        private ErrorProvider errorProvider1;
        private Label label7;
        private TextBox textDesvStan;
        private Button BtnCalcular;
    }
}