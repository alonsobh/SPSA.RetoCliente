namespace SPSA.RetoCliente.Forms
{
    partial class frmCliente
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
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtLastNames = new System.Windows.Forms.TextBox();
            this.txtNames = new System.Windows.Forms.TextBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStandardDesviationValue = new System.Windows.Forms.Label();
            this.lblAverageValue = new System.Windows.Forms.Label();
            this.lblStandardDesviation = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudEdadMuerte = new System.Windows.Forms.NumericUpDown();
            this.btnRefrescar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdadMuerte)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClients
            // 
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClients.Location = new System.Drawing.Point(0, 122);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.Size = new System.Drawing.Size(803, 328);
            this.dgvClients.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefrescar);
            this.panel1.Controls.Add(this.nudEdadMuerte);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpBirthDate);
            this.panel1.Controls.Add(this.txtLastNames);
            this.panel1.Controls.Add(this.txtNames);
            this.panel1.Controls.Add(this.lblBirthDate);
            this.panel1.Controls.Add(this.lblLastName);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 122);
            this.panel1.TabIndex = 1;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(122, 86);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(100, 20);
            this.dtpBirthDate.TabIndex = 7;
            // 
            // txtLastNames
            // 
            this.txtLastNames.Location = new System.Drawing.Point(122, 50);
            this.txtLastNames.Name = "txtLastNames";
            this.txtLastNames.Size = new System.Drawing.Size(240, 20);
            this.txtLastNames.TabIndex = 6;
            // 
            // txtNames
            // 
            this.txtNames.Location = new System.Drawing.Point(122, 13);
            this.txtNames.Name = "txtNames";
            this.txtNames.Size = new System.Drawing.Size(240, 20);
            this.txtNames.TabIndex = 5;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(13, 86);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(93, 13);
            this.lblBirthDate.TabIndex = 4;
            this.lblBirthDate.Text = "Fecha Nacimiento";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(12, 46);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(52, 13);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Apellidos:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nombres:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblStandardDesviationValue);
            this.panel2.Controls.Add(this.lblAverageValue);
            this.panel2.Controls.Add(this.lblStandardDesviation);
            this.panel2.Controls.Add(this.lblAverage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(498, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 122);
            this.panel2.TabIndex = 1;
            // 
            // lblStandardDesviationValue
            // 
            this.lblStandardDesviationValue.AutoSize = true;
            this.lblStandardDesviationValue.Location = new System.Drawing.Point(133, 57);
            this.lblStandardDesviationValue.Name = "lblStandardDesviationValue";
            this.lblStandardDesviationValue.Size = new System.Drawing.Size(0, 13);
            this.lblStandardDesviationValue.TabIndex = 3;
            // 
            // lblAverageValue
            // 
            this.lblAverageValue.AutoSize = true;
            this.lblAverageValue.Location = new System.Drawing.Point(133, 13);
            this.lblAverageValue.Name = "lblAverageValue";
            this.lblAverageValue.Size = new System.Drawing.Size(0, 13);
            this.lblAverageValue.TabIndex = 2;
            // 
            // lblStandardDesviation
            // 
            this.lblStandardDesviation.AutoSize = true;
            this.lblStandardDesviation.Location = new System.Drawing.Point(16, 57);
            this.lblStandardDesviation.Name = "lblStandardDesviation";
            this.lblStandardDesviation.Size = new System.Drawing.Size(108, 13);
            this.lblStandardDesviation.TabIndex = 1;
            this.lblStandardDesviation.Text = "Desviacion Estandar:";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(16, 13);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(93, 13);
            this.lblAverage.TabIndex = 0;
            this.lblAverage.Text = "Promedio Edades:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(379, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Agregar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Edad Probable de Muerte";
            // 
            // nudEdadMuerte
            // 
            this.nudEdadMuerte.Location = new System.Drawing.Point(415, 92);
            this.nudEdadMuerte.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudEdadMuerte.Name = "nudEdadMuerte";
            this.nudEdadMuerte.Size = new System.Drawing.Size(51, 20);
            this.nudEdadMuerte.TabIndex = 9;
            this.nudEdadMuerte.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(379, 46);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(75, 23);
            this.btnRefrescar.TabIndex = 10;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.dgvClients);
            this.Controls.Add(this.panel1);
            this.Name = "frmCliente";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdadMuerte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblStandardDesviation;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.TextBox txtLastNames;
        private System.Windows.Forms.TextBox txtNames;
        private System.Windows.Forms.Label lblStandardDesviationValue;
        private System.Windows.Forms.Label lblAverageValue;
        private System.Windows.Forms.NumericUpDown nudEdadMuerte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefrescar;
    }
}

