class SaleService
{
    public bool TrySell(
        ICanSellItem seller,
        ICanBuyItem buyer, 
        int itemId, 
        int quantity)
    {
        decimal totalPrice = -1;

        if(!seller.HasItemQuantity(itemId, quantity)) 
            return false;

        if(!buyer.HasMoney(totalPrice))
            return false;

        //criar um novo if pra calcular total

        //MONEY
        buyer.SpendMoney(totalPrice);
        seller.ReceiveMoney(totalPrice);

        //ITEM
        seller.RemoveItem(itemId, quantity);
        buyer.AddItem(itemId, quantity);


        return true;
    }
}