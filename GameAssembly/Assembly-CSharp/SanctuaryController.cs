/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using WW.Debug;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ManagedBehaviourManager] // 0x00000001801E3560-0x00000001801E3590
public class SanctuaryController : ManagedBehaviour // TypeDefIndex: 13288
{
	// Fields
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private static SanctuaryController <instance>k__BackingField; // 0x00
	private SanctuaryLayoutData _layoutData; // 0x50
	private GameObject _interiorLights; // 0x58
	private GameObject _exteriorLights; // 0x60
	private List<Light> _interiorLightComponents; // 0x68
	private List<Light> _exteiorLightComponents; // 0x70
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int <expansionIdx>k__BackingField; // 0x78
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int <purchasedRoomIdx>k__BackingField; // 0x7C
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<int> <enlargedAreas>k__BackingField; // 0x80
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<int> <purchasedEnlargedAreas>k__BackingField; // 0x88
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int <modifiedExpansionIdx>k__BackingField; // 0x90
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<int> <modifiedEnlargedAreas>k__BackingField; // 0x98
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int <modifiedPurchaseExpansionIdx>k__BackingField; // 0xA0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<SanctuaryHouseDefComponent.TwiggleBuildLocation> <twiggleBuildLocations>k__BackingField; // 0xA8
	private List<RoomData> _changedServerRoomData; // 0xB0
	private List<RoomData> _serverRoomData; // 0xB8
	private List<RoomData> _serverRoomDataInitialized; // 0xC0
	private static int _playerAndCameraCollisionLayer; // 0x08
	private static int _playerCollisionLayer; // 0x0C
	private static int _sanctuaryLayer; // 0x10
	private static int _sanctuaryLayerMask; // 0x14
	private string _sanctuaryName; // 0xC8
	public Data data; // 0xD0
	private EState _desiredState; // 0xD8
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private EState <currentState>k__BackingField; // 0xDC
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private ETime <currentTime>k__BackingField; // 0xE0
	public List<SanctuaryObjectBase> sanctuaryObjectsInScene; // 0xE8
	public static Action<SanctuaryObjectBase> OnSanctuaryObjectAdded; // 0x18
	public static Action<SanctuaryObjectBase> OnSanctuaryObjectRemoved; // 0x20
	private GameObject _cursorSanctuaryCameraMove; // 0xF0
	private GameObject _cursorSanctuaryCameraRotate; // 0xF8
	private GameObject _cursorSanctuaryObjectMove; // 0x100
	private GameObject _cursorSanctuaryObjectRotate; // 0x108
	private SanctuaryCamera _sanctuaryCamera; // 0x110
	private UI_Sanctuary _sanctuaryUI; // 0x118
	private GameObject _exteriorGreenhouseDecorationGround; // 0x120
	private GameObject _exteriorGreenhouseBuildGround; // 0x128
	private GameObject _exteriorGreenhouseGround; // 0x130
	private GameObject _exteriorDecorationGround; // 0x138
	private GameObject _exteriorBuildGround; // 0x140
	private GameObject _exteriorHouseGround; // 0x148
	private SanctuarySafeSpawnObject _exteriorSafeSpawnObject; // 0x150
	private GameObject _skyboxExteriorGameObject; // 0x158
	private GameObject _skyboxInteriorGameObject; // 0x160
	private GameObject _respawnInterior; // 0x168
	private GameObject _respawnExterior; // 0x170
	private SanctuaryInterior _sanctuaryInterior; // 0x178
	private GameObject _safeSpawnExterior; // 0x180
	private GameObject _safeSpawnHouseEntrance; // 0x188
	private GameObject _safeSpawnInterior; // 0x190
	private GameObject _mySanctuaryObject; // 0x198
	private GameObject _mySanctuaryInterior; // 0x1A0
	private GameObject _mySanctuaryExterior; // 0x1A8
	private GameObject _mySanctuaryHouse; // 0x1B0
	private GameObject _mySanctuaryIsland; // 0x1B8
	private GameObject _mySanctuaryGround; // 0x1C0
	private GameObject _myGreenhouseGround; // 0x1C8
	private GameObject _materialParent; // 0x1D0
	private GameObject _portalToInteriorObject; // 0x1D8
	private SanctuaryPortal _portalToInterior; // 0x1E0
	public List<SanctuaryObjectBase> childSanctuaryObjectBases; // 0x1E8
	public List<SanctuaryObjectBase> activeSanctuaryObjectBases; // 0x1F0
	public SanctuaryObjectBase activeSanctuaryObjectBaseHouse; // 0x1F8
	public SanctuaryObjectBase activeSanctuaryObjectBaseIsland; // 0x200
	private List<SanctuaryAudio> _exteriorMusicObjects; // 0x208
	private List<SanctuaryAudio> _interiorMusicObjects; // 0x210
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RaycastHit <lastSurfaceRaycastHit>k__BackingField; // 0x218
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private SanctuarySurface <lastSurface>k__BackingField; // 0x248
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RaycastHit <activeSurfaceRaycastHit>k__BackingField; // 0x250
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private SanctuarySurface <activeSurface>k__BackingField; // 0x280
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RaycastHit <activeSanctuaryObjectRaycastHit>k__BackingField; // 0x288
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private SanctuaryObjectBase <activeSanctuaryObject>k__BackingField; // 0x2B8
	private SanctuaryObjectBase _currentSanctuaryObject; // 0x2C0
	private Camera _cachedCamera; // 0x2C8
	private UI3D_SanctuaryItem _sanctuaryItem3DUI; // 0x2D0
	public GameObject _highlightTracker; // 0x2D8
	public GameObject[] _highlights; // 0x2E0
	public Material[] _highlightMaterials; // 0x2E8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _shopTwiggle; // 0x2F0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _workerTwiggle; // 0x2F8
	private bool _teleporting; // 0x300
	private float _priorStepHeight; // 0x304
	private SanctuarySurface _priorControlledSurface; // 0x308
	private SanctuarySurface _controlledSurface; // 0x310
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private SanctuaryIndoorRoom <currentRoom>k__BackingField; // 0x318
	private LayerMask _cameraCullingMask; // 0x320
	private bool? _wasInterior; // 0x324
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float <leftMouseButtonHoldTimer>k__BackingField; // 0x328
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float <rightMouseButtonHoldTimer>k__BackingField; // 0x32C
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private static float <deltaTime>k__BackingField; // 0x28
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <moveObject>k__BackingField; // 0x330
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <rotateObject>k__BackingField; // 0x331
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <wasMoveObject>k__BackingField; // 0x332
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <wasRotateObject>k__BackingField; // 0x333
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <hasInitialized>k__BackingField; // 0x334
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <defaultMaterialsInitialized>k__BackingField; // 0x335
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <hasInitializedInterior>k__BackingField; // 0x336
	private bool _selectedObjectMove; // 0x337
	private bool _selectedObjectMoveLastUpdate; // 0x338
	private bool _selectedObjectRotate; // 0x339
	private bool _selectedObjectRotateLastUpdate; // 0x33A
	private bool _leftMouseButtonDown; // 0x33B
	private bool _leftMouseButtonUp; // 0x33C
	private bool _leftMouseButton; // 0x33D
	private bool _rightMouseButtonDown; // 0x33E
	private bool _rightMouseButtonUp; // 0x33F
	private bool _rightMouseButton; // 0x340
	private bool _saved; // 0x341
	private bool _LMBWasDown; // 0x342
	private bool _RMBWasDown; // 0x343
	private Vector3 _leftMouseDelta; // 0x344
	private Vector3 _leftMousePosition; // 0x350
	private Vector3 _rightMouseDelta; // 0x35C
	private Vector3 _rightMousePosition; // 0x368
	private List<UpdateItem> updateItems; // 0x378
	private List<RemoveItem> removeItems; // 0x380
	private List<LightInfo> _priorLightInfos; // 0x388
	private static string[] _includedTransformNames; // 0x30
	private static string[] _excludedTransformNames; // 0x38
	private static string[] _includedMaterialNames; // 0x40
	private static string[] _excludedMaterialNames; // 0x48

	// Properties
	public static SanctuaryController instance { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180475D70-0x0000000180475DD0 0x00000001804793E0-0x0000000180479440
	public SanctuaryLayoutData layoutData { get; } // 0x0000000180378320-0x0000000180378330 
	public GameObject interiorLights { get; } // 0x0000000180475DD0-0x0000000180475EC0 
	public GameObject exteriorLights { get; } // 0x0000000180475BA0-0x0000000180475C90 
	public int expansionIdx { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803959E0-0x00000001803959F0 0x00000001804793B0-0x00000001804793C0
	public int purchasedRoomIdx { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803A1570-0x00000001803A1580 0x00000001804794D0-0x00000001804794E0
	public List<int> enlargedAreas { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x000000018040ED60-0x000000018040ED70 0x00000001804793A0-0x00000001804793B0
	public List<int> purchasedEnlargedAreas { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180476CE0-0x0000000180476CF0 0x00000001804794C0-0x00000001804794D0
	public int modifiedExpansionIdx { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180476020-0x0000000180476030 0x0000000180479490-0x00000001804794A0
	public List<int> modifiedEnlargedAreas { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180418990-0x00000001804189A0 0x0000000180419170-0x0000000180419180
	public int modifiedPurchaseExpansionIdx { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180476030-0x0000000180476040 0x00000001804794A0-0x00000001804794B0
	public List<SanctuaryHouseDefComponent.TwiggleBuildLocation> twiggleBuildLocations { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180431310-0x0000000180431320 0x0000000180479500-0x0000000180479510
	public static int playerAndCameraCollisionLayer { get; } // 0x0000000180476940-0x0000000180476A20 
	public static int playerCollisionLayer { get; } // 0x0000000180476A20-0x0000000180476B00 
	public static int sanctuaryLayer { get; } // 0x0000000180478910-0x00000001804789F0 
	public static int sanctuaryLayerMask { get; } // 0x00000001804787C0-0x0000000180478910 
	public string sanctuaryName { get; } // 0x00000001804789F0-0x0000000180478B10 
	public EState currentState { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180475720-0x0000000180475730 0x0000000180479300-0x0000000180479310
	public ETime currentTime { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180475730-0x0000000180475740 0x0000000180479310-0x0000000180479320
	public SanctuaryCamera sanctuaryCamera { get; } // 0x0000000180478660-0x0000000180478710 
	public UI_Sanctuary sanctuaryUI { get; } // 0x0000000180478B10-0x0000000180478BC0 
	public GameObject exteriorGreenhouseDecorationGround { get; } // 0x00000001804759F0-0x0000000180475A80 
	public GameObject exteriorGreenhouseBuildGround { get; } // 0x0000000180475960-0x00000001804759F0 
	public GameObject exteriorGreenhouseGround { get; } // 0x0000000180475A80-0x0000000180475B10 
	public GameObject exteriorDecorationGround { get; } // 0x00000001804758D0-0x0000000180475960 
	public GameObject exteriorBuildGround { get; } // 0x0000000180475840-0x00000001804758D0 
	public GameObject exteriorHouseGround { get; } // 0x0000000180475B10-0x0000000180475BA0 
	public SanctuarySafeSpawnObject exteriorSafeSpawnObject { get; } // 0x0000000180475C90-0x0000000180475D40 
	public GameObject skyboxExteriorGameObject { get; } // 0x0000000180478BC0-0x0000000180478D00 
	public GameObject skyboxInteriorGameObject { get; } // 0x0000000180478D00-0x0000000180478E40 
	public GameObject respawnInterior { get; } // 0x0000000180476F90-0x0000000180477230 
	public GameObject respawnExterior { get; } // 0x0000000180476CF0-0x0000000180476F90 
	public SanctuaryInterior sanctuaryInterior { get; } // 0x0000000180478710-0x00000001804787C0 
	public GameObject safeSpawnExterior { get; } // 0x0000000180478100-0x0000000180478360 
	public GameObject safeSpawnHouseEntrance { get; } // 0x0000000180478360-0x00000001804785A0 
	public GameObject safeSpawnInterior { get; } // 0x00000001804785A0-0x0000000180478660 
	public GameObject mySanctuaryObject { get; } // 0x0000000180476850-0x0000000180476940 
	public GameObject mySanctuaryInterior { get; } // 0x0000000180476550-0x0000000180476710 
	public GameObject mySanctuaryExterior { get; } // 0x0000000180476190-0x00000001804762D0 
	public GameObject mySanctuaryHouse { get; } // 0x0000000180476410-0x0000000180476550 
	public GameObject mySanctuaryIsland { get; } // 0x0000000180476710-0x0000000180476850 
	public GameObject mySanctuaryGround { get; } // 0x00000001804762D0-0x0000000180476410 
	public GameObject myGreenhouseGround { get; } // 0x0000000180476050-0x0000000180476190 
	public GameObject materialParent { get; } // 0x0000000180475F70-0x0000000180476020 
	public GameObject portalToInteriorObject { get; } // 0x0000000180476B00-0x0000000180476BF0 
	public SanctuaryPortal portalToInterior { get; } // 0x0000000180476BF0-0x0000000180476CE0 
	public static bool roomOpenL { get; } // 0x00000001804779A0-0x0000000180477C10 
	public static bool roomOpenR { get; } // 0x0000000180477C10-0x0000000180477E80 
	public static bool roomOpenF { get; } // 0x0000000180477730-0x00000001804779A0 
	public static bool roomOpenB { get; } // 0x0000000180477240-0x00000001804774C0 
	public static bool roomOpenUp { get; } // 0x0000000180477E80-0x00000001804780F0 
	public static bool roomOpenDown { get; } // 0x00000001804774C0-0x0000000180477730 
	public RaycastHit lastSurfaceRaycastHit { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180475F20-0x0000000180475F50 0x0000000180479440-0x0000000180479470
	public SanctuarySurface lastSurface { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180475F50-0x0000000180475F60 0x0000000180479470-0x0000000180479480
	public RaycastHit activeSurfaceRaycastHit { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001804755F0-0x0000000180475620 0x0000000180478EA0-0x0000000180478ED0
	public SanctuarySurface activeSurface { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180475620-0x0000000180475630 0x0000000180478ED0-0x0000000180478EE0
	public RaycastHit activeSanctuaryObjectRaycastHit { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001804755B0-0x00000001804755E0 0x0000000180478E60-0x0000000180478E90
	public SanctuaryObjectBase activeSanctuaryObject { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001804755E0-0x00000001804755F0 0x0000000180478E90-0x0000000180478EA0
	public SanctuaryObjectBase currentSanctuaryObject { get; private set; } // 0x0000000180475710-0x0000000180475720 0x0000000180478FC0-0x0000000180479300
	public Camera cachedCamera { get; } // 0x0000000180475630-0x00000001804756F0 
	public static string defaultPrefix { get; } // 0x0000000180475750-0x0000000180475780 
	public SanctuarySurface controlledSurface { get; set; } // 0x00000001804756F0-0x0000000180475700 0x0000000180478EE0-0x0000000180478FB0
	public SanctuaryIndoorRoom currentRoom { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180475700-0x0000000180475710 0x0000000180478FB0-0x0000000180478FC0
	public bool isInterior { get; } // 0x0000000180475EC0-0x0000000180475F20 
	public float holdTime { get; } // 0x0000000180475D60-0x0000000180475D70 
	public float leftMouseButtonHoldTimer { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180475F60-0x0000000180475F70 0x0000000180479480-0x0000000180479490
	public float rightMouseButtonHoldTimer { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180477230-0x0000000180477240 0x00000001804794E0-0x00000001804794F0
	public static float deltaTime { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180475780-0x0000000180475840 0x0000000180479330-0x00000001804793A0
	public bool moveObject { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180476040-0x0000000180476050 0x00000001804794B0-0x00000001804794C0
	public bool rotateObject { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001804780F0-0x0000000180478100 0x00000001804794F0-0x0000000180479500
	public bool wasMoveObject { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180478E40-0x0000000180478E50 0x0000000180479510-0x0000000180479520
	public bool wasRotateObject { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180478E50-0x0000000180478E60 0x0000000180479520-0x0000000180479530
	public bool hasInitialized { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180475D50-0x0000000180475D60 0x00000001804793D0-0x00000001804793E0
	public bool defaultMaterialsInitialized { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180475740-0x0000000180475750 0x0000000180479320-0x0000000180479330
	public bool hasInitializedInterior { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180475D40-0x0000000180475D50 0x00000001804793C0-0x00000001804793D0

	// Nested types
	[Serializable]
	public class Data // TypeDefIndex: 13289
	{
		// Fields
		public List<SanctuarySurface> sanctuarySurfaces; // 0x10
		private Light[] _mainLights; // 0x18

		// Properties
		public Light[] mainLights { get; } // 0x00000001807ADE10-0x00000001807ADE80 

		// Constructors
		public Data(); // 0x00000001807ADDB0-0x00000001807ADE10

		// Methods
		public int GetHighestSurfaceIndex(); // 0x00000001807ADC70-0x00000001807ADDB0
	}

	public enum EState // TypeDefIndex: 13290
	{
		None = 0,
		Edit = 1
	}

	public enum ETime // TypeDefIndex: 13291
	{
		Day = 0,
		Night = 1
	}

	public enum ELocation // TypeDefIndex: 13292
	{
		Exterior = 0,
		Interior = 1
	}

	public class LightInfo // TypeDefIndex: 13293
	{
		// Fields
		public float intensity; // 0x10
		public float bounceIntensity; // 0x14
		public Color color; // 0x18

		// Constructors
		public LightInfo(); // 0x00000001807AE0E0-0x00000001807AE120
	}

	public enum ECursorMode // TypeDefIndex: 13294
	{
		NONE = 0,
		CAMERAMOVE = 1,
		CAMERAROTATE = 2,
		OBJECTMOVE = 3,
		OBJECTROTATE = 4
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass307_0 // TypeDefIndex: 13295
	{
		// Fields
		public Material cMat; // 0x10

		// Constructors
		public <>c__DisplayClass307_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <AssignDefaultMatToLayoutData>b__0(Material tLoaded); // 0x0000000180379F20-0x0000000180379F30
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <AssignDefaultMatToLayoutData>d__307 : IEnumerator<object> // TypeDefIndex: 13296
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public string inDefId; // 0x20
		public SanctuaryController <>4__this; // 0x28
		public Action<Material> inMaterial; // 0x30
		private <>c__DisplayClass307_0 <>8__1; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <AssignDefaultMatToLayoutData>d__307(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807B8690-0x00000001807B8830
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807B8830-0x00000001807B8880
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <InitializeSanctuaryCoroutine>d__308 : IEnumerator<object> // TypeDefIndex: 13297
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SanctuaryController <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <InitializeSanctuaryCoroutine>d__308(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807BE370-0x00000001807BEBC0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807BEBC0-0x00000001807BEC10
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass318_0 // TypeDefIndex: 13298
	{
		// Fields
		public bool bShouldTeleport; // 0x10

		// Constructors
		public <>c__DisplayClass318_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <TeleportToSafeAreaCoroutine>b__0(bool b); // 0x00000001803FD630-0x00000001803FD640
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass318_1 // TypeDefIndex: 13299
	{
		// Fields
		public bool bShouldTeleport; // 0x10

		// Constructors
		public <>c__DisplayClass318_1(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <TeleportToSafeAreaCoroutine>b__1(bool b); // 0x00000001803FD630-0x00000001803FD640
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <TeleportToSafeAreaCoroutine>d__318 : IEnumerator<object> // TypeDefIndex: 13300
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SanctuaryController <>4__this; // 0x20
		private <>c__DisplayClass318_0 <>8__1; // 0x28
		private <>c__DisplayClass318_1 <>8__2; // 0x30
		public bool inFade; // 0x38
		private Transform <cSafeSpawn>5__2; // 0x40
		private float <fFade>5__3; // 0x48
		private List<Transform> <cSafeSpawns>5__4; // 0x50
		private bool <bInCurrentRoom>5__5; // 0x58

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <TeleportToSafeAreaCoroutine>d__318(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807C1B50-0x00000001807C2460
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807C2460-0x00000001807C24B0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass329_0 // TypeDefIndex: 13301
	{
		// Fields
		public Material cMat; // 0x10

		// Constructors
		public <>c__DisplayClass329_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <SetIndoorMaterialCoroutine>b__0(Material tLoaded); // 0x0000000180379F20-0x0000000180379F30
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <SetIndoorMaterialCoroutine>d__329 : IEnumerator<object> // TypeDefIndex: 13302
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Item inItem; // 0x20
		public SanctuaryController <>4__this; // 0x28
		private <>c__DisplayClass329_0 <>8__1; // 0x30
		public SanctuaryItemCategory inCategory; // 0x38
		public SanctuaryObjectBase inSanctuaryObjectBase; // 0x40
		public int inRoomId; // 0x48

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <SetIndoorMaterialCoroutine>d__329(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807BFFE0-0x00000001807C0350
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807C0350-0x00000001807C03A0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass331_0 // TypeDefIndex: 13303
	{
		// Fields
		public Material cResult; // 0x10

		// Constructors
		public <>c__DisplayClass331_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <GetSanctuaryMaterial>b__0(Material cLoaded); // 0x0000000180379F20-0x0000000180379F30
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <GetSanctuaryMaterial>d__331 : IEnumerator<object> // TypeDefIndex: 13304
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public BaseDef inBaseDef; // 0x20
		public GameObject inGameObject; // 0x28
		public Action<Material> inResult; // 0x30
		private <>c__DisplayClass331_0 <>8__1; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <GetSanctuaryMaterial>d__331(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807BD000-0x00000001807BD180
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807BD180-0x00000001807BD1D0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <SetStepHeight>d__370 : IEnumerator<object> // TypeDefIndex: 13305
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SanctuaryController <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <SetStepHeight>d__370(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807C03A0-0x00000001807C0560
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807C0560-0x00000001807C05B0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <Fade>d__379 : IEnumerator<object> // TypeDefIndex: 13306
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SanctuaryController <>4__this; // 0x20
		public SanctuaryTeleportMessage inMessage; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <Fade>d__379(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807BB160-0x00000001807BB720
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807BB720-0x00000001807BB770
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <UpdateLights>d__387 : IEnumerator<object> // TypeDefIndex: 13307
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SanctuaryController <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <UpdateLights>d__387(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807C3850-0x00000001807C3930
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807C3930-0x00000001807C3980
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass390_0 // TypeDefIndex: 13308
	{
		// Fields
		public string sID; // 0x10

		// Constructors
		public <>c__DisplayClass390_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <UpdateItem>b__0(UpdateItem ui); // 0x00000001803E2140-0x00000001803E2170
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass403_0 // TypeDefIndex: 13309
	{
		// Fields
		public UpdateItem cUpdateItem; // 0x10

		// Constructors
		public <>c__DisplayClass403_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <ShouldTeleport>b__0(SanctuaryObjectBase sob); // 0x00000001807C2F60-0x00000001807C2FB0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <ShouldTeleport>d__403 : IEnumerator<object> // TypeDefIndex: 13310
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SanctuaryController <>4__this; // 0x20
		private <>c__DisplayClass403_0 <>8__1; // 0x28
		public Action<bool> result; // 0x30
		private bool <bTeleport>5__2; // 0x38
		private List<UpdateItem> <>7__wrap2; // 0x40
		private SanctuaryObjectBase <cSanctuaryObjectBase>5__4; // 0x58

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <ShouldTeleport>d__403(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001807C0990-0x00000001807C0A30
		private bool MoveNext(); // 0x00000001807C05B0-0x00000001807C0940
		private void <>m__Finally1(); // 0x00000001807C0A30-0x00000001807C0A70
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807C0940-0x00000001807C0990
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <CheckTeleportToSafeArea>d__404 : IEnumerator<object> // TypeDefIndex: 13311
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SanctuaryController <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <CheckTeleportToSafeArea>d__404(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807BB040-0x00000001807BB110
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807BB110-0x00000001807BB160
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass412_0 // TypeDefIndex: 13312
	{
		// Fields
		public Item inItem; // 0x10

		// Constructors
		public <>c__DisplayClass412_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <ItemIsEquipped>b__0(SanctuaryObjectBase so); // 0x00000001803734E0-0x0000000180373530
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass415_0 // TypeDefIndex: 13313
	{
		// Fields
		public SanctuaryObjectBase cSanctuaryObjectBase; // 0x10
		public Item inItem; // 0x18
		public SanctuaryItemDefComponent cSanctuaryItemDefComponent; // 0x20
		public SanctuaryObjectBaseInfo cSanctuaryObjectBaseInfo; // 0x28
		public SanctuaryController <>4__this; // 0x30
		public Action<GameObject> Callback; // 0x38

		// Constructors
		public <>c__DisplayClass415_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <SpawnPlacedItemFromUI>b__0(GameObject gInstancedAsset); // 0x00000001807C2FB0-0x00000001807C3080
		internal void <SpawnPlacedItemFromUI>b__1(GameObject gInstancedAsset); // 0x00000001807C3080-0x00000001807C31C0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <MovePlacedItemFromUI>d__416 : IEnumerator<object> // TypeDefIndex: 13314
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SanctuaryObjectBase inSanctuaryObjectBase; // 0x20
		public SanctuaryController <>4__this; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <MovePlacedItemFromUI>d__416(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807BFC00-0x00000001807BFF90
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807BFF90-0x00000001807BFFE0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass462_0 // TypeDefIndex: 13315
	{
		// Fields
		public RoomData cServerRoomData; // 0x10

		// Constructors
		public <>c__DisplayClass462_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <UpdateChangedServerRoomData>b__0(RoomData data); // 0x00000001807C31C0-0x00000001807C31F0
		internal bool <UpdateChangedServerRoomData>b__1(RoomData data); // 0x00000001807C31C0-0x00000001807C31F0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <SpawnPortalToInterior>d__472 : IEnumerator<object> // TypeDefIndex: 13316
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SanctuaryController <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <SpawnPortalToInterior>d__472(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807C1470-0x00000001807C1B00
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807C1B00-0x00000001807C1B50
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 13317
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<RoomData, RoomData> <>9__494_0; // 0x08
		public static Func<RoomData, RoomData> <>9__494_1; // 0x10

		// Constructors
		static <>c(); // 0x00000001807C37F0-0x00000001807C3850
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal RoomData <InitializeRoomDetails>b__494_0(RoomData roomData); // 0x00000001807C24B0-0x00000001807C24D0
		internal RoomData <InitializeRoomDetails>b__494_1(RoomData roomData); // 0x00000001807C24B0-0x00000001807C24D0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass505_0 // TypeDefIndex: 13318
	{
		// Fields
		public GameObject gSanctuary; // 0x10
		public Action<GameObject> inResult; // 0x18

		// Constructors
		public <>c__DisplayClass505_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <BuildSanctuaryForUI>b__0(List<GameObject> gLoaded); // 0x00000001807C3240-0x00000001807C3370
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass506_0 // TypeDefIndex: 13319
	{
		// Fields
		public GameObject gSanctuaryMod; // 0x10
		public Action<GameObject> inResult; // 0x18

		// Constructors
		public <>c__DisplayClass506_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <BuildHouseModForUI>b__0(GameObject gLoaded); // 0x00000001807C3370-0x00000001807C34A0
	}

	// Constructors
	public SanctuaryController(); // 0x0000000180475310-0x00000001804755B0
	static SanctuaryController(); // 0x0000000180475020-0x0000000180475310

	// Methods
	public override void MStart(); // 0x00000001804693A0-0x0000000180469810
	private void OnWindowOpened(WindowOpenCompleteMessage inMessage); // 0x000000018046B440-0x000000018046B450
	private void OnWindowClosed(WindowClosedMessage inMessage); // 0x000000018046B430-0x000000018046B440
	public void InitializeSanctuary(SanctuaryLayoutData inLayoutData, int inCurrentExpansionIdx, int inPurchasedRoomIdx, List<int> inCurrentEnlargedAreas, List<int> inPurchasedEnlargedAreas, List<SanctuaryHouseDefComponent.TwiggleBuildLocation> inTwiggleBuildLocations); // 0x00000001804682D0-0x0000000180468440
	[IteratorStateMachine] // 0x00000001801FAA10-0x00000001801FAA60
	private IEnumerator AssignDefaultMatToLayoutData(string inDefId, Action<Material> inMaterial); // 0x000000018045CF10-0x000000018045CFA0
	[IteratorStateMachine] // 0x00000001801FADB0-0x00000001801FAE00
	private IEnumerator InitializeSanctuaryCoroutine(); // 0x0000000180468260-0x00000001804682D0
	private void SetupWorldMapLocations(); // 0x0000000180470A60-0x0000000180471100
	private List<Transform> AddSpawns(List<Transform> inList, Transform inSpawn); // 0x000000018045C9E0-0x000000018045CA50
	private List<Transform> AddSpawns(List<Transform> inList, List<Transform> inSpawns); // 0x000000018045CA50-0x000000018045CBC0
	private void SetDefaultMaterial(SanctuaryItemCategory inCategory, Material inMaterial, SanctuaryIndoorRoom inSanctuaryIndoorRoom); // 0x000000018046DC80-0x000000018046DF70
	private void SetDefaultMaterials(SanctuaryIndoorRoom inSanctuaryIndoorRoom, SanctuaryItemCategory? inCategory); // 0x000000018046DF70-0x000000018046E140
	private SanctuaryObjectBase CreateTempSanctuaryObjectBase(int inRoomId); // 0x0000000180462E30-0x0000000180462EC0
	private Item CreateNewItem(ItemType inItemType, BaseDef inDef); // 0x0000000180461A20-0x0000000180461A90
	public void Decorate(bool inDecorate); // 0x00000001804633E0-0x0000000180463400
	public void TeleportToSafeArea(bool inFade); // 0x00000001804721E0-0x0000000180472260
	[IteratorStateMachine] // 0x00000001801FAF10-0x00000001801FAF60
	private IEnumerator TeleportToSafeAreaCoroutine(bool inFade); // 0x0000000180472160-0x00000001804721E0
	private static Transform GetTransformFromName(Transform inTransform, string[] inExcludeNames, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ string[] inNames); // 0x0000000180466D80-0x0000000180466EF0
	public static Transform GetTransform(List<Transform> inTransforms, string[] inExcludeNames, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ string[] inNames); // 0x0000000180466EF0-0x0000000180467130
	public static List<Transform> GetTransforms(List<Transform> inTransforms, string[] inExcludeNames, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ string[] inNames); // 0x0000000180467130-0x00000001804673A0
	public void SetExteriorInteriorFlooring(Material inMaterial); // 0x000000018046E430-0x000000018046E550
	public void SetExteriorInteriorWallpaper(Material inMaterial); // 0x000000018046E550-0x000000018046E670
	public static void DestroyMeshRenderer(Transform inTransform); // 0x0000000180463500-0x00000001804635A0
	public static void DestroyMeshRenderer(GameObject inGameObject); // 0x00000001804635A0-0x0000000180463680
	private void AddCursors(); // 0x000000018045C240-0x000000018045C3B0
	private void SetCursor(ECursorMode inMode); // 0x000000018046DBC0-0x000000018046DC80
	public void SetIndoorMaterials(SanctuaryItemCategory inCategory, Item inItem, SanctuaryObjectBase inSanctuaryObjectBase, int inRoomId); // 0x000000018046EB90-0x000000018046EC40
	[IteratorStateMachine] // 0x00000001801FB550-0x00000001801FB5A0
	private IEnumerator SetIndoorMaterialCoroutine(SanctuaryItemCategory inCategory, Item inItem, SanctuaryObjectBase inSanctuaryObjectBase, int inRoomId); // 0x000000018046E670-0x000000018046E710
	private void SetIndoorMaterial(SanctuaryItemCategory inCategory, Material inMaterial, SanctuaryObjectBase inSanctuaryObjectBase, int inRoomId); // 0x000000018046E710-0x000000018046EB90
	[IteratorStateMachine] // 0x00000001801FCC20-0x00000001801FCC70
	private static IEnumerator GetSanctuaryMaterial(GameObject inGameObject, BaseDef inBaseDef, Action<Material> inResult); // 0x0000000180465650-0x00000001804656E0
	public void SetActiveIsland(SanctuaryObjectBase inSanctuaryObjectBase); // 0x000000018046D2D0-0x000000018046D2E0
	public void SetActiveHouse(SanctuaryObjectBase inSanctuaryObjectBase); // 0x000000018046D2C0-0x000000018046D2D0
	public void AddChildSanctuaryObject(SanctuaryObjectBase inSanctuaryObjectBase); // 0x000000018045C1E0-0x000000018045C240
	public void RemoveChildSanctuaryObject(SanctuaryObjectBase inSanctuaryObjectBase); // 0x000000018046BC50-0x000000018046BCB0
	public void AddActiveSanctuaryObject(SanctuaryObjectBase inSanctuaryObjectBase); // 0x000000018045C180-0x000000018045C1E0
	public void RemoveActiveSanctuaryObject(SanctuaryObjectBase inSanctuaryObjectBase); // 0x000000018046B5A0-0x000000018046B600
	private void UpdateParents(); // 0x0000000180474300-0x00000001804745B0
	private void UpdateSanctuarySurfaces(); // 0x00000001804745B0-0x0000000180474BB0
	private SanctuaryObjectBase GetSanctuaryObjectAtMousePosition(out RaycastHit outHit, bool inCheckCurrentSanctuaryObject = false /* Metadata: 0x007BA2C5 */); // 0x00000001804656E0-0x0000000180465CD0
	private void UpdateCurrentSanctuaryObject(); // 0x0000000180473760-0x00000001804737C0
	public static void DestroyColliders(List<Transform> inTransforms); // 0x0000000180463400-0x0000000180463500
	private void UpdateActiveSanctuaryObject(); // 0x0000000180473190-0x0000000180473200
	public static void CreateMeshCollidersForIsland(GameObject inGameObject); // 0x0000000180461710-0x0000000180461A20
	public static MeshCollider CreateMeshCollider(GameObject inGameObject); // 0x00000001804610C0-0x0000000180461710
	public static void CreateHouseCollider(GameObject inGameObject); // 0x00000001803774A0-0x00000001803774B0
	public static void CreateTouchCollider(List<GameObject> inGameObjects); // 0x0000000180463330-0x00000001804633E0
	public static BoxCollider CreateTouchCollider(GameObject inGameObject); // 0x0000000180462EC0-0x0000000180463330
	public static void CreateMeshColliderPlayer(List<GameObject> inGameObjects); // 0x0000000180461010-0x00000001804610C0
	public static MeshCollider CreateMeshColliderPlayer(GameObject inGameObject); // 0x0000000180460B60-0x0000000180461010
	public void SpawnWorldPortal(Transform inParent); // 0x0000000180471E90-0x0000000180471FA0
	private void ChangeExteriorComponent(string inName, int inIndex); // 0x00000001803774A0-0x00000001803774B0
	private void ChangeExteriorComponentColor(string inName, Color inColor1, Color inColor2); // 0x00000001803774A0-0x00000001803774B0
	public static void SplitAllMaterialsTracked(Transform inTransform); // 0x0000000180471FA0-0x0000000180472000
	private static bool SkipTransformPerName(string inName); // 0x0000000180471400-0x0000000180471680
	private static bool SkipMaterialPerName(string inName); // 0x0000000180471180-0x0000000180471400
	public static void SplitMaterials(List<Transform> inTransforms); // 0x0000000180472060-0x0000000180472160
	public static void SplitMaterials(Transform inTransforms); // 0x0000000180472000-0x0000000180472060
	public static List<MeshRenderer> GetMeshRenderers(List<Transform> inList); // 0x0000000180464BF0-0x0000000180464E90
	public static void SetMaterial(List<Transform> inTransforms, Material inMaterial, bool bAllowSkip = true /* Metadata: 0x007BA2C6 */); // 0x000000018046F3C0-0x000000018046F4B0
	public static void SetMaterial(GameObject inGameObject, Material inMaterial, bool bAllowSkip = true /* Metadata: 0x007BA2C7 */); // 0x000000018046F5E0-0x000000018046F730
	public static void SetMaterial(Transform inTransform, Material inMaterial, bool bAllowSkip = true /* Metadata: 0x007BA2C8 */); // 0x000000018046F4B0-0x000000018046F5E0
	public static void SetMaterial(MeshRenderer inMeshRenderer, Material inMaterial, bool bAllowSkip = true /* Metadata: 0x007BA2C9 */); // 0x000000018046F730-0x000000018046F990
	public static List<Material> GetMaterials(List<Transform> inList); // 0x0000000180464900-0x0000000180464BF0
	public static List<Transform> GetRenderersTransform(Transform inParent); // 0x0000000180464E90-0x0000000180465090
	[IteratorStateMachine] // 0x00000001801FD020-0x00000001801FD070
	private IEnumerator SetStepHeight(); // 0x0000000180470800-0x0000000180470870
	public void OnCloseDecorateWindow(); // 0x0000000180469D90-0x0000000180469E50
	public override void MOnDestroy(); // 0x0000000180468D90-0x00000001804693A0
	private void OnSanctuaryInteriorExteriorChange(SanctuaryInteriorExteriorChange inMessage); // 0x000000018046A5B0-0x000000018046A710
	private void SetPriorStepHeight(float inStepHeight); // 0x000000018046FA30-0x000000018046FB40
	private void SetStepHeight(float inStepHeight); // 0x0000000180470870-0x0000000180470980
	private void OnSanctuaryTeleportMessage(SanctuaryTeleportMessage inMessage); // 0x000000018046B3B0-0x000000018046B430
	private void FadeToBlack(float inTime = 1f /* Metadata: 0x007BA2CA */); // 0x0000000180463680-0x0000000180463690
	private void FadeToGame(float inTime = 1f /* Metadata: 0x007BA2CE */); // 0x0000000180463690-0x00000001804636A0
	[IteratorStateMachine] // 0x00000001801FD230-0x00000001801FD280
	private IEnumerator Fade(SanctuaryTeleportMessage inMessage); // 0x00000001804636A0-0x0000000180463720
	private void OnSanctuaryIndoorRoomMessage(SanctuaryIndoorRoomMessage inMessage); // 0x000000018046A450-0x000000018046A5B0
	public void AddSanctuaryObject(SanctuaryObjectBase inSanctuaryObject); // 0x000000018045C460-0x000000018045C7C0
	public void RemoveSanctuaryObject(SanctuaryObjectBase inSanctuaryObject); // 0x000000018046C4D0-0x000000018046C620
	private void RevertMaterialToDefault(SanctuaryObjectBase inSanctuaryObject); // 0x000000018046C820-0x000000018046C9A0
	public void RemoveAllSanctuaryObjectsInRoom(); // 0x000000018046B600-0x000000018046B630
	public void RemoveAllSanctuaryObjectsInRoom(int inRoomIdx, bool inForceServerUpdate = false /* Metadata: 0x007BA2D2 */); // 0x000000018046B630-0x000000018046BC50
	[DebugButton] // 0x00000001801FD680-0x00000001801FD6E0
	public void SaveMySanctuaryState(); // 0x000000018046CCE0-0x000000018046D1E0
	[IteratorStateMachine] // 0x00000001801FDA30-0x00000001801FDA80
	private IEnumerator UpdateLights(); // 0x0000000180474290-0x0000000180474300
	public void OnNonOwnerUpdateMessage(SanctuaryXtHandler.DenStateUpdateResponse inMessage); // 0x0000000180469E50-0x000000018046A450
	public void RemoveItem(SanctuaryObjectBase inSanctuaryObjectBase); // 0x000000018046C170-0x000000018046C4D0
	public void UpdateItem(SanctuaryObjectBase inSanctuaryObjectBase); // 0x0000000180473D80-0x0000000180474290
	public override void MUpdate(); // 0x0000000180469810-0x0000000180469D10
	private void UpdateCameraMode(); // 0x0000000180473200-0x00000001804733D0
	public static bool IsOnGround(Vector3 inNormalDir); // 0x0000000180468AE0-0x0000000180468B00
	private void SetActiveSkybox(bool inInterior); // 0x000000018046D380-0x000000018046D420
	private void SetActiveLights(bool inInterior); // 0x000000018046D2E0-0x000000018046D380
	private void SetActiveAudio(List<SanctuaryAudio> inSanctuaryAudios, bool inActive); // 0x000000018046D1E0-0x000000018046D2C0
	public static string AddOrdinal(int inValue); // 0x000000018045C3B0-0x000000018045C460
	public string GetFloorName(); // 0x0000000180463AF0-0x0000000180463E00
	private void SetSanctuaryObjectActive(SanctuaryObjectBase inSanctuaryObject, bool inActive); // 0x0000000180470560-0x0000000180470670
	private void UpdateActions(); // 0x0000000180472300-0x0000000180473190
	private RaycastHit GetActiveHit(); // 0x0000000180463720-0x00000001804639C0
	private void SetLastGood(); // 0x000000018046F260-0x000000018046F3C0
	[IteratorStateMachine] // 0x00000001801FDDF0-0x00000001801FDE40
	private IEnumerator ShouldTeleport(Action<bool> result); // 0x0000000180471100-0x0000000180471180
	[IteratorStateMachine] // 0x00000001801FE0D0-0x00000001801FE120
	private IEnumerator CheckTeleportToSafeArea(); // 0x000000018045F080-0x000000018045F0F0
	private void UpdateState(); // 0x0000000180474BB0-0x0000000180475000
	public void UpdateHighlightColor(bool inValidPosition); // 0x00000001804737C0-0x0000000180473940
	private void Ray(Ray inRay, int inLayermask, Action<Vector3?> HitPoint); // 0x000000018046B450-0x000000018046B5A0
	private void CreateHighlight(); // 0x0000000180460580-0x0000000180460B60
	private void UpdateHighlight(); // 0x0000000180473940-0x0000000180473D80
	private static void OnSanctuaryObjectUpdateMessage(SanctuaryObjectUpdateMessage inMessage); // 0x000000018046A710-0x000000018046B3B0
	public static Quaternion GetSurfaceRotation(Vector3 inNormal, Transform inTransform); // 0x0000000180466C60-0x0000000180466D80
	public bool ItemIsEquipped(Item inItem); // 0x0000000180468BE0-0x0000000180468CF0
	public void SpawnFromUI(Item inItem, bool inWasDragged = false /* Metadata: 0x007BA2D3 */, BaseDef inFakeObject = null, Action<GameObject> Callback = null); // 0x0000000180471680-0x0000000180471690
	public void RemoveFromUI(Item inItem, int inRoomIdx = -1 /* Metadata: 0x007BA2D4 */); // 0x000000018046BE50-0x000000018046C170
	private void SpawnPlacedItemFromUI(Item inItem, bool inWasDragged = false /* Metadata: 0x007BA2D8 */, BaseDef inFakeObject = null, Action<GameObject> Callback = null); // 0x0000000180471690-0x0000000180471E20
	[IteratorStateMachine] // 0x00000001801FE400-0x00000001801FE450
	private IEnumerator MovePlacedItemFromUI(SanctuaryObjectBase inSanctuaryObjectBase); // 0x0000000180469D10-0x0000000180469D90
	private SanctuarySurface GetSurfaceFromRay(bool inWasDragged, out Vector3 oPosition, out int oSurfaceIndex); // 0x00000001804660C0-0x0000000180466AD0
	public int GetSurfaceIndex(SanctuaryObjectBase inSanctuaryObject); // 0x0000000180466C30-0x0000000180466C60
	public int GetSurfaceIndex(SanctuarySurface inSanctuarySurface); // 0x0000000180466AD0-0x0000000180466C30
	public Vector3 GetWorldPosition(SanctuaryObjectBase inSanctuaryObjectBase, int inSurfaceIdx, Vector3 inLocalPosition); // 0x0000000180467430-0x00000001804675E0
	public Vector3 GetLocalPosition(SanctuaryObjectBase inSanctuaryObjectBase, int inSurfaceIdx, Vector3 inWorldPosition); // 0x00000001804643F0-0x00000001804645A0
	public void SetPositionAndRotation(SanctuaryObjectBase inSanctuaryObjectBase, int inSurfaceIdx, Vector3 inLocalPosition, Quaternion inWorldRotation); // 0x000000018046F990-0x000000018046FA30
	public SanctuarySurface GetSanctuarySurface(int inIndex); // 0x0000000180465CD0-0x0000000180465F10
	public void AddSurfaces(SanctuarySurface[] inSanctuarySurfaces); // 0x000000018045CBC0-0x000000018045CC60
	public void SetState(EState inState); // 0x0000000180470670-0x0000000180470800
	public void GoToRoomLeft(); // 0x0000000180467C50-0x0000000180467CF0
	public void GoToRoomRight(); // 0x0000000180467CF0-0x0000000180467D90
	public void GoToRoomForward(); // 0x0000000180467BB0-0x0000000180467C50
	public void GoToRoomBack(); // 0x0000000180467A70-0x0000000180467B10
	public void GoToRoomUpstairs(); // 0x0000000180467D90-0x0000000180467E30
	public void GoToRoomDownstairs(); // 0x0000000180467B10-0x0000000180467BB0
	public void GoToDayTime(); // 0x00000001804675E0-0x00000001804675F0
	public void GoToNightTime(); // 0x0000000180467A60-0x0000000180467A70
	private void UpdateTime(); // 0x00000001803774A0-0x00000001803774B0
	public void GoToInterior(); // 0x0000000180467840-0x0000000180467A60
	public void GoToExterior(); // 0x00000001804675F0-0x0000000180467840
	public void CameraReset(); // 0x000000018045E100-0x000000018045E190
	public void CameraZoomOut(); // 0x000000018045E1E0-0x000000018045E220
	public void CameraZoomIn(); // 0x000000018045E190-0x000000018045E1E0
	public void RoomUpgrade(); // 0x00000001803774A0-0x00000001803774B0
	public void RoomDowngrade(); // 0x00000001803774A0-0x00000001803774B0
	public void SaveChanges(); // 0x000000018046CCD0-0x000000018046CCE0
	public void LoadSanctuaryLook(SanctuaryLookItemComponent inSanctuaryLook); // 0x0000000180468CF0-0x0000000180468D90
	public void BuildInteriorLayout(); // 0x000000018045D1C0-0x000000018045DEE0
	private void CreateSanctuaryGrounds(); // 0x0000000180461E00-0x0000000180462590
	private void CreateGreenhouseGrounds(); // 0x000000018045FC30-0x0000000180460580
	private void InstanceInteriorRooms(); // 0x0000000180468440-0x00000001804685F0
	private void CreateSanctuaryIndoorRooms(); // 0x0000000180462590-0x0000000180462D80
	public void SetSafeSpawnHouseEntrance(Vector3 inPosition, Vector3 inRotation); // 0x0000000180470280-0x0000000180470350
	public SanctuaryIndoorRoom GetRoomIndex(int inIdx); // 0x00000001804653B0-0x00000001804654E0
	public SanctuaryIndoorRoom GetRoomIndex(SanctuarySurface inSurface); // 0x0000000180465270-0x00000001804653B0
	private void SetRoomIndexes(); // 0x000000018046FD70-0x00000001804700A0
	private void SetRoomSizes(); // 0x00000001804700A0-0x0000000180470280
	private void SetInteriorRoomDoors(); // 0x000000018046ED20-0x000000018046F260
	public bool GetIsInCurrentRoom(Item inItem); // 0x0000000180463E60-0x0000000180464020
	public string GetRoomIdForUI(Item inItem); // 0x0000000180465100-0x0000000180465250
	private int GetRoomIndexFromRoom(SanctuaryObjectBase inSanctuaryObjectBase); // 0x0000000180465250-0x0000000180465270
	private string GetIdFromRoomForUI(SanctuaryObjectBase inSanctuaryObjectBase); // 0x0000000180463E00-0x0000000180463E50
	public string GetRoomIdForUI(int inRoomIndex); // 0x00000001804650A0-0x00000001804650C0
	public string GetRoomIdForUI(); // 0x00000001804650C0-0x0000000180465100
	public void SetRoomIdFromUI(int inRoomIndex, string inString); // 0x000000018046FD40-0x000000018046FD70
	private void UpdateChangedServerRoomData(); // 0x00000001804733D0-0x0000000180473760
	private RoomData GetServerRoomData(int inRoomIndex); // 0x0000000180465F10-0x00000001804660C0
	public void SetRoomIdFromUI(string inString); // 0x000000018046FD00-0x000000018046FD40
	private string GetLocallySavedRoomIdFromRoomIndex(int inRoomIndex); // 0x00000001804645A0-0x0000000180464900
	public float GetRoomLightRotation(int inRoomIndex); // 0x0000000180465530-0x0000000180465560
	public string GetRoomLightColor(int inRoomIndex); // 0x0000000180465510-0x0000000180465530
	public float GetRoomLightBrightness(int inRoomIndex); // 0x00000001804654E0-0x0000000180465510
	private void SetInteriorRoomAddOns(); // 0x000000018046EC40-0x000000018046ED20
	public BaseDef GetExpansionDef(int inRoomId); // 0x0000000180463A60-0x0000000180463AF0
	public BaseDef GetUpgradeDef(int inRoomId); // 0x00000001804673A0-0x0000000180467430
	[IteratorStateMachine] // 0x00000001801FE6D0-0x00000001801FE720
	private IEnumerator SpawnPortalToInterior(); // 0x0000000180471E20-0x0000000180471E90
	private void CreateAudio(); // 0x000000018045F4B0-0x000000018045F940
	private void CreateRespawns(); // 0x0000000180461A90-0x0000000180461E00
	private GameObject CreateBoundary(GameObject inParent, Vector3 inSize); // 0x000000018045F940-0x000000018045FA40
	private GameObject Instance(GameObject inPrefab, GameObject inParent); // 0x00000001804688E0-0x00000001804689D0
	private GameObject CreateCubeObject(GameObject inPrefab, GameObject inParent, bool inCastShadows = false /* Metadata: 0x007BA2D9 */); // 0x000000018045FA40-0x000000018045FC30
	private static void SetCollider(GameObject inGameObject); // 0x000000018046D820-0x000000018046D920
	private bool RoomIsEnlarged(int inRoomIdx); // 0x000000018046C9A0-0x000000018046CA20
	private GameObject InstanceRoom(SanctuaryLayoutData.RoomData inRoomData, SanctuaryIndoorRoom inSanctuaryIndoorRoom, Transform inParent); // 0x00000001804685F0-0x00000001804688E0
	private int GetCurrentRoomIndex(); // 0x00000001804639C0-0x0000000180463A60
	public List<Light> GetLights(); // 0x0000000180464210-0x00000001804643F0
	public float GetLightIntensity(); // 0x0000000180464190-0x00000001804641D0
	public void ChangeLightIntensity(float inIntensity); // 0x000000018045EBA0-0x000000018045ECE0
	private void ChangeLightIntensityFromRoom(); // 0x000000018045E920-0x000000018045EBA0
	public float GetLightRotation(); // 0x00000001804641D0-0x0000000180464210
	public void ChangeLightRotation(float inValue); // 0x000000018045EE20-0x000000018045F080
	private void ChangeLightRotationFromRoom(); // 0x000000018045ECE0-0x000000018045EE20
	public void SetCurrentLightsToWhite(); // 0x000000018046D920-0x000000018046DBC0
	public void RevertCurrentLightColor(); // 0x000000018046C640-0x000000018046C820
	public SanctuaryLightDefComponent GetLightColor(); // 0x0000000180464020-0x0000000180464190
	public void ChangeLightColor(SanctuaryLightDefComponent inValue); // 0x000000018045E8B0-0x000000018045E920
	private void ChangeLightColorFromRoom(); // 0x000000018045E650-0x000000018045E8B0
	public void InitializeRoomDetails(List<RoomData> inRoomData); // 0x0000000180468010-0x0000000180468260
	public static void SetCastShadowsOff(GameObject inGameObject, bool inIncludeChildren); // 0x000000018046D690-0x000000018046D820
	public static void SetCastAndReceiveShadowsOff(List<Transform> inTransforms); // 0x000000018046D510-0x000000018046D5C0
	public static void SetCastAndReceiveShadowsOff(GameObject inGameObject); // 0x000000018046D420-0x000000018046D510
	public static void SetCastAndReceiveShadowsOff(Transform inTransform); // 0x000000018046D5C0-0x000000018046D690
	public static void RemoveColliders(List<Transform> inTransforms); // 0x000000018046BDA0-0x000000018046BE50
	public static void RemoveColliders(Transform inTransform); // 0x000000018046BCB0-0x000000018046BDA0
	public static void AddSanctuarySurfaceComponent(List<Transform> inTransforms); // 0x000000018045C7C0-0x000000018045C870
	public static void AddSanctuarySurfaceComponent(Transform inTransform); // 0x000000018045C8E0-0x000000018045C9E0
	public static void AddSanctuarySurfaceComponent(GameObject inGameObject); // 0x000000018045C870-0x000000018045C8E0
	private GameObject CreateSpawn(GameObject inParent, float inWallY, float inDoorY); // 0x0000000180462D80-0x0000000180462E30
	public static void BuildSanctuaryForUI(Action<GameObject> inResult, Item inItem = null, BaseDef inDef = null, int inModIndex = -1 /* Metadata: 0x007BA2DA */); // 0x000000018045DEE0-0x000000018045E100
	public static void BuildHouseModForUI(SanctuaryHouseGetModelDefComponent.EHouseMod inType, Action<GameObject> inResult, Item inItem = null, BaseDef inDef = null, int inModIndex = -1 /* Metadata: 0x007BA2DE */); // 0x000000018045CFA0-0x000000018045D1C0
	public bool IsPurchasingRoomOrRoomUpgrade(int inRoomIndex); // 0x0000000180468B00-0x0000000180468B20
	public bool IsPurchasingRoom(int inRoomIndex); // 0x0000000180468BD0-0x0000000180468BE0
	public bool IsPurchasingRoomUpgrade(int inRoomIndex); // 0x0000000180468B20-0x0000000180468BD0
	public bool CanPurchaseRoom(int inRoomIndex); // 0x000000018045E3B0-0x000000018045E460
	public bool CanPurchaseUpgradeRoom(int inRoomIndex); // 0x000000018045E460-0x000000018045E540
	public bool CanUpgradeRoom(int inRoomIndex); // 0x000000018045E540-0x000000018045E650
	public bool CanDowngradeRoom(int inRoomIndex); // 0x000000018045E2C0-0x000000018045E390
	public bool CanDisableRoom(int inRoomIndex); // 0x000000018045E2A0-0x000000018045E2C0
	public bool CanEnableRoom(int inRoomIndex); // 0x000000018045E390-0x000000018045E3B0
	public bool CanAddRoom(); // 0x000000018045E220-0x000000018045E2A0
	public bool GetIsEntranceRoom(int inRoomIndex); // 0x0000000180463E50-0x0000000180463E60
	public bool GetRoomUpgradePurchased(int inRoomIndex); // 0x0000000180465570-0x00000001804655F0
	public void SetEnabledRoom(int inRoomIndex); // 0x000000018046E3A0-0x000000018046E430
	public void SetDisabledRoom(int inRoomIndex); // 0x000000018046E140-0x000000018046E2C0
	public void SetPurchaseRoom(int inRoomIndex); // 0x000000018046FB40-0x000000018046FBF0
	public void SetUpgrade(int inRoomIndex); // 0x0000000180470980-0x0000000180470A60
	public void SetPurchaseUpgrade(int inRoomIndex, bool inUpgrade); // 0x000000018046FBF0-0x000000018046FD00
	public void SetDowngrade(int inRoomIndex); // 0x000000018046E2C0-0x000000018046E3A0
	public bool HasModifications(); // 0x0000000180467E30-0x0000000180467F30
	public bool HasPurchases(); // 0x0000000180467F30-0x0000000180468010
	private void ClearPendingPurchases(); // 0x000000018045F270-0x000000018045F3A0
	public bool GetRoomEnabled(int inRoomIndex); // 0x0000000180465090-0x00000001804650A0
	public bool GetRoomPurchased(int inRoomIndex); // 0x0000000180465560-0x0000000180465570
	public bool GetRoomUpgraded(int inRoomIndex); // 0x00000001804655F0-0x0000000180465650
	public bool IsDowngradingAnyRoom(); // 0x00000001804689D0-0x0000000180468AE0
	public bool AnyFurnitureInDowngradingRooms(); // 0x000000018045CC60-0x000000018045CDB0
	private bool SanctuaryObjectExistsInRoom(SanctuaryIndoorRoom inRoom); // 0x000000018046CA20-0x000000018046CCD0
	public bool AnyFurnitureInRoom(int inRoomIdx = -1 /* Metadata: 0x007BA2E2 */); // 0x000000018045CDB0-0x000000018045CF10
	public void SetSanctuaryJobStart(); // 0x00000001804703D0-0x0000000180470560
	private void ClearAnyDowngradedRooms(); // 0x000000018045F0F0-0x000000018045F1F0
	private void VerifyPurchaseVariable(); // 0x0000000180475000-0x0000000180475020
	public void ResetSanctuaryJobVariables(); // 0x000000018046C620-0x000000018046C640
	public void ClearPurchase(); // 0x000000018045F3A0-0x000000018045F4B0
	public void ClearModifications(); // 0x000000018045F1F0-0x000000018045F270
	public void SetSanctuaryJobComplete(); // 0x0000000180470350-0x00000001804703D0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <InitializeSanctuaryCoroutine>b__308_0(Material cMat); // 0x0000000180472270-0x0000000180472290
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <InitializeSanctuaryCoroutine>b__308_1(Material cMat); // 0x0000000180472290-0x00000001804722B0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <InitializeSanctuaryCoroutine>b__308_2(Material cMat); // 0x00000001804722B0-0x00000001804722D0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <InitializeSanctuaryCoroutine>b__308_3(Material cMat); // 0x00000001804722D0-0x00000001804722F0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <CheckTeleportToSafeArea>b__404_0(bool b); // 0x0000000180472260-0x0000000180472270
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <SetState>b__425_0(UI3D_SanctuaryItem loaded3DUI); // 0x00000001804722F0-0x0000000180472300
}

