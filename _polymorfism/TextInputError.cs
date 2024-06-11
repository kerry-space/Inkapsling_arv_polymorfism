using Inkapsling_arv_polymorfism;


namespace Inkapsling_arv_polymorfism
{
    public class TextInputError : UserError
    {
        public override string UEMessage()
        {
             return "You tried to use a text input in a numeric only field. This fired an error!";
        }
    }
}