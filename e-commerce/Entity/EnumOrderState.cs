using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace e_commerce.Entity
{
    public enum EnumOrderState
    {
        [Display(Name="Onay Bekliyor")]
        Waiting,
        [Display(Name = "Onaylandı")]
        Completed
    }
}