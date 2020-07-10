/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class ActorBase : WorldObjectMover<ActorInfo> // TypeDefIndex: 9979
{
	// Fields
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private Animator <BodyAnimator>k__BackingField; // 0xA8
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
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
	private ActorBaseDataObject _actorData; // 0x130
	private List<Outline> _silhouettes; // 0x138
	private Color32 _lastAppliedSilhouetteColor; // 0x140
	private Outline.Mode _lastAppliedSilhouetteMode; // 0x144
	protected float _deltaTime; // 0x148
	private ActorBuildState _buildState; // 0x14C
	private float _bodyScale; // 0x150
	private float _offsetTransformYOffset; // 0x154
	[NonSerialized]
	private Transform _offsetTransform; // 0x158
	[NonSerialized]
	private Transform _bodyTransform; // 0x160
	private bool _lastMeshesAreVisible; // 0x168
	private Color _lastFakeLightMultColor; // 0x16C
	private Color _lastFakeLightAddColor; // 0x17C
	private bool _failedWingJointMatching; // 0x18C
	private Texture2D _materialBaseTexture; // 0x190
	private float _lastWorldY; // 0x198
	private static readonly int MainTexTintFloor; // 0x70
	private List<Material> _allBodyPartMaterials; // 0x1A0
	private ActorMoverState _moverState; // 0x1A8
	private CharacterController _moverCharController; // 0x1B0
	private bool _moverCharControllerChecked; // 0x1B8
	private Dictionary<string, bool> _moverAnimatorHasParamDict; // 0x1C0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private Vector3 <MoverMoveInputVector>k__BackingField; // 0x1C8
	private Quaternion _moverLastRotation; // 0x1D4
	private Vector3? _moverLastPosition; // 0x1E4
	private float _moverCurrentPitch; // 0x1F4
	private float _moverNoMoveTimer; // 0x1F8
	private float _moverAnimationSpeedPercent; // 0x1FC
	private float _swimmingRootHeight; // 0x200
	private ControllerColliderHit _moverLastControllerHit; // 0x208
	private CollideFX _lastCollideFX; // 0x210
	protected bool _moverIsGrounded; // 0x218
	protected bool _moverLastIsGrounded; // 0x219
	protected bool _moverIsSliding; // 0x21A
	protected RaycastHit _moverGroundHit; // 0x21C
	protected bool _moverReadyToJump; // 0x248
	protected float _moverDesiredSpeed; // 0x24C
	protected float _moverCurrentSpeed; // 0x250
	protected Vector3 _moverMovementVector; // 0x254
	protected float _moverCurrentVerticalVelocity; // 0x260
	protected float _moverCurrentTurnRotation; // 0x264
	protected float _moverCurrentJumpForce; // 0x268
	protected Quaternion _moverTargetRotation; // 0x26C
	protected float _moverTargetRotationAngleDiff; // 0x27C
	protected float _moverCurrentOffsetRotationSmoothDampVelocity; // 0x280
	private const float _moverAirborneTurnSpeedProportion = 5.4f; // Metadata: 0x007467EE
	private const float _moverGroundedRayDistance = 1f; // Metadata: 0x007467F2
	private const float _moverMinEnemyDotCoeff = 0.2f; // Metadata: 0x007467F6
	private const float _moverInverseOneEighty = 0.0055555557f; // Metadata: 0x007467FA
	private const float _moverStickingGravityProportion = 0.3f; // Metadata: 0x007467FE
	private const float _moverGroundAcceleration = 30f; // Metadata: 0x00746802
	private const float _moverGroundDeceleration = 20f; // Metadata: 0x00746806
	private const float _moverTurnAcceleration = 100f; // Metadata: 0x0074680A
	private Transform _rotateTransform; // 0x288
	private static bool _autoRun; // 0x74
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private float <MoverVelocityMagnitude>k__BackingField; // 0x290
	private List<Vector3> _raycastPositions; // 0x298
	private List<RaycastHit> _raycastHits; // 0x2A0
	private float _moverTargetTurnBlend; // 0x2A8
	private float _moverMaxTurnAngle; // 0x2AC
	private float _moverTurnBlend; // 0x2B0
	private float _moverLastTurnAngle; // 0x2B4
	private float _moverIdleTimer; // 0x2B8
	private float _moverSleepTimer; // 0x2BC
	private bool _moverLastSwimmingAudio; // 0x2C0
	private bool _moverFlying; // 0x2C1
	private Vector3? _moverLastGoodPosition; // 0x2C4
	private Quaternion? _moverLastGoodRotation; // 0x2D4
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private ActorActionType <MoverLastGoodActionType>k__BackingField; // 0x2E8
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private WorldObjectMoverNodeType <MoverLastGoodNodeType>k__BackingField; // 0x2EC
	private bool _moverSwimming; // 0x2F0
	private bool _moverCanDive; // 0x2F1
	private float _waterDepth; // 0x2F4
	private bool _moverWaterDiving; // 0x2F8
	private float _moverMaxSwimDepth; // 0x2FC
	private float _moverDiveDepth; // 0x300
	private static readonly int Speed; // 0x78
	private static readonly int DirectionX; // 0x7C
	[Header] // 0x000000018011EBD0-0x000000018011EC20
	[SerializeField] // 0x000000018011EBD0-0x000000018011EC20
	private DynamicAssetQualityLevel _shaderQuality; // 0x308
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private DynamicAssetQualityLevel _textureQuality; // 0x310
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private DynamicAssetQualityLevel _meshQuality; // 0x318
	[Header] // 0x000000018011F0E0-0x000000018011F130
	[SerializeField] // 0x000000018011F0E0-0x000000018011F130
	private bool _ignoreClassDefScale; // 0x320
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private ActorCombineType _combineType; // 0x324
	[SerializeField] // 0x00000001800EDB90-0x00000001800EDBD0
	[Space] // 0x00000001800EDB90-0x00000001800EDBD0
	private bool _applySilhouette; // 0x328
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color32 silhouetteColor; // 0x32C
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Outline.Mode silhouetteMode; // 0x330
	[Header] // 0x000000018011FB90-0x000000018011FBE0
	[SerializeField] // 0x000000018011FB90-0x000000018011FBE0
	private ActorMoverNavType _moverNavType; // 0x334
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _moverEnableTransformVelocityAnimation; // 0x338
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _moverMaxSpeed; // 0x33C
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _moverMaxSpeedRunning; // 0x340
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _moverStickToGround; // 0x344
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _moverGravity; // 0x348
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _moverJumpForce; // 0x34C
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _useFSpineAnimator; // 0x350
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _useFTailAnimator; // 0x351
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _useIdleBreaks; // 0x352
	public bool _doCameraRelativeInput; // 0x353
	[Header] // 0x0000000180121F40-0x0000000180121FA0
	[SerializeField] // 0x0000000180121F40-0x0000000180121FA0
	[Space] // 0x0000000180121F40-0x0000000180121FA0
	private bool _useBubble; // 0x354
	private static QRoutineGroup _actorQRoutineMainGroup; // 0x80
	private static QRoutineGroup _actorAssetsQRoutineGroup; // 0x88
	private QRoutineGroup _actorBodyQRoutineGroup; // 0x358
	private QRoutineGroup _actorClothingQRoutineGroup; // 0x360
	private Dictionary<ActorInfoDirtyType, bool> _dirtyTypes; // 0x368
	[NonSerialized]
	private bool _isRefreshingDirty; // 0x370
	private QRoutine _refreshDirtyUpdateCheckRoutine; // 0x378
	private QRoutine _refreshDirtyRoutine; // 0x380
	public Action<ActorBase> OnSkeletonsRefreshed; // 0x388
	private GameObject _bodySkeletonObject; // 0x390
	private GameObject _wingSkeletonObject; // 0x398
	private Dictionary<string, ActorBoneInfo> _bodySkeletonMap; // 0x3A0
	private Transform _bodySkeletonRootJoint; // 0x3A8
	private Transform _bodySkeletonGameNodeJoint; // 0x3B0
	private Dictionary<string, ActorBoneInfo> _wingSkeletonMap; // 0x3B8
	private Transform _wingSkeletonRootJoint; // 0x3C0
	private Transform _wingSkeletonGameNodeJoint; // 0x3C8
	private Transform _cameraLookBody; // 0x3D0
	private Transform _cameraLookTail; // 0x3D8
	private Transform _cameraLookHead; // 0x3E0

	// Properties
	public Animator BodyAnimator { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180382A90-0x0000000180382AA0 0x00000001804A1230-0x00000001804A1240
	public Animator WingAnimator { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803ED9D0-0x00000001803ED9E0 0x00000001804A0A60-0x00000001804A0A70
	public List<Animator> Animators { get; } // 0x000000018123E090-0x000000018123E390 
	public static List<string> AdditiveAnimationParameterNames { get; } // 0x000000018123D540-0x000000018123D810 
	public bool AnimationInAction { get; } // 0x000000018123DC80-0x000000018123DD60 
	public bool AnimationInFalling { get; } // 0x000000018123DD60-0x000000018123DE70 
	public bool AnimationInJumping { get; } // 0x000000018123DE70-0x000000018123DF80 
	public bool AnimationInSwimming { get; } // 0x000000018123DF80-0x000000018123E090 
	public List<ActorBodyPart> AttachedBodyParts { get; } // 0x00000001804A0FC0-0x00000001804A0FD0 
	public ActorBodyPart HeadBodyPart { get; } // 0x000000018123E720-0x000000018123E780 
	public ActorBodyPart BodyBodyPart { get; } // 0x000000018123E390-0x000000018123E3F0 
	private bool NeedsRefreshSharedInstances { get; } // 0x000000018123F370-0x000000018123F530 
	private static Material MaskedBlitMat { get; } // 0x000000018123EC40-0x000000018123ED70 
	private static Material StandardBlitMat { get; } // 0x000000018123F950-0x000000018123FA80 
	public SkinnedMeshRenderer CombinedBodyPartsRenderer { get; } // 0x00000001803BD3C0-0x00000001803BD3D0 
	public UI_ActorBubble Bubble { get; } // 0x00000001803BD3A0-0x00000001803BD3B0 
	public ActorClothingBuildState ClothingBuildState { get; } // 0x000000018123E6A0-0x000000018123E6D0 
	public List<AttachedClothingItem> AttachedClothingItems { get; } // 0x00000001803BD3D0-0x00000001803BD3E0 
	public virtual string ActorName { get; } // 0x000000018123D3C0-0x000000018123D3D0 
	public ActorClassDefComponent ClassDef { get; } // 0x000000018123E660-0x000000018123E6A0 
	public bool IsLocal { get; } // 0x000000018123E990-0x000000018123EA00 
	public bool IsNetwork { get; } // 0x000000018123EA00-0x000000018123EA70 
	public ActorBuildState BuildState { get; set; } // 0x0000000180F83870-0x0000000180F83880 0x000000018123FBD0-0x000000018123FBE0
	public float BodyScale { get; set; } // 0x00000001810E2340-0x00000001810E2350 0x000000018123FB50-0x000000018123FBD0
	public float OffsetTransformYOffset { get; set; } // 0x000000018123F530-0x000000018123F540 0x000000018123FC60-0x000000018123FC70
	public Transform OffsetTransform { get; } // 0x000000018123F540-0x000000018123F720 
	public Transform BodyTransform { get; } // 0x000000018123E420-0x000000018123E620 
	public bool IsVisible { get; } // 0x000000018123EA70-0x000000018123EC40 
	public bool MeshesAreVisible { get; } // 0x000000018123ED80-0x000000018123EE50 
	public override QRoutineGroup BuildQRoutineGroup { get; } // 0x000000018123E620-0x000000018123E630 
	public List<Material> AllBodyPartMaterials { get; } // 0x000000018123D810-0x000000018123DAF0 
	public ActorMoverState MoverState { get; set; } // 0x000000018123F2C0-0x000000018123F2D0 0x000000018123FC40-0x000000018123FC50
	public CharacterController MoverCharController { get; } // 0x000000018123EE50-0x000000018123EEF0 
	public bool IsGrounded { get; } // 0x000000018123E8F0-0x000000018123E990 
	public Vector3 MoverMoveInputVector { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018123F290-0x000000018123F2B0 0x000000018123FC10-0x000000018123FC30
	private Vector2 MoverInputVector { get; } // 0x000000018123F010-0x000000018123F0E0 
	private bool MoverHasInputVector { get; } // 0x000000018123EF10-0x000000018123EFA0 
	private bool MoverInputJump { get; } // 0x000000018123EFA0-0x000000018123F010 
	private Transform RotateTransform { get; } // 0x000000018123F720-0x000000018123F820 
	protected GameSettingsManager.ControlSetting ControlMode { get; } // 0x000000018123E6D0-0x000000018123E720 
	public bool MoverDontAllowMovement { get; } // 0x000000018123EEF0-0x000000018123EF00 
	public bool RunInput { get; } // 0x000000018123F820-0x000000018123F950 
	public bool WalkInput { get; } // 0x000000018123FAB0-0x000000018123FB20 
	public float MoverMaxSpeed { get; } // 0x000000018123F120-0x000000018123F290 
	public float MoverVelocityMagnitude { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018123F2E0-0x000000018123F2F0 0x000000018123FC50-0x000000018123FC60
	public float MoverVelocityMaxSpeedPercent { get; } // 0x000000018123F2F0-0x000000018123F370 
	public Quaternion? MoverLastGoodRotation { get; } // 0x000000018123F100-0x000000018123F120 
	public ActorActionType MoverLastGoodActionType { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018123F0F0-0x000000018123F100 0x000000018123FBF0-0x000000018123FC00
	public WorldObjectMoverNodeType MoverLastGoodNodeType { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001811C6E50-0x00000001811C6E60 0x000000018123FC00-0x000000018123FC10
	public bool MoverSwimming { get; } // 0x000000018123F2D0-0x000000018123F2E0 
	public DynamicAssetQualityLevel ShaderQuality { get; } // 0x0000000180E365F0-0x0000000180E36600 
	public DynamicAssetQualityLevel TextureQuality { get; } // 0x0000000180E36600-0x0000000180E36610 
	public DynamicAssetQualityLevel MeshQuality { get; } // 0x000000018123ED70-0x000000018123ED80 
	public ActorCombineType CombineType { get; } // 0x00000001811C6950-0x00000001811C6960 
	public bool ApplySilhouette { get; } // 0x0000000180E36E50-0x0000000180E36E60 
	public ActorMoverNavType MoverNavType { get; set; } // 0x000000018123F2B0-0x000000018123F2C0 0x000000018123FC30-0x000000018123FC40
	public float MoverGravity { get; } // 0x000000018123EF00-0x000000018123EF10 
	public float MoverJumpForce { get; } // 0x000000018123F0E0-0x000000018123F0F0 
	public bool UseFSpineAnimator { get; } // 0x000000018123FA80-0x000000018123FA90 
	public bool UseFTailAnimator { get; } // 0x000000018123FA90-0x000000018123FAA0 
	public bool UseIdleBreaks { get; set; } // 0x000000018123FAA0-0x000000018123FAB0 0x000000018123FC90-0x000000018123FCA0
	public bool UseBubble { set; } // 0x000000018123FC80-0x000000018123FC90
	public bool SetStickToGround { set; } // 0x000000018123FC70-0x000000018123FC80
	public static QRoutineGroup ActorQRoutineMainGroup { get; } // 0x000000018123D3D0-0x000000018123D540 
	public static QRoutineGroup ActorAssetsQRoutineGroup { get; } // 0x000000018123CC70-0x000000018123CF00 
	public QRoutineGroup ActorInstanceBodyQRoutineGroup { get; } // 0x000000018123CF00-0x000000018123D160 
	public QRoutineGroup ActorInstanceClothingQRoutineGroup { get; } // 0x000000018123D160-0x000000018123D3C0 
	public bool IsRefreshingDirty { get; set; } // 0x00000001811C6A50-0x00000001811C6A60 0x000000018123FBE0-0x000000018123FBF0
	public bool IsAnyDirty { get; } // 0x000000018123E780-0x000000018123E8F0 
	public List<ActorInfoDirtyType> AllDirty { get; } // 0x000000018123DAF0-0x000000018123DC80 
	private Dictionary<string, ActorBoneInfo> BodySkeletonMap { get; } // 0x000000018123E400-0x000000018123E410 
	private Transform BodySkeletonRootJoint { get; } // 0x000000018123E410-0x000000018123E420 
	private Transform BodySkeletonGameNodeJoint { get; } // 0x000000018123E3F0-0x000000018123E400 
	private Dictionary<string, ActorBoneInfo> WingSkeletonMap { get; } // 0x000000018123FB30-0x000000018123FB40 
	private Transform WingSkeletonRootJoint { get; } // 0x000000018123FB40-0x000000018123FB50 
	private Transform WingSkeletonGameNodeJoint { get; } // 0x000000018123FB20-0x000000018123FB30 
	public Transform CameraLookBody { get; } // 0x000000018123E630-0x000000018123E640 
	public Transform CameraLookTail { get; } // 0x000000018123E650-0x000000018123E660 
	public Transform CameraLookHead { get; } // 0x000000018123E640-0x000000018123E650 

	// Nested types
	private class AnimatorLayerTransitionInfo // TypeDefIndex: 9980
	{
		// Fields
		public int layer; // 0x10
		public bool visibility; // 0x14
		public float duration; // 0x18
		public float time; // 0x1C

		// Constructors
		public AnimatorLayerTransitionInfo(int inLayer, bool inVisibility, float inDuration, float inTime = 0f /* Metadata: 0x0074680E */); // 0x0000000181410000-0x0000000181410060
	}

	private class ActorBodyPartInstantiatedDecal // TypeDefIndex: 9981
	{
		// Fields
		public ActorInfoDecalEntry decalEntry; // 0x10
		public string lastRefreshedDefID; // 0x18
		public GameObject sprite; // 0x20
		public GameObject outlineSprite; // 0x28
		public GameObject mirrorSprite; // 0x30
		public GameObject mirrorOutlineSprite; // 0x38

		// Constructors
		public ActorBodyPartInstantiatedDecal(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	private class ActorBodyPartInstantiatedEyeDecal // TypeDefIndex: 9982
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
		public ActorBodyPartInstantiatedEyeDecal(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[Serializable]
	public class ActorBodyPart // TypeDefIndex: 9983
	{
		// Fields
		public ActorBase parentActorBase; // 0x10
		public ActorInfoBodyPart bodyPartInfo; // 0x18
		public ActorInfoBodyPart lastBodyPartInfo; // 0x20
		public ActorBodyPartNodeDefComponent bodyPartNode; // 0x28
		public ActorBaseBodyPartDataObject bodyPartData; // 0x30
		public bool combined; // 0x38
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
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
		public bool IsBuilding { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001806EDE30-0x00000001806EDE40 0x0000000180DDE770-0x0000000180DDE780
		public GameObject EyeDecalParentGroup { get; } // 0x00000001804E9920-0x00000001804E9930 
		public List<ActorInfoDecalEntry> DecalEntries { get; } // 0x0000000181245DB0-0x0000000181245E40 
		public List<ActorInfoDecalEntry> EyeDecalEntries { get; } // 0x0000000181245E40-0x0000000181245E70 
		public Transform FXAttachNode { get; } // 0x0000000181245E70-0x0000000181245FC0 

		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass53_0 // TypeDefIndex: 9984
		{
			// Fields
			public ActorBodyPart <>4__this; // 0x10
			public GameObject nInstanceObject; // 0x18

			// Constructors
			public <>c__DisplayClass53_0(); // 0x000000018036B6C0-0x000000018036B6D0

			// Methods
			internal void <InstantiateRoutine>b__0(ActorBaseBodyPartDataObject loadedAsset); // 0x000000018141CEE0-0x000000018141CF00
			internal void <InstantiateRoutine>b__1(GameObject retObject); // 0x000000018141CF00-0x000000018141CF30
			internal void <InstantiateRoutine>b__2(GameObject loadedAsset); // 0x000000018141CF30-0x000000018141CF50
		}

		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <InstantiateRoutine>d__53 : IEnumerator<object> // TypeDefIndex: 9985
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <InstantiateRoutine>d__53(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181413DB0-0x00000001814150F0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001814150F0-0x0000000181415140
		}

		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass56_0 // TypeDefIndex: 9986
		{
			// Fields
			public Sprite cacheSprite; // 0x10

			// Constructors
			public <>c__DisplayClass56_0(); // 0x000000018036B6C0-0x000000018036B6D0

			// Methods
			internal void <InstantiateDecalSprite>b__0(Sprite loadedAsset); // 0x000000018036B1E0-0x000000018036B1F0
		}

		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass56_1 // TypeDefIndex: 9987
		{
			// Fields
			public Sprite cacheSprite; // 0x10

			// Constructors
			public <>c__DisplayClass56_1(); // 0x000000018036B6C0-0x000000018036B6D0

			// Methods
			internal void <InstantiateDecalSprite>b__1(Sprite loadedAsset); // 0x000000018036B1E0-0x000000018036B1F0
		}

		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <InstantiateDecalSprite>d__56 : IEnumerator<object> // TypeDefIndex: 9988
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <InstantiateDecalSprite>d__56(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181412410-0x0000000181412E40
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181412E40-0x0000000181412E90
		}

		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <RefreshDecalsRoutine>d__59 : IEnumerator<object> // TypeDefIndex: 9989
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public ActorBodyPart <>4__this; // 0x20

			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <RefreshDecalsRoutine>d__59(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181415140-0x00000001814158C0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001814158C0-0x0000000181415910
		}

		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass62_0 // TypeDefIndex: 9990
		{
			// Fields
			public Sprite nEyeShapeSprite; // 0x10
			public Sprite nEyeShapeBlinkSprite; // 0x18
			public Sprite nEyeShapeClipSprite; // 0x20

			// Constructors
			public <>c__DisplayClass62_0(); // 0x000000018036B6C0-0x000000018036B6D0

			// Methods
			internal void <RefreshEyeDecals>b__0(Sprite loadedAsset); // 0x000000018036B1E0-0x000000018036B1F0
			internal void <RefreshEyeDecals>b__1(Sprite loadedAsset); // 0x000000018038B160-0x000000018038B170
			internal void <RefreshEyeDecals>b__2(Sprite loadedAsset); // 0x000000018036AC90-0x000000018036ACA0
		}

		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass62_1 // TypeDefIndex: 9991
		{
			// Fields
			public Sprite nEyePupilSprite; // 0x10

			// Constructors
			public <>c__DisplayClass62_1(); // 0x000000018036B6C0-0x000000018036B6D0

			// Methods
			internal void <RefreshEyeDecals>b__3(Sprite loadedAsset); // 0x000000018036B1E0-0x000000018036B1F0
		}

		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <RefreshEyeDecals>d__62 : IEnumerator<object> // TypeDefIndex: 9992
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public ActorBodyPart <>4__this; // 0x20
			private <>c__DisplayClass62_0 <>8__1; // 0x28
			private <>c__DisplayClass62_1 <>8__2; // 0x30
			private BaseDef <eyeShapeDecalDef>5__2; // 0x38

			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <RefreshEyeDecals>d__62(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181415910-0x000000018141C330
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018141C330-0x000000018141C380
		}

		// Constructors
		public ActorBodyPart(); // 0x0000000181245CA0-0x0000000181245DB0

		// Methods
		public void MUpdate(); // 0x0000000181242430-0x00000001812427D0
		public void Destroy(GameObject inInstanceObjectOverride = null, List<ActorBoneInfo> inSkeletonMapOverride = null); // 0x0000000181241000-0x0000000181241490
		public void UpdateAdditiveAnimations(); // 0x00000001812458E0-0x0000000181245CA0
		public void DeinitAdditiveAnimations(); // 0x00000001803581E0-0x00000001803581F0
		public void ApplyColorsFromParentInfo(); // 0x0000000181240250-0x00000001812408E0
		public void ApplyColors(HSVColor inColor1, HSVColor inColor2, HSVColor inColor3, HSVColor inColor4); // 0x00000001812408E0-0x0000000181240B60
		[IteratorStateMachine] // 0x00000001801284B0-0x0000000180128500
		public IEnumerator InstantiateRoutine(); // 0x00000001812423C0-0x0000000181242430
		private void DestroyDecalSystem(); // 0x0000000181240B60-0x0000000181240C70
		private void InitDecalSystem(); // 0x0000000181241530-0x0000000181241B80
		[IteratorStateMachine] // 0x0000000180128660-0x00000001801286B0
		private IEnumerator InstantiateDecalSprite(ActorBodyPartInstantiatedDecal inInstantiatedDecal, Material inMaterial); // 0x0000000181242330-0x00000001812423C0
		public void RefreshDecalsPreRoutine(); // 0x0000000181244E60-0x0000000181245800
		public void RefreshDecalsPostRoutine(); // 0x00000001812427D0-0x0000000181244E60
		[IteratorStateMachine] // 0x0000000180128940-0x0000000180128990
		public IEnumerator RefreshDecalsRoutine(); // 0x0000000181245800-0x0000000181245870
		private void InitEyeDecalSystem(); // 0x0000000181241B80-0x0000000181242330
		private void DestroyEyeDecalSystem(bool inDestroyRenderTex); // 0x0000000181240C70-0x0000000181241000
		[IteratorStateMachine] // 0x0000000180128D10-0x0000000180128D60
		public IEnumerator RefreshEyeDecals(); // 0x0000000181245870-0x00000001812458E0
		private void AddJointsToSkeletonMap(Transform inRootJoint, Transform inParentJoint, HashSet<string> inSkinnedBones); // 0x000000018123FCA0-0x0000000181240250
		public Transform GetSkeletonJointTransform(string inName); // 0x0000000181241490-0x0000000181241530
	}

	[Serializable]
	public class AttachedClothingItem // TypeDefIndex: 9993
	{
		// Fields
		public ActorBase parentActorBase; // 0x10
		public ActorInfoClothingItem clothingItemInfo; // 0x18
		public ActorClothingDefComponent clothingDefComponent; // 0x20
		public ActorAttachNodeDefComponent attachNode; // 0x28
		public GameObject instanceObject; // 0x30
		public Transform instanceTransform; // 0x38
		public Renderer instanceRenderer; // 0x40
		public Material instanceMaterial; // 0x48
		private Texture2D _baseTexture; // 0x50
		private Texture2D _baseColorIDTexture; // 0x58
		public GameObject attachmentInstanceObject; // 0x60
		public Dictionary<string, ActorBoneInfo> skeletonMap; // 0x68

		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass16_0 // TypeDefIndex: 9994
		{
			// Fields
			public GameObject nInstanceObject; // 0x10

			// Constructors
			public <>c__DisplayClass16_0(); // 0x000000018036B6C0-0x000000018036B6D0

			// Methods
			internal void <InstantiateRoutine>b__0(GameObject retObject); // 0x000000018036B1E0-0x000000018036B1F0
		}

		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <InstantiateRoutine>d__16 : IEnumerator<object> // TypeDefIndex: 9995
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public AttachedClothingItem <>4__this; // 0x20
			private <>c__DisplayClass16_0 <>8__1; // 0x28

			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <InstantiateRoutine>d__16(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181412E90-0x0000000181413D60
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181413D60-0x0000000181413DB0
		}

		// Constructors
		public AttachedClothingItem(); // 0x0000000181411100-0x0000000181411160

		// Methods
		public void Destroy(); // 0x0000000181410C20-0x0000000181410E80
		public void Instantiate(); // 0x0000000181410F70-0x00000001814110A0
		public void ApplyMaterialKeywords(); // 0x00000001814108A0-0x0000000181410C20
		public void ApplyMaterialColors(); // 0x0000000181410610-0x00000001814108A0
		[IteratorStateMachine] // 0x000000018012CAE0-0x000000018012CB30
		private IEnumerator InstantiateRoutine(); // 0x0000000181410F10-0x0000000181410F70
		private void AddJointsToSkeletonMap(Transform inRootJoint, Transform inParentJoint); // 0x0000000181410060-0x0000000181410610
		public Transform GetSkeletonJointTransform(string inName); // 0x0000000181410E80-0x0000000181410F10
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void <Instantiate>b__13_0(QRoutine inRoutine); // 0x00000001814110A0-0x0000000181411100
	}

	[Serializable]
	public struct ActorBoneInfo // TypeDefIndex: 9996
	{
		// Fields
		public Transform bone; // 0x00
		public Transform actorRoot; // 0x08
		public Vector3 initialPos; // 0x10
		public Quaternion initialRot; // 0x1C
		public Vector3 initialScale; // 0x2C

		// Constructors
		public ActorBoneInfo(Transform inTrans, Transform inActorRoot); // 0x0000000180222A80-0x0000000180222AB0

		// Methods
		public Vector3 GetBoneLocalPosition(); // 0x0000000180222700-0x0000000180222780
		public Vector3 TransformPosition(Vector3 inLocalSpacePos); // 0x0000000180222950-0x00000001802229B0
		public Quaternion GetBoneLocalRotation(); // 0x0000000180222780-0x0000000180222880
		public Quaternion TransformRotation(Quaternion inLocalSpaceRotation); // 0x00000001802229B0-0x0000000180222A80
		public Vector3 GetBoneScaleOffset(); // 0x0000000180222880-0x0000000180222950
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <UpdateAnimationQueue>d__17 : IEnumerator<object> // TypeDefIndex: 9997
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <UpdateAnimationQueue>d__17(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x000000018124C840-0x000000018124D530
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x000000018124D530-0x000000018124D580
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <ActionCoroutine>d__47 : IEnumerator<object> // TypeDefIndex: 9998
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ActorBase <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <ActionCoroutine>d__47(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181245FC0-0x00000001812467C0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001812467C0-0x0000000181246810
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <BuildBodyParts>d__75 : IEnumerator<object> // TypeDefIndex: 9999
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ActorBase <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <BuildBodyParts>d__75(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181247F70-0x00000001812480F0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001812480F0-0x0000000181248140
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 10000
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<Material> <>9__78_0; // 0x08
		public static Action<Material> <>9__78_1; // 0x10
		public static Action<Material> <>9__78_2; // 0x18

		// Constructors
		static <>c(); // 0x000000018124C7E0-0x000000018124C840
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <RefreshSharedInstances>b__78_0(Material loadedObject); // 0x000000018124C690-0x000000018124C6F0
		internal void <RefreshSharedInstances>b__78_1(Material loadedObject); // 0x000000018124C6F0-0x000000018124C750
		internal void <RefreshSharedInstances>b__78_2(Material loadedObject); // 0x000000018124C750-0x000000018124C7B0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <RefreshSharedInstances>d__78 : IEnumerator<object> // TypeDefIndex: 10001
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ActorBase <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <RefreshSharedInstances>d__78(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x000000018124BD20-0x000000018124C270
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x000000018124C270-0x000000018124C2C0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <RefreshBodyParts>d__79 : IEnumerator<object> // TypeDefIndex: 10002
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ActorBase <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <RefreshBodyParts>d__79(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x000000018124A140-0x000000018124A4E0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x000000018124A4E0-0x000000018124A530
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <SetBodyPartWithInfo>d__99 : IEnumerator<object> // TypeDefIndex: 10003
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ActorBase <>4__this; // 0x20
		public ActorBodyPartNodeDefComponent inBodyPartNode; // 0x28
		public ActorInfoBodyPart inInfo; // 0x30
		private ActorBodyPart <existingBodyPart>5__2; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <SetBodyPartWithInfo>d__99(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x000000018124C2C0-0x000000018124C640
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x000000018124C640-0x000000018124C690
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <BuildBodyPartCombine>d__105 : IEnumerator<object> // TypeDefIndex: 10004
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ActorBase <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <BuildBodyPartCombine>d__105(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181246810-0x0000000181247F20
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181247F20-0x0000000181247F70
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <BuildBubble>d__111 : IEnumerator<object> // TypeDefIndex: 10005
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ActorBase <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <BuildBubble>d__111(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181248140-0x00000001812482E0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001812482E0-0x0000000181248330
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <BuildClothing>d__118 : IEnumerator<object> // TypeDefIndex: 10006
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ActorBase <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <BuildClothing>d__118(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181248330-0x0000000181248450
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181248450-0x00000001812484A0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <RefreshClothing>d__119 : IEnumerator<object> // TypeDefIndex: 10007
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ActorBase <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <RefreshClothing>d__119(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x000000018124A530-0x000000018124AC40
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x000000018124AC40-0x000000018124AC90
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <Build>d__172 : IEnumerator<object> // TypeDefIndex: 10008
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ActorBase <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <Build>d__172(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001812490E0-0x000000018124A0F0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x000000018124A0F0-0x000000018124A140
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <WaitForBuildRoutine>d__176 : IEnumerator<object> // TypeDefIndex: 10009
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ActorBase <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <WaitForBuildRoutine>d__176(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x000000018124D580-0x000000018124D5D0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x000000018124D5D0-0x000000018124D620
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass201_0 // TypeDefIndex: 10010
	{
		// Fields
		public string defId; // 0x10

		// Constructors
		public <>c__DisplayClass201_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <InitJointScaling>b__0(BaseDef group); // 0x000000018124C7B0-0x000000018124C7E0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <RefreshDirtyUpdateCheckRoutine>d__419 : IEnumerator<object> // TypeDefIndex: 10011
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ActorBase <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <RefreshDirtyUpdateCheckRoutine>d__419(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x000000018124BB50-0x000000018124BCD0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x000000018124BCD0-0x000000018124BD20
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <RefreshDirtyRoutine>d__420 : IEnumerator<object> // TypeDefIndex: 10012
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ActorBase <>4__this; // 0x20
		private List<ActorInfoDirtyType> <allDirty>5__2; // 0x28
		private int <i>5__3; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <RefreshDirtyRoutine>d__420(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x000000018124AC90-0x000000018124BB00
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x000000018124BB00-0x000000018124BB50
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <BuildSkeletons>d__451 : IEnumerator<object> // TypeDefIndex: 10013
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ActorBase <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <BuildSkeletons>d__451(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001812484A0-0x0000000181249090
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181249090-0x00000001812490E0
	}

	// Constructors
	public ActorBase(); // 0x000000018123C8E0-0x000000018123CC70
	static ActorBase(); // 0x000000018123C6B0-0x000000018123C8E0

	// Methods
	[IteratorStateMachine] // 0x0000000180122780-0x00000001801227D0
	private static IEnumerator UpdateAnimationQueue(); // 0x000000018123C410-0x000000018123C460
	private void RegisterForAnimationUpdate(); // 0x000000018123B220-0x000000018123B3E0
	private void UnregisterForAnimationUpdate(); // 0x000000018123C2A0-0x000000018123C380
	private void InitAnimation(); // 0x0000000181233580-0x0000000181233A80
	private void MUpdateAnimation(); // 0x0000000181235270-0x0000000181235DA0
	public void AnimatorSetLayerVisibility(int inLayerIndex, bool inVisibility, float inDuration = 0.25f /* Metadata: 0x007467D7 */); // 0x0000000181230C90-0x0000000181230F30
	public void AnimatorSetLayerVisibility(int[] inOnLayers, int[] inOffLayers, float inDuration = 0.25f /* Metadata: 0x007467DB */); // 0x0000000181230F30-0x0000000181231030
	public void SetBool(string inTrigger, bool inValue); // 0x000000018123BA10-0x000000018123BB80
	public void SetInt(string inTrigger, int inValue); // 0x000000018123BDD0-0x000000018123BF40
	public void BreakLoop(); // 0x00000001812316F0-0x0000000181231710
	public void SetAction(ActorActionType inValue); // 0x0000000180F44170-0x0000000180F44180
	public void SetTrigger(string inTrigger); // 0x000000018123BF40-0x000000018123C090
	public override void MOnEnable(); // 0x00000001812351C0-0x0000000181235230
	[IteratorStateMachine] // 0x0000000180122A30-0x0000000180122A80
	private IEnumerator ActionCoroutine(); // 0x000000018122F6F0-0x000000018122F750
	public void AnimationIdleBreak01(bool notifyMover = true /* Metadata: 0x007467DF */); // 0x0000000181230A20-0x0000000181230A60
	public void AnimationIdleBreak02(bool notifyMover = true /* Metadata: 0x007467E0 */); // 0x0000000181230A60-0x0000000181230AA0
	public void AnimationIdleBreak03(bool notifyMover = true /* Metadata: 0x007467E1 */); // 0x0000000181230AA0-0x0000000181230AE0
	public void AnimationStartJump(bool notifyMover = true /* Metadata: 0x007467E2 */); // 0x0000000181230C40-0x0000000181230C90
	public void AnimationFinishLoop(bool notifyMover = true /* Metadata: 0x007467E3 */); // 0x00000001812309D0-0x0000000181230A20
	public void AnimationStartFall(bool notifyMover = true /* Metadata: 0x007467E4 */); // 0x0000000181230C00-0x0000000181230C40
	public void AnimationDig(bool notifyMover = true /* Metadata: 0x007467E5 */); // 0x0000000181230910-0x0000000181230950
	public void AnimationDizzy(bool notifyMover = true /* Metadata: 0x007467E6 */); // 0x0000000181230990-0x00000001812309D0
	public void AnimationDive(bool notifyMover = true /* Metadata: 0x007467E7 */); // 0x0000000181230950-0x0000000181230990
	public void AnimationSleep(bool notifyMover = true /* Metadata: 0x007467E8 */); // 0x0000000181230AE0-0x0000000181230C00
	public void AnimationBoolSwim(bool inValue, bool notifyMover = true /* Metadata: 0x007467E9 */); // 0x00000001812308C0-0x0000000181230910
	public void AnimationBoolDecal(bool inValue); // 0x0000000181230870-0x00000001812308C0
	public void FreezeAnimation(bool inFreeze); // 0x0000000181232560-0x00000001812326C0
	private void MUpdateBodyParts(); // 0x0000000181235DA0-0x0000000181235F60
	[IteratorStateMachine] // 0x0000000180122CD0-0x0000000180122D20
	private IEnumerator BuildBodyParts(); // 0x0000000181231770-0x00000001812317D0
	[IteratorStateMachine] // 0x0000000180122EA0-0x0000000180122EF0
	private IEnumerator RefreshSharedInstances(); // 0x000000018123B080-0x000000018123B0E0
	[IteratorStateMachine] // 0x0000000180124510-0x0000000180124560
	private IEnumerator RefreshBodyParts(); // 0x000000018123AB80-0x000000018123ABE0
	private void ClearBodyParts(); // 0x0000000181231B30-0x0000000181231BB0
	private void DestroyBodyParts(); // 0x0000000181231FF0-0x00000001812321A0
	public ActorBodyPart GetAttachedBodyPartOfType(string inBodyPartNodeDefID); // 0x00000001812327E0-0x00000001812328B0
	public ActorBodyPart GetAttachedBodyPartOfType(ActorBodyPartNodeDefComponent inBodyPartNode); // 0x0000000181232770-0x00000001812327E0
	[IteratorStateMachine] // 0x0000000180124730-0x0000000180124780
	public IEnumerator SetBodyPartWithInfo(ActorInfoBodyPart inInfo, ActorBodyPartNodeDefComponent inBodyPartNode); // 0x000000018123B990-0x000000018123BA10
	[IteratorStateMachine] // 0x0000000180124890-0x00000001801248E0
	private IEnumerator BuildBodyPartCombine(); // 0x0000000181231710-0x0000000181231770
	private Vector2 GetAtlasOffsetLine(int inIndex, int inCount); // 0x00000001812326C0-0x0000000181232700
	private Vector2 GetAtlasOffsetSquare(int inIndex); // 0x0000000181232700-0x0000000181232770
	[IteratorStateMachine] // 0x0000000180124A40-0x0000000180124A90
	private IEnumerator BuildBubble(); // 0x00000001812317D0-0x0000000181231830
	[IteratorStateMachine] // 0x0000000180124C10-0x0000000180124C60
	private IEnumerator BuildClothing(); // 0x0000000181231830-0x0000000181231890
	[IteratorStateMachine] // 0x0000000180124F90-0x0000000180124FE0
	private IEnumerator RefreshClothing(); // 0x000000018123ABE0-0x000000018123AC40
	private void ClearClothing(); // 0x0000000181231BB0-0x0000000181231C20
	private void DestroyClothing(); // 0x00000001812321A0-0x0000000181232340
	public bool HasAttachedClothingItemWithDefID(string inClothingItemDefID); // 0x00000001812333D0-0x0000000181233580
	public AttachedClothingItem GetAttachedClothingItemWithItemDefID(string inClothingItemDefID); // 0x0000000181232B00-0x0000000181232CC0
	public AttachedClothingItem GetAttachedClothingItemOnNode(BaseDef inAttachNode); // 0x0000000181232AA0-0x0000000181232B00
	public AttachedClothingItem GetAttachedClothingItemOnGroup(ActorAttachNodeGroupDefComponent inAttachNodeGroup); // 0x00000001812328B0-0x0000000181232AA0
	public void RemoveAttachedClothingItemOnNode(BaseDef inAttachNode); // 0x000000018123B5B0-0x000000018123B620
	public void RemoveAttachedClothingItemOnGroup(BaseDef inAttachNodeGroup); // 0x000000018123B470-0x000000018123B5B0
	public void RemoveAttachedClothingItem(AttachedClothingItem inAttachedItem); // 0x000000018123B620-0x000000018123B6D0
	public AttachedClothingItem AddAttachedClothingItemWithDefComponent(ActorClothingDefComponent inDefComponent); // 0x000000018122F750-0x000000018122FDD0
	public static ActorBase CreateActor(string inWorldObjectDefID, ActorInfo inInfo, Vector3 inPosition, Quaternion inRotation, Action<GameObject, ActorInfo> inFinishedCallback); // 0x0000000181231F20-0x0000000181231FF0
	public ActorBase CreateActorClone(string inWorldObjectDefID, Vector3 inPosition, Quaternion inRotation, Action<GameObject, ActorInfo> inFinishedCallback); // 0x0000000181231CB0-0x0000000181231DE0
	public ActorBase CreateActorClone(Vector3 inPosition, Quaternion inRotation, Action<GameObject, ActorInfo> inFinishedCallback); // 0x0000000181231DE0-0x0000000181231F20
	private void RefreshRebuild(); // 0x000000018123AF90-0x000000018123B080
	public override void MStart(); // 0x0000000181235230-0x0000000181235270
	public override void MOnDestroy(); // 0x0000000181235180-0x00000001812351C0
	protected virtual void OnActorStart(); // 0x00000001803581E0-0x00000001803581F0
	protected virtual void OnActorDestroy(); // 0x00000001803581E0-0x00000001803581F0
	[IteratorStateMachine] // 0x00000001801251E0-0x0000000180125230
	public override IEnumerator Build(); // 0x0000000181231AD0-0x0000000181231B30
	public QRoutine WaitForBuild(); // 0x000000018123C630-0x000000018123C6B0
	[IteratorStateMachine] // 0x00000001801254B0-0x0000000180125500
	public IEnumerator WaitForBuildRoutine(); // 0x000000018123C5D0-0x000000018123C630
	protected virtual void OnFinishedBuilding(); // 0x00000001803581E0-0x00000001803581F0
	public void SetActorLayer(); // 0x000000018123B6D0-0x000000018123B740
	private void MUpdateOffsetTransform(); // 0x0000000181239D40-0x0000000181239E10
	private void MUpdateMeshVisibility(); // 0x0000000181236190-0x0000000181236340
	public override void MUpdate(); // 0x0000000181239E10-0x000000018123A1E0
	private void LateUpdate(); // 0x0000000181235090-0x00000001812350D0
	private void UnBuild(); // 0x000000018123C110-0x000000018123C2A0
	public override void OnDestroy(); // 0x000000018123A7F0-0x000000018123A980
	private void OnValidate(); // 0x00000001803581E0-0x00000001803581F0
	public void Log(string inLogMessage); // 0x00000001803581E0-0x00000001803581F0
	public void LogError(string inLogMessage); // 0x00000001812350D0-0x0000000181235180
	private void InitFakeLighting(); // 0x0000000181233A80-0x0000000181233A90
	private void MUpdateFakeLighting(); // 0x0000000181235F60-0x0000000181235F70
	public void UpdateLighting(bool inForced); // 0x000000018123C460-0x000000018123C5D0
	public void SetFakeLightColors(Color inMultColor, Color inAddColor); // 0x000000018123BBF0-0x000000018123BDD0
	private void InitJointMatching(); // 0x0000000181233A90-0x0000000181234030
	private void LateUpdateJointMatching(); // 0x0000000181234810-0x0000000181234D90
	private void InitJointScaling(); // 0x0000000181234030-0x00000001812345B0
	public void LateUpdateJointScaling(); // 0x0000000181234D90-0x0000000181235090
	public virtual void RegisterListeners(); // 0x000000018123B3E0-0x000000018123B470
	public virtual void UnregisterListeners(); // 0x000000018123C380-0x000000018123C410
	private void BuildMaterial(); // 0x0000000181231890-0x0000000181231A10
	private void RefreshMaterial(); // 0x000000018123AD00-0x000000018123AF90
	private void MUpdateMaterial(); // 0x0000000181235F70-0x0000000181236190
	public void ApplyMaterialKeywords(); // 0x0000000181231160-0x00000001812316F0
	public void ApplyMaterialBodyPartColors(); // 0x0000000181231030-0x0000000181231160
	private void BuildMover(); // 0x0000000181231A10-0x0000000181231A70
	private bool FastHasParameter(string inParamName); // 0x0000000181232470-0x0000000181232560
	public void MoverReset(); // 0x000000018123A480-0x000000018123A580
	private void MUpdateMoverWater(); // 0x0000000181239400-0x0000000181239A50
	public void OnHarvestPointMessage(InteractablePointMessage inMessage); // 0x000000018123A980-0x000000018123AB80
	private float MapClampAndRamp(float inValue, bool doRamp = true /* Metadata: 0x007467EA */); // 0x000000018123A1E0-0x000000018123A370
	private void MUpdateMover(); // 0x0000000181239A50-0x0000000181239D40
	private void OnControllerColliderHit(ControllerColliderHit inHit); // 0x000000018123A680-0x000000018123A7F0
	protected void MUpdateMoverIsGrounded(); // 0x0000000181237EB0-0x0000000181238150
	protected override void MUpdateMoverNodeQueue(); // 0x00000001812393C0-0x0000000181239400
	private void MUpdateMoverSmoothFollowTarget(); // 0x00000001803581E0-0x00000001803581F0
	protected override void HandleNodeType(WorldObjectMoverNode inNode); // 0x00000001812331A0-0x00000001812333D0
	public override void Teleport(Vector3 inPosition, Quaternion inRotation); // 0x000000018123C090-0x000000018123C0E0
	protected void MUpdateMoverLocalCharacterController(); // 0x0000000181238B70-0x00000001812393C0
	public void MoverFinishMouseOrbit(); // 0x00000001803581E0-0x00000001803581F0
	protected void MUpdateMoverLocalCharacterController_StandardMode(); // 0x0000000181238170-0x0000000181238B70
	protected virtual void MUpdateMoverLocalCharacterController_SimplifiedMode(); // 0x0000000181238150-0x0000000181238170
	public void DebugSetMoverMaxSpeed(float inSpeed, bool forRunning = false /* Metadata: 0x007467EB */); // 0x00000001803581E0-0x00000001803581F0
	private void MUpdateMoverAlignToGround(); // 0x0000000181236340-0x0000000181236E60
	private void MUpdateMoverAnimation(); // 0x0000000181236E60-0x0000000181237B10
	protected void MUpdateMoverAudio(); // 0x0000000181237B10-0x0000000181237EB0
	protected void MoverResetNodeAndPositionData(); // 0x000000018123A370-0x000000018123A480
	protected void MoverSetNodeTypeAndDetails(WorldObjectMoverNodeType nodeType, ActorActionType actionType); // 0x000000018123A580-0x000000018123A680
	public void ExitLevelWithPos(Vector3 inPos); // 0x0000000181232450-0x0000000181232470
	public void NavigateToPos(Vector3 inPos, float? inRotation = default); // 0x0000000180567730-0x0000000180567740
	public bool IsDirty(ActorInfoDirtyType inType); // 0x00000001812347B0-0x0000000181234810
	public void SetDirty(ActorInfoDirtyType inType, bool inValue = true /* Metadata: 0x007467EC */); // 0x000000018123BB80-0x000000018123BBF0
	public void SetAllDirty(bool inValue = true /* Metadata: 0x007467ED */); // 0x000000018123B740-0x000000018123B990
	private void InitRefreshDirtyUpdateCheck(); // 0x00000001812345B0-0x00000001812346A0
	[IteratorStateMachine] // 0x0000000180127470-0x00000001801274C0
	private IEnumerator RefreshDirtyUpdateCheckRoutine(); // 0x000000018123ACA0-0x000000018123AD00
	[IteratorStateMachine] // 0x00000001801276D0-0x0000000180127720
	private IEnumerator RefreshDirtyRoutine(); // 0x000000018123AC40-0x000000018123ACA0
	[IteratorStateMachine] // 0x00000001801278C0-0x0000000180127910
	private IEnumerator BuildSkeletons(); // 0x0000000181231A70-0x0000000181231AD0
	private void RefreshSkeletons(); // 0x000000018123B0E0-0x000000018123B220
	private void ClearSkeletons(); // 0x0000000181231C20-0x0000000181231CB0
	private void DestroySkeleton(); // 0x0000000181232340-0x0000000181232450
	private void AddJointsToBodySkeletonMap(Transform inParentJoint); // 0x000000018122FDD0-0x0000000181230270
	private void AddJointsToWingSkeletonMap(Transform inParentJoint); // 0x0000000181230270-0x0000000181230710
	public Transform GetSkeletonJointTransform(string inName); // 0x0000000181232E00-0x00000001812331A0
	public Transform GetJointTransformWithAttachNode(ActorAttachNodeDefComponent inAttachNode); // 0x0000000181232CC0-0x0000000181232E00
	private void InitSurfaceFXNodes(); // 0x00000001812346A0-0x00000001812347B0
	private void AddSurfaceFXTerrainNodeToJoint(string inJointName); // 0x0000000181230710-0x00000001812307C0
	private void AddSurfaceFXWaterNodeToJoint(string inJointName); // 0x00000001812307C0-0x0000000181230870
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <BuildBubble>b__111_0(UI_ActorBubble loadedBubble); // 0x00000001803BE5C0-0x00000001803BE5D0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Build>b__172_0(ActorBaseDataObject loadedAsset); // 0x00000001803BE5B0-0x00000001803BE5C0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <InitRefreshDirtyUpdateCheck>b__417_0(QRoutine inRoutine); // 0x000000018123C100-0x000000018123C110
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <BuildSkeletons>b__451_0(GameObject loadedAsset); // 0x000000018123C0E0-0x000000018123C0F0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <BuildSkeletons>b__451_1(GameObject loadedAsset); // 0x000000018123C0F0-0x000000018123C100
}

