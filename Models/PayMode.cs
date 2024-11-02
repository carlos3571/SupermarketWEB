﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SupermarketWEB.Models
{
    public class PayMode
    {
        public int Id { get; set; }

        [DisplayName("Pay Mode txtCategoryName")]
        [Required(ErrorMessage = "Pay Mode txtCategoryName is required")]
        [StringLength(50, MinimumLength = 3,
            ErrorMessage = "Pay Mode txtCategoryName must be between 3 and 50 characters")]
        public string PayModeName { get; set; }

        [DisplayName("Observation")]
        [Required(ErrorMessage = "Pay Mode Observation is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Pay Mode Observation must be between 3 and 200 characters")]
        public string PayModeObservation { get; set; }
    }
}
