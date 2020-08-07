/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace ParadoxNotion.Services
{
	public static class Logger // TypeDefIndex: 15853
	{
		// Fields
		private static List<LogHandler> subscribers; // 0x00
	
		// Nested types
		public struct Message // TypeDefIndex: 15854
		{
			// Fields
			private WeakReference<object> _contextRef; // 0x00
			public LogType type; // 0x08
			public string text; // 0x10
			public string tag; // 0x18
	
			// Properties
			public object context { get; set; } // 0x0000000180005A80-0x0000000180005AE0 0x0000000180005AE0-0x0000000180005B70
	
			// Methods
			public bool IsValid(); // 0x0000000180005A60-0x0000000180005A80
		}
	
		public delegate bool LogHandler(Message message); // TypeDefIndex: 15855; 0x00000001804D68D0-0x00000001804D6C90
	
		// Constructors
		static Logger(); // 0x00000001804D7760-0x00000001804D77C0
	
		// Methods
		public static void AddListener(LogHandler callback); // 0x00000001804D6C90-0x00000001804D6D10
		public static void RemoveListener(LogHandler callback); // 0x00000001804D76E0-0x00000001804D7760
		[Conditional] // 0x0000000180255E60-0x0000000180255EC0
		[Conditional] // 0x0000000180255E60-0x0000000180255EC0
		public static void Log(object message, string tag = null, object context = null); // 0x00000001804D7660-0x00000001804D76E0
		[Conditional] // 0x0000000180255E60-0x0000000180255EC0
		[Conditional] // 0x0000000180255E60-0x0000000180255EC0
		public static void LogWarning(object message, string tag = null, object context = null); // 0x00000001804D75E0-0x00000001804D7660
		[Conditional] // 0x0000000180255E60-0x0000000180255EC0
		[Conditional] // 0x0000000180255E60-0x0000000180255EC0
		public static void LogError(object message, string tag = null, object context = null); // 0x00000001804D74E0-0x00000001804D7560
		public static void LogException(Exception exception, string tag = null, object context = null); // 0x00000001804D7560-0x00000001804D75E0
		private static void Internal_Log(LogType type, object message, string tag, object context); // 0x00000001804D6FC0-0x00000001804D74E0
		private static void ForwardToUnity(LogType type, object message, string tag, object context); // 0x00000001804D6D10-0x00000001804D6FC0
	}
}
