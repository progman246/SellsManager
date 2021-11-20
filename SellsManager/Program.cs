// See https://aka.ms/new-console-template for more information
using Task1;
using System.Linq;

string path = @"D:\saleList.txt";
string[] txtFile = File.ReadAllLines(path);
List<Product> files = new List<Product>();
foreach (var item in txtFile)
{
    Product SampleProduct = new Product();
    string[] data=item.Split('|');
    if (data.Length > 0)
    { 
      SampleProduct .RecordNumber= Convert.ToInt32(data[0]);
       SampleProduct.ProductId= Convert.ToInt32(data[1]);
         SampleProduct.Price= Convert.ToInt32(data[2]);
          SampleProduct.Quantity= Convert.ToInt32(data[3]);
    }
    files.Add(SampleProduct);
}

//var query = files.GroupBy(x => x.ProductId).Select(x => x.Select(y => y.Quantity).Sum()).Max();
//var query = files.GroupBy(x => x.ProductId);
//var query1=query.Select(x=>x.Sum(x=>x.Quantity).max
var query = files.GroupBy(x => x.ProductId).Select(x => new { ProductId = x.Key, TotalQuantity = x.Sum(y => y.Quantity) }).OrderByDescending(x => x.TotalQuantity).First();
Console.WriteLine($"the Most Sell productId is :{query.ProductId} that TotalSells is :{query.TotalQuantity}");
var TotalPrice=files.Sum(x=>x.Price);
Console.WriteLine($"Total Price Paid for All Salles:{TotalPrice}");
int AveragrPrice = TotalPrice / files.Count();
Console.WriteLine(AveragrPrice);
var query1 = files.GroupBy(x => x.ProductId).Select(x => new { ProductId = x.Key, TotalSells = x.Sum(y => y.Quantity * y.Price) }).OrderByDescending(x=>x.TotalSells).Last();
Console.WriteLine($"cheapest Sell Product : {query1.ProductId}");
Console.WriteLine("Hello World");