/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion.FinalIK
{
	[Serializable]
	public class FABRIKChain // TypeDefIndex: 9900
	{
		// Fields
		public FABRIK ik; // 0x10
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float pull; // 0x18
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float pin; // 0x1C
		public int[] children; // 0x20
	
		// Constructors
		public FABRIKChain(); // 0x0000000181428BB0-0x0000000181428C10
	
		// Methods
		public bool IsValid(ref string message); // 0x0000000181428720-0x00000001814287F0
		public void Initiate(); // 0x000000018137E430-0x000000018137E460
		public void Stage1(FABRIKChain[] chain); // 0x00000001814287F0-0x00000001814289B0
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain); // 0x00000001814289B0-0x0000000181428BB0
		private Vector3 GetCentroid(FABRIKChain[] chain); // 0x0000000181428220-0x0000000181428720
	}
}
