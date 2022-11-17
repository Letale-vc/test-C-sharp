using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newTestProject
{
    class nextLevelCar : Car, IRun
    {


        public string NextLevelClassName { get; set; }
        public float speed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void carRun()
        {
            Console.WriteLine("\n Car run")
        }
        {
            throw new NotImplementedException();
    }

    public override void printAllVaues()
    {
        base.printAllVaues();

        Console.WriteLine("NEXT LEVEL CLASS NAME CAR: {0}", NextLevelClassName);
    }


}
}
