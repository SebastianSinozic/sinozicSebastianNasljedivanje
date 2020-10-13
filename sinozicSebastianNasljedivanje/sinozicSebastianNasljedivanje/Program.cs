using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace sinozicSebastianNasljedivanje
{

    interface IControl
    {
        void Metoda();

        int Brojac { get; set; }

    }

    class ListBox : IControl
    {


        public void Metoda()
        {
            Console.WriteLine("Metoda List");
        }

        public int Brojac
        {
            get { return Brojac; }
            set { Brojac = value; }
        }

       



        class ComboBox : IControl
        {
            public int Brojac { get; set; }

            public void Metoda()
            {
                Console.WriteLine("Metoda Combo");

            }
        }



        class Program
        {
            static void Main(string[] args)
            {
                ListBox x = new ListBox();
                ComboBox y = new ComboBox();

                x.Metoda();
                y.Metoda();

                Console.ReadKey();
            }
        }
    }
}
