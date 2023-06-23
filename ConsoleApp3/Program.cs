using System.ComponentModel.DataAnnotations;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Card myCard = new Card("5674-4937-2037-7584", 574, "02/23", "Asgar Madadli", "Kapital Bank", 500);
            myCard.Information();
        }
    }
}

class Card
{
    public string CardNumber { get; set; }
    public int CVV { get; set; }
    public string ExpDate { get; set; }
    public string OwnerFullname { get; set; }
    public string BankName { get; set; }
    public double Balance { get; set; }

    public Card(string CardNumber, int CVV, string ExpDate, string OwnerFullname, string BankName, double Balance)
    {
        this.CardNumber = CardNumber;
        this.CVV = CVV;
        this.ExpDate = ExpDate;
        this.OwnerFullname = OwnerFullname;
        this.BankName = BankName;
        this.Balance = Balance;
    }
    public void Information()
    {
        Console.WriteLine("CardNumber:" + CardNumber);
        Console.WriteLine("CVV:" + CVV);
        Console.WriteLine("ExpDate:" + ExpDate);
        Console.WriteLine("OwnerFullname:" + OwnerFullname);
        Console.WriteLine("BankName:" + BankName);
        Console.WriteLine("Balance:" + Balance);
    }



}
