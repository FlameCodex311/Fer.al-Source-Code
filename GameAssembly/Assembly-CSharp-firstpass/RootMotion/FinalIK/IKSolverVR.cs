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

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion.FinalIK
{
	[Serializable]
	public class IKSolverVR : IKSolver // TypeDefIndex: 9939
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
		[Tooltip] // 0x0000000180249330-0x0000000180249360
		public bool plantFeet; // 0xC0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private VirtualBone <rootBone>k__BackingField; // 0xC8
		[Tooltip] // 0x000000018024A7E0-0x000000018024A810
		public Spine spine; // 0xD0
		[Tooltip] // 0x000000018024A8F0-0x000000018024A920
		public Arm leftArm; // 0xD8
		[Tooltip] // 0x000000018024A960-0x000000018024A990
		public Arm rightArm; // 0xE0
		[Tooltip] // 0x000000018024AA20-0x000000018024AA50
		public Leg leftLeg; // 0xE8
		[Tooltip] // 0x000000018024ABA0-0x000000018024ABD0
		public Leg rightLeg; // 0xF0
		[Tooltip] // 0x000000018024ACA0-0x000000018024ACD0
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
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public VirtualBone rootBone { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001804AF400-0x00000001804AF410 0x00000001804AF520-0x00000001804AF530
	
		// Nested types
		[Serializable]
		public class Arm : BodyPart // TypeDefIndex: 9940
		{
			// Fields
			[Tooltip] // 0x000000018024B050-0x000000018024B080
			public Transform target; // 0x48
			[Tooltip] // 0x000000018024B290-0x000000018024B2C0
			public Transform bendGoal; // 0x50
			[Range] // 0x000000018024B460-0x000000018024B4C0
			[Tooltip] // 0x000000018024B460-0x000000018024B4C0
			public float positionWeight; // 0x58
			[Range] // 0x000000018024B790-0x000000018024B7F0
			[Tooltip] // 0x000000018024B790-0x000000018024B7F0
			public float rotationWeight; // 0x5C
			[Tooltip] // 0x000000018024B910-0x000000018024B940
			public ShoulderRotationMode shoulderRotationMode; // 0x60
			[Range] // 0x000000018024BB90-0x000000018024BBF0
			[Tooltip] // 0x000000018024BB90-0x000000018024BBF0
			public float shoulderRotationWeight; // 0x64
			[Range] // 0x000000018024BD70-0x000000018024BDD0
			[Tooltip] // 0x000000018024BD70-0x000000018024BDD0
			public float shoulderTwistWeight; // 0x68
			[Range] // 0x000000018024C1C0-0x000000018024C220
			[Tooltip] // 0x000000018024C1C0-0x000000018024C220
			public float bendGoalWeight; // 0x6C
			[Range] // 0x000000018024C380-0x000000018024C3E0
			[Tooltip] // 0x000000018024C380-0x000000018024C3E0
			public float swivelOffset; // 0x70
			[Tooltip] // 0x000000018024C4C0-0x000000018024C4F0
			public Vector3 wristToPalmAxis; // 0x74
			[Tooltip] // 0x000000018024C650-0x000000018024C680
			public Vector3 palmToThumbAxis; // 0x80
			[Range] // 0x000000018024C820-0x000000018024C880
			[Tooltip] // 0x000000018024C820-0x000000018024C880
			public float armLengthMlp; // 0x8C
			[Tooltip] // 0x000000018024CA10-0x000000018024CA40
			public AnimationCurve stretchCurve; // 0x90
			[NonSerialized]
			[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
			public Vector3 IKPosition; // 0x98
			[NonSerialized]
			[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
			public Quaternion IKRotation; // 0xA4
			[NonSerialized]
			[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
			public Vector3 bendDirection; // 0xB4
			[NonSerialized]
			[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
			public Vector3 handPositionOffset; // 0xC0
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private Vector3 <position>k__BackingField; // 0xCC
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private Quaternion <rotation>k__BackingField; // 0xD8
			private bool hasShoulder; // 0xE8
			private Vector3 chestForwardAxis; // 0xEC
			private Vector3 chestUpAxis; // 0xF8
			private Quaternion chestRotation; // 0x104
			private Vector3 chestForward; // 0x114
			private Vector3 chestUp; // 0x120
			private Quaternion forearmRelToUpperArm; // 0x12C
			private const float yawOffsetAngle = 45f; // Metadata: 0x0077AC59
			private const float pitchOffsetAngle = -30f; // Metadata: 0x0077AC5D
	
			// Properties
			public Vector3 position { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000181A99850-0x0000000181A99870 0x0000000181A998B0-0x0000000181A998D0
			public Quaternion rotation { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180BEAF10-0x0000000180BEAF20 0x0000000181A998D0-0x0000000181A998E0
			private VirtualBone shoulder { get; } // 0x000000018198A880-0x000000018198A8C0 
			private VirtualBone upperArm { get; } // 0x0000000181A99870-0x0000000181A998B0 
			private VirtualBone forearm { get; } // 0x0000000181A997B0-0x0000000181A99800 
			private VirtualBone hand { get; } // 0x0000000181A99800-0x0000000181A99850 
	
			// Nested types
			[Serializable]
			public enum ShoulderRotationMode // TypeDefIndex: 9941
			{
				YawPitch = 0,
				FromTo = 1
			}
	
			// Constructors
			public Arm(); // 0x0000000181A99650-0x0000000181A997B0
	
			// Methods
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index); // 0x0000000181A953A0-0x0000000181A95F10
			public override void PreSolve(); // 0x0000000181A95F10-0x0000000181A962E0
			public override void ApplyOffsets(); // 0x0000000181A94A60-0x0000000181A94B30
			private void Stretching(); // 0x0000000181A986F0-0x0000000181A99030
			public void Solve(bool isLeft); // 0x0000000181A96350-0x0000000181A986F0
			public override void ResetOffsets(); // 0x0000000181A962E0-0x0000000181A96350
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations); // 0x0000000181A99170-0x0000000181A99650
			private float DamperValue(float value, float min, float max, float weight = 1f /* Metadata: 0x0077AC55 */); // 0x0000000181A94B30-0x0000000181A94C30
			private Vector3 GetBendNormal(Vector3 dir); // 0x0000000181A94C30-0x0000000181A953A0
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color); // 0x0000000181A99030-0x0000000181A99170
		}
	
		[Serializable]
		public abstract class BodyPart // TypeDefIndex: 9942
		{
			// Fields
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private float <sqrMag>k__BackingField; // 0x10
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private float <mag>k__BackingField; // 0x14
			[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
			public VirtualBone[] bones; // 0x18
			protected bool initiated; // 0x20
			protected Vector3 rootPosition; // 0x24
			protected Quaternion rootRotation; // 0x30
			protected int index; // 0x40
	
			// Properties
			public float sqrMag { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180373AA0-0x0000000180373AB0 0x0000000180373AB0-0x0000000180373AC0
			public float mag { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x000000018094A320-0x000000018094A330 0x000000018094A330-0x000000018094A340
	
			// Constructors
			protected BodyPart(); // 0x0000000181A9A6B0-0x0000000181A9A730
	
			// Methods
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);
			public abstract void PreSolve();
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);
			public abstract void ApplyOffsets();
			public abstract void ResetOffsets();
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index); // 0x0000000181A99BB0-0x0000000181A99CC0
			public void MovePosition(Vector3 position); // 0x0000000181A998E0-0x0000000181A99AC0
			public void MoveRotation(Quaternion rotation); // 0x0000000181A99AC0-0x0000000181A99BB0
			public void Translate(Vector3 position, Quaternion rotation); // 0x0000000181A9A0B0-0x0000000181A9A370
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot); // 0x0000000181A99EA0-0x0000000181A9A0B0
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f /* Metadata: 0x0077AC69 */); // 0x0000000181A99CC0-0x0000000181A99EA0
			public void Visualize(Color color); // 0x0000000181A9A370-0x0000000181A9A500
			public void Visualize(); // 0x0000000181A9A500-0x0000000181A9A6B0
		}
	
		[Serializable]
		public class Footstep // TypeDefIndex: 9943
		{
			// Fields
			public float stepSpeed; // 0x10
			public Vector3 characterSpaceOffset; // 0x14
			public Vector3 position; // 0x20
			public Quaternion rotation; // 0x2C
			public Quaternion stepToRootRot; // 0x3C
			public bool isSupportLeg; // 0x4C
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private float <stepProgress>k__BackingField; // 0x50
			public Vector3 stepFrom; // 0x54
			public Vector3 stepTo; // 0x60
			public Quaternion stepFromRot; // 0x6C
			public Quaternion stepToRot; // 0x7C
			private Quaternion footRelativeToRoot; // 0x8C
			private float supportLegW; // 0x9C
			private float supportLegWV; // 0xA0
	
			// Properties
			public bool isStepping { get; } // 0x0000000181A9AFF0-0x0000000181A9B000 
			public float stepProgress { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180791CE0-0x0000000180791CF0 0x00000001807E32A0-0x00000001807E32B0
	
			// Constructors
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset); // 0x0000000181A9AE60-0x0000000181A9AFF0
	
			// Methods
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation); // 0x0000000181A9A730-0x0000000181A9A780
			public void StepTo(Vector3 p, Quaternion rootRotation); // 0x0000000181A9A780-0x0000000181A9A860
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed); // 0x0000000181A9AA60-0x0000000181A9AC20
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed); // 0x0000000181A9A860-0x0000000181A9AA60
			public void Update(InterpolationMode interpolation, UnityEvent onStep); // 0x0000000181A9AC20-0x0000000181A9AE60
		}
	
		[Serializable]
		public class Leg : BodyPart // TypeDefIndex: 9944
		{
			// Fields
			[Tooltip] // 0x000000018024EB10-0x000000018024EB40
			public Transform target; // 0x48
			[Tooltip] // 0x000000018024ED10-0x000000018024ED40
			public Transform bendGoal; // 0x50
			[Range] // 0x000000018024EEE0-0x000000018024EF40
			[Tooltip] // 0x000000018024EEE0-0x000000018024EF40
			public float positionWeight; // 0x58
			[Range] // 0x000000018024F2A0-0x000000018024F300
			[Tooltip] // 0x000000018024F2A0-0x000000018024F300
			public float rotationWeight; // 0x5C
			[Range] // 0x000000018024F660-0x000000018024F6C0
			[Tooltip] // 0x000000018024F660-0x000000018024F6C0
			public float bendGoalWeight; // 0x60
			[Range] // 0x000000018024F840-0x000000018024F8A0
			[Tooltip] // 0x000000018024F840-0x000000018024F8A0
			public float swivelOffset; // 0x64
			[Range] // 0x000000018024FC60-0x000000018024FCC0
			[Tooltip] // 0x000000018024FC60-0x000000018024FCC0
			public float bendToTargetWeight; // 0x68
			[Range] // 0x00000001802512B0-0x0000000180251310
			[Tooltip] // 0x00000001802512B0-0x0000000180251310
			public float legLengthMlp; // 0x6C
			[Tooltip] // 0x0000000180251640-0x0000000180251670
			public AnimationCurve stretchCurve; // 0x70
			[NonSerialized]
			[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
			public Vector3 IKPosition; // 0x78
			[NonSerialized]
			[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
			public Quaternion IKRotation; // 0x84
			[NonSerialized]
			[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
			public Vector3 footPositionOffset; // 0x94
			[NonSerialized]
			[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
			public Vector3 heelPositionOffset; // 0xA0
			[NonSerialized]
			[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
			public Quaternion footRotationOffset; // 0xAC
			[NonSerialized]
			[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
			public float currentMag; // 0xBC
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private Vector3 <position>k__BackingField; // 0xC0
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private Quaternion <rotation>k__BackingField; // 0xCC
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private bool <hasToes>k__BackingField; // 0xDC
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private Vector3 <thighRelativeToPelvis>k__BackingField; // 0xE0
			private Vector3 footPosition; // 0xEC
			private Quaternion footRotation; // 0xF8
			private Vector3 bendNormal; // 0x108
			private Quaternion calfRelToThigh; // 0x114
			private Quaternion thighRelToFoot; // 0x124
			private Vector3 bendNormalRelToPelvis; // 0x134
			private Vector3 bendNormalRelToTarget; // 0x140
	
			// Properties
			public Vector3 position { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000181AB5450-0x0000000181AB5470 0x0000000181AB54C0-0x0000000181AB54E0
			public Quaternion rotation { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180E59090-0x0000000180E590A0 0x0000000180B36720-0x0000000180B36730
			public bool hasToes { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x000000018148D600-0x000000018148D610 0x0000000181AB54B0-0x0000000181AB54C0
			public VirtualBone thigh { get; } // 0x000000018198A880-0x000000018198A8C0 
			private VirtualBone calf { get; } // 0x0000000181AB5390-0x0000000181AB53D0 
			private VirtualBone foot { get; } // 0x0000000181AB53D0-0x0000000181AB5410 
			private VirtualBone toes { get; } // 0x0000000181AB5470-0x0000000181AB54B0 
			public VirtualBone lastBone { get; } // 0x0000000181AB5410-0x0000000181AB5450 
			public Vector3 thighRelativeToPelvis { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000181890870-0x0000000181890890 0x0000000181890AB0-0x0000000181890AD0
	
			// Constructors
			public Leg(); // 0x0000000181AB5290-0x0000000181AB5390
	
			// Methods
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index); // 0x0000000181AB2760-0x0000000181AB32B0
			public override void PreSolve(); // 0x0000000181AB32B0-0x0000000181AB3A10
			public override void ApplyOffsets(); // 0x0000000181AB1A70-0x0000000181AB2370
			private void ApplyPositionOffset(Vector3 offset, float weight); // 0x0000000181AB2370-0x0000000181AB24C0
			private void ApplyRotationOffset(Quaternion offset, float weight); // 0x0000000181AB24C0-0x0000000181AB2760
			public void Solve(bool stretch); // 0x0000000181AB3AD0-0x0000000181AB4460
			private void Stretching(); // 0x0000000181AB4460-0x0000000181AB4E30
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations); // 0x0000000181AB4E30-0x0000000181AB5290
			public override void ResetOffsets(); // 0x0000000181AB3A10-0x0000000181AB3AD0
		}
	
		[Serializable]
		public class Locomotion // TypeDefIndex: 9945
		{
			// Fields
			[Range] // 0x0000000180253850-0x00000001802538B0
			[Tooltip] // 0x0000000180253850-0x00000001802538B0
			public float weight; // 0x10
			[Tooltip] // 0x0000000180253BE0-0x0000000180253C10
			public float footDistance; // 0x14
			[Tooltip] // 0x0000000180253E10-0x0000000180253E40
			public float stepThreshold; // 0x18
			[Tooltip] // 0x0000000180253FF0-0x0000000180254020
			public float angleThreshold; // 0x1C
			[Tooltip] // 0x0000000180254200-0x0000000180254230
			public float comAngleMlp; // 0x20
			[Tooltip] // 0x0000000180254370-0x00000001802543A0
			public float maxVelocity; // 0x24
			[Tooltip] // 0x0000000180254570-0x00000001802545A0
			public float velocityFactor; // 0x28
			[Range] // 0x00000001802546E0-0x0000000180254740
			[Tooltip] // 0x00000001802546E0-0x0000000180254740
			public float maxLegStretch; // 0x2C
			[Tooltip] // 0x0000000180254890-0x00000001802548C0
			public float rootSpeed; // 0x30
			[Tooltip] // 0x0000000180254A80-0x0000000180254AB0
			public float stepSpeed; // 0x34
			[Tooltip] // 0x0000000180254D40-0x0000000180254D70
			public AnimationCurve stepHeight; // 0x38
			[Tooltip] // 0x0000000180254E80-0x0000000180254EB0
			public AnimationCurve heelHeight; // 0x40
			[Range] // 0x0000000180255090-0x00000001802550F0
			[Tooltip] // 0x0000000180255090-0x00000001802550F0
			public float relaxLegTwistMinAngle; // 0x48
			[Tooltip] // 0x0000000180255260-0x0000000180255290
			public float relaxLegTwistSpeed; // 0x4C
			[Tooltip] // 0x00000001802553C0-0x00000001802553F0
			public InterpolationMode stepInterpolation; // 0x50
			[Tooltip] // 0x0000000180255680-0x00000001802556B0
			public Vector3 offset; // 0x54
			[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
			public bool blockingEnabled; // 0x60
			[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
			public LayerMask blockingLayers; // 0x64
			[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
			public float raycastRadius; // 0x68
			[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
			public float raycastHeight; // 0x6C
			[Tooltip] // 0x0000000180255BF0-0x0000000180255C20
			public UnityEvent onLeftFootstep; // 0x70
			[Tooltip] // 0x0000000180255DC0-0x0000000180255DF0
			public UnityEvent onRightFootstep; // 0x78
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private Vector3 <centerOfMass>k__BackingField; // 0x80
			private Footstep[] footsteps; // 0x90
			private Vector3 lastComPosition; // 0x98
			private Vector3 comVelocity; // 0xA4
			private int leftFootIndex; // 0xB0
			private int rightFootIndex; // 0xB4
	
			// Properties
			public Vector3 centerOfMass { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001804C6140-0x00000001804C6160 0x00000001804C61B0-0x00000001804C61D0
			public Vector3 leftFootstepPosition { get; } // 0x0000000181AB8BE0-0x0000000181AB8C40 
			public Vector3 rightFootstepPosition { get; } // 0x0000000181AB8C90-0x0000000181AB8CF0 
			public Quaternion leftFootstepRotation { get; } // 0x0000000181AB8C40-0x0000000181AB8C90 
			public Quaternion rightFootstepRotation { get; } // 0x0000000181AB8CF0-0x0000000181AB8D40 
	
			// Constructors
			public Locomotion(); // 0x0000000181AB8AE0-0x0000000181AB8BE0
	
			// Methods
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes); // 0x0000000181AB5EA0-0x0000000181AB6290
			public void Reset(Vector3[] positions, Quaternion[] rotations); // 0x0000000181AB6290-0x0000000181AB6690
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot); // 0x0000000181AB5710-0x0000000181AB5BF0
			public void AddDeltaPosition(Vector3 delta); // 0x0000000181AB54E0-0x0000000181AB5710
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset); // 0x0000000181AB6690-0x0000000181AB88B0
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition); // 0x0000000181AB88B0-0x0000000181AB8AE0
			private bool CanStep(); // 0x0000000181AB5BF0-0x0000000181AB5C70
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius); // 0x0000000181AB5C70-0x0000000181AB5EA0
		}
	
		[Serializable]
		public class Spine : BodyPart // TypeDefIndex: 9946
		{
			// Fields
			[Tooltip] // 0x0000000180256280-0x00000001802562B0
			public Transform headTarget; // 0x48
			[Tooltip] // 0x0000000180256370-0x00000001802563A0
			public Transform pelvisTarget; // 0x50
			[Range] // 0x00000001802565C0-0x0000000180256620
			[Tooltip] // 0x00000001802565C0-0x0000000180256620
			public float positionWeight; // 0x58
			[Range] // 0x0000000180256770-0x00000001802567D0
			[Tooltip] // 0x0000000180256770-0x00000001802567D0
			public float rotationWeight; // 0x5C
			[Range] // 0x0000000180256AA0-0x0000000180256B00
			[Tooltip] // 0x0000000180256AA0-0x0000000180256B00
			public float pelvisPositionWeight; // 0x60
			[Range] // 0x0000000180256C60-0x0000000180256CC0
			[Tooltip] // 0x0000000180256C60-0x0000000180256CC0
			public float pelvisRotationWeight; // 0x64
			[Tooltip] // 0x0000000180256F50-0x0000000180256F80
			public Transform chestGoal; // 0x68
			[Range] // 0x0000000180257180-0x00000001802571E0
			[Tooltip] // 0x0000000180257180-0x00000001802571E0
			public float chestGoalWeight; // 0x70
			[Tooltip] // 0x0000000180257370-0x00000001802573A0
			public float minHeadHeight; // 0x74
			[Range] // 0x0000000180257530-0x0000000180257590
			[Tooltip] // 0x0000000180257530-0x0000000180257590
			public float bodyPosStiffness; // 0x78
			[Range] // 0x0000000180257790-0x00000001802577F0
			[Tooltip] // 0x0000000180257790-0x00000001802577F0
			public float bodyRotStiffness; // 0x7C
			[FormerlySerializedAs] // 0x00000001802578A0-0x0000000180257920
			[Range] // 0x00000001802578A0-0x0000000180257920
			[Tooltip] // 0x00000001802578A0-0x0000000180257920
			public float neckStiffness; // 0x80
			[Range] // 0x0000000180257A60-0x0000000180257AC0
			[Tooltip] // 0x0000000180257A60-0x0000000180257AC0
			public float rotateChestByHands; // 0x84
			[Range] // 0x0000000180257C90-0x0000000180257CF0
			[Tooltip] // 0x0000000180257C90-0x0000000180257CF0
			public float chestClampWeight; // 0x88
			[Range] // 0x0000000180257F90-0x0000000180257FF0
			[Tooltip] // 0x0000000180257F90-0x0000000180257FF0
			public float headClampWeight; // 0x8C
			[Tooltip] // 0x0000000180258230-0x0000000180258260
			public float moveBodyBackWhenCrouching; // 0x90
			[Range] // 0x00000001802583D0-0x0000000180258430
			[Tooltip] // 0x00000001802583D0-0x0000000180258430
			public float maintainPelvisPosition; // 0x94
			[Range] // 0x0000000180258650-0x00000001802586B0
			[Tooltip] // 0x0000000180258650-0x00000001802586B0
			public float maxRootAngle; // 0x98
			[NonSerialized]
			[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
			public Vector3 IKPositionHead; // 0x9C
			[NonSerialized]
			[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
			public Quaternion IKRotationHead; // 0xA8
			[NonSerialized]
			[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
			public Vector3 IKPositionPelvis; // 0xB8
			[NonSerialized]
			[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
			public Quaternion IKRotationPelvis; // 0xC4
			[NonSerialized]
			[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
			public Vector3 goalPositionChest; // 0xD4
			[NonSerialized]
			[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
			public Vector3 pelvisPositionOffset; // 0xE0
			[NonSerialized]
			[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
			public Vector3 chestPositionOffset; // 0xEC
			[NonSerialized]
			[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
			public Vector3 headPositionOffset; // 0xF8
			[NonSerialized]
			[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
			public Quaternion pelvisRotationOffset; // 0x104
			[NonSerialized]
			[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
			public Quaternion chestRotationOffset; // 0x114
			[NonSerialized]
			[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
			public Quaternion headRotationOffset; // 0x124
			[NonSerialized]
			[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
			public Vector3 faceDirection; // 0x134
			[NonSerialized]
			[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
			public Vector3 locomotionHeadPositionOffset; // 0x140
			[NonSerialized]
			[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
			public Vector3 headPosition; // 0x14C
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
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
			public VirtualBone pelvis { get; } // 0x00000001816486C0-0x0000000181648700 
			public VirtualBone firstSpineBone { get; } // 0x0000000181648600-0x0000000181648640 
			public VirtualBone chest { get; } // 0x0000000181648590-0x0000000181648600 
			private VirtualBone neck { get; } // 0x0000000181648680-0x00000001816486C0 
			public VirtualBone head { get; } // 0x0000000181648640-0x0000000181648680 
			public Quaternion anchorRotation { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000181648580-0x0000000181648590 0x0000000181648700-0x0000000181648710
	
			// Constructors
			public Spine(); // 0x0000000181648380-0x0000000181648580
	
			// Methods
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index); // 0x00000001816456E0-0x0000000181646580
			public override void PreSolve(); // 0x0000000181646580-0x00000001816468F0
			public override void ApplyOffsets(); // 0x0000000181643D70-0x0000000181644410
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms); // 0x0000000181644AE0-0x0000000181644D00
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms); // 0x0000000181646FC0-0x0000000181647A70
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp); // 0x0000000181644D00-0x0000000181644FD0
			private void SolvePelvis(); // 0x0000000181646A00-0x0000000181646FC0
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations); // 0x0000000181648030-0x0000000181648380
			public override void ResetOffsets(); // 0x00000001816468F0-0x0000000181646A00
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms); // 0x00000001816438C0-0x0000000181643D70
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w); // 0x0000000181644FD0-0x0000000181645220
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation); // 0x0000000181647A70-0x0000000181648030
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2 /* Metadata: 0x0077AC6D */); // 0x0000000181645220-0x00000001816456E0
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w); // 0x0000000181644410-0x0000000181644720
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w); // 0x0000000181644720-0x0000000181644AE0
		}
	
		[Serializable]
		public enum PositionOffset // TypeDefIndex: 9947
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
		public enum RotationOffset // TypeDefIndex: 9948
		{
			Pelvis = 0,
			Chest = 1,
			Head = 2
		}
	
		[Serializable]
		public class VirtualBone // TypeDefIndex: 9949
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
			public VirtualBone(Vector3 position, Quaternion rotation); // 0x000000018164B670-0x000000018164B6D0
	
			// Methods
			public void Read(Vector3 position, Quaternion rotation); // 0x00000001816495E0-0x0000000181649610
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f /* Metadata: 0x0077ACA1 */); // 0x000000018164B370-0x000000018164B670
			public static float PreSolve(ref VirtualBone[] bones); // 0x0000000181649060-0x00000001816495E0
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation); // 0x0000000181649610-0x0000000181649890
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation); // 0x0000000181649BB0-0x0000000181649EC0
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation); // 0x0000000181649890-0x0000000181649BB0
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation); // 0x0000000181649EC0-0x0000000181649FB0
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight); // 0x000000018164AB50-0x000000018164B370
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2); // 0x0000000181648E10-0x0000000181649060
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset); // 0x000000018164A440-0x000000018164AB50
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length); // 0x000000018164A300-0x000000018164A440
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations); // 0x0000000181649FB0-0x000000018164A300
		}
	
		// Constructors
		public IKSolverVR(); // 0x0000000181AB17C0-0x0000000181AB1A70
	
		// Methods
		public void SetToReferences(VRIK.References references); // 0x0000000181AAED90-0x0000000181AAF120
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero); // 0x0000000181AAD2D0-0x0000000181AAD6C0
		public void DefaultAnimationCurves(); // 0x0000000181AABEC0-0x0000000181AAC0A0
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value); // 0x0000000181AAB580-0x0000000181AABAB0
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value); // 0x0000000181AABAB0-0x0000000181AABCF0
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value); // 0x0000000181AABCF0-0x0000000181AABEC0
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot); // 0x0000000181AAB1B0-0x0000000181AAB580
		public void Reset(); // 0x0000000181AAEBB0-0x0000000181AAED90
		public override void StoreDefaultLocalState(); // 0x0000000181AB0D30-0x0000000181AB0F40
		public override void FixTransforms(); // 0x0000000181AAC0A0-0x0000000181AAC2F0
		public override Point[] GetPoints(); // 0x0000000181AAD070-0x0000000181AAD0D0
		public override Point GetPoint(Transform transform); // 0x0000000181AAD010-0x0000000181AAD070
		public override bool IsValid(ref string message); // 0x0000000181AADDE0-0x0000000181AAE0A0
		private Vector3 GetNormal(Transform[] transforms); // 0x0000000181AAC2F0-0x0000000181AAC6B0
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm); // 0x0000000181AADBB0-0x0000000181AADDE0
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm); // 0x0000000181AAD6C0-0x0000000181AADBB0
		private static Keyframe[] GetSineKeyframes(float mag); // 0x0000000181AAD170-0x0000000181AAD2D0
		private void UpdateSolverTransforms(); // 0x0000000181AB0F40-0x0000000181AB1130
		protected override void OnInitiate(); // 0x0000000181AAE0A0-0x0000000181AAE100
		protected override void OnUpdate(); // 0x0000000181AAE100-0x0000000181AAE190
		private void WriteTransforms(); // 0x0000000181AB1130-0x0000000181AB15C0
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs); // 0x0000000181AAE190-0x0000000181AAEBB0
		private void Solve(); // 0x0000000181AAF120-0x0000000181AB0D30
		private Vector3 GetPosition(int index); // 0x0000000181AAD0D0-0x0000000181AAD120
		private Quaternion GetRotation(int index); // 0x0000000181AAD120-0x0000000181AAD170
		private void Write(); // 0x0000000181AB15C0-0x0000000181AB17C0
		private Vector3 GetPelvisOffset(); // 0x0000000181AAC6B0-0x0000000181AAD010
	}
}
