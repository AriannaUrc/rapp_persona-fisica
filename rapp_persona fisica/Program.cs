using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rapp_persona_fisica
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Persona persona = new Persona();
            Console.WriteLine(persona.Mostra());
        }

        class Persona
        {
            private int codice;
            private string nome;
            private string cognome;
            private bool registrato;

            public Persona(int codice, string nome, string cognome, bool registrato)
            {
                this.codice = codice;
                this.nome = nome;
                this.cognome = cognome;
                this.registrato = registrato;
            }

            public Persona()
            {
                this.codice = 0;
                this.nome = "none";
                this.cognome = "none";
                this.registrato = false;
            }


            public void SetCodice(int codice)
            {
                this.codice = codice;
            }

            public int GetCodice()
            {
                return codice;
            }

            public void SetNome(string nome)
            {
                this.nome = nome;
            }

            public string GetNome()
            {
                return this.nome;
            }

            public void SetCognome(string cognome)
            {
                this.cognome = cognome;
            }

            public string GetCognome()
            {
                return this.cognome;
            }

            public void SetRegistrato(bool registrato)
            {
                this.registrato = registrato;
            }

            public bool GetRegistrato()
            {
                return registrato;
            }



            public void Registra()
            {
                SetRegistrato(true);
            }

            public string Mostra()
            {
                if (this.registrato)
                return "\nCodice: " + codice + "\nNome: " + nome + "\nCognome: " + cognome + "\nRegistrato: " + registrato;

                else
                {
                    return "utente non registrato";
                }
            }
        }
    }
}
