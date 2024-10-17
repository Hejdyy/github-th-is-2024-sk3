        string again  = "a";
        while (again == "a"){
        
            Console.Clear();
            Console.WriteLine("**************************");
            Console.WriteLine("***Vykreslování obrazců***");
            Console.WriteLine("*********Obdelník*******");
            Console.WriteLine("***********Hejdy**********");
            Console.WriteLine("**************************");
            Console.WriteLine();
            Console.WriteLine();
 
            Console.Write("Zadejte šířku obrazce (kladné celé číslo): ");
            uint width;
            while(!uint.TryParse(Console.ReadLine(), out width)) {
                Console.Write("Nezadali jste celé kladné číslo. Zadejte šířku znovu: ");
            }

            Console.Write("Zadejte výšku obrazce (kladné celé číslo): ");
            uint heigth;
            while(!uint.TryParse(Console.ReadLine(), out heigth)) {
                Console.Write("Nezadali jste celé kladné číslo. Zadejte výšku znovu: ");
            }

            Console.WriteLine();
            Console.WriteLine("===========================================================");
            Console.WriteLine("Zadané hodnoty: ");
            Console.WriteLine("Šířka: {0}", width);
            Console.WriteLine("Výška: {0}", heigth);
            Console.WriteLine("===========================================================");


            
            for(int i = 1;i<=heigth;i++){
                for(int j = 1;j<=width;j++){
                    Console.Write("* ");
                }
                Console.Write("\n");
            }

           





            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Program muzete opakovat stiskem klavesy 'a' ");
            again = Console.ReadLine();

        }  