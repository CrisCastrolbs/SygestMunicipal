﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SYGESTMunicipal.Areas.OFGA.Models.ViewModel
{
    public class MaterialsViewModel
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de entrada ")]
        public DateTime? Date { get; set; }

        [Display(Name = "Peso (Kg)")]
        public float Weight { get; set; }

        [Display(Name = "Color")]
        public string Color { get; set; }

        [Display(Name = "Tipo de Material")]
        public int MaterialTypeId { get; set; }
        [Display(Name = "Tipo de Material")]
        public int MaterialTypeName { get; set; }
        public int SelectedOption { get; set; }

        public string msgError { get; set; }

        public IEnumerable<SelectListItem> Lista { get; set; }
    }
}
