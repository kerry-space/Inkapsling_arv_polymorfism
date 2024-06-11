namespace Inkapsling_arv_polymorfism
{
    public class PermissionError : UserError
    {
        public override string UEMessage()
        {
            return "You do not have the necessary permissions to access this resource.";
        }
    }
}