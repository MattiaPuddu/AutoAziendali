
namespace AutoAziendaliReforged.Forms
{
    partial class FormGiveCar
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
            this.btn_giveCar = new System.Windows.Forms.Button();
            this.lbl_autoDisponibili = new System.Windows.Forms.Label();
            this.lbl_dipendenti = new System.Windows.Forms.Label();
            this.cmbx_autoDisponibili = new System.Windows.Forms.ComboBox();
            this.cmbx_dipendenti = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_giveCar
            // 
            this.btn_giveCar.Location = new System.Drawing.Point(291, 24);
            this.btn_giveCar.Name = "btn_giveCar";
            this.btn_giveCar.Size = new System.Drawing.Size(112, 33);
            this.btn_giveCar.TabIndex = 2;
            this.btn_giveCar.Text = "Dai macchina";
            this.btn_giveCar.UseVisualStyleBackColor = true;
            this.btn_giveCar.Click += new System.EventHandler(this.btn_giveCar_Click);
            // 
            // lbl_autoDisponibili
            // 
            this.lbl_autoDisponibili.AutoSize = true;
            this.lbl_autoDisponibili.Location = new System.Drawing.Point(31, 9);
            this.lbl_autoDisponibili.Name = "lbl_autoDisponibili";
            this.lbl_autoDisponibili.Size = new System.Drawing.Size(77, 13);
            this.lbl_autoDisponibili.TabIndex = 3;
            this.lbl_autoDisponibili.Text = "Auto disponibili";
            // 
            // lbl_dipendenti
            // 
            this.lbl_dipendenti.AutoSize = true;
            this.lbl_dipendenti.Location = new System.Drawing.Point(187, 9);
            this.lbl_dipendenti.Name = "lbl_dipendenti";
            this.lbl_dipendenti.Size = new System.Drawing.Size(58, 13);
            this.lbl_dipendenti.TabIndex = 4;
            this.lbl_dipendenti.Text = "Dipendenti";
            // 
            // cmbx_autoDisponibili
            // 
            this.cmbx_autoDisponibili.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_autoDisponibili.FormattingEnabled = true;
            this.cmbx_autoDisponibili.Location = new System.Drawing.Point(12, 31);
            this.cmbx_autoDisponibili.Name = "cmbx_autoDisponibili";
            this.cmbx_autoDisponibili.Size = new System.Drawing.Size(121, 21);
            this.cmbx_autoDisponibili.TabIndex = 0;
            // 
            // cmbx_dipendenti
            // 
            this.cmbx_dipendenti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_dipendenti.FormattingEnabled = true;
            this.cmbx_dipendenti.Location = new System.Drawing.Point(155, 31);
            this.cmbx_dipendenti.Name = "cmbx_dipendenti";
            this.cmbx_dipendenti.Size = new System.Drawing.Size(121, 21);
            this.cmbx_dipendenti.TabIndex = 1;
            // 
            // FormGiveCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 66);
            this.Controls.Add(this.cmbx_dipendenti);
            this.Controls.Add(this.cmbx_autoDisponibili);
            this.Controls.Add(this.lbl_dipendenti);
            this.Controls.Add(this.lbl_autoDisponibili);
            this.Controls.Add(this.btn_giveCar);
            this.Name = "FormGiveCar";
            this.Text = "FormGiveCar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_giveCar;
        private System.Windows.Forms.Label lbl_autoDisponibili;
        private System.Windows.Forms.Label lbl_dipendenti;
        private System.Windows.Forms.ComboBox cmbx_autoDisponibili;
        private System.Windows.Forms.ComboBox cmbx_dipendenti;
    }
}