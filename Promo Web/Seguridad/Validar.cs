using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Seguridad
{
    public static class Validar
    {
        public static bool SesionActiva(object vouch)
        {
            Voucher voucher = vouch != null ? (Voucher)vouch : null;

            if (voucher != null)
                return true;
            else
                return false;
        }
    }
}
