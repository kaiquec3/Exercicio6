using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_6
{
    class MilhaMar    
    {
        double valor;
        double convertido;

        public void SetValor(double p)
        {
            valor = p;
        }

        public double GetValor()
        {
            return valor;
        }

        public double GetConvertido()
        {
            return convertido;
        }

        public double ConverterMilhaMarParaMetros()
        {
            convertido = valor * 1852;
            return convertido;
        }

    }
}
