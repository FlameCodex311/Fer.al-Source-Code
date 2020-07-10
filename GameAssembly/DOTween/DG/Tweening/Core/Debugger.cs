/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;

// Image 48: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5511-5701

namespace DG.Tweening.Core
{
	public static class Debugger // TypeDefIndex: 5664
	{
		// Fields
		private static int _logPriority; // 0x00
		private const string _LogPrefix = "<color=#0099bc><b>DOTWEEN \u25BA </b></colo"; // Metadata: 0x0072E812
	
		// Properties
		public static int logPriority { get; } // 0x0000000180BC9D30-0x0000000180BC9DB0 
	
		// Methods
		public static void Log(object message); // 0x0000000180BC9BB0-0x0000000180BC9CD0
		public static void LogWarning(object message); // 0x0000000180BC9A90-0x0000000180BC9BB0
		public static void LogError(object message); // 0x0000000180BC9570-0x0000000180BC9690
		public static void LogReport(object message); // 0x0000000180BC9890-0x0000000180BC9990
		public static void LogSafeModeReport(object message); // 0x0000000180BC9990-0x0000000180BC9A90
		public static void LogInvalidTween(Tween t); // 0x0000000180BC9690-0x0000000180BC96D0
		public static void LogNestedTween(Tween t); // 0x0000000180BC9780-0x0000000180BC97C0
		public static void LogNullTween(Tween t); // 0x0000000180BC9800-0x0000000180BC9840
		public static void LogNonPathTween(Tween t); // 0x0000000180BC97C0-0x0000000180BC9800
		public static void LogMissingMaterialProperty(string propertyName); // 0x0000000180BC9730-0x0000000180BC9780
		public static void LogMissingMaterialProperty(int propertyId); // 0x0000000180BC96D0-0x0000000180BC9730
		public static void LogRemoveActiveTweenError(string errorInfo); // 0x0000000180BC9840-0x0000000180BC9890
		public static void LogAddActiveTweenError(string errorInfo); // 0x0000000180BC9520-0x0000000180BC9570
		public static void SetLogPriority(LogBehaviour logBehaviour); // 0x0000000180BC9CD0-0x0000000180BC9D30
	}
}
