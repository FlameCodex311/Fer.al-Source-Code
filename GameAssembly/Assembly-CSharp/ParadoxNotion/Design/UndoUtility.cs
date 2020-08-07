/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace ParadoxNotion.Design
{
	public static class UndoUtility // TypeDefIndex: 15974
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static string <lastOperationName>k__BackingField; // 0x00
	
		// Properties
		public static string lastOperationName { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001806D9CB0-0x00000001806D9CF0 0x00000001806D9CF0-0x00000001806D9D30
	
		// Methods
		[Conditional] // 0x00000001801D54F0-0x00000001801D5520
		public static void RecordObject(UnityEngine.Object target, string name); // 0x00000001803774A0-0x00000001803774B0
		[Conditional] // 0x00000001801D54F0-0x00000001801D5520
		public static void RecordObjectComplete(UnityEngine.Object target, string name); // 0x00000001803774A0-0x00000001803774B0
		[Conditional] // 0x00000001801D54F0-0x00000001801D5520
		public static void SetDirty(UnityEngine.Object target); // 0x00000001803774A0-0x00000001803774B0
		[Conditional] // 0x00000001801D54F0-0x00000001801D5520
		public static void RecordObject(UnityEngine.Object target, string name, Action operation); // 0x00000001806D9C90-0x00000001806D9CB0
		[Conditional] // 0x00000001801D54F0-0x00000001801D5520
		public static void RecordObjectComplete(UnityEngine.Object target, string name, Action operation); // 0x00000001806D9C90-0x00000001806D9CB0
		public static string GetLastOperationNameOr(string operation); // 0x00000001806D9C10-0x00000001806D9C90
		public static void CheckUndo(UnityEngine.Object target, string name); // 0x00000001806D9B70-0x00000001806D9C10
		public static void CheckDirty(UnityEngine.Object target); // 0x00000001806D9B20-0x00000001806D9B70
	}
}
