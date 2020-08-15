using System;
using System.Collections.Generic;

namespace GenericIndexer
{
    public class SimpleIndexer
    {
        private string[] stringArr = new string[5];
        public string this[int index]
        {
            get
            {
                if (index > 4)
                    throw new IndexOutOfRangeException("Max index value is 4");
                return stringArr[index];
            }
            set
            {
                if (index > 4)
                    throw new IndexOutOfRangeException("Max index value is 4");
                stringArr[index] = value;
            }
        }
    }

    public class GenericIndexer<T>
    {
        private T[] arr = new T[5];
        public T this[int index]
        {
            get
            {
                if (index > 4)
                    throw new IndexOutOfRangeException("Max index value is 4");
                return arr[index];
            }
            set
            {
                if (index > 4)
                    throw new IndexOutOfRangeException("Max index value is 4");
                arr[index] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SimpleIndexer simpleIndexer = new SimpleIndexer();
            simpleIndexer[0] = "value 1";
            simpleIndexer[1] = "value 2";
            simpleIndexer[2] = "value 3";
            simpleIndexer[3] = "value 4";
            try
            {
                simpleIndexer[5] = "value 4";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            GenericIndexer<int> integerIndexer = new GenericIndexer<int>();
            integerIndexer[0] = 1;
            integerIndexer[1] = 2;
            integerIndexer[2] = 3;
            integerIndexer[3] = 4;

            GenericIndexer<string> stringIndexer = new GenericIndexer<string>();
            stringIndexer[0] = "value 1";
            stringIndexer[1] = "value 2";
            stringIndexer[2] = "value 3";
            stringIndexer[3] = "value 4";

            Console.WriteLine("Generic Indexer at index 3" +stringIndexer[2]);
            
            try
            {
                integerIndexer[6] = 4;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
