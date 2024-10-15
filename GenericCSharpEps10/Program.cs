namespace GenericCSharpEps10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    internal interface IEntity
    {
        int Id { get; }
    } 

    internal interface IRepository<T> where T : IEntity
    {
        public void Add(T item);
        public void Remove(T item);
    }

    internal class Product : IEntity
    {
        public int Id { get; set; }
        public int Name { get; set; }
    }

    internal class User : IEntity 
    {
        public int Id { get; set; }

        public int Name { get; set; }
    }

    internal class ProductRepository : IRepository<Product>
    {
        public void Add(Product item)
        {

        }

        public void Remove(Product item)
        {

        }
    }


    internal class UserRepository : IRepository<User>
    {
        public void Add(User item)
        {

        }

        public void Remove(User item)
        {

        }
    }

}