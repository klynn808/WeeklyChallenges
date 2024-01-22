﻿using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            return num1 == num2;
            //if(num1 == num2)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }

        public double Subtract(double minuend, double subtrahend)
        {
            return minuend - subtrahend;
        }

        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            //return Math.Min(number1, number2);  
            //if (number1 < number2) 
            //{
            //    return number1;
            //}

            //return number2;

            return number1 < number2 ? number1 : number2;
        }

        public long Multiply(long factor1, long factor2)
        {
            return factor1 * factor2;
        }

        public string GetGreeting(string nameOfPerson)
        {
            //if (nameOfPerson != "")
            //{
            //    string greeting = $"Hello, {nameOfPerson}!";
            //    return greeting;
            //}
            //else
            //{
            //    string greeting = "Hello!";
            //    return greeting;
            //}

            //return nameOfPerson == "" ? "Hello!" : $"Hello, {nameOfPerson}!";
            //OR ternary

            return string.IsNullOrEmpty(nameOfPerson) ? "Hello!" : $"Hello, {nameOfPerson}!";
        }

        public string GetHey() => "HEY!";
        
    }
}
