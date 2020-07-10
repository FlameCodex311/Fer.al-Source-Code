/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion.FinalIK
{
	[Serializable]
	public class FABRIKChain // TypeDefIndex: 9366
	{
		// Fields
		public FABRIK ik; // 0x10
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float pull; // 0x18
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float pin; // 0x1C
		public int[] children; // 0x20
	
		// Constructors
		public FABRIKChain(); // 0x0000000181824230-0x0000000181824290
	
		// Methods
		public bool IsValid(ref string message); // 0x0000000181823D70-0x0000000181823E40
		public void Initiate(); // 0x0000000181823D40-0x0000000181823D70
		public void Stage1(FABRIKChain[] chain); // 0x0000000181823E40-0x0000000181824010
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain); // 0x0000000181824010-0x0000000181824230
		private Vector3 GetCentroid(FABRIKChain[] chain); // 0x0000000181823820-0x0000000181823D40
	}
}
