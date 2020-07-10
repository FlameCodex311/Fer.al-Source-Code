/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace ParadoxNotion.Serialization.FullSerializer
{
	public class fsJsonParser // TypeDefIndex: 15310
	{
		// Fields
		private int _start; // 0x10
		private string _input; // 0x18
		private readonly StringBuilder _cachedStringBuilder; // 0x20
	
		// Constructors
		private fsJsonParser(string input); // 0x0000000181392B90-0x0000000181392C10
	
		// Methods
		private fsResult MakeFailure(string message); // 0x000000018138FFF0-0x00000001813902F0
		private bool TryMoveNext(); // 0x0000000181390E90-0x0000000181390EC0
		private bool HasValue(); // 0x000000018138FED0-0x000000018138FF00
		private bool HasValue(int offset); // 0x000000018138FF00-0x000000018138FF40
		private char Character(); // 0x000000018138FEA0-0x000000018138FED0
		private char Character(int offset); // 0x000000018138FE70-0x000000018138FEA0
		private void SkipSpace(); // 0x0000000181390B10-0x0000000181390E90
		private bool IsHex(char c); // 0x000000018138FF40-0x000000018138FF70
		private uint ParseSingleChar(char c1, uint multipliyer); // 0x00000001813902F0-0x0000000181390330
		private uint ParseUnicode(char c1, char c2, char c3, char c4); // 0x0000000181390330-0x0000000181390440
		private fsResult TryUnescapeChar(out char escaped); // 0x0000000181392280-0x0000000181392B90
		private fsResult TryParseExact(string content); // 0x00000001813911F0-0x0000000181391350
		private fsResult TryParseTrue(out fsData data); // 0x0000000181392180-0x0000000181392280
		private fsResult TryParseFalse(out fsData data); // 0x0000000181391350-0x0000000181391450
		private fsResult TryParseNull(out fsData data); // 0x0000000181391450-0x0000000181391520
		private bool IsSeparator(char c); // 0x000000018138FF70-0x000000018138FFF0
		private fsResult TryParseNumber(out fsData data); // 0x0000000181391520-0x00000001813918E0
		private fsResult TryParseString(out string str); // 0x0000000181391E60-0x0000000181392180
		private fsResult TryParseArray(out fsData arr); // 0x0000000181390EC0-0x00000001813911F0
		private fsResult TryParseObject(out fsData obj); // 0x00000001813918E0-0x0000000181391E60
		private fsResult RunParse(out fsData data); // 0x00000001813906B0-0x0000000181390B10
		public static fsResult Parse(string input, out fsData data); // 0x0000000181390440-0x0000000181390570
		public static fsData Parse(string input); // 0x0000000181390570-0x00000001813906B0
	}
}
