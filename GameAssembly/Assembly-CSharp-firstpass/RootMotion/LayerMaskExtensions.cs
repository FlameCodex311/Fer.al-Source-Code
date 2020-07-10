/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion
{
	public static class LayerMaskExtensions // TypeDefIndex: 9320
	{
		// Methods
		public static bool Contains(LayerMask mask, int layer); // 0x00000001822829F0-0x0000000182282A30
		public static LayerMask Create(params /* 0x00000001800B36B0-0x00000001800B36C0 */ string[] layerNames); // 0x0000000182282A30-0x0000000182282AD0
		public static LayerMask Create(params /* 0x00000001800B36B0-0x00000001800B36C0 */ int[] layerNumbers); // 0x0000000182282AD0-0x0000000182282B50
		public static LayerMask NamesToMask(params /* 0x00000001800B36B0-0x00000001800B36C0 */ string[] layerNames); // 0x0000000182282A30-0x0000000182282AD0
		public static LayerMask LayerNumbersToMask(params /* 0x00000001800B36B0-0x00000001800B36C0 */ int[] layerNumbers); // 0x0000000182282AD0-0x0000000182282B50
	
		// Extension methods
		public static LayerMask Inverse(this LayerMask original); // 0x0000000182282B50-0x0000000182282B70
		public static LayerMask AddToMask(this LayerMask original, params /* 0x00000001800B36B0-0x00000001800B36C0 */ string[] layerNames); // 0x0000000182282920-0x00000001822829F0
		public static LayerMask RemoveFromMask(this LayerMask original, params /* 0x00000001800B36B0-0x00000001800B36C0 */ string[] layerNames); // 0x0000000182282F40-0x0000000182283020
		public static string[] MaskToNames(this LayerMask original); // 0x0000000182282B70-0x0000000182282C50
		public static int[] MaskToNumbers(this LayerMask original); // 0x0000000182282C50-0x0000000182282D20
		public static string MaskToString(this LayerMask original); // 0x0000000182282D20-0x0000000182282E40
		public static string MaskToString(this LayerMask original, string delimiter); // 0x0000000182282E40-0x0000000182282F40
	}
}
