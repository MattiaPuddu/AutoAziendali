
namespace AutoAziendaliReforged.Forms
{
    partial class FormGetCar
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
            this.lbl_marca = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_targa = new System.Windows.Forms.Label();
            this.lbl_cilindrata = new System.Windows.Forms.Label();
            this.lbl_scadenzAssicurazione = new System.Windows.Forms.Label();
            this.dtp_scadenzAssicurazione = new System.Windows.Forms.DateTimePicker();
            this.tbx_marca = new System.Windows.Forms.TextBox();
            this.tbx_modello = new System.Windows.Forms.TextBox();
            this.tbx_targa = new System.Windows.Forms.TextBox();
            this.tbx_cilindrata = new System.Windows.Forms.TextBox();
            this.btn_inserisci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_marca
            // 
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.Location = new System.Drawing.Point(62, 16);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(37, 13);
            this.lbl_marca.TabIndex = 0;
            this.lbl_marca.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modello";
            // 
            // lbl_targa
            // 
            this.lbl_targa.AutoSize = true;
            this.lbl_targa.Location = new System.Drawing.Point(62, 88);
            this.lbl_targa.Name = "lbl_targa";
            this.lbl_targa.Size = new System.Drawing.Size(35, 13);
            this.lbl_targa.TabIndex = 2;
            this.lbl_targa.Text = "Targa";
            // 
            // lbl_cilindrata
            // 
            this.lbl_cilindrata.AutoSize = true;
            this.lbl_cilindrata.Location = new System.Drawing.Point(62, 124);
            this.lbl_cilindrata.Name = "lbl_cilindrata";
            this.lbl_cilindrata.Size = new System.Drawing.Size(50, 13);
            this.lbl_cilindrata.TabIndex = 3;
            this.lbl_cilindrata.Text = "Cilindrata";
            // 
            // lbl_scadenzAssicurazione
            // 
            this.lbl_scadenzAssicurazione.AutoSize = true;
            this.lbl_scadenzAssicurazione.Location = new System.Drawing.Point(13, 168);
            this.lbl_scadenzAssicurazione.Name = "lbl_scadenzAssicurazione";
            this.lbl_scadenzAssicurazione.Size = new System.Drawing.Size(123, 13);
            this.lbl_scadenzAssicurazione.TabIndex = 4;
            this.lbl_scadenzAssicurazione.Text = "Scadenza Assicurazione";
            // 
            // dtp_scadenzAssicurazione
            // 
            this.dtp_scadenzAssicurazione.Location = new System.Drawing.Point(159, 162);
            this.dtp_scadenzAssicurazione.Name = "dtp_scadenzAssicurazione";
            this.dtp_scadenzAssicurazione.Size = new System.Drawing.Size(115, 20);
            this.dtp_scadenzAssicurazione.TabIndex = 4;
            // 
            // tbx_marca
            // 
            this.tbx_marca.Location = new System.Drawing.Point(118, 13);
            this.tbx_marca.Name = "tbx_marca";
            this.tbx_marca.Size = new System.Drawing.Size(115, 20);
            this.tbx_marca.TabIndex = 0;
            // 
            // tbx_modello
            // 
            this.tbx_modello.Location = new System.Drawing.Point(118, 48);
            this.tbx_modello.Name = "tbx_modello";
            this.tbx_modello.Size = new System.Drawing.Size(115, 20);
            this.tbx_modello.TabIndex = 1;
            // 
            // tbx_targa
            // 
            this.tbx_targa.Location = new System.Drawing.Point(118, 85);
            this.tbx_targa.Name = "tbx_targa";
            this.tbx_targa.Size = new System.Drawing.Size(115, 20);
            this.tbx_targa.TabIndex = 2;
            // 
            // tbx_cilindrata
            // 
            this.tbx_cilindrata.Location = new System.Drawing.Point(118, 121);
            this.tbx_cilindrata.Name = "tbx_cilindrata";
            this.tbx_cilindrata.Size = new System.Drawing.Size(115, 20);
            this.tbx_cilindrata.TabIndex = 3;
            // 
            // btn_inserisci
            // 
            this.btn_inserisci.Location = new System.Drawing.Point(16, 205);
            this.btn_inserisci.Name = "btn_inserisci";
            this.btn_inserisci.Size = new System.Drawing.Size(249, 63);
            this.btn_inserisci.TabIndex = 5;
            this.btn_inserisci.Text = "Aggiungi";
            this.btn_inserisci.UseVisualStyleBackColor = true;
            this.btn_inserisci.Click += new System.EventHandler(this.btn_inserisci_Click);
            // 
            // FormGetCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 276);
            this.Controls.Add(this.btn_inserisci);
            this.Controls.Add(this.tbx_cilindrata);
            this.Controls.Add(this.tbx_targa);
            this.Controls.Add(this.tbx_modello);
            this.Controls.Add(this.tbx_marca);
            this.Controls.Add(this.dtp_scadenzAssicurazione);
            this.Controls.Add(this.lbl_scadenzAssicurazione);
            this.Controls.Add(this.lbl_cilindrata);
            this.Controls.Add(this.lbl_targa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_marca);
            this.Name = "FormGetCar";
            this.Text = "Aggiungi macchina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_marca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_targa;
        private System.Windows.Forms.Label lbl_cilindrata;
        private System.Windows.Forms.Label lbl_scadenzAssicurazione;
        private System.Windows.Forms.DateTimePicker dtp_scadenzAssicurazione;
        private System.Windows.Forms.TextBox tbx_marca;
        private System.Windows.Forms.TextBox tbx_modello;
        private System.Windows.Forms.TextBox tbx_targa;
        private System.Windows.Forms.TextBox tbx_cilindrata;
        private System.Windows.Forms.Button btn_inserisci;
    }
}