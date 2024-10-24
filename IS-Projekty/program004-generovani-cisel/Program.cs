        string again  = "a";
        while (again == "a"){
        
            Console.Clear();
            Console.WriteLine("**************************");
            Console.WriteLine("***Výpis z číselné řady***");
            Console.WriteLine("**************************");
            Console.WriteLine("***********Hejdy**********");
            Console.WriteLine("**************************");
            Console.WriteLine();
            Console.WriteLine();
 
            Console.Write("Zadejte číslo (celé číslo): ");
            int number;
            while(!int.TryParse(Console.ReadLine(), out number)) {
                Console.Write("Nezadali jste celé číslo. Zadejte číslo (celé číslo: ");
            }

            Console.WriteLine();
            Console.WriteLine("===========================================================");
            Console.WriteLine("Zadané hodnoty: ");
            Console.WriteLine("Číslo: {0}", number);
            Console.WriteLine("===========================================================");


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Program muzete opakovat stiskem klavesy 'a' ");
            again = Console.ReadLine();

        }  