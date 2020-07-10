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
	public abstract class Grounder : UnityEngine.MonoBehaviour // TypeDefIndex: 9339
	{
		// Fields
		[Range] // 0x0000000180121C70-0x0000000180121CD0
		[Tooltip] // 0x0000000180121C70-0x0000000180121CD0
		public float weight; // 0x18
		[Tooltip] // 0x0000000180121FA0-0x0000000180121FD0
		public Grounding solver; // 0x20
		public GrounderDelegate OnPreGrounder; // 0x28
		public GrounderDelegate OnPostGrounder; // 0x30
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <initiated>k__BackingField; // 0x38
	
		// Properties
		public bool initiated { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ protected set; } // 0x00000001804AEAD0-0x00000001804AEAE0 0x000000018044E330-0x000000018044E340
	
		// Nested types
		public delegate void GrounderDelegate(); // TypeDefIndex: 9340; 0x00000001804C7D50-0x00000001804C7EF0
	
		// Constructors
		protected Grounder(); // 0x0000000181C20930-0x0000000181C209F0
	
		// Methods
		public abstract void ResetPosition();
		protected Vector3 GetSpineOffsetTarget(); // 0x0000000181C20760-0x0000000181C20930
		protected void LogWarning(string message); // 0x000000018181E940-0x000000018181E970
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg); // 0x0000000181C20240-0x0000000181C20470
		private Vector3 GetLegSpineTangent(Grounding.Leg leg); // 0x0000000181C20470-0x0000000181C20760
		protected abstract void OpenUserManual();
		protected abstract void OpenScriptReference();
	}
}
