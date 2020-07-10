/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class Dbg // TypeDefIndex: 13199
{
	// Fields
	public static string debugPerson; // 0x00
	private static int? _debugPersonIdx; // 0x08

	// Properties
	public static bool isDebugBuild { get; } // 0x0000000180F47CD0-0x0000000180F47D20 

	// Constructors
	public Dbg(); // 0x000000018036B6C0-0x000000018036B6D0
	static Dbg(); // 0x0000000180F47C90-0x0000000180F47CD0

	// Methods
	public static bool ValidDebugPerson(EDebugPerson inDebugPerson); // 0x00000001803C29F0-0x00000001803C2A00
	public static void ReleaseLog(object message); // 0x0000000180F47970-0x0000000180F479F0
	public static void ReleaseLog(object message, UnityEngine.Object context); // 0x0000000180F479F0-0x0000000180F47A80
	[Conditional] // 0x00000001800C0AC0-0x00000001800C0AF0
	public static void EditorLog(object message, EDebugPerson inDebugPerson = EDebugPerson.ALL /* Metadata: 0x007837AF */); // 0x0000000180F470D0-0x0000000180F47170
	[Conditional] // 0x00000001800C0AC0-0x00000001800C0AF0
	public static void EditorLog(object message, UnityEngine.Object context, EDebugPerson inDebugPerson = EDebugPerson.ALL /* Metadata: 0x007837B3 */); // 0x0000000180F47170-0x0000000180F47220
	[Conditional] // 0x00000001800C0AC0-0x00000001800C0AF0
	public static void EditorLogWarning(object message, EDebugPerson inDebugPerson = EDebugPerson.ALL /* Metadata: 0x007837B7 */); // 0x0000000180F47030-0x0000000180F470D0
	[Conditional] // 0x00000001800C0AC0-0x00000001800C0AF0
	public static void EditorLogWarning(object message, UnityEngine.Object context, EDebugPerson inDebugPerson = EDebugPerson.ALL /* Metadata: 0x007837BB */); // 0x0000000180F46F80-0x0000000180F47030
	[Conditional] // 0x00000001800C0AC0-0x00000001800C0AF0
	public static void EditorLogError(object message, EDebugPerson inDebugPerson = EDebugPerson.ALL /* Metadata: 0x007837BF */); // 0x0000000180F46E30-0x0000000180F46ED0
	[Conditional] // 0x00000001800C0AC0-0x00000001800C0AF0
	public static void EditorLogError(object message, UnityEngine.Object context, EDebugPerson inDebugPerson = EDebugPerson.ALL /* Metadata: 0x007837C3 */); // 0x0000000180F46ED0-0x0000000180F46F80
	[Conditional] // 0x000000018010A720-0x000000018010A7A0
	[Conditional] // 0x000000018010A720-0x000000018010A7A0
	[Conditional] // 0x000000018010A720-0x000000018010A7A0
	public static void Log(object message, EDebugPerson inDebugPerson = EDebugPerson.ALL /* Metadata: 0x007837C7 */); // 0x0000000180F476B0-0x0000000180F47750
	[Conditional] // 0x000000018010A720-0x000000018010A7A0
	[Conditional] // 0x000000018010A720-0x000000018010A7A0
	[Conditional] // 0x000000018010A720-0x000000018010A7A0
	public static void LogWithTime(object message); // 0x0000000180F475B0-0x0000000180F476B0
	[Conditional] // 0x000000018010A720-0x000000018010A7A0
	[Conditional] // 0x000000018010A720-0x000000018010A7A0
	[Conditional] // 0x000000018010A720-0x000000018010A7A0
	public static void Log(object message, UnityEngine.Object context, EDebugPerson inDebugPerson = EDebugPerson.ALL /* Metadata: 0x007837CB */); // 0x00000001803581E0-0x00000001803581F0
	[Conditional] // 0x000000018010A720-0x000000018010A7A0
	[Conditional] // 0x000000018010A720-0x000000018010A7A0
	[Conditional] // 0x000000018010A720-0x000000018010A7A0
	public static void LogWarning(object message, EDebugPerson inDebugPerson = EDebugPerson.ALL /* Metadata: 0x007837CF */); // 0x0000000180F47510-0x0000000180F475B0
	[Conditional] // 0x000000018010A720-0x000000018010A7A0
	[Conditional] // 0x000000018010A720-0x000000018010A7A0
	[Conditional] // 0x000000018010A720-0x000000018010A7A0
	public static void LogWarning(object message, UnityEngine.Object context, EDebugPerson inDebugPerson = EDebugPerson.ALL /* Metadata: 0x007837D3 */); // 0x0000000180F47460-0x0000000180F47510
	public static void LogError(object message, EDebugPerson inDebugPerson = EDebugPerson.ALL /* Metadata: 0x007837D7 */); // 0x0000000180F47220-0x0000000180F472C0
	public static void LogError(object message, UnityEngine.Object context, EDebugPerson inDebugPerson = EDebugPerson.ALL /* Metadata: 0x007837DB */); // 0x0000000180F472C0-0x0000000180F47370
	public static void LogException(Exception exception, EDebugPerson inDebugPerson = EDebugPerson.ALL /* Metadata: 0x007837DF */); // 0x0000000180F47370-0x0000000180F473E0
	public static void LogException(Exception exception, UnityEngine.Object context, EDebugPerson inDebugPerson = EDebugPerson.ALL /* Metadata: 0x007837E3 */); // 0x0000000180F473E0-0x0000000180F47460
	[Conditional] // 0x00000001800B8950-0x00000001800B89B0
	[Conditional] // 0x00000001800B8950-0x00000001800B89B0
	public static void Break(); // 0x0000000180F46C30-0x0000000180F46C80
	[Conditional] // 0x00000001800B8950-0x00000001800B89B0
	[Conditional] // 0x00000001800B8950-0x00000001800B89B0
	public static void DebugBreak(); // 0x0000000180F46C80-0x0000000180F46CD0
	[Conditional] // 0x00000001800B8950-0x00000001800B89B0
	[Conditional] // 0x00000001800B8950-0x00000001800B89B0
	public static void DrawLine(Vector3 start, Vector3 end, Color color); // 0x0000000180F46CD0-0x0000000180F46D80
	[Conditional] // 0x00000001800B8950-0x00000001800B89B0
	[Conditional] // 0x00000001800B8950-0x00000001800B89B0
	public static void DrawRay(Vector3 start, Vector3 dir, Color color); // 0x0000000180F46D80-0x0000000180F46E30
	[Conditional] // 0x00000001800B8950-0x00000001800B89B0
	[Conditional] // 0x00000001800B8950-0x00000001800B89B0
	public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration); // 0x00000001803581E0-0x00000001803581F0
	[Conditional] // 0x00000001800B8950-0x00000001800B89B0
	[Conditional] // 0x00000001800B8950-0x00000001800B89B0
	public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration, bool depthTest); // 0x00000001803581E0-0x00000001803581F0
	public static Type MParentType<T>();
	public static Type MParentType(Type inType); // 0x0000000180F477F0-0x0000000180F478C0
	public static bool MIsVerbose<T>();
	public static bool MIsVerbose(Type inType); // 0x0000000180F47750-0x0000000180F477F0
	public static void MSetVerbose<T>(bool inVerbose);
	public static void MSetVerbose(Type inType, bool inVerbose); // 0x0000000180F478C0-0x0000000180F47970
	[Conditional] // 0x000000018010A720-0x000000018010A7A0
	[Conditional] // 0x000000018010A720-0x000000018010A7A0
	[Conditional] // 0x000000018010A720-0x000000018010A7A0
	public static void MLog<T>(string inLog);
	public static void MLogError<T>(string inLog);
	public static void Report(object message); // 0x0000000180F47BB0-0x0000000180F47C90
	public static void ReportBundleError(string inBundleID); // 0x0000000180F47A80-0x0000000180F47B10
	public static void ReportToBlinky(string reportType, string uuid); // 0x0000000180F47B10-0x0000000180F47BB0
}

