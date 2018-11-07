using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durchschnitt_berechnen
{
    class Program
    {
        static void Main(string[] args)
        {

            int schüler = 0;
            string noteEingabe;
            bool noteIsZahl;
            int note;
            int noteGesamt = 0;
            float durchschnitt;

            do
            {
                Console.WriteLine("Bitte die Note 1 - 6 des Schülers eingeben. Sobald -1 eingegeben wird, wird der Durchschnitt beerechnet.");
                noteEingabe = Console.ReadLine();
                noteIsZahl = int.TryParse(noteEingabe, out note);
                if (note > 0 && note < 7)
                {
                    schüler++;
                    noteGesamt += note;
                    Console.WriteLine($"Note {note} hinzugefügt. Bisherige Schüler {schüler}");
                }
                else if (note == -1)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Note war nich zwischen 1 - 6. Bitte wiederholen!");
                }



            } while (note != -1);

            durchschnitt = noteGesamt / schüler;
            Console.WriteLine($"Der durchschnitt von den {schüler} Schülern beträgt {durchschnitt}");
            Console.WriteLine("\nZum beenden des Programmes bitte eine Taste drücken.");
            Console.ReadKey();


        }

        
    }
}
