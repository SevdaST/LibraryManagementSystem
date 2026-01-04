namespace LibraryApp.WinForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtTckNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotalCopies = new System.Windows.Forms.TextBox();
            this.txtReturnLoanId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLoanDays = new System.Windows.Forms.TextBox();
            this.txtBorrowMemberId = new System.Windows.Forms.TextBox();
            this.txtBorrowIsbn = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.gridMembers = new System.Windows.Forms.DataGridView();
            this.gridBooks = new System.Windows.Forms.DataGridView();
            this.gridLoans = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLoans)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Üye Id";
            // 
            // txtMemberId
            // 
            this.txtMemberId.Location = new System.Drawing.Point(75, 36);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(100, 20);
            this.txtMemberId.TabIndex = 1;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(75, 62);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(100, 20);
            this.txtFullName.TabIndex = 2;
            // 
            // txtTckNo
            // 
            this.txtTckNo.Location = new System.Drawing.Point(75, 88);
            this.txtTckNo.Name = "txtTckNo";
            this.txtTckNo.Size = new System.Drawing.Size(100, 20);
            this.txtTckNo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adı Soyadı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "TC No";
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(34, 123);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(119, 23);
            this.btnAddMember.TabIndex = 6;
            this.btnAddMember.Text = " Üye Ekle";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(31, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Okuyucu Ekleme";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(249, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Kitap Ekleme";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(253, 158);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(119, 23);
            this.btnAddBook.TabIndex = 14;
            this.btnAddBook.Text = " Kitap Ekle";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Yazar Adı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(230, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Kitap Adı";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(293, 93);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(100, 20);
            this.txtAuthor.TabIndex = 11;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(293, 67);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 10;
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(293, 41);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(100, 20);
            this.txtIsbn.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(230, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "ISBN";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(230, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Adet";
            // 
            // txtTotalCopies
            // 
            this.txtTotalCopies.Location = new System.Drawing.Point(293, 122);
            this.txtTotalCopies.Name = "txtTotalCopies";
            this.txtTotalCopies.Size = new System.Drawing.Size(100, 20);
            this.txtTotalCopies.TabIndex = 16;
            // 
            // txtReturnLoanId
            // 
            this.txtReturnLoanId.Location = new System.Drawing.Point(748, 45);
            this.txtReturnLoanId.Name = "txtReturnLoanId";
            this.txtReturnLoanId.Size = new System.Drawing.Size(100, 20);
            this.txtReturnLoanId.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(508, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Kitap Verme";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(710, 81);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(119, 23);
            this.btnReturn.TabIndex = 25;
            this.btnReturn.Text = "Teslim Al";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(462, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Süre (Gün)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(462, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Üye Id";
            // 
            // txtLoanDays
            // 
            this.txtLoanDays.Location = new System.Drawing.Point(525, 93);
            this.txtLoanDays.Name = "txtLoanDays";
            this.txtLoanDays.Size = new System.Drawing.Size(100, 20);
            this.txtLoanDays.TabIndex = 22;
            this.txtLoanDays.Text = "14";
            // 
            // txtBorrowMemberId
            // 
            this.txtBorrowMemberId.Location = new System.Drawing.Point(525, 67);
            this.txtBorrowMemberId.Name = "txtBorrowMemberId";
            this.txtBorrowMemberId.Size = new System.Drawing.Size(100, 20);
            this.txtBorrowMemberId.TabIndex = 21;
            // 
            // txtBorrowIsbn
            // 
            this.txtBorrowIsbn.Location = new System.Drawing.Point(525, 41);
            this.txtBorrowIsbn.Name = "txtBorrowIsbn";
            this.txtBorrowIsbn.Size = new System.Drawing.Size(100, 20);
            this.txtBorrowIsbn.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(462, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "ISBN";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(687, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Teslimat Id";
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(485, 123);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(119, 23);
            this.btnBorrow.TabIndex = 31;
            this.btnBorrow.Text = "Kitap Ver";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // gridMembers
            // 
            this.gridMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMembers.Location = new System.Drawing.Point(12, 236);
            this.gridMembers.Name = "gridMembers";
            this.gridMembers.Size = new System.Drawing.Size(905, 150);
            this.gridMembers.TabIndex = 32;
            // 
            // gridBooks
            // 
            this.gridBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBooks.Location = new System.Drawing.Point(12, 392);
            this.gridBooks.Name = "gridBooks";
            this.gridBooks.Size = new System.Drawing.Size(905, 150);
            this.gridBooks.TabIndex = 33;
            // 
            // gridLoans
            // 
            this.gridLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLoans.Location = new System.Drawing.Point(13, 548);
            this.gridLoans.Name = "gridLoans";
            this.gridLoans.Size = new System.Drawing.Size(905, 161);
            this.gridLoans.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(716, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 20);
            this.label14.TabIndex = 35;
            this.label14.Text = "Kitap İade";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 789);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.gridLoans);
            this.Controls.Add(this.gridBooks);
            this.Controls.Add(this.gridMembers);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtReturnLoanId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtLoanDays);
            this.Controls.Add(this.txtBorrowMemberId);
            this.Controls.Add(this.txtBorrowIsbn);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTotalCopies);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTckNo);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtMemberId);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLoans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtTckNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotalCopies;
        private System.Windows.Forms.TextBox txtReturnLoanId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtLoanDays;
        private System.Windows.Forms.TextBox txtBorrowMemberId;
        private System.Windows.Forms.TextBox txtBorrowIsbn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.DataGridView gridMembers;
        private System.Windows.Forms.DataGridView gridBooks;
        private System.Windows.Forms.DataGridView gridLoans;
        private System.Windows.Forms.Label label14;
    }
}

