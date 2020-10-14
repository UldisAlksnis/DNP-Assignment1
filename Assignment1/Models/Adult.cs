using System.Text.Json;

namespace Assignment1.Models {
public class Adult : Person {

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
}