namespace refractor4_demo
{
    public class Address
    {
        private string _street = string.Empty;
        private string _city = string.Empty;
        private string _state = string.Empty;
        private int _postalCode = 0;

        public Address(string street, string city, string state, int postalCode)
        {
            this._street = street;
            this._city = city;
            this._state = state;
            this._postalCode = postalCode;
        }
        
        public override string ToString()
        {
            return _street + " " + _city + " " + _state + " " + _postalCode;
        }
    }
    public class Customer
    {
        private string _firstName = string.Empty;
        private string _lastName = string.Empty;
        private Address _address = null;

        public string GetFirstName()
        {
            return _firstName;
        }
        public string GetLastName()
        {
            return _lastName;
        }

        public Customer(string firstName, string lastName, string street, string city, string state, int postalCode)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            // this._street = street;
            // this._city = city;
            // this._state = state;
            // this._postalCode = postalCode;
            this._address = new Address(street, city, state, postalCode);
        }
        public Customer(string firstName, string lastName, Address address)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._address = address;
        }
    }
}
