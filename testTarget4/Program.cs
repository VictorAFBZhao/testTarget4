using System;

namespace testTarget4
{
    class Program
    {
        static void Main(string[] args)
        {
            double SP = 67.836;
            double RJ = 36.678;
            double MG = 29.229;
            double ES = 27.165;
            double OUTROS = 19.849;

            double percSP, percRJ, percMG, percES, percOUTROS;

            double total = SP + RJ + MG + ES + OUTROS;

            percSP = (SP * 100)/total;
            percRJ = (RJ * 100) / total;
            percMG = (MG * 100) / total;
            percES = (ES * 100) / total;
            percOUTROS = (OUTROS * 100) / total;


            Console.WriteLine("SP---> "+percSP + "%");
            Console.WriteLine("RJ---> " + percRJ + "%");
            Console.WriteLine("MG---> " + percMG + "%");
            Console.WriteLine("ES---> " + percES + "%");
            Console.WriteLine("OUTROS---> " + percOUTROS + "%");
        }
    }
}
