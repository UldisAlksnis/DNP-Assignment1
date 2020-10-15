using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Assignment1.Models
{
    public class Adult : Person
    {
        [NotNull]
        [ValidJobTitle]
        public string JobTitle { get; set; }
        
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }

        public void Update(Adult toUpdate)
        {
            JobTitle = toUpdate.JobTitle;
            base.Update(toUpdate);
        }
    }
    
    public class ValidJobTitle : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            List<string> valid = new[]
            {
                "teacher", "engineer", "garbage collector", "shepherd",
                "pilot", "police officer", "pirate", "fireman", "astronaut", "captain", "soldier", "pizza chef",
                "chef", "janitor", "factory worker", "chauffeur", "waitress", "ninja", "doctor", "nurse", "chemist",
                "caretaker", "gardener", "mascot", "athlete"
            }.ToList();
            if (valid == null || valid.Contains(value.ToString().ToLower())) {
                return ValidationResult.Success;
            }

            return new ValidationResult("This is not a valid job title");
        }
    }
}