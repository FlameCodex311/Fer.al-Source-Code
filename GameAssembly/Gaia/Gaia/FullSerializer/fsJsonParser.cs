/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia.FullSerializer
{
	public class fsJsonParser // TypeDefIndex: 9297
	{
		// Fields
		private int _start; // 0x10
		private string _input; // 0x18
		private readonly StringBuilder _cachedStringBuilder; // 0x20
	
		// Constructors
		private fsJsonParser(string input); // 0x000000018151BF90-0x000000018151C010
	
		// Methods
		private fsResult MakeFailure(string message); // 0x00000001815196B0-0x0000000181519990
		private bool TryMoveNext(); // 0x00000001811B0F80-0x00000001811B0FB0
		private bool HasValue(); // 0x00000001811AFEE0-0x00000001811AFF10
		private bool HasValue(int offset); // 0x00000001811AFF10-0x00000001811AFF40
		private char Character(); // 0x00000001811AFEB0-0x00000001811AFEE0
		private char Character(int offset); // 0x00000001811AFE80-0x00000001811AFEB0
		private void SkipSpace(); // 0x000000018151A060-0x000000018151A3D0
		private bool IsHex(char c); // 0x00000001811AFF40-0x00000001811AFF70
		private uint ParseSingleChar(char c1, uint multipliyer); // 0x00000001811B0330-0x00000001811B0370
		private uint ParseUnicode(char c1, char c2, char c3, char c4); // 0x00000001811B0370-0x00000001811B0480
		private fsResult TryUnescapeChar(out char escaped); // 0x000000018151B6B0-0x000000018151BF90
		private fsResult TryParseExact(string content); // 0x000000018151A6F0-0x000000018151A850
		private fsResult TryParseTrue(out fsData data); // 0x000000018151B5B0-0x000000018151B6B0
		private fsResult TryParseFalse(out fsData data); // 0x000000018151A850-0x000000018151A950
		private fsResult TryParseNull(out fsData data); // 0x000000018151A950-0x000000018151AA20
		private bool IsSeparator(char c); // 0x0000000181519630-0x00000001815196B0
		private fsResult TryParseNumber(out fsData data); // 0x000000018151AA20-0x000000018151ADB0
		private fsResult TryParseString(out string str); // 0x000000018151B290-0x000000018151B5B0
		private fsResult TryParseArray(out fsData arr); // 0x000000018151A3D0-0x000000018151A6F0
		private fsResult TryParseObject(out fsData obj); // 0x000000018151ADB0-0x000000018151B290
		private fsResult RunParse(out fsData data); // 0x0000000181519C00-0x000000018151A060
		public static fsResult Parse(string input, out fsData data); // 0x0000000181519AD0-0x0000000181519C00
		public static fsData Parse(string input); // 0x0000000181519990-0x0000000181519AD0
	}
}
