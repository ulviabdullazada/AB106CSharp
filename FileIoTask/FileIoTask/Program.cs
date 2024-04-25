using System.Diagnostics;
using System.Runtime.Intrinsics.Arm;

namespace FileIoTask
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("folder adi daxil edin");
            anar:
            string folderName = Console.ReadLine();
            string path = "C:\\Users\\ca.r214.01\\Desktop\\" + folderName;
            DirectoryInfo directoryInfo = new DirectoryInfo(path);

            if (!directoryInfo.Exists )
            {
                directoryInfo.Create();
            }
            else
            {
                Console.WriteLine("bele bir folder var yeniden yarat");
                goto anar;
            }
            bool check = false;
            do
            {
                if (!directoryInfo.Exists)
                {
                    directoryInfo.Create();
                    check = true;
                }
                else
                {
                    Console.WriteLine("bele bir folder var yeniden yarat");
                    
                }

            } while (!check);


            string choice;

            do
            {
                Console.WriteLine("1Yeni Fayl yarat  0.Exit");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("fayl adi daxil edin");
                        back:
                        string fileName = Console.ReadLine();
                        string filePath = Path.Combine(path, fileName);

                        if (!File.Exists(filePath))
                        {
                            File.Create(filePath).Close();
                            
                        }
                        else
                        {
                            Console.WriteLine("bele adda fayl var");
                            goto back;
                        }
                        Console.WriteLine("fayla yazi yazmaq isteyirsinizmi? yes or no");
                        choice = Console.ReadLine();
                        string writed;
                        if (choice == "yes")
                        {
                            writed = Console.ReadLine();

                            File.AppendAllText(filePath, writed);
                        }
                        else
                        {
                            Console.WriteLine("okai");
                        }




                        break;

                    default:
                        break;
                }


            } while (choice!= "0");
           











        }
    }
}
