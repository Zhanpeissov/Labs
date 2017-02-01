using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teachers
{ 

    class Teachers 
    {       //*creation of class*//
        public string name;
        public string surname;
        public int AmountOfPublications;
        public double CitationIndex;
        
        public Teachers(string name, string surname, int AmountOfPublications)
        { //*creation of constructur*//
            this.name = name;
            this.surname = surname;
            this.AmountOfPublications = AmountOfPublications;
        }

        public Teachers(string name, string surname, double CitationIndex)
        {
            this.name = name;
            this.surname = surname;
            this.CitationIndex = CitationIndex;
        }

        public override string ToString() //*It is necessary to bring all the data that the user must see when you call the Console.WriteLine method*//  
        {
            return this.name + ":" + this.surname + ": " + this.AmountOfPublications + ":" +this.CitationIndex;
        } 
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Teachers t = new Teachers("Arman", "Andosov", 154);
            t.CitationIndex = 0.78;
            Teachers s = new Teachers("Nikolay", "Sokolov", 0.67);
            s.AmountOfPublications = 125;    
            Console.WriteLine(t);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
