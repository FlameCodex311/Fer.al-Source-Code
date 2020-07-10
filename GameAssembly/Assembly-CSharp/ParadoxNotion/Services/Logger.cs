/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace ParadoxNotion.Services
{
	public static class Logger // TypeDefIndex: 15265
	{
		// Fields
		private static List<LogHandler> subscribers; // 0x00
	
		// Nested types
		public struct Message // TypeDefIndex: 15266
		{
			// Fields
			public LogType type; // 0x00
			public string text; // 0x08
			public string tag; // 0x10
			public object context; // 0x18
	
			// Methods
			public bool IsSameAs(Message b); // 0x000000018020D1B0-0x000000018020D230
			public bool IsValid(); // 0x000000018020D230-0x000000018020D3D0
		}
	
		public delegate bool LogHandler(Message message); // TypeDefIndex: 15267; 0x0000000180624690-0x00000001806249F0
	
		// Constructors
		static Logger(); // 0x0000000181168EA0-0x0000000181168F00
	
		// Methods
		public static void AddListener(LogHandler callback); // 0x00000001811681E0-0x0000000181168260
		public static void RemoveListener(LogHandler callback); // 0x0000000181168E20-0x0000000181168EA0
		public static void Log(object message, Enum tag = default, object context = null); // 0x0000000181168D80-0x0000000181168E20
		public static void Log(object message, string tag = null, object context = null); // 0x0000000181168D00-0x0000000181168D80
		public static void LogWarning(object message, Enum tag = default, object context = null); // 0x0000000181168C60-0x0000000181168D00
		public static void LogWarning(object message, string tag = null, object context = null); // 0x0000000181168BE0-0x0000000181168C60
		public static void LogError(object message, Enum tag = default, object context = null); // 0x00000001811689A0-0x0000000181168A40
		public static void LogError(object message, string tag = null, object context = null); // 0x0000000181168A40-0x0000000181168AC0
		public static void LogException(Exception exception, Enum tag = default, object context = null); // 0x0000000181168AC0-0x0000000181168B60
		public static void LogException(Exception exception, string tag = null, object context = null); // 0x0000000181168B60-0x0000000181168BE0
		private static void Internal_Log(LogType type, object message, string tag, object context); // 0x0000000181168510-0x00000001811689A0
		private static void ForwardToUnity(LogType type, object message, string tag, object context); // 0x0000000181168260-0x0000000181168510
	}
}
