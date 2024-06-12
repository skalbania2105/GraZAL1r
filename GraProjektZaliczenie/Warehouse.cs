using Figgle;
using Pastel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraProjektZaliczenie
{
    //klasa odpowiadająca za przechowywanie przedmiotów zbieranych w trakcie gry
    static class Warehouse
    {
        public static int wood = 0;
        public static int choppedWood = 0;
        public static int food = 0;
        public static int medicine = 3;


        //metoda zwracająca stan magazynu do wglądu przez użytkownika
        public static string DisplayWarehouseState()
        {
            string text = FiggleFonts.Small.Render("Magazyn").Pastel("#2E2EFF");
            return $"{text}\n{"Kawałki drewna:".Pastel("#964B00")} {wood}\n\n{"Posiekane drewno:".Pastel("#964B00")} {choppedWood}\n\n{"Jedzenie:".Pastel("#FF2E2E")} {food}\n\n{"Lekarstwa:".Pastel("#ff0000")} {medicine}\n";
        }
    }
}
