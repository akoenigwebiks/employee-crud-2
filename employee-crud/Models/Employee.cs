namespace employee_crud.Models
{
    public class UserForm
    {
        public string ID { get; set; }
        public string Nat { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public GenderEnum Gender { get; set; }
        public bool HasCar { get; set; }
        public MaritalStatusEnum MaritalStatus { get; set; }


        public enum GenderEnum
        {
            Male,
            Female
        }

        public enum MaritalStatusEnum
        {
            Single,
            Married,
            Divorced,
            Widowed
        }

        public UserForm()
        {
            // give default values to the properties
            ID = Guid.NewGuid().ToString();
            Nat = "";
            FirstName = "";
            LastName = "";
            Email = "";
            PhoneNumber = "";
            Address = "";
            City = "";
            PostalCode = "";
            MaritalStatus = MaritalStatusEnum.Single;
            Gender = GenderEnum.Male;
        }

        // Method to validate Israeli ID number based on the algorithm provided
        private bool IsValidIsraeliID(string id)
        {
            if (id == null || id.Length > 9 || !id.All(char.IsDigit))
            {
                return false;
            }

            id = id.PadLeft(9, '0'); // Pad the ID to ensure it is exactly 9 digits

            int checkSum = 0;
            for (int i = 0; i < id.Length; i++)
            {
                int digit = id[i] - '0'; // Convert char to int
                int weight = (i % 2 == 0) ? 1 : 2; // Assign weight 1 or 2 based on position

                int product = digit * weight;
                if (product > 9)
                {
                    product = (product % 10) + 1; // Sum the digits of the product
                }

                checkSum += product;
            }

            return checkSum % 10 == 0; // Check if the sum is divisible by 10
        }
    }
}


