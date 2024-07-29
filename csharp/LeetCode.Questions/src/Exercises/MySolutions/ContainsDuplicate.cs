namespace Exercises.MySolutions;

    public class ContainsDuplicate
    {
        /*
        static void Main()
        {
            int[] numbers = {1,3,3,4};
            var Cd = new ContainsDuplicate();
            Cd.HasDuplicateElements(numbers);
        }
        */
         public bool HasDuplicateElements(int[] numbers)
        {
            var numbersList = new List<int>();

            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbersList.Contains(numbers[i]))
                {
                Console.WriteLine("Há valores duplicados");
                return true; 
                }

                numbersList.Add(numbers[i]); 
            }
            Console.WriteLine("Não há valores duplicados");
            return false;
            
        }
    }
