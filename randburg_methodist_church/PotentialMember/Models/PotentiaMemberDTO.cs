namespace randburg_methodist_church.Models
{
    public class PotentiaMember
    {
        public Guid Potential_Id { get; set; }
        public string Potential_Fullname { get; set; }
        public string Potential_CellNumber { get; set; }
        public string Potential_EmailAddress { get; set; }
        public string Potential_Location { get; set; }
        public Guid Leader_Id { get; set; }
    }
}
