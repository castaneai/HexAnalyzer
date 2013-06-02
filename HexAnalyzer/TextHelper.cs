using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexAnalyzer
{
	internal static class TextHelper
	{
		internal static string GetPrintableText(ICollection<byte> bytes, Encoding encoding, string replacement = ".")
		{
			var encoderFallback = new EncoderExceptionFallback();
			var decoderFallback = new DecoderReplacementFallback(replacement);
			encoding = Encoding.GetEncoding(encoding.CodePage, encoderFallback, decoderFallback);
			var decodedString = encoding.GetString(bytes.ToArray());
			var printableText = System.Text.RegularExpressions.Regex.Replace(decodedString, @"\p{Cc}", replacement);
			return printableText;
		}
	}
}
