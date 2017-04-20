using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPtDLab1
{
	static class DESFunctionProvider
	{
		public static int CountFunction(int right, long roundKey)
		{
			//TODO
			return right ^ (int)(roundKey >> 18);
		}


	}
}
