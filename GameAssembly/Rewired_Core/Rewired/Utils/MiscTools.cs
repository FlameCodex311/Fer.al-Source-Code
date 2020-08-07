/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Utils.Interfaces;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Utils
{
	[CustomClassObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
	[CustomObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
	internal static class MiscTools // TypeDefIndex: 7048
	{
		// Fields
		private static uint ofQooKShNmkNpAgPPoWpiAHWHqM; // 0x00
		private static uint lnmyilEHNcIuQUFyrhGLmNytIts; // 0x04
		private static uint LFhffykLeDtERfvooOZDoWDGfGh; // 0x08
		private static int vXyQXKAIVXwFbLVLmpvNZTBfaPC; // 0x0C
		private static int faaLllyvnSjjAjPALFmOZPdBUkV; // 0x10
		private static int LasfgtUVulhlygDDnoinOMhsnXi; // 0x14
	
		// Constructors
		static MiscTools(); // 0x00000001813F6A00-0x00000001813F6AA0
	
		// Methods
		public static object Clone(object obj); // 0x00000001813F59C0-0x00000001813F5A40
		public static T Clone<T>(T obj)
			where T : class, ICloneable;
		public static T DeepClone<T>(T obj)
			where T : class, IDeepCloneable;
		public static T DeepClone<T>(T obj, bool createIfNull)
			where T : class, IDeepCloneable, new();
		public static T[] DeepClone<T>(T[] obj)
			where T : class, IDeepCloneable;
		public static List<T> DeepClone<T>(List<T> obj)
			where T : class, IDeepCloneable;
		public static Dictionary<TKey, TValue> DeepClone<TKey, TValue>(Dictionary<TKey, TValue> dictionary)
			where TValue : class, IDeepCloneable;
		public static Guid CreateGuidHashSHA256(string text); // 0x00000001813F5BB0-0x00000001813F5D30
		public static Guid CreateGuidHashSHA1(string text); // 0x00000001813F5A40-0x00000001813F5BB0
		public static Guid CreateHIDProductGuid(int vendorId, int productId); // 0x00000001813F5D30-0x00000001813F5DE0
		public static uint Tick(uint counter); // 0x00000001813F64E0-0x00000001813F65A0
		public static int Tick(int counter); // 0x00000001813F65A0-0x00000001813F6660
		public static uint TickPrev(uint counter); // 0x00000001813F6420-0x00000001813F64E0
		public static int TickPrev(int counter); // 0x00000001813F6310-0x00000001813F6420
		public static bool IsTickValid(uint tick); // 0x00000001813F61F0-0x00000001813F6250
		public static bool IsTickValid(int tick); // 0x00000001813F6250-0x00000001813F62B0
		public static bool IsTickNewer(uint tick1, uint tick2); // 0x00000001813F60C0-0x00000001813F61F0
		public static bool IsTickNewer(int tick1, int tick2); // 0x00000001813F5FE0-0x00000001813F60C0
		public static bool IsTickNewerOrEqualTo(uint tick1, uint tick2); // 0x00000001813F5EF0-0x00000001813F5FE0
		public static bool IsTickNewerOrEqualTo(int tick1, int tick2); // 0x00000001813F5DE0-0x00000001813F5EF0
		public static void Swap<T>(ref T a, ref T b);
		public static long ToLongUnchecked(object value); // 0x00000001813F6660-0x00000001813F6A00
		public static bool IsValidGuid(string guid); // 0x00000001813F62B0-0x00000001813F6310
	}
}
