﻿using System;

namespace PRNG_Service
{
    public class RandomGenerator
    {
        public int Generate()
        {
            Random rand = new Random();
            int randNum = rand.Next(1, 8);
            return randNum;
        }
    }
}