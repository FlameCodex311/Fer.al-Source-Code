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
	[Serializable]
	public abstract class IKSolver // TypeDefIndex: 9381
	{
		// Fields
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public Vector3 IKPosition; // 0x10
		[Range] // 0x0000000180140F20-0x0000000180140F80
		[Tooltip] // 0x0000000180140F20-0x0000000180140F80
		public float IKPositionWeight; // 0x1C
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <initiated>k__BackingField; // 0x20
		public UpdateDelegate OnPreInitiate; // 0x28
		public UpdateDelegate OnPostInitiate; // 0x30
		public UpdateDelegate OnPreUpdate; // 0x38
		public UpdateDelegate OnPostUpdate; // 0x40
		protected bool firstInitiation; // 0x48
		[HideInInspector] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		protected Transform root; // 0x50
	
		// Properties
		public bool initiated { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803C19E0-0x00000001803C19F0 0x00000001804231D0-0x00000001804231E0
	
		// Nested types
		[Serializable]
		public class Point // TypeDefIndex: 9382
		{
			// Fields
			public Transform transform; // 0x10
			[Range] // 0x00000001800C20E0-0x00000001800C2100
			public float weight; // 0x18
			public Vector3 solverPosition; // 0x1C
			public Quaternion solverRotation; // 0x28
			public Vector3 defaultLocalPosition; // 0x38
			public Quaternion defaultLocalRotation; // 0x44
	
			// Constructors
			public Point(); // 0x0000000181C349A0-0x0000000181C34A10
	
			// Methods
			public void StoreDefaultLocalState(); // 0x0000000181C35410-0x0000000181C35480
			public void FixTransform(); // 0x0000000181C35280-0x0000000181C35410
			public void UpdateSolverPosition(); // 0x0000000181C35530-0x0000000181C35570
			public void UpdateSolverLocalPosition(); // 0x0000000181C35480-0x0000000181C354C0
			public void UpdateSolverState(); // 0x0000000181C35570-0x0000000181C355E0
			public void UpdateSolverLocalState(); // 0x0000000181C354C0-0x0000000181C35530
		}
	
		[Serializable]
		public class Bone : Point // TypeDefIndex: 9383
		{
			// Fields
			public float length; // 0x58
			public float sqrMag; // 0x5C
			public Vector3 axis; // 0x60
			private RotationLimit _rotationLimit; // 0x70
			private bool isLimited; // 0x78
	
			// Properties
			public RotationLimit rotationLimit { get; set; } // 0x0000000181C13CC0-0x0000000181C13D90 0x0000000181C13D90-0x0000000181C13E00
	
			// Constructors
			public Bone(); // 0x0000000181C13BD0-0x0000000181C13CC0
			public Bone(Transform transform); // 0x0000000181C13AD0-0x0000000181C13BD0
			public Bone(Transform transform, float weight); // 0x0000000181C139C0-0x0000000181C13AD0
	
			// Methods
			public void Swing(Vector3 swingTarget, float weight = 1f /* Metadata: 0x007450D8 */); // 0x0000000181C136B0-0x0000000181C139C0
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f /* Metadata: 0x007450DC */); // 0x0000000181C13050-0x0000000181C13420
			public void Swing2D(Vector3 swingTarget, float weight = 1f /* Metadata: 0x007450E0 */); // 0x0000000181C13420-0x0000000181C136B0
			public void SetToSolverPosition(); // 0x0000000181C13010-0x0000000181C13050
		}
	
		[Serializable]
		public class Node : Point // TypeDefIndex: 9384
		{
			// Fields
			public float length; // 0x58
			public float effectorPositionWeight; // 0x5C
			public float effectorRotationWeight; // 0x60
			public Vector3 offset; // 0x64
	
			// Constructors
			public Node(); // 0x0000000181C349A0-0x0000000181C34A10
			public Node(Transform transform); // 0x0000000181C34920-0x0000000181C349A0
			public Node(Transform transform, float weight); // 0x0000000181C34A10-0x0000000181C34AA0
		}
	
		public delegate void UpdateDelegate(); // TypeDefIndex: 9385; 0x00000001804C7D50-0x00000001804C7EF0
	
		public delegate void IterationDelegate(int i); // TypeDefIndex: 9386; 0x0000000180D0FFB0-0x0000000180D10240
	
		// Constructors
		protected IKSolver(); // 0x0000000181C31730-0x0000000181C31750
	
		// Methods
		public bool IsValid(); // 0x0000000181C30E40-0x0000000181C30EB0
		public abstract bool IsValid(ref string message);
		public void Initiate(Transform root); // 0x0000000181C30D00-0x0000000181C30E40
		public void Update(); // 0x0000000181C316C0-0x0000000181C31730
		public virtual Vector3 GetIKPosition(); // 0x0000000180C49CA0-0x0000000180C49CC0
		public void SetIKPosition(Vector3 position); // 0x0000000181C316B0-0x0000000181C316C0
		public float GetIKPositionWeight(); // 0x00000001805D9070-0x00000001805D9080
		public void SetIKPositionWeight(float weight); // 0x0000000181C31640-0x0000000181C316B0
		public Transform GetRoot(); // 0x00000001803A27A0-0x00000001803A27B0
		public abstract Point[] GetPoints();
		public abstract Point GetPoint(Transform transform);
		public abstract void FixTransforms();
		public abstract void StoreDefaultLocalState();
		protected abstract void OnInitiate();
		protected abstract void OnUpdate();
		protected void LogWarning(string message); // 0x0000000181C30EB0-0x0000000181C30ED0
		public static Transform ContainsDuplicateBone(Bone[] bones); // 0x0000000181C30AE0-0x0000000181C30C40
		public static bool HierarchyIsValid(Bone[] bones); // 0x0000000181C30C40-0x0000000181C30D00
		protected static float PreSolveBones(ref Bone[] bones); // 0x0000000181C30ED0-0x0000000181C31640
	}
}
