using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            stu["Math"] = 90;
            stu["Math"] = 100;
            var mathScore = stu["Math"];
            Console.WriteLine(mathScore);
        }
    }
    class Student
    { 
     private Dictionary<string,int > scoreDictionary=new Dictionary<string,int>();
        public int? this[string subject]
        {
            get
            {
                if (this.scoreDictionary.ContainsKey(subject))
                {
                    return this.scoreDictionary[subject];
                }
                else
                {
                    return null;
                }
            }

            set {

                if (value.HasValue==false)
                {
                    throw new Exception("Score cannot be null");
                }

                if (this.scoreDictionary.ContainsKey(subject))
                {
                    this.scoreDictionary[subject] = value.Value;
                }
                else
                {

                    this.scoreDictionary.Add(subject, value.Value);
                }

                }
               
            }
        }

    }

