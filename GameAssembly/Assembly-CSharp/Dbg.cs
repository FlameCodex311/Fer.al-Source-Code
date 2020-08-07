/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class Dbg // TypeDefIndex: 10865
{
	// Fields
	public static string debugPerson; // 0x00
	private static int? _debugPersonIdx; // 0x08

	// Properties
	public static bool isDebugBuild { get; } // 0x000000018055A660-0x000000018055A6B0 

	// Constructors
	public Dbg(); // 0x0000000180373240-0x0000000180373250
	static Dbg(); // 0x000000018055A620-0x000000018055A660

	// Methods
	public static bool ValidDebugPerson(EDebugPerson inDebugPerson); // 0x0000000180380B60-0x0000000180380B70
	public static void ReleaseLog(object message); // 0x000000018055A310-0x000000018055A390
	public static void ReleaseLog(object message, UnityEngine.Object context); // 0x000000018055A390-0x000000018055A420
	[Conditional] // 0x00000001801D54F0-0x00000001801D5520
	public static void EditorLog(object message, EDebugPerson inDebugPerson = EDebugPerson.ALL /* Metadata: 0x0077C26A */); // 0x0000000180559A80-0x0000000180559B20
	[Conditional] // 0x00000001801D54F0-0x00000001801D5520
	public static void EditorLog(object message, UnityEngine.Object context, EDebugPerson inDebugPerson = EDebugPerson.ALL /* Metadata: 0x0077C26E */); // 0x0000000180559B20-0x0000000180559BD0
	[Conditional] // 0x00000001801D54F0-0x00000001801D5520
	public static void EditorLogWarning(object message, EDebugPerson inDebugPerson = EDebugPerson.ALL /* Metadata: 0x0077C272 */); // 0x00000001805599E0-0x0000000180559A80
	[Conditional] // 0x00000001801D54F0-0x00000001801D5520
	public static void EditorLogWarning(object message, UnityEngine.Object context, EDebugPerson inDebugPerson = EDebugPerson.ALL /* Metadata: 0x0077C276 */); // 0x0000000180559930-0x00000001805599E0
	[Conditional] // 0x00000001801D54F0-0x00000001801D5520
	public static void EditorLogError(object message, EDebugPerson inDebugPerson = EDebugPerson.ALL /* Metadata: 0x0077C27A */); // 0x00000001805597E0-0x0000000180559880
	[Conditional] // 0x00000001801D54F0-0x00000001801D5520
	public static void EditorLogError(object message, UnityEngine.Object context, EDebugPerson inDebugPerson = EDebugPerson.ALL /* Metadata: 0x0077C27E */); // 0x0000000180559880-0x0000000180559930
	[Conditional] // 0x00000001801DEB60-0x00000001801DEBE0
	[Conditional] // 0x00000001801DEB60-0x00000001801DEBE0
	[Conditional] // 0x00000001801DEB60-0x00000001801DEBE0
	public static void Log(object message, EDebugPerson inDebugPerson = EDebugPerson.ALL /* Metadata: 0x0077C282 */); // 0x000000018055A060-0x000000018055A100
	[Conditional] // 0x00000001801DEB60-0x00000001801DEBE0
	[Conditional] // 0x00000001801DEB60-0x00000001801DEBE0
	[Conditional] // 0x00000001801DEB60-0x00000001801DEBE0
	public static void LogWithTime(object message); // 0x0000000180559F60-0x000000018055A060
	[Conditional] // 0x00000001801DEB60-0x00000001801DEBE0
	[Conditional] // 0x00000001801DEB60-0x00000001801DEBE0
	[Conditional] // 0x00000001801DEB60-0x00000001801DEBE0
	public static void Log(object message, UnityEngine.Object context, EDebugPerson inDebugPerson = EDebugPerson.ALL /* Metadata: 0x0077C286 */); // 0x00000001803774A0-0x00000001803774B0
	[Conditional] // 0x00000001801DEB60-0x00000001801DEBE0
	[Conditional] // 0x00000001801DEB60-0x00000001801DEBE0
	[Conditional] // 0x00000001801DEB60-0x00000001801DEBE0
	public static void LogWarning(object message, EDebugPerson inDebugPerson = EDebugPerson.ALL /* Metadata: 0x0077C28A */); // 0x0000000180559EC0-0x0000000180559F60
	[Conditional] // 0x00000001801DEB60-0x00000001801DEBE0
	[Conditional] // 0x00000001801DEB60-0x00000001801DEBE0
	[Conditional] // 0x00000001801DEB60-0x00000001801DEBE0
	public static void LogWarning(object message, UnityEngine.Object context, EDebugPerson inDebugPerson = EDebugPerson.ALL /* Metadata: 0x0077C28E */); // 0x0000000180559E10-0x0000000180559EC0
	public static void LogError(object message, EDebugPerson inDebugPerson = EDebugPerson.ALL /* Metadata: 0x0077C292 */); // 0x0000000180559BD0-0x0000000180559C70
	public static void LogError(object message, UnityEngine.Object context, EDebugPerson inDebugPerson = EDebugPerson.ALL /* Metadata: 0x0077C296 */); // 0x0000000180559C70-0x0000000180559D20
	public static void LogException(Exception exception, EDebugPerson inDebugPerson = EDebugPerson.ALL /* Metadata: 0x0077C29A */); // 0x0000000180559D20-0x0000000180559D90
	public static void LogException(Exception exception, UnityEngine.Object context, EDebugPerson inDebugPerson = EDebugPerson.ALL /* Metadata: 0x0077C29E */); // 0x0000000180559D90-0x0000000180559E10
	[Conditional] // 0x00000001801DFB50-0x00000001801DFBB0
	[Conditional] // 0x00000001801DFB50-0x00000001801DFBB0
	public static void Break(); // 0x00000001805595E0-0x0000000180559630
	[Conditional] // 0x00000001801DFB50-0x00000001801DFBB0
	[Conditional] // 0x00000001801DFB50-0x00000001801DFBB0
	public static void DebugBreak(); // 0x0000000180559630-0x0000000180559680
	[Conditional] // 0x00000001801DFB50-0x00000001801DFBB0
	[Conditional] // 0x00000001801DFB50-0x00000001801DFBB0
	public static void DrawLine(Vector3 start, Vector3 end, Color color); // 0x0000000180559680-0x0000000180559730
	[Conditional] // 0x00000001801DFB50-0x00000001801DFBB0
	[Conditional] // 0x00000001801DFB50-0x00000001801DFBB0
	public static void DrawRay(Vector3 start, Vector3 dir, Color color); // 0x0000000180559730-0x00000001805597E0
	[Conditional] // 0x00000001801DFB50-0x00000001801DFBB0
	[Conditional] // 0x00000001801DFB50-0x00000001801DFBB0
	public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration); // 0x00000001803774A0-0x00000001803774B0
	[Conditional] // 0x00000001801DFB50-0x00000001801DFBB0
	[Conditional] // 0x00000001801DFB50-0x00000001801DFBB0
	public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration, bool depthTest); // 0x00000001803774A0-0x00000001803774B0
	public static Type MParentType<T>();
	public static Type MParentType(Type inType); // 0x000000018055A1A0-0x000000018055A260
	public static bool MIsVerbose<T>();
	public static bool MIsVerbose(Type inType); // 0x000000018055A100-0x000000018055A1A0
	public static void MSetVerbose<T>(bool inVerbose);
	public static void MSetVerbose(Type inType, bool inVerbose); // 0x000000018055A260-0x000000018055A310
	[Conditional] // 0x00000001801DEB60-0x00000001801DEBE0
	[Conditional] // 0x00000001801DEB60-0x00000001801DEBE0
	[Conditional] // 0x00000001801DEB60-0x00000001801DEBE0
	public static void MLog<T>(string inLog);
	public static void MLogError<T>(string inLog);
	public static void Report(object message); // 0x000000018055A540-0x000000018055A620
	public static void ReportBundleError(string inBundleID); // 0x000000018055A420-0x000000018055A4B0
	public static void ReportToBlinky(string reportType, string uuid); // 0x000000018055A4B0-0x000000018055A540
}

