using BankSerializer;
using BankServer.Models;
internal class Program
{
    private static void Main(string[] args)
    {
        BankSerializer.BankSerializer bankSerializer = new();

        /*        List<UserModel> users = new List<UserModel>()
                {
                    new UserModel(1, "Andrey","123"),
                    new UserModel(2, "Nastya", "123"),
                };*/

        List<InvoiceModel> users = new List<InvoiceModel>()
        {
            new InvoiceModel(new UserModel(1, "Andrey","123"), 1, "123", 100),
        };
        var str = bankSerializer.SerializeJSON<InvoiceModel>(users);
        Console.WriteLine(str);

        var list = bankSerializer.DeSerializeJSON<InvoiceModel>(str);
        foreach(var item in list)
        {
            Console.WriteLine(item.Balanse);
        }




    }
}