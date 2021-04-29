
namespace AutoAziendaliReforged
{
    partial class Form1
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
            this.dgv_autoAziendali = new System.Windows.Forms.DataGridView();
            this.btn_addCar = new System.Windows.Forms.Button();
            this.btn_giveCar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_autoAziendali)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_autoAziendali
            // 
            this.dgv_autoAziendali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_autoAziendali.Location = new System.Drawing.Point(8, 12);
            this.dgv_autoAziendali.Name = "dgv_autoAziendali";
            this.dgv_autoAziendali.Size = new System.Drawing.Size(780, 355);
            this.dgv_autoAziendali.TabIndex = 0;
            // 
            // btn_addCar
            // 
            this.btn_addCar.Location = new System.Drawing.Point(28, 381);
            this.btn_addCar.Name = "btn_addCar";
            this.btn_addCar.Size = new System.Drawing.Size(352, 57);
            this.btn_addCar.TabIndex = 1;
            this.btn_addCar.Text = "Aggiungi macchina";
            this.btn_addCar.UseVisualStyleBackColor = true;
            this.btn_addCar.Click += new System.EventHandler(this.btn_addCar_Click);
            // 
            // btn_giveCar
            // 
            this.btn_giveCar.Location = new System.Drawing.Point(410, 381);
            this.btn_giveCar.Name = "btn_giveCar";
            this.btn_giveCar.Size = new System.Drawing.Size(352, 57);
            this.btn_giveCar.TabIndex = 2;
            this.btn_giveCar.Text = "Dai macchina";
            this.btn_giveCar.UseVisualStyleBackColor = true;
            this.btn_giveCar.Click += new System.EventHandler(this.btn_giveCar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_giveCar);
            this.Controls.Add(this.btn_addCar);
            this.Controls.Add(this.dgv_autoAziendali);
            this.Name = "Form1";
            this.Text = "Auto aziendali";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_autoAziendali)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_autoAziendali;
        private System.Windows.Forms.Button btn_addCar;
        private System.Windows.Forms.Button btn_giveCar;
    }
}

