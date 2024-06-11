namespace Inkapsling_arv_polymorfism
{
    public class ConnectionError : UserError
    {
        public override string UEMessage()
        {
             return "There was a connection error. Please check your internet connection.";

        }
    }
}