using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryApp.Core.Models;
using LibraryApp.Core.Services;
namespace LibraryApp.WinForms
{
    public partial class Form1 : Form
    {
        private readonly Library _library = new Library();
        public Form1()
        {
            InitializeComponent();
            // Uygulama ilk açıldığında listeleri doldur
            RefreshMembers();
            RefreshBooks();
            RefreshLoans();
        }
        private void RefreshMembers()
        {
            var view = _library.Members
                .Select(m => new
                {
                    UyeNo = m.Id,
                    AdSoyad = m.FullName,
                    TCKNo = m.TckNo
                })
                .ToList();

            gridMembers.DataSource = null;
            gridMembers.DataSource = view;

            gridMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }


        private void RefreshBooks()
        {
            var view = _library.Books
                .Select(b => new
                {
                    ISBN = b.Isbn,
                    KitapAdi = b.Title,
                    Yazar = b.Author,
                    ToplamKopya = b.TotalCopies,
                    MevcutKopya = b.AvailableCopies
                })
                .ToList();

            gridBooks.DataSource = null;
            gridBooks.DataSource = view;

            gridBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }


        private void RefreshLoans()
        {
            
            var view = _library.Loans
                .Select(l => new
                {
                    OduncNo = l.LoanId,                          // LoanId -> Ödünç No
                    ISBN = l.Book.Isbn,                          // Book -> ISBN
                    UyeNo = l.Member.Id,                         // Member -> Üye No
                    AdSoyad = l.Member.FullName,                 // Member -> Ad Soyad
                    OduncTarihi = l.BorrowedAt,                  // BorrowedAt -> Ödünç Tarihi
                    SonIadeTarihi = l.DueAt,                      // DueAt -> Son İade Tarihi
                    IadeTarihi = l.ReturnedAt,                   // ReturnedAt -> İade Tarihi
                    IadeEdildiMi = l.IsReturned                  // IsReturned -> İade Edildi mi?
                })
                .ToList();

            gridLoans.DataSource = null;
            gridLoans.DataSource = view;

            gridLoans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtMemberId.Text.Trim());
                string fullName = txtFullName.Text.Trim();
                string tckNo = txtTckNo.Text.Trim();

                _library.AddMember(new Member(id, fullName, tckNo));

                MessageBox.Show("Üye Ekleme Başarılı.");

                // Sadece üyeler yenilenir
                RefreshMembers();

                txtMemberId.Clear();
                txtFullName.Clear();
                txtTckNo.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                string isbn = txtIsbn.Text.Trim();
                string title = txtTitle.Text.Trim();
                string author = txtAuthor.Text.Trim();
                int totalCopies = int.Parse(txtTotalCopies.Text.Trim());

                _library.AddBook(new Book(isbn, title, author, totalCopies));

                MessageBox.Show("Kitap Ekleme Başarılı.");

                // Sadece kitaplar yenilenir
                RefreshBooks();

                txtIsbn.Clear();
                txtTitle.Clear();
                txtAuthor.Clear();
                txtTotalCopies.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            try
            {
                string isbn = txtBorrowIsbn.Text.Trim();
                int memberId = int.Parse(txtBorrowMemberId.Text.Trim());

                int loanDays = 14;
                if (!string.IsNullOrWhiteSpace(txtLoanDays.Text))
                    loanDays = int.Parse(txtLoanDays.Text.Trim());

                var loan = _library.BorrowBook(isbn, memberId, loanDays);

                MessageBox.Show($"Ödünç Alma Başarılı.");

                // Kitap ve loan listeleri değişti
                RefreshBooks();
                RefreshLoans();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                string input = txtReturnLoanId.Text.Trim();

                if (!Int32.TryParse(input, out int loanId))
                    throw new ArgumentException("Teslimat Kodu Hatalı.");

                _library.ReturnBook(loanId);

                MessageBox.Show("Teslim Alma Başarılı.");

                // Kitap ve loan listeleri değişti
                RefreshBooks();
                RefreshLoans();

                txtReturnLoanId.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
