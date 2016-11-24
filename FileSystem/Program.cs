using System;

namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //criação de uma pasta
            Folder f = new Folder("documents",0);

            //criação de ficheiros
            File f1 = new File("mira.txt", 5);
            File f2 = new File("Eo.txt", 2);

            //atribuição dos filheiros às pasta
            f.addToList(f1);
            f.addToList(f2);

            //imprimir parametros da pasta
            f.ToString();
            //Console.WriteLine("{0}",Node.ToString());
            Console.ReadKey();
        }
    }
}
