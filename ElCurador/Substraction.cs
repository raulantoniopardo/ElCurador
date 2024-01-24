namespace ElCurador
{

    public interface ISubstraction
    {
        int Execute(int number);
    }
    public class Substraction: ISubstraction
    {
        public int Execute(int number)
        {
            return number - 9;
        }
    }
}
