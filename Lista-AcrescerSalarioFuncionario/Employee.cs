using System;
using System.Collections.Generic;
using System.Text;

namespace ListaAcrescerSalarioFuncionario {
    class Employee {

       static public int Id { get; set; }
        public string Name { get; set; }
        static public double Salary { get; set; }

        public Employee ( int id, string name, double salary ) {
            Id = id;
            Name = name;
            Salary = salary;
            }

        static public double increaseSalary ( double percentage, int identifier ) {

            if ( identifier == Id ) {

                Salary += ( percentage / 100 ) * Salary;

                return Salary;
                } else {
                Console.WriteLine ("This User doesn't exist!");
                return 99;

                }

            }

        public override string ToString ( ) {
            return Id + " - " + Name + " - " + Salary;
            }

        }

    }
