
namespace Bike_Rental_System
{
    partial class benefeciaries
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cleartext = new System.Windows.Forms.Button();
            this.dgvbenefeciaries = new System.Windows.Forms.DataGridView();
            this.refreshbut = new System.Windows.Forms.Button();
            this.deletebut = new System.Windows.Forms.Button();
            this.editbut = new System.Windows.Forms.Button();
            this.addbut = new System.Windows.Forms.Button();
            this.address = new System.Windows.Forms.TextBox();
            this.phone_No = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.middle_name = new System.Windows.Forms.TextBox();
            this.first_name = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.beneficiary_No = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exitbut = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbenefeciaries)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.cleartext);
            this.panel1.Controls.Add(this.dgvbenefeciaries);
            this.panel1.Controls.Add(this.refreshbut);
            this.panel1.Controls.Add(this.deletebut);
            this.panel1.Controls.Add(this.editbut);
            this.panel1.Controls.Add(this.addbut);
            this.panel1.Controls.Add(this.address);
            this.panel1.Controls.Add(this.phone_No);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.middle_name);
            this.panel1.Controls.Add(this.first_name);
            this.panel1.Controls.Add(this.surname);
            this.panel1.Controls.Add(this.beneficiary_No);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 406);
            this.panel1.TabIndex = 1;
            // 
            // cleartext
            // 
            this.cleartext.BackColor = System.Drawing.SystemColors.Info;
            this.cleartext.Font = new System.Drawing.Font("p5hatty", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cleartext.Location = new System.Drawing.Point(167, 9);
            this.cleartext.Name = "cleartext";
            this.cleartext.Size = new System.Drawing.Size(136, 32);
            this.cleartext.TabIndex = 25;
            this.cleartext.Text = "CLEAR TEXTBOX";
            this.cleartext.UseVisualStyleBackColor = false;
            this.cleartext.Click += new System.EventHandler(this.cleartext_Click);
            // 
            // dgvbenefeciaries
            // 
            this.dgvbenefeciaries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbenefeciaries.Location = new System.Drawing.Point(341, 41);
            this.dgvbenefeciaries.Name = "dgvbenefeciaries";
            this.dgvbenefeciaries.Size = new System.Drawing.Size(762, 344);
            this.dgvbenefeciaries.TabIndex = 24;
            this.dgvbenefeciaries.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbenefeciaries_CellContentClick);
            // 
            // refreshbut
            // 
            this.refreshbut.BackColor = System.Drawing.SystemColors.Info;
            this.refreshbut.Font = new System.Drawing.Font("p5hatty", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshbut.Location = new System.Drawing.Point(953, 3);
            this.refreshbut.Name = "refreshbut";
            this.refreshbut.Size = new System.Drawing.Size(150, 32);
            this.refreshbut.TabIndex = 23;
            this.refreshbut.Text = "REFRESH TABLE";
            this.refreshbut.UseVisualStyleBackColor = false;
            this.refreshbut.Click += new System.EventHandler(this.refreshbut_Click);
            // 
            // deletebut
            // 
            this.deletebut.BackColor = System.Drawing.SystemColors.Info;
            this.deletebut.Font = new System.Drawing.Font("p5hatty", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebut.Location = new System.Drawing.Point(230, 353);
            this.deletebut.Name = "deletebut";
            this.deletebut.Size = new System.Drawing.Size(82, 32);
            this.deletebut.TabIndex = 21;
            this.deletebut.Text = "DELETE";
            this.deletebut.UseVisualStyleBackColor = false;
            this.deletebut.Click += new System.EventHandler(this.deletebut_Click);
            // 
            // editbut
            // 
            this.editbut.BackColor = System.Drawing.SystemColors.Info;
            this.editbut.Font = new System.Drawing.Font("p5hatty", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbut.Location = new System.Drawing.Point(128, 353);
            this.editbut.Name = "editbut";
            this.editbut.Size = new System.Drawing.Size(83, 32);
            this.editbut.TabIndex = 20;
            this.editbut.Text = "UPDATE";
            this.editbut.UseVisualStyleBackColor = false;
            this.editbut.Click += new System.EventHandler(this.editbut_Click);
            // 
            // addbut
            // 
            this.addbut.BackColor = System.Drawing.SystemColors.Info;
            this.addbut.Font = new System.Drawing.Font("p5hatty", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbut.Location = new System.Drawing.Point(26, 353);
            this.addbut.Name = "addbut";
            this.addbut.Size = new System.Drawing.Size(82, 32);
            this.addbut.TabIndex = 19;
            this.addbut.Text = "ADD";
            this.addbut.UseVisualStyleBackColor = false;
            this.addbut.Click += new System.EventHandler(this.addbut_Click);
            // 
            // address
            // 
            this.address.BackColor = System.Drawing.SystemColors.Info;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(157, 271);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(155, 26);
            this.address.TabIndex = 17;
            // 
            // phone_No
            // 
            this.phone_No.BackColor = System.Drawing.SystemColors.Info;
            this.phone_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_No.Location = new System.Drawing.Point(157, 228);
            this.phone_No.Name = "phone_No";
            this.phone_No.Size = new System.Drawing.Size(155, 26);
            this.phone_No.TabIndex = 16;
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.SystemColors.Info;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(157, 191);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(155, 26);
            this.email.TabIndex = 15;
            // 
            // middle_name
            // 
            this.middle_name.BackColor = System.Drawing.SystemColors.Info;
            this.middle_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middle_name.Location = new System.Drawing.Point(157, 156);
            this.middle_name.Name = "middle_name";
            this.middle_name.Size = new System.Drawing.Size(155, 26);
            this.middle_name.TabIndex = 14;
            // 
            // first_name
            // 
            this.first_name.BackColor = System.Drawing.SystemColors.Info;
            this.first_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_name.Location = new System.Drawing.Point(157, 118);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(155, 26);
            this.first_name.TabIndex = 13;
            // 
            // surname
            // 
            this.surname.BackColor = System.Drawing.SystemColors.Info;
            this.surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surname.Location = new System.Drawing.Point(157, 83);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(155, 26);
            this.surname.TabIndex = 12;
            // 
            // beneficiary_No
            // 
            this.beneficiary_No.BackColor = System.Drawing.SystemColors.Info;
            this.beneficiary_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beneficiary_No.Location = new System.Drawing.Point(157, 47);
            this.beneficiary_No.Name = "beneficiary_No";
            this.beneficiary_No.Size = new System.Drawing.Size(155, 26);
            this.beneficiary_No.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("p5hatty", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("p5hatty", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Phone #:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("p5hatty", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("p5hatty", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Middle name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("p5hatty", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "First name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("p5hatty", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("p5hatty", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Benefeciary #:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("p5hatty", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "MANAGE BENEFECIARIES";
            // 
            // exitbut
            // 
            this.exitbut.Font = new System.Drawing.Font("p5hatty", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbut.Location = new System.Drawing.Point(1096, 12);
            this.exitbut.Name = "exitbut";
            this.exitbut.Size = new System.Drawing.Size(31, 26);
            this.exitbut.TabIndex = 25;
            this.exitbut.Text = "X";
            this.exitbut.UseVisualStyleBackColor = true;
            this.exitbut.Click += new System.EventHandler(this.exitbut_Click);
            // 
            // benefeciaries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1139, 505);
            this.Controls.Add(this.exitbut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "benefeciaries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "benefeciaries";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbenefeciaries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button refreshbut;
        private System.Windows.Forms.Button deletebut;
        private System.Windows.Forms.Button editbut;
        private System.Windows.Forms.Button addbut;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox phone_No;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox middle_name;
        private System.Windows.Forms.TextBox first_name;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.TextBox beneficiary_No;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvbenefeciaries;
        private System.Windows.Forms.Button exitbut;
        private System.Windows.Forms.Button cleartext;
    }
}