using System.IO;
using System.Text.Json;



Products[] products = new Products[5];
for (int i = 0; i < 5; i++)
{
    products[i] = new Products();
    Console.WriteLine("Введите код товара:");
    products[i].Code = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите наименование товара:");
    products[i].Name = Console.ReadLine();
    Console.WriteLine("Введите цену товара:");
    products[i].Price = Convert.ToInt32(Console.ReadLine());
}

string json= JsonSerializer.Serialize<Products[]>(products);
Console.WriteLine(json);
string path = "Products.json";
if (!File.Exists(path))
{
    File.Create(path);
}
StreamWriter sw = new StreamWriter(path);
{
    sw.WriteLine(json);
    sw.Close();
}
class Products
{
    
    public int Code { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    
}



