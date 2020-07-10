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
	public abstract class RotationLimit : UnityEngine.MonoBehaviour // TypeDefIndex: 9444
	{
		// Fields
		public Vector3 axis; // 0x18
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public Quaternion defaultLocalRotation; // 0x24
		private bool initiated; // 0x34
		private bool applicationQuit; // 0x35
		private bool defaultLocalRotationSet; // 0x36
	
		// Properties
		public Vector3 secondaryAxis { get; } // 0x0000000181B0F9D0-0x0000000181B0FA10 
		public Vector3 crossAxis { get; } // 0x0000000181B0F8E0-0x0000000181B0F9D0 
	
		// Constructors
		protected RotationLimit(); // 0x0000000181B0F870-0x0000000181B0F8E0
	
		// Methods
		public void SetDefaultLocalRotation(); // 0x0000000181B0F830-0x0000000181B0F870
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed); // 0x0000000181B0F0A0-0x0000000181B0F220
		public bool Apply(); // 0x0000000181B0ED70-0x0000000181B0EF60
		public void Disable(); // 0x0000000181B0F070-0x0000000181B0F0A0
		protected abstract Quaternion LimitRotation(Quaternion rotation);
		private void Awake(); // 0x0000000181B0EF60-0x0000000181B0F070
		private void LateUpdate(); // 0x0000000181B0F2E0-0x0000000181B0F4B0
		public void LogWarning(string message); // 0x000000018181E940-0x000000018181E970
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis); // 0x0000000181B0F4B0-0x0000000181B0F5B0
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit); // 0x0000000181B0F5B0-0x0000000181B0F830
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal); // 0x0000000181B0F220-0x0000000181B0F2E0
	}
}
