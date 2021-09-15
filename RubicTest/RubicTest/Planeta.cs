using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubicTest
{
    class Planeta
    {  
        private void CreateHuman()
        {
            Human human1 = new Human();
            human1.name = " Паша";
            human1.age = 21;
            human1.isBoy = true;
            human1.salory = 21.5F;
        }


        private void Main()
        {
            CteateCat();
            CteateCat();
            CteateCat();
            CreateHuman();
            CreateHuman();
        }


         private void CteateCat()
        {
            Cat cat1 = new Cat();
            cat1.name = " Жора ";
            cat1.age = 15;
            cat1.height = 13.5F;
            cat1.isBoy = true;
        }

    }
}
