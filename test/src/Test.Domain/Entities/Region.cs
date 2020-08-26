using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyCompany.Domain {
    [Table("region")]
    public class Region {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public string RegionName { get; set; }
        public string UserId { get; set; } 
        public User User { get; set; }

        // jhipster-needle-entity-add-field - JHipster will add fields here, do not remove

        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if (obj == null || GetType() != obj.GetType()) return false;
            var region = obj as Region;
            if (region?.Id == null || region?.Id == 0 || Id == 0) return false;
            return EqualityComparer<long>.Default.Equals(Id, region.Id);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return "Region{" +
                    $"ID='{Id}'" +
                    $", RegionName='{RegionName}'" +
                    "}";
        }
    }
}
