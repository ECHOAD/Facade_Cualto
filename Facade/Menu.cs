﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facade.Modelos;
using Facade.Helpers;
using Facade.Modulos;
using Facade.Modulosf;

namespace Facade
{
    public static class Menu
    {
        private static List<Empleados> lst_Empleados  = new List<Empleados>();

        private static Modulo_RRHH ModuloRHH  = new Modulo_RRHH();

        private static Modulo_Nomina ModuloNomina = new Modulo_Nomina();



        public static void IncializarMenu()
        {
            int seleccion = 0;
            Console.WriteLine("**********Sistema RRHH***********");

            Console.WriteLine("¿En que apartado desea trabajar ?");

            Console.WriteLine("1-RRHH  2-Nominas de Pago ");

            seleccion = Inputs.Input_int("Seleccion");

            Console.Clear();


            switch (seleccion)
            {
                case 1:
                    Console.WriteLine("Esta en el apartado de RRHH");

                    Console.WriteLine("¿Que funcion quiere realizar?");

                    Console.WriteLine("1-Contratar  2-Desvincular ");

                    do
                    {
                        seleccion = Inputs.Input_int("Seleccion: ");


                    } while (seleccion <= 0 || seleccion > 3);

                    if (seleccion == 1)
                    {
                    }
                    else if (seleccion == 2)
                    {

                    }
                    else
                    {

                    }


                    break;
                case 2:
                    break;

                default:
                    Console.WriteLine("Seleccion no existe");
                    Console.ReadKey();
                    Console.Clear();
                    IncializarMenu();
                    break;
            }


        }

       
    }
}

