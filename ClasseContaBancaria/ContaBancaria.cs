class ContaBancaria
{
    public int IndicatorNumber { get; set; }
    public string Name { get; set; }
    public double Balance { get; set; }
    public string Password { get; set; }

    public void ExibirContaBancaria() 
    {
        Console.WriteLine($"Nome: {Name}\nSaldo: {Balance}");
    }
}