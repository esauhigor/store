class Wallet : IWallet
{
    private decimal _amount;

    public Wallet(decimal amount){
        _amount = amount;
    }

    public bool HasMoney(decimal amount)
    {
    return amount <= _amount;
    }

    public void ReceiveMoney(decimal amount)
    {
        _amount += amount;
    }

    public void SpendMoney(decimal amount)
    {
        _amount -= amount;
    }
}