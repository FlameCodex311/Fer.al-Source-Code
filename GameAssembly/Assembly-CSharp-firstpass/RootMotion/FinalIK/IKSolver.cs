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
	public abstract class IKSolver // TypeDefIndex: 9915
	{
		// Fields
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public Vector3 IKPosition; // 0x10
		[Range] // 0x0000000180246B30-0x0000000180246B90
		[Tooltip] // 0x0000000180246B30-0x0000000180246B90
		public float IKPositionWeight; // 0x1C
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <initiated>k__BackingField; // 0x20
		public UpdateDelegate OnPreInitiate; // 0x28
		public UpdateDelegate OnPostInitiate; // 0x30
		public UpdateDelegate OnPreUpdate; // 0x38
		public UpdateDelegate OnPostUpdate; // 0x40
		protected bool firstInitiation; // 0x48
		[HideInInspector] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		protected Transform root; // 0x50
	
		// Properties
		public bool initiated { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803FA090-0x00000001803FA0A0 0x00000001803FA0B0-0x00000001803FA0C0
	
		// Nested types
		[Serializable]
		public class Point // TypeDefIndex: 9916
		{
			// Fields
			public Transform transform; // 0x10
			[Range] // 0x00000001801D3630-0x00000001801D3650
			public float weight; // 0x18
			public Vector3 solverPosition; // 0x1C
			public Quaternion solverRotation; // 0x28
			public Vector3 defaultLocalPosition; // 0x38
			public Quaternion defaultLocalRotation; // 0x44
	
			// Constructors
			public Point(); // 0x00000001819F8F20-0x00000001819F8F90
	
			// Methods
			public void StoreDefaultLocalState(); // 0x00000001819F9950-0x00000001819F99B0
			public void FixTransform(); // 0x00000001819F97C0-0x00000001819F9950
			public void UpdateSolverPosition(); // 0x00000001819F9A50-0x00000001819F9A90
			public void UpdateSolverLocalPosition(); // 0x00000001819F99B0-0x00000001819F99F0
			public void UpdateSolverState(); // 0x00000001819F9A90-0x00000001819F9AF0
			public void UpdateSolverLocalState(); // 0x00000001819F99F0-0x00000001819F9A50
		}
	
		[Serializable]
		public class Bone : Point // TypeDefIndex: 9917
		{
			// Fields
			public float length; // 0x58
			public float sqrMag; // 0x5C
			public Vector3 axis; // 0x60
			private RotationLimit _rotationLimit; // 0x70
			private bool isLimited; // 0x78
	
			// Properties
			public RotationLimit rotationLimit { get; set; } // 0x00000001819DA060-0x00000001819DA130 0x00000001819DA130-0x00000001819DA1A0
	
			// Constructors
			public Bone(); // 0x00000001819D9F70-0x00000001819DA060
			public Bone(Transform transform); // 0x00000001819D9E70-0x00000001819D9F70
			public Bone(Transform transform, float weight); // 0x00000001819D9D60-0x00000001819D9E70
	
			// Methods
			public void Swing(Vector3 swingTarget, float weight = 1f /* Metadata: 0x0077ABE5 */); // 0x00000001819D9A60-0x00000001819D9D60
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f /* Metadata: 0x0077ABE9 */); // 0x00000001819D9420-0x00000001819D97E0
			public void Swing2D(Vector3 swingTarget, float weight = 1f /* Metadata: 0x0077ABED */); // 0x00000001819D97E0-0x00000001819D9A60
			public void SetToSolverPosition(); // 0x00000001819D93E0-0x00000001819D9420
		}
	
		[Serializable]
		public class Node : Point // TypeDefIndex: 9918
		{
			// Fields
			public float length; // 0x58
			public float effectorPositionWeight; // 0x5C
			public float effectorRotationWeight; // 0x60
			public Vector3 offset; // 0x64
	
			// Constructors
			public Node(); // 0x00000001819F8F20-0x00000001819F8F90
			public Node(Transform transform); // 0x00000001819F8EA0-0x00000001819F8F20
			public Node(Transform transform, float weight); // 0x00000001819F8F90-0x00000001819F9020
		}
	
		public delegate void UpdateDelegate(); // TypeDefIndex: 9919; 0x0000000181437090-0x0000000181437300
	
		public delegate void IterationDelegate(int i); // TypeDefIndex: 9920; 0x00000001819F6010-0x00000001819F62E0
	
		// Constructors
		protected IKSolver(); // 0x00000001819F5D80-0x00000001819F5DA0
	
		// Methods
		public bool IsValid(); // 0x00000001819F54F0-0x00000001819F5560
		public abstract bool IsValid(ref string message);
		public void Initiate(Transform root); // 0x00000001819F53B0-0x00000001819F54F0
		public void Update(); // 0x00000001819F5D10-0x00000001819F5D80
		public virtual Vector3 GetIKPosition(); // 0x0000000180CB5720-0x0000000180CB5740
		public void SetIKPosition(Vector3 position); // 0x00000001819F5D00-0x00000001819F5D10
		public float GetIKPositionWeight(); // 0x0000000180918C20-0x0000000180918C30
		public void SetIKPositionWeight(float weight); // 0x00000001819F5C90-0x00000001819F5D00
		public Transform GetRoot(); // 0x0000000180378320-0x0000000180378330
		public abstract Point[] GetPoints();
		public abstract Point GetPoint(Transform transform);
		public abstract void FixTransforms();
		public abstract void StoreDefaultLocalState();
		protected abstract void OnInitiate();
		protected abstract void OnUpdate();
		protected void LogWarning(string message); // 0x00000001819F5560-0x00000001819F5580
		public static Transform ContainsDuplicateBone(Bone[] bones); // 0x00000001819F51A0-0x00000001819F52F0
		public static bool HierarchyIsValid(Bone[] bones); // 0x00000001819F52F0-0x00000001819F53B0
		protected static float PreSolveBones(ref Bone[] bones); // 0x00000001819F5580-0x00000001819F5C90
	}
}
