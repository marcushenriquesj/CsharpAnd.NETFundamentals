namespace RouteSmartTruckQuestion
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Package> packages = new List<Package> {
                new Package(1, 1, 1, 1),
                new Package(2, 1, 1, 1),
                new Package(3, 1, 1, 1),
                new Package(4, 1, 1, 1),
                new Package(5, 5, 5, 5),
                new Package(6, 1, 1, 1),
            };
            Truck truck = new Truck(1, 10, 99);

            PrintLabels(packages, truck);
        }

        static void PrintLabels(List<Package> pks, Truck truck)
        {
            var packages = pks.OrderBy(s => s.Sequence);
            foreach (Package package in packages)
            {
                decimal CurrentPackageVolume = package.PackageVolumne();
                var avaiableSection = truck.Sections
                    .Where(s => Convert.ToInt32(s.ShelfId) >= 0 && Convert.ToInt32(s.SectionId) >= 0 && s.HasStorage == true)
                    .OrderBy(s => Convert.ToInt32(s.SectionId))
                    .ThenBy(s => Convert.ToInt32(s.ShelfId))
                    .FirstOrDefault();
                if(CurrentPackageVolume <= 10)
                {
                    Console.WriteLine($"{avaiableSection.ShelfId}{avaiableSection.SectionId}");
                    avaiableSection.AddPackageToSection();
                }
                else
                {
                    Console.WriteLine($"{avaiableSection.ShelfId}FL");
                }
            }
        }
    }

    public class Package
    {
        public string Id { get; set; }
        public int Sequence { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public decimal Length { get; set; }

        public Package(int sequence, decimal width, decimal height, decimal length)
        {
            Id = Guid.NewGuid().ToString();
            Sequence = sequence;
            Width = width;
            Height = height;
            Length = length;
        }

        public decimal PackageVolumne() { return Width * Height * Length; }

    }

    public class Truck
    {
        public int Id { get; set; }
        public List<Section> Sections { get; set;}

        public Truck(int id, int shelfs, int sectionPerShelf)
        {
            Id = id;
            List<Section> sections = new List<Section>();
            for(int i = 1; i <= shelfs; i++)
            {
                for( int j = 1; j <= sectionPerShelf; j++ )
                {
                    Section temp = new Section(i.ToString("00"), j.ToString("00"), true);
                    sections.Add(temp);
                }
            }
            Sections = sections;
        }

    }

    public class Section
    {
        public string ShelfId { get; set; }
        public string SectionId { get; set; }
        public bool HasStorage { get; set; }

        public Section(string shelf, string section, bool storage)
        {
            ShelfId = shelf;
            SectionId = section;
            HasStorage = storage;
        }

        public void AddPackageToSection()
        {
            HasStorage = false;
        }

        public void RemovePackageToSection()
        {
            HasStorage = true;
        }
    }
}