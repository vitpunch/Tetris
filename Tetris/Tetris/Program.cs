﻿using System;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40,30);

            Point p1 = new Point(3, 6, '#');

            p1.Draw();
        }     

    }
}
