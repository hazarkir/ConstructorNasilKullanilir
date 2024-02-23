using Constructors;
using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "Hazar", LastName = "Kır", City = "Erzincan" };

            Customer customer3 = new Customer();

            customer3.Id = 3;

            Customer customer2 = new Customer(2, "Hazar", "Kır", "Erzincan");

            Console.WriteLine(customer2.FirstName);
        }
    }

    class Customer
    {
        public Customer()
        {

        }

        //default constructor

        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}


/*İlk olarak, Customer sınıfı tanımlanıyor. Bu sınıf, bir müşteriyi temsil etmek için kullanılıyor. Sınıfın içinde Id, FirstName, LastName ve City adında dört özellik bulunuyor. Bu özelliklerin her biri, bir müşterinin kimlik numarası, adı, soyadı ve yaşadığı şehri temsil ediyor. Bu özellikler public erişim belirleyicisiyle tanımlanmıştır, bu da dışarıdan erişime açık oldukları anlamına gelir.

Ardından, Customer sınıfının iki kurucu yöntemi tanımlanıyor:

İlk kurucu yöntem, parametre almayan bir kurucudur. Bu kurucu yöntemde herhangi bir işlev belirtilmemiş, yani boş bırakılmıştır.
İkinci kurucu yöntem, dört parametre alır: id, firstName, lastName ve city. Bu parametreler aracılığıyla müşterinin özellikleri atanır. Yani, bu kurucu yöntem sayesinde, müşteri nesneleri oluşturulurken direkt olarak değerler atanabilir.
Program sınıfı içinde, Main metodu bulunuyor. Bu metot, programın başlangıç noktasını temsil eder. Main metodu içinde üç adet müşteri nesnesi oluşturuluyor ve bazı özelliklerine değerler atanıyor:

customer1 adında bir müşteri nesnesi oluşturuluyor ve değerler ataması yapılıyor. Bu değerler, parametre almayan kurucu yöntemle atanmıyor, bunun yerine nesne oluşturulduktan sonra ayrı ayrı özelliklere değer atanıyor.
customer3 adında başka bir müşteri nesnesi oluşturuluyor ancak bu sefer parametre almayan kurucu yöntem kullanılıyor. Daha sonra customer3'ün özelliklerine değerler atanıyor.
customer2 adında bir müşteri nesnesi oluşturuluyor ve bu sefer parametre alan kurucu yöntem kullanılıyor. Bu kurucu yöntem aracılığıyla müşterinin özelliklerine doğrudan değer atanıyor.
Son olarak, customer2'nin FirstName özelliği Console.WriteLine metodu kullanılarak ekrana yazdırılıyor.

Bu program, müşteri nesneleri oluşturmayı, kurucu yöntemlerin kullanımını ve sınıf içindeki özelliklere erişimi göstermektedir.*/