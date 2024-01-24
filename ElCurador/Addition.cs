
namespace ElCurador
{

    public interface IAddition
    { 
        int SumDigits(int number);
    }
    
    public class Addition: IAddition
    {

        public int SumDigits(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }
    }
}
