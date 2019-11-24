using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmo_genettico
{
    
        class Estatistica
        {
            public int MelhorIndividuo;
            public int PiorIndividuo;
            public double AptidaoMelhorIndividuo;
            public double AptidaoPiorIndividuo;

            int i;

            public void GraficoAptidao(int N, Individuo[] individuo)
            {

                double[] x = new double[N];
                for (i = 0; i < N; i++)
                {
                    x[i] = -1 + (3 * individuo[i].genes / 1000);
                }

            }


        }
    }

