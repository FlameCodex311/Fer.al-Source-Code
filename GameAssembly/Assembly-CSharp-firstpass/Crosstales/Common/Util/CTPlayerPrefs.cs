/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace Crosstales.Common.Util
{
	public static class CTPlayerPrefs // TypeDefIndex: 9947
	{
		// Fields
		private static readonly SerializableDictionary<string, string> content; // 0x00
		private static readonly string fileName; // 0x08
	
		// Constructors
		static CTPlayerPrefs(); // 0x00000001815CDBE0-0x00000001815CDD00
	
		// Methods
		public static bool HasKey(string key); // 0x00000001815CD6D0-0x00000001815CD750
		public static void DeleteAll(); // 0x00000001815CD280-0x00000001815CD2F0
		public static void DeleteKey(string key); // 0x00000001815CD2F0-0x00000001815CD370
		public static void Save(); // 0x00000001815CD750-0x00000001815CD830
		public static string GetString(string key); // 0x00000001815CD650-0x00000001815CD6D0
		public static float GetFloat(string key); // 0x00000001815CD560-0x00000001815CD5E0
		public static int GetInt(string key); // 0x00000001815CD5E0-0x00000001815CD650
		public static bool GetBool(string key); // 0x00000001815CD370-0x00000001815CD480
		public static DateTime GetDate(string key); // 0x00000001815CD480-0x00000001815CD560
		public static void SetString(string key, string value); // 0x00000001815CDAB0-0x00000001815CDBE0
		public static void SetFloat(string key, float value); // 0x00000001815CD9B0-0x00000001815CDA30
		public static void SetInt(string key, int value); // 0x00000001815CDA30-0x00000001815CDAB0
		public static void SetBool(string key, bool value); // 0x00000001815CD830-0x00000001815CD8F0
		public static void SetDate(string key, DateTime value); // 0x00000001815CD8F0-0x00000001815CD9B0
	}
}
