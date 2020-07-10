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
	public class Grounding // TypeDefIndex: 9348
	{
		// Fields
		[Tooltip] // 0x0000000180129830-0x0000000180129860
		public LayerMask layers; // 0x10
		[Tooltip] // 0x0000000180129990-0x00000001801299C0
		public float maxStep; // 0x14
		[Tooltip] // 0x0000000180129B10-0x0000000180129B40
		public float heightOffset; // 0x18
		[Tooltip] // 0x0000000180129BA0-0x0000000180129BD0
		public float footSpeed; // 0x1C
		[Tooltip] // 0x0000000180129CB0-0x0000000180129CE0
		public float footRadius; // 0x20
		[HideInInspector] // 0x0000000180129D70-0x0000000180129DC0
		[Tooltip] // 0x0000000180129D70-0x0000000180129DC0
		public float footCenterOffset; // 0x24
		[Tooltip] // 0x0000000180129F20-0x0000000180129F50
		public float prediction; // 0x28
		[Range] // 0x000000018012A140-0x000000018012A1A0
		[Tooltip] // 0x000000018012A140-0x000000018012A1A0
		public float footRotationWeight; // 0x2C
		[Tooltip] // 0x000000018012A3C0-0x000000018012A3F0
		public float footRotationSpeed; // 0x30
		[Range] // 0x000000018012A680-0x000000018012A6E0
		[Tooltip] // 0x000000018012A680-0x000000018012A6E0
		public float maxFootRotationAngle; // 0x34
		[Tooltip] // 0x000000018012A880-0x000000018012A8B0
		public bool rotateSolver; // 0x38
		[Tooltip] // 0x000000018012AB40-0x000000018012AB70
		public float pelvisSpeed; // 0x3C
		[Range] // 0x000000018012BFF0-0x000000018012C050
		[Tooltip] // 0x000000018012BFF0-0x000000018012C050
		public float pelvisDamper; // 0x40
		[Tooltip] // 0x000000018012C420-0x000000018012C450
		public float lowerPelvisWeight; // 0x44
		[Tooltip] // 0x000000018012C5C0-0x000000018012C5F0
		public float liftPelvisWeight; // 0x48
		[Tooltip] // 0x000000018012C8F0-0x000000018012C920
		public float rootSphereCastRadius; // 0x4C
		[Tooltip] // 0x000000018012CA20-0x000000018012CA50
		public bool overstepFallsDown; // 0x50
		[Tooltip] // 0x000000018012CC50-0x000000018012CC80
		public Quality quality; // 0x54
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Leg[] <legs>k__BackingField; // 0x58
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Pelvis <pelvis>k__BackingField; // 0x60
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <isGrounded>k__BackingField; // 0x68
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Transform <root>k__BackingField; // 0x70
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private RaycastHit <rootHit>k__BackingField; // 0x78
		private bool initiated; // 0xA4
	
		// Properties
		public Leg[] legs { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180357120-0x0000000180357130 0x0000000180485C70-0x0000000180485C80
		public Pelvis pelvis { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180369B40-0x0000000180369B50 0x00000001803A27E0-0x00000001803A27F0
		public bool isGrounded { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180622650-0x0000000180622660 0x00000001804638B0-0x00000001804638C0
		public Transform root { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180369B50-0x0000000180369B60 0x00000001803C87F0-0x00000001803C8800
		public RaycastHit rootHit { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000181C222A0-0x0000000181C222D0 0x0000000181C22440-0x0000000181C22470
		public bool rootGrounded { get; } // 0x0000000181C22240-0x0000000181C222A0 
		public Vector3 up { get; } // 0x0000000181C222D0-0x0000000181C22370 
		private bool useRootRotation { get; } // 0x0000000181C22370-0x0000000181C22440 
	
		// Nested types
		[Serializable]
		public enum Quality // TypeDefIndex: 9349
		{
			Fastest = 0,
			Simple = 1,
			Best = 2
		}
	
		public class Leg // TypeDefIndex: 9350
		{
			// Fields
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private bool <isGrounded>k__BackingField; // 0x10
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private Vector3 <IKPosition>k__BackingField; // 0x14
			public Quaternion rotationOffset; // 0x20
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private bool <initiated>k__BackingField; // 0x30
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private float <heightFromGround>k__BackingField; // 0x34
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private Vector3 <velocity>k__BackingField; // 0x38
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private Transform <transform>k__BackingField; // 0x48
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private float <IKOffset>k__BackingField; // 0x50
			public bool invertFootCenter; // 0x54
			private Grounding grounding; // 0x58
			private float lastTime; // 0x60
			private float deltaTime; // 0x64
			private Vector3 lastPosition; // 0x68
			private Quaternion toHitNormal; // 0x74
			private Quaternion r; // 0x84
			private RaycastHit heelHit; // 0x94
			private Vector3 up; // 0xC0
	
			// Properties
			public bool isGrounded { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180375540-0x0000000180375550 0x00000001803930B0-0x00000001803930C0
			public Vector3 IKPosition { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000181210D80-0x0000000181210DA0 0x0000000181C345F0-0x0000000181C34600
			public bool initiated { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018048B840-0x000000018048B850 0x000000018048B850-0x000000018048B860
			public float heightFromGround { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001804C16A0-0x00000001804C16B0 0x000000018183B5A0-0x000000018183B5B0
			public Vector3 velocity { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001811F74A0-0x00000001811F74C0 0x0000000181C23C10-0x0000000181C23C20
			public Transform transform { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180369C40-0x0000000180369C50 0x00000001803A27F0-0x00000001803A2800
			public float IKOffset { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180487D20-0x0000000180487D30 0x0000000180DD2D90-0x0000000180DD2DA0
			public float stepHeightFromGround { get; } // 0x0000000181C34540-0x0000000181C345F0 
			private float rootYOffset { get; } // 0x0000000181C34350-0x0000000181C34540 
	
			// Constructors
			public Leg(); // 0x0000000181C342A0-0x0000000181C34350
	
			// Methods
			public void Initiate(Grounding grounding, Transform transform); // 0x0000000181C32860-0x0000000181C32990
			public void OnEnable(); // 0x0000000181C32990-0x0000000181C329E0
			public void Reset(); // 0x0000000181C33A60-0x0000000181C33B30
			public void Process(); // 0x0000000181C329E0-0x0000000181C33A60
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel); // 0x0000000181C319C0-0x0000000181C32030
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel); // 0x0000000181C32290-0x0000000181C32720
			private Vector3 RotateNormal(Vector3 normal); // 0x0000000181C33D30-0x0000000181C33E90
			private void SetFootToPoint(Vector3 normal, Vector3 point); // 0x0000000181C34180-0x0000000181C342A0
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint); // 0x0000000181C33E90-0x0000000181C34180
			private float GetHeightFromGround(Vector3 hitPoint); // 0x0000000181C32030-0x0000000181C32290
			private void RotateFoot(); // 0x0000000181C33B30-0x0000000181C33D30
			private Quaternion GetRotationOffsetTarget(); // 0x0000000181C32720-0x0000000181C32860
		}
	
		public class Pelvis // TypeDefIndex: 9351
		{
			// Fields
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private Vector3 <IKOffset>k__BackingField; // 0x10
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private float <heightOffset>k__BackingField; // 0x1C
			private Grounding grounding; // 0x20
			private Vector3 lastRootPosition; // 0x28
			private float damperF; // 0x34
			private bool initiated; // 0x38
			private float lastTime; // 0x3C
	
			// Properties
			public Vector3 IKOffset { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180C49CA0-0x0000000180C49CC0 0x0000000181C316B0-0x0000000181C316C0
			public float heightOffset { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001805D9070-0x00000001805D9080 0x00000001805D90A0-0x00000001805D90B0
	
			// Constructors
			public Pelvis(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			public void Initiate(Grounding grounding); // 0x0000000181C34D40-0x0000000181C34DC0
			public void Reset(); // 0x0000000181C351A0-0x0000000181C35280
			public void OnEnable(); // 0x0000000181C34DC0-0x0000000181C34E40
			public void Process(float lowestOffset, float highestOffset, bool isGrounded); // 0x0000000181C34E40-0x0000000181C351A0
		}
	
		// Constructors
		public Grounding(); // 0x0000000181C221E0-0x0000000181C22240
	
		// Methods
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f /* Metadata: 0x0074509F */); // 0x0000000181C21000-0x0000000181C215B0
		public bool IsValid(ref string errorMessage); // 0x0000000181C21C20-0x0000000181C21CF0
		public void Initiate(Transform root, Transform[] feet); // 0x0000000181C21710-0x0000000181C21C20
		public void Update(); // 0x0000000181C21F40-0x0000000181C221E0
		public Vector3 GetLegsPlaneNormal(); // 0x0000000181C20C90-0x0000000181C21000
		public void Reset(); // 0x0000000181C21D10-0x0000000181C21F40
		public void LogWarning(string message); // 0x0000000181C21CF0-0x0000000181C21D10
		public float GetVerticalOffset(Vector3 p1, Vector3 p2); // 0x0000000181C215B0-0x0000000181C21710
		public Vector3 Flatten(Vector3 v); // 0x0000000181C209F0-0x0000000181C20B30
		public Vector3 GetFootCenterOffset(); // 0x0000000181C20B30-0x0000000181C20C90
	}
}
