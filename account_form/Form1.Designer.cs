
namespace account_form
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name_box = new System.Windows.Forms.TextBox();
            this.pw_box = new System.Windows.Forms.TextBox();
            this.remember_chk = new System.Windows.Forms.CheckBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.join_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cancel_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("궁서", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(33, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("궁서", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(33, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(112, 154);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(143, 21);
            this.name_box.TabIndex = 3;
            // 
            // pw_box
            // 
            this.pw_box.Location = new System.Drawing.Point(112, 197);
            this.pw_box.Name = "pw_box";
            this.pw_box.PasswordChar = '●';
            this.pw_box.Size = new System.Drawing.Size(143, 21);
            this.pw_box.TabIndex = 4;
            // 
            // remember_chk
            // 
            this.remember_chk.AutoSize = true;
            this.remember_chk.ForeColor = System.Drawing.Color.Navy;
            this.remember_chk.Location = new System.Drawing.Point(112, 235);
            this.remember_chk.Name = "remember_chk";
            this.remember_chk.Size = new System.Drawing.Size(143, 16);
            this.remember_chk.TabIndex = 8;
            this.remember_chk.Text = "Remember My Login";
            this.remember_chk.UseVisualStyleBackColor = true;
            this.remember_chk.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(180, 282);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(75, 23);
            this.login_btn.TabIndex = 9;
            this.login_btn.Text = "로그인";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // join_btn
            // 
            this.join_btn.Location = new System.Drawing.Point(95, 282);
            this.join_btn.Name = "join_btn";
            this.join_btn.Size = new System.Drawing.Size(75, 23);
            this.join_btn.TabIndex = 10;
            this.join_btn.Text = "회원가입";
            this.join_btn.UseVisualStyleBackColor = true;
            this.join_btn.Click += new System.EventHandler(this.join_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(112, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.Red;
            this.cancel_btn.ForeColor = System.Drawing.Color.Snow;
            this.cancel_btn.Location = new System.Drawing.Point(290, 12);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(24, 24);
            this.cancel_btn.TabIndex = 12;
            this.cancel_btn.Text = "X";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(326, 335);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.join_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.remember_chk);
            this.Controls.Add(this.pw_box);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "로그인";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.TextBox pw_box;
        private System.Windows.Forms.CheckBox remember_chk;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button join_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cancel_btn;
    }
}

