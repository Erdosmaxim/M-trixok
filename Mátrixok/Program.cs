namespace Mátrixok
{
    internal class Program
    {

        static int sorokSzama = 10;
        static int oszlopokSzama = 6;
        static int[,] szamokMatrix = new int[sorokSzama, oszlopokSzama];
        static int[,] negyzetesMatrix = new int[5, 5];
        static Random r=new Random();
        static void F01(int[,]matrix, int min, int max)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for( int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = r.Next(min, max);
                }
            }
        }
        static void F02(int[,]matrix)
        {
            for (int i = 0;i < matrix.GetLength(0);i++)
            {
                for(int j = 0;j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j],5}");
                }
                Console.WriteLine();
            }
        }
        static void F03()
        {
            int ossz = 0;
            for(int i = 0; i < sorokSzama; i++)
            {
                for(int j=0; j< oszlopokSzama; j++)
                {
                    ossz += szamokMatrix[i, j];
                }
            }
            Console.WriteLine($"A szum:{ossz}");
        }
        static void F04()
        {
            for (int i = 0; i < sorokSzama; i++)
            {
                int ossz = 0;
                for (int j = 0; j < oszlopokSzama; j++)
                {
                    ossz += szamokMatrix[i, j];
                }
                Console.WriteLine($"A {i+1} sor összege: {ossz} ");
            }
        }
        static void F05()
        {
            for (int j = 0; j < sorokSzama; j++)
            {
                int ossz = 0;
                for (int i = 0; i < oszlopokSzama; i++)
                {
                    ossz += szamokMatrix[i, j];
                }
                Console.WriteLine($"A {j + 1} sor összege: {ossz} ");
            }
        }
        static void F06(int[,]matrix)
        {
            int ossz = 0;
            Console.Write("Az átló:");
            for (int i = 0; i < matrix.GetLength(0);i++)
            {
                Console.Write($"{matrix[i,i],5}");
                ossz += matrix[i, i];
            }
            Console.WriteLine();
            Console.WriteLine($"A mátrix bal átlójának összege: {ossz}");
        }
        static void F07(int[,]matrix)
        {
            int ossz = 0;
            int j= matrix.GetLength(0)-1;
            Console.Write("Az átló:");
            for (int i = 0;i <matrix.GetLength(0); i++)
            {
                Console.Write($"{matrix[i, j],5}");
                j--;
            }
            Console.WriteLine();
            Console.WriteLine($"A mátrix jobb átlójának összege: {ossz}");
        }
        static void Main(string[] args)
        {
            F01(szamokMatrix,10,100);
            F02(szamokMatrix);
            F03();
            F04();
            //F05();
            Console.WriteLine("-------------------------------------------");
            F01(negyzetesMatrix,-100,100);
            F02(negyzetesMatrix);
            F06(negyzetesMatrix);
            Console.WriteLine("--------------------------------------------");
            F07(negyzetesMatrix);
            int[,] masolat = negyzetesMatrix;
            masolat[0, 0] = 100;
            Console.WriteLine("Másolat elemei: ");
            F02(masolat);
            Console.WriteLine("Negyzetesmatrix elemei:");
            F02(negyzetesMatrix);
        }
    }
}
