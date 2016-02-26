using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace pendu2
{
    class Program
    {
static int error = 0;
static string MotConstruit = "";
       static string LettreTappees = "";
        static string MotSecret;

         static   string lettre = "^$";
        static void Main(string[] args)
        {
            Timer tt = new Timer(5000);
            tt.Elapsed += Tt_Elapsed;
            tt.Start();

            string[] listemotsecret =
                {
                    "accordeon", "basse", "alto", "appeau", "banjo", "batterie", "basson", "bongo", "harpe","saxophone","sifflet","trompette","orgue","gigue","voix","ukulele","trombone","piano","kazoo","jenbe","hochet","mandoline","marimba","xylophone","vibraphone","triangle","lyre","flute","harmonica","tambour","cornemuse","tymbale","synthetiseur","tamtam","maracas",""
                };
            Random rand = new Random();
            int rndNumber = 0;
            rndNumber = rand.Next(0, listemotsecret.Length);

            MotSecret = listemotsecret[rndNumber];

            Console.WriteLine("----------------------le jeu du PENDU solo mode----------------------------\n----------Trouvez le mot secret en entrant chacune des lettres au clavier\n----------'Entrée' pour valider la lettre\n----------1 lettre après l'autre\n----------10 erreurs sont permises \n----------GOOD LUCK !\npress enter to continue");
            Console.ReadKey();
            Console.Clear();

            foreach (char c in MotSecret)
            {
                MotConstruit += "_";
            }

            Console.WriteLine("\n:::lettre déjà tappée:::\n\n      _____________");
            Console.WriteLine("      |            |");
            Console.WriteLine("      |            |");
            Console.WriteLine("                   |");
            Console.WriteLine("                   |");
            Console.WriteLine("                   |");
            Console.WriteLine("                   |");
            Console.WriteLine("                   |");
            Console.WriteLine("                   |");
            Console.WriteLine("                   |");
            Console.WriteLine("                   |");
            Console.WriteLine("___________________|____");
            Console.WriteLine(MotConstruit);
            while (MotSecret != MotConstruit && error < 11)
            {
                char cha;
                int saisie = 0;
                do
                {
                    cha = '*';
                    if (saisie == 0)
                    { Console.WriteLine("entrez une lettre"); }
                    else
                    { Console.WriteLine("!!!SAISIE NON VALIDE!!!\nentrez une lettre"); }

                    lettre = Console.ReadLine();
                    char.TryParse(lettre, out cha);
                    saisie++;

                } while (!char.IsLetter(cha));

                



                if (LettreTappees.IndexOf(lettre) == -1)
                {
                    LettreTappees += lettre;
                }

                if (MotSecret.IndexOf(lettre) == -1 && LettreTappees.IndexOf(lettre) != -1)
                {
                    error++;
                }

                dessine(error, MotConstruit, LettreTappees);                

                MotConstruit = "";
                foreach (char c in MotSecret)
                {
                    if (LettreTappees.IndexOf(c) != -1)
                    {
                        MotConstruit += c;
                    }
                    else
                    {
                        MotConstruit += "_";
                    }
                }


                
                if (error == 11)
                {
                    Console.Clear();
                    Console.WriteLine("\nGAME OVER\n----------Mot secret:{0}-----------\n", MotSecret);
                }
                else if (MotSecret == MotConstruit)
                {
                    Console.Clear();
                    Console.WriteLine("\nYOU WIN !!\n----------Mot secret:{0}-----------\n", MotSecret);
                    if (error == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("!!!! PERFECT !!!!----------Mot secret:{0}-----------\n", MotSecret);
                    }
                }

            }
            tt.Stop();
            Console.ReadKey();
        }

        private static void Tt_Elapsed(object sender, ElapsedEventArgs e)
        {
            error++;
            dessine(error, MotConstruit, LettreTappees);
        }

        static void dessine(int error, string MotConstruit, string LettreTappees)
        {
            Console.Clear();
            switch (error)
            {
                
                case 0:
                    Console.WriteLine("\n:::lettre déjà tappée:::\n '{0}'\n", LettreTappees);
                    Console.WriteLine("      _____________");
                    Console.WriteLine("      |            |");
                    Console.WriteLine("      |            |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("___________________|____");
                    Console.WriteLine(MotConstruit);
                    break;

                case 1:
                    Console.WriteLine("\n:::lettre déjà tappée:::\n '{0}'\n", LettreTappees);
                    Console.WriteLine("      _____________");
                    Console.WriteLine("      |            |");
                    Console.WriteLine("      |            |");
                    Console.WriteLine("      O            |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("___________________|____");
                    Console.WriteLine(MotConstruit);
                    break;
                case 2:
                    Console.WriteLine("\n:::lettre déjà tappée:::\n '{0}'\n", LettreTappees);
                    Console.WriteLine("      _____________");
                    Console.WriteLine("      |            |");
                    Console.WriteLine("      |            |");
                    Console.WriteLine("      O_           |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("___________________|____");
                    Console.WriteLine(MotConstruit);
                    break;
                case 3:
                    Console.WriteLine("\n:::lettre déjà tappée:::\n '{0}'\n", LettreTappees);
                    Console.WriteLine("      _____________");
                    Console.WriteLine("      |            |");
                    Console.WriteLine("      |            |");
                    Console.WriteLine("     _O_           |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("___________________|____");
                    Console.WriteLine(MotConstruit);
                    break;
                case 4:
                    Console.WriteLine("\n:::lettre déjà tappée:::\n '{0}'\n", LettreTappees);
                    Console.WriteLine("      _____________");
                    Console.WriteLine("      |            |");
                    Console.WriteLine("      |            |");
                    Console.WriteLine("     _O__          |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("___________________|____");
                    Console.WriteLine(MotConstruit);
                    break;
                case 5:
                    Console.WriteLine("\n:::lettre déjà tappée:::\n '{0}'\n", LettreTappees);
                    Console.WriteLine("      _____________");
                    Console.WriteLine("      |            |");
                    Console.WriteLine("      |            |");
                    Console.WriteLine("    __O__          |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("___________________|____");
                    Console.WriteLine(MotConstruit);
                    break;
                case 6:
                    Console.WriteLine("\n:::lettre déjà tappée:::\n '{0}'\n", LettreTappees);
                    Console.WriteLine("      _____________");
                    Console.WriteLine("      |            |");
                    Console.WriteLine("      |            |");
                    Console.WriteLine("    __O__          |");
                    Console.WriteLine("      |            |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("___________________|____");
                    Console.WriteLine(MotConstruit);
                    break;
                case 7:
                    Console.WriteLine("\n:::lettre déjà tappée:::\n '{0}'\n", LettreTappees);
                    Console.WriteLine("      _____________");
                    Console.WriteLine("      |            |");
                    Console.WriteLine("      |            |");
                    Console.WriteLine("    __O__          |");
                    Console.WriteLine("      |            |");
                    Console.WriteLine("      |            |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("___________________|____");
                    Console.WriteLine(MotConstruit);
                    break;
                case 8:
                    Console.WriteLine("\n:::lettre déjà tappée:::\n '{0}'\n", LettreTappees);
                    Console.WriteLine("      _____________");
                    Console.WriteLine("      |            |");
                    Console.WriteLine("      |            |");
                    Console.WriteLine("    __O__          |");
                    Console.WriteLine("      |            |");
                    Console.WriteLine("      |            |");
                    Console.WriteLine(@"       \           |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("___________________|____");
                    Console.WriteLine(MotConstruit);
                    break;
                case 9:
                    Console.WriteLine("\n:::lettre déjà tappée:::\n '{0}'\n", LettreTappees);
                    Console.WriteLine("      _____________");
                    Console.WriteLine("      |            |");
                    Console.WriteLine("      |            |");
                    Console.WriteLine("    __O__          |");
                    Console.WriteLine("      |            |");
                    Console.WriteLine("      |            |");
                    Console.WriteLine(@"     / \           |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("___________________|____");
                    Console.WriteLine(MotConstruit);
                    break;
                case 10:
                    Console.WriteLine("\n:::lettre déjà tappée:::\n '{0}'\n", LettreTappees);
                    Console.WriteLine("      _____________");
                    Console.WriteLine("      |            |");
                    Console.WriteLine("      |            |");
                    Console.WriteLine("    __O__          |");
                    Console.WriteLine("      |            |");
                    Console.WriteLine("      |            |");
                    Console.WriteLine(@"     / \           |");
                    Console.WriteLine(@"        \          |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("___________________|____");
                    Console.WriteLine(MotConstruit);
                    break;
                case 11:
                    Console.WriteLine("      _____________");
                    Console.WriteLine("      |            |");
                    Console.WriteLine("      |            |");
                    Console.WriteLine("    __O__          |");
                    Console.WriteLine("      |            |");
                    Console.WriteLine("      |            |");
                    Console.WriteLine(@"     / \           |");
                    Console.WriteLine(@"    /   \          |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("                   |");
                    Console.WriteLine("___________________|____");

                    break;
            }
            
            if (MotSecret.IndexOf(lettre) == -1)

            {
                Console.WriteLine("\nFAUX !\n");
            }
            else if (MotSecret.IndexOf(lettre) != -1)
            {
                Console.WriteLine("\nCORRECT !\n");
            }
        }
    }
}

