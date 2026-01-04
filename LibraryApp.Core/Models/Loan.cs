using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Core.Models
{
    /*
    TR:
    Loan sınıfı, bir kitabın bir üye tarafından ödünç alınmasını temsil eder.
    Ödünç alma/son iade/iade durumu bilgilerini tutar.

    EN:
    The Loan class represents a borrowing transaction.
    It stores borrow/due/return status information.
    */
    public class Loan
    {
        // Her ödünç işlemi için benzersiz ID
        public int LoanId { get; }

        // Ödünç alınan kitap
        public Book Book { get; }

        // Ödünç alan üye
        public Member Member { get; }

        // Ödünç alma tarihi
        public DateTime BorrowedAt { get; }

        // Son iade tarihi
        public DateTime DueAt { get; }

        // İade edildiyse iade zamanı, edilmediyse null
        public DateTime? ReturnedAt { get; private set; }

        // İade edildi mi?
        public bool IsReturned => ReturnedAt.HasValue;


        public Loan(int loanId, Book book, Member member, int loanDays)
        {
            LoanId = loanId;
            Book = book ?? throw new ArgumentNullException(nameof(book));
            Member = member ?? throw new ArgumentNullException(nameof(member));

            // Gün sayısı pozitif olmalı
            if (loanDays <= 0)
                throw new ArgumentException("Ödünç süresi pozitif olmalıdır.");

            BorrowedAt = DateTime.Now;
            DueAt = BorrowedAt.AddDays(loanDays);
        }
        public void MarkReturned()
        {
            if (IsReturned)
                throw new InvalidOperationException("Bu ödünç zaten iade edilmiş.");

            ReturnedAt = DateTime.Now;
        }

        public override string ToString()
        {
            string status = IsReturned ? $"Teslim Edildi: {ReturnedAt:yyyy-MM-dd}" : "Teslim Edilmedi";
            return $"{LoanId} | {Member.FullName} | {Book.Title} | Verildi: {BorrowedAt:yyyy-MM-dd} | -e Kadar: {DueAt:yyyy-MM-dd} | {status}";
        }
    }
}
