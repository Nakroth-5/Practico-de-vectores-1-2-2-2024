using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico_de_vectores_1_y_2
{
     class Vector
     {
	    int n;
	    int[] v;
	    public Vector()
	    {
		   n = 0;
		   v = new int[100];
	    }

	    public void Cagar(int c, int a, int b)
	    {
		   n = c;
		   Random r = new Random();
		   for (int i = 1; i <= n; i++)
			  v[i] = r.Next(a, b + 1);
	    }

	    public string Descargar()
	    {
		   string s = "{ ";
		   for (int i = 1; i <= n; i++)
		   {
			  s += v[i];
			  if (i < n)
				 s += ", ";
		   }
		   return s + " }";
	    }
		/**Hello World**/
	    public void Eliminar_Elemento(int pos)
	    {
		   if (pos > 0 && pos <= n)
		   {
			  for (int i = pos; i < n; i++)
				 v[i] = v[i + 1];
			  n--;
		   }
	    }

	    public void Eliminar_Elementos(int a, int b)
	    {
		   if (a > 0 && a <= b)
		   {
			  for (int i = b; i >= a; i--)
				 Eliminar_Elemento(i);
		   }
	    }
     }
}
