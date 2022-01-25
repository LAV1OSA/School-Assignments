public class ItemSearcher
{
    public static void Search(List<string> filters, Store storeSearched)
    {
        Console.Clear();
        Console.Write("Filters: |");
        foreach (var x in filters)
        {
            Console.Write($" {x} |");
        }
        string keyword;
        Console.Write("\nEnter a keyword to search: ");
        keyword = Console.ReadLine().ToLower();
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
            foreach (var i in storeSearched.Storage)
            {
                if (i.GetType().Name.ToLower() == filter.ToLower())
                {
                    switch (i)
                    {
                        case Book:
                            if (i.Name.ToLower().Contains(keyword) || i.ItemID.ToLower().Contains(keyword) || i.Value.ToString().ToLower().Contains(keyword))
                                Console.WriteLine($"{i,-39}");
                            break;
                        case Jewelry:
                            if (i.Name.ToLower().Contains(keyword) || i.ItemID.ToLower().Contains(keyword) || i.Value.ToString().ToLower().Contains(keyword))
                                Console.WriteLine($"{i,-39}");
                            break;
                        case Souvenir:
                            if (i.Name.ToLower().Contains(keyword) || i.ItemID.ToLower().Contains(keyword) || i.Value.ToString().ToLower().Contains(keyword))
                                Console.WriteLine($"{i,-39}");
                            break;
                        case CollectibleFigure:
                            if (i.Name.ToLower().Contains(keyword) || i.ItemID.ToLower().Contains(keyword) || i.Value.ToString().ToLower().Contains(keyword))
                                Console.WriteLine($"{i,-39}");
                            break;
                        case FootWear:
                            if (i.Name.ToLower().Contains(keyword) || i.ItemID.ToLower().Contains(keyword) || i.Value.ToString().ToLower().Contains(keyword))
                                Console.WriteLine($"{i,-39}");
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}