﻿namespace StarwarsGame.Core.Models
{
    /// <summary>
    /// fjskgjfhdk
    /// </summary>
    //[Table("")] a ne pas faire : dependance non voulue
    public class Wookiee
    {
        public Wookiee() : this("", 10000)
        {
        }

        public Wookiee(string name, int nbPoils)
        {
            this.Name = name;
            this.NbPoils = nbPoils;
        }

        public void SeDeplacer(IMoyenDeplacement deplacement)
        {
            deplacement.Deplacer();
        }

        //[Key]
        public int Id { get; set; } = 1;
        public string? Name { get; private set; }

        public int NbPoils { get; init; }

        public IEnumerable<Weapon> Weapons { get; init; } = new List<Weapon>();

        public Weapon? MainWeapon => this.Weapons.FirstOrDefault(item => item.IsMain);

        public List<Role> Roles { get; set; } = new List<Role>();

        public Grade Grade { get; set; } = Grade.Caporal;
    }
}