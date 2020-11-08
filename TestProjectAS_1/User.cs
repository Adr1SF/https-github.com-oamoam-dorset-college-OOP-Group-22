using System;
namespace TestProjectAS_1
{
    public abstract class User
    {
        public string lastName { get; }
        public string firstName { get; }
        public string login { get; }
        public string password { get; }
        public int userID { get; }

        public User(string lastName, string firstName, string login, string password, int userID)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.login = login;
            this.password = password;
            this.userID = userID;
        }

        public string PublicInformation()
        {
            return $" The public information are : \n First Name : {firstName} \n Last Name : {lastName} \n ID : {userID} \n";
        }
        public string PersonalInformation()
        {
            return $"Your personal information are : \n First Name : {firstName} \n Last Name : {lastName} \n ID : {userID} \n e-mail : {login} \n password : {password} \n";
        }

        //Creer des fonctions qui permettent de savoir en fonction infos si appartient à list student...
    }
}
