using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Calculadora
    {
        #region METODOS


        /// <summary>
        /// Realiza las operaciones correspondientes
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        public static double operar(Numero numero1, Numero numero2, string operador)
        {
            double rdo = 0;
            switch (validarOperador(operador))
            {
                case "+":
                    rdo = numero1.getNumero() + numero2.getNumero();
                    break;

                case "-":
                    rdo = numero1.getNumero() - numero2.getNumero();
                    break;

                case "*": rdo = numero1.getNumero() * numero2.getNumero();
                    break;

                case "/":
                        rdo = numero1.getNumero() / numero2.getNumero();
                    break;
            }
            return rdo;
        }


        /// <summary>
        /// Valida que los operadores sean suma resta multiplicacion y division, 
        /// en el caso de no elegir se asigna directamente suma
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>
        public static string validarOperador(string operador)
        {
            if (operador != "+" && operador != "-" && operador != "*" && operador != "/")
            {
                return "+";
            }
            else
            {
                return operador;
            }
        }

        #endregion
    }

}
