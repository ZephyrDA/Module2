using System;

namespace Module2.Models
{
    public class Cercle : Forme
    {
        public int Rayon { get; set; }

        public override double Aire => Math.PI * Rayon * Rayon;

        public override double Perimetre => 2 * Math.PI * Rayon;

        public override string ToString()
        {
            return $"rayon {Rayon}" + Environment.NewLine + base.ToString();
        }
    }
}