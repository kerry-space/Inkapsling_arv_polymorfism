namespace Inkapsling_arv_polymorfism
{
    public class LoginError : UserError
    {
        public override string UEMessage()
        {
            return "There was an error during login. Please check your credentials.";

        }
    }
}