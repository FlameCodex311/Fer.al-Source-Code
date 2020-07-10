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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	[CustomClassObfuscation] // 0x00000001800BCF20-0x00000001800BCF70
	[CustomObfuscation] // 0x00000001800BCF20-0x00000001800BCF70
	internal static class Logger // TypeDefIndex: 6324
	{
		// Fields
		private const int screenLogLength = 50; // Metadata: 0x0072F97C
		private static List<string> __screenLog; // 0x00
		private static GUIText _guiText; // 0x08
		private static bool _logToScreen; // 0x10
	
		// Properties
		private static List<string> screenLog { get; } // 0x0000000180633AC0-0x0000000180633B40 
		private static LogLevelFlags logLevel { get; } // 0x00000001806338B0-0x0000000180633A80 
		public static bool logToScreen { get; set; } // 0x0000000180633A80-0x0000000180633AC0 0x0000000180633B40-0x0000000180633D30
	
		// Methods
		public static void LogEditor(object msg); // 0x00000001806311B0-0x0000000180631410
		public static void LogEditor(object msg, bool requiredThreadSafety); // 0x00000001806310C0-0x00000001806311B0
		public static void LogWarningEditor(object msg); // 0x0000000180632F20-0x0000000180633010
		public static void LogWarningEditor(object msg, bool requiredThreadSafety); // 0x0000000180633010-0x0000000180633100
		public static void LogErrorEditor(object msg); // 0x0000000180631500-0x00000001806315F0
		public static void LogErrorEditor(object msg, bool requiredThreadSafety); // 0x0000000180631410-0x0000000180631500
		public static void Log(object msg); // 0x0000000180633540-0x00000001806336D0
		public static void Log(object msg, bool requiredThreadSafety); // 0x00000001806336D0-0x00000001806338B0
		public static void LogWarning(object msg); // 0x0000000180633530-0x0000000180633540
		public static void LogWarning(object msg, bool requiredThreadSafety); // 0x0000000180633260-0x0000000180633530
		public static void LogError(object msg); // 0x00000001806317B0-0x00000001806317C0
		public static void LogError(object msg, bool requiredThreadSafety); // 0x00000001806317C0-0x0000000180632740
		private static void LogNow(object msg, bool requireThreadSafety); // 0x0000000180632870-0x0000000180632990
		private static void LogWarningNow(object msg, bool requireThreadSafety); // 0x0000000180633100-0x0000000180633260
		private static void LogErrorNow(object msg, bool requireThreadSafety); // 0x00000001806315F0-0x00000001806317B0
		private static bool IsLoggingAllowed(LogLevel logLevel); // 0x0000000180630FD0-0x00000001806310C0
		private static void LogToScreen(object msg); // 0x0000000180632990-0x0000000180632F20
		[Conditional] // 0x0000000180142A10-0x0000000180142A40
		public static void LogInit(object o); // 0x0000000180632760-0x0000000180632870
		[Conditional] // 0x0000000180142A10-0x0000000180142A40
		public static void LogInitError(object o); // 0x0000000180632740-0x0000000180632750
		[Conditional] // 0x0000000180142A10-0x0000000180142A40
		public static void LogInitWarning(object o); // 0x0000000180632750-0x0000000180632760
		[Conditional] // 0x00000001801431D0-0x0000000180143200
		public static void Log_VCTest(object o); // 0x0000000180633540-0x00000001806336D0
		[Conditional] // 0x0000000180143430-0x0000000180143460
		public static void LogUpdate(object o); // 0x0000000180632760-0x0000000180632870
	}
}
