// <copyright file="IntervenantExterne.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ClassesMetier
{
    /// <summary>
    /// Classe Intervenant Externe.
    /// </summary>
    public class IntervenantExterne : Intervenant
    {
        private string specialite;
        private string adresse;
        private string tel;

        /// <summary>
        /// Initializes a new instance of the <see cref="IntervenantExterne"/> class.
        /// Constructeur de Intervenant externe.
        /// </summary>
        /// <param name="nom">.</param>
        /// <param name="prenom">..</param>
        /// <param name="specialite">...</param>
        /// <param name="adresse">....</param>
        /// <param name="tel">.....</param>
        public IntervenantExterne(string nom, string prenom, string specialite, string adresse, string tel)
            : base(nom, prenom)
        {
            this.specialite = specialite;
            this.adresse = adresse;
            this.tel = tel;
        }

        /// <summary>
        /// GetsSpecialité.
        /// </summary>
        public string Specialite
        {
            get { return this.specialite; }
        }

        /// <summary>
        /// GetsAdresse.
        /// </summary>
        public string Adresse
        {
            get { return this.adresse; }
        }

        /// <summary>
        /// GetsTel.
        /// </summary>
        public string Tel
        {
            get { return this.tel; }
        }

        /// <summary>
        /// override de tostring.
        /// </summary>
        /// <returns>.</returns>
        public override string ToString()
        {
            return base.ToString() + " Spécialité : " + this.Specialite + "\n\t\t  " + this.Adresse + " - " + this.Tel;
        }
    }
}
