using System;
using System.Collections.Generic;

namespace ListaAcrescerSalarioFuncionario {
    class Program {
        static void Main ( string [ ] args ) {

            //Programa com intuito de treinar como é o funcionamento de LISTAS em C#
            //É Criada uma lista de funcionarios, depois é escolhido um funcionario para aumento do salário!
            Console.WriteLine ( "------------------------------" );
            Console.Write ( "How many employees will be registered?" );
            int qtd = int.Parse ( Console.ReadLine ( ) );

            List<Employee> list = new List<Employee> ( );

            for ( int i = 0 ; i < qtd ; i++ ) {

                Console.WriteLine ( "------------------------------" );
                Console.Write ( "Employee #" + i );

                Console.WriteLine ( "ID: " );
                int id = int.Parse ( Console.ReadLine ( ) );
                Console.Write ( "Name: " );
                string name = Console.ReadLine ( );
                Console.Write ( "Salary:" );
                double salary = double.Parse ( Console.ReadLine ( ) );
                list.Add ( new Employee ( id, name, salary ) );
                }

            Console.WriteLine ( "------------------------------" );
            Console.Write ( "Enter the employee ID that will have salary increase:" );
            int inputId = int.Parse ( Console.ReadLine ( ) );
            
            Console.Write ( "Enter the percentage:" );
            double percentage = double.Parse ( Console.ReadLine ( ) );

            Employee.increaseSalary ( percentage, inputId );

            Console.WriteLine ( "------------------------------" );
            Console.WriteLine ( "Updated list of employees:" );
            /*List*/
            foreach ( var item in list ) {
                Console.WriteLine ( item );
                }


            }
        }
    }
