/*
 
 4. "Raqamni toping" o'yini:
1 dan 100 gacha bo'lgan tasodifiy sonni yaratadigan dastur yarating va 
keyin foydalanuvchidan bu raqamni taxmin qilishni so'raydi. 
Dastur sirli raqam foydalanuvchi kiritgan raqamdan katta yoki 
kichik ekanligi haqida maslahatlar berishi kerak. 

Ternary operatoridan va Random dan foydalaning
 
 */

 using System;
 namespace Tanlash
 {
    class Program{
        static void Main(){
            System.Console.WriteLine("Tasodifiy raqam tanlanyapti...");
            Random random = new Random();
            int variable = random.Next(1, 3);
            System.Console.Write("Raqam tanlandi. Taxmin qilib ko'ring: ");
            int prediction = Convert.ToInt32(Console.ReadLine());
            if(prediction == variable){
                System.Console.WriteLine("Ajoyib!\nTaxminingiz to'g'ri chiqdi. Davom etishni xohlaysizmi? (Ha/Yo'q)");
                string userInput = Console.ReadLine().ToLower();
                if(userInput == "ha"){
                    Main();
                }
                else{
                    System.Console.WriteLine("Dastur tugatildi.");
                }
            }
            else{
                System.Console.WriteLine("Xato! Dastur tugatildi.");
            }
        }
    }
 }