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
	[AddComponentMenu] // 0x0000000180270E20-0x0000000180270E80
	[HelpURL] // 0x0000000180270E20-0x0000000180270E80
	public class RotationLimitPolygonal : RotationLimit // TypeDefIndex: 9981
	{
		// Fields
		[Range] // 0x000000018020FC30-0x000000018020FC50
		public float twistLimit; // 0x38
		[Range] // 0x00000001802711B0-0x00000001802711D0
		public int smoothIterations; // 0x3C
		[HideInInspector] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		public LimitPoint[] points; // 0x40
		[HideInInspector] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		public Vector3[] P; // 0x48
		[HideInInspector] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		public ReachCone[] reachCones; // 0x50
	
		// Nested types
		[Serializable]
		public class ReachCone // TypeDefIndex: 9982
		{
			// Fields
			public Vector3[] tetrahedron; // 0x10
			public float volume; // 0x18
			public Vector3 S; // 0x1C
			public Vector3 B; // 0x28
	
			// Properties
			public Vector3 o { get; } // 0x000000018201FF30-0x000000018201FF70 
			public Vector3 a { get; } // 0x000000018201FE60-0x000000018201FEA0 
			public Vector3 b { get; } // 0x000000018201FEA0-0x000000018201FEE0 
			public Vector3 c { get; } // 0x000000018201FEE0-0x000000018201FF20 
			public bool isValid { get; } // 0x000000018201FF20-0x000000018201FF30 
	
			// Constructors
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c); // 0x000000018201FCA0-0x000000018201FE60
	
			// Methods
			public void Calculate(); // 0x000000018201F9A0-0x000000018201FCA0
		}
	
		[Serializable]
		public class LimitPoint // TypeDefIndex: 9983
		{
			// Fields
			public Vector3 point; // 0x10
			public float tangentWeight; // 0x1C
	
			// Constructors
			public LimitPoint(); // 0x000000018201E900-0x000000018201E980
		}
	
		// Constructors
		public RotationLimitPolygonal(); // 0x0000000181642B90-0x0000000181642C30
	
		// Methods
		[ContextMenu] // 0x00000001801E9920-0x00000001801E9950
		private void OpenUserManual(); // 0x0000000181641460-0x00000001816414A0
		[ContextMenu] // 0x00000001801E9B90-0x00000001801E9BC0
		private void OpenScriptReference(); // 0x0000000181641420-0x0000000181641460
		[ContextMenu] // 0x00000001802233A0-0x00000001802233D0
		private void SupportGroup(); // 0x0000000181642950-0x0000000181642990
		[ContextMenu] // 0x0000000180223520-0x0000000180223550
		private void ASThread(); // 0x00000001816405F0-0x0000000181640630
		public void SetLimitPoints(LimitPoint[] points); // 0x0000000181641B00-0x0000000181641B80
		protected override Quaternion LimitRotation(Quaternion rotation); // 0x0000000181640F40-0x0000000181641060
		private void Start(); // 0x00000001816425E0-0x0000000181642950
		public void ResetToDefault(); // 0x0000000181641630-0x0000000181641B00
		public void BuildReachCones(); // 0x0000000181640630-0x0000000181640C40
		private Vector3[] SmoothPoints(); // 0x0000000181641B80-0x00000001816425E0
		private float GetScalar(int k); // 0x0000000181640EF0-0x0000000181640F40
		private Vector3 PointToTangentPlane(Vector3 p, float r); // 0x00000001816414A0-0x0000000181641630
		private Vector3 TangentPointToSphere(Vector3 q, float r); // 0x0000000181642990-0x0000000181642B90
		private Quaternion LimitSwing(Quaternion rotation); // 0x0000000181641060-0x0000000181641420
		private int GetReachCone(Vector3 L); // 0x0000000181640C40-0x0000000181640EF0
	}
}
