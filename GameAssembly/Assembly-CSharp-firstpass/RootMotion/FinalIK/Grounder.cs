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
	public abstract class Grounder : UnityEngine.MonoBehaviour // TypeDefIndex: 9873
	{
		// Fields
		[Range] // 0x0000000180226A20-0x0000000180226A80
		[Tooltip] // 0x0000000180226A20-0x0000000180226A80
		public float weight; // 0x18
		[Tooltip] // 0x0000000180226CB0-0x0000000180226CE0
		public Grounding solver; // 0x20
		public GrounderDelegate OnPreGrounder; // 0x28
		public GrounderDelegate OnPostGrounder; // 0x30
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <initiated>k__BackingField; // 0x38
	
		// Properties
		public bool initiated { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ protected set; } // 0x0000000180379B20-0x0000000180379B30 0x00000001804F1690-0x00000001804F16A0
	
		// Nested types
		public delegate void GrounderDelegate(); // TypeDefIndex: 9874; 0x0000000181437090-0x0000000181437300
	
		// Constructors
		protected Grounder(); // 0x000000018143DEE0-0x000000018143DF40
	
		// Methods
		public abstract void ResetPosition();
		protected Vector3 GetSpineOffsetTarget(); // 0x000000018143DAF0-0x000000018143DEE0
		protected void LogWarning(string message); // 0x0000000181424090-0x00000001814240C0
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg); // 0x000000018143D5E0-0x000000018143D810
		private Vector3 GetLegSpineTangent(Grounding.Leg leg); // 0x000000018143D810-0x000000018143DAF0
		protected abstract void OpenUserManual();
		protected abstract void OpenScriptReference();
	}
}
