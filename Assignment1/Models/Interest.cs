using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Assignment1.Models {
public class Interest {
    [Key]
    public string Type { get; set; }

    [JsonIgnore]
    public List<ChildInterest> ChildInterests { get; set; }

}
}