﻿using System; 

class DIO {

    static void Main(string[] args) { 

       for(int i = 1; i<=9; i+=2)
            {
                for(int j = 7; j>=5; j-=1)
                {
                    Console.WriteLine("I=" + i + " J=" + j);
                }
            }
    }

}