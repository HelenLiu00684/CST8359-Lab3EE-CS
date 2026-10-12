namespace Lab3EE.Models
{
     // Represents one workshop registration.
     public class Rsvp
     {
          // Stores the participant's full name.
          public string FullName { get; set; } = string.Empty;

          // Stores whether the participant needs accommodation.
          public bool NeedsAccommodation { get; set; }

          // Stores the selected workshop title.
          public string WorkshopTitle { get; set; } = string.Empty;
     }
}
