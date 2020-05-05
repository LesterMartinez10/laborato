using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace labo_01
{
    class Usuarios
    {    
        static inve inv = new inve();
        static creando creo = new creando();
        static facturacion fac = new facturacion();
        

        public int a, e, i,m,p;

        public string uss= "orlando"  , us="fer"  , con="123"  , contra="789" , aa, bb, cc, dd;
       
        public void indi()
        { 

            Console.WriteLine("_____________________________________Bienvenido a Nuestra Empresa______________________________________________________");
            Console.WriteLine("_____________________________________________Los Patos_________________________________________________________________\n");
            Console.WriteLine("Inicio de sesion:\n \n 1.Administrador  \n 2.Trabajador \n 3.Salir \n");
            a = int.Parse(Console.ReadLine());          

            if (a == 1)
            {


                Console.Clear();
                Console.Write("Ingrese el nombre:\n");
                aa = Console.ReadLine();
             ;

                if (uss == aa) 
                {
                    Console.Write("Ingrese contraseña:\n");
                    bb = Console.ReadLine();
                    


                    if (con == bb)
                    {
                        Console.Clear();
                        Console.WriteLine("Bienvenido Administrador \n\n¿Que desea hacer?\n\n 1. Inventario \n 2. Usuarios \n 3. Facturas \n 4. Salir\n");
                        e = int.Parse(Console.ReadLine());
                        if (e == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("¿Que desea hacer?\n\n 1. Agregar producto al inventario \n 2. Ver inventario");
                            p = int.Parse(Console.ReadLine());

                            if(p== 1) 
                            {                               
                                Console.Clear();
                                inv.or();
                            }
                            else
                            {
                                Console.Clear();
                                inv.inests();

                            }                                                           
                        }
                        if (e == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("¿Que desea hacer?\n\n 1. crear usuario \n 2.Ver usuario");
                            m = int.Parse(Console.ReadLine());
                            if(m==1)
                            {
                                Console.Clear();
                                creo.cracio();
                            }
                            else
                            {
                                Console.Clear();
                                creo.regis();
                            }
                            
                        }
                        if (e == 3)
                        {
                            Console.Clear();
                            fac.leefac();
                        }
                        else
                        {

                            Console.Clear();
                            creo.ult();
                          
                        }
                    }
                    else
                    {                    
                        Console.WriteLine("Contraseña Incorecta");                      
                        creo.ult();
                       
                    }
                }
                else
                {
                    
                    Console.WriteLine("Usuario Incorecto");                  
                    creo.ult();
                    
                    
                }
            }
            if (a == 2)
            {
                Console.Clear();
                Console.Write("Ingrese el nombre:\n");
                cc = Console.ReadLine();

                if (us == cc)
                {
                    Console.Write("Ingrese contraseña:\n");
                    dd = Console.ReadLine();

                    if (contra == dd)
                    {
                        Console.Clear();
                        Console.WriteLine("Bienvenido trabajador\n\n¿Que desea hacer?\n\n 1. Cargar Inventario \n 2. Factura \n 3. Salir\n");
                        i = int.Parse(Console.ReadLine());
                        if (i == 1)
                        {
                          
                            Console.Clear();
                            inv.or();
                        }
                        if (i == 2)
                        {
                            Console.Clear();
                            fac.facturis();

                        }
                        else
                        {
                            Console.Clear();
                            creo.ult();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Contraseña Incorecta");
                        creo.ult();
                    }
                }
                else
                {
                    Console.WriteLine("Usuario Incorecto");
                    creo.ult();
                }
            }

           

            

        }
    }
}
