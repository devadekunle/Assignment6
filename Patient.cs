namespace Assignment6
{
    internal class Patient
    {
        public Patient()
        {
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Status { get; set; }
        public decimal Expenses { get; set; }
        public string Age { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string PatientType { get; set; }
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }
        public string Insurance { get; set; }
        public string CopayValue { get; set; }
        public string CopayPercent { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string HospitalName { get; set; }
        public string HopsitalPhone { get; set; }
        public string State { get; internal set; }
        public string ContactPhone { get; internal set; }
    }
}