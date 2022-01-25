public class ThingAdder
{
    public static void AdderFunction(Store storeTo)
    {
        string name;
        string itemID;

        Console.WriteLine("What type of item would you like to add?");
        Console.WriteLine("1 - Book");
        Console.WriteLine("2 - Jewelry");
        Console.WriteLine("3 - Souvenir");
        Console.WriteLine("4 - Collectible Figure");
        Console.WriteLine("5 - Footwear");
        Console.Write("Choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.Write("Enter the name of the book: ");
                name = Console.ReadLine();
                Console.Write("Enter the item ID of the book: ");
                itemID = Console.ReadLine();
                Console.Write("Enter the title of the book: ");
                string title = Console.ReadLine();
                Console.Write("Enter the author of the book: ");
                string author = Console.ReadLine();
                Console.Write("Enter the number of pages of the book: ");
                int numberOfPages = Convert.ToInt32(Console.ReadLine());
                if (name == null || itemID == null || title == null || author == null || numberOfPages == 0)
                {
                    Console.WriteLine("Please enter a proper value in each input");
                    Console.WriteLine("Press enter to return to function selection screen");
                    Console.ReadLine();
                    break;
                }
                if (Thing.IdList.Contains(itemID))
                {
                    Console.WriteLine("Item ID already exists");
                    Console.WriteLine("Press enter to return to function selection screen");
                    Console.ReadLine();
                    break;
                }
                storeTo.Storage.Insert(storeTo.bookQuantity, AddThing(name, itemID, title, author, numberOfPages)) ;
                Console.WriteLine("Book added successfully");
                break;
            case 2:
                Console.Write("Enter the name of the jewelry: ");
                name = Console.ReadLine();
                Console.Write("Enter the item ID of the jewelry: ");
                itemID = Console.ReadLine();
                Console.Write("Enter the rarity of the jewelry: \n1 - Common \n2 - Rare \n3 - Unique\nChoice:");
                Rarity rarity = (Rarity)Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the material type of the jewelry: \n1 - Bronze \n2 - Silver \n3 - Gold\nChoice:");
                JewelryMaterialType materialType = (JewelryMaterialType)Convert.ToInt32(Console.ReadLine());
                if (name == null || itemID == null || rarity == 0 || materialType == 0)
                {
                    Console.WriteLine("Please enter a proper value in each input");
                    Console.WriteLine("Press enter to return to function selection screen");
                    Console.ReadLine();
                    break;
                }
                if (Thing.IdList.Contains(itemID))
                {
                    Console.WriteLine("Item ID already exists");
                    Console.WriteLine("Press enter to return to function selection screen");
                    Console.ReadLine();
                    break;
                }
                storeTo.Storage.Insert(storeTo.bookQuantity + storeTo.jewelryQuantity, AddThing(name, itemID, rarity, materialType));
                Console.WriteLine("Jewelry added successfully");
                break;
            case 3:
                Console.Write("Enter the name of the souvenir: ");
                name = Console.ReadLine();
                Console.Write("Enter the item ID of the souvenir: ");
                itemID = Console.ReadLine();
                Console.Write("Enter the model of the souvenir: ");
                string model = Console.ReadLine();
                Console.Write("Enter the country of origin of the souvenir: ");
                string countryOfOrigin = Console.ReadLine();
                Console.Write("Enter the material type of the souvenir: \n1 - Wood \n2 - Plastic \n3 - Steel\nChoice:");
                SouvenirMaterialType souvenirMaterialType = (SouvenirMaterialType)Convert.ToInt32(Console.ReadLine());
                if (name == null || itemID == null || model == null ||countryOfOrigin == null || souvenirMaterialType == 0)
                {
                    Console.WriteLine("Please enter a proper value in each input");
                    Console.WriteLine("Press enter to return to function selection screen");
                    Console.ReadLine();
                    break;
                }
                if (Thing.IdList.Contains(itemID))
                {
                    Console.WriteLine("Item ID already exists");
                    Console.WriteLine("Press enter to return to function selection screen");
                    Console.ReadLine();
                    break;
                }
                storeTo.Storage.Insert(storeTo.bookQuantity + storeTo.jewelryQuantity + storeTo.souvenirQuantity, AddThing(name, itemID, model, souvenirMaterialType, countryOfOrigin));
                Console.WriteLine("Souvenir added successfully");
                break;
            case 4:
                Console.Write("Enter the name of the collectible figure: ");
                name = Console.ReadLine();
                Console.Write("Enter the item ID of the collectible figure: ");
                itemID = Console.ReadLine();
                Console.Write("Enter the franchise of the collectible figure: ");
                string franchise = Console.ReadLine();
                Console.Write("Enter the original price of the collectible figure: ");
                float originalPrice = (float)Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the rarity of the collectible: \n1 - Common \n2 - Rare \n3 - Unique\nChoice:");
                Rarity figureRarity = (Rarity)Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the condition of the souvenir: \n1 - Worst \n2 - Bad \n3 - Fine\n4 - Good\n5 - Best\nChoice:");
                Condition condition = (Condition)Convert.ToInt32(Console.ReadLine());
                if (name == null || itemID == null || franchise == null || originalPrice == 0 || figureRarity == 0 || condition == 0)
                {
                    Console.WriteLine("Please enter a proper value in each input");
                    Console.WriteLine("Press enter to return to function selection screen");
                    Console.ReadLine();
                    break;
                }
                if (Thing.IdList.Contains(itemID))
                {
                    Console.WriteLine("Item ID already exists");
                    Console.WriteLine("Press enter to return to function selection screen");
                    Console.ReadLine();
                    break;
                }
                storeTo.Storage.Insert(storeTo.bookQuantity + storeTo.jewelryQuantity + storeTo.souvenirQuantity + storeTo.collectibleFigureQuantity, AddThing(name, itemID, franchise, originalPrice, figureRarity, condition));
                Console.WriteLine("Collectible figure added successfully");
                break;
            case 5:
                Console.Write("Enter the name of the footwear: ");
                name = Console.ReadLine();
                Console.Write("Enter the item ID of the footwear: ");
                itemID = Console.ReadLine();
                Console.Write("Enter the original price of the footwear: ");
                float footWearOriginalPrice = (float)Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the size of the footwear: ");
                float size = (float)Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the type of the footwear: ");
                FootWearType footWearType = (FootWearType)Convert.ToInt32(Console.ReadLine());

                if (name == null || itemID == null || footWearOriginalPrice == 0 || size == 0 || footWearType == 0)
                {
                    Console.WriteLine("Please enter a proper value in each input");
                    Console.WriteLine("Press enter to return to function selection screen");
                    Console.ReadLine();
                    break;
                }
                if (Thing.IdList.Contains(itemID))
                {
                    Console.WriteLine("Item ID already exists");
                    Console.WriteLine("Press enter to return to function selection screen");
                    Console.ReadLine();
                    break;
                }
                storeTo.Storage.Insert(storeTo.bookQuantity + storeTo.jewelryQuantity + storeTo.souvenirQuantity + storeTo.collectibleFigureQuantity + storeTo.footWearQuantity, AddThing(name, itemID, footWearOriginalPrice, size, footWearType));
                Console.WriteLine("Footwear added successfully");
                break;
            default:
                break;
        }
        
    }
    public static Book AddThing(string name,
                         string itemId,
                         string title,
                         string author,
                         int numberOfPages)
    {
        return new Book(name,itemId,title,author,numberOfPages);
    }
    public static Jewelry AddThing(string name,
                                   string itemId,
                                   Rarity rarity,
                                   JewelryMaterialType materialType)
    {
        return new Jewelry(name, itemId, rarity, materialType);
    }
    public static Souvenir AddThing(string name,
                                   string itemId,
                                   string model,
                                   SouvenirMaterialType materialType,
                                   string countryOfOrigin)
    {
        return new Souvenir(name, itemId, model, materialType, countryOfOrigin);
    }
    public static CollectibleFigure AddThing(string name,
                                  string itemId,
                                  string franchise,
                                  float originalPrice,
                                  Rarity rarity,
                                  Condition condition)
    {
        return new CollectibleFigure(name, itemId, franchise, originalPrice, rarity, condition);
    }
    public static FootWear AddThing(string name,
                                  string itemId,
                                  float originalPrice,
                                  float size,
                                  FootWearType type)
    {
        return new FootWear(name, itemId, originalPrice, size, type);
    }
}
