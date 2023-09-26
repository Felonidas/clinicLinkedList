
namespace ejercicio1TP4
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BtnAddPatient = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.BtnDelPatient = new System.Windows.Forms.Button();
            this.BtnEditPatient = new System.Windows.Forms.Button();
            this.BtnAddAfterSel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(12, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(524, 462);
            this.listBox1.TabIndex = 0;
            // 
            // BtnAddPatient
            // 
            this.BtnAddPatient.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnAddPatient.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnAddPatient.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddPatient.Location = new System.Drawing.Point(542, 9);
            this.BtnAddPatient.Name = "BtnAddPatient";
            this.BtnAddPatient.Size = new System.Drawing.Size(103, 52);
            this.BtnAddPatient.TabIndex = 1;
            this.BtnAddPatient.Text = "Registrar Paciente";
            this.BtnAddPatient.UseVisualStyleBackColor = false;
            this.BtnAddPatient.Click += new System.EventHandler(this.BtnAddPatient_Click);
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(12, 9);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 31);
            this.txtCode.TabIndex = 2;
            this.txtCode.Text = "Codigo";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(118, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 31);
            this.txtName.TabIndex = 3;
            this.txtName.Text = "Nombre";
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSurname.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(224, 9);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 31);
            this.txtSurname.TabIndex = 4;
            this.txtSurname.Text = "Apellido";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(330, 9);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 31);
            this.txtAddress.TabIndex = 5;
            this.txtAddress.Text = "Dirección";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(436, 9);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 31);
            this.txtPhone.TabIndex = 6;
            this.txtPhone.Text = "Teléfono";
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // BtnDelPatient
            // 
            this.BtnDelPatient.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnDelPatient.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnDelPatient.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelPatient.Location = new System.Drawing.Point(542, 67);
            this.BtnDelPatient.Name = "BtnDelPatient";
            this.BtnDelPatient.Size = new System.Drawing.Size(103, 65);
            this.BtnDelPatient.TabIndex = 7;
            this.BtnDelPatient.Text = "Eliminar Paciente Seleccionado";
            this.BtnDelPatient.UseVisualStyleBackColor = false;
            this.BtnDelPatient.Click += new System.EventHandler(this.BtnDelPatient_Click);
            // 
            // BtnEditPatient
            // 
            this.BtnEditPatient.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnEditPatient.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnEditPatient.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditPatient.Location = new System.Drawing.Point(542, 138);
            this.BtnEditPatient.Name = "BtnEditPatient";
            this.BtnEditPatient.Size = new System.Drawing.Size(103, 76);
            this.BtnEditPatient.TabIndex = 8;
            this.BtnEditPatient.Text = "Actualizar Info Paciente";
            this.BtnEditPatient.UseVisualStyleBackColor = false;
            this.BtnEditPatient.Click += new System.EventHandler(this.BtnEditPatient_Click);
            // 
            // BtnAddAfterSel
            // 
            this.BtnAddAfterSel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnAddAfterSel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnAddAfterSel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddAfterSel.Location = new System.Drawing.Point(542, 220);
            this.BtnAddAfterSel.Name = "BtnAddAfterSel";
            this.BtnAddAfterSel.Size = new System.Drawing.Size(103, 80);
            this.BtnAddAfterSel.TabIndex = 9;
            this.BtnAddAfterSel.Text = "Agregar despues del seleccionado";
            this.BtnAddAfterSel.UseVisualStyleBackColor = false;
            this.BtnAddAfterSel.Click += new System.EventHandler(this.BtnAddAfterSel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::ejercicio1TP4.Properties.Resources.modern_background;
            this.ClientSize = new System.Drawing.Size(648, 522);
            this.Controls.Add(this.BtnAddAfterSel);
            this.Controls.Add(this.BtnEditPatient);
            this.Controls.Add(this.BtnDelPatient);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.BtnAddPatient);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Clinica Pogoniana del Oeste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BtnAddPatient;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button BtnDelPatient;
        private System.Windows.Forms.Button BtnEditPatient;
        private System.Windows.Forms.Button BtnAddAfterSel;
    }
}

