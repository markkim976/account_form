
namespace account_form
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name_box = new System.Windows.Forms.TextBox();
            this.pw_box = new System.Windows.Forms.TextBox();
            this.join_btn = new System.Windows.Forms.Button();
            this.go_login_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pw2_box = new System.Windows.Forms.TextBox();
            this.pw_chk = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("궁서", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(54, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("궁서", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(54, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "UserName";
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(122, 126);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(143, 21);
            this.name_box.TabIndex = 3;
            // 
            // pw_box
            // 
            this.pw_box.Location = new System.Drawing.Point(122, 161);
            this.pw_box.Name = "pw_box";
            this.pw_box.PasswordChar = '●';
            this.pw_box.Size = new System.Drawing.Size(143, 21);
            this.pw_box.TabIndex = 4;
            // 
            // join_btn
            // 
            this.join_btn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.join_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.join_btn.Location = new System.Drawing.Point(122, 257);
            this.join_btn.Name = "join_btn";
            this.join_btn.Size = new System.Drawing.Size(67, 23);
            this.join_btn.TabIndex = 6;
            this.join_btn.Text = "회원가입";
            this.join_btn.UseVisualStyleBackColor = false;
            this.join_btn.Click += new System.EventHandler(this.join_btn_Click);
            // 
            // go_login_label
            // 
            this.go_login_label.AutoSize = true;
            this.go_login_label.Location = new System.Drawing.Point(111, 297);
            this.go_login_label.Name = "go_login_label";
            this.go_login_label.Size = new System.Drawing.Size(93, 12);
            this.go_login_label.TabIndex = 7;
            this.go_login_label.Text = "로그인하러 가기";
            this.go_login_label.Click += new System.EventHandler(this.go_login_label_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(113, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("궁서", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(12, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password 재확인";
            // 
            // pw2_box
            // 
            this.pw2_box.Location = new System.Drawing.Point(122, 200);
            this.pw2_box.Name = "pw2_box";
            this.pw2_box.PasswordChar = '●';
            this.pw2_box.Size = new System.Drawing.Size(143, 21);
            this.pw2_box.TabIndex = 10;
            // 
            // pw_chk
            // 
            this.pw_chk.AutoSize = true;
            this.pw_chk.Location = new System.Drawing.Point(179, 227);
            this.pw_chk.Name = "pw_chk";
            this.pw_chk.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pw_chk.Size = new System.Drawing.Size(117, 16);
            this.pw_chk.TabIndex = 11;
            this.pw_chk.Text = "Show Password";
            this.pw_chk.UseVisualStyleBackColor = true;
            this.pw_chk.CheckedChanged += new System.EventHandler(this.pw_chk_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(326, 332);
            this.Controls.Add(this.pw_chk);
            this.Controls.Add(this.pw2_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.go_login_label);
            this.Controls.Add(this.join_btn);
            this.Controls.Add(this.pw_box);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "회원가입";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.TextBox pw_box;
        private System.Windows.Forms.Button join_btn;
        private System.Windows.Forms.Label go_login_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pw2_box;
        private System.Windows.Forms.CheckBox pw_chk;
    }
}