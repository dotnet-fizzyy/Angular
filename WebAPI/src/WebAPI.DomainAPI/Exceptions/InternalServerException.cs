﻿using System;

namespace WebAPI.DomainAPI.Exceptions
{
	public class InternalServerException : Exception
	{
		public InternalServerException(string message) : base(message)
		{

		}
	}
}
