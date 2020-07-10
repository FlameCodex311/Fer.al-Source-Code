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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ManagedBehaviourManager] // 0x0000000180106CD0-0x0000000180106D00
public class SanctuaryController : ManagedBehaviour // TypeDefIndex: 11753
{
	// Fields
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private static SanctuaryController <instance>k__BackingField; // 0x00
	[RootSelector] // 0x000000018010D430-0x000000018010D490
	public string greenhouseDefId; // 0x50
	[RootSelector] // 0x000000018010D700-0x000000018010D760
	public string greenhouseEnabledDefId; // 0x58
	private Transform _greenHouseParent; // 0x60
	private SanctuaryLayoutData _layoutData; // 0x68
	private GameObject _interiorLights; // 0x70
	private GameObject _exteriorLights; // 0x78
	private List<Light> _interiorLightComponents; // 0x80
	private List<Light> _exteiorLightComponents; // 0x88
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private int <expansionIdx>k__BackingField; // 0x90
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private int <purchasedRoomIdx>k__BackingField; // 0x94
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private List<int> <enlargedAreas>k__BackingField; // 0x98
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private List<int> <purchasedEnlargedAreas>k__BackingField; // 0xA0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private int <modifiedExpansionIdx>k__BackingField; // 0xA8
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private List<int> <modifiedEnlargedAreas>k__BackingField; // 0xB0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private int <modifiedPurchaseExpansionIdx>k__BackingField; // 0xB8
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private List<SanctuaryHouseDefComponent.TwiggleBuildLocation> <twiggleBuildLocations>k__BackingField; // 0xC0
	private List<RoomData> _changedServerRoomData; // 0xC8
	private List<RoomData> _serverRoomData; // 0xD0
	private List<RoomData> _serverRoomDataInitialized; // 0xD8
	private static int _playerAndCameraCollisionLayer; // 0x08
	private static int _playerCollisionLayer; // 0x0C
	private static int _sanctuaryLayer; // 0x10
	private static int _sanctuaryLayerMask; // 0x14
	private string _sanctuaryName; // 0xE0
	public Data data; // 0xE8
	private EState _desiredState; // 0xF0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private EState <currentState>k__BackingField; // 0xF4
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private ETime <currentTime>k__BackingField; // 0xF8
	public List<SanctuaryObjectBase> sanctuaryObjectsInScene; // 0x100
	public static Action<SanctuaryObjectBase> OnSanctuaryObjectAdded; // 0x18
	public static Action<SanctuaryObjectBase> OnSanctuaryObjectRemoved; // 0x20
	private GameObject _cursorSanctuaryCameraMove; // 0x108
	private GameObject _cursorSanctuaryCameraRotate; // 0x110
	private GameObject _cursorSanctuaryObjectMove; // 0x118
	private GameObject _cursorSanctuaryObjectRotate; // 0x120
	private SanctuaryCamera _sanctuaryCamera; // 0x128
	private UI_Sanctuary _sanctuaryUI; // 0x130
	private GameObject _exteriorDecorationGround; // 0x138
	private GameObject _exteriorBuildGround; // 0x140
	private SanctuarySafeSpawnObject _exteriorSafeSpawnObject; // 0x148
	private GameObject _exteriorHouseGround; // 0x150
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
	private GameObject _materialParent; // 0x1C8
	private GameObject _portalToInteriorObject; // 0x1D0
	private SanctuaryPortal _portalToInterior; // 0x1D8
	public List<SanctuaryObjectBase> childSanctuaryObjectBases; // 0x1E0
	public List<SanctuaryObjectBase> activeSanctuaryObjectBases; // 0x1E8
	public SanctuaryObjectBase activeSanctuaryObjectBaseHouse; // 0x1F0
	public SanctuaryObjectBase activeSanctuaryObjectBaseIsland; // 0x1F8
	private List<SanctuaryAudio> _exteriorMusicObjects; // 0x200
	private List<SanctuaryAudio> _interiorMusicObjects; // 0x208
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private RaycastHit <lastSurfaceRaycastHit>k__BackingField; // 0x210
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private SanctuarySurface <lastSurface>k__BackingField; // 0x240
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private RaycastHit <activeSurfaceRaycastHit>k__BackingField; // 0x248
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private SanctuarySurface <activeSurface>k__BackingField; // 0x278
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private RaycastHit <activeSanctuaryObjectRaycastHit>k__BackingField; // 0x280
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private SanctuaryObjectBase <activeSanctuaryObject>k__BackingField; // 0x2B0
	private SanctuaryObjectBase _currentSanctuaryObject; // 0x2B8
	private Camera _cachedCamera; // 0x2C0
	private UI3D_SanctuaryItem _sanctuaryItem3DUI; // 0x2C8
	public GameObject _highlightTracker; // 0x2D0
	public GameObject[] _highlights; // 0x2D8
	public Material[] _highlightMaterials; // 0x2E0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _shopTwiggle; // 0x2E8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _workerTwiggle; // 0x2F0
	private bool _teleporting; // 0x2F8
	private float _priorStepHeight; // 0x2FC
	private SanctuarySurface _priorControlledSurface; // 0x300
	private SanctuarySurface _controlledSurface; // 0x308
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private SanctuaryIndoorRoom <currentRoom>k__BackingField; // 0x310
	private LayerMask _cameraCullingMask; // 0x318
	private bool? _wasInterior; // 0x31C
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private float <leftMouseButtonHoldTimer>k__BackingField; // 0x320
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private float <rightMouseButtonHoldTimer>k__BackingField; // 0x324
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private static float <deltaTime>k__BackingField; // 0x28
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <moveObject>k__BackingField; // 0x328
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <rotateObject>k__BackingField; // 0x329
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <wasMoveObject>k__BackingField; // 0x32A
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <wasRotateObject>k__BackingField; // 0x32B
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <hasInitialized>k__BackingField; // 0x32C
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <defaultMaterialsInitialized>k__BackingField; // 0x32D
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <hasInitializedInterior>k__BackingField; // 0x32E
	private bool _selectedObjectMove; // 0x32F
	private bool _selectedObjectMoveLastUpdate; // 0x330
	private bool _selectedObjectRotate; // 0x331
	private bool _selectedObjectRotateLastUpdate; // 0x332
	private bool _leftMouseButtonDown; // 0x333
	private bool _leftMouseButtonUp; // 0x334
	private bool _leftMouseButton; // 0x335
	private bool _rightMouseButtonDown; // 0x336
	private bool _rightMouseButtonUp; // 0x337
	private bool _rightMouseButton; // 0x338
	private bool _saved; // 0x339
	private bool _LMBWasDown; // 0x33A
	private bool _RMBWasDown; // 0x33B
	private Vector3 _leftMouseDelta; // 0x33C
	private Vector3 _leftMousePosition; // 0x348
	private Vector3 _rightMouseDelta; // 0x354
	private Vector3 _rightMousePosition; // 0x360
	private List<UpdateItem> updateItems; // 0x370
	private List<RemoveItem> removeItems; // 0x378
	private static string[] _includedTransformNames; // 0x30
	private static string[] _excludedTransformNames; // 0x38
	private static string[] _includedMaterialNames; // 0x40
	private static string[] _excludedMaterialNames; // 0x48

	// Properties
	public static SanctuaryController instance { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180E36B40-0x0000000180E36C00 0x0000000180E3A110-0x0000000180E3A170
	public bool greenHouseEnabled { get; } // 0x0000000180E36A90-0x0000000180E36B10 
	public SanctuaryLayoutData layoutData { get; } // 0x0000000180358970-0x0000000180358980 
	public GameObject interiorLights { get; } // 0x0000000180E36C00-0x0000000180E36CF0 
	public GameObject exteriorLights { get; } // 0x0000000180E368F0-0x0000000180E369E0 
	public int expansionIdx { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001804A1060-0x00000001804A1070 0x00000001804AFEE0-0x00000001804AFEF0
	public int purchasedRoomIdx { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001804D0680-0x00000001804D0690 0x00000001804D0BB0-0x00000001804D0BC0
	public List<int> enlargedAreas { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180369B70-0x0000000180369B80 0x000000018036A3D0-0x000000018036A3E0
	public List<int> purchasedEnlargedAreas { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180382AA0-0x0000000180382AB0 0x00000001803D8EE0-0x00000001803D8EF0
	public int modifiedExpansionIdx { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180E08B10-0x0000000180E08B20 0x000000018046A090-0x000000018046A0A0
	public List<int> modifiedEnlargedAreas { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803ED9D0-0x00000001803ED9E0 0x00000001804A0A60-0x00000001804A0A70
	public int modifiedPurchaseExpansionIdx { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180428830-0x0000000180428840 0x0000000180E3A1C0-0x0000000180E3A1D0
	public List<SanctuaryHouseDefComponent.TwiggleBuildLocation> twiggleBuildLocations { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001804A1050-0x00000001804A1060 0x00000001804A0A80-0x00000001804A0A90
	public static int playerAndCameraCollisionLayer { get; } // 0x0000000180E37610-0x0000000180E376F0 
	public static int playerCollisionLayer { get; } // 0x0000000180E376F0-0x0000000180E377D0 
	public static int sanctuaryLayer { get; } // 0x0000000180E39660-0x0000000180E39740 
	public static int sanctuaryLayerMask { get; } // 0x0000000180E39500-0x0000000180E39660 
	public string sanctuaryName { get; } // 0x0000000180E39740-0x0000000180E39860 
	public EState currentState { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180E36620-0x0000000180E36630 0x0000000180E3A050-0x0000000180E3A060
	public ETime currentTime { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180E36630-0x0000000180E36640 0x0000000180E3A060-0x0000000180E3A070
	public SanctuaryCamera sanctuaryCamera { get; } // 0x0000000180E393A0-0x0000000180E39450 
	public UI_Sanctuary sanctuaryUI { get; } // 0x0000000180E39860-0x0000000180E39910 
	public GameObject exteriorDecorationGround { get; } // 0x0000000180E367D0-0x0000000180E36860 
	public GameObject exteriorBuildGround { get; } // 0x0000000180E36740-0x0000000180E367D0 
	public SanctuarySafeSpawnObject exteriorSafeSpawnObject { get; } // 0x0000000180E369E0-0x0000000180E36A90 
	public GameObject exteriorHouseGround { get; } // 0x0000000180E36860-0x0000000180E368F0 
	public GameObject skyboxExteriorGameObject { get; } // 0x0000000180E39910-0x0000000180E39A50 
	public GameObject skyboxInteriorGameObject { get; } // 0x0000000180E39A50-0x0000000180E39B90 
	public GameObject respawnInterior { get; } // 0x0000000180E37C60-0x0000000180E37F10 
	public GameObject respawnExterior { get; } // 0x0000000180E379C0-0x0000000180E37C60 
	public SanctuaryInterior sanctuaryInterior { get; } // 0x0000000180E39450-0x0000000180E39500 
	public GameObject safeSpawnExterior { get; } // 0x0000000180E38E30-0x0000000180E390A0 
	public GameObject safeSpawnHouseEntrance { get; } // 0x0000000180E390A0-0x0000000180E392E0 
	public GameObject safeSpawnInterior { get; } // 0x0000000180E392E0-0x0000000180E393A0 
	public GameObject mySanctuaryObject { get; } // 0x0000000180E37520-0x0000000180E37610 
	public GameObject mySanctuaryInterior { get; } // 0x0000000180E37220-0x0000000180E373E0 
	public GameObject mySanctuaryExterior { get; } // 0x0000000180E36E60-0x0000000180E36FA0 
	public GameObject mySanctuaryHouse { get; } // 0x0000000180E370E0-0x0000000180E37220 
	public GameObject mySanctuaryIsland { get; } // 0x0000000180E373E0-0x0000000180E37520 
	public GameObject mySanctuaryGround { get; } // 0x0000000180E36FA0-0x0000000180E370E0 
	public GameObject materialParent { get; } // 0x0000000180E36DA0-0x0000000180E36E50 
	public GameObject portalToInteriorObject { get; } // 0x0000000180E377D0-0x0000000180E378C0 
	public SanctuaryPortal portalToInterior { get; } // 0x0000000180E378C0-0x0000000180E379C0 
	public static bool roomOpenL { get; } // 0x0000000180E386A0-0x0000000180E38920 
	public static bool roomOpenR { get; } // 0x0000000180E38920-0x0000000180E38BA0 
	public static bool roomOpenF { get; } // 0x0000000180E38420-0x0000000180E386A0 
	public static bool roomOpenB { get; } // 0x0000000180E37F20-0x0000000180E381A0 
	public static bool roomOpenUp { get; } // 0x0000000180E38BA0-0x0000000180E38E20 
	public static bool roomOpenDown { get; } // 0x0000000180E381A0-0x0000000180E38420 
	public RaycastHit lastSurfaceRaycastHit { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180E36D50-0x0000000180E36D80 0x0000000180E3A170-0x0000000180E3A1A0
	public SanctuarySurface lastSurface { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180E36D80-0x0000000180E36D90 0x0000000180E3A1A0-0x0000000180E3A1B0
	public RaycastHit activeSurfaceRaycastHit { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180E364F0-0x0000000180E36520 0x0000000180E39BF0-0x0000000180E39C20
	public SanctuarySurface activeSurface { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180E36520-0x0000000180E36530 0x0000000180E39C20-0x0000000180E39C30
	public RaycastHit activeSanctuaryObjectRaycastHit { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180E364B0-0x0000000180E364E0 0x0000000180E39BB0-0x0000000180E39BE0
	public SanctuaryObjectBase activeSanctuaryObject { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180E364E0-0x0000000180E364F0 0x0000000180E39BE0-0x0000000180E39BF0
	public SanctuaryObjectBase currentSanctuaryObject { get; private set; } // 0x0000000180E36610-0x0000000180E36620 0x0000000180E39D10-0x0000000180E3A050
	public Camera cachedCamera { get; } // 0x0000000180E36530-0x0000000180E365F0 
	public static string defaultPrefix { get; } // 0x0000000180E36650-0x0000000180E36680 
	public SanctuarySurface controlledSurface { get; set; } // 0x0000000180E365F0-0x0000000180E36600 0x0000000180E39C30-0x0000000180E39D00
	public SanctuaryIndoorRoom currentRoom { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180E36600-0x0000000180E36610 0x0000000180E39D00-0x0000000180E39D10
	public bool isInterior { get; } // 0x0000000180E36CF0-0x0000000180E36D50 
	public float holdTime { get; } // 0x0000000180E36B30-0x0000000180E36B40 
	public float leftMouseButtonHoldTimer { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180E36D90-0x0000000180E36DA0 0x0000000180E3A1B0-0x0000000180E3A1C0
	public float rightMouseButtonHoldTimer { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180E37F10-0x0000000180E37F20 0x0000000180E3A1E0-0x0000000180E3A1F0
	public static float deltaTime { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180E36680-0x0000000180E36740 0x0000000180E3A080-0x0000000180E3A0F0
	public bool moveObject { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180E36E50-0x0000000180E36E60 0x0000000180E3A1D0-0x0000000180E3A1E0
	public bool rotateObject { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180E38E20-0x0000000180E38E30 0x0000000180E3A1F0-0x0000000180E3A200
	public bool wasMoveObject { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180E39B90-0x0000000180E39BA0 0x0000000180E3A200-0x0000000180E3A210
	public bool wasRotateObject { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180E39BA0-0x0000000180E39BB0 0x0000000180E3A210-0x0000000180E3A220
	public bool hasInitialized { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180E36B20-0x0000000180E36B30 0x0000000180E3A100-0x0000000180E3A110
	public bool defaultMaterialsInitialized { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180E36640-0x0000000180E36650 0x0000000180E3A070-0x0000000180E3A080
	public bool hasInitializedInterior { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180E36B10-0x0000000180E36B20 0x0000000180E3A0F0-0x0000000180E3A100

	// Nested types
	[Serializable]
	public class Data // TypeDefIndex: 11754
	{
		// Fields
		public List<SanctuarySurface> sanctuarySurfaces; // 0x10
		private Light[] _mainLights; // 0x18

		// Properties
		public Light[] mainLights { get; } // 0x0000000181285780-0x00000001812857F0 

		// Constructors
		public Data(); // 0x0000000181285720-0x0000000181285780
	}

	public enum EState // TypeDefIndex: 11755
	{
		None = 0,
		Edit = 1
	}

	public enum ETime // TypeDefIndex: 11756
	{
		Day = 0,
		Night = 1
	}

	public enum ELocation // TypeDefIndex: 11757
	{
		Exterior = 0,
		Interior = 1
	}

	public enum ECursorMode // TypeDefIndex: 11758
	{
		NONE = 0,
		CAMERAMOVE = 1,
		CAMERAROTATE = 2,
		OBJECTMOVE = 3,
		OBJECTROTATE = 4
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass296_0 // TypeDefIndex: 11759
	{
		// Fields
		public Material cMat; // 0x10

		// Constructors
		public <>c__DisplayClass296_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <AssignDefaultMatToLayoutData>b__0(Material tLoaded); // 0x000000018036B1E0-0x000000018036B1F0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <AssignDefaultMatToLayoutData>d__296 : IEnumerator<object> // TypeDefIndex: 11760
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public string inDefId; // 0x20
		public SanctuaryController <>4__this; // 0x28
		public Action<Material> inMaterial; // 0x30
		private <>c__DisplayClass296_0 <>8__1; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <AssignDefaultMatToLayoutData>d__296(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181293B90-0x0000000181293D40
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181293D40-0x0000000181293D90
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <InitializeSanctuaryCoroutine>d__297 : IEnumerator<object> // TypeDefIndex: 11761
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SanctuaryController <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <InitializeSanctuaryCoroutine>d__297(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x000000018129BA60-0x000000018129C370
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x000000018129C370-0x000000018129C3C0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass298_0 // TypeDefIndex: 11762
	{
		// Fields
		public GameObject gLoadedExterior; // 0x10
		public GameObject gLoadedInterior; // 0x18

		// Constructors
		public <>c__DisplayClass298_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <InitializeGreenhouse>b__0(GameObject loadedObject); // 0x000000018036B1E0-0x000000018036B1F0
		internal void <InitializeGreenhouse>b__1(GameObject inLoadedAsset); // 0x000000018038B160-0x000000018038B170
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <InitializeGreenhouse>d__298 : IEnumerator<object> // TypeDefIndex: 11763
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public string inDefId; // 0x20
		public SanctuaryController <>4__this; // 0x28
		private <>c__DisplayClass298_0 <>8__1; // 0x30
		private SanctuaryGreenhouseDefComponent <cSanctuaryGreenhouseDefComponent>5__2; // 0x38
		private GameObject <gGreenhouseInteriorObject>5__3; // 0x40
		private string <bundlePath>5__4; // 0x48

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <InitializeGreenhouse>d__298(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x000000018129B330-0x000000018129BA10
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x000000018129BA10-0x000000018129BA60
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass305_0 // TypeDefIndex: 11764
	{
		// Fields
		public bool bShouldTeleport; // 0x10

		// Constructors
		public <>c__DisplayClass305_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <TeleportToSafeAreaCoroutine>b__0(bool b); // 0x00000001803930B0-0x00000001803930C0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass305_1 // TypeDefIndex: 11765
	{
		// Fields
		public bool bShouldTeleport; // 0x10

		// Constructors
		public <>c__DisplayClass305_1(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <TeleportToSafeAreaCoroutine>b__1(bool b); // 0x00000001803930B0-0x00000001803930C0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <TeleportToSafeAreaCoroutine>d__305 : IEnumerator<object> // TypeDefIndex: 11766
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SanctuaryController <>4__this; // 0x20
		private <>c__DisplayClass305_0 <>8__1; // 0x28
		private <>c__DisplayClass305_1 <>8__2; // 0x30
		public bool inFade; // 0x38
		private Transform <cSafeSpawn>5__2; // 0x40
		private float <fFade>5__3; // 0x48
		private List<Transform> <cSafeSpawns>5__4; // 0x50
		private bool <bInCurrentRoom>5__5; // 0x58

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <TeleportToSafeAreaCoroutine>d__305(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x000000018129EE40-0x000000018129F6B0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x000000018129F6B0-0x000000018129F700
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass316_0 // TypeDefIndex: 11767
	{
		// Fields
		public Material cMat; // 0x10

		// Constructors
		public <>c__DisplayClass316_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <SetIndoorMaterialCoroutine>b__0(Material tLoaded); // 0x000000018036B1E0-0x000000018036B1F0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <SetIndoorMaterialCoroutine>d__316 : IEnumerator<object> // TypeDefIndex: 11768
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Item inItem; // 0x20
		public SanctuaryController <>4__this; // 0x28
		private <>c__DisplayClass316_0 <>8__1; // 0x30
		public SanctuaryItemCategory inCategory; // 0x38
		public SanctuaryObjectBase inSanctuaryObjectBase; // 0x40
		public int inRoomId; // 0x48

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <SetIndoorMaterialCoroutine>d__316(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x000000018129D7D0-0x000000018129DB60
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x000000018129DB60-0x000000018129DBB0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass318_0 // TypeDefIndex: 11769
	{
		// Fields
		public Material cResult; // 0x10

		// Constructors
		public <>c__DisplayClass318_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <GetSanctuaryMaterial>b__0(Material cLoaded); // 0x000000018036B1E0-0x000000018036B1F0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <GetSanctuaryMaterial>d__318 : IEnumerator<object> // TypeDefIndex: 11770
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public BaseDef inBaseDef; // 0x20
		public GameObject inGameObject; // 0x28
		public Action<Material> inResult; // 0x30
		private <>c__DisplayClass318_0 <>8__1; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <GetSanctuaryMaterial>d__318(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181299F30-0x000000018129A0C0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x000000018129A0C0-0x000000018129A110
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <SetStepHeight>d__357 : IEnumerator<object> // TypeDefIndex: 11771
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SanctuaryController <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <SetStepHeight>d__357(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x000000018129DBB0-0x000000018129DD70
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x000000018129DD70-0x000000018129DDC0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <Fade>d__366 : IEnumerator<object> // TypeDefIndex: 11772
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SanctuaryController <>4__this; // 0x20
		public SanctuaryTeleportMessage inMessage; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <Fade>d__366(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181296760-0x0000000181296C70
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181296C70-0x0000000181296CC0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <UpdateLights>d__374 : IEnumerator<object> // TypeDefIndex: 11773
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SanctuaryController <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <UpdateLights>d__374(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001812A07C0-0x00000001812A08A0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001812A08A0-0x00000001812A08F0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass377_0 // TypeDefIndex: 11774
	{
		// Fields
		public string sID; // 0x10

		// Constructors
		public <>c__DisplayClass377_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <UpdateItem>b__0(UpdateItem ui); // 0x0000000180EB3C90-0x0000000180EB3CC0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass390_0 // TypeDefIndex: 11775
	{
		// Fields
		public UpdateItem cUpdateItem; // 0x10

		// Constructors
		public <>c__DisplayClass390_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <ShouldTeleport>b__0(SanctuaryObjectBase sob); // 0x000000018129FD30-0x000000018129FD80
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <ShouldTeleport>d__390 : IEnumerator<object> // TypeDefIndex: 11776
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SanctuaryController <>4__this; // 0x20
		private <>c__DisplayClass390_0 <>8__1; // 0x28
		public Action<bool> result; // 0x30
		private bool <bTeleport>5__2; // 0x38
		private List<UpdateItem> <>7__wrap2; // 0x40
		private SanctuaryObjectBase <cSanctuaryObjectBase>5__4; // 0x58

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <ShouldTeleport>d__390(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x000000018129E1B0-0x000000018129E260
		private bool MoveNext(); // 0x000000018129DDC0-0x000000018129E160
		private void <>m__Finally1(); // 0x000000018129E260-0x000000018129E2A0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x000000018129E160-0x000000018129E1B0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <CheckTeleportToSafeArea>d__391 : IEnumerator<object> // TypeDefIndex: 11777
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SanctuaryController <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <CheckTeleportToSafeArea>d__391(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181296640-0x0000000181296710
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181296710-0x0000000181296760
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass399_0 // TypeDefIndex: 11778
	{
		// Fields
		public Item inItem; // 0x10

		// Constructors
		public <>c__DisplayClass399_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <ItemIsEquipped>b__0(SanctuaryObjectBase so); // 0x0000000180E3E330-0x0000000180E3E380
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass402_0 // TypeDefIndex: 11779
	{
		// Fields
		public SanctuaryObjectBase cSanctuaryObjectBase; // 0x10
		public Item inItem; // 0x18
		public SanctuaryItemDefComponent cSanctuaryItemDefComponent; // 0x20
		public SanctuaryObjectBaseInfo cSanctuaryObjectBaseInfo; // 0x28
		public SanctuaryController <>4__this; // 0x30
		public Action<GameObject> Callback; // 0x38

		// Constructors
		public <>c__DisplayClass402_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <SpawnPlacedItemFromUI>b__0(GameObject gInstancedAsset); // 0x000000018129FF20-0x000000018129FFF0
		internal void <SpawnPlacedItemFromUI>b__1(GameObject gInstancedAsset); // 0x000000018129FFF0-0x00000001812A0130
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <MovePlacedItemFromUI>d__403 : IEnumerator<object> // TypeDefIndex: 11780
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SanctuaryObjectBase inSanctuaryObjectBase; // 0x20
		public SanctuaryController <>4__this; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <MovePlacedItemFromUI>d__403(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x000000018129D3F0-0x000000018129D780
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x000000018129D780-0x000000018129D7D0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass447_0 // TypeDefIndex: 11781
	{
		// Fields
		public RoomData cServerRoomData; // 0x10

		// Constructors
		public <>c__DisplayClass447_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <UpdateChangedServerRoomData>b__0(RoomData data); // 0x00000001812A0130-0x00000001812A0160
		internal bool <UpdateChangedServerRoomData>b__1(RoomData data); // 0x00000001812A0130-0x00000001812A0160
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <SpawnPortalToInterior>d__457 : IEnumerator<object> // TypeDefIndex: 11782
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SanctuaryController <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <SpawnPortalToInterior>d__457(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x000000018129E720-0x000000018129EDF0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x000000018129EDF0-0x000000018129EE40
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 11783
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<RoomData, RoomData> <>9__477_0; // 0x08
		public static Func<RoomData, RoomData> <>9__477_1; // 0x10

		// Constructors
		static <>c(); // 0x00000001812A0700-0x00000001812A0760
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal RoomData <InitializeRoomDetails>b__477_0(RoomData roomData); // 0x000000018129F700-0x000000018129F730
		internal RoomData <InitializeRoomDetails>b__477_1(RoomData roomData); // 0x000000018129F700-0x000000018129F730
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass488_0 // TypeDefIndex: 11784
	{
		// Fields
		public GameObject gSanctuary; // 0x10
		public Action<GameObject> inResult; // 0x18

		// Constructors
		public <>c__DisplayClass488_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <BuildSanctuaryForUI>b__0(List<GameObject> gLoaded); // 0x00000001812A0160-0x00000001812A0290
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass489_0 // TypeDefIndex: 11785
	{
		// Fields
		public GameObject gSanctuaryMod; // 0x10
		public Action<GameObject> inResult; // 0x18

		// Constructors
		public <>c__DisplayClass489_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <BuildHouseModForUI>b__0(GameObject gLoaded); // 0x00000001812A0290-0x00000001812A03C0
	}

	// Constructors
	public SanctuaryController(); // 0x0000000180E36210-0x0000000180E364B0
	static SanctuaryController(); // 0x0000000180E35F00-0x0000000180E36210

	// Methods
	public override void MStart(); // 0x0000000180E2AD40-0x0000000180E2AFE0
	public void InitializeSanctuary(SanctuaryLayoutData inLayoutData, int inCurrentExpansionIdx, int inPurchasedRoomIdx, List<int> inCurrentEnlargedAreas, List<int> inPurchasedEnlargedAreas, List<SanctuaryHouseDefComponent.TwiggleBuildLocation> inTwiggleBuildLocations); // 0x0000000180E29E00-0x0000000180E29F70
	[IteratorStateMachine] // 0x0000000180117AF0-0x0000000180117B40
	private IEnumerator AssignDefaultMatToLayoutData(string inDefId, Action<Material> inMaterial); // 0x0000000180E1F3D0-0x0000000180E1F460
	[IteratorStateMachine] // 0x0000000180117CE0-0x0000000180117D30
	private IEnumerator InitializeSanctuaryCoroutine(); // 0x0000000180E29D90-0x0000000180E29E00
	[IteratorStateMachine] // 0x0000000180117E80-0x0000000180117ED0
	private IEnumerator InitializeGreenhouse(string inDefId); // 0x0000000180E29AC0-0x0000000180E29B40
	private void SetDefaultMaterial(SanctuaryItemCategory inCategory, Material inMaterial, SanctuaryIndoorRoom inSanctuaryIndoorRoom); // 0x0000000180E2F060-0x0000000180E2F360
	private void SetDefaultMaterials(SanctuaryIndoorRoom inSanctuaryIndoorRoom, SanctuaryItemCategory? inCategory); // 0x0000000180E2F360-0x0000000180E2F540
	private SanctuaryObjectBase CreateTempSanctuaryObjectBase(int inRoomId); // 0x0000000180E246D0-0x0000000180E24760
	private Item CreateNewItem(ItemType inItemType, BaseDef inDef); // 0x0000000180E23A10-0x0000000180E23A80
	public void Decorate(bool inDecorate); // 0x0000000180E24CA0-0x0000000180E24CC0
	public void TeleportToSafeArea(bool inFade); // 0x0000000180E33030-0x0000000180E330B0
	[IteratorStateMachine] // 0x0000000180119220-0x0000000180119270
	private IEnumerator TeleportToSafeAreaCoroutine(bool inFade); // 0x0000000180E32FB0-0x0000000180E33030
	private static Transform GetTransformFromName(Transform inTransform, string[] inExcludeNames, params /* 0x00000001800B36B0-0x00000001800B36C0 */ string[] inNames); // 0x0000000180E287C0-0x0000000180E28940
	public static Transform GetTransform(List<Transform> inTransforms, string[] inExcludeNames, params /* 0x00000001800B36B0-0x00000001800B36C0 */ string[] inNames); // 0x0000000180E28940-0x0000000180E28B90
	public static List<Transform> GetTransforms(List<Transform> inTransforms, string[] inExcludeNames, params /* 0x00000001800B36B0-0x00000001800B36C0 */ string[] inNames); // 0x0000000180E28B90-0x0000000180E28E10
	public void SetExteriorInteriorFlooring(Material inMaterial); // 0x0000000180E2F830-0x0000000180E2F950
	public void SetExteriorInteriorWallpaper(Material inMaterial); // 0x0000000180E2F950-0x0000000180E2FA70
	public static void DestroyMeshRenderer(Transform inTransform); // 0x0000000180E24DC0-0x0000000180E24E60
	public static void DestroyMeshRenderer(GameObject inGameObject); // 0x0000000180E24E60-0x0000000180E24F40
	private void AddCursors(); // 0x0000000180E1E8B0-0x0000000180E1EA30
	private void SetCursor(ECursorMode inMode); // 0x0000000180E2EFA0-0x0000000180E2F060
	public void SetIndoorMaterials(SanctuaryItemCategory inCategory, Item inItem, SanctuaryObjectBase inSanctuaryObjectBase, int inRoomId); // 0x0000000180E2FFB0-0x0000000180E30060
	[IteratorStateMachine] // 0x0000000180119740-0x0000000180119790
	private IEnumerator SetIndoorMaterialCoroutine(SanctuaryItemCategory inCategory, Item inItem, SanctuaryObjectBase inSanctuaryObjectBase, int inRoomId); // 0x0000000180E2FA70-0x0000000180E2FB10
	private void SetIndoorMaterial(SanctuaryItemCategory inCategory, Material inMaterial, SanctuaryObjectBase inSanctuaryObjectBase, int inRoomId); // 0x0000000180E2FB10-0x0000000180E2FFB0
	[IteratorStateMachine] // 0x00000001801198F0-0x0000000180119940
	private static IEnumerator GetSanctuaryMaterial(GameObject inGameObject, BaseDef inBaseDef, Action<Material> inResult); // 0x0000000180E27020-0x0000000180E270B0
	public void SetActiveIsland(SanctuaryObjectBase inSanctuaryObjectBase); // 0x0000000180E2E920-0x0000000180E2E930
	public void SetActiveHouse(SanctuaryObjectBase inSanctuaryObjectBase); // 0x0000000180E2E910-0x0000000180E2E920
	public void AddChildSanctuaryObject(SanctuaryObjectBase inSanctuaryObjectBase); // 0x0000000180E1E850-0x0000000180E1E8B0
	public void RemoveChildSanctuaryObject(SanctuaryObjectBase inSanctuaryObjectBase); // 0x0000000180E2D430-0x0000000180E2D490
	public void AddActiveSanctuaryObject(SanctuaryObjectBase inSanctuaryObjectBase); // 0x0000000180E1E7F0-0x0000000180E1E850
	public void RemoveActiveSanctuaryObject(SanctuaryObjectBase inSanctuaryObjectBase); // 0x0000000180E2CD60-0x0000000180E2CDC0
	private void UpdateParents(); // 0x0000000180E351A0-0x0000000180E35470
	private void UpdateSanctuarySurfaces(); // 0x0000000180E35470-0x0000000180E35A80
	private SanctuaryObjectBase GetSanctuaryObjectAtMousePosition(out RaycastHit outHit, bool inCheckCurrentSanctuaryObject = false /* Metadata: 0x00782BB7 */); // 0x0000000180E270B0-0x0000000180E276C0
	private void UpdateCurrentSanctuaryObject(); // 0x0000000180E345C0-0x0000000180E34620
	public static void DestroyColliders(List<Transform> inTransforms); // 0x0000000180E24CC0-0x0000000180E24DC0
	private void UpdateActiveSanctuaryObject(); // 0x0000000180E33FE0-0x0000000180E34050
	public static void CreateMeshCollidersForIsland(GameObject inGameObject); // 0x0000000180E236F0-0x0000000180E23A10
	public static MeshCollider CreateMeshCollider(GameObject inGameObject); // 0x0000000180E23080-0x0000000180E236F0
	public static void CreateHouseCollider(GameObject inGameObject); // 0x00000001803581E0-0x00000001803581F0
	public static void CreateTouchCollider(List<GameObject> inGameObjects); // 0x0000000180E24BF0-0x0000000180E24CA0
	public static BoxCollider CreateTouchCollider(GameObject inGameObject); // 0x0000000180E24760-0x0000000180E24BF0
	public static void CreateMeshColliderPlayer(List<GameObject> inGameObjects); // 0x0000000180E22FD0-0x0000000180E23080
	public static MeshCollider CreateMeshColliderPlayer(GameObject inGameObject); // 0x0000000180E22B00-0x0000000180E22FD0
	public void SpawnWorldPortal(Transform inParent); // 0x0000000180E32CE0-0x0000000180E32DF0
	private void ChangeExteriorComponent(string inName, int inIndex); // 0x00000001803581E0-0x00000001803581F0
	private void ChangeExteriorComponentColor(string inName, Color inColor1, Color inColor2); // 0x00000001803581E0-0x00000001803581F0
	public static void SplitAllMaterialsTracked(Transform inTransform); // 0x0000000180E32DF0-0x0000000180E32E50
	private static bool SkipTransformPerName(string inName); // 0x0000000180E32220-0x0000000180E324B0
	private static bool SkipMaterialPerName(string inName); // 0x0000000180E31F90-0x0000000180E32220
	public static void SplitMaterials(List<Transform> inTransforms); // 0x0000000180E32EB0-0x0000000180E32FB0
	public static void SplitMaterials(Transform inTransforms); // 0x0000000180E32E50-0x0000000180E32EB0
	public static List<MeshRenderer> GetMeshRenderers(List<Transform> inList); // 0x0000000180E26530-0x0000000180E267D0
	public static void SetMaterial(List<Transform> inTransforms, Material inMaterial, bool bAllowSkip = true /* Metadata: 0x00782BB8 */); // 0x0000000180E30810-0x0000000180E30900
	public static void SetMaterial(GameObject inGameObject, Material inMaterial, bool bAllowSkip = true /* Metadata: 0x00782BB9 */); // 0x0000000180E30A30-0x0000000180E30B80
	public static void SetMaterial(Transform inTransform, Material inMaterial, bool bAllowSkip = true /* Metadata: 0x00782BBA */); // 0x0000000180E30900-0x0000000180E30A30
	public static void SetMaterial(MeshRenderer inMeshRenderer, Material inMaterial, bool bAllowSkip = true /* Metadata: 0x00782BBB */); // 0x0000000180E30B80-0x0000000180E30E00
	public static List<Material> GetMaterials(List<Transform> inList); // 0x0000000180E26230-0x0000000180E26530
	public static List<Transform> GetRenderersTransform(Transform inParent); // 0x0000000180E267D0-0x0000000180E269E0
	[IteratorStateMachine] // 0x0000000180119B50-0x0000000180119BA0
	private IEnumerator SetStepHeight(); // 0x0000000180E31CB0-0x0000000180E31D20
	public void OnCloseDecorateWindow(); // 0x0000000180E2B510-0x0000000180E2B5D0
	public override void MOnDestroy(); // 0x0000000180E2A900-0x0000000180E2AD40
	private void OnSanctuaryInteriorExteriorChange(SanctuaryInteriorExteriorChange inMessage); // 0x0000000180E2BD50-0x0000000180E2BEC0
	private void SetPriorStepHeight(float inStepHeight); // 0x0000000180E30EA0-0x0000000180E30FB0
	private void SetStepHeight(float inStepHeight); // 0x0000000180E31D20-0x0000000180E31E30
	private void OnSanctuaryTeleportMessage(SanctuaryTeleportMessage inMessage); // 0x0000000180E2CB90-0x0000000180E2CC10
	private void FadeToBlack(float inTime = 1f /* Metadata: 0x00782BBC */); // 0x0000000180E24F40-0x0000000180E24F50
	private void FadeToGame(float inTime = 1f /* Metadata: 0x00782BC0 */); // 0x0000000180E24F50-0x0000000180E24F60
	[IteratorStateMachine] // 0x0000000180119D20-0x0000000180119D70
	private IEnumerator Fade(SanctuaryTeleportMessage inMessage); // 0x0000000180E24F60-0x0000000180E24FE0
	private void OnSanctuaryIndoorRoomMessage(SanctuaryIndoorRoomMessage inMessage); // 0x0000000180E2BBF0-0x0000000180E2BD50
	public void AddSanctuaryObject(SanctuaryObjectBase inSanctuaryObject); // 0x0000000180E1EAE0-0x0000000180E1EE40
	public void RemoveSanctuaryObject(SanctuaryObjectBase inSanctuaryObject); // 0x0000000180E2DCD0-0x0000000180E2DE20
	private void RevertMaterialToDefault(SanctuaryObjectBase inSanctuaryObject); // 0x0000000180E2DE40-0x0000000180E2DFC0
	public void RemoveAllSanctuaryObjectsInRoom(); // 0x0000000180E2CDC0-0x0000000180E2CDF0
	public void RemoveAllSanctuaryObjectsInRoom(int inRoomIdx, bool inForceServerUpdate = false /* Metadata: 0x00782BC4 */); // 0x0000000180E2CDF0-0x0000000180E2D430
	[DebugButton] // 0x000000018011A090-0x000000018011A0F0
	public void SaveMySanctuaryState(); // 0x0000000180E2E310-0x0000000180E2E820
	[IteratorStateMachine] // 0x000000018011A210-0x000000018011A260
	private IEnumerator UpdateLights(); // 0x0000000180E35130-0x0000000180E351A0
	public void OnNonOwnerUpdateMessage(SanctuaryXtHandler.DenStateUpdateResponse inMessage); // 0x0000000180E2B5D0-0x0000000180E2BBF0
	public void RemoveItem(SanctuaryObjectBase inSanctuaryObjectBase); // 0x0000000180E2D960-0x0000000180E2DCD0
	public void UpdateItem(SanctuaryObjectBase inSanctuaryObjectBase); // 0x0000000180E34C10-0x0000000180E35130
	public override void MUpdate(); // 0x0000000180E2AFE0-0x0000000180E2B490
	private void UpdateCameraMode(); // 0x0000000180E34050-0x0000000180E34220
	public static bool IsOnGround(Vector3 inNormalDir); // 0x0000000180E2A650-0x0000000180E2A670
	private void SetActiveSkybox(bool inInterior); // 0x0000000180E2E9D0-0x0000000180E2EA70
	private void SetActiveLights(bool inInterior); // 0x0000000180E2E930-0x0000000180E2E9D0
	private void SetActiveAudio(List<SanctuaryAudio> inSanctuaryAudios, bool inActive); // 0x0000000180E2E820-0x0000000180E2E910
	public static string AddOrdinal(int inValue); // 0x0000000180E1EA30-0x0000000180E1EAE0
	public string GetFloorName(); // 0x0000000180E253D0-0x0000000180E256F0
	private void SetSanctuaryObjectActive(SanctuaryObjectBase inSanctuaryObject, bool inActive); // 0x0000000180E31A10-0x0000000180E31B20
	private void UpdateActions(); // 0x0000000180E33150-0x0000000180E33FE0
	private RaycastHit GetActiveHit(); // 0x0000000180E24FE0-0x0000000180E25290
	private void SetLastGood(); // 0x0000000180E306B0-0x0000000180E30810
	[IteratorStateMachine] // 0x000000018011A750-0x000000018011A7A0
	private IEnumerator ShouldTeleport(Action<bool> result); // 0x0000000180E31F10-0x0000000180E31F90
	[IteratorStateMachine] // 0x000000018011AA60-0x000000018011AAB0
	private IEnumerator CheckTeleportToSafeArea(); // 0x0000000180E218E0-0x0000000180E21950
	private void UpdateState(); // 0x0000000180E35A80-0x0000000180E35EE0
	public void UpdateHighlightColor(bool inValidPosition); // 0x0000000180E34620-0x0000000180E347B0
	private void Ray(Ray inRay, int inLayermask, Action<Vector3?> HitPoint); // 0x0000000180E2CC10-0x0000000180E2CD60
	private void CreateHighlight(); // 0x0000000180E224E0-0x0000000180E22B00
	private void UpdateHighlight(); // 0x0000000180E347B0-0x0000000180E34C10
	private static void OnSanctuaryObjectUpdateMessage(SanctuaryObjectUpdateMessage inMessage); // 0x0000000180E2BEC0-0x0000000180E2CB90
	public static Quaternion GetSurfaceRotation(Vector3 inNormal, Transform inTransform); // 0x0000000180E286A0-0x0000000180E287C0
	public bool ItemIsEquipped(Item inItem); // 0x0000000180E2A750-0x0000000180E2A860
	public void SpawnFromUI(Item inItem, bool inWasDragged = false /* Metadata: 0x00782BC5 */, BaseDef inFakeObject = null, Action<GameObject> Callback = null); // 0x0000000180E324B0-0x0000000180E324C0
	public void RemoveFromUI(Item inItem, int inRoomIdx = -1 /* Metadata: 0x00782BC6 */); // 0x0000000180E2D630-0x0000000180E2D960
	private void SpawnPlacedItemFromUI(Item inItem, bool inWasDragged = false /* Metadata: 0x00782BCA */, BaseDef inFakeObject = null, Action<GameObject> Callback = null); // 0x0000000180E324C0-0x0000000180E32C70
	[IteratorStateMachine] // 0x000000018011ABA0-0x000000018011ABF0
	private IEnumerator MovePlacedItemFromUI(SanctuaryObjectBase inSanctuaryObjectBase); // 0x0000000180E2B490-0x0000000180E2B510
	private SanctuarySurface GetSurfaceFromRay(bool inWasDragged, out Vector3 oPosition, out int oSurfaceIndex); // 0x0000000180E27AD0-0x0000000180E28500
	public int GetSurfaceIndex(SanctuaryObjectBase inSanctuaryObject); // 0x0000000180E28670-0x0000000180E286A0
	public int GetSurfaceIndex(SanctuarySurface inSanctuarySurface); // 0x0000000180E28500-0x0000000180E28670
	public Vector3 GetWorldPosition(SanctuaryObjectBase inSanctuaryObjectBase, int inSurfaceIdx, Vector3 inLocalPosition); // 0x0000000180E28EB0-0x0000000180E29060
	public Vector3 GetLocalPosition(SanctuaryObjectBase inSanctuaryObjectBase, int inSurfaceIdx, Vector3 inWorldPosition); // 0x0000000180E25D00-0x0000000180E25EB0
	public void SetPositionAndRotation(SanctuaryObjectBase inSanctuaryObjectBase, int inSurfaceIdx, Vector3 inLocalPosition, Quaternion inWorldRotation); // 0x0000000180E30E00-0x0000000180E30EA0
	public SanctuarySurface GetSanctuarySurface(int inIndex); // 0x0000000180E276C0-0x0000000180E27910
	public void AddSurfaces(SanctuarySurface[] inSanctuarySurfaces); // 0x0000000180E1F060-0x0000000180E1F100
	public void SetState(EState inState); // 0x0000000180E31B20-0x0000000180E31CB0
	public void GoToRoomLeft(); // 0x0000000180E296F0-0x0000000180E29790
	public void GoToRoomRight(); // 0x0000000180E29790-0x0000000180E29830
	public void GoToRoomForward(); // 0x0000000180E29650-0x0000000180E296F0
	public void GoToRoomBack(); // 0x0000000180E29510-0x0000000180E295B0
	public void GoToRoomUpstairs(); // 0x0000000180E29830-0x0000000180E298D0
	public void GoToRoomDownstairs(); // 0x0000000180E295B0-0x0000000180E29650
	public void GoToDayTime(); // 0x0000000180E29060-0x0000000180E29070
	public void GoToNightTime(); // 0x0000000180E29500-0x0000000180E29510
	private void UpdateTime(); // 0x00000001803581E0-0x00000001803581F0
	public void GoToInterior(); // 0x0000000180E292D0-0x0000000180E29500
	public void GoToExterior(); // 0x0000000180E29070-0x0000000180E292D0
	public void CameraReset(); // 0x0000000180E20CD0-0x0000000180E20D60
	public void CameraZoomOut(); // 0x0000000180E20DB0-0x0000000180E20DF0
	public void CameraZoomIn(); // 0x0000000180E20D60-0x0000000180E20DB0
	public void RoomUpgrade(); // 0x00000001803581E0-0x00000001803581F0
	public void RoomDowngrade(); // 0x00000001803581E0-0x00000001803581F0
	public void SaveChanges(); // 0x0000000180E2E300-0x0000000180E2E310
	public void LoadSanctuaryLook(SanctuaryLookItemComponent inSanctuaryLook); // 0x0000000180E2A860-0x0000000180E2A900
	public void BuildInteriorLayout(); // 0x0000000180E1F690-0x0000000180E20AB0
	private void InstanceInteriorRooms(); // 0x0000000180E29F70-0x0000000180E2A130
	private void CreateSanctuaryIndoorRooms(); // 0x0000000180E23DE0-0x0000000180E24620
	public void SetSafeSpawnHouseEntrance(Vector3 inPosition, Vector3 inRotation); // 0x0000000180E31720-0x0000000180E317F0
	public SanctuaryIndoorRoom GetRoomIndex(int inIdx); // 0x0000000180E26D40-0x0000000180E26E80
	public SanctuaryIndoorRoom GetRoomIndex(SanctuarySurface inSurface); // 0x0000000180E26BF0-0x0000000180E26D40
	private void SetRoomIndexes(); // 0x0000000180E311E0-0x0000000180E31530
	private void SetRoomSizes(); // 0x0000000180E31530-0x0000000180E31720
	private void SetInteriorRoomDoors(); // 0x0000000180E30140-0x0000000180E306B0
	public bool GetIsInCurrentRoom(Item inItem); // 0x0000000180E25740-0x0000000180E25910
	public string GetRoomIdForUI(Item inItem); // 0x0000000180E26A60-0x0000000180E26BC0
	private int GetRoomIndexFromRoom(SanctuaryObjectBase inSanctuaryObjectBase); // 0x0000000180E26BC0-0x0000000180E26BF0
	private string GetIdFromRoomForUI(SanctuaryObjectBase inSanctuaryObjectBase); // 0x0000000180E256F0-0x0000000180E25740
	public string GetRoomIdForUI(int inRoomIndex); // 0x0000000180E269F0-0x0000000180E26A20
	public string GetRoomIdForUI(); // 0x0000000180E26A20-0x0000000180E26A60
	public void SetRoomIdFromUI(int inRoomIndex, string inString); // 0x0000000180E311B0-0x0000000180E311E0
	private void UpdateChangedServerRoomData(); // 0x0000000180E34220-0x0000000180E345C0
	private RoomData GetServerRoomData(int inRoomIndex); // 0x0000000180E27910-0x0000000180E27AD0
	public void SetRoomIdFromUI(string inString); // 0x0000000180E31170-0x0000000180E311B0
	private string GetLocallySavedRoomIdFromRoomIndex(int inRoomIndex); // 0x0000000180E25EB0-0x0000000180E26230
	public float GetRoomLightRotation(int inRoomIndex); // 0x0000000180E26EE0-0x0000000180E26F10
	public string GetRoomLightColor(int inRoomIndex); // 0x0000000180E26EB0-0x0000000180E26EE0
	public float GetRoomLightBrightness(int inRoomIndex); // 0x0000000180E26E80-0x0000000180E26EB0
	private void SetInteriorRoomAddOns(); // 0x0000000180E30060-0x0000000180E30140
	public BaseDef GetExpansionDef(int inRoomId); // 0x0000000180E25330-0x0000000180E253D0
	public BaseDef GetUpgradeDef(int inRoomId); // 0x0000000180E28E10-0x0000000180E28EB0
	[IteratorStateMachine] // 0x000000018011ADD0-0x000000018011AE20
	private IEnumerator SpawnPortalToInterior(); // 0x0000000180E32C70-0x0000000180E32CE0
	private void CreateAudio(); // 0x0000000180E21D20-0x0000000180E221E0
	private void CreateRespawns(); // 0x0000000180E23A80-0x0000000180E23DE0
	private GameObject CreateBoundary(GameObject inParent, Vector3 inSize); // 0x0000000180E221E0-0x0000000180E222E0
	private GameObject Instance(GameObject inPrefab, GameObject inParent); // 0x0000000180E2A440-0x0000000180E2A540
	private GameObject CreateCubeObject(GameObject inPrefab, GameObject inParent, bool inCastShadows = false /* Metadata: 0x00782BCB */); // 0x0000000180E222E0-0x0000000180E224E0
	private static void SetCollider(GameObject inGameObject); // 0x0000000180E2EE90-0x0000000180E2EFA0
	private bool RoomIsEnlarged(int inRoomIdx); // 0x0000000180E2DFC0-0x0000000180E2E040
	private GameObject InstanceRoom(SanctuaryLayoutData.RoomData inRoomData, SanctuaryIndoorRoom inSanctuaryIndoorRoom, Transform inParent); // 0x0000000180E2A130-0x0000000180E2A440
	private int GetCurrentRoomIndex(); // 0x0000000180E25290-0x0000000180E25330
	private List<Light> GetLights(); // 0x0000000180E25B10-0x0000000180E25D00
	public float GetLightIntensity(); // 0x0000000180E25A90-0x0000000180E25AD0
	public void ChangeLightIntensity(float inIntensity); // 0x0000000180E215E0-0x0000000180E21660
	private void ChangeLightIntensityFromRoom(); // 0x0000000180E21440-0x0000000180E215E0
	public float GetLightRotation(); // 0x0000000180E25AD0-0x0000000180E25B10
	public void ChangeLightRotation(float inValue); // 0x0000000180E21860-0x0000000180E218E0
	private void ChangeLightRotationFromRoom(); // 0x0000000180E21660-0x0000000180E21860
	public SanctuaryLightDefComponent GetLightColor(); // 0x0000000180E25910-0x0000000180E25A90
	public void ChangeLightColor(SanctuaryLightDefComponent inValue); // 0x0000000180E213D0-0x0000000180E21440
	private void ChangeLightColorFromRoom(); // 0x0000000180E21250-0x0000000180E213D0
	public void InitializeRoomDetails(List<RoomData> inRoomData); // 0x0000000180E29B40-0x0000000180E29D90
	public static void SetCastShadowsOff(GameObject inGameObject, bool inIncludeChildren); // 0x0000000180E2ECF0-0x0000000180E2EE90
	public static void SetCastAndReceiveShadowsOff(List<Transform> inTransforms); // 0x0000000180E2EB60-0x0000000180E2EC10
	public static void SetCastAndReceiveShadowsOff(GameObject inGameObject); // 0x0000000180E2EA70-0x0000000180E2EB60
	public static void SetCastAndReceiveShadowsOff(Transform inTransform); // 0x0000000180E2EC10-0x0000000180E2ECF0
	public static void RemoveColliders(List<Transform> inTransforms); // 0x0000000180E2D580-0x0000000180E2D630
	public static void RemoveColliders(Transform inTransform); // 0x0000000180E2D490-0x0000000180E2D580
	public static void AddSanctuarySurfaceComponent(List<Transform> inTransforms); // 0x0000000180E1EE40-0x0000000180E1EEF0
	public static void AddSanctuarySurfaceComponent(Transform inTransform); // 0x0000000180E1EF60-0x0000000180E1F060
	public static void AddSanctuarySurfaceComponent(GameObject inGameObject); // 0x0000000180E1EEF0-0x0000000180E1EF60
	private GameObject CreateSpawn(GameObject inParent, float inWallY, float inDoorY); // 0x0000000180E24620-0x0000000180E246D0
	public static void BuildSanctuaryForUI(Action<GameObject> inResult, Item inItem = null, BaseDef inDef = null, int inModIndex = -1 /* Metadata: 0x00782BCC */); // 0x0000000180E20AB0-0x0000000180E20CD0
	public static void BuildHouseModForUI(SanctuaryHouseGetModelDefComponent.EHouseMod inType, Action<GameObject> inResult, Item inItem = null, BaseDef inDef = null, int inModIndex = -1 /* Metadata: 0x00782BD0 */); // 0x0000000180E1F460-0x0000000180E1F690
	public bool IsPurchasingRoomOrRoomUpgrade(int inRoomIndex); // 0x0000000180E2A670-0x0000000180E2A690
	public bool IsPurchasingRoom(int inRoomIndex); // 0x0000000180E2A740-0x0000000180E2A750
	public bool IsPurchasingRoomUpgrade(int inRoomIndex); // 0x0000000180E2A690-0x0000000180E2A740
	public bool CanPurchaseRoom(int inRoomIndex); // 0x0000000180E20F90-0x0000000180E21040
	public bool CanPurchaseUpgradeRoom(int inRoomIndex); // 0x0000000180E21040-0x0000000180E21130
	public bool CanUpgradeRoom(int inRoomIndex); // 0x0000000180E21130-0x0000000180E21250
	public bool CanDowngradeRoom(int inRoomIndex); // 0x0000000180E20EA0-0x0000000180E20F70
	public bool CanDisableRoom(int inRoomIndex); // 0x0000000180E20E80-0x0000000180E20EA0
	public bool CanEnableRoom(int inRoomIndex); // 0x0000000180E20F70-0x0000000180E20F90
	public bool CanAddRoom(); // 0x0000000180E20DF0-0x0000000180E20E80
	public bool GetIsEntranceRoom(int inRoomIndex); // 0x0000000180A05CD0-0x0000000180A05CE0
	public bool GetRoomUpgradePurchased(int inRoomIndex); // 0x0000000180E26F20-0x0000000180E26FB0
	public void SetEnabledRoom(int inRoomIndex); // 0x0000000180E2F7A0-0x0000000180E2F830
	public void SetDisabledRoom(int inRoomIndex); // 0x0000000180E2F540-0x0000000180E2F6C0
	public void SetPurchaseRoom(int inRoomIndex); // 0x0000000180E30FB0-0x0000000180E31060
	public void SetUpgrade(int inRoomIndex); // 0x0000000180E31E30-0x0000000180E31F10
	public void SetPurchaseUpgrade(int inRoomIndex, bool inUpgrade); // 0x0000000180E31060-0x0000000180E31170
	public void SetDowngrade(int inRoomIndex); // 0x0000000180E2F6C0-0x0000000180E2F7A0
	public bool HasModifications(); // 0x0000000180E298D0-0x0000000180E299D0
	public bool HasPurchases(); // 0x0000000180E299D0-0x0000000180E29AC0
	private void ClearPendingPurchases(); // 0x0000000180E21AE0-0x0000000180E21C10
	public bool GetRoomEnabled(int inRoomIndex); // 0x0000000180E269E0-0x0000000180E269F0
	public bool GetRoomPurchased(int inRoomIndex); // 0x0000000180E26F10-0x0000000180E26F20
	public bool GetRoomUpgraded(int inRoomIndex); // 0x0000000180E26FB0-0x0000000180E27020
	public bool IsDowngradingAnyRoom(); // 0x0000000180E2A540-0x0000000180E2A650
	public bool AnyFurnitureInDowngradingRooms(); // 0x0000000180E1F100-0x0000000180E1F260
	private bool SanctuaryObjectExistsInRoom(SanctuaryIndoorRoom inRoom); // 0x0000000180E2E040-0x0000000180E2E300
	public bool AnyFurnitureInRoom(int inRoomIdx = -1 /* Metadata: 0x00782BD4 */); // 0x0000000180E1F260-0x0000000180E1F3D0
	public void SetSanctuaryJobStart(); // 0x0000000180E31870-0x0000000180E31A10
	private void ClearAnyDowngradedRooms(); // 0x0000000180E21950-0x0000000180E21A50
	private void VerifyPurchaseVariable(); // 0x0000000180E35EE0-0x0000000180E35F00
	public void ResetSanctuaryJobVariables(); // 0x0000000180E2DE20-0x0000000180E2DE40
	public void ClearPurchase(); // 0x0000000180E21C10-0x0000000180E21D20
	public void ClearModifications(); // 0x0000000180E21A50-0x0000000180E21AE0
	public void SetSanctuaryJobComplete(); // 0x0000000180E317F0-0x0000000180E31870
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <InitializeSanctuaryCoroutine>b__297_0(Material cMat); // 0x0000000180E330C0-0x0000000180E330E0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <InitializeSanctuaryCoroutine>b__297_1(Material cMat); // 0x0000000180E330E0-0x0000000180E33100
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <InitializeSanctuaryCoroutine>b__297_2(Material cMat); // 0x0000000180E33100-0x0000000180E33120
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <InitializeSanctuaryCoroutine>b__297_3(Material cMat); // 0x0000000180E33120-0x0000000180E33140
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <CheckTeleportToSafeArea>b__391_0(bool b); // 0x0000000180E330B0-0x0000000180E330C0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <SetState>b__412_0(UI3D_SanctuaryItem loaded3DUI); // 0x0000000180E33140-0x0000000180E33150
}

