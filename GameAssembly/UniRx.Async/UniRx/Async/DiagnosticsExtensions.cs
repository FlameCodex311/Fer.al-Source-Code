/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

// Image 68: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8376-8739

namespace UniRx.Async
{
	public static class DiagnosticsExtensions // TypeDefIndex: 8383
	{
		// Fields
		private static bool displayFilenames; // 0x00
		private static readonly Regex typeBeautifyRegex; // 0x08
		private static readonly Dictionary<Type, string> builtInTypeNames; // 0x10
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 8384
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<ParameterInfo, string> <>9__4_0; // 0x08
			public static Func<Type, string> <>9__7_0; // 0x10
			public static Func<Type, string> <>9__7_1; // 0x18
	
			// Constructors
			static <>c(); // 0x0000000181671F00-0x0000000181671F60
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal string <CleanupAsyncStackTrace>b__4_0(ParameterInfo p); // 0x0000000181671D90-0x0000000181671E40
			internal string <BeautifyType>b__7_0(Type x); // 0x0000000181671CD0-0x0000000181671D30
			internal string <BeautifyType>b__7_1(Type x); // 0x0000000181671D30-0x0000000181671D90
		}
	
		// Constructors
		static DiagnosticsExtensions(); // 0x000000018166B2D0-0x000000018166B690
	
		// Methods
		private static bool IsAsync(MethodBase methodInfo); // 0x000000018166AA50-0x000000018166AB00
		private static bool TryResolveStateMachineMethod(ref MethodBase method, out Type declaringType); // 0x000000018166AF70-0x000000018166B2D0
		private static string BeautifyType(Type t, bool shortName); // 0x0000000181669DF0-0x000000018166A290
		private static bool IgnoreLine(MethodBase methodInfo); // 0x000000018166A950-0x000000018166AA50
		private static string SimplifyPath(string path); // 0x000000018166AB00-0x000000018166ABF0
	
		// Extension methods
		public static string ToStringWithCleanupAsyncStackTrace(this Exception exception); // 0x000000018166ABF0-0x000000018166AF70
		public static string CleanupAsyncStackTrace(this StackTrace stackTrace); // 0x000000018166A290-0x000000018166A950
	}
}
