﻿
namespace BaiGiuXeVer2.Forms.Login
{
    partial class frmLogin
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
            this.textUser = new Guna.UI.WinForms.GunaLineTextBox();
            this.textPassword = new Guna.UI.WinForms.GunaLineTextBox();
            this.CheckBox_HienThiMK = new Guna.UI.WinForms.GunaCheckBox();
            this.rdoStaff = new Guna.UI.WinForms.GunaRadioButton();
            this.rdoManager = new Guna.UI.WinForms.GunaRadioButton();
            this.iconLogin = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.buttonLogin = new Guna.UI.WinForms.GunaGradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // textUser
            // 
            this.textUser.BackColor = System.Drawing.Color.White;
            this.textUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textUser.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textUser.Font = new System.Drawing.Font("Yu Gothic UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUser.LineColor = System.Drawing.Color.Gainsboro;
            this.textUser.Location = new System.Drawing.Point(30, 200);
            this.textUser.Name = "textUser";
            this.textUser.PasswordChar = '\0';
            this.textUser.SelectedText = "";
            this.textUser.Size = new System.Drawing.Size(425, 37);
            this.textUser.TabIndex = 2;
            this.textUser.Text = "Username";
            this.textUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textPassword
            // 
            this.textPassword.BackColor = System.Drawing.Color.White;
            this.textPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPassword.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textPassword.Font = new System.Drawing.Font("Yu Gothic UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.LineColor = System.Drawing.Color.Gainsboro;
            this.textPassword.Location = new System.Drawing.Point(30, 260);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '\0';
            this.textPassword.SelectedText = "";
            this.textPassword.Size = new System.Drawing.Size(425, 37);
            this.textPassword.TabIndex = 3;
            this.textPassword.Text = "Password";
            this.textPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CheckBox_HienThiMK
            // 
            this.CheckBox_HienThiMK.BaseColor = System.Drawing.Color.White;
            this.CheckBox_HienThiMK.CheckedOffColor = System.Drawing.Color.Gray;
            this.CheckBox_HienThiMK.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CheckBox_HienThiMK.FillColor = System.Drawing.Color.White;
            this.CheckBox_HienThiMK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox_HienThiMK.Location = new System.Drawing.Point(30, 314);
            this.CheckBox_HienThiMK.Name = "CheckBox_HienThiMK";
            this.CheckBox_HienThiMK.Size = new System.Drawing.Size(150, 22);
            this.CheckBox_HienThiMK.TabIndex = 68;
            this.CheckBox_HienThiMK.Text = "Hiển thị mật khẩu";
            // 
            // rdoStaff
            // 
            this.rdoStaff.BaseColor = System.Drawing.SystemColors.Control;
            this.rdoStaff.CheckedOffColor = System.Drawing.Color.Gray;
            this.rdoStaff.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rdoStaff.FillColor = System.Drawing.Color.White;
            this.rdoStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdoStaff.Location = new System.Drawing.Point(87, 362);
            this.rdoStaff.Name = "rdoStaff";
            this.rdoStaff.Size = new System.Drawing.Size(81, 20);
            this.rdoStaff.TabIndex = 71;
            this.rdoStaff.Text = "Nhân viên";
            // 
            // rdoManager
            // 
            this.rdoManager.BaseColor = System.Drawing.SystemColors.Control;
            this.rdoManager.CheckedOffColor = System.Drawing.Color.Gray;
            this.rdoManager.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rdoManager.FillColor = System.Drawing.Color.White;
            this.rdoManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdoManager.Location = new System.Drawing.Point(299, 362);
            this.rdoManager.Name = "rdoManager";
            this.rdoManager.Size = new System.Drawing.Size(69, 20);
            this.rdoManager.TabIndex = 72;
            this.rdoManager.Text = "Quản lý";
            // 
            // iconLogin
            // 
            this.iconLogin.BackColor = System.Drawing.Color.Transparent;
            this.iconLogin.BaseColor = System.Drawing.Color.Black;
            this.iconLogin.Image = global::BaiGiuXeVer2.Properties.Resources.default_DDLK_avatar;
            this.iconLogin.Location = new System.Drawing.Point(177, 45);
            this.iconLogin.Name = "iconLogin";
            this.iconLogin.Size = new System.Drawing.Size(130, 130);
            this.iconLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconLogin.TabIndex = 0;
            this.iconLogin.TabStop = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.AnimationHoverSpeed = 0.07F;
            this.buttonLogin.AnimationSpeed = 0.03F;
            this.buttonLogin.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogin.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.buttonLogin.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.buttonLogin.BorderColor = System.Drawing.Color.Black;
            this.buttonLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonLogin.FocusedColor = System.Drawing.Color.Empty;
            this.buttonLogin.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Image = null;
            this.buttonLogin.ImageSize = new System.Drawing.Size(20, 20);
            this.buttonLogin.Location = new System.Drawing.Point(30, 423);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.buttonLogin.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.buttonLogin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.buttonLogin.OnHoverForeColor = System.Drawing.Color.White;
            this.buttonLogin.OnHoverImage = null;
            this.buttonLogin.OnPressedColor = System.Drawing.Color.Black;
            this.buttonLogin.Radius = 10;
            this.buttonLogin.Size = new System.Drawing.Size(425, 65);
            this.buttonLogin.TabIndex = 73;
            this.buttonLogin.Text = "Đăng nhập";
            this.buttonLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 511);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.rdoManager);
            this.Controls.Add(this.rdoStaff);
            this.Controls.Add(this.iconLogin);
            this.Controls.Add(this.CheckBox_HienThiMK);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUser);
            this.Name = "frmLogin";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.iconLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaTransfarantPictureBox iconLogin;
        private Guna.UI.WinForms.GunaLineTextBox textUser;
        private Guna.UI.WinForms.GunaLineTextBox textPassword;
        private Guna.UI.WinForms.GunaCheckBox CheckBox_HienThiMK;
        private Guna.UI.WinForms.GunaRadioButton rdoStaff;
        private Guna.UI.WinForms.GunaRadioButton rdoManager;
        private Guna.UI.WinForms.GunaGradientButton buttonLogin;
    }
}