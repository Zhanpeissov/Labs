using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Di
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo(Console.ReadLine());
            List<FileSystemInfo> fi = new List<FileSystemInfo>();
            fi.AddRange(di.GetFiles());
            foreach (FileInfo p in fi) {
                StreamReader sr = new StreamReader(p.FullName);
                string str = sr.ReadToEnd();
                string[] arr = str.Split();
                for (int i = 0; i < arr.Length; i++) {
                    if (arr[i] == "abcd") {
                        Console.WriteLine(p.Name);
                    }
                }
                
            }
            Console.ReadKey();
        }
    }
}
