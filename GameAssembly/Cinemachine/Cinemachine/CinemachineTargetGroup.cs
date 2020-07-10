/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7252-7414

namespace Cinemachine
{
	[AddComponentMenu] // 0x0000000180131260-0x00000001801312D0
	[DocumentationSorting] // 0x0000000180131260-0x00000001801312D0
	[ExecuteAlways] // 0x0000000180131260-0x00000001801312D0
	[SaveDuringPlay] // 0x0000000180131260-0x00000001801312D0
	public class CinemachineTargetGroup : UnityEngine.MonoBehaviour // TypeDefIndex: 7299
	{
		// Fields
		[Tooltip] // 0x00000001801315F0-0x0000000180131620
		public PositionMode m_PositionMode; // 0x18
		[Tooltip] // 0x0000000180131830-0x0000000180131860
		public RotationMode m_RotationMode; // 0x1C
		[Tooltip] // 0x00000001801318C0-0x00000001801318F0
		public UpdateMethod m_UpdateMethod; // 0x20
		[NoSaveDuringPlay] // 0x0000000180131AD0-0x0000000180131B20
		[Tooltip] // 0x0000000180131AD0-0x0000000180131B20
		public Target[] m_Targets; // 0x28
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Bounds <BoundingBox>k__BackingField; // 0x30
		private float mMaxWeight; // 0x48
		private Vector3 mAveragePos; // 0x4C
	
		// Properties
		public Bounds BoundingBox { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001817DE520-0x00000001817DE540 0x00000001817DE810-0x00000001817DE830
		public BoundingSphere Sphere { get; } // 0x00000001817DE680-0x00000001817DE810 
		public bool IsEmpty { get; } // 0x00000001817DE540-0x00000001817DE680 
	
		// Nested types
		[Serializable]
		[DocumentationSorting] // 0x00000001800B83F0-0x00000001800B8410
		public struct Target // TypeDefIndex: 7300
		{
			// Fields
			[Tooltip] // 0x0000000180132390-0x00000001801323C0
			public Transform target; // 0x00
			[Tooltip] // 0x0000000180132660-0x0000000180132690
			public float weight; // 0x08
			[Tooltip] // 0x0000000180132840-0x0000000180132870
			public float radius; // 0x0C
		}
	
		[DocumentationSorting] // 0x00000001800B83F0-0x00000001800B8410
		public enum PositionMode // TypeDefIndex: 7301
		{
			GroupCenter = 0,
			GroupAverage = 1
		}
	
		[DocumentationSorting] // 0x00000001800B83F0-0x00000001800B8410
		public enum RotationMode // TypeDefIndex: 7302
		{
			Manual = 0,
			GroupAverage = 1
		}
	
		public enum UpdateMethod // TypeDefIndex: 7303
		{
			Update = 0,
			FixedUpdate = 1,
			LateUpdate = 2
		}
	
		// Constructors
		public CinemachineTargetGroup(); // 0x00000001817DE4D0-0x00000001817DE520
	
		// Methods
		public void AddMember(Transform t, float weight, float radius); // 0x00000001817DC730-0x00000001817DC880
		public void RemoveMember(Transform t); // 0x00000001817DE160-0x00000001817DE2D0
		public int FindMember(Transform t); // 0x00000001817DD510-0x00000001817DD5E0
		public BoundingSphere GetWeightedBoundsForMember(int index); // 0x00000001817DDEF0-0x00000001817DDFC0
		public Bounds GetViewSpaceBoundingBox(Matrix4x4 observer); // 0x00000001817DDC50-0x00000001817DDEF0
		private static BoundingSphere WeightedMemberBounds(Target t, Vector3 avgPos, float maxWeight); // 0x00000001817DE300-0x00000001817DE4D0
		private void DoUpdate(); // 0x00000001817DD240-0x00000001817DD510
		private Vector3 CalculateAveragePosition(out float maxWeight); // 0x00000001817DCB10-0x00000001817DCF20
		private Quaternion CalculateAverageOrientation(); // 0x00000001817DC880-0x00000001817DCB10
		private Bounds CalculateBoundingBox(Vector3 avgPos, float maxWeight); // 0x00000001817DCF20-0x00000001817DD240
		private void OnValidate(); // 0x00000001817DDFD0-0x00000001817DE160
		private void FixedUpdate(); // 0x00000001817DD5E0-0x00000001817DD5F0
		private void Update(); // 0x00000001817DE2D0-0x00000001817DE300
		private void LateUpdate(); // 0x00000001817DDFC0-0x00000001817DDFD0
		public void GetViewSpaceAngularBounds(Matrix4x4 observer, out Vector2 minAngles, out Vector2 maxAngles, out Vector2 zRange); // 0x00000001817DD5F0-0x00000001817DDC50
	}
}
