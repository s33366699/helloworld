using System.Net;
using HtmlAgilityPack;
using System.Threading.Tasks;
using helloworld.Class;
namespace helloworld
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Coffee cup = PourCoffee();
            System.Diagnostics.Debug.WriteLine("coffee is ready");

            Egg eggs = await FryEggsAsync(2);
            System.Diagnostics.Debug.WriteLine("eggs are ready");

            Bacon bacon = await FryBaconAsync(3);
            System.Diagnostics.Debug.WriteLine("bacon is ready");

            Toast toast = await ToastBreadAsync(2);
            ApplyButter(toast);
            ApplyJam(toast);
            System.Diagnostics.Debug.WriteLine("toast is ready");

            Juice oj = PourOJ();
            System.Diagnostics.Debug.WriteLine("oj is ready");
            System.Diagnostics.Debug.WriteLine("Breakfast is ready!");
        }

        private static Juice PourOJ()
        {
            System.Diagnostics.Debug.WriteLine("Pouring orange juice");
            return new Juice();
        }

        private static void ApplyJam(Toast toast) =>
            System.Diagnostics.Debug.WriteLine("Putting jam on the toast");

        private static void ApplyButter(Toast toast) =>
            System.Diagnostics.Debug.WriteLine("Putting butter on the toast");

        private static Toast ToastBread(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                System.Diagnostics.Debug.WriteLine("Putting a slice of bread in the toaster" + " " + slice.ToString());
            }
            System.Diagnostics.Debug.WriteLine("Start toasting...");
            Task.Delay(3000).Wait();
            System.Diagnostics.Debug.WriteLine("Remove toast from toaster");

            return new Toast();
        }

        private static Bacon FryBacon(int slices)
        {
            System.Diagnostics.Debug.WriteLine($"putting {slices} slices of bacon in the pan");
            System.Diagnostics.Debug.WriteLine("cooking first side of bacon...");
            Task.Delay(3000).Wait();
            for (int slice = 0; slice < slices; slice++)
            {
                System.Diagnostics.Debug.WriteLine("flipping a slice of bacon" + " " + slice.ToString());
            }
            System.Diagnostics.Debug.WriteLine("cooking the second side of bacon...");
            Task.Delay(3000).Wait();
            System.Diagnostics.Debug.WriteLine("Put bacon on plate");

            return new Bacon();
        }

        private static Egg FryEggs(int howMany)
        {
            System.Diagnostics.Debug.WriteLine("Warming the egg pan...");
            Task.Delay(3000).Wait();
            System.Diagnostics.Debug.WriteLine($"cracking {howMany} eggs");
            System.Diagnostics.Debug.WriteLine("cooking the eggs ...");
            Task.Delay(3000).Wait();
            System.Diagnostics.Debug.WriteLine("Put eggs on plate");

            return new Egg();
        }

        private static Coffee PourCoffee()
        {
            System.Diagnostics.Debug.WriteLine("Pouring coffee");
            return new Coffee();
        }

        private static async Task<Egg> FryEggsAsync(int howMany)
        {
            System.Diagnostics.Debug.WriteLine("Warming the egg pan...");
            await Task.Delay(3000);
            System.Diagnostics.Debug.WriteLine($"cracking {howMany} eggs");
            System.Diagnostics.Debug.WriteLine("cooking the eggs ...");
            await Task.Delay(3000);
            System.Diagnostics.Debug.WriteLine("Put eggs on plate");

            return new Egg();
        }

        private static async Task<Bacon> FryBaconAsync(int slices)
        {
            System.Diagnostics.Debug.WriteLine($"putting {slices} slices of bacon in the pan");
            System.Diagnostics.Debug.WriteLine("cooking first side of bacon...");
            await Task.Delay(3000);
            for (int slice = 0; slice < slices; slice++)
            {
                System.Diagnostics.Debug.WriteLine("flipping a slice of bacon" + " " + slice.ToString());
            }
            System.Diagnostics.Debug.WriteLine("cooking the second side of bacon...");
            await Task.Delay(3000);
            System.Diagnostics.Debug.WriteLine("Put bacon on plate");

            return new Bacon();
        }

        private static async Task<Toast> ToastBreadAsync(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                System.Diagnostics.Debug.WriteLine("Putting a slice of bread in the toaster" + " " + slice.ToString());
            }
            System.Diagnostics.Debug.WriteLine("Start toasting...");
            await Task.Delay(3000);
            System.Diagnostics.Debug.WriteLine("Remove toast from toaster");

            return new Toast();
        }
    }
}
