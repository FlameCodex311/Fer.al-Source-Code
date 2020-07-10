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
	[AddComponentMenu] // 0x0000000180171590-0x00000001801715F0
	[HelpURL] // 0x0000000180171590-0x00000001801715F0
	public class RotationLimitPolygonal : RotationLimit // TypeDefIndex: 9447
	{
		// Fields
		[Range] // 0x00000001800D6F30-0x00000001800D6F50
		public float twistLimit; // 0x38
		[Range] // 0x000000018010C4B0-0x000000018010C4D0
		public int smoothIterations; // 0x3C
		[HideInInspector] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		public LimitPoint[] points; // 0x40
		[HideInInspector] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		public Vector3[] P; // 0x48
		[HideInInspector] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		public ReachCone[] reachCones; // 0x50
	
		// Nested types
		[Serializable]
		public class ReachCone // TypeDefIndex: 9448
		{
			// Fields
			public Vector3[] tetrahedron; // 0x10
			public float volume; // 0x18
			public Vector3 S; // 0x1C
			public Vector3 B; // 0x28
	
			// Properties
			public Vector3 o { get; } // 0x00000001822846B0-0x0000000182284700 
			public Vector3 a { get; } // 0x00000001822845B0-0x0000000182284600 
			public Vector3 b { get; } // 0x0000000182284600-0x0000000182284650 
			public Vector3 c { get; } // 0x0000000182284650-0x00000001822846A0 
			public bool isValid { get; } // 0x00000001822846A0-0x00000001822846B0 
	
			// Constructors
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c); // 0x00000001822843E0-0x00000001822845B0
	
			// Methods
			public void Calculate(); // 0x00000001822840C0-0x00000001822843E0
		}
	
		[Serializable]
		public class LimitPoint // TypeDefIndex: 9449
		{
			// Fields
			public Vector3 point; // 0x10
			public float tangentWeight; // 0x1C
	
			// Constructors
			public LimitPoint(); // 0x0000000182283020-0x00000001822830A0
		}
	
		// Constructors
		public RotationLimitPolygonal(); // 0x0000000182288E00-0x0000000182288E50
	
		// Methods
		[ContextMenu] // 0x0000000180119E00-0x0000000180119E30
		private void OpenUserManual(); // 0x00000001822875F0-0x0000000182287630
		[ContextMenu] // 0x000000018011A010-0x000000018011A040
		private void OpenScriptReference(); // 0x00000001822875B0-0x00000001822875F0
		[ContextMenu] // 0x000000018011E390-0x000000018011E3C0
		private void SupportGroup(); // 0x0000000182288BC0-0x0000000182288C00
		[ContextMenu] // 0x000000018011E5A0-0x000000018011E5D0
		private void ASThread(); // 0x0000000182286740-0x0000000182286780
		public void SetLimitPoints(LimitPoint[] points); // 0x0000000182287D10-0x0000000182287D80
		protected override Quaternion LimitRotation(Quaternion rotation); // 0x00000001822870E0-0x00000001822871F0
		private void Start(); // 0x0000000182288820-0x0000000182288BC0
		public void ResetToDefault(); // 0x00000001822877C0-0x0000000182287D10
		public void BuildReachCones(); // 0x0000000182286780-0x0000000182286DD0
		private Vector3[] SmoothPoints(); // 0x0000000182287D80-0x0000000182288820
		private float GetScalar(int k); // 0x0000000182287090-0x00000001822870E0
		private Vector3 PointToTangentPlane(Vector3 p, float r); // 0x0000000182287630-0x00000001822877C0
		private Vector3 TangentPointToSphere(Vector3 q, float r); // 0x0000000182288C00-0x0000000182288E00
		private Quaternion LimitSwing(Quaternion rotation); // 0x00000001822871F0-0x00000001822875B0
		private int GetReachCone(Vector3 L); // 0x0000000182286DD0-0x0000000182287090
	}
}
