using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travailCredit
{
    class Globales
    {
        // static, ce qui signifie que toutes les parties de l'application partagent les mêmes valeurs pour ces variables

        public static FrmEnregistrement fenEnregistrement;

        public static FrmCredit fenCredit;

        public static List<Crédit.Crédit> listeCrédits = new List<Crédit.Crédit>();

        public static Client unClient = new Client();

    }
}
