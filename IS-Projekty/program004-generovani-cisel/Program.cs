﻿using System.Runtime.CompilerServices;

string again  = "a";
        while (again == "a"){
        
            Console.Clear();
            Console.WriteLine("**************************");
            Console.WriteLine("*Generátor pseudonáhodných čísel*");
            Console.WriteLine("**************************");
            Console.WriteLine("***********Hejdy**********");
            Console.WriteLine("**************************");
            Console.WriteLine();
            Console.WriteLine();
 
            Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n)) {
                Console.Write("Nezadali jste celé číslo. Zadejte číslo (celé číslo): ");
            }


            Console.Write("Zadejte dolní mez čísel (celé číslo): ");
            int dm;
            while(!int.TryParse(Console.ReadLine(), out dm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu (celé číslo): ");
            }


            Console.Write("Zadejte horní mez čísel (celé číslo): ");
            int hm;
            while(!int.TryParse(Console.ReadLine(), out hm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu (celé číslo): ");
            }

            Console.WriteLine();
            Console.WriteLine("===========================================================");
            Console.WriteLine("Zadané hodnoty: ");
            Console.WriteLine("Počet generovaných čísel: {0}; Dolní mez: {1}; Horní mez: {2}", n, dm, hm);
            Console.WriteLine("===========================================================\n\n");


            //deklarace pole o velikosti n prvků 
            int[] myArray = new int[n];

            //příprava pro generátor náhodných čísel
            Random randomnumber = new Random();

        
            int positive = 0;
            int negative = 0;
            int nuly = 0;

            int suda = 0;  
            int licha = 0;

            for(int i=0;i<n;i++){
                
                myArray[i] = randomnumber.Next(dm,hm+1);
                Console.Write("{0}; ",myArray[i]);


                if(myArray[i] > 0){
                    positive++;
                }
                else if(myArray[i] < 0)
                {
                    negative++;
                }
                else if(myArray[i] == 0)
                {
                    nuly++;
                }

                if(myArray[i] % 2 == 0 ){
                    suda++;
                }
                licha++;

                
            }

                Console.WriteLine("\npocet kladnych: {0} ",positive);
                Console.WriteLine("pocet zapornych: {0} ",negative);
                Console.WriteLine("pocet nul: {0} ",nuly);
                Console.WriteLine("\npocet sudych: {0} ",suda);
                Console.WriteLine("pocet lichych: {0} ",licha);






            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Program muzete opakovat stiskem klavesy 'a' ");
            again = Console.ReadLine();

        }  