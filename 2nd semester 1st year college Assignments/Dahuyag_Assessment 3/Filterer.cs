public class Filterer
{
    public static List<string> Filter()
    {
        int filterChoice = 0;
        int exitChoice = 0;
        var filters = new List<string>();
    ChooseFilter:
        Console.Clear();
        Console.WriteLine("Choose which type to add to filter view");
        Console.WriteLine("1 - Book");
        Console.WriteLine("2 - Jewelry");
        Console.WriteLine("3 - Souvenir");
        Console.WriteLine("4 - Collectible Figure");
        Console.WriteLine("5 - Footwear");
        Console.WriteLine("6 - All");
        Console.Write("Choice: ");
        filterChoice = Convert.ToInt32(Console.ReadLine());
        switch (filterChoice)
        {
            case 1:
                filters.Add("Book");
                break;
            case 2:
                filters.Add("Jewelry");
                break;
            case 3:
                filters.Add("Souvenir");
                break;
            case 4:
                filters.Add("CollectibleFigure");
                break;
            case 5:
                filters.Add("Footwear");
                break;
            case 6:
                filters = new List<string>
                {
                    "Book", "Jewelry", "Souvenir", "CollectibleFigure", "Footwear"
                };
                break;
            default:
                break;
        }
        Console.WriteLine("Would you like to add more filters?\n1 - yes\n2 - no");
        Console.Write("Choice: ");
        exitChoice = Convert.ToInt32(Console.ReadLine());
        switch (exitChoice)
        {
            case 1:
                goto ChooseFilter;
            case 2:
                break;
            default:
                break;
        }
        Console.ReadLine();
        return filters;
    }
}
