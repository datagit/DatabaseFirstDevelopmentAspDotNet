using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models {
    public class CategoryMetadata {

        [MinLength(4)]
        [Display(Name = "CategoryName in metadata")]
        public String CategoryName;
    }
}