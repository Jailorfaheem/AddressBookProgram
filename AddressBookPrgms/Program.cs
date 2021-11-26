using System;

namespace AddressBookSystem
{
    class ContactDetails
    {
        //variable declaration
        private string firstname;
        private string lastname;
        private string address;
        private string city;
        private string state;
        private int zip;
        private long phonenumber;

        //creating xonstructor
        public ContactDetails(string firstname, string lastname, string address, string city, string state, int zip, long phonenumber)
        {
            //assigning variables
            this.firstname = firstname;
            this.lastname = lastname;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phonenumber = phonenumber;
        }
        //Displaying details
        public void getDetails()
        {
            Console.WriteLine("Contact details : " + "\nName : " + firstname + " " + lastname + "\nAddress : " + address + "\nCity : " + city + "\nState : " + state + "\nZip Code : " + zip + "\nPhoneNumber = " + phonenumber);
        }


        static void Main(string[] args)
        {
            //creating object of ContactDetails
            ContactDetails contactdetails = new ContactDetails("Faheem", "Jailor", "shaniwar peth", "Solapur", "Maharashtra", 413006, 4785963214);
            contactdetails.getDetails();
            Console.ReadLine();
        }
    }
}