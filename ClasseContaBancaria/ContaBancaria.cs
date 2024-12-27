class ContaBancaria
{
    public int indicatorNumber;
    public string name;
    public double balance;
    public string password;

    public void ExibirContaBancaria() 
    {
        Console.WriteLine($"Nome: {name}\nSaldo: {balance}");
    }
}