/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7418-7580

namespace Cinemachine
{
	[AddComponentMenu] // 0x00000001801CF4E0-0x00000001801CF550
	[DocumentationSorting] // 0x00000001801CF4E0-0x00000001801CF550
	[ExecuteAlways] // 0x00000001801CF4E0-0x00000001801CF550
	[SaveDuringPlay] // 0x00000001801CF4E0-0x00000001801CF550
	public class CinemachineTargetGroup : UnityEngine.MonoBehaviour // TypeDefIndex: 7465
	{
		// Fields
		[Tooltip] // 0x00000001801CF850-0x00000001801CF880
		public PositionMode m_PositionMode; // 0x18
		[Tooltip] // 0x00000001801CF950-0x00000001801CF980
		public RotationMode m_RotationMode; // 0x1C
		[Tooltip] // 0x00000001801CFD20-0x00000001801CFD50
		public UpdateMethod m_UpdateMethod; // 0x20
		[NoSaveDuringPlay] // 0x00000001801CFE10-0x00000001801CFE60
		[Tooltip] // 0x00000001801CFE10-0x00000001801CFE60
		public Target[] m_Targets; // 0x28
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Bounds <BoundingBox>k__BackingField; // 0x30
		private float mMaxWeight; // 0x48
		private Vector3 mAveragePos; // 0x4C
	
		// Properties
		public Bounds BoundingBox { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000181398A80-0x0000000181398AA0 0x0000000181398D70-0x0000000181398D90
		public BoundingSphere Sphere { get; } // 0x0000000181398BE0-0x0000000181398D70 
		public bool IsEmpty { get; } // 0x0000000181398AA0-0x0000000181398BE0 
	
		// Nested types
		[Serializable]
		[DocumentationSorting] // 0x00000001801D04D0-0x00000001801D04F0
		public struct Target // TypeDefIndex: 7466
		{
			// Fields
			[Tooltip] // 0x00000001801D0560-0x00000001801D0590
			public Transform target; // 0x00
			[Tooltip] // 0x00000001801D07B0-0x00000001801D07E0
			public float weight; // 0x08
			[Tooltip] // 0x00000001801D08A0-0x00000001801D08D0
			public float radius; // 0x0C
		}
	
		[DocumentationSorting] // 0x00000001801D04D0-0x00000001801D04F0
		public enum PositionMode // TypeDefIndex: 7467
		{
			GroupCenter = 0,
			GroupAverage = 1
		}
	
		[DocumentationSorting] // 0x00000001801D04D0-0x00000001801D04F0
		public enum RotationMode // TypeDefIndex: 7468
		{
			Manual = 0,
			GroupAverage = 1
		}
	
		public enum UpdateMethod // TypeDefIndex: 7469
		{
			Update = 0,
			FixedUpdate = 1,
			LateUpdate = 2
		}
	
		// Constructors
		public CinemachineTargetGroup(); // 0x0000000181398A30-0x0000000181398A80
	
		// Methods
		public void AddMember(Transform t, float weight, float radius); // 0x0000000181396D10-0x0000000181396E50
		public void RemoveMember(Transform t); // 0x00000001813986D0-0x0000000181398830
		public int FindMember(Transform t); // 0x0000000181397AB0-0x0000000181397B80
		public BoundingSphere GetWeightedBoundsForMember(int index); // 0x0000000181398490-0x0000000181398550
		public Bounds GetViewSpaceBoundingBox(Matrix4x4 observer); // 0x00000001813981F0-0x0000000181398490
		private static BoundingSphere WeightedMemberBounds(Target t, Vector3 avgPos, float maxWeight); // 0x0000000181398860-0x0000000181398A30
		private void DoUpdate(); // 0x00000001813977F0-0x0000000181397AB0
		private Vector3 CalculateAveragePosition(out float maxWeight); // 0x00000001813970D0-0x00000001813974D0
		private Quaternion CalculateAverageOrientation(); // 0x0000000181396E50-0x00000001813970D0
		private Bounds CalculateBoundingBox(Vector3 avgPos, float maxWeight); // 0x00000001813974D0-0x00000001813977F0
		private void OnValidate(); // 0x0000000181398560-0x00000001813986D0
		private void FixedUpdate(); // 0x0000000181397B80-0x0000000181397B90
		private void Update(); // 0x0000000181398830-0x0000000181398860
		private void LateUpdate(); // 0x0000000181398550-0x0000000181398560
		public void GetViewSpaceAngularBounds(Matrix4x4 observer, out Vector2 minAngles, out Vector2 maxAngles, out Vector2 zRange); // 0x0000000181397B90-0x00000001813981F0
	}
}
