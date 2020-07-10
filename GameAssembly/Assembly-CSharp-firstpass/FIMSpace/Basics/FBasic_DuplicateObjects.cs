/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace FIMSpace.Basics
{
	public class FBasic_DuplicateObjects : UnityEngine.MonoBehaviour // TypeDefIndex: 9907
	{
		// Fields
		[Tooltip] // 0x0000000180107970-0x00000001801079A0
		public GameObject ToDuplicate; // 0x18
		[Tooltip] // 0x0000000180107C80-0x0000000180107CB0
		public Vector3 DuplicatesCount; // 0x20
		[Tooltip] // 0x0000000180107E00-0x0000000180107E30
		public Vector3 Offsets; // 0x2C
		[Tooltip] // 0x0000000180107FA0-0x0000000180107FD0
		public bool PlaceOnGround; // 0x38
		public FEDuplicateDirection DuplicationType; // 0x3C
		public FEDuplicateOrigin DuplicationOrigin; // 0x40
	
		// Nested types
		public enum FEDuplicateDirection // TypeDefIndex: 9908
		{
			GoIterative = 0,
			GoFromCenter = 1
		}
	
		public enum FEDuplicateOrigin // TypeDefIndex: 9909
		{
			FromToDuplicate = 0,
			FromComponent = 1
		}
	
		// Constructors
		public FBasic_DuplicateObjects(); // 0x00000001815D4430-0x00000001815D44D0
	
		// Methods
		public void Duplicate(); // 0x00000001815D34A0-0x00000001815D3E20
		private void OnDrawGizmos(); // 0x00000001815D3E20-0x00000001815D4430
	}
}
