using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Core.Models
{
    /*
    TR:
    Book sınıfı, kitap bilgilerini ve mevcut kopya durumunu tutar.
    Kopya sayıları doğrudan değil, sınıf metotları üzerinden güncellenir.

    EN:
    The Book class stores book data and availability.
    Copy counts are updated via class methods, not directly.
    */
    public class Book
    {
        // Kitabın benzersiz ISBN numarası
        public string Isbn { get; }

        // Kitap adı
        public string Title { get; }

        // Yazar adı
        public string Author { get; }

        // Toplam kopya sayısı
        public int TotalCopies { get; }

        // Ödünç verilebilir mevcut kopya sayısı
        public int AvailableCopies { get; private set; }

        public Book(string isbn, string title, string author, int totalCopies)
        {
            // ISBN boş olamaz
            if (string.IsNullOrWhiteSpace(isbn))
                throw new ArgumentException("ISBN boş olamaz.");

            // Kitap adı boş olamaz
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Kitap adı boş olamaz.");

            // Yazar adı boş olamaz
            if (string.IsNullOrWhiteSpace(author))
                throw new ArgumentException("Yazar bilgisi boş olamaz.");

            // Toplam kopya en az 1 olmalı
            if (totalCopies <= 0)
                throw new ArgumentException("Toplam kopya sayısı 1 veya daha büyük olmalıdır.");

            Isbn = isbn.Trim();
            Title = title.Trim();
            Author = author.Trim();
            TotalCopies = totalCopies;

            // Başlangıçta tüm kopyalar kullanılabilir
            AvailableCopies = totalCopies;
        }

        // Ödünç verilebilir mi?
        public bool CanBorrow()
        {
            return AvailableCopies > 0;
        }

        // Bir kopya ödünç ver
        public void BorrowOne()
        {
            // Kopya yoksa işlem yapılamaz
            if (!CanBorrow())
                throw new InvalidOperationException("Uygun kopya yok.");

            AvailableCopies--;
        }

        // Bir kopya iade al
        public void ReturnOne()
        {
            // Mevcut kopya toplamı geçemez
            if (AvailableCopies >= TotalCopies)
                throw new InvalidOperationException("İade edilecek fazla kopya var.");

            AvailableCopies++;
        }

        public override string ToString()
        {
            return $"{Title} - {Author} (ISBN: {Isbn}) | Available: {AvailableCopies}/{TotalCopies}";
        }
    }
}
