﻿namespace ProyectoTecnicasProgramacion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupSensors = new System.Windows.Forms.GroupBox();
            this.btnS7 = new System.Windows.Forms.Button();
            this.btnS6 = new System.Windows.Forms.Button();
            this.btnS5 = new System.Windows.Forms.Button();
            this.btnS4 = new System.Windows.Forms.Button();
            this.btnS3 = new System.Windows.Forms.Button();
            this.btnS2 = new System.Windows.Forms.Button();
            this.btnS1 = new System.Windows.Forms.Button();
            this.groupConnection = new System.Windows.Forms.GroupBox();
            this.cboCom = new System.Windows.Forms.ComboBox();
            this.btnConnection = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNode = new System.Windows.Forms.TextBox();
            this.labNode = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtMotors = new System.Windows.Forms.TextBox();
            this.labMotors = new System.Windows.Forms.Label();
            this.labIn = new System.Windows.Forms.Label();
            this.txtIn = new System.Windows.Forms.TextBox();
            this.port = new System.IO.Ports.SerialPort(this.components);
            this.groupAlgorithum = new System.Windows.Forms.GroupBox();
            this.radioLeft = new System.Windows.Forms.RadioButton();
            this.radioRight = new System.Windows.Forms.RadioButton();
            this.groupSensors.SuspendLayout();
            this.groupConnection.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupAlgorithum.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupSensors
            // 
            this.groupSensors.Controls.Add(this.btnS7);
            this.groupSensors.Controls.Add(this.btnS6);
            this.groupSensors.Controls.Add(this.btnS5);
            this.groupSensors.Controls.Add(this.btnS4);
            this.groupSensors.Controls.Add(this.btnS3);
            this.groupSensors.Controls.Add(this.btnS2);
            this.groupSensors.Controls.Add(this.btnS1);
            this.groupSensors.Location = new System.Drawing.Point(254, 12);
            this.groupSensors.Name = "groupSensors";
            this.groupSensors.Size = new System.Drawing.Size(200, 222);
            this.groupSensors.TabIndex = 0;
            this.groupSensors.TabStop = false;
            this.groupSensors.Text = "Monitor de Sensores";
            // 
            // btnS7
            // 
            this.btnS7.Location = new System.Drawing.Point(77, 166);
            this.btnS7.Name = "btnS7";
            this.btnS7.Size = new System.Drawing.Size(47, 41);
            this.btnS7.TabIndex = 4;
            this.btnS7.Text = "S7";
            this.btnS7.UseVisualStyleBackColor = true;
            // 
            // btnS6
            // 
            this.btnS6.Location = new System.Drawing.Point(130, 121);
            this.btnS6.Name = "btnS6";
            this.btnS6.Size = new System.Drawing.Size(47, 41);
            this.btnS6.TabIndex = 6;
            this.btnS6.Text = "S6";
            this.btnS6.UseVisualStyleBackColor = true;
            // 
            // btnS5
            // 
            this.btnS5.Location = new System.Drawing.Point(24, 121);
            this.btnS5.Name = "btnS5";
            this.btnS5.Size = new System.Drawing.Size(47, 41);
            this.btnS5.TabIndex = 4;
            this.btnS5.Text = "S5";
            this.btnS5.UseVisualStyleBackColor = true;
            // 
            // btnS4
            // 
            this.btnS4.Location = new System.Drawing.Point(77, 79);
            this.btnS4.Name = "btnS4";
            this.btnS4.Size = new System.Drawing.Size(47, 41);
            this.btnS4.TabIndex = 5;
            this.btnS4.Text = "S4";
            this.btnS4.UseVisualStyleBackColor = true;
            // 
            // btnS3
            // 
            this.btnS3.Location = new System.Drawing.Point(130, 32);
            this.btnS3.Name = "btnS3";
            this.btnS3.Size = new System.Drawing.Size(47, 41);
            this.btnS3.TabIndex = 4;
            this.btnS3.Text = "S3";
            this.btnS3.UseVisualStyleBackColor = true;
            // 
            // btnS2
            // 
            this.btnS2.Location = new System.Drawing.Point(77, 32);
            this.btnS2.Name = "btnS2";
            this.btnS2.Size = new System.Drawing.Size(47, 41);
            this.btnS2.TabIndex = 1;
            this.btnS2.Text = "S2";
            this.btnS2.UseVisualStyleBackColor = true;
            // 
            // btnS1
            // 
            this.btnS1.Location = new System.Drawing.Point(24, 32);
            this.btnS1.Name = "btnS1";
            this.btnS1.Size = new System.Drawing.Size(47, 41);
            this.btnS1.TabIndex = 0;
            this.btnS1.Text = "S1";
            this.btnS1.UseVisualStyleBackColor = true;
            // 
            // groupConnection
            // 
            this.groupConnection.Controls.Add(this.cboCom);
            this.groupConnection.Controls.Add(this.btnConnection);
            this.groupConnection.Location = new System.Drawing.Point(13, 12);
            this.groupConnection.Name = "groupConnection";
            this.groupConnection.Size = new System.Drawing.Size(200, 100);
            this.groupConnection.TabIndex = 1;
            this.groupConnection.TabStop = false;
            this.groupConnection.Text = "Conexión";
            // 
            // cboCom
            // 
            this.cboCom.FormattingEnabled = true;
            this.cboCom.Location = new System.Drawing.Point(7, 71);
            this.cboCom.Name = "cboCom";
            this.cboCom.Size = new System.Drawing.Size(187, 24);
            this.cboCom.TabIndex = 1;
            // 
            // btnConnection
            // 
            this.btnConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnection.Location = new System.Drawing.Point(7, 21);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(187, 43);
            this.btnConnection.TabIndex = 0;
            this.btnConnection.Text = "Conectar";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(254, 425);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(193, 42);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Buscar";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNode);
            this.groupBox3.Controls.Add(this.labNode);
            this.groupBox3.Controls.Add(this.btnStop);
            this.groupBox3.Controls.Add(this.txtMotors);
            this.groupBox3.Controls.Add(this.labMotors);
            this.groupBox3.Controls.Add(this.labIn);
            this.groupBox3.Controls.Add(this.txtIn);
            this.groupBox3.Location = new System.Drawing.Point(13, 249);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(441, 170);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "IO";
            // 
            // txtNode
            // 
            this.txtNode.Location = new System.Drawing.Point(6, 136);
            this.txtNode.Name = "txtNode";
            this.txtNode.Size = new System.Drawing.Size(306, 22);
            this.txtNode.TabIndex = 6;
            // 
            // labNode
            // 
            this.labNode.AutoSize = true;
            this.labNode.Location = new System.Drawing.Point(6, 115);
            this.labNode.Name = "labNode";
            this.labNode.Size = new System.Drawing.Size(42, 17);
            this.labNode.TabIndex = 5;
            this.labNode.Text = "Nodo";
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.Control;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.Black;
            this.btnStop.Location = new System.Drawing.Point(325, 122);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(109, 36);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Enviar";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtMotors
            // 
            this.txtMotors.Location = new System.Drawing.Point(7, 88);
            this.txtMotors.Name = "txtMotors";
            this.txtMotors.Size = new System.Drawing.Size(427, 22);
            this.txtMotors.TabIndex = 3;
            // 
            // labMotors
            // 
            this.labMotors.AutoSize = true;
            this.labMotors.Location = new System.Drawing.Point(7, 67);
            this.labMotors.Name = "labMotors";
            this.labMotors.Size = new System.Drawing.Size(47, 17);
            this.labMotors.TabIndex = 2;
            this.labMotors.Text = "Salida";
            // 
            // labIn
            // 
            this.labIn.AutoSize = true;
            this.labIn.Location = new System.Drawing.Point(7, 22);
            this.labIn.Name = "labIn";
            this.labIn.Size = new System.Drawing.Size(53, 17);
            this.labIn.TabIndex = 1;
            this.labIn.Text = "Entada";
            // 
            // txtIn
            // 
            this.txtIn.Location = new System.Drawing.Point(6, 42);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(428, 22);
            this.txtIn.TabIndex = 0;
            // 
            // port
            // 
            this.port.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Received);
            // 
            // groupAlgorithum
            // 
            this.groupAlgorithum.Controls.Add(this.radioLeft);
            this.groupAlgorithum.Controls.Add(this.radioRight);
            this.groupAlgorithum.Location = new System.Drawing.Point(13, 133);
            this.groupAlgorithum.Name = "groupAlgorithum";
            this.groupAlgorithum.Size = new System.Drawing.Size(200, 100);
            this.groupAlgorithum.TabIndex = 4;
            this.groupAlgorithum.TabStop = false;
            this.groupAlgorithum.Text = "Tipo de Algoritmo";
            // 
            // radioLeft
            // 
            this.radioLeft.AutoSize = true;
            this.radioLeft.Location = new System.Drawing.Point(10, 49);
            this.radioLeft.Name = "radioLeft";
            this.radioLeft.Size = new System.Drawing.Size(84, 21);
            this.radioLeft.TabIndex = 1;
            this.radioLeft.Text = "Izquierda";
            this.radioLeft.UseVisualStyleBackColor = true;
            // 
            // radioRight
            // 
            this.radioRight.AutoSize = true;
            this.radioRight.Checked = true;
            this.radioRight.Location = new System.Drawing.Point(10, 22);
            this.radioRight.Name = "radioRight";
            this.radioRight.Size = new System.Drawing.Size(80, 21);
            this.radioRight.TabIndex = 0;
            this.radioRight.TabStop = true;
            this.radioRight.Text = "Derecha";
            this.radioRight.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 482);
            this.Controls.Add(this.groupAlgorithum);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.groupConnection);
            this.Controls.Add(this.groupSensors);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Robot Dibuja Trayectoria";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupSensors.ResumeLayout(false);
            this.groupConnection.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupAlgorithum.ResumeLayout(false);
            this.groupAlgorithum.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupSensors;
        private System.Windows.Forms.GroupBox groupConnection;
        private System.Windows.Forms.ComboBox cboCom;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMotors;
        private System.Windows.Forms.Label labMotors;
        private System.Windows.Forms.Label labIn;
        private System.Windows.Forms.TextBox txtIn;
        private System.IO.Ports.SerialPort port;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnS6;
        private System.Windows.Forms.Button btnS5;
        private System.Windows.Forms.Button btnS4;
        private System.Windows.Forms.Button btnS3;
        private System.Windows.Forms.Button btnS2;
        private System.Windows.Forms.Button btnS1;
        private System.Windows.Forms.Button btnS7;
        private System.Windows.Forms.TextBox txtNode;
        private System.Windows.Forms.Label labNode;
        private System.Windows.Forms.GroupBox groupAlgorithum;
        private System.Windows.Forms.RadioButton radioLeft;
        private System.Windows.Forms.RadioButton radioRight;
    }
}
