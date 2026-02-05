namespace Encaptulation
{
    //Encaptulation
    class StudentMarks
    {
        private int ScienceMark;
        private int MathMarks;
        public void SetMarks(int Sci, int M)
        {
            if (Sci <= 100 && M <= 100 && Sci >= 0 && M >= 0)
            {
                Console.WriteLine("valid with science mark  " + Sci + " Math marks  " + M);
                ScienceMark = Sci;
                MathMarks = M;

            }
            else
            {
                Console.WriteLine("Invcalid Marks");
            }

        }
        public int gettotalmarks()
        {
            return ScienceMark + MathMarks;

        }
        public double GetPercentage()
        {
            return (gettotalmarks() * 100 / 200);
        }
    }

    // inheritance with get set (Encaptulation)
    class Vehiclee
    {
        public string CompanyName { get; set; }
        public double Price { get; set; }
        public void ShowVehicleInfo()
        {
            Console.WriteLine($"Company Name is {CompanyName} and Company price is {Price}");

        }
    }
    class Carr : Vehiclee
    {
        public string Model { get; set; }
        public string FuelType { get; set; }
        public void ShowCarInfo()
        {
            Console.WriteLine($"Car model is {Model} and Car FuelType is {FuelType}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Encaptulation

            StudentMarks marks = new StudentMarks();
            marks.SetMarks(90, 80);
            Console.WriteLine(marks.gettotalmarks());
            Console.WriteLine(marks.GetPercentage() + "%");

            //inheritance with encaptulation

            Carr c1 = new Carr();
            c1.CompanyName = "Sangeeta";
            c1.Price = 5000;
            c1.Model = "Priya";
            c1.FuelType = "Arpit";
            c1.ShowVehicleInfo();
            c1.ShowCarInfo();

        }
    }
}

