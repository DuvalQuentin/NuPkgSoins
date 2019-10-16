// <copyright file="Prestation.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ClassesMetier
{
    using System;

    /// <summary>
    /// Classe prestation.
    /// </summary>
    public class Prestation
    {
        private readonly string libelle;
        private readonly DateTime dateHeureSoin;
        private readonly Intervenant unIntervenant;

        /// <summary>
        /// Initializes a new instance of the <see cref="Prestation"/> class.
        /// Constructeur.
        /// </summary>
        /// <param name="libelle"> Un libelle.</param>
        /// <param name="uneDateHeure"> Date et heure.</param>
        /// <param name="unIntervenant"> unIntervenant de la classe Intervenant .</param>
        public Prestation(string libelle, DateTime uneDateHeure, Intervenant unIntervenant)
        {
            this.libelle = libelle;
            this.dateHeureSoin = uneDateHeure;
            this.unIntervenant = unIntervenant;
        }

        /// <summary>
        /// Gets property de l'objet intervenant ayant réalisé la prestation
        /// (lecture seule).
        /// </summary>
        public Intervenant UnIntervenant
        {
            get { return this.unIntervenant; }
        }

        /// <summary>
        /// Gets property du libelle de la prestation
        /// (lecture seule).
        /// </summary>
        public string Libelle
        {
            get { return this.libelle; }
        }

        /// <summary>
        /// Gets property de la date des soins
        /// (lecture seule).
        /// </summary>
        public DateTime GetsDateHeureSoin
        {
            get { return this.dateHeureSoin; }
        }

        /// <summary>
        /// Retourn l'heure du soin de cette classe.
        /// </summary>
        /// <returns> l'heure les minutes et les secondes. </returns>
        public string HeureSoin()
        {
            return this.GetsDateHeureSoin.Hour + "h" + this.GetsDateHeureSoin.Minute + " - " + this.GetsDateHeureSoin.ToShortTimeString();
        }

        /// <summary>
        /// fonction qui compare 2 dates au format DateHeure
        /// Attention ici, on ne compare que les dates.
        /// 2 dates seront égales si leur JJ/MM/AAAA  sont égaux, quelle que soit l'heure.
        /// </summary>
        /// <param name="unePrestation">.</param>
        /// <returns>
        ///     0 les dates sont égales
        ///     1 si la date de la prestation courante est postérieure à la date de la prestation unePrestation
        ///     -1 si la date de la prestation courante est antérieure à la date de la prestation unePrestation.
        /// </returns>
        public int CompareTo(Prestation unePrestation)
        {
            if (this.GetsDateHeureSoin.Date > unePrestation.GetsDateHeureSoin.Date)
            {
                return 1;
            }
            else
            {
                if (this.GetsDateHeureSoin.Date == unePrestation.GetsDateHeureSoin.Date)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }// bien mieux car on utilise le framework

            // return this.GetsDateHeureSoin.Date.CompareTo(unePrestation.GetsDateHeureSoin.Date);
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return "\t" + this.libelle + " - " + this.dateHeureSoin.ToString() + " - " + this.unIntervenant;
        }

        /// <summary>
        /// Effectuer la somme de 2 nombres.
        /// </summary>
        /// <param name="a"> entier1 à additionner. </param>
        /// <param name="b"> entier2 à additionner. </param>
        /// <returns> entier égal à la somme des deux entiers passés en paramètre. </returns>
        public int SommePourRien(int a, int b)
        {
            return a + b;
        }
    }
}
