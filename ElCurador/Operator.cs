namespace ElCurador
{
    public class Operator
    {
        IAddition addition;
        ISubstraction substraction;

        public ISubstraction Susbtraction
        {
            get { return substraction; }
            set { substraction = value; }
        }

        public IAddition Addition
        {
            get { return addition; }
            set { addition = value; }
        }

        public Operator() 
        {
            addition = new Addition();
            substraction = new Substraction();
        }   

        //public int operation1(int valor)
        //{
        //    switch (valor)
        //    {
        //        case 1:
        //            return 1;
        //        case 2:
        //            return 2;
        //        default:
        //            return 1;
        //    }
        //}

        public int Execute(int valor)
        {
            return Multiply(valor);
        }

        private int Multiply(int valor)
        {          
            int product = valor * 8;
            var sum = addition.SumDigits(product);
            return substraction.Execute(sum);
        }

    }
}
