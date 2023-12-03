using Static___Sealed___Nullable.Models;
using System.Runtime.CompilerServices;

namespace Static___Sealed___Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Student class-i yaradin
             static Count
             Id
             Fullname
             static CheckFullname()

        Hər dəfə Student yarananda Count artmalı və Id constructor işə düşdükdə dinamik olaraq Count-a əsasən təyin olunmalıdır 

        Fullname memberi ad ve soyadi ifade edir, ona gore de fullname deyeri ad ve soyaddan ibaret olmalidir.(Example: Murad Aliyev) ad ve soyadin ilk herfi boyuk ve ortada bosluq olmalidir.

        CheckFullname() - Fullname-nin duzgunluyunu yoxlayan ve geriye boolean type qaytaran static method yazib methodu istifade edirsiz(Yoxlama, deyer constructora oturulmezden evvel program.cs-de edilmelidir).

        Student yaradilarken Fullname gonderilmek mecburiyyetindedir. Ve duzgun deyer daxil edene qeder proqram bitmemelidir (deyer consoledan goturulur ve duz olana qeder dovr etmelidir)
             */
            Console.WriteLine("1-Yeni sagird yaradir");
            Console.WriteLine("0-Emeliyyati sonlandirir");
            byte input = Convert.ToByte(Console.ReadLine());
           
            if (input is 1)
            {
                bool response = true;
                while (response)
                {
                    Console.WriteLine("Sagirdin adini ve soyadini daxil edin");
                    Student student = new Student(Console.ReadLine());
                    if (Student.CheckFullname(student.Fullname) is true)
                    {
                        Console.WriteLine("Sagird ugurla elave edildi");
                        response = false;
                    }
                    else
                    {
                        Console.WriteLine("Daxil etdiyiniz sagirdin adi ve yaxud soyadi dogru daxil edilmemisdir bir daha daxil edin");
                        response = true;
                    }
                }
            }
            else if (input is 0)
            {
                Console.WriteLine("Emeliyyat basa catdi");
            }
            else
            {
                Console.WriteLine("Yanlis reqem daxil edildi");
            }
        }
    }
}