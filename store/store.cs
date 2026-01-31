class Store : ICanSellItem
{
    private Inventory inventory;
    private Wallet wallet;

    public Store(Inventory inventory)
    {
        this.inventory = inventory;
        wallet = new Wallet(2000);
    }

    public bool HasItemQuantity(int itemId, int quantity)
    {
        return inventory.HasItemQuantity(itemId, quantity);
    }

    public void ReceiveMoney(decimal amount)
    {
        wallet.ReceiveMoney(amount);
    }

    public void RemoveItem(int itemId, int quantity)
    {
        inventory.RemoveItem(itemId, quantity);
    }
}