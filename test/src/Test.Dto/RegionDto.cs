using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyCompany.Dto {

    public class RegionDto {

        public long Id { get; set; }

        public string RegionName { get; set; }
        public UserDto User { get; set; }


        // jhipster-needle-dto-add-field - JHipster will add fields here, do not remove
    }
}
