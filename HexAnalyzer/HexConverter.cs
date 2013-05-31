using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HexAnalyzer
{
	public static class HexConverter
	{
		/// <summary>
		/// 16進数表記文字列をバイト配列に分割するときの分割子正規表現
		/// </summary>
		private static Regex splitRegex = new Regex(@"\s+");
		
		/// <summary>
		/// 16進数表記文字列をバイト配列に変換する 
		/// </summary>
		/// <param name="hexString"></param>
		/// <returns></returns>
		public static byte[] ToBytes(string hexString)
		{
			var hexDigits = splitRegex.Split(hexString.Trim());
			return hexDigits.Select(d => byte.Parse(d, System.Globalization.NumberStyles.HexNumber)).ToArray();
		}

		/// <summary>
		/// バイト配列を16進数表記文字列に変換する 
		/// </summary>
		/// <param name="bytes"></param>
		/// <param name="separator"></param>
		/// <returns></returns>
		public static string ToHex(byte[] bytes, char separator = ' ')
		{
			return BitConverter.ToString(bytes).Replace('-', separator);
		}
	}
}
