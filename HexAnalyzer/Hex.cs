using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexAnalyzer
{
	public class Hex
	{
		/// <summary>
		/// 16進数表記文字列をHexオブジェクトにぱーすする
		/// </summary>
		/// <param name="hexString"></param>
		/// <returns></returns>
		public static Hex Parse(string hexString)
		{
			return new Hex(HexConverter.ToBytes(hexString));
		}

		/// <summary>
		/// バイナリデータのバイト長
		/// </summary>
		public int Length { get; private set; }

		/// <summary>
		/// インデクサー
		/// </summary>
		/// <param name="i"></param>
		/// <returns></returns>
		public byte this[int i]
		{
			get
			{
				return data[i];
			}
		}

		/// <summary>
		/// マークした部分Hexのリスト
		/// </summary>
		public IEnumerable<Hex> Marks { get { return marks; } }

		/// <summary>
		/// 
		/// </summary>
		private ICollection<Hex> marks = new List<Hex>();

		/// <summary>
		/// 
		/// </summary>
		private byte[] data;


		/// <summary>
		/// 
		/// </summary>
		/// <param name="source"></param>
		public Hex(IEnumerable<byte> source)
		{
			data = source.ToArray();
		}

		/// <summary>
		/// 指定部分をマークする
		/// </summary>
		/// <param name="startIndex">開始位置</param>
		/// <param name="length">長さ（バイト長）</param>
		public void Mark(int startIndex, int length)
		{
			var slicedBytes = data.Skip(startIndex).Take(length);
			marks.Add(new Hex(slicedBytes));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string ToHexString()
		{
			return HexConverter.ToHex(data);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public Int32 ToInt32()
		{
			return BitConverter.ToInt32(data, 0);	
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public Int64 ToInt64()
		{
			return BitConverter.ToInt64(data, 0);
		}
	}
}
