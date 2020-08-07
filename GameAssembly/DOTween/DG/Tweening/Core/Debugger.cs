/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;

// Image 49: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5670-5860

namespace DG.Tweening.Core
{
	public static class Debugger // TypeDefIndex: 5823
	{
		// Fields
		private static int _logPriority; // 0x00
		private const string _LogPrefix = "<color=#0099bc><b>DOTWEEN \u25BA </b></colo"; // Metadata: 0x007634AF
	
		// Properties
		public static int logPriority { get; } // 0x000000018178D2F0-0x000000018178D330 
	
		// Methods
		public static void Log(object message); // 0x000000018178D170-0x000000018178D290
		public static void LogWarning(object message); // 0x000000018178D050-0x000000018178D170
		public static void LogError(object message); // 0x000000018178CB30-0x000000018178CC50
		public static void LogReport(object message); // 0x000000018178CE50-0x000000018178CF50
		public static void LogSafeModeReport(object message); // 0x000000018178CF50-0x000000018178D050
		public static void LogInvalidTween(Tween t); // 0x000000018178CC50-0x000000018178CC90
		public static void LogNestedTween(Tween t); // 0x000000018178CD40-0x000000018178CD80
		public static void LogNullTween(Tween t); // 0x000000018178CDC0-0x000000018178CE00
		public static void LogNonPathTween(Tween t); // 0x000000018178CD80-0x000000018178CDC0
		public static void LogMissingMaterialProperty(string propertyName); // 0x000000018178CCF0-0x000000018178CD40
		public static void LogMissingMaterialProperty(int propertyId); // 0x000000018178CC90-0x000000018178CCF0
		public static void LogRemoveActiveTweenError(string errorInfo); // 0x000000018178CE00-0x000000018178CE50
		public static void LogAddActiveTweenError(string errorInfo); // 0x000000018178CAE0-0x000000018178CB30
		public static void SetLogPriority(LogBehaviour logBehaviour); // 0x000000018178D290-0x000000018178D2F0
	}
}
