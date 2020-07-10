/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia.FullSerializer
{
	public class fsJsonParser // TypeDefIndex: 9125
	{
		// Fields
		private int _start; // 0x10
		private string _input; // 0x18
		private readonly StringBuilder _cachedStringBuilder; // 0x20
	
		// Constructors
		private fsJsonParser(string input); // 0x00000001818F6EF0-0x00000001818F6F70
	
		// Methods
		private fsResult MakeFailure(string message); // 0x00000001818F44F0-0x00000001818F4850
		private bool TryMoveNext(); // 0x0000000181390E90-0x0000000181390EC0
		private bool HasValue(); // 0x000000018138FED0-0x000000018138FF00
		private bool HasValue(int offset); // 0x000000018138FF00-0x000000018138FF40
		private char Character(); // 0x000000018138FEA0-0x000000018138FED0
		private char Character(int offset); // 0x000000018138FE70-0x000000018138FEA0
		private void SkipSpace(); // 0x00000001818F4FF0-0x00000001818F5370
		private bool IsHex(char c); // 0x000000018138FF40-0x000000018138FF70
		private uint ParseSingleChar(char c1, uint multipliyer); // 0x00000001813902F0-0x0000000181390330
		private uint ParseUnicode(char c1, char c2, char c3, char c4); // 0x0000000181390330-0x0000000181390440
		private fsResult TryUnescapeChar(out char escaped); // 0x00000001818F65E0-0x00000001818F6EF0
		private fsResult TryParseExact(string content); // 0x00000001818F5680-0x00000001818F57E0
		private fsResult TryParseTrue(out fsData data); // 0x00000001818F64E0-0x00000001818F65E0
		private fsResult TryParseFalse(out fsData data); // 0x00000001818F57E0-0x00000001818F58E0
		private fsResult TryParseNull(out fsData data); // 0x00000001818F58E0-0x00000001818F59B0
		private bool IsSeparator(char c); // 0x00000001818F4470-0x00000001818F44F0
		private fsResult TryParseNumber(out fsData data); // 0x00000001818F59B0-0x00000001818F5D40
		private fsResult TryParseString(out string str); // 0x00000001818F61E0-0x00000001818F64E0
		private fsResult TryParseArray(out fsData arr); // 0x00000001818F5370-0x00000001818F5680
		private fsResult TryParseObject(out fsData obj); // 0x00000001818F5D40-0x00000001818F61E0
		private fsResult RunParse(out fsData data); // 0x00000001818F4BB0-0x00000001818F4FF0
		public static fsResult Parse(string input, out fsData data); // 0x00000001818F4A20-0x00000001818F4BB0
		public static fsData Parse(string input); // 0x00000001818F4850-0x00000001818F4A20
	}
}
