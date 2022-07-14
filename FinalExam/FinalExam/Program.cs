using System;

namespace FinalExam
{
    public abstract class Product
    {
        int _proID;
        string _proName;
        double _proPrice;

        public int ID
        {
            get { return _proID; }
            set { _proID = value; }
        }

        public string Name
        {
            get { return _proName; }
            set { _proName = value; }
        }

        public double Price
        {
            get { return this._proPrice; }
            set { _proPrice = value; }
        }

        public Product(int id, string name, double price)
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
        }

        public int GetID()
        {
            return ID;
        }
        public string GetName()
        {
            return Name;
        }
        public double GetPrice()
        {
            return Price;
        }

        public abstract double computeTax();
    }
    public class Book : Product
    {
        double bookTax;
        public Book(int id, string name, double price) : base(id, name, price)
        {

        }
        public override double computeTax()
        {
            return Price * 5 / 100;
        }
    }

    public class Phone : Product
    {
        public Phone(int id, string name, double price) : base(id, name, price)
        {

        }
        public override double computeTax()
        {
            return Price * 10 / 100;
        }
    }

    public static class Programs
    {
        public static void Main(string[] args)
        {
            double phoneTax = 0;
            double bookTax = 0;
            double totalTax = 0;
            Book Book1 = new Book(1, "Onepiece", 100);
            Book Book2 = new Book(2, "Doraemon", 120);
            Book Book3 = new Book(3, "Conan", 110);
            Phone Phone1 = new Phone(1, "Vertu", 1000);
            Phone Phone2 = new Phone(2, "Iphone", 1200);
            List<Phone> objPhone = new List<Phone>();
            objPhone.Add(Phone1);
            objPhone.Add(Phone2);
            List<Book> objBook = new List<Book>();
            objBook.Add(Book1);
            objBook.Add(Book2);
            objBook.Add(Book3);
            for (int i = 0; i < objPhone.Count; i++)
            {
                phoneTax += objPhone[i].computeTax();
            }
            for (int a = 0; a < objBook.Count; a++)
            {
                bookTax += objBook[a].computeTax();
            }
            totalTax = phoneTax + bookTax;
            Console.WriteLine(phoneTax);
            Console.WriteLine(bookTax);
            Console.WriteLine("Total Tax of product is: " + totalTax);
        }
    }
}

