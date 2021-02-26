namespace parlem.domain.Models.Customer
{
    public class Customer
    {
        private int customerId;
        private string docType;
        private string docNum;
        private string email;
        private string givenName;
        private string familyName1;
        private string phoneNumber;

        public int CustomerId { get => customerId; set => customerId = value; }
        public string DocType { get => docType; set => docType = value; }
        public string DocNum { get => docNum; set => docNum = value; }
        public string Email { get => email; set => email = value; }
        public string GivenName { get => givenName; set => givenName = value; }
        public string FamilyName1 { get => familyName1; set => familyName1 = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
    }
}
