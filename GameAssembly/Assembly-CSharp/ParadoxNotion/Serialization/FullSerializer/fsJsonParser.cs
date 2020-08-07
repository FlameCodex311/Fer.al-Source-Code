/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace ParadoxNotion.Serialization.FullSerializer
{
	public class fsJsonParser // TypeDefIndex: 15915
	{
		// Fields
		private int _start; // 0x10
		private string _input; // 0x18
		private readonly StringBuilder _cachedStringBuilder; // 0x20
	
		// Constructors
		private fsJsonParser(string input); // 0x00000001811B2BC0-0x00000001811B2C40
	
		// Methods
		private fsResult MakeFailure(string message); // 0x00000001811AFFF0-0x00000001811B0330
		private bool TryMoveNext(); // 0x00000001811B0F80-0x00000001811B0FB0
		private bool HasValue(); // 0x00000001811AFEE0-0x00000001811AFF10
		private bool HasValue(int offset); // 0x00000001811AFF10-0x00000001811AFF40
		private char Character(); // 0x00000001811AFEB0-0x00000001811AFEE0
		private char Character(int offset); // 0x00000001811AFE80-0x00000001811AFEB0
		private void SkipSpace(); // 0x00000001811B0C10-0x00000001811B0F80
		private bool IsHex(char c); // 0x00000001811AFF40-0x00000001811AFF70
		private uint ParseSingleChar(char c1, uint multipliyer); // 0x00000001811B0330-0x00000001811B0370
		private uint ParseUnicode(char c1, char c2, char c3, char c4); // 0x00000001811B0370-0x00000001811B0480
		private fsResult TryUnescapeChar(out char escaped); // 0x00000001811B22E0-0x00000001811B2BC0
		private fsResult TryParseExact(string content); // 0x00000001811B12B0-0x00000001811B1410
		private fsResult TryParseTrue(out fsData data); // 0x00000001811B21E0-0x00000001811B22E0
		private fsResult TryParseFalse(out fsData data); // 0x00000001811B1410-0x00000001811B1510
		private fsResult TryParseNull(out fsData data); // 0x00000001811B1510-0x00000001811B15E0
		private bool IsSeparator(char c); // 0x00000001811AFF70-0x00000001811AFFF0
		private fsResult TryParseNumber(out fsData data); // 0x00000001811B15E0-0x00000001811B19A0
		private fsResult TryParseString(out string str); // 0x00000001811B1EE0-0x00000001811B21E0
		private fsResult TryParseArray(out fsData arr); // 0x00000001811B0FB0-0x00000001811B12B0
		private fsResult TryParseObject(out fsData obj); // 0x00000001811B19A0-0x00000001811B1EE0
		private fsResult RunParse(out fsData data); // 0x00000001811B07D0-0x00000001811B0C10
		public static fsResult Parse(string input, out fsData data); // 0x00000001811B0480-0x00000001811B0610
		public static fsData Parse(string input); // 0x00000001811B0610-0x00000001811B07D0
	}
}
