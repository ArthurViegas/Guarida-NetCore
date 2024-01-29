namespace Program
{
    using System;
    public static class AdvancedListUtils
    {
        public static void Main()
        {
            List<string> originalList = ["maçã", "banana", "banana", "laranja", "banana", "maçã", "banana"];
            
            WriteList(originalList, "Lista Original");

            var orderedList = OrdenarPorFrequencia(originalList);

            WriteList(orderedList, "Lista Ordenada");
        }

        public static List<string> OrdenarPorFrequencia(List<string> list)
        {
            return list.GroupBy(x => x)
                                  .OrderByDescending(y => y.Count())
                                  .Select(y => y.Key)
                                  .ToList();
        }

        private static void WriteList(List<string> list, string description)
        {
            Console.WriteLine($"{description}: ");

            foreach (var elemento in list)
            {
                Console.Write($"{elemento} ");
            }
            Console.WriteLine();
        }
    }
}
