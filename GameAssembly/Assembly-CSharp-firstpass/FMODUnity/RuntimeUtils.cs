/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FMOD;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace FMODUnity
{
	public static class RuntimeUtils // TypeDefIndex: 9840
	{
		// Fields
		private const string BankExtension = ".bank"; // Metadata: 0x00745F2A
	
		// Methods
		internal static string GetBankPathWW(string bankName, string bankFolder); // 0x0000000181B2C630-0x0000000181B2C6C0
		public static ATTRIBUTES_3D To3DAttributes(Transform transform, Rigidbody rigidbody = null); // 0x0000000181B2CD50-0x0000000181B2CE50
		public static ATTRIBUTES_3D To3DAttributes(GameObject go, Rigidbody rigidbody = null); // 0x0000000181B2CA00-0x0000000181B2CB20
		public static ATTRIBUTES_3D To3DAttributes(Transform transform, Rigidbody2D rigidbody); // 0x0000000181B2CC40-0x0000000181B2CD50
		public static ATTRIBUTES_3D To3DAttributes(GameObject go, Rigidbody2D rigidbody); // 0x0000000181B2C7D0-0x0000000181B2C900
		internal static FMODPlatform GetCurrentPlatform(); // 0x000000018045B7B0-0x000000018045B7C0
		internal static string GetBankPath(string bankName); // 0x0000000181B2C6C0-0x0000000181B2C760
		internal static string GetPluginPath(string pluginName); // 0x0000000181B2C760-0x0000000181B2C7D0
		public static void EnforceLibraryOrder(); // 0x0000000181B2C5D0-0x0000000181B2C630
	
		// Extension methods
		public static VECTOR ToFMODVector(this Vector3 vec); // 0x0000000181B2CE50-0x0000000181B2CFC0
		public static ATTRIBUTES_3D To3DAttributes(this Vector3 pos); // 0x0000000181B2CB20-0x0000000181B2CC40
		public static ATTRIBUTES_3D To3DAttributes(this Transform transform); // 0x0000000181B2C900-0x0000000181B2CA00
	}
}
