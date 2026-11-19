namespace íjászverseny
{
    internal class Program
    {
        static int[,]jatekosokpontjai;
        static Random r = new Random();
        static string[] jatekosokNevei(int jatekosokszama)
        {
            string[] nevek = { "Anna", "Bence", "Csaba", "Dóra", "Eszter", "Ferenc", "Gábor", "Hanna", "István", "Judit", "Katalin", "László", "Márk", "Nóra", "Orsolya", "Péter", "Réka", "Sándor", "Tamás", "Viktória", "Zoltán", "Ádám", "Balázs", "Cecília", "Dávid", "Emese", "Flóra", "György", "Levente", "Mihály" };
            string[] jatekosok = new string[jatekosokszama];
            for(int i = 0; i < jatekosokszama; i++)
            {
                int index = r.Next(0, nevek.Length);
                jatekosok[i] = nevek[index];
            }
            return jatekosok;
        }
        private static int[,] Feltolt(int jatekosokSzama)
        {
            int[,] matrix = new int[jatekosokSzama, 5];
    
            for(int i = 0;i < jatekosokSzama; i++)
            {
                for(int j = 0;j < 5; j++)
                {
                    matrix[i, j] = r.Next(0, 26);
                }
            }
            return matrix;
        }
        
        static void kiiras(string[] jatekosok)
        {
            
            

            ;

            for (int i = 0; i < jatekosokpontjai.GetLength(1); i++)
            {
                Console.Write($"Az {i + 1}. játékos: {jatekosok[i],8} pontja: ");
                for (int j = 0; j < jatekosok.GetLength(0); j++)
                {
                    Console.Write($"{jatekosokpontjai[i, j],4}");

                }
                Console.WriteLine();
            }
        }
        static void nyertes(string[] jatekosok)
        {
            int index = 0;
            int ossz=0;
            int tmp = 0;

            for(int i = 0;i>jatekosokpontjai.GetLength(0) ; i++)
            {
                for(int j = 0;j> jatekosokpontjai.GetLength(1); j++)
                {
                    ossz += jatekosokpontjai[i, j];
                    
                }
                if (ossz > tmp)
                {
                    tmp= ossz;
                    ossz = 0;
                    index= i;
                }
                else
                {
                    tmp = 0;
                }
                
            }
            Console.WriteLine($"{jatekosok[index]} jatekos gyozott");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Játékosok száma: ");

            int szama = Convert.ToInt32(Console.ReadLine());
            jatekosokpontjai = Feltolt(szama);
            string[] jatekosok = jatekosokNevei(szama);
            kiiras(jatekosok);
            nyertes(jatekosok);
            
            
        }
    }
}
