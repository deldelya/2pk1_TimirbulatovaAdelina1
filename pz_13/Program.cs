using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_13
{
    internal class Program
    {
        public static void GetFolderInfo(string path, out int folderCount, out int fileCount)
        {
            folderCount = 0;
            fileCount = 0;

            // Проверяем, существует ли директория по заданному пути
            if (Directory.Exists(path))
            {
                
                DirectoryInfo directoryInfo = new DirectoryInfo(path); // Получаем информацию о директории

                
                DirectoryInfo[] subDirectories = directoryInfo.GetDirectories(); // Получаем информацию о поддиректориях


                foreach (DirectoryInfo subDirectory in subDirectories)
                {
                    int subFolderCount, subFileCount;

                    GetFolderInfo(subDirectory.FullName, out subFolderCount, out subFileCount);

                    folderCount += subFolderCount + 1; 
                    fileCount += subFileCount;
                }

                // Получаем информацию о файлах в директории
                FileInfo[] files = directoryInfo.GetFiles();

                // Добавляем количество файлов в общее количество файлов
                fileCount += files.Length;
            }
            else
            {
                
                Console.WriteLine("Директории не существует");
            }
        }
        static void Main(string[] args)
        {
            int folderCount, fileCount;
            GetFolderInfo("D:\\Folders", out folderCount, out fileCount);

            Console.WriteLine("Количество папок: {0}", folderCount);
            Console.WriteLine("Количество файлов: {0}", fileCount);
            Console.ReadKey();
        }
    }
}
