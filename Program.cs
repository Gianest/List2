using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List2
{
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa mhs1 = new Mahasiswa();
            mhs1.Nim = "1223";
            mhs1.NamaMahasiswa = "erik";

            Mahasiswa mhs2 = new Mahasiswa();
            mhs2.Nim = "1243";
            mhs2.NamaMahasiswa = "ceguk";

            List<Mahasiswa> list = new List<Mahasiswa>();

            list.Add(mhs1);
            list.Add(mhs2);

            //Mahasiswa mhs = list[1];

            foreach(Mahasiswa mhs in list)
            {
                Console.WriteLine("{0},{1}",mhs.Nim, mhs.NamaMahasiswa);
            }
            Console.ReadKey();
        }
    }
}
