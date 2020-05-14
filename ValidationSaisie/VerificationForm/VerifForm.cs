using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace VerificationForm
{
    public static class VerifForm
    {

        static List<string> errors = new List<string>();

        public static List<string> Errors { get => errors; set => errors = value; }

        public static List<string> VerificationMontant(string montant)
        {
            string motif = @"^[0-9]{1,}?[.0-9]{0,}";

            List<string> errorsMontant = new List<string>();

            if(!Regex.IsMatch(montant, motif))
            {
                errorsMontant.Add("Le montant est invalide");
            }
            return errorsMontant;

        }

        public static List<string> VerificationNom(string nom)
        {
            string motif = @"^[A-Za-z]+$";

            List<string> errorsNom = new List<string>();

            if (!Regex.IsMatch(nom, motif))
            {
                Errors.Add("Le nom est invalide");
                errorsNom.Add("Le nom est invalide");
            }

            return errorsNom;
        }


        public static List<string> VerificationDate(string date, out DateTime newDate)
        {

            List<string> errorsDate = new List<string>();

            string[] dateArray;

            newDate = DateTime.MinValue;

            dateArray = date.Split('/');

            bool jourTempValide = false;

            bool moisTempValide = false;

            bool anneeTempValide = false;

            bool dateParTrois = dateArray.Length == 3;

            int jour = 0;
            int mois = 0;
            int annee = 0;

            if (dateParTrois)
            {
                jourTempValide = int.TryParse(dateArray[0], out jour);
                moisTempValide = int.TryParse(dateArray[1], out mois) && mois < 13 && mois > 0;
                anneeTempValide = int.TryParse(dateArray[2], out annee);
            }
            

            bool dateExist = DateTime.TryParse(date, out newDate);


            if (!dateExist)
            {
                if (moisTempValide && anneeTempValide && jour > DateTime.DaysInMonth(annee, mois))
                {
                    errorsDate.Add("La combinaison jour/mois/année est invalide");
                }
                else if(jourTempValide || moisTempValide || anneeTempValide){

                    if (!jourTempValide)
                    {
                        errorsDate.Add("Le jour est invalide");
                    }
                    if (!moisTempValide)
                    {
                        errorsDate.Add("Le mois est invalide");
                    }

                    if (!anneeTempValide)
                    {
                        errorsDate.Add("L'année est invalide");
                    }
                }
                else
                {
                    errorsDate.Add("Le format de la date est invalide");
                }
            }
            else if(newDate > DateTime.Now)
            {
                errorsDate.Add("La date doit être inférieure à aujourd'hui");
            }

            //Nous ajoutons nos erreurs à la liste globale
            if (errorsDate.Count > 0)
            {
                foreach (string error in errorsDate)
                {
                    Errors.Add(error);
                }
            }

            return errorsDate;
        }

        public static List<string> VerificationCodePostal(string codePostal)
        {

            string motif = @"^[0-9]{5}$";

            List<string> errorsCP = new List<string>();

            if (!Regex.IsMatch(codePostal, motif))
            {
                Errors.Add("Le Code Postal est invalide");
                errorsCP.Add("Le Code Postal est invalide");
            }
            return errorsCP;

        }

        public static void ClearError()
        {
            Errors.Clear();
        }
    }
}
