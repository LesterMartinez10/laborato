using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace labo_01
{
    class facturacion
    {
        static string local = "facturacion.txt";
        static StreamWriter escri;
        static Usuarios us = new Usuarios();
        public int l;

        static double cat(double a)
        {
            Console.Clear();
            Console.WriteLine("Ingrese cantidad del producto" + a + ":");
            return double.Parse(Console.ReadLine());
        }        
        static double vr(double a)
        {
            Console.Clear();
            Console.WriteLine("Ingrese precio del producto" + a + ":");
            return double.Parse(Console.ReadLine());
        }   
        static void vt(string pro)
        {
            escri = File.AppendText(local);
            escri.WriteLine("Producto:" + pro);
            escri.Close();
        }

        static double resp(double l, double m)
        {
            double tol;
            tol = l * m;
            return tol;
        }
        static string dt(string a)
        {
            Console.Clear();
            Console.WriteLine("Ingrese " + a + ":");
            return (Console.ReadLine());
        }
        static void clit(string nom, string corre, string NIT, string fecha)
        {
            Console.Clear();
            escri = File.AppendText(local);
            escri.WriteLine("Correlativo: " + corre + "\ncliente: " + nom + "\nN.I.T: " + NIT + "\nfecha: " + fecha);
            escri.Close();
        }
        static double b, o, m;
        public void facturis()
        {

            clit(dt("Correlativo"), dt("Nombre completo del comprador"), dt("N.I.T"), dt("Fecha cuando se emite la factura"));
            double tta = 0;
            char op = 's';

            while (op != 'n')
            {
                Console.Clear();
                vt(dt("Producto"));

                m = resp(vr(o), cat(b));
                escri = File.AppendText(local);
                escri.WriteLine("Precio de unidad:" + m);
                escri.Close();
                Console.Clear();
                Console.WriteLine("Precio de unidad:" + m);
                Console.WriteLine("¿Quiere ingresar otro producto? [s/n]:");
                op = char.Parse(Console.ReadLine());

                tta = tta + m;
            }
            Console.Clear();
            escri = File.AppendText(local);
            escri.WriteLine("Total:" + tta); 
            escri.WriteLine("\n");
            Console.WriteLine("Total:" + tta);
            escri.Close();
            Console.WriteLine("Desea salir al menu principala presione [1]");
            l = int.Parse(Console.ReadLine());

            if (l == 1)
            {
                Console.Clear();
                us.indi();

            }
           
            
          
        }
        public void leefac()
        {
          
            TextReader leer_archivo = new StreamReader("facturacion.txt");
            Console.WriteLine(leer_archivo.ReadToEnd());
            leer_archivo.Close();
            Console.WriteLine("Desea salir al menu principala presione [1]");
            l = int.Parse(Console.ReadLine());

            if (l == 1)
            {
                Console.Clear();
                us.indi();

            }
          

            Console.ReadKey();
        }
    }
}
