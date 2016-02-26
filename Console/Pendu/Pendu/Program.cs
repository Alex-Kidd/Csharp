using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace Pendu
{
    class Program
    {

        //test
        static void Main(string[] args)
        {
            string MotSecret;
            string MotConstruit = "";
            string LettreTappees = "";
            string lettre;
            int error = 0;  
            
                     
            Console.WriteLine("----------------------le jeu du PENDU----------------------------\n\n-------------------------GOOD LUCK !-----------------------");
            Console.WriteLine("JOUEUR 1 : entrez le mot secret");
            MotSecret = Console.ReadLine().ToLower(); // on demande le MotSecret au J1
            Console.Clear();
            Console.WriteLine("Joueur 2: trouvez le mot secret");
                       

            Console.Clear();
            Console.WriteLine("\n:::lettre déjà tappée:::'{0}'\n", LettreTappees);
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
                    Console.WriteLine("Nombre d'erreurs commises : {0}/11", error);
                    Console.WriteLine("\nMOT MYSTERE");
            foreach (char c in MotSecret)
            {
                MotConstruit += "_";
            }
                    Console.WriteLine(MotConstruit);

            while (MotSecret != MotConstruit && error < 11) //tant que le motsecret n'est pas recomposé
            {
                Console.WriteLine("Joueur 2: trouvez le mot secret"); //on demande une lettre à l'utilisateur
                char cha;
                int saisie = 0;
                do {

                    cha = '*';
                    if (saisie != 0)
                    {
                        Console.WriteLine("!saisie incorrecte!");
                    }
                    Console.WriteLine("entrez une lettre");                   
                    lettre = Console.ReadLine().ToLower();
                    char.TryParse(lettre, out cha);                    
                    saisie++;
                } while (!char.IsLetter(cha));

                Console.Clear();
                
           
                if (LettreTappees.IndexOf(lettre) == -1)
                {
                    LettreTappees += lettre;
                }
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
                if (MotSecret.IndexOf(lettre) == -1)
                {
                    error++;
                }



                switch (error) //évolution du dessin en fonction du nombre d'erreurs
                {
                    case 0:
                        Console.WriteLine("\n:::lettre déjà tappée:::'{0}'\n", LettreTappees);
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
                        Console.WriteLine("Nombre d'erreurs commises : {0}/11", error);
                        Console.WriteLine("\nMOT MYSTERE");
                        Console.WriteLine(MotConstruit);
                        break;

                    case 1:
                        Console.WriteLine("\n:::lettre déjà tappée:::'{0}'\n", LettreTappees);
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
                        Console.WriteLine("Nombre d'erreurs commises : {0}/11", error);
                        Console.WriteLine("\nMOT MYSTERE");
                        Console.WriteLine(MotConstruit);
                        break;
                    case 2:
                        Console.WriteLine("\n:::lettre déjà tappée:::'{0}'\n", LettreTappees);
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
                        Console.WriteLine("Nombre d'erreurs commises : {0}/11", error);
                        Console.WriteLine("\nMOT MYSTERE");
                        Console.WriteLine(MotConstruit);
                        break;
                    case 3:
                        Console.WriteLine("\n:::lettre déjà tappée:::'{0}'\n", LettreTappees);
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
                        Console.WriteLine("Nombre d'erreurs commises : {0}/11", error);
                        Console.WriteLine("\nMOT MYSTERE");
                        Console.WriteLine(MotConstruit);
                        break;
                    case 4:
                        Console.WriteLine("\n:::lettre déjà tappée:::'{0}'\n", LettreTappees);
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
                        Console.WriteLine("Nombre d'erreurs commises : {0}/11", error);
                        Console.WriteLine("\nMOT MYSTERE");
                        Console.WriteLine(MotConstruit);
                        break;
                    case 5:
                        Console.WriteLine("\n:::lettre déjà tappée:::'{0}'\n", LettreTappees);
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
                        Console.WriteLine("Nombre d'erreurs commises : {0}/11", error);
                        Console.WriteLine("\nMOT MYSTERE");
                        Console.WriteLine(MotConstruit);
                        break;
                    case 6:
                        Console.WriteLine("\n:::lettre déjà tappée:::'{0}'\n", LettreTappees);
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
                        Console.WriteLine("Nombre d'erreurs commises : {0}/11", error);
                        Console.WriteLine("\nMOT MYSTERE");
                        Console.WriteLine(MotConstruit);
                        break;
                    case 7:
                        Console.WriteLine("\n:::lettre déjà tappée:::'{0}'\n", LettreTappees);
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
                        Console.WriteLine("Nombre d'erreurs commises : {0}/11", error);
                        Console.WriteLine("\nMOT MYSTERE");
                        Console.WriteLine(MotConstruit);
                        break;
                    case 8:
                        Console.WriteLine("\n:::lettre déjà tappée:::'{0}'\n", LettreTappees);
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
                        Console.WriteLine("Nombre d'erreurs commises : {0}/11", error);
                        Console.WriteLine("\nMOT MYSTERE");
                        Console.WriteLine(MotConstruit);
                        break;
                    case 9:
                        Console.WriteLine("\n:::lettre déjà tappée:::'{0}'\n", LettreTappees);
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
                        Console.WriteLine("Nombre d'erreurs commises : {0}/11", error);
                        Console.WriteLine("\nMOT MYSTERE");
                        Console.WriteLine(MotConstruit);
                        break;
                    case 10:
                        Console.WriteLine("\n:::lettre déjà tappée:::'{0}'\n", LettreTappees);
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
                        Console.WriteLine("Nombre d'erreurs commises : {0}/11", error);
                        Console.WriteLine("\nMOT MYSTERE");
                        Console.WriteLine(MotConstruit);
                        break;
                    case 11:
                        Console.WriteLine("\n:::lettre déjà tappée:::'{0}'\n", LettreTappees);
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
                        Console.WriteLine("Nombre d'erreurs commises : {0}/11", error);
                        Console.WriteLine("\nMOT MYSTERE");
                        Console.WriteLine(MotConstruit);
                        break;
                }


                if (MotSecret.IndexOf(lettre) == -1)
                {
                    Console.WriteLine("\nLETTRE --> FAUSSE !\n");
                }
                else
                {
                    Console.WriteLine("\nLETTRE --> CORRECTE !\n");
                }
               
                if (error == 11)
                {                    
                    Console.WriteLine("\nPENDU !\n----------solution:{0}-----------\n", MotSecret);
                }
                else if (MotSecret == MotConstruit)
                {
                    Console.WriteLine("\nMOT MYSTERE RECOMPOSE\n");
                    if (error == 0)
                    {
                        Console.WriteLine("!!!! PERFECT !!!!");
                    }
                }
                
            }            
            Console.ReadKey();
        }


    }
}

