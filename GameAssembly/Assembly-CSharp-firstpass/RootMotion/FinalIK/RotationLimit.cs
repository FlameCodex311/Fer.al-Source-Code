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
	public abstract class RotationLimit : UnityEngine.MonoBehaviour // TypeDefIndex: 9978
	{
		// Fields
		public Vector3 axis; // 0x18
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public Quaternion defaultLocalRotation; // 0x24
		private bool initiated; // 0x34
		private bool applicationQuit; // 0x35
		private bool defaultLocalRotationSet; // 0x36
	
		// Properties
		public Vector3 secondaryAxis { get; } // 0x0000000181643880-0x00000001816438C0 
		public Vector3 crossAxis { get; } // 0x0000000181643790-0x0000000181643880 
	
		// Constructors
		protected RotationLimit(); // 0x0000000181643720-0x0000000181643790
	
		// Methods
		public void SetDefaultLocalRotation(); // 0x00000001816436E0-0x0000000181643720
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed); // 0x0000000181642F50-0x00000001816430D0
		public bool Apply(); // 0x0000000181642C30-0x0000000181642E10
		public void Disable(); // 0x0000000181642F20-0x0000000181642F50
		protected abstract Quaternion LimitRotation(Quaternion rotation);
		private void Awake(); // 0x0000000181642E10-0x0000000181642F20
		private void LateUpdate(); // 0x0000000181643190-0x0000000181643360
		public void LogWarning(string message); // 0x0000000181424090-0x00000001814240C0
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis); // 0x0000000181643360-0x0000000181643460
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit); // 0x0000000181643460-0x00000001816436E0
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal); // 0x00000001816430D0-0x0000000181643190
	}
}
