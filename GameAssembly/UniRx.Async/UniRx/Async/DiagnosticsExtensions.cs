/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async
{
	public static class DiagnosticsExtensions // TypeDefIndex: 8549
	{
		// Fields
		private static bool displayFilenames; // 0x00
		private static readonly Regex typeBeautifyRegex; // 0x08
		private static readonly Dictionary<Type, string> builtInTypeNames; // 0x10
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 8550
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<ParameterInfo, string> <>9__4_0; // 0x08
			public static Func<Type, string> <>9__7_0; // 0x10
			public static Func<Type, string> <>9__7_1; // 0x18
	
			// Constructors
			static <>c(); // 0x0000000180E1E8D0-0x0000000180E1E930
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal string <CleanupAsyncStackTrace>b__4_0(ParameterInfo p); // 0x0000000180E1E760-0x0000000180E1E810
			internal string <BeautifyType>b__7_0(Type x); // 0x0000000180E1E6A0-0x0000000180E1E700
			internal string <BeautifyType>b__7_1(Type x); // 0x0000000180E1E700-0x0000000180E1E760
		}
	
		// Constructors
		static DiagnosticsExtensions(); // 0x0000000180E18020-0x0000000180E183E0
	
		// Methods
		private static bool IsAsync(MethodBase methodInfo); // 0x0000000180E177E0-0x0000000180E17890
		private static bool TryResolveStateMachineMethod(ref MethodBase method, out Type declaringType); // 0x0000000180E17CD0-0x0000000180E18020
		private static string BeautifyType(Type t, bool shortName); // 0x0000000180E16BA0-0x0000000180E17040
		private static bool IgnoreLine(MethodBase methodInfo); // 0x0000000180E176E0-0x0000000180E177E0
		private static string SimplifyPath(string path); // 0x0000000180E17890-0x0000000180E17970
	
		// Extension methods
		public static string ToStringWithCleanupAsyncStackTrace(this Exception exception); // 0x0000000180E17970-0x0000000180E17CD0
		public static string CleanupAsyncStackTrace(this StackTrace stackTrace); // 0x0000000180E17040-0x0000000180E176E0
	}
}
