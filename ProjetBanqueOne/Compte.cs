using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetBanqueOne
{
    public class Compte
    {
        private int _compteId;

        private float _decouvert;

        private float _solde;

        private string _nom;

        public Compte()
        {
            _decouvert = 0;
            _solde = 0;

        }
        public Compte(int compteID, string nom, float solde, float decouvert)
        {
            _compteId = compteID;
            _nom = nom;
            _solde = solde;
            _decouvert = decouvert;
        }
        private bool CheckIfDebitIsPossible(float number)
        {
            float newValue = this._solde - number;

            bool response = false;
            if (newValue >= this._decouvert )
            {
               response = true;
            }
            return response;
        }
        public float Debiter(float number)
        {
             if(CheckIfDebitIsPossible(number))
            {
                this._solde -= number;
            }
            return this._solde;
        }

        public float Transferer(Compte transfertToCompte, float number)
        {
            if (CheckIfDebitIsPossible(number))
            {
                this._solde -= number;
                transfertToCompte.Crediter(number);
            }
            return this._solde;
        }

        public float Crediter(float number)
        {
            return this._solde += number;
        }

        public string GetNom()
        {
            return this._nom;
        }
        public int GetNumero()
        {
            return this._compteId;
        }

        public float GetSolde()
        {
            return this._solde;
        }

        public float GetDebitAutorise()
        {
            return this._decouvert;
        }
         public override string ToString()
        {
            return $"Numero: {this._compteId}, Nom: {this._nom}, Solde {this._solde} Découvert {this._decouvert}";
        }
        public bool Superieur(Compte c)
        {
            bool resp = false;
            return this._solde > c.GetSolde();
        }
    }
}

