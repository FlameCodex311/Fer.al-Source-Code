/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace FIMSpace.Basics
{
	public class FBasic_DuplicateObjects : UnityEngine.MonoBehaviour // TypeDefIndex: 10361
	{
		// Fields
		[Tooltip] // 0x00000001801EA530-0x00000001801EA560
		public GameObject ToDuplicate; // 0x18
		[Tooltip] // 0x00000001801EA760-0x00000001801EA790
		public Vector3 DuplicatesCount; // 0x20
		[Tooltip] // 0x00000001801EA8D0-0x00000001801EA900
		public Vector3 Offsets; // 0x2C
		[Tooltip] // 0x00000001801EAAE0-0x00000001801EAB10
		public bool PlaceOnGround; // 0x38
		public FEDuplicateDirection DuplicationType; // 0x3C
		public FEDuplicateOrigin DuplicationOrigin; // 0x40
	
		// Nested types
		public enum FEDuplicateDirection // TypeDefIndex: 10362
		{
			GoIterative = 0,
			GoFromCenter = 1
		}
	
		public enum FEDuplicateOrigin // TypeDefIndex: 10363
		{
			FromToDuplicate = 0,
			FromComponent = 1
		}
	
		// Constructors
		public FBasic_DuplicateObjects(); // 0x000000018107E0E0-0x000000018107E180
	
		// Methods
		public void Duplicate(); // 0x000000018107D160-0x000000018107DAD0
		private void OnDrawGizmos(); // 0x000000018107DAD0-0x000000018107E0E0
	}
}
