public class HouseHold
    {
        public string StudentPersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string HouseHoldID { get; set; }
        public string HouseHoldGuardian { get; set; }
        public string HouseHoldLegalGuardian { get; set; }

        public override String ToString()
        {
        return "\n{\n\tStudentPersonId : " + StudentPersonId +
                  "\n\tFirstName : " + FirstName +             
                  "\n\tLastName : " + LastName +             
                  "\n\tHouseHoldID : " + HouseHoldID +             
                  "\n\tHouseHoldGuardian : " + HouseHoldGuardian + "\n}";             
         } 
    }