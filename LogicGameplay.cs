using System;
namespace _50
{
   
   class LogicGameplay
    {
        public void Gameplay()//สุ่มคำ และสร้าง ____ คำใบ้...
        {
            string[] words = new string[3];
            words[0] = "Tennis";
            words[1] = "Football";
            words[2] = "Badminton";

            Random random = new Random();///ใช้ random ที่พี่ให้มา
            int resultRandom = random.Next(0,2);
            string secretword = words[resultRandom];

            char[] inputt = new char[secretword.Length];///สร้าง Array _____


            for (int i = 0; i < secretword.Length; i++)
            {
                inputt[i] = '_';
            }
            counting(secretword, inputt);
        }

        public void counting(string secretword,char[]inputt)/// เมดทอดนับคำผิดและแสดงผล
        {
            int misscount = 0;
            int rightcount = 0;


            bool IsWon = false;/// เงื่อนไขที่ตั้งว่าชนะเป็น false เพื่อที่จะเอาไว้ใส่ตอนชนะจะได้ ใส่เป็น trueเพื่อบอกว่ามึงชนะแล้ว

            do
            {
                Console.WriteLine("Incorrect Score : {0}", misscount);///นับคำผิด
                for (int i = 0; i < secretword.Length; i++)
                {
                    Console.Write(inputt[i]);
                }
                Console.Write("Input letter alphabet : ");////ใส่ตัวอักษร

                char playerGuess = char.Parse(Console.ReadLine());

                if (secretword.Contains(playerGuess))//// การตรวจสอบคำไปเรื่อบๆ
                {
                    for (int j = 0; j < secretword.Length; j++)
                    {
                        if (playerGuess == secretword[j])
                        {
                            inputt[j] = playerGuess;
                            rightcount++;
                        }
                    }

                    if (rightcount == secretword.Length) ////ถ้าเดาถูกก็จะไม่นับ misscount
                    {
                        IsWon = true; 
                    }
                }
                else
                {
                    misscount += 1; ///// เดาคำผิดก็ Misscount + 1 ไปดิ
                }
            }
            while (misscount <= 7 && !IsWon);

            if (IsWon = true)/// นี่ไงที่บอกว่าชนะแล้วจะเป็น true 
            {
                Console.WriteLine(inputt);
                Console.WriteLine("You win!!!!!");
            }
            else
            {
                Console.WriteLine("You loose!!!!!");///// นี่ไงถ้านอกเหนือจากนี้ก็แพ้เพราะว่าหลุด กรณ๊ Iswon = true
            }
            Console.ReadLine();


        }

    }
 }
