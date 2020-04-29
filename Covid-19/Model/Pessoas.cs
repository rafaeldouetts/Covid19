using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid_19.Model
{
	
	class Pessoas
	{
		public int _idade { get; set; }
		public bool _vivo { get; set; }
		public bool _contaminado { get; set; }
		public int _tempo { get; set; }
		public Pessoas(int idade,bool vivo,bool contaminado, int tempo)
		{
			this._idade = idade;
			this._vivo = vivo;
			this._contaminado = _contaminado;
			this._tempo = tempo;
		}
	}

	
}
