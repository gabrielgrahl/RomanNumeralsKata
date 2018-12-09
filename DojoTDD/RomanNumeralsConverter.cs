using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DojoTDD.Tests
{
    public class RomanNumeralsConverter
    {
       public int ConverterNumerosRomanos(string numeros)
        {
            var retorno = 0;

            for (var i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == 'I')
                {
                    retorno += 1;
                }
                if (numeros[i] == 'V')
                {
                    if (i > 0 && numeros[i - 1] == 'I')
                    {
                        retorno += 3;
                    }
                    else
                    {
                        retorno += 5;
                    }
                }
                if (numeros[i] == 'X')
                {
                    if (i > 0 && numeros[i - 1] == 'I')
                    {
                        retorno += 8;
                    }
                    else
                    {
                        retorno += 10;
                    }
                }
                if (numeros[i] == 'C')
                {
                    if (i > 0 && numeros[i - 1] == 'X')
                    {
                        retorno += 80;
                    }
                    else
                    {
                        retorno += 100;
                    }
                }
                if (numeros[i] == 'L')
                {
                    if (i > 0 && numeros[i - 1] == 'X')
                    {
                        retorno += 30;
                    }
                    else
                    {
                        retorno += 50;
                    }                   
                }
                if (numeros[i] == 'D')
                {
                    if (i > 0 && numeros[i - 1] == 'C')
                    {
                        retorno += 300;
                    }
                    else
                    {
                        retorno += 500;
                    }                 
                }
                if (numeros[i] == 'M')
                {
                    if (i > 0 && numeros[i - 1] == 'C')
                    {
                        retorno += 800;
                    }
                    else
                    {
                        retorno += 1000;
                    }                   
                }
            }
            
            return retorno;
        }     
    }
}
