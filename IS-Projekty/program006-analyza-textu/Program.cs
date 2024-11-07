        string again  = "a";
        while (again == "a"){
        
            Console.Clear();
            Console.WriteLine("**************************");
            Console.WriteLine("*********Analýza textu********");
            Console.WriteLine("**************************");
            Console.WriteLine("***********Hejdy**********");
            Console.WriteLine("**************************");
            Console.WriteLine();
            Console.WriteLine();
 
            Console.Write("\n\nZadejte text pro Analýz:");
            string mujText = Console.ReadLine();


            Console.WriteLine();
            Console.WriteLine(mujText);
            Console.WriteLine(mujText[0]);
            Console.WriteLine(mujText.Length);
            Console.WriteLine(mujText[mujText.Length-1]);

            int pocetSouhlasek = 0;
            int pocetSamohlasek = 0;
            int pocetCislic = 0;
            int pocetOstatnich = 0;


            string samohlasky = "aáeéěiíoóuůúyýAÁEÉĚIÍOÓUŮÚYÝ";
            string souhlasky = "bcčdďfghjklmnňpqrřsštťvwxzžBCČDDĎFGHJKLMNŇPQRŘSŠTŤVWXZŽ";
            string cislice = "0123456789";

            foreach(char znak in mujText){
                if(souhlasky.Contains(znak)){
                    pocetSouhlasek++;
                }
                else if(samohlasky.Contains(znak)){
                    pocetSamohlasek++;
                }
                else if(cislice.Contains(znak)){
                    pocetCislic++;
                }
                else{
                    pocetOstatnich++;
                }

                

            }
                Console.WriteLine("\nPocet Samohlasek: {0}",pocetSamohlasek);
                Console.WriteLine("Pocet Souhlasek: {0}",pocetSouhlasek);
                Console.WriteLine("Pocet Cislic: {0}",pocetCislic);
                Console.WriteLine("Pocet Ostatnich znaku: {0}",pocetOstatnich);



            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Program muzete opakovat stiskem klavesy 'a' ");
            again = Console.ReadLine();

        }  