namespace GenericConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Generics Concepts Problems");
            Console.WriteLine("Select any one option \n 1. Delete Int Element \n 2. Delete Double Element \n" +
                " 3. Delete Char Element");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    int[] intArry = DeleteArrayElement.GetIntElement();
                    Console.WriteLine("Plese pick up any one elemnt");
                    int delete = Convert.ToInt32(Console.ReadLine());
                    DeleteArrayElement.DeleteIntElement(intArry, delete);
                    break;

                case 2:
                    double[] doubleArry = DeleteArrayElement.GetDoubleElement();
                    Console.WriteLine("Plese pick up any one elemnt");
                    double doubleDelete = Convert.ToDouble(Console.ReadLine());
                    DeleteArrayElement.DeleteDoubleElement(doubleArry, doubleDelete);
                    break;

                case 3:
                    char[] charArry = DeleteArrayElement.GetCharElement();
                    Console.WriteLine("Plese pick up any one elemnt");
                    char charDelete = Convert.ToChar(Console.ReadLine());
                    DeleteArrayElement.DeleteCharElement(charArry, charDelete);
                    break;

                default:
                    Console.WriteLine("Please Enter Right Option number From given List");
                    break;
            }
        }
    }
}