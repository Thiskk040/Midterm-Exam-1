using System;
using System.Collections.Generic;

namespace _50
{
    enum HanngmanMenu
    {
        playgame=1,
            exit=2,
    }
    class Program
    {
        static void Main(string[] args)
        {
            Printmenuscreen();//แสดงผลลัพธ์หน้าจอที่ main
        }
        static void Printmenuscreen()//เมดทอดแสดงผลลัพธ์ main
        {
            Console.WriteLine("Welcome to Hangman game");
            Console.WriteLine();
            Console.WriteLine("1.Playgame");
            Console.WriteLine("2.Exit");
            InputFormTheKeyboard();
        }
        static void InputFormTheKeyboard()//รับค่าจากคียบอรด์ โดยใช้ enum
        {
            Console.Write("Please sclected menu: ");
            HanngmanMenu menu = (HanngmanMenu)(int.Parse(Console.ReadLine()));
            Persentmenu(menu);

        }
        static void Persentmenu(HanngmanMenu menu)///ฟังก๋ชั่นคำสั่งเมนูหลัก
        {
            if (menu == HanngmanMenu.playgame)
            {
                Startgame();
            }
            else if (menu == HanngmanMenu.exit)
            {
                
            }
            else
            {
                Console.WriteLine("Error Please try again");
            }
        }
        static void Startgame()//เมดทอดเริ่มเกมและแสดงหน้าจอ interface 
        {
            Console.WriteLine("Play Hangman Game");
            Console.WriteLine();
            Console.WriteLine("------------------");
            LogicGameplay Hang1 = new LogicGameplay();
            Hang1.Gameplay();
            
        }
       


    }
}

