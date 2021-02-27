using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ejercicios_Del_Libro_De_Cshart
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            //Capitulo 10
            this.Ejercicio10_1ToolStripMenuItem.Click += new EventHandler(this.Ejercicio10_1ToolStripMenuItem_ItemClicked);
            this.Ejercicio10_2ToolStripMenuItem.Click += new EventHandler(this.Ejercicio10_2ToolStripMenuItem_ItemClicked);
            this.Ejercicio10_3ToolStripMenuItem.Click += new EventHandler(this.Ejercicio10_3ToolStripMenuItem_ItemClicked);
            this.Ejercicio10_4ToolStripMenuItem.Click += new EventHandler(this.Ejercicio10_4ToolStripMenuItem_ItemClicked);
            this.Ejercicio10_5ToolStripMenuItem.Click += new EventHandler(this.Ejercicio10_5ToolStripMenuItem_ItemClicked);

            //Capitulo 12
            this.Ejercicio12_1ToolStripMenuItem.Click += new EventHandler(this.Ejercicio12_1ToolStripMenuItem_ItemClicked);
            this.Ejercicio12_2ToolStripMenuItem.Click += new EventHandler(this.Ejercicio12_2ToolStripMenuItem_ItemClicked);

        }
        /*
         private void Ejercicio10_1ToolStripMenuItem_ItemClicked(object sender, EventArgs e){}

        private void Ejercicio10_2ToolStripMenuItem_ItemClicked(object sender, EventArgs e){}

        private void Ejercicio10_3ToolStripMenuItem_ItemClicked(object sender, EventArgs e){}

        private void Ejercicio10_4ToolStripMenuItem_ItemClicked(object sender, EventArgs e){}

        private void Ejercicio10_5ToolStripMenuItem_ItemClicked(object sender, EventArgs e){}
         */
        
        //Capitulo 10
        private void Ejercicio10_1ToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            Ejercicio10_1 ejercicio10_1;
        }

        private void Ejercicio10_2ToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            Ejercicio10_2 ejercicio10_2;
        }

        private void Ejercicio10_3ToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            Ejercicio10_3 ejercicio10_3;
        }

        private void Ejercicio10_4ToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            Ejercicio10_4 ejercicio10_4;
        }

        private void Ejercicio10_5ToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            Ejercicio10_5 ejercicio10_5;
        }

        //Capitulo 12

        private void Ejercicio12_1ToolStripMenuItem_ItemClicked(object sender, EventArgs e) 
        {
            int numero;
            Console.WriteLine("Digite un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            int factor = 1;
            for (int i = numero; i > 1; i--)
                factor *= i;

            Console.WriteLine("El factorial del numero {0} es {1}", numero, factor);

        }

        private void Ejercicio12_2ToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            Console.WriteLine("Hola Mundo");
        }

    }

    public class Ejercicio10_1
    {

        public string nombre { get; set; }
        public int codigo { get; set; }
        public int cantidad { get; set; }
        public string descripcion { get; set; }
        public double precioCompra { get; set; }
        public double precioVenta { get; set; }

    }

    public class Ejercicio10_2
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public int edad { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string grado { get; set; }

    }

    public class Ejercicio10_3
    {
        public int lado { get; set; }
        public int longitud { get; set; }

        public Ejercicio10_3()
        {
            this.lado = 0;
            this.longitud = 0;
        }

        public Ejercicio10_3(int lado, int longitud)
        {
            this.lado = lado;
            this.longitud = longitud;
        }

    }

    public class Ejercicio10_4
    {
        public int lado { get; set; }
        public int longitud { get; set; }

        public Ejercicio10_4()
        {
            this.lado = 0;
            this.longitud = 0;
        }

        public Ejercicio10_4(int lado, int longitud)
        {
            this.lado = lado;
            this.longitud = longitud;
        }

        public int poligono(int lado, int longitud)
        {
            int perimetro = 0;
            if (lado < 0 || longitud < 0)
                Console.WriteLine("Debe ingresar datos validos");
            else
            {
                perimetro = longitud * lado;
            }

            return perimetro;
        }

    }


    public class Ejercicio10_5
    {

        public int lado { get; set; }
        public int longitud { get; set; }

        public Ejercicio10_5()
        {
            this.lado = 0;
            this.longitud = 0;
        }

        public Ejercicio10_5(int lado, int longitud)
        {
            this.lado = lado;
            this.longitud = longitud;
        }

        public int poligono(int lado, int longitud)
        {
            int perimetro = 0;
            if (lado < 0 || longitud < 0)
                Console.WriteLine("Debe ingresar datos validos");
            else
                perimetro = longitud * lado;


            return perimetro;
        }
        public int poligono()
        {
            int perimetro = 0;
            if (this.lado < 0 || this.longitud < 0)
                Console.WriteLine("Debe ingresar datos validos");
            else
                perimetro = this.longitud * this.lado;


            return perimetro;
        }
        public override string ToString()
        {
            return "El perimetro es: " + poligono();
        }
    }

}

    
