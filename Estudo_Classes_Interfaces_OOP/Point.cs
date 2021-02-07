﻿using System;

namespace Estudo_Classes_Interfaces_OOP
{
	public class Point
	{
		public int X;
		public int Y;

		public Point(int x, int y)
		{
			X = x;
			Y = y;
		}

		public void Move(int x, int y)
		{
			this.X = x;
			this.Y = y;
		}

		public void Move(Point newLocation)
		{
			if (newLocation == null)
				throw new ArgumentException("newLocation");

			Move(newLocation.X, newLocation.Y);
			//this.X = newLocation.X;
			//this.Y = newLocation.Y;
		}

	}
}
