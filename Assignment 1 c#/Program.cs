namespace Assignment_1_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  Islam's Carpet Cleaning Service\nCharges:\n$25 per small\n$35 per large\nSales tax rate is 6%\nEstimates are valid for 30 days\n");
            Console.WriteLine("Estimate for carpet cleaning service\n");
            Console.Write("Number of small carpets:");
            int smallCarpets = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of large carpets:");
            int largeCarpets = Convert.ToInt32(Console.ReadLine());
            float sum = largeCarpets*35 + smallCarpets*25;
            float tax = sum * 6 / 100;
            Console.WriteLine($"Total Cost = {sum} \n Tax = {tax}");
            Console.WriteLine("==========================================================================================");
            float totalEstimate = sum + tax;
            Console.WriteLine($"Total Estimate = {totalEstimate} \n This estimate is valid for 30 days ");
        }
    }
}
