﻿namespace PonrfDomain;

/// <summary>
/// Class Customer describes a customer
/// </summary>
public class Customer
{
    /// <summary>
    /// Passport contains informatiom about passport's number of customer
    /// </summary>
    public int Passport { get; set; } = int.MinValue;
    /// <summary>
    /// FIO contains informatiom about full name of customer
    /// </summary>  
    public string FIO { get; set; } = string.Empty;
    /// <summary>
    /// Address contains informatiom about home address of customer
    /// </summary>
    public string Address { get; set; } = string.Empty;

    public Customer() { }
    public Customer(int passport, string fIO, string address)
    {
        Passport = passport;
        FIO = fIO;
        Address = address;
    }
}