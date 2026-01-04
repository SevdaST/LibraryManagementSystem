using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibraryApp.Core.Models;

namespace LibraryApp.Core.Services
{
    /*
    TR:
    Library sınıfı, uygulamadaki işlemleri yöneten ana sınıftır.
    Üye/kitap ekleme, ödünç verme ve iade alma işlemleri burada yapılır.
    Aynı TCK No ile ikinci üye eklenmesi engellenir.

    EN:
    The Library class manages the application operations.
    Adding members/books, borrowing and returning are handled here.
    Duplicate members with the same identity number are prevented.
    */
    public class Library
    {
        // Veri listeleri private tutulur (dışarıdan doğrudan değiştirilemesin)
        private readonly List<Book> _books = new List<Book>();
        private readonly List<Member> _members = new List<Member>();
        private readonly List<Loan> _loans = new List<Loan>();

        // Dışarıya sadece okunabilir şekilde listeleri açıyoruz
        public IReadOnlyList<Book> Books => _books;
        public IReadOnlyList<Member> Members => _members;
        public IReadOnlyList<Loan> Loans => _loans;

        private int _nextLoanId = 1;

        // Kitap ekleme
        public void AddBook(Book book)
        {
            if (book == null)
                throw new ArgumentNullException(nameof(book));

            // Aynı ISBN ile ikinci kitap kaydı olmasın
            if (_books.Any(b => b.Isbn == book.Isbn))
                throw new InvalidOperationException("Bu ISBN ile zaten bir kitap kayıtlı.");

            _books.Add(book);
        }

        // Üye ekleme
        public void AddMember(Member member)
        {
            if (member == null)
                throw new ArgumentNullException(nameof(member));

            // Aynı ID ile ikinci üye eklenmesin
            if (_members.Any(m => m.Id == member.Id))
                throw new InvalidOperationException("Bu ID ile zaten bir üye kayıtlı.");

            // Aynı TCK No ile ikinci üye eklenmesin
            if (_members.Any(m => m.TckNo == member.TckNo))
                throw new InvalidOperationException("Bu TCK No ile zaten bir üye kayıtlı.");

            _members.Add(member);
        }

        // ISBN ile kitap bulma (internal iş için)
        private Book FindBook(string isbn)
        {
            if (string.IsNullOrWhiteSpace(isbn))
                throw new ArgumentException("ISBN boş olamaz.");

            var book = _books.FirstOrDefault(b => b.Isbn.Equals(isbn.Trim(), StringComparison.OrdinalIgnoreCase));
            if (book == null)
                throw new InvalidOperationException("Kitap bulunamadı.");

            return book;
        }

        // ID ile üye bulma
        private Member FindMember(int memberId)
        {
            var member = _members.FirstOrDefault(m => m.Id == memberId);
            if (member == null)
                throw new InvalidOperationException("Üye bulunamadı.");

            return member;
        }

        // Ödünç verme
        public Loan BorrowBook(string isbn, int memberId, int loanDays)
        {
            // Kitap ve üyeyi bul
            
            var book = FindBook(isbn);
            var member = FindMember(memberId);

            if (!book.CanBorrow())
                throw new InvalidOperationException("Bu kitabın ödünç verilebilir kopyası yok.");

            

            book.BorrowOne();

            var loan = new Loan(_nextLoanId, book, member, loanDays);
            _nextLoanId++;

            _loans.Add(loan);
            return loan;
        }

        // İade alma
        public void ReturnBook(int loanId)
        {
            var loan = _loans.FirstOrDefault(l => l.LoanId == loanId);
            if (loan == null)
                throw new InvalidOperationException("Hata.");

            if (loan.IsReturned)
                throw new InvalidOperationException("Hata.");

            loan.MarkReturned();
            loan.Book.ReturnOne();
        }
    }
}
