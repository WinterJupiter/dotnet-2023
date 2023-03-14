using PonrfDomain;

namespace PonrfTests;
public class PonrfFixture
{
    /// <summary>
    /// List of customers for testing
    /// </summary>
    public List<Customer> CustomersFixture
    {
        get
        {
            var customers = new List<Customer>()
            {
                new Customer(1, "Раскольникова С. М.", "пр. Чехова, 94"),
                new Customer(2, "Рудаков Р. Р.", "пр. Гагарина, 7"),
                new Customer(3, "Каневский Л. С.", "пер. Будапештсткий, 35"),
                new Customer(4, "Саламандрова А. А.", "пр. Ленина, 68"),
                new Customer(5, "Морская Н. П.", "спуск Ломоносова, 16"),
                new Customer(6, "Турец И. П.", "пл. Славы, 44"),
            };
            return customers;
        }
    }
    /// <summary>
    /// List of buildings for testing
    /// </summary>
    public List<Building> BuildingsFixture
    {
        get
        {
            var buildings = new List<Building>()
            {
                new Building(1, "Кировский", "Домодедовская", 76, 120, 2, DateTime.Parse("2001-09-05"), new List<Lot>{ new Lot(1, 1) }),
                new Building(2, "Кировский", "Домодедовская", 1, 75, 1, DateTime.Parse("2003-10-16"), new List<Lot>{ new Lot(1, 2) }),
                new Building(3, "Самарский", "Самарская", 42, 235, 3, DateTime.MinValue, new List<Lot>{ new Lot(1, 3), new Lot(3, 3) }),
                new Building(4, "Железнодорожный", "Гоголя", 53, 68, 1, DateTime.Parse("2018-02-09"), new List < Lot > { new Lot(3, 4) }),
                new Building(5, "Промышленный", "Гагарина", 7, 2100, 5, DateTime.Parse("2018-02-09"), new List < Lot > { new Lot(2, 5) }),
                new Building(6, "Железнодорожный", "Студенческий", 12, 540, 3, DateTime.Parse("1997-10-30"), new List < Lot > { new Lot(2, 6) }),
            };
            return buildings;
        }
    }
    /// <summary>
    /// List of auctions for testing
    /// </summary>
    public List<Auction> AuctionsFixture
    {
        get
        {
            var auctions = new List<Auction>()
            {
                new Auction(1, DateTime.Parse("2023-02-02"),"Аргентум", new List<Lot>
                {
                    new Lot(1, 1),
                    new Lot(1, 2),
                    new Lot(1, 3) }),
                new Auction(2, DateTime.Parse("2022-09-11"),"Сириус", new List<Lot>
                {
                    new Lot(2, 6),
                    new Lot(2, 5) }),
                new Auction(3, DateTime.Parse("2023-03-03"),"Вечность", new List<Lot>
                {
                    new Lot(3, 3),
                    new Lot(3, 4) })
            };
            return auctions;
        }
    }
    /// <summary>
    /// List of privatized buildings for testing
    /// </summary>
    public List<PrivatizedBuilding> PrivatizedBuildingsFixture
    {
        get
        {
            var customers = CustomersFixture;
            var buildings = BuildingsFixture;
            var auctions = AuctionsFixture;
            var privatizedBuildings = new List<PrivatizedBuilding>()
            {
                new PrivatizedBuilding(1, DateTime.Parse("2023-02-02"), 100000, 300000, customers[0], auctions[0], buildings[0]),
                new PrivatizedBuilding(2, DateTime.Parse("2003-02-02"), 400000, 750000, customers[1], auctions[0], buildings[1]),
                new PrivatizedBuilding(3, DateTime.Parse("2023-03-04"), 560000, 640000, customers[1], auctions[2], buildings[3]),
                new PrivatizedBuilding(4, DateTime.Parse("2023-03-03"), 600000, 650000, customers[2], auctions[2], buildings[2]),
                new PrivatizedBuilding(5, DateTime.Parse("2023-09-11"), 303000, 708000, customers[3], auctions[1], buildings[5]),
                new PrivatizedBuilding(6, DateTime.Parse("2023-09-11"), 3100000, 6700000, customers[5], auctions[1], buildings[4]),
            };
            return privatizedBuildings;
        }
    }
}