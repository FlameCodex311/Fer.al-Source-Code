/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Config;
using Rewired.Internal;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	[CustomClassObfuscation] // 0x00000001801DE5D0-0x00000001801DE620
	[CustomObfuscation] // 0x00000001801DE5D0-0x00000001801DE620
	internal static class Logger // TypeDefIndex: 6483
	{
		// Fields
		private const int screenLogLength = 50; // Metadata: 0x00764619
		private static List<string> __screenLog; // 0x00
		private static GUIText _guiText; // 0x08
		private static bool _logToScreen; // 0x10
	
		// Properties
		private static List<string> screenLog { get; } // 0x0000000180EAB3D0-0x0000000180EAB450 
		private static LogLevelFlags logLevel { get; } // 0x0000000180EAB1C0-0x0000000180EAB390 
		public static bool logToScreen { get; set; } // 0x0000000180EAB390-0x0000000180EAB3D0 0x0000000180EAB450-0x0000000180EAB640
	
		// Methods
		public static void LogEditor(object msg); // 0x0000000180EA8BB0-0x0000000180EA8E10
		public static void LogEditor(object msg, bool requiredThreadSafety); // 0x0000000180EA8AC0-0x0000000180EA8BB0
		public static void LogWarningEditor(object msg); // 0x0000000180EAA840-0x0000000180EAA930
		public static void LogWarningEditor(object msg, bool requiredThreadSafety); // 0x0000000180EAA930-0x0000000180EAAA20
		public static void LogErrorEditor(object msg); // 0x0000000180EA8F00-0x0000000180EA8FF0
		public static void LogErrorEditor(object msg, bool requiredThreadSafety); // 0x0000000180EA8E10-0x0000000180EA8F00
		public static void Log(object msg); // 0x0000000180EAAE60-0x0000000180EAAFF0
		public static void Log(object msg, bool requiredThreadSafety); // 0x0000000180EAAFF0-0x0000000180EAB1C0
		public static void LogWarning(object msg); // 0x0000000180EAAE50-0x0000000180EAAE60
		public static void LogWarning(object msg, bool requiredThreadSafety); // 0x0000000180EAAB80-0x0000000180EAAE50
		public static void LogError(object msg); // 0x0000000180EA91B0-0x0000000180EA91C0
		public static void LogError(object msg, bool requiredThreadSafety); // 0x0000000180EA91C0-0x0000000180EAA090
		private static void LogNow(object msg, bool requireThreadSafety); // 0x0000000180EAA1C0-0x0000000180EAA2E0
		private static void LogWarningNow(object msg, bool requireThreadSafety); // 0x0000000180EAAA20-0x0000000180EAAB80
		private static void LogErrorNow(object msg, bool requireThreadSafety); // 0x0000000180EA8FF0-0x0000000180EA91B0
		private static bool IsLoggingAllowed(LogLevel logLevel); // 0x0000000180EA89D0-0x0000000180EA8AC0
		private static void LogToScreen(object msg); // 0x0000000180EAA2E0-0x0000000180EAA840
		[Conditional] // 0x00000001801DE760-0x00000001801DE790
		public static void LogInit(object o); // 0x0000000180EAA0B0-0x0000000180EAA1C0
		[Conditional] // 0x00000001801DE760-0x00000001801DE790
		public static void LogInitError(object o); // 0x0000000180EAA090-0x0000000180EAA0A0
		[Conditional] // 0x00000001801DE760-0x00000001801DE790
		public static void LogInitWarning(object o); // 0x0000000180EAA0A0-0x0000000180EAA0B0
		[Conditional] // 0x00000001801DEC40-0x00000001801DEC70
		public static void Log_VCTest(object o); // 0x0000000180EAAE60-0x0000000180EAAFF0
		[Conditional] // 0x00000001801DED80-0x00000001801DEDB0
		public static void LogUpdate(object o); // 0x0000000180EAA0B0-0x0000000180EAA1C0
	}
}
