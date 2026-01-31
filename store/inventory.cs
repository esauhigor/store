class InventoryItem
{
    private Item item;
    public int Quantity {get; private set;}

    public int GetId()
    {
        return item.Id;
    }
    public bool HasQuantity(int quantity)
    {
        return quantity <= Quantity;
    }
    public InventoryItem(Item item, int quantity)
    {
        this.item = item;
        Quantity = quantity;
    }

    public void RemoveItem(int quantity)
    {
        Quantity-=quantity;
    }
    
}
class Inventory
{
    private List<InventoryItem> items = new List<InventoryItem>();

    public bool HasItemQuantity(int itemId, int quantity)
    {
        foreach (var item in items)
        {
            if (item.GetId() == itemId)
            {
                if (!item.HasQuantity(quantity))
                    return false;

                return true;
            }
        }
        return false;
    }
    public bool RemoveItem(int itemId, int quantity)
    {
        foreach (var item in items)
        {
            if (item.GetId() == itemId)
            {
                item.RemoveItem(quantity);
                return true;
            }
        }
        return false;
    }
}