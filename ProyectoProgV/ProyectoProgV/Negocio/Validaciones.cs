using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProgV
{
    class Validaciones
    {
        Random random = new Random();
        public string generarCodigo()
        {
            char[] chars = new char[62];
            chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
            char[] letrasAleatorio = new char[5];

            for (int i = 0; i < letrasAleatorio.Length; i++)
            {
                letrasAleatorio[i] = chars[random.Next(chars.Length)];
            }

            String codigo = new String(letrasAleatorio);

            return codigo;
        
        
        }

        public bool validarCedula(string ced)
        {
            int isNumeric;
            var total = 0;
            const int tamanoLongitudCedula = 10;
            int[] coeficientes = { 2,1,2,1,2,1,2,1,2};
            const int numeroProvincias = 24;
            const int tercerDigito = 6;
            if(int.TryParse(ced, out isNumeric)&& ced.Length== tamanoLongitudCedula)
            {
                var provincia = Convert.ToInt32(string.Concat(ced[0], ced[1], string.Empty));
                var digitoTres = Convert.ToInt32(ced[2]+ string.Empty);
                if((provincia > 0 && provincia <= numeroProvincias) && digitoTres < tercerDigito)
                {
                    var digitoVerificadorRecibido = Convert.ToInt32(ced[9]+string.Empty);
                    for (var k = 0; k < coeficientes.Length; k++ )
                    {
                        var valor = Convert.ToInt32(coeficientes[k]+ string.Empty) * Convert.ToInt32(ced[k] + string.Empty);
                        total = valor >= 10 ? total + (valor - 9) : total + valor;

                    }
                    var digitoVerificadorObtenido= total >= 10? (total%10) != 0? 10- (total%10): (total%10):total;
                    return digitoVerificadorObtenido == digitoVerificadorRecibido;
                }

            }
            return false;
        }

        public bool validarRuc(string ruc)
        {
            long isNumeric;
            const int tamanoLongitudRuc = 13;
            const string establecimiento = "001";
            if(long.TryParse(ruc, out isNumeric)&& ruc.Length.Equals(tamanoLongitudRuc))
            {
                var numeroProvincia = Convert.ToInt32(string.Concat(ruc[0 ] + string.Empty, ruc[1] + string.Empty ));
                var personaNatural = Convert.ToInt32(ruc[2] + string.Empty);
                if((numeroProvincia >=1 && numeroProvincia <=24)&& (personaNatural>= 0 && personaNatural<6))
                {
                    return ruc.Substring(10, 3) == establecimiento && validarCedula(ruc.Substring(0,10));
                }
                return false;
            }
            return false;

        }

      

        public  bool validarEmail(string email)
        {
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (System.Text.RegularExpressions.Regex.IsMatch(email, expresion))
            {
                if (System.Text.RegularExpressions.Regex.Replace(email, expresion, String.Empty).Length == 0)
                { return true; }
                else
                { return false; }
            }
            else
            { return false; }
        }
                






    }
}
