﻿namespace PonrfDomain;

/// <summary>
/// Class Building describes a building 
/// </summary>
public class Building
{
    /// <summary>
    /// Id is an identifier of building
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// RegistNum contains information about registration number of building
    /// </summary>
    public string RegistNum { get; set; } = string.Empty;
    /// <summary>
    /// District, street and house number contain information about full address of building
    /// </summary>  
    public string District { get; set; } = string.Empty;
    public string Street { get; set; } = string.Empty;
    public int HouseNumber { get; set; }
    /// <summary>
    /// Area contains information about building area
    /// </summary>
    public int Area { get; set; }
    /// <summary>
    /// Floors contains information about number of floors of the building
    /// </summary>
    public int Floors { get; set; }
    /// <summary>
    /// DateOfBuild contains information about date of construction of the building
    /// </summary>
    public DateTime DateOfBuild { get; set; } = DateTime.MinValue;
    public List<PrivatizedBuilding>? PrivatizedBuilding { get; set; }

    public Building() { }
    public Building(int id, string registNum, string district, string street, int houseNumber, int area, int floors, DateTime dateOfBuild, List<PrivatizedBuilding> privatizedBuilding)
    {
        Id = id;
        RegistNum = registNum;
        District = district;
        Street = street;
        HouseNumber = houseNumber;
        Area = area;
        Floors = floors;
        DateOfBuild = dateOfBuild;
        PrivatizedBuilding = privatizedBuilding;
    }
    public string GetAddress()
    {
        return $"р-н {District}, ул. {Street}, {HouseNumber}";
    }
}