using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Numero
    {
        private double _numero; //variable

        #region CONSTRUCTORES

        public Numero() //constructor por defecto
        {
            _numero = 0;
        }

        public Numero(double numero)
        {
            this._numero = numero;
        }

        public Numero(string numero)
        {
            validarNumeroString(numero);
        }
        #endregion

        #region METODOS

        /// <summary>
        /// para obtener los numeros
        /// </summary>
        /// <returns></returns>
        public double getNumero()
        {
            return _numero;
        }



        private void setNumero(string num)
        {
            this._numero = Convert.ToDouble(num);
        }


        /// <summary>
        /// Valida que coincida el tipo
        /// </summary>
        /// <param name="numeroString"></param>
        /// <returns></returns>
        private double validarNumeroString(string numeroString)
        {
            double validar;
            bool isDouble = false;

            isDouble = Double.TryParse(numeroString, out validar);
            if (isDouble == true)
            {
                setNumero(numeroString);

            }
            return this._numero;
        }

    }
}
        #endregion
