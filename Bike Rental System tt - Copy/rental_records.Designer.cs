
namespace Bike_Rental_System
{
    partial class rental_records
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
            this.exitbut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.showstaffs = new System.Windows.Forms.Button();
            this.showbikes = new System.Windows.Forms.Button();
            this.showbeneficiary = new System.Windows.Forms.Button();
            this.inactivebut = new System.Windows.Forms.Button();
            this.active_but = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.validity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.receiver_staff_No = new System.Windows.Forms.TextBox();
            this.lender_staff_No = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cleartext = new System.Windows.Forms.Button();
            this.dgvrentalrec = new System.Windows.Forms.DataGridView();
            this.refreshbut = new System.Windows.Forms.Button();
            this.deletebut = new System.Windows.Forms.Button();
            this.editbut = new System.Windows.Forms.Button();
            this.addbut = new System.Windows.Forms.Button();
            this.cond_after = new System.Windows.Forms.TextBox();
            this.cond_before = new System.Windows.Forms.TextBox();
            this.return_date = new System.Windows.Forms.TextBox();
            this.rental_date = new System.Windows.Forms.TextBox();
            this.beneficiary_No = new System.Windows.Forms.TextBox();
            this.bike_No = new System.Windows.Forms.TextBox();
            this.rental_rec_No = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrentalrec)).BeginInit();
            this.SuspendLayout();
            // 
            // exitbut
            // 
            this.exitbut.Font = new System.Drawing.Font("p5hatty", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbut.Location = new System.Drawing.Point(1096, 12);
            this.exitbut.Name = "exitbut";
            this.exitbut.Size = new System.Drawing.Size(31, 26);
            this.exitbut.TabIndex = 26;
            this.exitbut.Text = "X";
            this.exitbut.UseVisualStyleBackColor = true;
            this.exitbut.Click += new System.EventHandler(this.exitbut_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.showstaffs);
            this.panel1.Controls.Add(this.showbikes);
            this.panel1.Controls.Add(this.showbeneficiary);
            this.panel1.Controls.Add(this.inactivebut);
            this.panel1.Controls.Add(this.active_but);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.validity);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.receiver_staff_No);
            this.panel1.Controls.Add(this.lender_staff_No);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cleartext);
            this.panel1.Controls.Add(this.dgvrentalrec);
            this.panel1.Controls.Add(this.refreshbut);
            this.panel1.Controls.Add(this.deletebut);
            this.panel1.Controls.Add(this.editbut);
            this.panel1.Controls.Add(this.addbut);
            this.panel1.Controls.Add(this.cond_after);
            this.panel1.Controls.Add(this.cond_before);
            this.panel1.Controls.Add(this.return_date);
            this.panel1.Controls.Add(this.rental_date);
            this.panel1.Controls.Add(this.beneficiary_No);
            this.panel1.Controls.Add(this.bike_No);
            this.panel1.Controls.Add(this.rental_rec_No);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-1, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 406);
            this.panel1.TabIndex = 27;
            // 
            // showstaffs
            // 
            this.showstaffs.BackColor = System.Drawing.SystemColors.Info;
            this.showstaffs.Font = new System.Drawing.Font("p5hatty", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showstaffs.Location = new System.Drawing.Point(611, 3);
            this.showstaffs.Name = "showstaffs";
            this.showstaffs.Size = new System.Drawing.Size(150, 32);
            this.showstaffs.TabIndex = 40;
            this.showstaffs.Text = "STAFFS";
            this.showstaffs.UseVisualStyleBackColor = false;
            this.showstaffs.Click += new System.EventHandler(this.showstaffs_Click);
            // 
            // showbikes
            // 
            this.showbikes.BackColor = System.Drawing.SystemColors.Info;
            this.showbikes.Font = new System.Drawing.Font("p5hatty", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showbikes.Location = new System.Drawing.Point(497, 3);
            this.showbikes.Name = "showbikes";
            this.showbikes.Size = new System.Drawing.Size(108, 32);
            this.showbikes.TabIndex = 39;
            this.showbikes.Text = "BIKES";
            this.showbikes.UseVisualStyleBackColor = false;
            this.showbikes.Click += new System.EventHandler(this.showbikes_Click);
            // 
            // showbeneficiary
            // 
            this.showbeneficiary.BackColor = System.Drawing.SystemColors.Info;
            this.showbeneficiary.Font = new System.Drawing.Font("p5hatty", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showbeneficiary.Location = new System.Drawing.Point(341, 3);
            this.showbeneficiary.Name = "showbeneficiary";
            this.showbeneficiary.Size = new System.Drawing.Size(150, 32);
            this.showbeneficiary.TabIndex = 38;
            this.showbeneficiary.Text = "BENEFICIARIES";
            this.showbeneficiary.UseVisualStyleBackColor = false;
            this.showbeneficiary.Click += new System.EventHandler(this.showbeneficiary_Click);
            // 
            // inactivebut
            // 
            this.inactivebut.BackColor = System.Drawing.SystemColors.Info;
            this.inactivebut.Font = new System.Drawing.Font("p5hatty", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inactivebut.Location = new System.Drawing.Point(1009, 3);
            this.inactivebut.Name = "inactivebut";
            this.inactivebut.Size = new System.Drawing.Size(94, 32);
            this.inactivebut.TabIndex = 37;
            this.inactivebut.Text = "INVALID";
            this.inactivebut.UseVisualStyleBackColor = false;
            this.inactivebut.Click += new System.EventHandler(this.inactivebut_Click);
            // 
            // active_but
            // 
            this.active_but.BackColor = System.Drawing.SystemColors.Info;
            this.active_but.Font = new System.Drawing.Font("p5hatty", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.active_but.Location = new System.Drawing.Point(924, 3);
            this.active_but.Name = "active_but";
            this.active_but.Size = new System.Drawing.Size(79, 32);
            this.active_but.TabIndex = 36;
            this.active_but.Text = "VALID";
            this.active_but.UseVisualStyleBackColor = false;
            this.active_but.Click += new System.EventHandler(this.active_but_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("p5hatty", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Bike_Cond._After:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("p5hatty", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 16);
            this.label8.TabIndex = 34;
            this.label8.Text = "Bike_Cond._Before:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("p5hatty", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 19);
            this.label7.TabIndex = 33;
            this.label7.Text = "Return date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("p5hatty", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 19);
            this.label6.TabIndex = 32;
            this.label6.Text = "Rental date:";
            // 
            // validity
            // 
            this.validity.BackColor = System.Drawing.SystemColors.Info;
            this.validity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validity.Location = new System.Drawing.Point(172, 317);
            this.validity.Name = "validity";
            this.validity.Size = new System.Drawing.Size(155, 26);
            this.validity.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("p5hatty", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 319);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 19);
            this.label10.TabIndex = 30;
            this.label10.Text = "Validity:";
            // 
            // receiver_staff_No
            // 
            this.receiver_staff_No.BackColor = System.Drawing.SystemColors.Info;
            this.receiver_staff_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiver_staff_No.Location = new System.Drawing.Point(172, 287);
            this.receiver_staff_No.Name = "receiver_staff_No";
            this.receiver_staff_No.Size = new System.Drawing.Size(155, 26);
            this.receiver_staff_No.TabIndex = 29;
            // 
            // lender_staff_No
            // 
            this.lender_staff_No.BackColor = System.Drawing.SystemColors.Info;
            this.lender_staff_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lender_staff_No.Location = new System.Drawing.Point(172, 259);
            this.lender_staff_No.Name = "lender_staff_No";
            this.lender_staff_No.Size = new System.Drawing.Size(155, 26);
            this.lender_staff_No.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("p5hatty", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 19);
            this.label9.TabIndex = 27;
            this.label9.Text = "Receiver Staff #:";
            // 
            // cleartext
            // 
            this.cleartext.BackColor = System.Drawing.SystemColors.Info;
            this.cleartext.Font = new System.Drawing.Font("p5hatty", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cleartext.Location = new System.Drawing.Point(176, 9);
            this.cleartext.Name = "cleartext";
            this.cleartext.Size = new System.Drawing.Size(151, 32);
            this.cleartext.TabIndex = 25;
            this.cleartext.Text = "CLEAR TEXTBOX";
            this.cleartext.UseVisualStyleBackColor = false;
            this.cleartext.Click += new System.EventHandler(this.cleartext_Click);
            // 
            // dgvrentalrec
            // 
            this.dgvrentalrec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrentalrec.Location = new System.Drawing.Point(341, 41);
            this.dgvrentalrec.Name = "dgvrentalrec";
            this.dgvrentalrec.Size = new System.Drawing.Size(762, 344);
            this.dgvrentalrec.TabIndex = 24;
            this.dgvrentalrec.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvrentalrec_CellContentClick);
            // 
            // refreshbut
            // 
            this.refreshbut.BackColor = System.Drawing.SystemColors.Info;
            this.refreshbut.Font = new System.Drawing.Font("p5hatty", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshbut.Location = new System.Drawing.Point(768, 3);
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
            this.deletebut.Location = new System.Drawing.Point(230, 371);
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
            this.editbut.Location = new System.Drawing.Point(126, 371);
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
            this.addbut.Location = new System.Drawing.Point(16, 371);
            this.addbut.Name = "addbut";
            this.addbut.Size = new System.Drawing.Size(82, 32);
            this.addbut.TabIndex = 19;
            this.addbut.Text = "ADD";
            this.addbut.UseVisualStyleBackColor = false;
            this.addbut.Click += new System.EventHandler(this.addbut_Click);
            // 
            // cond_after
            // 
            this.cond_after.BackColor = System.Drawing.SystemColors.Info;
            this.cond_after.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cond_after.Location = new System.Drawing.Point(172, 228);
            this.cond_after.Name = "cond_after";
            this.cond_after.Size = new System.Drawing.Size(155, 26);
            this.cond_after.TabIndex = 17;
            // 
            // cond_before
            // 
            this.cond_before.BackColor = System.Drawing.SystemColors.Info;
            this.cond_before.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cond_before.Location = new System.Drawing.Point(172, 199);
            this.cond_before.Name = "cond_before";
            this.cond_before.Size = new System.Drawing.Size(155, 26);
            this.cond_before.TabIndex = 16;
            // 
            // return_date
            // 
            this.return_date.BackColor = System.Drawing.SystemColors.Info;
            this.return_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_date.Location = new System.Drawing.Point(172, 168);
            this.return_date.Name = "return_date";
            this.return_date.Size = new System.Drawing.Size(155, 26);
            this.return_date.TabIndex = 15;
            // 
            // rental_date
            // 
            this.rental_date.BackColor = System.Drawing.SystemColors.Info;
            this.rental_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rental_date.Location = new System.Drawing.Point(172, 139);
            this.rental_date.Name = "rental_date";
            this.rental_date.Size = new System.Drawing.Size(155, 26);
            this.rental_date.TabIndex = 14;
            // 
            // beneficiary_No
            // 
            this.beneficiary_No.BackColor = System.Drawing.SystemColors.Info;
            this.beneficiary_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beneficiary_No.Location = new System.Drawing.Point(172, 109);
            this.beneficiary_No.Name = "beneficiary_No";
            this.beneficiary_No.Size = new System.Drawing.Size(155, 26);
            this.beneficiary_No.TabIndex = 13;
            // 
            // bike_No
            // 
            this.bike_No.BackColor = System.Drawing.SystemColors.Info;
            this.bike_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bike_No.Location = new System.Drawing.Point(172, 77);
            this.bike_No.Name = "bike_No";
            this.bike_No.Size = new System.Drawing.Size(155, 26);
            this.bike_No.TabIndex = 12;
            // 
            // rental_rec_No
            // 
            this.rental_rec_No.BackColor = System.Drawing.SystemColors.Info;
            this.rental_rec_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rental_rec_No.Location = new System.Drawing.Point(172, 47);
            this.rental_rec_No.Name = "rental_rec_No";
            this.rental_rec_No.Size = new System.Drawing.Size(155, 26);
            this.rental_rec_No.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("p5hatty", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Lender Staff #:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("p5hatty", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Beneficiary #:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("p5hatty", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bike_No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("p5hatty", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rental_Rec. No:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("p5hatty", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(380, 27);
            this.label11.TabIndex = 28;
            this.label11.Text = "MANAGE RENTAL RECORDS";
            // 
            // rental_records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1139, 505);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exitbut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rental_records";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rental_records";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrentalrec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitbut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cleartext;
        private System.Windows.Forms.DataGridView dgvrentalrec;
        private System.Windows.Forms.Button refreshbut;
        private System.Windows.Forms.Button deletebut;
        private System.Windows.Forms.Button editbut;
        private System.Windows.Forms.Button addbut;
        private System.Windows.Forms.TextBox cond_after;
        private System.Windows.Forms.TextBox cond_before;
        private System.Windows.Forms.TextBox return_date;
        private System.Windows.Forms.TextBox rental_date;
        private System.Windows.Forms.TextBox beneficiary_No;
        private System.Windows.Forms.TextBox bike_No;
        private System.Windows.Forms.TextBox rental_rec_No;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox receiver_staff_No;
        private System.Windows.Forms.TextBox lender_staff_No;
        private System.Windows.Forms.TextBox validity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button inactivebut;
        private System.Windows.Forms.Button active_but;
        private System.Windows.Forms.Button showstaffs;
        private System.Windows.Forms.Button showbikes;
        private System.Windows.Forms.Button showbeneficiary;
    }
}