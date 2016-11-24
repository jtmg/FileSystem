using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    class Folder:Node
    {
        private int size;
        private  List< File> contentFolder = new List<File>();
        public Folder(string name, int size) : base(name, size)
        {
            Node.addToList(this);
        }

        public void addToList(File f)
        {
            contentFolder.Add(f);
            this.size += f.Size;
        }

        public void calculateSize()
        {
            size = 0;
            foreach (File f in contentFolder)
            {
                size += f.Size;
            }
        }

        public string ToString()
        {
            Console.WriteLine("{0} {1}",this.Name, this.size);
            foreach (File f in contentFolder)
            {
                Console.WriteLine("\t {0} {1}",f.Name,f.Size);
            }
            return "";
        }

        public int  Size
        {
            get { return this.size;}
        }


    }
}
