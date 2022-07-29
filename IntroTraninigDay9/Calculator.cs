using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroTraninigDay9
{
    public class Calculator
    {
        public int Adunare(int primulNumar, int alDoileaNumar)
        {
            int rezultat = primulNumar + alDoileaNumar;
            return rezultat;
        }
        public float Scadere(float primulNumar, float alDoileaNumar)
        {
            float rezultat = (float)primulNumar - alDoileaNumar;
            return rezultat;
        }
        public int Inmultire(int primulNumar, int alDoileaNumar)
        {
            int rezultat = primulNumar * alDoileaNumar;
            return rezultat;
        }
        public float Impartire(int primulNumar, int alDoileaNumar)
        {
            float rezultat = (float)primulNumar / alDoileaNumar;
            return rezultat;
        }
    }
}
