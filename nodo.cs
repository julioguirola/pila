using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Pila
{
	class Nodo<T>
	{
		private T info;
		private Nodo<T> prox;
        
		public Nodo()
		{
			info = default(T);
			prox = null;
		}
        
		public Nodo(T info)
		{
			this.info = info;
			prox = null;
		}
        
		public T Info {
			get{ return info; }
			set{ info = value; }
		}
        
		public Nodo<T> Prox
		{
			get{return prox;}
			set{prox=value;}
		}
	}
}
