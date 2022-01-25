public class Store
{
    private List<Thing> _storage;
    public int bookQuantity = 0;
    public int jewelryQuantity = 0;
    public int souvenirQuantity = 0;
    public int collectibleFigureQuantity = 0;
    public int footWearQuantity = 0;
    public List<Thing> Storage { get => _storage; set => _storage = value; }
    public Store() 
    {
        _storage = new List<Thing>();
    }
    public Store(List<Thing> thingsToStore) : this()
    {
        foreach (Thing thing in thingsToStore)
            _storage.Add(thing);
    }
    public void Display()
    {
        bookQuantity = 0;
        jewelryQuantity = 0;
        souvenirQuantity = 0;
        collectibleFigureQuantity = 0;
        footWearQuantity = 0;
        int internalCount = 0;
        foreach (var i in _storage)
        {
            switch (i)
            {
                case Book:
                    bookQuantity += 1;
                    break;
                case Jewelry:
                    jewelryQuantity += 1;
                    break;
                case Souvenir:
                    souvenirQuantity += 1;
                    break;
                case CollectibleFigure:
                    collectibleFigureQuantity += 1;
                    break;
                case FootWear:
                    footWearQuantity += 1;
                    break;
                default:
                    break;
            }
        }
        foreach (var i in _storage)
        {
            switch (i)
            {
                case Book:
                    if (internalCount == 0)
                    {
                        Console.WriteLine($"{"\n             --- Books ---"}");
                        Console.WriteLine($"{"|      Name",-16} {"|  Price",-10} {"| Item ID |",-9}");
                    }
                    Console.WriteLine($"{i, -39}");
                    internalCount++;
                    break;
                case Jewelry:
                    if (internalCount == bookQuantity)
                    {
                        Console.WriteLine($"{"\n           --- Jewelries ---"}");
                        Console.WriteLine($"{"|      Name",-16} {"|  Price",-10} {"| Item ID |",-9}");
                    }
                    Console.WriteLine($"{i, -39}");
                    internalCount++;
                    break;
                case Souvenir:
                    if (internalCount == jewelryQuantity + bookQuantity)
                    {
                        Console.WriteLine($"{"\n           --- Souvenirs ---"}");
                        Console.WriteLine($"{"|      Name",-16} {"|  Price",-10} {"| Item ID |",-9}");
                    }
                    Console.WriteLine($"{i, -39}");
                    internalCount++;
                    break;
                case CollectibleFigure:
                    if (internalCount == souvenirQuantity + jewelryQuantity + bookQuantity)
                    {
                        Console.WriteLine($"{"\n     --- Collectible Figures ---"}");
                        Console.WriteLine($"{"|      Name",-16} {"|  Price",-10} {"| Item ID |",-9}");
                    }
                    Console.WriteLine($"{i, -39}");
                    internalCount++;
                    break;
                case FootWear:
                    if (internalCount == collectibleFigureQuantity + souvenirQuantity + jewelryQuantity + bookQuantity)
                    {
                        Console.WriteLine($"{"\n          --- Foot Wear ---"}");
                        Console.WriteLine($"{"|      Name",-16} {"|  Price",-10} {"| Item ID |",-9}");
                    }
                    Console.WriteLine($"{i, -39}");
                    internalCount++;
                    break;
                default:
                    break;
            }
        }
    }
    public List<string> Display(List<string> filters)
    {
        bookQuantity = 0;
        jewelryQuantity = 0;
        souvenirQuantity = 0;
        collectibleFigureQuantity = 0;
        footWearQuantity = 0;
        foreach (var i in _storage)
        {
            switch (i)
            {
                case Book:
                    bookQuantity += 1;
                    break;
                case Jewelry:
                    jewelryQuantity += 1;
                    break;
                case Souvenir:
                    souvenirQuantity += 1;
                    break;
                case CollectibleFigure:
                    collectibleFigureQuantity += 1;
                    break;
                case FootWear:
                    footWearQuantity += 1;
                    break;
                default:
                    break;
            }
        }
        foreach (var filter in filters)
        {
            switch (filter.ToLower())
            {
                case "book":
                    Console.WriteLine($"{"\n             --- Books ---"}");
                    Console.WriteLine($"{"|      Name",-16} {"|  Price",-10} {"| Item ID |",-9}");
                    break;
                case "jewelry":
                    Console.WriteLine($"{"\n           --- Jewelries ---"}");
                    Console.WriteLine($"{"|      Name",-16} {"|  Price",-10} {"| Item ID |",-9}");
                    break;
                case "souvenir":
                    Console.WriteLine($"{"\n           --- Souvenirs ---"}");
                    Console.WriteLine($"{"|      Name",-16} {"|  Price",-10} {"| Item ID |",-9}");
                    break;
                case "collectiblefigure":
                    Console.WriteLine($"{"\n     --- Collectible Figures ---"}");
                    Console.WriteLine($"{"|      Name",-16} {"|  Price",-10} {"| Item ID |",-9}");
                    break;
                case "footwear":
                    Console.WriteLine($"{"\n          --- Foot Wear ---"}");
                    Console.WriteLine($"{"|      Name",-16} {"|  Price",-10} {"| Item ID |",-9}");
                    break;
                default:
                    break;
            }
            foreach (var i in _storage)
            {
                if (i.GetType().Name.ToLower() == filter.ToLower())
                {
                    switch (i)
                    {
                        case Book:
                            Console.WriteLine($"{i,-39}");
                            break;
                        case Jewelry:
                            Console.WriteLine($"{i,-39}");
                            break;
                        case Souvenir:
                            Console.WriteLine($"{i,-39}");
                            break;
                        case CollectibleFigure:
                            Console.WriteLine($"{i,-39}");
                            break;
                        case FootWear:
                            Console.WriteLine($"{i,-39}");
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        return filters;
    }
    public void Search()
    {

    }
}
