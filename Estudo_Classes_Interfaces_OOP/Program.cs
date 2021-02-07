using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Estudo_Classes_Interfaces_OOP
{
	public class Program
	{
		static void Main(string[] args)
		{
			//Person1 _personExemplo = new Person1();
			//var p = person.Parse("Fabio");
			/*
			var person = Person.Parse("Fabio");
			person.Introduce("Mosh");
			*/
			//Customer customer = new Customer(1, "Fabio");
			/*
			Customer customer = new Customer();
			customer.Id = 1;
			customer.Name = "Fabio";
			*/
			/*
			Customer customer = new Customer()
			{
				Id = 1,
				Name = "Fabio"
			};

			Order order = new Order();
			customer.Orders.Add(order);

			Console.WriteLine(customer.Id);
			Console.WriteLine(customer.Name);
			*/
			/*
			TestRef testeref = new TestRef();

			var a = 1;
			testeref.DoAWeirdThing(ref a);

			var b = 1;
			testeref.MyMethod(b);

			int c;
			testeref.MyMethodOut(out c);
			*/
			/*
			Calculator calculator = new Calculator();

			try
			{
				var number = int.Parse("abc");
			}
			catch (Exception)
			{
				Console.WriteLine("Convertion Failed!");
			}
			
			int number2;
			int.TryParse("abc", out number2);


			Console.WriteLine(calculator.Add(1, 2));
			Console.WriteLine(calculator.Add(1, 2, 3));
			Console.WriteLine(calculator.Add(5, 8, 4, 3, 10));
			Console.WriteLine(calculator.Add(new int[] { 3, 2, 1, 7 } ));
			*/
			/*
			Customer customer = new Customer(1);
			customer.Orders.Add(new Order());
			customer.Orders.Add(new Order());

			customer.Promote();

			Console.WriteLine(customer.Orders.Count);
			*/
			/*
			Person person = new Person();
			person.SetBirthdate(new DateTime(1973, 11, 4));

			Console.WriteLine(person.GetBirthdate());
			*/
			/*
			Person person = new Person(new DateTime(1973, 11, 4));

			Console.WriteLine(person.Age);
			*/

			HttpCookie Cookie = new HttpCookie();
			Cookie["name"] = "Fabio";

			Console.WriteLine(Cookie["name"]);

			Console.ReadLine();
		}

		public static void UsePoints()
		{
			try
			{
				Point point = new Point(10, 20);
				//point.Move(new Point(40, 60));
				point.Move(null);

				Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

				point.Move(100, 200);
				Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
			}
			catch (Exception ex)
			{

				Console.WriteLine("Error occuried: " + ex.Message);
			}
		}
	}

	public class TestRef
	{
		public void DoAWeirdThing(ref int a)
		{
			a += 2;
		}

		public void MyMethod(int b)
		{
			b += 2;
		}

		public void MyMethodOut(out int result)
		{
			result = 1;
		}
	}

	public class Person1
	{
		public string Name;

		public Person1()
		{
		}

		public void Introduce(string to)
		{
			Console.WriteLine("Hi {0}, I am {1}", to, Name);
		}

		public static Person1 Parse(string str)
		{
			Person1 person = new Person1();
			person.Name = str;

			return person;
		}
	}
}
