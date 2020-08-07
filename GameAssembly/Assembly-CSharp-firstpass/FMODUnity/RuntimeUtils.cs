/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FMOD;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace FMODUnity
{
	public static class RuntimeUtils // TypeDefIndex: 10294
	{
		// Fields
		private const string BankExtension = ".bank"; // Metadata: 0x0077B9DC
	
		// Methods
		internal static string GetBankPathWW(string bankName, string bankFolder); // 0x0000000180D31C70-0x0000000180D31D00
		public static ATTRIBUTES_3D To3DAttributes(Transform transform, Rigidbody rigidbody = null); // 0x0000000180D32380-0x0000000180D32480
		public static ATTRIBUTES_3D To3DAttributes(GameObject go, Rigidbody rigidbody = null); // 0x0000000180D32030-0x0000000180D32150
		public static ATTRIBUTES_3D To3DAttributes(Transform transform, Rigidbody2D rigidbody); // 0x0000000180D32270-0x0000000180D32380
		public static ATTRIBUTES_3D To3DAttributes(GameObject go, Rigidbody2D rigidbody); // 0x0000000180D31E10-0x0000000180D31F30
		internal static FMODPlatform GetCurrentPlatform(); // 0x00000001808E2210-0x00000001808E2220
		internal static string GetBankPath(string bankName); // 0x0000000180D31D00-0x0000000180D31DA0
		internal static string GetPluginPath(string pluginName); // 0x0000000180D31DA0-0x0000000180D31E10
		public static void EnforceLibraryOrder(); // 0x0000000180D31C10-0x0000000180D31C70
	
		// Extension methods
		public static VECTOR ToFMODVector(this Vector3 vec); // 0x0000000180D32480-0x0000000180D324C0
		public static ATTRIBUTES_3D To3DAttributes(this Vector3 pos); // 0x0000000180D32150-0x0000000180D32270
		public static ATTRIBUTES_3D To3DAttributes(this Transform transform); // 0x0000000180D31F30-0x0000000180D32030
	}
}
