using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace FileSystem
{
    class Node
    {
        private string name;
        private int size;
        private static List <Folder> content = new List<Folder>();
        public Node(string name, int size)
        {
            this.name = name;
            this.size = size;
        }

        public static void addToList(Folder f)
        {
            content.Add(f);
        }

        public string  Name
        {
            get { return this.name ;}
            set { this.name = value; }
        }

        public int Size
        {
            get { return this.size; }
        }

        public static String ToString()
        {

            foreach (Folder f in content)
            {
                Console.WriteLine("{0}  {1}",f.Name,f.Size);
            }
            return "";
        }
       

    }
}
