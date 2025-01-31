﻿using PonrfDomain;

namespace PonrfServer.Repository;
/// <summary>
/// PonrfRepository contains all data
/// </summary>
public class PonrfRepository : IPonrfRepository
{
    private readonly List<Customer> _customers;
    private readonly List<Building> _buildings;
    private readonly List<Auction> _auctions;
    private readonly List<PrivatizedBuilding> _privatizedBuildings;

    /// <summary>
    /// Constructor for PonrfRepository
    /// </summary>
    public PonrfRepository()
    {
        _customers = new List<Customer>()
        {
            new Customer(){Id = 1, Passport = "23 47 345689", Fio = "Раскольникова С. М.", Address = "пр. Чехова, 94"},
            new Customer(){Id = 2, Passport = "67 56 123456", Fio = "Рудаков Р. Р.", Address = "пр. Гагарина, 7"},
            new Customer(){Id = 3, Passport = "21 47 867535", Fio = "Каневский Л. С.", Address = "пер. Будапештсткий, 35"},
            new Customer(){Id = 4, Passport = "23 42 345123", Fio = "Саламандрова А. А.", Address = "пр. Ленина, 68"},
            new Customer(){Id = 5, Passport = "23 45 340987", Fio = "Морская Н. П.", Address = "спуск Ломоносова, 16"},
            new Customer(){Id = 6, Passport = "98 47 345689", Fio = "Турец И. П.", Address = "пл. Славы, 44"},
        };

        _buildings = new List<Building>()
        {
            new Building(){Id = 1, RegistNum = "30:45:423298:13", District = "Кировский", Street = "Домодедовская", HouseNumber = 76, Area = 120, Floors = 2, DateOfBuild = DateTime.Parse("2001-09-05")},
            new Building(){Id = 2, RegistNum = "30:67:345783:14", District = "Кировский", Street = "Домодедовская", HouseNumber = 1, Area = 75, Floors = 1, DateOfBuild = DateTime.Parse("2003-10-16")},
            new Building(){Id = 3, RegistNum = "67:45:423298:15", District = "Самарский", Street = "Самарская", HouseNumber = 42, Area = 235, Floors = 3, DateOfBuild = DateTime.MinValue},
            new Building(){Id = 4, RegistNum = "45:46:123096:16", District = "Железнодорожный", Street = "Гоголя", HouseNumber = 53, Area = 68, Floors = 1, DateOfBuild = DateTime.Parse("2018-02-09")},
            new Building(){Id = 5, RegistNum = "98:34:345678:17", District = "Промышленный", Street = "Гагарина", HouseNumber = 7, Area = 2100, Floors = 5, DateOfBuild = DateTime.Parse("2018-02-09")},
            new Building(){Id = 6, RegistNum = "45:23:423298:18", District = "Железнодорожный", Street = "Студенческий", HouseNumber = 12, Area = 540, Floors = 3, DateOfBuild = DateTime.Parse("1997-10-30")},
        };

        _auctions = new List<Auction>()
        {
            new Auction(){Id = 1,Date = DateTime.Parse("2023-02-02"), Organizer = "Аргентум"},
            new Auction(){Id = 2, Date = DateTime.Parse("2022-09-11"), Organizer = "Сириус"},
            new Auction(){Id = 3, Date = DateTime.Parse("2023-03-03"), Organizer = "Вечность"},
        };

        _privatizedBuildings = new List<PrivatizedBuilding>()
        {
            new PrivatizedBuilding(){Id = 1, DateOfSale = DateTime.Parse("2023-02-02"), FirstCost = 100000, SecondCost = 300000, CustomerId = 1, AuctionId = 1, BuildingId = 1},
            new PrivatizedBuilding(){Id = 2, FirstCost =  178000, SecondCost = 0, CustomerId = null, AuctionId = 1, BuildingId = 3},
            new PrivatizedBuilding(){Id = 3, DateOfSale = DateTime.Parse("2003-02-02"), FirstCost = 400000, SecondCost = 750000, CustomerId = 2, AuctionId = 1, BuildingId = 2},
            new PrivatizedBuilding(){Id = 4, DateOfSale = DateTime.Parse("2023-03-04"), FirstCost = 560000, SecondCost = 640000, CustomerId = 2, AuctionId = 3, BuildingId = 4},
            new PrivatizedBuilding(){Id = 5, DateOfSale = DateTime.Parse("2023-03-03"), FirstCost = 600000, SecondCost = 650000, CustomerId = 3, AuctionId = 3, BuildingId = 3},
            new PrivatizedBuilding(){Id = 6, DateOfSale = DateTime.Parse("2023-09-11"), FirstCost = 303000, SecondCost = 708000, CustomerId = 4, AuctionId = 2, BuildingId = 6},
            new PrivatizedBuilding(){Id = 7, DateOfSale = DateTime.Parse("2023-09-11"), FirstCost = 3100000, SecondCost = 6700000, CustomerId = 5, AuctionId = 2, BuildingId = 5},
        };

        _auctions[0].PrivatizedBuilding?.Add(_privatizedBuildings[0]);
        _auctions[0].PrivatizedBuilding?.Add(_privatizedBuildings[1]);
        _auctions[0].PrivatizedBuilding?.Add(_privatizedBuildings[2]);
        _auctions[1].PrivatizedBuilding?.Add(_privatizedBuildings[3]);
        _auctions[1].PrivatizedBuilding?.Add(_privatizedBuildings[4]);
        _auctions[2].PrivatizedBuilding?.Add(_privatizedBuildings[5]);
        _auctions[2].PrivatizedBuilding?.Add(_privatizedBuildings[6]);

        _buildings[0].PrivatizedBuilding?.Add(_privatizedBuildings[0]);
        _buildings[2].PrivatizedBuilding?.Add(_privatizedBuildings[1]);
        _buildings[1].PrivatizedBuilding?.Add(_privatizedBuildings[2]);
        _buildings[2].PrivatizedBuilding?.Add(_privatizedBuildings[5]);
        _buildings[3].PrivatizedBuilding?.Add(_privatizedBuildings[6]);
        _buildings[4].PrivatizedBuilding?.Add(_privatizedBuildings[4]);
        _buildings[5].PrivatizedBuilding?.Add(_privatizedBuildings[3]);
    }
    /// <summary>
    /// List of all customers with data
    /// </summary>
    public List<Customer> Customers => _customers;
    /// <summary>
    /// List of all buildings with data
    /// </summary>
    public List<Building> Buildings => _buildings;
    /// <summary>
    /// List of all auctions with data
    /// </summary>
    public List<Auction> Auctions => _auctions;
    /// <summary>
    /// List of all privatized buildings with data
    /// </summary>
    public List<PrivatizedBuilding> PrivatizedBuildings => _privatizedBuildings;
}