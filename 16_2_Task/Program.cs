using System.Text.Json;

using Task16;

StreamReader streamReader = new StreamReader("C:\\Users\\Администратор\\OneDrive\\Autodesk_ITMO_2021\\1_CSharp_Base\\N_Task\\16_Task\\16_Task\\bin\\Debug\\net6.0\\Products.json");
string json = streamReader.ReadLine();
Products[] products = JsonSerializer.Deserialize<Products[]>(json);

Products productMax = products[0];
for (int i=0; i<5; i++)
{
    if (products[i].Price > productMax.Price)
    {
        productMax = products[i];
    }   
}
Console.WriteLine(productMax.Name);

