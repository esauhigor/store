interface ICanProviderItems
{
    bool HasItemQuantity(int itemId, int quantity);
    void RemoveItem(int itemId, int quantity);
}
interface ICanReceiveItems
{
    void AddItem(int itemId, int quantity);
}

interface ICanSpendMoney
{
    bool HasMoney(decimal amount);
    void SpendMoney(decimal amount);
}

interface ICanReceiveMoney
{
    void ReceiveMoney(decimal amount);
}


interface ICanSellItem : ICanProviderItems, ICanReceiveMoney
{
}

interface ICanBuyItem : ICanSpendMoney, ICanReceiveItems
{
}

interface IWallet : ICanSpendMoney, ICanReceiveMoney
{
    
}