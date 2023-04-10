namespace Practica
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
            this.tbDay = new System.Windows.Forms.TextBox();
            this.tbMonth = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnCalculateDate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbDay
            // 
            this.tbDay.Location = new System.Drawing.Point(124, 96);
            this.tbDay.Name = "tbDay";
            this.tbDay.Size = new System.Drawing.Size(100, 20);
            this.tbDay.TabIndex = 0;
            // 
            // tbMonth
            // 
            this.tbMonth.Location = new System.Drawing.Point(124, 129);
            this.tbMonth.Name = "tbMonth";
            this.tbMonth.Size = new System.Drawing.Size(100, 20);
            this.tbMonth.TabIndex = 1;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(124, 164);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(100, 20);
            this.tbYear.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(77, 266);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(72, 13);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "La Fecha es: ";
            // 
            // btnCalculateDate
            // 
            this.btnCalculateDate.Location = new System.Drawing.Point(149, 202);
            this.btnCalculateDate.Name = "btnCalculateDate";
            this.btnCalculateDate.Size = new System.Drawing.Size(75, 38);
            this.btnCalculateDate.TabIndex = 4;
            this.btnCalculateDate.Text = "Calcular Fecha";
            this.btnCalculateDate.UseVisualStyleBackColor = true;
            this.btnCalculateDate.Click += new System.EventHandler(this.btnCalculateDate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(230, 204);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 36);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Limpiar Todo";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Año";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculateDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.tbMonth);
            this.Controls.Add(this.tbDay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDay;
        private System.Windows.Forms.TextBox tbMonth;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnCalculateDate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

