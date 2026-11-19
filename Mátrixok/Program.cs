namespace Mátrixok
{
    internal class Program
    {

        static int sorokSzama = 10;
        static int oszlopokSzama = 6;
        static int[,] szamokMatrix = new int[sorokSzama, oszlopokSzama];
        static Random r=new Random();
        static void F01()
        {
            for(int i = 0; i < sorokSzama; i++)
            {
                for( int j = 0; j < oszlopokSzama; j++)
                {
                    szamokMatrix[i, j] = r.Next(10, 100);
                }
            }
        }
        static void F02()
        {
            for (int i = 0;i < sorokSzama;i++)
            {
                for(int j = 0;j < oszlopokSzama; j++)
                {
                    Console.Write(szamokMatrix[i, j] + " ");
                }
            }
        }
        static void Main(string[] args)
        {
            F01();
        }
    }
}
