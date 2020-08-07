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
	public class Grounding // TypeDefIndex: 9882
	{
		// Fields
		[Tooltip] // 0x000000018022E730-0x000000018022E760
		public LayerMask layers; // 0x10
		[Tooltip] // 0x000000018022E980-0x000000018022E9B0
		public float maxStep; // 0x14
		[Tooltip] // 0x000000018022EB30-0x000000018022EB60
		public float heightOffset; // 0x18
		[Tooltip] // 0x000000018022EDB0-0x000000018022EDE0
		public float footSpeed; // 0x1C
		[Tooltip] // 0x000000018022EF90-0x000000018022EFC0
		public float footRadius; // 0x20
		[HideInInspector] // 0x000000018022F440-0x000000018022F490
		[Tooltip] // 0x000000018022F440-0x000000018022F490
		public float footCenterOffset; // 0x24
		[Tooltip] // 0x000000018022F630-0x000000018022F660
		public float prediction; // 0x28
		[Range] // 0x000000018022F840-0x000000018022F8A0
		[Tooltip] // 0x000000018022F840-0x000000018022F8A0
		public float footRotationWeight; // 0x2C
		[Tooltip] // 0x000000018022FAB0-0x000000018022FAE0
		public float footRotationSpeed; // 0x30
		[Range] // 0x000000018022FBE0-0x000000018022FC40
		[Tooltip] // 0x000000018022FBE0-0x000000018022FC40
		public float maxFootRotationAngle; // 0x34
		[Tooltip] // 0x000000018022FE40-0x000000018022FE70
		public bool rotateSolver; // 0x38
		[Tooltip] // 0x00000001802300D0-0x0000000180230100
		public float pelvisSpeed; // 0x3C
		[Range] // 0x0000000180230560-0x00000001802305C0
		[Tooltip] // 0x0000000180230560-0x00000001802305C0
		public float pelvisDamper; // 0x40
		[Tooltip] // 0x0000000180230810-0x0000000180230840
		public float lowerPelvisWeight; // 0x44
		[Tooltip] // 0x0000000180230AA0-0x0000000180230AD0
		public float liftPelvisWeight; // 0x48
		[Tooltip] // 0x0000000180230C80-0x0000000180230CB0
		public float rootSphereCastRadius; // 0x4C
		[Tooltip] // 0x0000000180231080-0x00000001802310B0
		public bool overstepFallsDown; // 0x50
		[Tooltip] // 0x00000001802312F0-0x0000000180231320
		public Quality quality; // 0x54
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Leg[] <legs>k__BackingField; // 0x58
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Pelvis <pelvis>k__BackingField; // 0x60
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <isGrounded>k__BackingField; // 0x68
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Transform <root>k__BackingField; // 0x70
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private RaycastHit <rootHit>k__BackingField; // 0x78
		private bool initiated; // 0xA4
	
		// Properties
		public Leg[] legs { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803A1580-0x00000001803A1590 0x00000001803A1740-0x00000001803A1750
		public Pelvis pelvis { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180418970-0x0000000180418980 0x00000001804AF510-0x00000001804AF520
		public bool isGrounded { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x000000018037D390-0x000000018037D3A0 0x000000018039EC50-0x000000018039EC60
		public Transform root { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180418980-0x0000000180418990 0x00000001804C61A0-0x00000001804C61B0
		public RaycastHit rootHit { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001819DCC10-0x00000001819DCC40 0x00000001819DCDB0-0x00000001819DCDE0
		public bool rootGrounded { get; } // 0x00000001819DCBB0-0x00000001819DCC10 
		public Vector3 up { get; } // 0x00000001819DCC40-0x00000001819DCCE0 
		private bool useRootRotation { get; } // 0x00000001819DCCE0-0x00000001819DCDB0 
	
		// Nested types
		[Serializable]
		public enum Quality // TypeDefIndex: 9883
		{
			Fastest = 0,
			Simple = 1,
			Best = 2
		}
	
		public class Leg // TypeDefIndex: 9884
		{
			// Fields
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private bool <isGrounded>k__BackingField; // 0x10
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private Vector3 <IKPosition>k__BackingField; // 0x14
			public Quaternion rotationOffset; // 0x20
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private bool <initiated>k__BackingField; // 0x30
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private float <heightFromGround>k__BackingField; // 0x34
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private Vector3 <velocity>k__BackingField; // 0x38
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private Transform <transform>k__BackingField; // 0x48
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
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
			public bool isGrounded { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803FD450-0x00000001803FD460 0x00000001803FD630-0x00000001803FD640
			public Vector3 IKPosition { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180CBC920-0x0000000180CBC940 0x00000001819F8E90-0x00000001819F8EA0
			public bool initiated { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180455B90-0x0000000180455BA0 0x0000000180455C10-0x0000000180455C20
			public float heightFromGround { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001806CEAE0-0x00000001806CEAF0 0x000000018143E770-0x000000018143E780
			public Vector3 velocity { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x000000018094A680-0x000000018094A6A0 0x00000001819DE4E0-0x00000001819DE4F0
			public Transform transform { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803743E0-0x00000001803743F0 0x00000001804ADAE0-0x00000001804ADAF0
			public float IKOffset { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180791CE0-0x0000000180791CF0 0x00000001807E32A0-0x00000001807E32B0
			public float stepHeightFromGround { get; } // 0x00000001819F8DE0-0x00000001819F8E90 
			private float rootYOffset { get; } // 0x00000001819F8C00-0x00000001819F8DE0 
	
			// Constructors
			public Leg(); // 0x00000001819F8B50-0x00000001819F8C00
	
			// Methods
			public void Initiate(Grounding grounding, Transform transform); // 0x00000001819F7140-0x00000001819F7270
			public void OnEnable(); // 0x00000001819F7270-0x00000001819F72C0
			public void Reset(); // 0x00000001819F8310-0x00000001819F83E0
			public void Process(); // 0x00000001819F72C0-0x00000001819F8310
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel); // 0x00000001819F62E0-0x00000001819F6940
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel); // 0x00000001819F6B90-0x00000001819F7010
			private Vector3 RotateNormal(Vector3 normal); // 0x00000001819F85E0-0x00000001819F8740
			private void SetFootToPoint(Vector3 normal, Vector3 point); // 0x00000001819F8A30-0x00000001819F8B50
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint); // 0x00000001819F8740-0x00000001819F8A30
			private float GetHeightFromGround(Vector3 hitPoint); // 0x00000001819F6940-0x00000001819F6B90
			private void RotateFoot(); // 0x00000001819F83E0-0x00000001819F85E0
			private Quaternion GetRotationOffsetTarget(); // 0x00000001819F7010-0x00000001819F7140
		}
	
		public class Pelvis // TypeDefIndex: 9885
		{
			// Fields
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private Vector3 <IKOffset>k__BackingField; // 0x10
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private float <heightOffset>k__BackingField; // 0x1C
			private Grounding grounding; // 0x20
			private Vector3 lastRootPosition; // 0x28
			private float damperF; // 0x34
			private bool initiated; // 0x38
			private float lastTime; // 0x3C
	
			// Properties
			public Vector3 IKOffset { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180CB5720-0x0000000180CB5740 0x00000001819F5D00-0x00000001819F5D10
			public float heightOffset { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180918C20-0x0000000180918C30 0x0000000180918CF0-0x0000000180918D00
	
			// Constructors
			public Pelvis(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			public void Initiate(Grounding grounding); // 0x00000001819F92C0-0x00000001819F9330
			public void Reset(); // 0x00000001819F96F0-0x00000001819F97C0
			public void OnEnable(); // 0x00000001819F9330-0x00000001819F93A0
			public void Process(float lowestOffset, float highestOffset, bool isGrounded); // 0x00000001819F93A0-0x00000001819F96F0
		}
	
		// Constructors
		public Grounding(); // 0x00000001819DCB50-0x00000001819DCBB0
	
		// Methods
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f /* Metadata: 0x0077ABAC */); // 0x00000001819DB9B0-0x00000001819DBF50
		public bool IsValid(ref string errorMessage); // 0x00000001819DC5A0-0x00000001819DC670
		public void Initiate(Transform root, Transform[] feet); // 0x00000001819DC0B0-0x00000001819DC5A0
		public void Update(); // 0x00000001819DC8B0-0x00000001819DCB50
		public Vector3 GetLegsPlaneNormal(); // 0x00000001819DB650-0x00000001819DB9B0
		public void Reset(); // 0x00000001819DC690-0x00000001819DC8B0
		public void LogWarning(string message); // 0x00000001819DC670-0x00000001819DC690
		public float GetVerticalOffset(Vector3 p1, Vector3 p2); // 0x00000001819DBF50-0x00000001819DC0B0
		public Vector3 Flatten(Vector3 v); // 0x00000001819DB3B0-0x00000001819DB4F0
		public Vector3 GetFootCenterOffset(); // 0x00000001819DB4F0-0x00000001819DB650
	}
}
