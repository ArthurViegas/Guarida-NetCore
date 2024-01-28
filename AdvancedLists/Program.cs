namespace Program
{
    using System;
    public static class AdvancedListUtils
    {
        public static void Main()
        {
            List<string> originalList = ["maçã", "banana", "banana", "laranja", "banana", "maçã", "banana"];
            
            ImprimirLista(originalList, "Lista Original");

            var orderedList = OrdenarPorFrequencia(originalList);

            ImprimirLista(orderedList, "Lista Ordenada");
        }

        public static List<string> OrdenarPorFrequencia(List<string> lista)
        {
            return lista.GroupBy(x => x)
                                  .OrderByDescending(y => y.Count())
                                  .Select(y => y.Key)
                                  .ToList();
        }

        static void ImprimirLista(List<string> list, string description)
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
