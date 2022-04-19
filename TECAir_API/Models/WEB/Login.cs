namespace TECAir_API.Models.WEB
{
    public class Login
    {
        public bool status { get; set; }

        public Login()
        {
        }

        public Login(bool status)
        {
            this.status = status;
        }
    }
}
