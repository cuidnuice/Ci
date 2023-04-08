using Microsoft.VisualBasic;
using System;

namespace MyApp
{
    class GameObject
    {
        // int Scale;
    }

    internal class Program
    {
        static void Attack()
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("공격");
            }
        }

        static int Damage()
        {
            return 100;
        }

        static void Stat(int x)
        {
            Console.WriteLine("매개 변수 x의 값 : " + x);
        }

        static int Calculator(int x, int y)
        {
            return x + y;
        }

        static void ItemData(ref int count)
        {
            count += 100;
        }

        static void RaycastHit(out float ray)
        {
            ray = 99.9f;
        }
        
        static void ItemInformation(in int data)
        {
            Console.WriteLine("data의 값 : " + data);
        }

        static void Process(int count)
        {
            Console.WriteLine("작업 처리");

            if(count == 1)
            {
                return;
            }

            Process(count - 1);
        }

        static void Main(string[] args)
        {
            #region 함수
            // Attack();
            // 
            // Console.WriteLine(Damage());
            // 
            // Stat(100);
            // 
            // Console.WriteLine(Calculator(10, 20));
            #endregion

            #region 매개변수 한정자
            // int item = 100;
            // 
            // ItemData(ref item);
            // 
            // Console.WriteLine("item의 값 : " + item);
            // 
            // float ray;
            // 
            // RaycastHit(out ray);
            // 
            // Console.WriteLine("ray의 값 : " + ray);
            // 
            // int dataBase = 30;
            // 
            // ItemInformation(dataBase);
            #endregion

            #region
            Process(3);
            #endregion
        }
    }
}