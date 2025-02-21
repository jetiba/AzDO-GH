namespace NetTestDemo.App
{
    public class Logic
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            return a / b;
        }

        public int[] CharacterCount(string input)
        {
            int[] counts = new int[256]; // Assuming ASCII characters
            foreach (char c in input)
            {
                counts[(int)c]++;
            }
                return counts;
        }
    }
}
