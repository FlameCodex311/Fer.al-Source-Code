/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace Crosstales.Common.Util
{
	public static class CTPlayerPrefs // TypeDefIndex: 9733
	{
		// Fields
		private static readonly SerializableDictionary<string, string> content; // 0x00
		private static readonly string fileName; // 0x08
	
		// Constructors
		static CTPlayerPrefs(); // 0x0000000181077B20-0x0000000181077C40
	
		// Methods
		public static bool HasKey(string key); // 0x0000000181077610-0x0000000181077690
		public static void DeleteAll(); // 0x00000001810771D0-0x0000000181077240
		public static void DeleteKey(string key); // 0x0000000181077240-0x00000001810772C0
		public static void Save(); // 0x0000000181077690-0x0000000181077770
		public static string GetString(string key); // 0x0000000181077590-0x0000000181077610
		public static float GetFloat(string key); // 0x00000001810774A0-0x0000000181077520
		public static int GetInt(string key); // 0x0000000181077520-0x0000000181077590
		public static bool GetBool(string key); // 0x00000001810772C0-0x00000001810773D0
		public static DateTime GetDate(string key); // 0x00000001810773D0-0x00000001810774A0
		public static void SetString(string key, string value); // 0x00000001810779F0-0x0000000181077B20
		public static void SetFloat(string key, float value); // 0x00000001810778F0-0x0000000181077970
		public static void SetInt(string key, int value); // 0x0000000181077970-0x00000001810779F0
		public static void SetBool(string key, bool value); // 0x0000000181077770-0x0000000181077830
		public static void SetDate(string key, DateTime value); // 0x0000000181077830-0x00000001810778F0
	}
}
