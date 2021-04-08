namespace PropellerTorkenMain.Models
{
    public class Admin
    {
        public int Id { get; set; }
        public bool isAdmin { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
    }
}