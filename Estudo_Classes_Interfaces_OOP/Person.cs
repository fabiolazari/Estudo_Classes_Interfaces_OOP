using System;

namespace Estudo_Classes_Interfaces_OOP
{
	public class Person
	{
		public DateTime Birthdate { get; private set; }

		public int Age
		{
			get
			{
				TimeSpan timeSpan = DateTime.Today - Birthdate;
				Int32 years = timeSpan.Days / 365;
				return years;
			}
		}

		public Person(DateTime birthdate)
		{
			Birthdate = birthdate;
		}

		//private DateTime _birthdate;

		/*
		public void SetBirthdate(DateTime birthdate)
		{
			_birthdate = birthdate;
		}
	
		public DateTime GetBirthdate()
		{
			return _birthdate;
		}
		*/
	}
}
