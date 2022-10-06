
namespace OPERACION__FQL_
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.btnReporteFechas = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(211, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Menú de Seleción";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.BackColor = System.Drawing.Color.Blue;
            this.btnCargarDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCargarDatos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCargarDatos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCargarDatos.Location = new System.Drawing.Point(21, 49);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(160, 54);
            this.btnCargarDatos.TabIndex = 4;
            this.btnCargarDatos.Text = "Cargar Datos";
            this.btnCargarDatos.UseVisualStyleBackColor = false;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // btnReporteFechas
            // 
            this.btnReporteFechas.BackColor = System.Drawing.Color.Blue;
            this.btnReporteFechas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReporteFechas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReporteFechas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReporteFechas.Location = new System.Drawing.Point(21, 122);
            this.btnReporteFechas.Name = "btnReporteFechas";
            this.btnReporteFechas.Size = new System.Drawing.Size(160, 63);
            this.btnReporteFechas.TabIndex = 6;
            this.btnReporteFechas.Text = "Generar Reporte por Fechas";
            this.btnReporteFechas.UseVisualStyleBackColor = false;
            this.btnReporteFechas.Click += new System.EventHandler(this.btnReporteFechas_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Maroon;
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAtras.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAtras.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAtras.Location = new System.Drawing.Point(21, 200);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(160, 63);
            this.btnAtras.TabIndex = 8;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 287);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnReporteFechas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCargarDatos);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.Button btnReporteFechas;
        private System.Windows.Forms.Button btnAtras;
    }
}