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

var query = files.GroupBy(x => x.ProductId).Select(x=> x.Sum(y=>y.Quantity)).Max(); 
      
            

    //foreach(var item in query)
    Console.WriteLine(query);