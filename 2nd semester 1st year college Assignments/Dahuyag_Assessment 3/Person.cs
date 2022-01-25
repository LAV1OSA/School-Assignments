public class Person
{
    private string _name;
    private Gender _gender;
    private float _money;
    private List<Cabinet> _cabinets;
    private List<Thing> _boughtItems;
    private int _remainingCabinetCapacity;

    public string Name { get => _name; set => _name = value; }
    public Gender Gender { get => _gender; set => _gender = value; }
    public float Money { get => _money; set => _money = value; }
    public List<Cabinet> Cabinets{ get => _cabinets; set => _cabinets = value; }
    public List<Thing> BoughtItems{ get => _boughtItems; set => _boughtItems = value; }
    public int RemainingCabinetCapacity 
    {
        get
        {
            _remainingCabinetCapacity = 0;
            foreach (var cabinet in Cabinets)
            {
                _remainingCabinetCapacity += cabinet.RemainingCapacity;
            }
            return _remainingCabinetCapacity;
        }
        private set => _remainingCabinetCapacity = value; 
    } 
    public Person(string name, Gender gender, float money)
    {
        _name = name;
        _gender = gender;
        _money = money;
        _cabinets = new List<Cabinet>();
        _boughtItems = new List<Thing>();
    }
    public Person(string name, 
                  Gender gender, 
                  float money,
                  Cabinet cabinet)
        :this(name, gender, money)
    {
        Cabinets.Add(cabinet);
        _remainingCabinetCapacity += cabinet.RemainingCapacity;
    }

    public void Buy(Thing thingBought, Store store)
    {
        if (thingBought.Value > _money)
            throw new InvalidOperationException("You don't have enough money");
        if (RemainingCabinetCapacity <= 0)
            throw new InvalidOperationException("You don't have enough space");
        foreach (var cabinet in Cabinets)
        {
            if (cabinet.RemainingCapacity == 0)
                continue;
            cabinet.RemainingCapacity -= 1;
            cabinet.Things.Add(thingBought);
            break;
        }
        _money -= thingBought.Value;
        _boughtItems.Add(thingBought);
        store.Storage.Remove(thingBought);
    }
    public void Sell(Thing thingToSell, Store store)
    {
        if (!_boughtItems.Contains(thingToSell))
            throw new InvalidOperationException("You don't own this item");
        foreach (var cabinet in Cabinets)
        {
            if (cabinet.Things.Contains(thingToSell))
            {
                cabinet.Things.Remove(thingToSell);
                cabinet.RemainingCapacity += 1;
                break;
            }
            continue;
        }
        _money += thingToSell.Value * 0.6f;
        _boughtItems.Remove(thingToSell);
        store.Storage.Add(thingToSell);
    }
    public void SellCabinet(Cabinet cabinetToSell, Store store)
    {
        if(!Cabinets.Contains(cabinetToSell))
            throw new InvalidOperationException("You don't own this cabinet");
        _money += cabinetToSell.Value * 0.6f;
        foreach (var item in cabinetToSell.Things)
        {
            _money += item.Value * 0.6f;
            _boughtItems.Remove(item);
            store.Storage.Add(item);
        }
        cabinetToSell.Things.Clear();
    }
}
