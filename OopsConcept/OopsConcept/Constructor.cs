﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class Constructor : InterfaceType
    {
        //Constructor does not have any return type.
        //Name should be same as the class name.
        //This is a non-parameterised constructor.
        ClassName subject;
        int One;
        string column;
        public Constructor(ClassName input, int rowOne, string columnOne)
        {
            Console.WriteLine("Hello World");
            this.subject = input;
            this.One = rowOne;
            column = columnOne;
        }
        //This is a parameterised constructor.
        public string query;
        public int transactionNum;
        public char alphabet;
        public Constructor(string name, int number, char character)
        {
            this.query = name;
            Console.WriteLine(query);
            transactionNum = number;
            Console.WriteLine(transactionNum);
            this.alphabet = character;
            Console.WriteLine(alphabet);
        }
        public int numberAdd;
        public int numberSub;
        public Constructor(int numOne, int numTwo)
        {
            this.numberAdd = numOne + numTwo;
            Console.WriteLine(numberAdd);
            this.numberSub = numOne - numTwo;
            Console.WriteLine(numberSub);
        }
        public Constructor(string alpha, string beta, string gamma)
        {
            Console.WriteLine(alpha + beta + gamma);
        }
        public bool input;
        int num;
        public Constructor(bool output, int value)
        {
            this.input = output;
            Console.WriteLine(input);
            this.num = value;
            Console.WriteLine(num);
        }
        public void WithoutImplementionMethod()
        {
            Console.WriteLine("Hi there this is constructor.cs class");
        }
        public Constructor()
        {

        }
    }
}
