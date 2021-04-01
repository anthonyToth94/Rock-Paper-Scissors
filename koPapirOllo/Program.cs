using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koPapirOllo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5-ig menjen, play again Y / N
            //jatékos név
            string nev;
            //gép nevei
            string[] gepNev = { "Pogácsa", "Lajos", "Kalács","Süni","Mókus", "Lacika"};
            //Akarsz-e játszani? y
            string valasz;

            //pontok
            int gepPont = 0, jatekosPont = 0;

            //korok
            int kor = 1;


            Console.Title = "Ko papir ollo!";
            Console.SetWindowSize(45, 17);

            Console.WriteLine("--- Szia játékos írd be a neved : - ) ---");
            Console.WriteLine();
            Console.Write("\t\t"); nev = Console.ReadLine();
            Console.WriteLine();
            //véletlen név
            Random r = new Random();
            int veletlenszam = r.Next(gepNev.Length);
            do
            {
                Console.Clear();
                Console.WriteLine("Szia " + nev + " kezdődhet a játék? (y): ");
                Console.WriteLine();
                valasz = Console.ReadLine();
                Console.WriteLine();
            } while ( valasz != "y");
            do
            {
                  Console.Clear();
                if ( kor == 10 )
                {
                    Console.WriteLine(kor + " KÖR! UTOLSÓ MENET!!!!");
                   
                }
                else
                {
                    Console.WriteLine(kor + " KÖR!");
                    
                }
                Console.WriteLine();
                Console.WriteLine(nev + " pontok: " + jatekosPont);
                Console.WriteLine();
                Console.WriteLine(gepNev[veletlenszam] + " pontok: " + gepPont);
                Console.WriteLine();
                Console.WriteLine("| ko | ---- | papir | ---- | ollo | ");
                Console.WriteLine();
                //gép válasz 0 = ko | 1 = papir | 2 = ollo
                int gepValasz = r.Next(0, 3);
                Console.Write("Válassz         "); valasz = Console.ReadLine();
                Console.WriteLine();
                
               
                switch (valasz)
                {

                    // KŐŐŐŐŐŐŐŐŐŐŐŐŐŐŐŐŐŐ
                    case "ko":
                        if (gepValasz == 0)
                        {
                            Console.WriteLine("A választásod: \"" + valasz + "\" ");
                            Console.WriteLine();
                            Console.WriteLine(gepNev[veletlenszam] + " választása: \" ko \"");
                            Console.WriteLine();
                            Console.WriteLine("Döntetlen");
                            Console.ReadKey();
                        }
                        else if (gepValasz == 1)
                        {
                            Console.WriteLine("A választásod: \"" + valasz + "\" ");
                            Console.WriteLine();
                            Console.WriteLine(gepNev[veletlenszam] + " választása: \" papir \"");
                            Console.WriteLine();
                            Console.WriteLine(gepNev[veletlenszam] + " nyert!!!!");
                            kor++;
                            gepPont++;
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("A választásod: \"" + valasz + "\" ");
                            Console.WriteLine();
                            Console.WriteLine(gepNev[veletlenszam] + " választása: \" ollo \"");
                            Console.WriteLine();
                            Console.WriteLine(nev + " nyert!!!");
                            kor++;
                            jatekosPont++;
                            Console.ReadKey();
                        }
                        break;

                    // PAPÍÍÍÍÍÍÍÍÍÍÍÍR
                    case "papir":
                        if (gepValasz == 1)
                        {
                            Console.WriteLine("A választásod: \"" + valasz + "\" ");
                            Console.WriteLine();
                            Console.WriteLine(gepNev[veletlenszam] + " választása: \" papir \"");
                            Console.WriteLine();
                            Console.WriteLine("Döntetlen");
                            Console.ReadKey();
                        }
                        else if (gepValasz == 0)
                        {
                            Console.WriteLine("A választásod: \"" + valasz + "\" ");
                            Console.WriteLine();
                            Console.WriteLine(gepNev[veletlenszam] + " választása: \" ko \"");
                            Console.WriteLine();
                            Console.WriteLine(nev + " nyert!!!");
                            kor++;
                            jatekosPont++;
                            Console.ReadKey();
                        }
                        else if (gepValasz == 2)
                        {
                            Console.WriteLine("A választásod: \"" + valasz + "\" ");
                            Console.WriteLine();
                            Console.WriteLine(gepNev[veletlenszam] + " választása: \" ollo \"");
                            Console.WriteLine();
                            Console.WriteLine(gepNev[veletlenszam] + " nyert!!!");
                            kor++;
                            gepPont++;
                            Console.ReadKey();
                        }
                        Console.WriteLine();
                        break;

                    // OLLÓÓÓÓÓÓÓÓÓÓÓÓ
                    case "ollo":
                        if (gepValasz == 2)
                        {
                            Console.WriteLine("A választásod: \"" + valasz + "\" ");
                            Console.WriteLine();
                            Console.WriteLine(gepNev[veletlenszam] + " választása: \" ollo \"");
                            Console.WriteLine();
                            Console.WriteLine("Döntetlen");
                            Console.ReadKey();
                        }
                        else if (gepValasz == 0)
                        {
                            Console.WriteLine("A választásod: \"" + valasz + "\" ");
                            Console.WriteLine();
                            Console.WriteLine(gepNev[veletlenszam] + " választása: \" ko \"");
                            Console.WriteLine();
                            Console.WriteLine(gepNev[veletlenszam] + " nyert!!!");
                            kor++;
                            gepPont++;
                            Console.ReadKey();
                        }
                        else if (gepValasz == 1)
                        {
                            Console.WriteLine("A választásod: \"" + valasz + "\" ");
                            Console.WriteLine();
                            Console.WriteLine(gepNev[veletlenszam] + " választása: \" papir \"");
                            Console.WriteLine();
                            Console.WriteLine(nev + " nyert!!!");
                            kor++;
                            jatekosPont++;
                            Console.ReadKey();
                        } 
                        Console.WriteLine();
                        break;
                    //minden mas
                    default:
                        Console.WriteLine("Ilyen lehetőség nincs");
                        Console.ReadKey();
                        break;

                }
            } while ( kor <= 10 );
            if( gepPont > jatekosPont)
            {
                Console.Clear();
                Console.WriteLine(nev + " pontok: " + jatekosPont);
                Console.WriteLine();
                Console.WriteLine(gepNev[veletlenszam] + " pontok: " + gepPont);
                Console.WriteLine();
                Console.WriteLine("VÉGE a nyertes: " + gepNev[veletlenszam]);
            } else if ( gepPont == jatekosPont)
            {
                Console.Clear();
                Console.WriteLine(nev + " pontok: " + jatekosPont);
                Console.WriteLine();
                Console.WriteLine(gepNev[veletlenszam] + " pontok: " + gepPont);
                Console.WriteLine();
                Console.WriteLine("VÉGE a nyertes: SENKI XD");
            }
            else
            {
                Console.Clear();
                Console.WriteLine(nev + " pontok: " + jatekosPont);
                Console.WriteLine();
                Console.WriteLine(gepNev[veletlenszam] + " pontok: " + gepPont);
                Console.WriteLine();
                Console.WriteLine("VÉGE a nyertes: " + nev);
            }

            Console.ReadKey();

        }
    }
}
 