/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion.FinalIK
{
	[Serializable]
	public class IKSolverVR : IKSolver // TypeDefIndex: 9405
	{
		// Fields
		private Transform[] solverTransforms; // 0x58
		private bool hasChest; // 0x60
		private bool hasNeck; // 0x61
		private bool hasShoulders; // 0x62
		private bool hasToes; // 0x63
		private bool hasLegs; // 0x64
		private Vector3[] readPositions; // 0x68
		private Quaternion[] readRotations; // 0x70
		private Vector3[] solvedPositions; // 0x78
		private Quaternion[] solvedRotations; // 0x80
		private Quaternion[] defaultLocalRotations; // 0x88
		private Vector3[] defaultLocalPositions; // 0x90
		private Vector3 rootV; // 0x98
		private Vector3 rootVelocity; // 0xA4
		private Vector3 bodyOffset; // 0xB0
		private int supportLegIndex; // 0xBC
		[Tooltip] // 0x0000000180146040-0x0000000180146070
		public bool plantFeet; // 0xC0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private VirtualBone <rootBone>k__BackingField; // 0xC8
		[Tooltip] // 0x0000000180146440-0x0000000180146470
		public Spine spine; // 0xD0
		[Tooltip] // 0x0000000180146590-0x00000001801465C0
		public Arm leftArm; // 0xD8
		[Tooltip] // 0x00000001801467B0-0x00000001801467E0
		public Arm rightArm; // 0xE0
		[Tooltip] // 0x0000000180146850-0x0000000180146880
		public Leg leftLeg; // 0xE8
		[Tooltip] // 0x00000001801469F0-0x0000000180146A20
		public Leg rightLeg; // 0xF0
		[Tooltip] // 0x0000000180146D40-0x0000000180146D70
		public Locomotion locomotion; // 0xF8
		private Leg[] legs; // 0x100
		private Arm[] arms; // 0x108
		private Vector3 headPosition; // 0x110
		private Vector3 headDeltaPosition; // 0x11C
		private Vector3 raycastOriginPelvis; // 0x128
		private Vector3 lastOffset; // 0x134
		private Vector3 debugPos1; // 0x140
		private Vector3 debugPos2; // 0x14C
		private Vector3 debugPos3; // 0x158
		private Vector3 debugPos4; // 0x164
	
		// Properties
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public VirtualBone rootBone { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001804A2590-0x00000001804A25A0 0x00000001804A22E0-0x00000001804A22F0
	
		// Nested types
		[Serializable]
		public class Arm : BodyPart // TypeDefIndex: 9406
		{
			// Fields
			[Tooltip] // 0x00000001801473E0-0x0000000180147410
			public Transform target; // 0x48
			[Tooltip] // 0x0000000180147580-0x00000001801475B0
			public Transform bendGoal; // 0x50
			[Range] // 0x00000001801477E0-0x0000000180147840
			[Tooltip] // 0x00000001801477E0-0x0000000180147840
			public float positionWeight; // 0x58
			[Range] // 0x0000000180147BD0-0x0000000180147C30
			[Tooltip] // 0x0000000180147BD0-0x0000000180147C30
			public float rotationWeight; // 0x5C
			[Tooltip] // 0x0000000180147E70-0x0000000180147EA0
			public ShoulderRotationMode shoulderRotationMode; // 0x60
			[Range] // 0x0000000180148030-0x0000000180148090
			[Tooltip] // 0x0000000180148030-0x0000000180148090
			public float shoulderRotationWeight; // 0x64
			[Range] // 0x0000000180148410-0x0000000180148470
			[Tooltip] // 0x0000000180148410-0x0000000180148470
			public float shoulderTwistWeight; // 0x68
			[Range] // 0x0000000180148740-0x00000001801487A0
			[Tooltip] // 0x0000000180148740-0x00000001801487A0
			public float bendGoalWeight; // 0x6C
			[Range] // 0x0000000180148B70-0x0000000180148BD0
			[Tooltip] // 0x0000000180148B70-0x0000000180148BD0
			public float swivelOffset; // 0x70
			[Tooltip] // 0x0000000180148D50-0x0000000180148D80
			public Vector3 wristToPalmAxis; // 0x74
			[Tooltip] // 0x0000000180149020-0x0000000180149050
			public Vector3 palmToThumbAxis; // 0x80
			[Range] // 0x0000000180149120-0x0000000180149180
			[Tooltip] // 0x0000000180149120-0x0000000180149180
			public float armLengthMlp; // 0x8C
			[Tooltip] // 0x0000000180149400-0x0000000180149430
			public AnimationCurve stretchCurve; // 0x90
			[NonSerialized]
			[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
			public Vector3 IKPosition; // 0x98
			[NonSerialized]
			[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
			public Quaternion IKRotation; // 0xA4
			[NonSerialized]
			[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
			public Vector3 bendDirection; // 0xB4
			[NonSerialized]
			[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
			public Vector3 handPositionOffset; // 0xC0
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private Vector3 <position>k__BackingField; // 0xCC
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private Quaternion <rotation>k__BackingField; // 0xD8
			private bool hasShoulder; // 0xE8
			private Vector3 chestForwardAxis; // 0xEC
			private Vector3 chestUpAxis; // 0xF8
			private Quaternion chestRotation; // 0x104
			private Vector3 chestForward; // 0x114
			private Vector3 chestUp; // 0x120
			private Quaternion forearmRelToUpperArm; // 0x12C
			private const float yawOffsetAngle = 45f; // Metadata: 0x0074514C
			private const float pitchOffsetAngle = -30f; // Metadata: 0x00745150
	
			// Properties
			public Vector3 position { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000181D61000-0x0000000181D61020 0x0000000181D61070-0x0000000181D61090
			public Quaternion rotation { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001813626A0-0x00000001813626B0 0x0000000181D61090-0x0000000181D610A0
			private VirtualBone shoulder { get; } // 0x0000000181B04B00-0x0000000181B04B40 
			private VirtualBone upperArm { get; } // 0x0000000181D61020-0x0000000181D61070 
			private VirtualBone forearm { get; } // 0x0000000181D60F60-0x0000000181D60FB0 
			private VirtualBone hand { get; } // 0x0000000181D60FB0-0x0000000181D61000 
	
			// Nested types
			[Serializable]
			public enum ShoulderRotationMode // TypeDefIndex: 9407
			{
				YawPitch = 0,
				FromTo = 1
			}
	
			// Constructors
			public Arm(); // 0x0000000181D60D90-0x0000000181D60F60
	
			// Methods
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index); // 0x0000000181D5CB20-0x0000000181D5D700
			public override void PreSolve(); // 0x0000000181D5D700-0x0000000181D5DAF0
			public override void ApplyOffsets(); // 0x0000000181D5C1D0-0x0000000181D5C2A0
			private void Stretching(); // 0x0000000181D5FD80-0x0000000181D60710
			public void Solve(bool isLeft); // 0x0000000181D5DB60-0x0000000181D5FD80
			public override void ResetOffsets(); // 0x0000000181D5DAF0-0x0000000181D5DB60
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations); // 0x0000000181D60860-0x0000000181D60D90
			private float DamperValue(float value, float min, float max, float weight = 1f /* Metadata: 0x00745148 */); // 0x0000000181D5C2A0-0x0000000181D5C3A0
			private Vector3 GetBendNormal(Vector3 dir); // 0x0000000181D5C3A0-0x0000000181D5CB20
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color); // 0x0000000181D60710-0x0000000181D60860
		}
	
		[Serializable]
		public abstract class BodyPart // TypeDefIndex: 9408
		{
			// Fields
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private float <sqrMag>k__BackingField; // 0x10
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private float <mag>k__BackingField; // 0x14
			[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
			public VirtualBone[] bones; // 0x18
			protected bool initiated; // 0x20
			protected Vector3 rootPosition; // 0x24
			protected Quaternion rootRotation; // 0x30
			protected int index; // 0x40
	
			// Properties
			public float sqrMag { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180493360-0x0000000180493370 0x0000000180BD7F10-0x0000000180BD7F20
			public float mag { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018048F530-0x000000018048F540 0x00000001805C1F50-0x00000001805C1F60
	
			// Constructors
			protected BodyPart(); // 0x0000000181D61EE0-0x0000000181D61F60
	
			// Methods
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);
			public abstract void PreSolve();
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);
			public abstract void ApplyOffsets();
			public abstract void ResetOffsets();
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index); // 0x0000000181D61380-0x0000000181D614A0
			public void MovePosition(Vector3 position); // 0x0000000181D610A0-0x0000000181D61290
			public void MoveRotation(Quaternion rotation); // 0x0000000181D61290-0x0000000181D61380
			public void Translate(Vector3 position, Quaternion rotation); // 0x0000000181D618B0-0x0000000181D61B80
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot); // 0x0000000181D61690-0x0000000181D618B0
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f /* Metadata: 0x0074515C */); // 0x0000000181D614A0-0x0000000181D61690
			public void Visualize(Color color); // 0x0000000181D61B80-0x0000000181D61D20
			public void Visualize(); // 0x0000000181D61D20-0x0000000181D61EE0
		}
	
		[Serializable]
		public class Footstep // TypeDefIndex: 9409
		{
			// Fields
			public float stepSpeed; // 0x10
			public Vector3 characterSpaceOffset; // 0x14
			public Vector3 position; // 0x20
			public Quaternion rotation; // 0x2C
			public Quaternion stepToRootRot; // 0x3C
			public bool isSupportLeg; // 0x4C
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private float <stepProgress>k__BackingField; // 0x50
			public Vector3 stepFrom; // 0x54
			public Vector3 stepTo; // 0x60
			public Quaternion stepFromRot; // 0x6C
			public Quaternion stepToRot; // 0x7C
			private Quaternion footRelativeToRoot; // 0x8C
			private float supportLegW; // 0x9C
			private float supportLegWV; // 0xA0
	
			// Properties
			public bool isStepping { get; } // 0x0000000181D62820-0x0000000181D62830 
			public float stepProgress { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180487D20-0x0000000180487D30 0x0000000180DD2D90-0x0000000180DD2DA0
	
			// Constructors
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset); // 0x0000000181D62690-0x0000000181D62820
	
			// Methods
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation); // 0x0000000181D61F60-0x0000000181D61FB0
			public void StepTo(Vector3 p, Quaternion rootRotation); // 0x0000000181D61FB0-0x0000000181D62090
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed); // 0x0000000181D62290-0x0000000181D62450
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed); // 0x0000000181D62090-0x0000000181D62290
			public void Update(InterpolationMode interpolation, UnityEvent onStep); // 0x0000000181D62450-0x0000000181D62690
		}
	
		[Serializable]
		public class Leg : BodyPart // TypeDefIndex: 9410
		{
			// Fields
			[Tooltip] // 0x000000018014B7F0-0x000000018014B820
			public Transform target; // 0x48
			[Tooltip] // 0x000000018014BB10-0x000000018014BB40
			public Transform bendGoal; // 0x50
			[Range] // 0x000000018014BD00-0x000000018014BD60
			[Tooltip] // 0x000000018014BD00-0x000000018014BD60
			public float positionWeight; // 0x58
			[Range] // 0x000000018014C040-0x000000018014C0A0
			[Tooltip] // 0x000000018014C040-0x000000018014C0A0
			public float rotationWeight; // 0x5C
			[Range] // 0x000000018014C460-0x000000018014C4C0
			[Tooltip] // 0x000000018014C460-0x000000018014C4C0
			public float bendGoalWeight; // 0x60
			[Range] // 0x000000018014C7D0-0x000000018014C830
			[Tooltip] // 0x000000018014C7D0-0x000000018014C830
			public float swivelOffset; // 0x64
			[Range] // 0x000000018014CA00-0x000000018014CA60
			[Tooltip] // 0x000000018014CA00-0x000000018014CA60
			public float bendToTargetWeight; // 0x68
			[Range] // 0x000000018014CE10-0x000000018014CE70
			[Tooltip] // 0x000000018014CE10-0x000000018014CE70
			public float legLengthMlp; // 0x6C
			[Tooltip] // 0x000000018014CF60-0x000000018014CF90
			public AnimationCurve stretchCurve; // 0x70
			[NonSerialized]
			[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
			public Vector3 IKPosition; // 0x78
			[NonSerialized]
			[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
			public Quaternion IKRotation; // 0x84
			[NonSerialized]
			[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
			public Vector3 footPositionOffset; // 0x94
			[NonSerialized]
			[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
			public Vector3 heelPositionOffset; // 0xA0
			[NonSerialized]
			[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
			public Quaternion footRotationOffset; // 0xAC
			[NonSerialized]
			[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
			public float currentMag; // 0xBC
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private Vector3 <position>k__BackingField; // 0xC0
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private Quaternion <rotation>k__BackingField; // 0xCC
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private bool <hasToes>k__BackingField; // 0xDC
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private Vector3 <thighRelativeToPelvis>k__BackingField; // 0xE0
			private Vector3 footPosition; // 0xEC
			private Quaternion footRotation; // 0xF8
			private Vector3 bendNormal; // 0x108
			private Quaternion calfRelToThigh; // 0x114
			private Quaternion thighRelToFoot; // 0x124
			private Vector3 bendNormalRelToPelvis; // 0x134
			private Vector3 bendNormalRelToTarget; // 0x140
	
			// Properties
			public Vector3 position { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000181B04AC0-0x0000000181B04AE0 0x0000000181B04B80-0x0000000181B04BA0
			public Quaternion rotation { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180615040-0x0000000180615050 0x000000018050E510-0x000000018050E520
			public bool hasToes { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001819DFAD0-0x00000001819DFAE0 0x00000001819DFCA0-0x00000001819DFCB0
			public VirtualBone thigh { get; } // 0x0000000181B04B00-0x0000000181B04B40 
			private VirtualBone calf { get; } // 0x0000000181B04A00-0x0000000181B04A40 
			private VirtualBone foot { get; } // 0x0000000181B04A40-0x0000000181B04A80 
			private VirtualBone toes { get; } // 0x0000000181B04B40-0x0000000181B04B80 
			public VirtualBone lastBone { get; } // 0x0000000181B04A80-0x0000000181B04AC0 
			public Vector3 thighRelativeToPelvis { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000181B04AE0-0x0000000181B04B00 0x0000000181B04BA0-0x0000000181B04BC0
	
			// Constructors
			public Leg(); // 0x0000000181B04900-0x0000000181B04A00
	
			// Methods
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index); // 0x0000000181B01C10-0x0000000181B027B0
			public override void PreSolve(); // 0x0000000181B027B0-0x0000000181B02F50
			public override void ApplyOffsets(); // 0x0000000181B00EE0-0x0000000181B01820
			private void ApplyPositionOffset(Vector3 offset, float weight); // 0x0000000181B01820-0x0000000181B01970
			private void ApplyRotationOffset(Quaternion offset, float weight); // 0x0000000181B01970-0x0000000181B01C10
			public void Solve(bool stretch); // 0x0000000181B03010-0x0000000181B03A00
			private void Stretching(); // 0x0000000181B03A00-0x0000000181B04440
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations); // 0x0000000181B04440-0x0000000181B04900
			public override void ResetOffsets(); // 0x0000000181B02F50-0x0000000181B03010
		}
	
		[Serializable]
		public class Locomotion // TypeDefIndex: 9411
		{
			// Fields
			[Range] // 0x0000000180151530-0x0000000180151590
			[Tooltip] // 0x0000000180151530-0x0000000180151590
			public float weight; // 0x10
			[Tooltip] // 0x0000000180151920-0x0000000180151950
			public float footDistance; // 0x14
			[Tooltip] // 0x0000000180151BF0-0x0000000180151C20
			public float stepThreshold; // 0x18
			[Tooltip] // 0x0000000180151D10-0x0000000180151D40
			public float angleThreshold; // 0x1C
			[Tooltip] // 0x0000000180151F40-0x0000000180151F70
			public float comAngleMlp; // 0x20
			[Tooltip] // 0x0000000180152130-0x0000000180152160
			public float maxVelocity; // 0x24
			[Tooltip] // 0x0000000180152340-0x0000000180152370
			public float velocityFactor; // 0x28
			[Range] // 0x00000001801525C0-0x0000000180152620
			[Tooltip] // 0x00000001801525C0-0x0000000180152620
			public float maxLegStretch; // 0x2C
			[Tooltip] // 0x0000000180152850-0x0000000180152880
			public float rootSpeed; // 0x30
			[Tooltip] // 0x0000000180152A20-0x0000000180152A50
			public float stepSpeed; // 0x34
			[Tooltip] // 0x0000000180152C80-0x0000000180152CB0
			public AnimationCurve stepHeight; // 0x38
			[Tooltip] // 0x0000000180152E30-0x0000000180152E60
			public AnimationCurve heelHeight; // 0x40
			[Range] // 0x0000000180152FE0-0x0000000180153040
			[Tooltip] // 0x0000000180152FE0-0x0000000180153040
			public float relaxLegTwistMinAngle; // 0x48
			[Tooltip] // 0x00000001801533B0-0x00000001801533E0
			public float relaxLegTwistSpeed; // 0x4C
			[Tooltip] // 0x00000001801535F0-0x0000000180153620
			public InterpolationMode stepInterpolation; // 0x50
			[Tooltip] // 0x00000001801536B0-0x00000001801536E0
			public Vector3 offset; // 0x54
			[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
			public bool blockingEnabled; // 0x60
			[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
			public LayerMask blockingLayers; // 0x64
			[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
			public float raycastRadius; // 0x68
			[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
			public float raycastHeight; // 0x6C
			[Tooltip] // 0x0000000180153CC0-0x0000000180153CF0
			public UnityEvent onLeftFootstep; // 0x70
			[Tooltip] // 0x0000000180153ED0-0x0000000180153F00
			public UnityEvent onRightFootstep; // 0x78
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private Vector3 <centerOfMass>k__BackingField; // 0x80
			private Footstep[] footsteps; // 0x90
			private Vector3 lastComPosition; // 0x98
			private Vector3 comVelocity; // 0xA4
			private int leftFootIndex; // 0xB0
			private int rightFootIndex; // 0xB4
	
			// Properties
			public Vector3 centerOfMass { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180EF1850-0x0000000180EF1870 0x0000000180EF18B0-0x0000000180EF18D0
			public Vector3 leftFootstepPosition { get; } // 0x0000000181B08670-0x0000000181B086D0 
			public Vector3 rightFootstepPosition { get; } // 0x0000000181B08730-0x0000000181B08790 
			public Quaternion leftFootstepRotation { get; } // 0x0000000181B086D0-0x0000000181B08730 
			public Quaternion rightFootstepRotation { get; } // 0x0000000181B08790-0x0000000181B087F0 
	
			// Constructors
			public Locomotion(); // 0x0000000181B08570-0x0000000181B08670
	
			// Methods
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes); // 0x0000000181B05720-0x0000000181B05B30
			public void Reset(Vector3[] positions, Quaternion[] rotations); // 0x0000000181B05B30-0x0000000181B05F40
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot); // 0x0000000181B04F60-0x0000000181B05450
			public void AddDeltaPosition(Vector3 delta); // 0x0000000181B04D20-0x0000000181B04F60
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset); // 0x0000000181B05F40-0x0000000181B08340
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition); // 0x0000000181B08340-0x0000000181B08570
			private bool CanStep(); // 0x0000000181B05450-0x0000000181B054F0
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius); // 0x0000000181B054F0-0x0000000181B05720
		}
	
		[Serializable]
		public class Spine : BodyPart // TypeDefIndex: 9412
		{
			// Fields
			[Tooltip] // 0x00000001801542C0-0x00000001801542F0
			public Transform headTarget; // 0x48
			[Tooltip] // 0x0000000180154400-0x0000000180154430
			public Transform pelvisTarget; // 0x50
			[Range] // 0x0000000180154590-0x00000001801545F0
			[Tooltip] // 0x0000000180154590-0x00000001801545F0
			public float positionWeight; // 0x58
			[Range] // 0x00000001801549F0-0x0000000180154A50
			[Tooltip] // 0x00000001801549F0-0x0000000180154A50
			public float rotationWeight; // 0x5C
			[Range] // 0x0000000180154C50-0x0000000180154CB0
			[Tooltip] // 0x0000000180154C50-0x0000000180154CB0
			public float pelvisPositionWeight; // 0x60
			[Range] // 0x0000000180154E70-0x0000000180154ED0
			[Tooltip] // 0x0000000180154E70-0x0000000180154ED0
			public float pelvisRotationWeight; // 0x64
			[Tooltip] // 0x0000000180155230-0x0000000180155260
			public Transform chestGoal; // 0x68
			[Range] // 0x0000000180155290-0x00000001801552F0
			[Tooltip] // 0x0000000180155290-0x00000001801552F0
			public float chestGoalWeight; // 0x70
			[Tooltip] // 0x00000001801554F0-0x0000000180155520
			public float minHeadHeight; // 0x74
			[Range] // 0x00000001801569D0-0x0000000180156A30
			[Tooltip] // 0x00000001801569D0-0x0000000180156A30
			public float bodyPosStiffness; // 0x78
			[Range] // 0x0000000180156D50-0x0000000180156DB0
			[Tooltip] // 0x0000000180156D50-0x0000000180156DB0
			public float bodyRotStiffness; // 0x7C
			[FormerlySerializedAs] // 0x0000000180157040-0x00000001801570C0
			[Range] // 0x0000000180157040-0x00000001801570C0
			[Tooltip] // 0x0000000180157040-0x00000001801570C0
			public float neckStiffness; // 0x80
			[Range] // 0x0000000180157420-0x0000000180157480
			[Tooltip] // 0x0000000180157420-0x0000000180157480
			public float rotateChestByHands; // 0x84
			[Range] // 0x0000000180157760-0x00000001801577C0
			[Tooltip] // 0x0000000180157760-0x00000001801577C0
			public float chestClampWeight; // 0x88
			[Range] // 0x0000000180157A10-0x0000000180157A70
			[Tooltip] // 0x0000000180157A10-0x0000000180157A70
			public float headClampWeight; // 0x8C
			[Tooltip] // 0x0000000180157D70-0x0000000180157DA0
			public float moveBodyBackWhenCrouching; // 0x90
			[Range] // 0x0000000180157F70-0x0000000180157FD0
			[Tooltip] // 0x0000000180157F70-0x0000000180157FD0
			public float maintainPelvisPosition; // 0x94
			[Range] // 0x00000001801582C0-0x0000000180158320
			[Tooltip] // 0x00000001801582C0-0x0000000180158320
			public float maxRootAngle; // 0x98
			[NonSerialized]
			[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
			public Vector3 IKPositionHead; // 0x9C
			[NonSerialized]
			[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
			public Quaternion IKRotationHead; // 0xA8
			[NonSerialized]
			[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
			public Vector3 IKPositionPelvis; // 0xB8
			[NonSerialized]
			[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
			public Quaternion IKRotationPelvis; // 0xC4
			[NonSerialized]
			[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
			public Vector3 goalPositionChest; // 0xD4
			[NonSerialized]
			[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
			public Vector3 pelvisPositionOffset; // 0xE0
			[NonSerialized]
			[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
			public Vector3 chestPositionOffset; // 0xEC
			[NonSerialized]
			[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
			public Vector3 headPositionOffset; // 0xF8
			[NonSerialized]
			[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
			public Quaternion pelvisRotationOffset; // 0x104
			[NonSerialized]
			[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
			public Quaternion chestRotationOffset; // 0x114
			[NonSerialized]
			[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
			public Quaternion headRotationOffset; // 0x124
			[NonSerialized]
			[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
			public Vector3 faceDirection; // 0x134
			[NonSerialized]
			[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
			public Vector3 locomotionHeadPositionOffset; // 0x140
			[NonSerialized]
			[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
			public Vector3 headPosition; // 0x14C
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private Quaternion <anchorRotation>k__BackingField; // 0x158
			private Quaternion headRotation; // 0x168
			private Quaternion pelvisRotation; // 0x178
			private Quaternion anchorRelativeToHead; // 0x188
			private Quaternion anchorRelativeToPelvis; // 0x198
			private Quaternion pelvisRelativeRotation; // 0x1A8
			private Quaternion chestRelativeRotation; // 0x1B8
			private Vector3 headDeltaPosition; // 0x1C8
			private Quaternion pelvisDeltaRotation; // 0x1D4
			private Quaternion chestTargetRotation; // 0x1E4
			private int pelvisIndex; // 0x1F4
			private int spineIndex; // 0x1F8
			private int chestIndex; // 0x1FC
			private int neckIndex; // 0x200
			private int headIndex; // 0x204
			private float length; // 0x208
			private bool hasChest; // 0x20C
			private bool hasNeck; // 0x20D
			private bool hasLegs; // 0x20E
			private float headHeight; // 0x210
			private float sizeMlp; // 0x214
			private Vector3 chestForward; // 0x218
	
			// Properties
			public VirtualBone pelvis { get; } // 0x0000000181B14870-0x0000000181B148B0 
			public VirtualBone firstSpineBone { get; } // 0x0000000181B147B0-0x0000000181B147F0 
			public VirtualBone chest { get; } // 0x0000000181B14730-0x0000000181B147B0 
			private VirtualBone neck { get; } // 0x0000000181B14830-0x0000000181B14870 
			public VirtualBone head { get; } // 0x0000000181B147F0-0x0000000181B14830 
			public Quaternion anchorRotation { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000181B14720-0x0000000181B14730 0x0000000181B148B0-0x0000000181B148C0
	
			// Constructors
			public Spine(); // 0x0000000181B14520-0x0000000181B14720
	
			// Methods
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index); // 0x0000000181B118D0-0x0000000181B127F0
			public override void PreSolve(); // 0x0000000181B127F0-0x0000000181B12B80
			public override void ApplyOffsets(); // 0x0000000181B0FEC0-0x0000000181B10570
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms); // 0x0000000181B10C50-0x0000000181B10E70
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms); // 0x0000000181B13270-0x0000000181B13BB0
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp); // 0x0000000181B10E70-0x0000000181B11150
			private void SolvePelvis(); // 0x0000000181B12C90-0x0000000181B13270
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations); // 0x0000000181B14190-0x0000000181B14520
			public override void ResetOffsets(); // 0x0000000181B12B80-0x0000000181B12C90
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms); // 0x0000000181B0FA10-0x0000000181B0FEC0
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w); // 0x0000000181B11150-0x0000000181B113A0
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation); // 0x0000000181B13BB0-0x0000000181B14190
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2 /* Metadata: 0x00745160 */); // 0x0000000181B113A0-0x0000000181B118D0
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w); // 0x0000000181B10570-0x0000000181B10880
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w); // 0x0000000181B10880-0x0000000181B10C50
		}
	
		[Serializable]
		public enum PositionOffset // TypeDefIndex: 9413
		{
			Pelvis = 0,
			Chest = 1,
			Head = 2,
			LeftHand = 3,
			RightHand = 4,
			LeftFoot = 5,
			RightFoot = 6,
			LeftHeel = 7,
			RightHeel = 8
		}
	
		[Serializable]
		public enum RotationOffset // TypeDefIndex: 9414
		{
			Pelvis = 0,
			Chest = 1,
			Head = 2
		}
	
		[Serializable]
		public class VirtualBone // TypeDefIndex: 9415
		{
			// Fields
			public Vector3 readPosition; // 0x10
			public Quaternion readRotation; // 0x1C
			public Vector3 solverPosition; // 0x2C
			public Quaternion solverRotation; // 0x38
			public float length; // 0x48
			public float sqrMag; // 0x4C
			public Vector3 axis; // 0x50
	
			// Constructors
			public VirtualBone(Vector3 position, Quaternion rotation); // 0x0000000181B179A0-0x0000000181B17A00
	
			// Methods
			public void Read(Vector3 position, Quaternion rotation); // 0x0000000181B157F0-0x0000000181B15820
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f /* Metadata: 0x00745194 */); // 0x0000000181B17680-0x0000000181B179A0
			public static float PreSolve(ref VirtualBone[] bones); // 0x0000000181B15230-0x0000000181B157F0
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation); // 0x0000000181B15820-0x0000000181B15AC0
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation); // 0x0000000181B15E00-0x0000000181B16130
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation); // 0x0000000181B15AC0-0x0000000181B15E00
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation); // 0x0000000181B16130-0x0000000181B16230
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight); // 0x0000000181B16E20-0x0000000181B17680
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2); // 0x0000000181B14FE0-0x0000000181B15230
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset); // 0x0000000181B166D0-0x0000000181B16E20
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length); // 0x0000000181B16590-0x0000000181B166D0
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations); // 0x0000000181B16230-0x0000000181B16590
		}
	
		// Constructors
		public IKSolverVR(); // 0x0000000181D83200-0x0000000181D833D0
	
		// Methods
		public void SetToReferences(VRIK.References references); // 0x0000000181D80730-0x0000000181D80AE0
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero); // 0x0000000181D7EBB0-0x0000000181D7EFB0
		public void DefaultAnimationCurves(); // 0x0000000181D7D720-0x0000000181D7D920
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value); // 0x0000000181D7CDB0-0x0000000181D7D2F0
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value); // 0x0000000181D7D2F0-0x0000000181D7D540
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value); // 0x0000000181D7D540-0x0000000181D7D720
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot); // 0x0000000181D7CBD0-0x0000000181D7CDB0
		public void Reset(); // 0x0000000181D80540-0x0000000181D80730
		public override void StoreDefaultLocalState(); // 0x0000000181D826E0-0x0000000181D82910
		public override void FixTransforms(); // 0x0000000181D7D920-0x0000000181D7DB90
		public override Point[] GetPoints(); // 0x0000000181D7E930-0x0000000181D7E990
		public override Point GetPoint(Transform transform); // 0x0000000181D7E8D0-0x0000000181D7E930
		public override bool IsValid(ref string message); // 0x0000000181D7F6F0-0x0000000181D7F9B0
		private Vector3 GetNormal(Transform[] transforms); // 0x0000000181D7DB90-0x0000000181D7DF60
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm); // 0x0000000181D7F4B0-0x0000000181D7F6F0
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm); // 0x0000000181D7EFB0-0x0000000181D7F4B0
		private static Keyframe[] GetSineKeyframes(float mag); // 0x0000000181D7EA30-0x0000000181D7EBB0
		private void UpdateSolverTransforms(); // 0x0000000181D82910-0x0000000181D82B20
		protected override void OnInitiate(); // 0x0000000181D7F9B0-0x0000000181D7FA10
		protected override void OnUpdate(); // 0x0000000181D7FA10-0x0000000181D7FAA0
		private void WriteTransforms(); // 0x0000000181D82B20-0x0000000181D82FF0
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs); // 0x0000000181D7FAA0-0x0000000181D80540
		private void Solve(); // 0x0000000181D80AE0-0x0000000181D826E0
		private Vector3 GetPosition(int index); // 0x0000000181D7E990-0x0000000181D7E9E0
		private Quaternion GetRotation(int index); // 0x0000000181D7E9E0-0x0000000181D7EA30
		private void Write(); // 0x0000000181D82FF0-0x0000000181D83200
		private Vector3 GetPelvisOffset(); // 0x0000000181D7DF60-0x0000000181D7E8D0
	}
}
