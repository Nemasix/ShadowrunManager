using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Enums;

namespace Domain.Entities
{
    /// <summary>
    /// Represent Shadowrun Identity
    /// </summary>
    public class Identity : BaseEntity
    {
        public string Name { get; set; }
        public string Nationality { get; set; }
        public string Birthplace { get; set; }
        public string FamilyStatus { get; set; }
        public string Dependents { get; set; }
        public IdentityStatus Status { get; set; }
        public int Indice { get; set; }
        public string Informations { get; set; }
        public List<string> Licenses { get; set; }
        public Lifestyle Lifestyle { get; set; }
    }
}