using System;

namespace PatternAdapter
{
    public class EnchufeBritanico : IEnchufeIngles
    {
        public int[] Flujo110V()
        {
            int[] arrayFlujo = new int[100];
            Random r = new Random();
            for (int i = 0; i < arrayFlujo.Length; i++)
            {
                // Calculamos la fluctuacion del voltaje
                int fluctuacion = r.Next(100) > 50 ? 1 : -1;    // Positiva o negativa
                fluctuacion = fluctuacion * (r.Next(7) + 1);    // El valor fluctuara entre -7 y +7

                // Valor total entre 103 y 117V
                arrayFlujo[i] = fluctuacion + 110;
            }

            return arrayFlujo;
        }

        public int getNumeroBornes()
        {
            return 3;
        }
    }
}
