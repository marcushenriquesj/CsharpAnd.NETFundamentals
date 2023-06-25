using System.Xml.Linq;

namespace LinqExcersize
{
    public class Building
    {
        public decimal Size { get; set; }
        public decimal TaxPerSize { get; set; }
        public string Name { get; set; }

    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var buildings = new List<Building>
            { 
                new Building{Size = 25.5m, TaxPerSize = 15.1m, Name= "executiveBuilding"},
                new Building{Size = 55.5m, TaxPerSize = 10.3m, Name= "OfficeSpaceBuilding"},
                new Building{Size = 23.2m, TaxPerSize = 30.1m, Name= "RandDBuilding"}

            };

            var costPerBuidling = buildings.Select(b => new
            {
                Name = b.Name,
                TaxPerSize = b.TaxPerSize,
                Size = b.Size,
                NewColumn = b.TaxPerSize * b.Size
            });

            foreach (var result in costPerBuidling)
            {
                Console.WriteLine($"Name: {result.Name}, TaxPerSize: {result.TaxPerSize}, Size: {result.Size}, NewColumn: {result.NewColumn}");
            }
        }
    }
}
