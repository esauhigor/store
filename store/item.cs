interface IUseble
{
    bool TryUse();
}
interface IEquipable
{
    bool Equip();
    bool Unequip();
}

class Item
{
    public string Name { get; private set; }
    public int Price { get; private set; }
    public int Id {get; private set; }

    public Item(string name, int price)
    {
        Name = name;
        Price = price;
    }
}


class Consumable : Item, IUseble
{
    private bool used = false;

    public Consumable(string name, int price) : base(name, price){}

    public bool TryUse()
    {
        if (used)
        {
            Console.WriteLine($"{Name}: Item já usado");
            return false;
        }

        Console.WriteLine($"{Name}: Usando item");
        used = true;

        return true;
    }
}

class Army : Item
{
    public Army(string name, int price, int damageInit, int durably) : base(name, price)
    {
        this.damageInit = damageInit;
        this.durably = durably;
    }

    public int damageInit {get; private set;}
    public int durably { get; private set;}
}

class Sword : Army, IEquipable
{
    //adionar algumas coisas como atributos de sangramento...
    private bool equip = false;
    public Sword(string name, int price, int damageInit, int durably) : base(name, price, damageInit, durably)
    {
    }

    public bool Equip()
    {
        if (equip)
        {
            Console.WriteLine($"{Name}: já equipado");
            return false;
        }
        Console.WriteLine($"Equipando a espada: {Name}");
        equip = true;
        return true;
    }

    public bool Unequip()
    {
        if (!equip)
        {
            Console.WriteLine($"{Name}: Não equipado");
            return false;
        }
        Console.WriteLine($"Desequipando a espada: {Name}");
        equip = false;
        return true;
    }
}
