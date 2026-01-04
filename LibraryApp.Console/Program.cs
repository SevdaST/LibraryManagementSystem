using LibraryApp.Core.Models;
using LibraryApp.Core.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Console
{
    internal class Program
    {
        static void Main()
        {
            var library = new Library();

            while (true)
            {
                System.Console.WriteLine("\n=== Console Kütüphane Uygulaması  ===");
                System.Console.WriteLine("1) Üye Ekle");
                System.Console.WriteLine("2) Yayın Ekle");
                System.Console.WriteLine("3) Yayın Ver");
                System.Console.WriteLine("4) Teslim al");
                System.Console.WriteLine("5) Üyeleri Listele");
                System.Console.WriteLine("6) Yayınları Listele");
                System.Console.WriteLine("7) İşlemleri Listele");
                System.Console.WriteLine("0) Çıkış");
                System.Console.Write("Seçiminiz: ");

                string choice = System.Console.ReadLine();

                try
                {
                    switch (choice)
                    {
                        case "1":
                            AddMember(library);
                            break;
                        case "2":
                            AddBook(library);
                            break;
                        case "3":
                            BorrowBook(library);
                            break;
                        case "4":
                            ReturnBook(library);
                            break;
                        case "5":
                            ListMembers(library);
                            break;
                        case "6":
                            ListBooks(library);
                            break;
                        case "7":
                            ListLoans(library);
                            break;
                        case "0":
                            return;
                        default:
                            System.Console.WriteLine("Seçim Geçersiz.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine($"ERROR: {ex.Message}");
                }
            }
        }

        static void AddMember(Library library)
        {
            System.Console.Write("Üye ID: ");
            int id = int.Parse(System.Console.ReadLine() ?? "0");

            System.Console.Write("Adı Soyadı: ");
            string name = System.Console.ReadLine() ?? "";

            System.Console.Write("TCK No: ");
            string tck = System.Console.ReadLine() ?? "";

            library.AddMember(new Member(id, name, tck));
            System.Console.WriteLine("Üye eklendi.");
        }

        static void AddBook(Library library)
        {
            System.Console.Write("Yayın Id: ");
            string isbn = System.Console.ReadLine() ?? "";

            System.Console.Write("Yayın Adı: ");
            string title = System.Console.ReadLine() ?? "";

            System.Console.Write("Yazarı: ");
            string author = System.Console.ReadLine() ?? "";

            System.Console.Write("Mevcut Adet: ");
            int copies = int.Parse(System.Console.ReadLine() ?? "0");

            library.AddBook(new Book(isbn, title, author, copies));
            System.Console.WriteLine("Yayın Eklendi.");
        }

        static void BorrowBook(Library library)
        {
            System.Console.Write("Kitap ID: ");
            string isbn = System.Console.ReadLine() ?? "";

            System.Console.Write("Üye ID: ");
            int memberId = int.Parse(System.Console.ReadLine() ?? "0");

            System.Console.Write("Gün Sayısı (e.g., 14): ");
            int days = int.Parse(System.Console.ReadLine() ?? "14");

            var loan = library.BorrowBook(isbn, memberId, days);
            System.Console.WriteLine($"Ödünç Verildi. İşlem ID: {loan.LoanId}");
        }

        static void ReturnBook(Library library)
        {
            System.Console.Write("İşlem ID : ");
            string input = System.Console.ReadLine() ?? "";

            if (!Int32.TryParse(input, out int loanId))
            {
                System.Console.WriteLine("Hatalı İşlem.");
                return;
            }

            library.ReturnBook(loanId);
            System.Console.WriteLine("Teslim Alındı.");
        }

        static void ListMembers(Library library)
        {
            System.Console.WriteLine("\n--- Üyeler ---");
            foreach (var m in library.Members)
                System.Console.WriteLine(m);
        }

        static void ListBooks(Library library)
        {
            System.Console.WriteLine("\n--- Yayınlar ---");
            foreach (var b in library.Books)
                System.Console.WriteLine(b);
        }

        static void ListLoans(Library library)
        {
            System.Console.WriteLine("\n--- İşlemler ---");
            foreach (var l in library.Loans)
                System.Console.WriteLine(l);
        }
    }
}

