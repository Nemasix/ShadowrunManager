using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Enums;

namespace Domain.Entities
{
    /// <summary>
    /// Represent Shadowrun character
    /// </summary>
    public class Character : BaseEntity
    {
        public required string Codename { get; set; }
        public List<string>? Aliases { get; set; }
        public List<string>? Philosophy { get; set; }
        public string? Background { get; set; }

        #region Attributes
        public required Gender Gender { get; set; }
        public int? Age { get; set; }
        public int? Height { get; set; }
        public int? Weight { get; set; }
        public required Metatype Metatype { get; set; }
        public string? Variant { get; set; }
        public string? Hair { get; set; }
        public string? Eyes { get; set; }
        public string? Skin { get; set; }
        public string? Ethnicity { get; set; }
        public string? GeneralAppearance { get; set; }
        #endregion

        #region Identities
        public required Identity RealIdentity { get; set; }
        public Identity? PrincipalFakeIdentity { get; set; }
        public List<Identity>? SecondariesFakeIdentities { get; set; }
        #endregion

    }
}