using System;
using System.Linq;

namespace LibraryApp.Core.Models
{
    /*
    TR:
    Member sınıfı, kütüphaneye kayıtlı kullanıcıyı temsil eder.
    TCK No için sadece temel format kontrolü yapılır:
    - 11 karakter
    - Sadece rakam

    EN:
    The Member class represents a registered library user.
    The TCK No is validated only for basic format.
    */
    public class Member
    {
        public int Id { get; }
        public string FullName { get; }
        public string TckNo { get; }

        public Member(int id, string fullName, string tckNo)
        {
            if (id <= 0)
                throw new ArgumentException("Üye numarası pozitif olmalıdır.");

            if (string.IsNullOrWhiteSpace(fullName))
                throw new ArgumentException("Ad soyad boş olamaz.");

            if (string.IsNullOrWhiteSpace(tckNo))
                throw new ArgumentException("TCK No boş olamaz.");

            if (tckNo.Length != 11)
                throw new ArgumentException("TCK No 11 haneli olmalıdır.");

            if (!tckNo.All(char.IsDigit))
                throw new ArgumentException("TCK No sadece rakamlardan oluşmalıdır.");

            Id = id;
            FullName = fullName.Trim();
            TckNo = tckNo;
        }

        public override string ToString()
        {
            return $"{Id} - {FullName} (TCK No: {TckNo})";
        }
    }
}
