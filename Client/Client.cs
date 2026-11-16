using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travailCredit
{
    public class Client
    {
        private int numeroClient;
        private string nomClient;
        private string prenomClient;

        public Client()
        {

        }

        public Client(string nomCli, string prenomCli)
        {
            numeroClient = 0;
            nomClient = nomCli;
            prenomClient = prenomCli;
        }

        public void setInfo(string nomCli, string prenomCli)
        {
            numeroClient = 0;
            nomClient = nomCli;
            prenomClient = prenomCli;
        }

        public string getInfo()
        {
            return numeroClient + nomClient + prenomClient;
        }

        public int getNumero()
        {
            return numeroClient;
        }

        public void setNumero()
        {
            numeroClient += 1;
        }
        public string getNomClient()
        {
            return nomClient;
        }

        public void setNomClient(string nomCli)
        {
            nomClient = nomCli;
        }

        public string getPrenomClient()
        {
            return prenomClient;
        }

        public void setPrenomClient(string prenomCli)
        {
            prenomClient = prenomCli;
        }


    }
}
