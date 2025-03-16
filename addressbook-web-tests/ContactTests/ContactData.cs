namespace WebAddressbookTests
{
    internal class ContactData
    {
        private string firstname;
        private string middlename;
        private string lastname;
        private string nickname;
        private string title;
        private string company;
        private string address;
        private string home;
        private string homepage;
        private string mobile;
        private string work;
        private string fax;
        private string email;
       


        public ContactData(string firstname, string middlename, string lastname, string nickname)
        {
            this.firstname = firstname;
            this.middlename = middlename;
            this.lastname = lastname;
            this.nickname = nickname;
        }
        public string FirstName { get { return firstname; } set { firstname = value; } }
        public string MiddleName { get { return middlename; } set { middlename= value; } }
        public string LastName { get { return lastname; } set { lastname = value; } }
        public string Nickname{ get { return nickname; } set { nickname = value; } }
        public string Title{ get { return title; } set { title = value; } }
        public string Company{ get { return company; } set { company = value; } }
        public string Address{ get { return address; } set { address = value; } }
        public string Home{ get { return home; }    set { home = value; } }
        public string HomePage{ get { return homepage; }    set { homepage = value; } }
        public string Mobile{ get { return mobile; } set { mobile = value; } }
        public string Work { get { return work; } set { work = value; } }
        public string Fax { get { return fax; } set { fax = value; } }
        public string Email{ get { return email; } set { email = value; } }
   
    }
}
