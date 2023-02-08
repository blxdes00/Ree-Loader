using System;
using System.Net;

namespace WebReloader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor= ConsoleColor.DarkBlue;

            Console.WriteLine("\t\t\t██████╗ ███████╗███████╗    ██╗      ██████╗  █████╗ ██████╗ ███████╗██████╗ ");
            Console.WriteLine("\t\t\t██╔══██╗██╔════╝██╔════╝    ██║     ██╔═══██╗██╔══██╗██╔══██╗██╔════╝██╔══██╗");
            Console.WriteLine("\t\t\t██████╔╝█████╗  █████╗█████╗██║     ██║   ██║███████║██║  ██║█████╗  ██████╔╝");
            Console.WriteLine("\t\t\t██╔══██╗██╔══╝  ██╔══╝╚════╝██║     ██║   ██║██╔══██║██║  ██║██╔══╝  ██╔══██╗");
            Console.WriteLine("\t\t\t██║  ██║███████╗███████╗    ███████╗╚██████╔╝██║  ██║██████╔╝███████╗██║  ██║");
            Console.WriteLine("\t\t\t╚═╝  ╚═╝╚══════╝╚══════╝    ╚══════╝ ╚═════╝ ╚═╝  ╚═╝╚═════╝ ╚══════╝╚═╝  ╚═╝");
            Console.WriteLine("\t\t\t        by Blxdes00                                                          \n\n");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("\t\t\t[+] Enter the URL of the website you want to reload:");
            string url = Console.ReadLine();

            Console.WriteLine("\n\t\t\t[+] Do you want to reload it in milliseconds or seconds? ms/s");
            string rMethod = Console.ReadLine();

            if (rMethod == "ms")
            {
                Console.WriteLine("\n\t\t\t[+] Enter the interval (in milliseconds) at which you want to reload the website(Max 100ms):");
                int interval1 = int.Parse(Console.ReadLine());

                using (WebClient client = new WebClient())
                {
                    while (true)
                    {
                        Console.WriteLine("\t\t\t[-] Reloading website...");
                        client.DownloadString(url);
                        System.Threading.Thread.Sleep(interval1);
                    }
                }

            }

            if (rMethod == "s")
                {
                    Console.WriteLine("\n[+] Enter the interval (in seconds) at which you want to reload the website:");
                    int interval2 = int.Parse(Console.ReadLine());

                    using (WebClient client = new WebClient())
                    {
                        while (true)
                        {
                            Console.WriteLine("[-] Reloading website...");
                            client.DownloadString(url);
                            System.Threading.Thread.Sleep(interval2 * 1000);
                        }
                    }
                }
            }
        }
}
