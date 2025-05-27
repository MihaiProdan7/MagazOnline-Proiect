using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace MagazOnline.Models
{
    public class Utilizator
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Parola { get; set; }
        public string Nume { get; set; }
        public string Tip { get; set; }

        public Utilizator() {}

        public static List<Utilizator> IncarcaUtilizatoriDinFisier(string caleFisier)
        {
            if (!File.Exists(caleFisier))
                return new List<Utilizator>();

            string continut = File.ReadAllText(caleFisier);
            return JsonConvert.DeserializeObject<List<Utilizator>>(continut) ?? new List<Utilizator>();
        }
    }
}
