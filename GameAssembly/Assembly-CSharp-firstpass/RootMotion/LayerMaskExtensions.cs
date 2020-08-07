/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion
{
	public static class LayerMaskExtensions // TypeDefIndex: 9774
	{
		// Methods
		public static bool Contains(LayerMask mask, int layer); // 0x000000018201E2E0-0x000000018201E320
		public static LayerMask Create(params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ string[] layerNames); // 0x000000018201E320-0x000000018201E3C0
		public static LayerMask Create(params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ int[] layerNumbers); // 0x000000018201E3C0-0x000000018201E440
		public static LayerMask NamesToMask(params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ string[] layerNames); // 0x000000018201E320-0x000000018201E3C0
		public static LayerMask LayerNumbersToMask(params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ int[] layerNumbers); // 0x000000018201E3C0-0x000000018201E440
	
		// Extension methods
		public static LayerMask Inverse(this LayerMask original); // 0x000000018201E440-0x000000018201E460
		public static LayerMask AddToMask(this LayerMask original, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ string[] layerNames); // 0x000000018201E210-0x000000018201E2E0
		public static LayerMask RemoveFromMask(this LayerMask original, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ string[] layerNames); // 0x000000018201E820-0x000000018201E900
		public static string[] MaskToNames(this LayerMask original); // 0x000000018201E460-0x000000018201E540
		public static int[] MaskToNumbers(this LayerMask original); // 0x000000018201E540-0x000000018201E600
		public static string MaskToString(this LayerMask original); // 0x000000018201E600-0x000000018201E720
		public static string MaskToString(this LayerMask original, string delimiter); // 0x000000018201E720-0x000000018201E820
	}
}
