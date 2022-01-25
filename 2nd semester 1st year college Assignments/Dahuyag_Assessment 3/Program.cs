global using System.Text;

var cabinet = new Cabinet(6, 4);
var cabinet2 = new Cabinet(1, 3);
var per1 = new Person("Kitagawa", Gender.Female, 300000, cabinet);

var jewel1 = new Jewelry("ring", "123FGH", Rarity.Rare, JewelryMaterialType.Gold);
var jewel2 = new Jewelry("necklace", "572HRD", Rarity.Common, JewelryMaterialType.Bronze);
var jewel3 = new Jewelry("ring", "920MAS", Rarity.Unique, JewelryMaterialType.Gold);
var jewel4 = new Jewelry("earring", "385YUF", Rarity.Rare, JewelryMaterialType.Silver);
var jewel5 = new Jewelry("bracelet", "284PCZ", Rarity.Rare, JewelryMaterialType.Bronze);
var book1 = new Book("scifi", "726HGJ", "Lord of the Rings", "J. R. R. Tolkien",415);
var book2 = new Book("horror", "831BGB", "The Haunting of Hill House", " Shirley Jackson", 246);
var book3 = new Book("comedy", "962NTS", "A Confederacy of Dunces", "John Kennedy Toole", 405);
var book4 = new Book("romance", "100TAD", "People We Meet on Vacation", "Emily Henry", 361);
var book5 = new Book("educational", "865NFD", "The Coddling of the American Mind", "Greg Lukianoff & Jonathan Haidt", 500);
var souvenir1 = new Souvenir("keychain", "1J5D7G", "Master", SouvenirMaterialType.Plastic, "Japan");
var souvenir2 = new Souvenir("stamp", "7Q5GF5", "Original", SouvenirMaterialType.Steel, "Paris");
var souvenir3 = new Souvenir("bookmark", "9SGY34", "Signed", SouvenirMaterialType.Plastic, "Rome");
var souvenir4 = new Souvenir("fridge magnet", "27G4JS", "Limited", SouvenirMaterialType.Wood, "India");
var souvenir5 = new Souvenir("T-shirt", "NQX37F", "Silk", SouvenirMaterialType.Steel, "Singapore");
var collectible1 = new CollectibleFigure("Nami", "61MU24", "One Piece", 1000, Rarity.Rare, Condition.Good);
var collectible2 = new CollectibleFigure("Darth Vader", "72MLP4", "Stara Wars", 2500, Rarity.Common, Condition.Bad);
var collectible3 = new CollectibleFigure("Tanjiro", "1LASU4", "Demon Slayer", 1250, Rarity.Common, Condition.Best);
var collectible4 = new CollectibleFigure("Batman", "M37H23", "Batman", 7500, Rarity.Unique, Condition.Worst);
var collectible5 = new CollectibleFigure("Thor", "MYTH23", "Thor", 10000, Rarity.Rare, Condition.Fine);
var footWear1 = new FootWear("Addidas", "PODBA6", 2000, 9, FootWearType.Shoes);
var footWear2 = new FootWear("Bata", "9124PS", 1350, 6, FootWearType.Sandals);
var footWear3 = new FootWear("Hunter", "BYDRFA", 1780, 9, FootWearType.Boots);
var footWear4 = new FootWear("Crocs", "7DFY3F", 600, 9, FootWearType.Slippers);
var footWear5 = new FootWear("Nike", "NMAE43", 5000, 8, FootWearType.Shoes);

var defaultBooks = new List<Thing>
{
    book1, book2, book3, book4, book5
};
var defaultJewelries = new List<Thing>
{
    jewel1, jewel2, jewel3, jewel4, jewel5
};
var defaultSouvenirs = new List<Thing>
{
    souvenir1, souvenir2, souvenir3, souvenir4, souvenir5
};
var defaultCollectibles = new List<Thing>
{
    collectible1, collectible2, collectible3, collectible4, collectible5
};
var defaultFootWears = new List<Thing>
{
    footWear1, footWear2, footWear3, footWear4, footWear5
};
var defaultThings = new List<Thing>();
defaultThings.AddRange(defaultBooks);
defaultThings.AddRange(defaultJewelries);
defaultThings.AddRange(defaultSouvenirs);
defaultThings.AddRange(defaultCollectibles);
defaultThings.AddRange(defaultFootWears);
var store = new Store(new List<Thing>(defaultThings));
var ongoingFilters = new List<string>() { "Book", "Jewelry", "Souvenir", "CollectibleFigure", "Footwear" };
DefaultPrint:
Console.Write("Would you like to print the default items? \n1 - yes\n2 - no\nChoice: ");
int defaultPrintChoice = Convert.ToInt32(Console.ReadLine());
switch (defaultPrintChoice)
{
    case 1:
        for (int count = 0; count < defaultThings.Count() - 1; count++)
        {
            switch (defaultThings.ElementAt(count))
            {
                case Book:
                    if (count == 0)
                    {
                        Console.WriteLine($"{"\n             --- Books ---"}");
                        Console.WriteLine($"{"|      Name",-16} {"|  Price",-10} {"| Item ID |",-9}");
                    }
                    Console.WriteLine($"{defaultThings.ElementAt(count),-39}");
                    break;
                case Jewelry:
                    if (count == defaultBooks.Count())
                    {
                        Console.WriteLine($"{"\n           --- Jewelries ---"}");
                        Console.WriteLine($"{"|      Name",-16} {"|  Price",-10} {"| Item ID |",-9}");
                    }
                    Console.WriteLine($"{defaultThings.ElementAt(count),-39}");
                    break;
                case Souvenir:
                    if (count == defaultJewelries.Count() + defaultBooks.Count())
                    {
                        Console.WriteLine($"{"\n           --- Souvenirs ---"}");
                        Console.WriteLine($"{"|      Name",-16} {"|  Price",-10} {"| Item ID |",-9}");
                    }
                    Console.WriteLine($"{defaultThings.ElementAt(count),-39}");
                    break;
                case CollectibleFigure:
                    if (count == defaultSouvenirs.Count() + defaultJewelries.Count() + defaultBooks.Count())
                    {
                        Console.WriteLine($"{"\n     --- Collectible Figures ---"}");
                        Console.WriteLine($"{"|      Name",-16} {"|  Price",-10} {"| Item ID |",-9}");
                    }
                    Console.WriteLine($"{defaultThings.ElementAt(count),-39}");
                    break;
                case FootWear:
                    if (count == defaultCollectibles.Count() + defaultSouvenirs.Count() + defaultJewelries.Count() + defaultBooks.Count())
                    {
                        Console.WriteLine($"{"\n          --- Foot Wear ---"}");
                        Console.WriteLine($"{"|      Name",-16} {"|  Price",-10} {"| Item ID |",-9}");
                    }
                    Console.WriteLine($"{defaultThings.ElementAt(count),-39}");
                    break;
                default:
                    break;
            }
        }
        break;
    case 2:
        break;
    default:
        goto DefaultPrint;
}
Console.ReadLine();
Functions:
Console.Clear();
Console.WriteLine("Select a Function:");
Console.WriteLine("1 - Print all things");
Console.WriteLine("2 - Add a thing");
Console.WriteLine("3 - Search for a thing");
Console.WriteLine("4 - Filter");
Console.WriteLine("5 - Exit");
Console.WriteLine("Choice: ");
int functionChoice = Convert.ToInt32(Console.ReadLine());
switch (functionChoice)
{
    case 1:
        store.Display();
        Console.ReadLine();
        break;
    case 2:
        store.Display();
        Console.Clear();
        ThingAdder.AdderFunction(store);
        Console.ReadLine();
        goto Functions;
    case 3:
        ItemSearcher.Search(ongoingFilters, store);
        Console.ReadLine();
        goto Functions;
    case 4:
        ongoingFilters = store.Display(Filterer.Filter());
        Console.ReadLine();
        goto Functions;
    case 5:
        goto Exit;
    default:
        break;
}
goto Functions;
Exit:
Console.WriteLine("Thank you for using the program!");
Console.ReadLine();
public enum Gender
{
    Male,
    Female
}
public enum SouvenirMaterialType
{
    Wood = 1,
    Plastic,
    Steel
}
public enum JewelryMaterialType
{
    Bronze = 1,
    Silver,
    Gold
}

public enum Rarity
{
    Common = 1,
    Rare,
    Unique
}
public enum FootWearType
{
    Shoes = 1,
    Slippers,
    Boots,
    Sandals
}
public enum Condition
{
    Worst = 1,
    Bad,
    Fine,
    Good,
    Best
}
