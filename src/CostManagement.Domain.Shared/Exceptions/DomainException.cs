﻿namespace CostManagement.Domain.Shared.Exceptions;

public class DomainException : Exception
{
    public DomainException(string message) 
        : base(message)
    { }

    public DomainException(string message, Exception exception) 
        : base(message, exception)
    { }
}