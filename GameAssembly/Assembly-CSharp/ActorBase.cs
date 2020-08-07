/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class ActorBase : WorldObjectMover<ActorInfo> // TypeDefIndex: 11470
{
	// Fields
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Animator <BodyAnimator>k__BackingField; // 0xA8
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Animator <WingAnimator>k__BackingField; // 0xB0
	private List<Animator> _animators; // 0xB8
	private List<AnimatorLayerTransitionInfo> _animatorTransitions; // 0xC0
	private List<AnimatorLayerTransitionInfo> _animatorCachedTransitionsToRemove; // 0xC8
	private static int _animatorUpdateIndex; // 0x00
	private static List<ActorBase> _animatorUpdateRegisteredActors; // 0x08
	private static QRoutine _animatorUpdateQRoutine; // 0x10
	private static List<ActorBase> _animatorUpdateCurrentActors; // 0x18
	private bool _registeredForAnimationUpdate; // 0xD0
	private static List<string> _additiveAnimationParameterNames; // 0x20
	private ActorActionType _nextActionType; // 0xD4
	private bool _nextActionBreakLoop; // 0xD8
	private static readonly int Action; // 0x28
	private static readonly int ActionTrigger; // 0x2C
	private List<ActorBodyPart> _attachedBodyParts; // 0xE0
	private Dictionary<string, ActorBodyPart> _attachedNodeToBodyPartDict; // 0xE8
	private ActorBodyPart _headBodyPart; // 0xF0
	private ActorBodyPart _bodyBodyPart; // 0xF8
	private static Material _decalSharedMaterial; // 0x30
	private static Material _eyeShapeSharedMaterial; // 0x38
	private static Material _eyePupilSharedMaterial; // 0x40
	private static Material _maskedBlitMat; // 0x48
	private static Material _standardBlitMat; // 0x50
	private static readonly int Decal2Tex; // 0x58
	private static readonly int ColorId1Hsv; // 0x5C
	private static readonly int ColorId2Hsv; // 0x60
	private static readonly int ColorId3Hsv; // 0x64
	private static readonly int ColorId4Hsv; // 0x68
	private static readonly int DecalTex; // 0x6C
	private GameObject _combinedBodyPartsObject; // 0x100
	private SkinnedMeshRenderer _combinedBodyPartsRenderer; // 0x108
	private Material _combinedBodyMaterial; // 0x110
	[NonSerialized]
	protected UI_ActorBubble _bubble; // 0x118
	private List<AttachedClothingItem> _attachedClothingItems; // 0x120
	private Dictionary<string, AttachedClothingItem> _attachNodeToClothingItemDict; // 0x128
	private Color _lastFakeLightMultColor; // 0x130
	private Color _lastFakeLightAddColor; // 0x140
	private bool _failedWingJointMatching; // 0x150
	private Texture2D _materialBaseTexture; // 0x158
	private float _lastWorldY; // 0x160
	private static readonly int MainTexTintFloor; // 0x70
	private List<Material> _allBodyPartMaterials; // 0x168
	private ActorMoverState _moverState; // 0x170
	private CharacterController _moverCharController; // 0x178
	private bool _moverCharControllerChecked; // 0x180
	private Dictionary<string, bool> _moverAnimatorHasParamDict; // 0x188
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Vector3 <MoverMoveInputVector>k__BackingField; // 0x190
	private Quaternion _moverLastRotation; // 0x19C
	private Vector3? _moverLastPosition; // 0x1AC
	private float _moverCurrentPitch; // 0x1BC
	private float _moverNoMoveTimer; // 0x1C0
	private float _moverAnimationSpeedPercent; // 0x1C4
	private float _swimmingRootHeight; // 0x1C8
	private ControllerColliderHit _moverLastControllerHit; // 0x1D0
	private CollideFX _lastCollideFX; // 0x1D8
	protected bool _moverIsGrounded; // 0x1E0
	protected bool _moverLastIsGrounded; // 0x1E1
	protected bool _moverIsSliding; // 0x1E2
	protected RaycastHit _moverGroundHit; // 0x1E4
	protected bool _moverReadyToJump; // 0x210
	protected float _moverDesiredSpeed; // 0x214
	protected float _moverCurrentSpeed; // 0x218
	protected Vector3 _moverMovementVector; // 0x21C
	protected float _moverCurrentVerticalVelocity; // 0x228
	protected float _moverCurrentTurnRotation; // 0x22C
	protected float _moverCurrentJumpForce; // 0x230
	protected Quaternion _moverTargetRotation; // 0x234
	protected float _moverTargetRotationAngleDiff; // 0x244
	protected float _moverCurrentOffsetRotationSmoothDampVelocity; // 0x248
	private const float _moverAirborneTurnSpeedProportion = 5.4f; // Metadata: 0x0077CC14
	private const float _moverGroundedRayDistance = 1f; // Metadata: 0x0077CC18
	private const float _moverMinEnemyDotCoeff = 0.2f; // Metadata: 0x0077CC1C
	private const float _moverInverseOneEighty = 0.0055555557f; // Metadata: 0x0077CC20
	private const float _moverStickingGravityProportion = 0.3f; // Metadata: 0x0077CC24
	private const float _moverGroundAcceleration = 30f; // Metadata: 0x0077CC28
	private const float _moverGroundDeceleration = 20f; // Metadata: 0x0077CC2C
	private const float _moverTurnAcceleration = 100f; // Metadata: 0x0077CC30
	private Transform _rotateTransform; // 0x250
	private static bool _autoRun; // 0x74
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float <MoverVelocityMagnitude>k__BackingField; // 0x258
	private List<Vector3> _raycastPositions; // 0x260
	private List<RaycastHit> _raycastHits; // 0x268
	private float _moverTargetTurnBlend; // 0x270
	private float _moverMaxTurnAngle; // 0x274
	private float _moverTurnBlend; // 0x278
	private float _moverLastTurnAngle; // 0x27C
	private float _moverIdleTimer; // 0x280
	private float _moverSleepTimer; // 0x284
	private bool _moverLastSwimmingAudio; // 0x288
	private bool _moverFlying; // 0x289
	private Vector3? _moverLastGoodPosition; // 0x28C
	private Quaternion? _moverLastGoodRotation; // 0x29C
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private ActorActionType <MoverLastGoodActionType>k__BackingField; // 0x2B0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WorldObjectMoverNodeType <MoverLastGoodNodeType>k__BackingField; // 0x2B4
	private bool _moverSwimming; // 0x2B8
	private bool _moverCanDive; // 0x2B9
	private float _waterDepth; // 0x2BC
	private bool _moverWaterDiving; // 0x2C0
	private float _moverMaxSwimDepth; // 0x2C4
	private float _moverDiveDepth; // 0x2C8
	private static readonly int Speed; // 0x78
	private static readonly int DirectionX; // 0x7C
	[Header] // 0x00000001801EFF40-0x00000001801EFF90
	[SerializeField] // 0x00000001801EFF40-0x00000001801EFF90
	private DynamicAssetQualityLevel _shaderQuality; // 0x2D0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private DynamicAssetQualityLevel _textureQuality; // 0x2D8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private DynamicAssetQualityLevel _meshQuality; // 0x2E0
	[Header] // 0x00000001801F0620-0x00000001801F0670
	[SerializeField] // 0x00000001801F0620-0x00000001801F0670
	private bool _ignoreClassDefScale; // 0x2E8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private ActorCombineType _combineType; // 0x2EC
	[SerializeField] // 0x00000001801F0B30-0x00000001801F0B70
	[Space] // 0x00000001801F0B30-0x00000001801F0B70
	private bool _applySilhouette; // 0x2F0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color32 silhouetteColor; // 0x2F4
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Outline.Mode silhouetteMode; // 0x2F8
	[Header] // 0x00000001801F10F0-0x00000001801F1140
	[SerializeField] // 0x00000001801F10F0-0x00000001801F1140
	private ActorMoverNavType _moverNavType; // 0x2FC
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _moverEnableTransformVelocityAnimation; // 0x300
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _moverMaxSpeed; // 0x304
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _moverMaxSpeedRunning; // 0x308
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _moverStickToGround; // 0x30C
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _moverGravity; // 0x310
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _moverJumpForce; // 0x314
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _useFSpineAnimator; // 0x318
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _useFTailAnimator; // 0x319
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _useIdleBreaks; // 0x31A
	public bool _doCameraRelativeInput; // 0x31B
	[Header] // 0x00000001801F3500-0x00000001801F3560
	[SerializeField] // 0x00000001801F3500-0x00000001801F3560
	[Space] // 0x00000001801F3500-0x00000001801F3560
	private bool _useBubble; // 0x31C
	private static QRoutineGroup _actorQRoutineMainGroup; // 0x80
	private static QRoutineGroup _actorAssetsQRoutineGroup; // 0x88
	private QRoutineGroup _actorBodyQRoutineGroup; // 0x320
	private QRoutineGroup _actorClothingQRoutineGroup; // 0x328
	private Dictionary<ActorInfoDirtyType, bool> _dirtyTypes; // 0x330
	[NonSerialized]
	private bool _isRefreshingDirty; // 0x338
	private QRoutine _refreshDirtyUpdateCheckRoutine; // 0x340
	private QRoutine _refreshDirtyRoutine; // 0x348
	public Action<ActorBase> OnSkeletonsRefreshed; // 0x350
	private GameObject _bodySkeletonObject; // 0x358
	private GameObject _wingSkeletonObject; // 0x360
	private Dictionary<string, ActorBoneInfo> _bodySkeletonMap; // 0x368
	private Transform _bodySkeletonRootJoint; // 0x370
	private Transform _bodySkeletonGameNodeJoint; // 0x378
	private Dictionary<string, ActorBoneInfo> _wingSkeletonMap; // 0x380
	private Transform _wingSkeletonRootJoint; // 0x388
	private Transform _wingSkeletonGameNodeJoint; // 0x390
	private Transform _cameraLookBody; // 0x398
	private Transform _cameraLookTail; // 0x3A0
	private Transform _cameraLookHead; // 0x3A8
	private ActorBaseDataObject _actorData; // 0x3B0
	private List<Outline> _silhouettes; // 0x3B8
	private Color32 _lastAppliedSilhouetteColor; // 0x3C0
	private Outline.Mode _lastAppliedSilhouetteMode; // 0x3C4
	protected float _deltaTime; // 0x3C8
	private ActorBuildState _buildState; // 0x3CC
	private float _bodyScale; // 0x3D0
	private float _offsetTransformYOffset; // 0x3D4
	[NonSerialized]
	private Transform _offsetTransform; // 0x3D8
	[NonSerialized]
	private Transform _bodyTransform; // 0x3E0
	private bool _lastMeshesAreVisible; // 0x3E8

	// Properties
	public Animator BodyAnimator { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180431310-0x0000000180431320 0x0000000180479500-0x0000000180479510
	public Animator WingAnimator { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x000000018067DD20-0x000000018067DD30 0x000000018067E630-0x000000018067E640
	public List<Animator> Animators { get; } // 0x0000000182173110-0x0000000182173400 
	public static List<string> AdditiveAnimationParameterNames { get; } // 0x00000001821725F0-0x00000001821728B0 
	public bool AnimationInAction { get; } // 0x0000000182172D00-0x0000000182172DE0 
	public bool AnimationInFalling { get; } // 0x0000000182172DE0-0x0000000182172EF0 
	public bool AnimationInJumping { get; } // 0x0000000182172EF0-0x0000000182173000 
	public bool AnimationInSwimming { get; } // 0x0000000182173000-0x0000000182173110 
	public List<ActorBodyPart> AttachedBodyParts { get; } // 0x000000018057C4E0-0x000000018057C4F0 
	public ActorBodyPart HeadBodyPart { get; } // 0x00000001821737B0-0x0000000182173810 
	public ActorBodyPart BodyBodyPart { get; } // 0x0000000182173410-0x0000000182173470 
	private bool NeedsRefreshSharedInstances { get; } // 0x00000001821743D0-0x0000000182174590 
	private static Material MaskedBlitMat { get; } // 0x0000000182173CD0-0x0000000182173E00 
	private static Material StandardBlitMat { get; } // 0x0000000182174930-0x0000000182174A60 
	public SkinnedMeshRenderer CombinedBodyPartsRenderer { get; } // 0x0000000180380B50-0x0000000180380B60 
	public UI_ActorBubble Bubble { get; } // 0x00000001803916B0-0x00000001803916C0 
	public ActorClothingBuildState ClothingBuildState { get; } // 0x0000000182173730-0x0000000182173760 
	public List<AttachedClothingItem> AttachedClothingItems { get; } // 0x00000001803EF220-0x00000001803EF230 
	public List<Material> AllBodyPartMaterials { get; } // 0x00000001821728B0-0x0000000182172B80 
	public ActorMoverState MoverState { get; set; } // 0x0000000180652A50-0x0000000180652A60 0x0000000182174C10-0x0000000182174C20
	public CharacterController MoverCharController { get; } // 0x0000000182173EE0-0x0000000182173F80 
	public bool IsGrounded { get; } // 0x0000000182173970-0x0000000182173A10 
	public Vector3 MoverMoveInputVector { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000182174310-0x0000000182174330 0x0000000182174BE0-0x0000000182174C00
	private Vector2 MoverInputVector { get; } // 0x0000000182174090-0x0000000182174160 
	private bool MoverHasInputVector { get; } // 0x0000000182173FA0-0x0000000182174030 
	private bool MoverInputJump { get; } // 0x0000000182174030-0x0000000182174090 
	private Transform RotateTransform { get; } // 0x0000000182174780-0x0000000182174880 
	protected GameSettingsManager.ControlSetting ControlMode { get; } // 0x0000000182173760-0x00000001821737B0 
	public bool MoverDontAllowMovement { get; } // 0x0000000182173F80-0x0000000182173F90 
	public bool RunInput { get; } // 0x0000000182174880-0x0000000182174920 
	public bool WalkInput { get; } // 0x0000000182174AA0-0x0000000182174B00 
	public float MoverMaxSpeed { get; } // 0x00000001821741A0-0x0000000182174310 
	public float MoverVelocityMagnitude { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000181F5F460-0x0000000181F5F470 0x0000000182174C20-0x0000000182174C30
	public float MoverVelocityMaxSpeedPercent { get; } // 0x0000000182174350-0x00000001821743D0 
	public Quaternion? MoverLastGoodRotation { get; } // 0x0000000182174180-0x00000001821741A0 
	public ActorActionType MoverLastGoodActionType { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000182174160-0x0000000182174170 0x0000000182174BC0-0x0000000182174BD0
	public WorldObjectMoverNodeType MoverLastGoodNodeType { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000182174170-0x0000000182174180 0x0000000182174BD0-0x0000000182174BE0
	public bool MoverSwimming { get; } // 0x0000000182174340-0x0000000182174350 
	public DynamicAssetQualityLevel ShaderQuality { get; } // 0x0000000182174920-0x0000000182174930 
	public DynamicAssetQualityLevel TextureQuality { get; } // 0x0000000182174A60-0x0000000182174A70 
	public DynamicAssetQualityLevel MeshQuality { get; } // 0x0000000182173E00-0x0000000182173E10 
	public ActorCombineType CombineType { get; } // 0x000000018037DDC0-0x000000018037DDD0 
	public bool ApplySilhouette { get; } // 0x0000000182173400-0x0000000182173410 
	public ActorMoverNavType MoverNavType { get; set; } // 0x0000000182174330-0x0000000182174340 0x0000000182174C00-0x0000000182174C10
	public float MoverGravity { get; } // 0x0000000182173F90-0x0000000182173FA0 
	public float MoverJumpForce { get; } // 0x00000001805CB900-0x00000001805CB910 
	public bool UseFSpineAnimator { get; } // 0x0000000182174A70-0x0000000182174A80 
	public bool UseFTailAnimator { get; } // 0x0000000182174A80-0x0000000182174A90 
	public bool UseIdleBreaks { get; set; } // 0x0000000182174A90-0x0000000182174AA0 0x0000000182174C60-0x0000000182174C70
	public bool UseBubble { set; } // 0x0000000182174C50-0x0000000182174C60
	public bool SetStickToGround { set; } // 0x0000000182174C40-0x0000000182174C50
	public static QRoutineGroup ActorQRoutineMainGroup { get; } // 0x0000000182172480-0x00000001821725F0 
	public static QRoutineGroup ActorAssetsQRoutineGroup { get; } // 0x0000000182171D40-0x0000000182171FD0 
	public QRoutineGroup ActorInstanceBodyQRoutineGroup { get; } // 0x0000000182171FD0-0x0000000182172230 
	public QRoutineGroup ActorInstanceClothingQRoutineGroup { get; } // 0x0000000182172230-0x0000000182172480 
	public bool IsRefreshingDirty { get; set; } // 0x0000000182173AF0-0x0000000182173B00 0x0000000182174BB0-0x0000000182174BC0
	public bool IsAnyDirty { get; } // 0x0000000182173810-0x0000000182173970 
	public List<ActorInfoDirtyType> AllDirty { get; } // 0x0000000182172B80-0x0000000182172D00 
	private Dictionary<string, ActorBoneInfo> BodySkeletonMap { get; } // 0x00000001805CC0C0-0x00000001805CC0D0 
	private Transform BodySkeletonRootJoint { get; } // 0x0000000182173490-0x00000001821734A0 
	private Transform BodySkeletonGameNodeJoint { get; } // 0x0000000182173480-0x0000000182173490 
	private Dictionary<string, ActorBoneInfo> WingSkeletonMap { get; } // 0x0000000182174B00-0x0000000182174B10 
	private Transform WingSkeletonRootJoint { get; } // 0x0000000182174B10-0x0000000182174B20 
	private Transform WingSkeletonGameNodeJoint { get; } // 0x00000001805CB970-0x00000001805CB980 
	public Transform CameraLookBody { get; } // 0x00000001821736C0-0x00000001821736D0 
	public Transform CameraLookTail { get; } // 0x00000001821736E0-0x00000001821736F0 
	public Transform CameraLookHead { get; } // 0x00000001821736D0-0x00000001821736E0 
	public virtual string ActorName { get; } // 0x00000001808A3EB0-0x00000001808A3EC0 
	public ActorClassDefComponent ClassDef { get; } // 0x00000001821736F0-0x0000000182173730 
	public bool IsLocal { get; } // 0x0000000182173A10-0x0000000182173A80 
	public bool IsNetwork { get; } // 0x0000000182173A80-0x0000000182173AF0 
	public ActorBuildState BuildState { get; set; } // 0x00000001821736B0-0x00000001821736C0 0x0000000182174BA0-0x0000000182174BB0
	public float BodyScale { get; set; } // 0x0000000182173470-0x0000000182173480 0x0000000182174B20-0x0000000182174BA0
	public float OffsetTransformYOffset { get; set; } // 0x0000000182174590-0x00000001821745A0 0x0000000182174C30-0x0000000182174C40
	public Transform OffsetTransform { get; } // 0x00000001821745A0-0x0000000182174780 
	public Transform BodyTransform { get; } // 0x00000001821734A0-0x00000001821736A0 
	public bool IsVisible { get; } // 0x0000000182173B00-0x0000000182173CD0 
	public bool MeshesAreVisible { get; } // 0x0000000182173E10-0x0000000182173EE0 
	public override QRoutineGroup BuildQRoutineGroup { get; } // 0x00000001821736A0-0x00000001821736B0 

	// Nested types
	private class AnimatorLayerTransitionInfo // TypeDefIndex: 11471
	{
		// Fields
		public int layer; // 0x10
		public bool visibility; // 0x14
		public float duration; // 0x18
		public float time; // 0x1C

		// Constructors
		public AnimatorLayerTransitionInfo(int inLayer, bool inVisibility, float inDuration, float inTime = 0f /* Metadata: 0x0077CC34 */); // 0x00000001821E0420-0x00000001821E0480
	}

	private class ActorBodyPartInstantiatedDecal // TypeDefIndex: 11472
	{
		// Fields
		public ActorInfoDecalEntry decalEntry; // 0x10
		public string lastRefreshedDefID; // 0x18
		public GameObject sprite; // 0x20
		public GameObject outlineSprite; // 0x28
		public GameObject mirrorSprite; // 0x30
		public GameObject mirrorOutlineSprite; // 0x38

		// Constructors
		public ActorBodyPartInstantiatedDecal(); // 0x0000000180373240-0x0000000180373250
	}

	private class ActorBodyPartInstantiatedEyeDecal // TypeDefIndex: 11473
	{
		// Fields
		public ActorInfoDecalEntry decalEntry; // 0x10
		public GameObject shapeSprite; // 0x18
		public GameObject shapeClipSprite; // 0x20
		public GameObject shapeBlinkSprite; // 0x28
		public GameObject pupilSprite; // 0x30
		public GameObject mirrorShapeSprite; // 0x38
		public GameObject mirrorShapeClipSprite; // 0x40
		public GameObject mirrorShapeBlinkSprite; // 0x48
		public GameObject mirrorPupilSprite; // 0x50

		// Constructors
		public ActorBodyPartInstantiatedEyeDecal(); // 0x0000000180373240-0x0000000180373250
	}

	[Serializable]
	public class ActorBodyPart // TypeDefIndex: 11474
	{
		// Fields
		public ActorBase parentActorBase; // 0x10
		public ActorInfoBodyPart bodyPartInfo; // 0x18
		public ActorInfoBodyPart lastBodyPartInfo; // 0x20
		public ActorBodyPartNodeDefComponent bodyPartNode; // 0x28
		public ActorBaseBodyPartDataObject bodyPartData; // 0x30
		public bool combined; // 0x38
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <IsBuilding>k__BackingField; // 0x39
		public bool initedJointMatching; // 0x3A
		public bool initedAdditiveAnimations; // 0x3B
		public GameObject instanceObject; // 0x40
		public Transform instanceTransform; // 0x48
		public SkinnedMeshRenderer instanceRenderer; // 0x50
		public List<Material> instanceMaterials; // 0x58
		public GameObject attachmentInstanceObject; // 0x60
		public Mesh instanceMesh; // 0x68
		private Camera _decalCamera; // 0x70
		private int _decalRenderTextureRatio; // 0x78
		private RenderTexture _decalRenderTexture; // 0x80
		private GameObject _decalParentGroup; // 0x88
		private int _decalParentGroupXPos; // 0x90
		private Transform _decalEditorSpriteGroup; // 0x98
		private Transform _decalMainSpriteGroup; // 0xA0
		private Transform _decalDefaultMaskGroup; // 0xA8
		private List<Transform> _decalMaskGroups; // 0xB0
		private List<ActorBodyPartInstantiatedDecal> _decalsInstantiated; // 0xB8
		private Camera _eyeDecalCamera; // 0xC0
		private RenderTexture _eyeDecalRenderTexture; // 0xC8
		private RenderTexture _eyeDecalBlinkRenderTexture; // 0xD0
		private GameObject _eyeDecalParentGroup; // 0xD8
		private int _eyeDecalParentGroupXPos; // 0xE0
		private Transform _eyeDecalSpriteGroup; // 0xE8
		private bool _eyeBlinkState; // 0xF0
		private float _eyeBlinkTimer; // 0xF4
		private List<ActorBodyPartInstantiatedEyeDecal> _eyeDecalsInstantiated; // 0xF8
		public Dictionary<string, ActorBoneInfo> skeletonMap; // 0x100
		private Transform _fxAttachNode; // 0x108

		// Properties
		public bool IsBuilding { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001804F1610-0x00000001804F1620 0x00000001804F1660-0x00000001804F1670
		public GameObject EyeDecalParentGroup { get; } // 0x00000001805CB740-0x00000001805CB750 
		public List<ActorInfoDecalEntry> DecalEntries { get; } // 0x000000018217ABB0-0x000000018217AC30 
		public List<ActorInfoDecalEntry> EyeDecalEntries { get; } // 0x000000018217AC30-0x000000018217AC60 
		public Transform FXAttachNode { get; } // 0x000000018217AC60-0x000000018217ADB0 

		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass53_0 // TypeDefIndex: 11475
		{
			// Fields
			public ActorBodyPart <>4__this; // 0x10
			public GameObject nInstanceObject; // 0x18

			// Constructors
			public <>c__DisplayClass53_0(); // 0x0000000180373240-0x0000000180373250

			// Methods
			internal void <InstantiateRoutine>b__0(ActorBaseBodyPartDataObject loadedAsset); // 0x00000001821EBE00-0x00000001821EBE20
			internal void <InstantiateRoutine>b__1(GameObject retObject); // 0x00000001821EBE20-0x00000001821EBE50
			internal void <InstantiateRoutine>b__2(GameObject loadedAsset); // 0x00000001815CA460-0x00000001815CA480
		}

		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <InstantiateRoutine>d__53 : IEnumerator<object> // TypeDefIndex: 11476
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public ActorBodyPart <>4__this; // 0x20
			private <>c__DisplayClass53_0 <>8__1; // 0x28
			private BundleDownloadCollection <bundleDownloadCollection>5__2; // 0x30
			private GameObject <oldInstanceObject>5__3; // 0x38
			private List<ActorBoneInfo> <oldSkeletonMap>5__4; // 0x40

			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <InstantiateRoutine>d__53(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001821E34B0-0x00000001821E4790
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001821E4790-0x00000001821E47E0
		}

		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass56_0 // TypeDefIndex: 11477
		{
			// Fields
			public Sprite cacheSprite; // 0x10

			// Constructors
			public <>c__DisplayClass56_0(); // 0x0000000180373240-0x0000000180373250

			// Methods
			internal void <InstantiateDecalSprite>b__0(Sprite loadedAsset); // 0x0000000180379F20-0x0000000180379F30
		}

		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass56_1 // TypeDefIndex: 11478
		{
			// Fields
			public Sprite cacheSprite; // 0x10

			// Constructors
			public <>c__DisplayClass56_1(); // 0x0000000180373240-0x0000000180373250

			// Methods
			internal void <InstantiateDecalSprite>b__1(Sprite loadedAsset); // 0x0000000180379F20-0x0000000180379F30
		}

		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <InstantiateDecalSprite>d__56 : IEnumerator<object> // TypeDefIndex: 11479
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public ActorBodyPartInstantiatedDecal inInstantiatedDecal; // 0x20
			private <>c__DisplayClass56_0 <>8__1; // 0x28
			public Material inMaterial; // 0x30
			public ActorBodyPart <>4__this; // 0x38
			private <>c__DisplayClass56_1 <>8__2; // 0x40
			private BaseDef <spriteDecalDef>5__2; // 0x48

			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <InstantiateDecalSprite>d__56(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001821E19C0-0x00000001821E23B0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001821E23B0-0x00000001821E2400
		}

		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <RefreshDecalsRoutine>d__59 : IEnumerator<object> // TypeDefIndex: 11480
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public ActorBodyPart <>4__this; // 0x20

			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <RefreshDecalsRoutine>d__59(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001821E47E0-0x00000001821E4F40
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001821E4F40-0x00000001821E4F90
		}

		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass62_0 // TypeDefIndex: 11481
		{
			// Fields
			public Sprite nEyeShapeSprite; // 0x10
			public Sprite nEyeShapeBlinkSprite; // 0x18
			public Sprite nEyeShapeClipSprite; // 0x20

			// Constructors
			public <>c__DisplayClass62_0(); // 0x0000000180373240-0x0000000180373250

			// Methods
			internal void <RefreshEyeDecals>b__0(Sprite loadedAsset); // 0x0000000180379F20-0x0000000180379F30
			internal void <RefreshEyeDecals>b__1(Sprite loadedAsset); // 0x0000000180379F30-0x0000000180379F40
			internal void <RefreshEyeDecals>b__2(Sprite loadedAsset); // 0x00000001803F70C0-0x00000001803F70D0
		}

		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass62_1 // TypeDefIndex: 11482
		{
			// Fields
			public Sprite nEyePupilSprite; // 0x10

			// Constructors
			public <>c__DisplayClass62_1(); // 0x0000000180373240-0x0000000180373250

			// Methods
			internal void <RefreshEyeDecals>b__3(Sprite loadedAsset); // 0x0000000180379F20-0x0000000180379F30
		}

		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <RefreshEyeDecals>d__62 : IEnumerator<object> // TypeDefIndex: 11483
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public ActorBodyPart <>4__this; // 0x20
			private <>c__DisplayClass62_0 <>8__1; // 0x28
			private <>c__DisplayClass62_1 <>8__2; // 0x30
			private BaseDef <eyeShapeDecalDef>5__2; // 0x38

			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <RefreshEyeDecals>d__62(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001821E4F90-0x00000001821EB7A0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001821EB7A0-0x00000001821EB7F0
		}

		// Constructors
		public ActorBodyPart(); // 0x000000018217AAA0-0x000000018217ABB0

		// Methods
		public void MUpdate(); // 0x0000000182177340-0x00000001821776D0
		public void Destroy(GameObject inInstanceObjectOverride = null, List<ActorBoneInfo> inSkeletonMapOverride = null); // 0x0000000182175F60-0x00000001821763F0
		public void UpdateAdditiveAnimations(); // 0x000000018217A700-0x000000018217AAA0
		public void DeinitAdditiveAnimations(); // 0x00000001803774A0-0x00000001803774B0
		public void ApplyColorsFromParentInfo(); // 0x0000000182175200-0x0000000182175840
		public void ApplyColors(HSVColor inColor1, HSVColor inColor2, HSVColor inColor3, HSVColor inColor4); // 0x0000000182175840-0x0000000182175AC0
		[IteratorStateMachine] // 0x00000001801FB190-0x00000001801FB1E0
		public IEnumerator InstantiateRoutine(); // 0x00000001821772D0-0x0000000182177340
		public void DestroyDecalSystem(); // 0x0000000182175AC0-0x0000000182175BD0
		private void InitDecalSystem(); // 0x0000000182176490-0x0000000182176AC0
		[IteratorStateMachine] // 0x00000001801FB400-0x00000001801FB450
		private IEnumerator InstantiateDecalSprite(ActorBodyPartInstantiatedDecal inInstantiatedDecal, Material inMaterial); // 0x0000000182177240-0x00000001821772D0
		public void RefreshDecalsPreRoutine(); // 0x0000000182179CB0-0x000000018217A620
		public void RefreshDecalsPostRoutine(); // 0x00000001821776D0-0x0000000182179CB0
		[IteratorStateMachine] // 0x00000001801FB690-0x00000001801FB6E0
		public IEnumerator RefreshDecalsRoutine(); // 0x000000018217A620-0x000000018217A690
		private void InitEyeDecalSystem(); // 0x0000000182176AC0-0x0000000182177240
		private void DestroyEyeDecalSystem(bool inDestroyRenderTex); // 0x0000000182175BD0-0x0000000182175F60
		[IteratorStateMachine] // 0x00000001801FCCD0-0x00000001801FCD20
		public IEnumerator RefreshEyeDecals(); // 0x000000018217A690-0x000000018217A700
		private void AddJointsToSkeletonMap(Transform inRootJoint, Transform inParentJoint, HashSet<string> inSkinnedBones); // 0x0000000182174C70-0x0000000182175200
		public Transform GetSkeletonJointTransform(string inName); // 0x00000001821763F0-0x0000000182176490
	}

	[Serializable]
	public class AttachedClothingItem // TypeDefIndex: 11484
	{
		// Fields
		public ActorBase parentActorBase; // 0x10
		public ActorInfoClothingItem clothingItemInfo; // 0x18
		public ActorClothingDefComponent clothingDefComponent; // 0x20
		public ActorAttachNodeDefComponent attachNode; // 0x28
		public bool combined; // 0x30
		public GameObject instanceObject; // 0x38
		public Transform instanceTransform; // 0x40
		public Mesh instanceMesh; // 0x48
		public Renderer instanceRenderer; // 0x50
		public Material instanceMaterial; // 0x58
		private Texture2D _baseTexture; // 0x60
		private Texture2D _baseColorIDTexture; // 0x68
		public GameObject attachmentInstanceObject; // 0x70
		public Dictionary<string, ActorBoneInfo> skeletonMap; // 0x78

		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass18_0 // TypeDefIndex: 11485
		{
			// Fields
			public GameObject nInstanceObject; // 0x10

			// Constructors
			public <>c__DisplayClass18_0(); // 0x0000000180373240-0x0000000180373250

			// Methods
			internal void <InstantiateRoutine>b__0(GameObject retObject); // 0x0000000180379F20-0x0000000180379F30
		}

		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <InstantiateRoutine>d__18 : IEnumerator<object> // TypeDefIndex: 11486
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public AttachedClothingItem <>4__this; // 0x20
			private <>c__DisplayClass18_0 <>8__1; // 0x28

			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <InstantiateRoutine>d__18(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001821E2400-0x00000001821E3460
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001821E3460-0x00000001821E34B0
		}

		// Constructors
		public AttachedClothingItem(); // 0x00000001821E14E0-0x00000001821E1540

		// Methods
		public void Destroy(); // 0x00000001821E1000-0x00000001821E1260
		public void Instantiate(); // 0x00000001821E1350-0x00000001821E1480
		public void ApplyMaterialKeywords(); // 0x00000001821E0C90-0x00000001821E1000
		public void ApplyMaterialColors(); // 0x00000001821E0A10-0x00000001821E0C90
		[IteratorStateMachine] // 0x00000001801FFF20-0x00000001801FFF70
		private IEnumerator InstantiateRoutine(); // 0x00000001821E12F0-0x00000001821E1350
		private void AddJointsToSkeletonMap(Transform inRootJoint, Transform inParentJoint); // 0x00000001821E0480-0x00000001821E0A10
		public Transform GetSkeletonJointTransform(string inName); // 0x00000001821E1260-0x00000001821E12F0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <Instantiate>b__15_0(QRoutine inRoutine); // 0x00000001821E1480-0x00000001821E14E0
	}

	[Serializable]
	public struct ActorBoneInfo // TypeDefIndex: 11487
	{
		// Fields
		public Transform bone; // 0x00
		public Transform actorRoot; // 0x08
		public Vector3 initialPos; // 0x10
		public Quaternion initialRot; // 0x1C
		public Vector3 initialScale; // 0x2C

		// Constructors
		public ActorBoneInfo(Transform inTrans, Transform inActorRoot); // 0x000000018031EB90-0x00000001803289F0

		// Methods
		public Vector3 GetBoneLocalPosition(); // 0x000000018031E820-0x000000018031E8A0
		public Vector3 TransformPosition(Vector3 inLocalSpacePos); // 0x000000018031EA60-0x000000018031EAC0
		public Quaternion GetBoneLocalRotation(); // 0x000000018031E8A0-0x000000018031E9A0
		public Quaternion TransformRotation(Quaternion inLocalSpaceRotation); // 0x000000018031EAC0-0x000000018031EB90
		public Vector3 GetBoneScaleOffset(); // 0x000000018031E9A0-0x000000018031EA60
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <UpdateAnimationQueue>d__17 : IEnumerator<object> // TypeDefIndex: 11488
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <UpdateAnimationQueue>d__17(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018217FE40-0x0000000182180B90
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000182180B90-0x0000000182180BE0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <ActionCoroutine>d__47 : IEnumerator<object> // TypeDefIndex: 11489
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ActorBase <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <ActionCoroutine>d__47(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018217ADB0-0x000000018217B580
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018217B580-0x000000018217B5D0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <BuildBodyParts>d__75 : IEnumerator<object> // TypeDefIndex: 11490
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ActorBase <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <BuildBodyParts>d__75(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018217B620-0x000000018217B7A0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018217B7A0-0x000000018217B7F0
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 11491
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<Material> <>9__78_0; // 0x08
		public static Action<Material> <>9__78_1; // 0x10
		public static Action<Material> <>9__78_2; // 0x18

		// Constructors
		static <>c(); // 0x000000018217FDE0-0x000000018217FE40
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <RefreshSharedInstances>b__78_0(Material loadedObject); // 0x000000018217FC90-0x000000018217FCF0
		internal void <RefreshSharedInstances>b__78_1(Material loadedObject); // 0x000000018217FCF0-0x000000018217FD50
		internal void <RefreshSharedInstances>b__78_2(Material loadedObject); // 0x000000018217FD50-0x000000018217FDB0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <RefreshSharedInstances>d__78 : IEnumerator<object> // TypeDefIndex: 11492
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ActorBase <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <RefreshSharedInstances>d__78(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018217F340-0x000000018217F880
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018217F880-0x000000018217F8D0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <RefreshBodyParts>d__79 : IEnumerator<object> // TypeDefIndex: 11493
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ActorBase <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <RefreshBodyParts>d__79(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018217D840-0x000000018217DBD0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018217DBD0-0x000000018217DC20
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <SetBodyPartWithInfo>d__99 : IEnumerator<object> // TypeDefIndex: 11494
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ActorBase <>4__this; // 0x20
		public ActorBodyPartNodeDefComponent inBodyPartNode; // 0x28
		public ActorInfoBodyPart inInfo; // 0x30
		private ActorBodyPart <existingBodyPart>5__2; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <SetBodyPartWithInfo>d__99(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018217F8D0-0x000000018217FC40
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018217FC40-0x000000018217FC90
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <BuildBodyPartCombine>d__105 : IEnumerator<object> // TypeDefIndex: 11495
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ActorBase <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <BuildBodyPartCombine>d__105(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001803C5AF0-0x00000001803C5B00
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018217B5D0-0x000000018217B620
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <BuildBubble>d__112 : IEnumerator<object> // TypeDefIndex: 11496
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ActorBase <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <BuildBubble>d__112(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018217B7F0-0x000000018217B980
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018217B980-0x000000018217B9D0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <BuildClothing>d__119 : IEnumerator<object> // TypeDefIndex: 11497
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ActorBase <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <BuildClothing>d__119(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018217B9D0-0x000000018217BAE0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018217BAE0-0x000000018217BB30
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <RefreshClothing>d__120 : IEnumerator<object> // TypeDefIndex: 11498
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ActorBase <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <RefreshClothing>d__120(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018217DC20-0x000000018217E300
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018217E300-0x000000018217E350
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass144_0 // TypeDefIndex: 11499
	{
		// Fields
		public string defId; // 0x10

		// Constructors
		public <>c__DisplayClass144_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <InitJointScaling>b__0(BaseDef group); // 0x000000018217FDB0-0x000000018217FDE0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <RefreshDirtyUpdateCheckRoutine>d__362 : IEnumerator<object> // TypeDefIndex: 11500
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ActorBase <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <RefreshDirtyUpdateCheckRoutine>d__362(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018217F1B0-0x000000018217F2F0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018217F2F0-0x000000018217F340
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <RefreshDirtyRoutine>d__363 : IEnumerator<object> // TypeDefIndex: 11501
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ActorBase <>4__this; // 0x20
		private List<ActorInfoDirtyType> <allDirty>5__2; // 0x28
		private int <i>5__3; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <RefreshDirtyRoutine>d__363(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018217E350-0x000000018217F160
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018217F160-0x000000018217F1B0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <BuildSkeletons>d__394 : IEnumerator<object> // TypeDefIndex: 11502
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ActorBase <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <BuildSkeletons>d__394(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018217BB30-0x000000018217C6F0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018217C6F0-0x000000018217C740
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <Build>d__446 : IEnumerator<object> // TypeDefIndex: 11503
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ActorBase <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <Build>d__446(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018217C740-0x000000018217D7F0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018217D7F0-0x000000018217D840
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <WaitForBuildRoutine>d__450 : IEnumerator<object> // TypeDefIndex: 11504
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ActorBase <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <WaitForBuildRoutine>d__450(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000182180BE0-0x0000000182180C30
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000182180C30-0x0000000182180C80
	}

	// Constructors
	public ActorBase(); // 0x00000001821719B0-0x0000000182171D40
	static ActorBase(); // 0x0000000182171780-0x00000001821719B0

	// Methods
	[IteratorStateMachine] // 0x00000001801F4290-0x00000001801F42E0
	private static IEnumerator UpdateAnimationQueue(); // 0x00000001821714E0-0x0000000182171530
	private void RegisterForAnimationUpdate(); // 0x00000001821702E0-0x0000000182170490
	private void UnregisterForAnimationUpdate(); // 0x0000000182171370-0x0000000182171450
	private void InitAnimation(); // 0x0000000182168750-0x0000000182168C30
	private void MUpdateAnimation(); // 0x000000018216A3B0-0x000000018216AEB0
	public void AnimatorSetLayerVisibility(int inLayerIndex, bool inVisibility, float inDuration = 0.25f /* Metadata: 0x0077CBFD */); // 0x0000000182165EB0-0x0000000182166150
	public void AnimatorSetLayerVisibility(int[] inOnLayers, int[] inOffLayers, float inDuration = 0.25f /* Metadata: 0x0077CC01 */); // 0x0000000182166150-0x0000000182166240
	public void SetBool(string inTrigger, bool inValue); // 0x0000000182170AC0-0x0000000182170C30
	public void SetInt(string inTrigger, int inValue); // 0x0000000182170E70-0x0000000182170FE0
	public void BreakLoop(); // 0x0000000182166860-0x0000000182166880
	public void SetAction(ActorActionType inValue); // 0x0000000180556A20-0x0000000180556A30
	public void SetTrigger(string inTrigger); // 0x0000000182170FE0-0x0000000182171130
	public override void MOnEnable(); // 0x000000018216A300-0x000000018216A370
	[IteratorStateMachine] // 0x00000001801F46E0-0x00000001801F4730
	private IEnumerator ActionCoroutine(); // 0x0000000182164970-0x00000001821649D0
	public void AnimationIdleBreak01(bool notifyMover = true /* Metadata: 0x0077CC05 */); // 0x0000000182165C40-0x0000000182165C80
	public void AnimationIdleBreak02(bool notifyMover = true /* Metadata: 0x0077CC06 */); // 0x0000000182165C80-0x0000000182165CC0
	public void AnimationIdleBreak03(bool notifyMover = true /* Metadata: 0x0077CC07 */); // 0x0000000182165CC0-0x0000000182165D00
	public void AnimationStartJump(bool notifyMover = true /* Metadata: 0x0077CC08 */); // 0x0000000182165E60-0x0000000182165EB0
	public void AnimationFinishLoop(bool notifyMover = true /* Metadata: 0x0077CC09 */); // 0x0000000182165BF0-0x0000000182165C40
	public void AnimationStartFall(bool notifyMover = true /* Metadata: 0x0077CC0A */); // 0x0000000182165E20-0x0000000182165E60
	public void AnimationDig(bool notifyMover = true /* Metadata: 0x0077CC0B */); // 0x0000000182165B30-0x0000000182165B70
	public void AnimationDizzy(bool notifyMover = true /* Metadata: 0x0077CC0C */); // 0x0000000182165BB0-0x0000000182165BF0
	public void AnimationDive(bool notifyMover = true /* Metadata: 0x0077CC0D */); // 0x0000000182165B70-0x0000000182165BB0
	public void AnimationSleep(bool notifyMover = true /* Metadata: 0x0077CC0E */); // 0x0000000182165D00-0x0000000182165E20
	public void AnimationBoolSwim(bool inValue, bool notifyMover = true /* Metadata: 0x0077CC0F */); // 0x0000000182165AE0-0x0000000182165B30
	public void AnimationBoolDecal(bool inValue); // 0x0000000182165A90-0x0000000182165AE0
	public void FreezeAnimation(bool inFreeze); // 0x00000001821676A0-0x0000000182167800
	private void MUpdateBodyParts(); // 0x000000018216AEB0-0x000000018216B070
	[IteratorStateMachine] // 0x00000001801F4940-0x00000001801F4990
	private IEnumerator BuildBodyParts(); // 0x00000001821668E0-0x0000000182166940
	[IteratorStateMachine] // 0x00000001801F4F30-0x00000001801F4F80
	private IEnumerator RefreshSharedInstances(); // 0x0000000182170140-0x00000001821701A0
	[IteratorStateMachine] // 0x00000001801F5240-0x00000001801F5290
	private IEnumerator RefreshBodyParts(); // 0x000000018216FC50-0x000000018216FCB0
	private void ClearBodyParts(); // 0x0000000182166C90-0x0000000182166D10
	private void DestroyBodyParts(); // 0x0000000182167150-0x00000001821672F0
	public ActorBodyPart GetAttachedBodyPartOfType(string inBodyPartNodeDefID); // 0x00000001821679D0-0x0000000182167AA0
	public ActorBodyPart GetAttachedBodyPartOfType(ActorBodyPartNodeDefComponent inBodyPartNode); // 0x0000000182167960-0x00000001821679D0
	[IteratorStateMachine] // 0x00000001801F5610-0x00000001801F5660
	public IEnumerator SetBodyPartWithInfo(ActorInfoBodyPart inInfo, ActorBodyPartNodeDefComponent inBodyPartNode); // 0x0000000182170A40-0x0000000182170AC0
	[IteratorStateMachine] // 0x00000001801F5960-0x00000001801F59B0
	private IEnumerator BuildBodyPartCombine(); // 0x0000000182166880-0x00000001821668E0
	private Vector2 GetAtlasOffsetLine(int inIndex, int inCount); // 0x0000000182167800-0x0000000182167840
	private Vector2 GetAtlasSizeSquare(int inCount); // 0x00000001821678E0-0x0000000182167960
	private Vector2 GetAtlasOffsetSquare(int inCount, int inIndex); // 0x0000000182167840-0x00000001821678E0
	[IteratorStateMachine] // 0x00000001801F5B40-0x00000001801F5B90
	private IEnumerator BuildBubble(); // 0x0000000182166940-0x00000001821669A0
	[IteratorStateMachine] // 0x00000001801F7100-0x00000001801F7150
	private IEnumerator BuildClothing(); // 0x00000001821669A0-0x0000000182166A00
	[IteratorStateMachine] // 0x00000001801F74D0-0x00000001801F7520
	private IEnumerator RefreshClothing(); // 0x000000018216FCB0-0x000000018216FD10
	private void ClearClothing(); // 0x0000000182166D10-0x0000000182166D80
	private void DestroyClothing(); // 0x00000001821672F0-0x0000000182167480
	public bool HasAttachedClothingItemWithDefID(string inClothingItemDefID); // 0x00000001821685A0-0x0000000182168750
	public AttachedClothingItem GetAttachedClothingItemWithItemDefID(string inClothingItemDefID); // 0x0000000182167CF0-0x0000000182167EA0
	public AttachedClothingItem GetAttachedClothingItemOnNode(BaseDef inAttachNode); // 0x0000000182167C90-0x0000000182167CF0
	public AttachedClothingItem GetAttachedClothingItemOnGroup(ActorAttachNodeGroupDefComponent inAttachNodeGroup); // 0x0000000182167AA0-0x0000000182167C90
	public void RemoveAttachedClothingItemOnNode(BaseDef inAttachNode); // 0x0000000182170660-0x00000001821706D0
	public void RemoveAttachedClothingItemOnGroup(BaseDef inAttachNodeGroup); // 0x0000000182170520-0x0000000182170660
	public void RemoveAttachedClothingItem(AttachedClothingItem inAttachedItem); // 0x00000001821706D0-0x0000000182170780
	public AttachedClothingItem AddAttachedClothingItemWithDefComponent(ActorClothingDefComponent inDefComponent); // 0x00000001821649D0-0x0000000182165010
	public void Log(string inLogMessage); // 0x00000001803774A0-0x00000001803774B0
	public void LogError(string inLogMessage); // 0x000000018216A210-0x000000018216A2C0
	private void InitFakeLighting(); // 0x0000000182168C30-0x0000000182168C40
	private void MUpdateFakeLighting(); // 0x000000018216B070-0x000000018216B080
	public void UpdateLighting(bool inForced); // 0x0000000182171530-0x00000001821716A0
	public void SetFakeLightColors(Color inMultColor, Color inAddColor); // 0x0000000182170CA0-0x0000000182170E70
	private void InitJointMatching(); // 0x0000000182168C40-0x00000001821691D0
	private void LateUpdateJointMatching(); // 0x0000000182169990-0x0000000182169EE0
	private void InitJointScaling(); // 0x00000001821691D0-0x0000000182169730
	public void LateUpdateJointScaling(); // 0x0000000182169EE0-0x000000018216A1D0
	public virtual void RegisterListeners(); // 0x0000000182170490-0x0000000182170520
	public virtual void UnregisterListeners(); // 0x0000000182171450-0x00000001821714E0
	private void BuildMaterial(); // 0x0000000182166A00-0x0000000182166B80
	private void RefreshMaterial(); // 0x000000018216FDD0-0x0000000182170050
	private void MUpdateMaterial(); // 0x000000018216B080-0x000000018216B2A0
	public void ApplyMaterialKeywords(); // 0x0000000182166360-0x0000000182166860
	public void ApplyMaterialBodyPartColors(); // 0x0000000182166240-0x0000000182166360
	private void BuildMover(); // 0x0000000182166B80-0x0000000182166BD0
	private bool FastHasParameter(string inParamName); // 0x00000001821675B0-0x00000001821676A0
	public void MoverReset(); // 0x000000018216F580-0x000000018216F680
	private void MUpdateMoverWater(); // 0x000000018216E530-0x000000018216EB60
	public void OnHarvestPointMessage(InteractablePointMessage inMessage); // 0x000000018216FA60-0x000000018216FC50
	private float MapClampAndRamp(float inValue, bool doRamp = true /* Metadata: 0x0077CC10 */); // 0x000000018216F2E0-0x000000018216F470
	private void MUpdateMover(); // 0x000000018216EB60-0x000000018216EE50
	private void OnControllerColliderHit(ControllerColliderHit inHit); // 0x000000018216F780-0x000000018216F8D0
	protected void MUpdateMoverIsGrounded(); // 0x000000018216CF80-0x000000018216D210
	protected override void MUpdateMoverNodeQueue(); // 0x000000018216E4F0-0x000000018216E530
	private void MUpdateMoverSmoothFollowTarget(); // 0x00000001803774A0-0x00000001803774B0
	protected override void HandleNodeType(WorldObjectMoverNode inNode); // 0x0000000182168370-0x00000001821685A0
	public override void Teleport(ObscuredVector3 inPosition, ObscuredQuaternion inRotation); // 0x0000000182171130-0x00000001821711A0
	protected void MUpdateMoverLocalCharacterController(); // 0x000000018216DC20-0x000000018216E4F0
	public void MoverFinishMouseOrbit(); // 0x00000001803774A0-0x00000001803774B0
	protected void MUpdateMoverLocalCharacterController_StandardMode(); // 0x000000018216D230-0x000000018216DC20
	protected virtual void MUpdateMoverLocalCharacterController_SimplifiedMode(); // 0x000000018216D210-0x000000018216D230
	public void DebugSetMoverMaxSpeed(float inSpeed, bool forRunning = false /* Metadata: 0x0077CC11 */); // 0x00000001803774A0-0x00000001803774B0
	private void MUpdateMoverAlignToGround(); // 0x000000018216B440-0x000000018216BF30
	private void MUpdateMoverAnimation(); // 0x000000018216BF30-0x000000018216CC00
	protected void MUpdateMoverAudio(); // 0x000000018216CC00-0x000000018216CF80
	protected void MoverResetNodeAndPositionData(); // 0x000000018216F470-0x000000018216F580
	protected void MoverSetNodeTypeAndDetails(WorldObjectMoverNodeType nodeType, ActorActionType actionType); // 0x000000018216F680-0x000000018216F780
	public void ExitLevelWithPos(Vector3 inPos); // 0x0000000182167590-0x00000001821675B0
	public void NavigateToPos(Vector3 inPos, float? inRotation = default); // 0x0000000180910E30-0x0000000180910E40
	public bool IsDirty(ActorInfoDirtyType inType); // 0x0000000182169930-0x0000000182169990
	public void SetDirty(ActorInfoDirtyType inType, bool inValue = true /* Metadata: 0x0077CC12 */); // 0x0000000182170C30-0x0000000182170CA0
	public void SetAllDirty(bool inValue = true /* Metadata: 0x0077CC13 */); // 0x00000001821707F0-0x0000000182170A40
	private void InitRefreshDirtyUpdateCheck(); // 0x0000000182169730-0x0000000182169820
	[IteratorStateMachine] // 0x00000001801F9670-0x00000001801F96C0
	private IEnumerator RefreshDirtyUpdateCheckRoutine(); // 0x000000018216FD70-0x000000018216FDD0
	[IteratorStateMachine] // 0x00000001801F98A0-0x00000001801F98F0
	private IEnumerator RefreshDirtyRoutine(); // 0x000000018216FD10-0x000000018216FD70
	[IteratorStateMachine] // 0x00000001801F9BB0-0x00000001801F9C00
	private IEnumerator BuildSkeletons(); // 0x0000000182166BD0-0x0000000182166C30
	private void RefreshSkeletons(); // 0x00000001821701A0-0x00000001821702E0
	private void ClearSkeletons(); // 0x0000000182166D80-0x0000000182166E10
	private void DestroySkeleton(); // 0x0000000182167480-0x0000000182167590
	private void AddJointsToBodySkeletonMap(Transform inParentJoint); // 0x0000000182165010-0x00000001821654A0
	private void AddJointsToWingSkeletonMap(Transform inParentJoint); // 0x00000001821654A0-0x0000000182165930
	public Transform GetSkeletonJointTransform(string inName); // 0x0000000182167FE0-0x0000000182168370
	public Transform GetJointTransformWithAttachNode(ActorAttachNodeDefComponent inAttachNode); // 0x0000000182167EA0-0x0000000182167FE0
	private void InitSurfaceFXNodes(); // 0x0000000182169820-0x0000000182169930
	private void AddSurfaceFXTerrainNodeToJoint(string inJointName); // 0x0000000182165930-0x00000001821659E0
	private void AddSurfaceFXWaterNodeToJoint(string inJointName); // 0x00000001821659E0-0x0000000182165A90
	public static ActorBase CreateActor(string inWorldObjectDefID, ActorInfo inInfo, Vector3 inPosition, Quaternion inRotation, Action<GameObject, ActorInfo> inFinishedCallback); // 0x0000000182167080-0x0000000182167150
	public ActorBase CreateActorClone(string inWorldObjectDefID, Vector3 inPosition, Quaternion inRotation, Action<GameObject, ActorInfo> inFinishedCallback); // 0x0000000182166E10-0x0000000182166F40
	public ActorBase CreateActorClone(Vector3 inPosition, Quaternion inRotation, Action<GameObject, ActorInfo> inFinishedCallback); // 0x0000000182166F40-0x0000000182167080
	private void RefreshRebuild(); // 0x0000000182170050-0x0000000182170140
	public override void MStart(); // 0x000000018216A370-0x000000018216A3B0
	public override void MOnDestroy(); // 0x000000018216A2C0-0x000000018216A300
	protected virtual void OnActorStart(); // 0x00000001803774A0-0x00000001803774B0
	protected virtual void OnActorDestroy(); // 0x00000001803774A0-0x00000001803774B0
	[IteratorStateMachine] // 0x00000001801F9F80-0x00000001801F9FD0
	public override IEnumerator Build(); // 0x0000000182166C30-0x0000000182166C90
	public QRoutine WaitForBuild(); // 0x0000000182171700-0x0000000182171780
	[IteratorStateMachine] // 0x00000001801FA360-0x00000001801FA3B0
	public IEnumerator WaitForBuildRoutine(); // 0x00000001821716A0-0x0000000182171700
	protected virtual void OnFinishedBuilding(); // 0x00000001803774A0-0x00000001803774B0
	public void SetActorLayer(); // 0x0000000182170780-0x00000001821707F0
	private void MUpdateOffsetTransform(); // 0x000000018216EE50-0x000000018216EF20
	private void MUpdateMeshVisibility(); // 0x000000018216B2A0-0x000000018216B440
	public override void MUpdate(); // 0x000000018216EF20-0x000000018216F2E0
	private void LateUpdate(); // 0x000000018216A1D0-0x000000018216A210
	private void UnBuild(); // 0x00000001821711E0-0x0000000182171370
	public override void OnDestroy(); // 0x000000018216F8D0-0x000000018216FA60
	private void OnValidate(); // 0x00000001803774A0-0x00000001803774B0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <BuildBubble>b__112_0(UI_ActorBubble loadedBubble); // 0x0000000180617A80-0x0000000180617A90
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <InitRefreshDirtyUpdateCheck>b__360_0(QRoutine inRoutine); // 0x00000001821711D0-0x00000001821711E0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <BuildSkeletons>b__394_0(GameObject loadedAsset); // 0x00000001821711A0-0x00000001821711B0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <BuildSkeletons>b__394_1(GameObject loadedAsset); // 0x00000001821711B0-0x00000001821711C0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Build>b__446_0(ActorBaseDataObject loadedAsset); // 0x00000001821711C0-0x00000001821711D0
}

