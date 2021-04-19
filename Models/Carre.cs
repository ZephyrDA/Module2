using System;

namespace Module2.Models
{
    public class Carre : Rectangle
    {
        public override int Largeur => Longueur;

        public override string ToString()
        {
            return $"coté={Longueur}" + Environment.NewLine + base.ToString(true);
        }
    }
}