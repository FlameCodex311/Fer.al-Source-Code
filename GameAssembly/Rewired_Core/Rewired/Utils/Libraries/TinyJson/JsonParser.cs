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
using Rewired;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Utils.Libraries.TinyJson
{
	public static class JsonParser // TypeDefIndex: 7022
	{
		// Fields
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static Stack<List<string>> splitArrayPool; // 0x00
		private static StringBuilder ruVDLVATrtwfgQYvVryHYAKXmXV; // 0x08
		private static readonly Dictionary<Type, Dictionary<string, FieldInfo>> mtjDgwrsKHLyGpZcHneeBeJiCIF; // 0x10
		private static readonly Dictionary<Type, Dictionary<string, PropertyInfo>> KzybAcqvobVRsvNuDNHGjeCrgkWj; // 0x18
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Func<FieldInfo, bool> rMADKvwwlBDxGizQaeqoBdFZwld; // 0x20
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Func<FieldInfo, string> JTCXEGDxEOeUKhqiWcgWTpItzfs; // 0x28
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Func<PropertyInfo, bool> qKeWAGlhnvzAfpdHfrtZXCbPGPfH; // 0x30
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Func<PropertyInfo, string> EWlhMlrDrFKXLfmWfTVIDnhEqEQ; // 0x38
	
		// Constructors
		static JsonParser(); // 0x00000001813EB810-0x00000001813EB900
	
		// Methods
		public static bool TryFromJson<T>(string json, out T value);
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static bool TryFromJson<T>(string json, out T value, Type preferredAnonymousObjectType);
		public static T FromJson<T>(string json);
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static T FromJson<T>(string json, Type preferredAnonymousObjectType);
		public static object FromJson(Type type, string json); // 0x00000001813EB1A0-0x00000001813EB210
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static object FromJson(Type type, string json, Type preferredAnonymousObjectType); // 0x00000001813EAF00-0x00000001813EB1A0
		private static object oiDedQajiPqFWDlAfWegKcQKoKzL(Type param_0000f0a9, string param_0000f0aa, Type param_0000f0ab, out bool param_0000f0ac); // 0x00000001813ED6C0-0x00000001813EEDD0
		private static object dqezUQXaNYZnrSsNUgBqgLXRGve(string param_0000f0ad, Type param_0000f0ae, out bool param_0000f0af); // 0x00000001813EB900-0x00000001813EC770
		private static object iTyUdztRojLrcYEAwiWSynRpAzZ(Type param_0000f0b0, string param_0000f0b1, Type param_0000f0b2); // 0x00000001813EC770-0x00000001813ED1A0
		private static int OcWHwDcuovoBOphbkZvMcXyQMFE(bool param_0000f0b3, int param_0000f0b4, string param_0000f0b5); // 0x00000001813EB210-0x00000001813EB550
		private static List<string> lJElHlzqpyaWVchTUFrBWYNwaYLz(string param_0000f0b6); // 0x00000001813ED1A0-0x00000001813ED6C0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static bool XUwVbCcTdezMDPRxbNSYgSKyfvB(FieldInfo param_0000f0b7); // 0x00000001813EB670-0x00000001813EB810
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static string vkXfcMDWrdECdhpTRbdDMQhkmOqJ(FieldInfo param_0000f0b8); // 0x00000001813EEDD0-0x00000001813EEF90
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static bool TsgSPyxcJohdcRSUYzdTENfRNCb(PropertyInfo param_0000f0b9); // 0x00000001813EB550-0x00000001813EB670
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static string BSjnnOWjgMsktPLNAAmXCeMPphZl(PropertyInfo param_0000f0ba); // 0x00000001813EAD40-0x00000001813EAF00
	}
}
