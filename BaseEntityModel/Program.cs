using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseEntityModel
{
    public class Program
    {
        static void Main(string[] args)
        {
            var bookRepo = new Repository<Book>();
            var customerRepo = new Repository<Customer>();

            bookRepo.Add( new Book { ID = 1, Title= "C# 101", TitleName="C#101" } );
            customerRepo.Add(new Customer { ID = 2, Name = "Ahmet" } );
            //Bu örnekte, aynı Repository<T> sınıfı hem Book hem Customer için kullanılabildi çünkü ikisi de BaseEntityModel'den türedi.
        }
    }
    public class BaseEntityModel
    {
        public int ID { get; set; }
        public string TitleName { get; set; }
    }
    public class Book: BaseEntityModel
    {
        public string Title { get; set; }
    }
    public class Customer: BaseEntityModel
    {
        public string Name { get; set; }
    }
    public interface IRepository<T> where T : BaseEntityModel 
    {
        void Add(T entity);
    }
    public class Repository<T> : IRepository<T> where T : BaseEntityModel 
    {
        public void Add(T entity) 
        {
            Console.WriteLine($" {typeof(T).Name} eklendi. ID: {entity.ID} ve kitap adı: {entity.TitleName}");
        }
    }
}
