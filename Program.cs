using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        string line;
        string concatinated=null;
        int brojac = 0;
        int brojac2 = 0;

        string[] redKol =  { "A", "D", "F", "G", "V", "X" };

        string[,] sifra = { {"B","2","E","5","R","L"},
                          {"I","9","N","A","1","C"},
                          {"3","D","4","F","6","G"},
                          {"7","H","8","J","0","K"},
                          {"M","O","P","Q","S","T"},
                          {"U","V","W","X","Y","Z"}};

        StreamReader sr = new StreamReader("C:\\Users\\Mirza\\Desktop\\zimmerman input.txt");

        while ((line = sr.ReadLine()) != null)
        {
            concatinated += line;
        }


        //obrisi razmake
        concatinated = concatinated.Replace(" ", String.Empty);


        //dodaj razmak svako trece mjesto
        for (int i = 0; i < concatinated.Length; i++)
        {
            if ((i % 3) == 0)
                concatinated =concatinated.Insert(i, " ");
        }

        //makni nepotrebni razmak
        concatinated=concatinated.Remove(0, 1);

        //uvrsti
        for (int i = 0; i < redKol.Length; i++)
        {
            for (int j = 0; j < redKol.Length; j++)
            {
                concatinated = concatinated.Replace(redKol[i] + redKol[j], sifra[i, j]);
            }
        }


        //prebroj
        for (int i = 0; i < concatinated.Length; i++)
        {
            brojac++;

            if (concatinated[i] == ' ')
            {
                brojac2++;
            }
        }

        using (StreamWriter sw = new StreamWriter("C:\\Users\\Mirza\\Desktop\\zimmerman output.txt"))
        {
            sw.WriteLine(concatinated);
        }


        sr.Close();

        Console.WriteLine("ukupan broj karaktera je " + brojac);
        Console.WriteLine("broj razmaka je " + brojac2);
    }
}