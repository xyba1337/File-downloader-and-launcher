using bootstrapping;
using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading;

namespace BootstrappingTut
{
    class Program
    {
        //create if pipe is connected (X)
        //delete files which might cause some problems (X)
        //download the file (X)
        //extract the file (X)
        //open the file (X)


        public static void removeproblems()
        {
            string dc = @".\Bin";
            if (Directory.Exists(dc))
            try
            {
                Directory.Delete(dc, true);

                Thread.Sleep(1700);
            }
            catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Something went wrong " + ex.ToString());
                }
            Console.WriteLine("Remove Problems done");
        }
        public static void check()
        {
            for(;;)
            {
                if (NamedPipes.NamedPipeExist(NamedPipes.luapipename))
                {
                    Console.WriteLine("Pipe found");
                }
                else
                {
                    Console.WriteLine("Pipe doesn't exist");
                }
                //foreach (Process pc in Process.GetProcessesByName("RobloxPlayerBeta"))
                //    try
                //    {
                //        pc.Kill();
                //    }
                //    catch (Exception ex)
                //    {
                //        Console.WriteLine($"Nothing to worrie about " + ex.ToString());
                //    }
                Thread.Sleep(2000);
            }
            
        }

        public static void download()
        {
            WebClient wc = new WebClient();
            wc.DownloadFileAsync(new Uri ("put_your_download_here"), @".\files.zip");
            Thread.Sleep(2500);
            Console.WriteLine("Downloaded files");
        }

        public static void extract()
        {
            string zippath = @".\files.zip";
            ZipFile.ExtractToDirectory(zippath, @".\Bin");
            Thread.Sleep(1000);

            string zip = @".\files.zip";
            if (File.Exists(zip))
                try
                {
                    File.Delete(zip);

                    Thread.Sleep(1700);
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Something went wrong " + ex.ToString());
                }
            Console.WriteLine("Exploit Extracted");
        }

        public static void startprocess()
        {
            string executeablepath = @".\Bin\TestExploit.exe";
            Process.Start(executeablepath);
            Thread.Sleep(600);
            Console.WriteLine("Starting process");
        }
        static void Main(string[] args)
        {
            removeproblems();
            download();
            extract();
            startprocess();
            Console.WriteLine("");
            Console.WriteLine("Window won't close due to the fact that you need to tell the problem to close itself after everything is done. You can find out how to do that yourself im pretty sure!");
            Console.ReadKey();
        }
    }
}
