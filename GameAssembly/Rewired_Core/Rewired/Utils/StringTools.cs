/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Utils
{
	public static class StringTools // TypeDefIndex: 7053
	{
		// Fields
		private static string NKizIiksNcIfufgEzeTrvroKWYQ; // 0x00
	
		// Constructors
		static StringTools(); // 0x0000000181468450-0x00000001814684F0
	
		// Methods
		public static string ToString(int[] inArray); // 0x0000000181466A90-0x0000000181466BC0
		public static string ToString(float[] inArray); // 0x0000000181466FA0-0x00000001814670C0
		public static string ToString(string[] inArray); // 0x0000000181466620-0x0000000181466720
		public static string ToString(bool[] inArray); // 0x0000000181466950-0x0000000181466A90
		public static string ToString(byte[] inArray); // 0x0000000181466E40-0x0000000181466FA0
		public static string ToString(byte[] inArray, string stringOptions, int maxItemsPerLine = 0 /* Metadata: 0x007667C7 */); // 0x00000001814672A0-0x0000000181467450
		public static string ToString(Vector3[] inArray); // 0x00000001814670C0-0x0000000181467220
		public static string ToString(List<object> list); // 0x0000000181467450-0x0000000181467550
		public static string ToString(Vector2 v); // 0x0000000181467220-0x00000001814672A0
		public static string ToString(Vector3 v); // 0x0000000181466BC0-0x0000000181466E40
		public static string ToString<T>(T[] inArray);
		public static string ToString<T>(List<T> inList);
		public static string[] Split(string str, string delimiter); // 0x0000000181465A20-0x0000000181465AD0
		public static string[] SplitAndTrim(string str, string delimiter); // 0x00000001814657F0-0x0000000181465A20
		public static string DecodeNewlines(string s); // 0x00000001814650D0-0x0000000181465120
		public static string EncodeNewlines(string s); // 0x0000000181465120-0x0000000181465170
		public static string ArrayToText(string[] sA); // 0x00000001814640E0-0x00000001814641D0
		public static string[] TextToArray(string s); // 0x0000000181465FB0-0x0000000181466050
		public static string StringToString(string s); // 0x0000000181465D90-0x0000000181465DD0
		public static int StringToInt(string s); // 0x0000000181465C90-0x0000000181465CC0
		public static float StringToFloat(string s); // 0x0000000181465C10-0x0000000181465C90
		public static bool StringToBoolean(string s); // 0x0000000181465AD0-0x0000000181465B40
		public static KeyCode StringToKeyCode(string s); // 0x0000000181465CC0-0x0000000181465D90
		public static Enum StringToEnum(string str, Type type); // 0x0000000181465B50-0x0000000181465C10
		public static string ToStringWithCount(string s); // 0x00000001814664B0-0x0000000181466620
		public static char[] StringToCharArray(string s); // 0x0000000181465B40-0x0000000181465B50
		public static string CharArrayToString(char[] c); // 0x0000000181464F20-0x0000000181464F40
		public static string CSVEncode(string s); // 0x00000001814646E0-0x0000000181464780
		public static string CSVDecode(string s); // 0x0000000181464430-0x00000001814646E0
		public static string[] CSVToArray(string s); // 0x0000000181464780-0x0000000181464F20
		public static bool TryParseEnum<TEnum>(string value, out TEnum enumeration);
		public static string TimeToString(int seconds); // 0x0000000181466380-0x00000001814663E0
		public static string TimeToString(float seconds); // 0x0000000181466050-0x0000000181466380
		public static string CleanUpFileName(string name); // 0x0000000181464F40-0x0000000181465010
		public static string StripTrailingNumbers(string name); // 0x0000000181465F50-0x0000000181465FB0
		public static string StripTrailingNumbers(string name, out int number); // 0x0000000181465DD0-0x0000000181465F50
		public static string VerifyName(string name, int indexInNameList, string[] names, bool cleanUpIllegalFileChars); // 0x0000000181467910-0x0000000181467C20
		public static string VerifyName(string name, int indexInNameList, string[] names, bool cleanUpIllegalFileChars, bool allowBlank); // 0x0000000181467C20-0x0000000181467F10
		public static string IterateName(string name, int indexInNameList = -1 /* Metadata: 0x007667CB */, string[] names = null); // 0x0000000181465420-0x0000000181465660
		public static string ToString(Rect rect); // 0x0000000181466720-0x0000000181466950
		public static Guid ToGuid(string guid); // 0x00000001814663E0-0x00000001814664B0
		public static byte[] GetBytes(string str); // 0x0000000181465170-0x0000000181465230
		public static string GetString(byte[] bytes); // 0x0000000181465390-0x0000000181465420
		public static string ByteShiftEncode(string source, short shift); // 0x00000001814641D0-0x0000000181464430
		public static string GetNullTerminatedUnicodeString(byte[] bytes); // 0x0000000181465230-0x0000000181465390
		public static string SanitizeDeviceString(string text); // 0x0000000181465720-0x00000001814657F0
		public static string ReplaceChar(string @string, int index, char replacement); // 0x0000000181465660-0x0000000181465720
		public static string AddSpacesToSentence(string text, bool preserveAcronyms); // 0x0000000181463DE0-0x00000001814640E0
		public static string WriteVar(string name, object value); // 0x00000001814682D0-0x0000000181468340
		public static string WriteVar(string name, object value, char delimiter); // 0x0000000181467F10-0x00000001814681F0
		public static void WriteVar(StringBuilder sb, string name, object value); // 0x0000000181468340-0x0000000181468450
		public static void WriteVar(StringBuilder sb, string name, object value, char delimiter); // 0x00000001814681F0-0x00000001814682D0
		public static string Trim(string str); // 0x0000000181467550-0x0000000181467590
		public static string VariableNameToDisplayName(string fieldName); // 0x0000000181467590-0x0000000181467910
		public static int CountChars(string text, char character); // 0x0000000181465010-0x00000001814650D0
	}
}
