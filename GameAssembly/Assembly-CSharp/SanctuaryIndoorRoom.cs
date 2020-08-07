/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ManagedBehaviourManager] // 0x00000001801E3560-0x00000001801E3590
public class SanctuaryIndoorRoom : ManagedBehaviour // TypeDefIndex: 13326
{
	// Fields
	public Transform toExterior; // 0x50
	[Header] // 0x000000018020ABF0-0x000000018020AC20
	public SanctuaryIndoorRoom toUpstairs; // 0x58
	public SanctuaryIndoorRoom toDownstairs; // 0x60
	[Header] // 0x000000018020ADE0-0x000000018020AE10
	public SanctuaryIndoorRoom toRoomL; // 0x68
	public SanctuaryIndoorRoom toRoomR; // 0x70
	public SanctuaryIndoorRoom toRoomF; // 0x78
	public SanctuaryIndoorRoom toRoomB; // 0x80
	[Header] // 0x000000018020AFC0-0x000000018020AFF0
	public SanctuaryLayoutData.RoomData roomData; // 0x88
	private int _roomIndex; // 0x90
	private int _roomSizeIndex; // 0x94
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private BoxCollider <roomBoxCollider>k__BackingField; // 0x98
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private SanctuaryObjectBase <wallpaperBase>k__BackingField; // 0xA0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private SanctuaryObjectBase <flooringBase>k__BackingField; // 0xA8
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private SanctuaryObjectBase <trimBase>k__BackingField; // 0xB0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private SanctuaryObjectBase <ceilingBase>k__BackingField; // 0xB8
	public Naming naming; // 0xC0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<Transform> <allWalls>k__BackingField; // 0xC8
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<Transform> <allFloors>k__BackingField; // 0xD0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<Transform> <allTrims>k__BackingField; // 0xD8
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<Transform> <allCeilings>k__BackingField; // 0xE0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<Transform> <allFaders>k__BackingField; // 0xE8
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<Transform> <allBlacks>k__BackingField; // 0xF0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform <mainFloor>k__BackingField; // 0xF8
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform <mainCeiling>k__BackingField; // 0x100
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform <editline>k__BackingField; // 0x108
	public Data frontData; // 0x110
	public Data backData; // 0x118
	public Data leftData; // 0x120
	public Data rightData; // 0x128
	public Data entryData; // 0x130
	public Transform editLine; // 0x138
	[Header] // 0x000000018020C6B0-0x000000018020C6E0
	public List<SanctuarySurface> sanctuarySurfaces; // 0x140
	public List<SanctuarySurface> sanctuaryDoorSurfaces; // 0x148

	// Properties
	public bool locked { get; } // 0x0000000180BEA540-0x0000000180BEA610 
	public bool entry { get; } // 0x0000000180BEA510-0x0000000180BEA540 
	public int roomIndex { get; set; } // 0x0000000180476020-0x0000000180476030 0x0000000180479490-0x00000001804794A0
	public int roomSizeIndex { get; set; } // 0x00000001804D9970-0x00000001804D9980 0x00000001804D99B0-0x00000001804D99C0
	public BoxCollider roomBoxCollider { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180418990-0x00000001804189A0 0x0000000180419170-0x0000000180419180
	public SanctuaryObjectBase wallpaperBase { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803D6D90-0x00000001803D6DA0 0x00000001804A0450-0x00000001804A0460
	public SanctuaryObjectBase flooringBase { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180431310-0x0000000180431320 0x0000000180479500-0x0000000180479510
	public SanctuaryObjectBase trimBase { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x000000018067DD20-0x000000018067DD30 0x000000018067E630-0x000000018067E640
	public SanctuaryObjectBase ceilingBase { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803CFB60-0x00000001803CFB70 0x000000018049F9C0-0x000000018049F9D0
	public List<Transform> allWalls { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001804AF400-0x00000001804AF410 0x00000001804AF520-0x00000001804AF530
	public List<Transform> allFloors { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001805293A0-0x00000001805293B0 0x0000000180529420-0x0000000180529430
	public List<Transform> allTrims { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001805CB740-0x00000001805CB750 0x00000001809E2CC0-0x00000001809E4880
	public List<Transform> allCeilings { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x000000018057C4E0-0x000000018057C4F0 0x000000018057C5E0-0x000000018057C5F0
	public List<Transform> allFaders { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x000000018037DDD0-0x000000018037DDE0 0x00000001804296B0-0x00000001804296C0
	public List<Transform> allBlacks { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x000000018037DDB0-0x000000018037DDC0 0x00000001805AF740-0x00000001805AF750
	public Transform mainFloor { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x000000018037E230-0x000000018037E240 0x0000000180617A50-0x0000000180617A60
	public Transform mainCeiling { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x000000018037F030-0x000000018037F040 0x0000000180617A70-0x0000000180617A80
	public Transform editline { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180380B50-0x0000000180380B60 0x00000001803B50D0-0x00000001803B50E0

	// Nested types
	public enum EWall // TypeDefIndex: 13327
	{
		FRONT = 0,
		BACK = 1,
		LEFT = 2,
		RIGHT = 3,
		ALL = 4
	}

	public class Naming // TypeDefIndex: 13328
	{
		// Fields
		public string back; // 0x10
		public string front; // 0x18
		public string left; // 0x20
		public string right; // 0x28
		public string main; // 0x30
		public string entry; // 0x38
		public string doorBlock; // 0x40
		public string doorCeiling; // 0x48
		public string doorWall; // 0x50
		public string doorPortal; // 0x58
		public string doorSpawn; // 0x60
		public string fader; // 0x68
		public string black; // 0x70
		public string wall; // 0x78
		public string floor; // 0x80
		public string baseBoard; // 0x88
		public string crownMolding; // 0x90
		public string doortrim; // 0x98
		public string ceiling; // 0xA0
		public string editLine; // 0xA8
		public string door; // 0xB0
		public string stairs; // 0xB8
		public string guardRail; // 0xC0
		public string stairsBlockerL; // 0xC8
		public string stairsBlockerR; // 0xD0
		public string stairsL; // 0xD8
		public string stairsR; // 0xE0
		public string stairsPortalL; // 0xE8
		public string stairsPortalR; // 0xF0
		public string stairsSpawnL; // 0xF8
		public string stairsSpawnR; // 0x100
		public string floorNoStairs; // 0x108
		public string bothStairs; // 0x110
		public string stairsFloorL; // 0x118
		public string stairsFloorR; // 0x120
		public string wallNoStairs; // 0x128

		// Constructors
		public Naming(); // 0x0000000180BE5030-0x0000000180BE5240
	}

	[Serializable]
	public class Data // TypeDefIndex: 13329
	{
		// Fields
		public Transform main; // 0x10
		public List<Transform> objects; // 0x18
		public List<Transform> doorwayObjects; // 0x20
		public List<Transform> doorwayWallObjects; // 0x28
		public List<Transform> wallObjects; // 0x30
		public List<Transform> floorObjects; // 0x38
		public List<Transform> doorTrimObjects; // 0x40
		public List<Transform> ceilingObjects; // 0x48
		public List<Transform> surfaces; // 0x50
		public Transform doorBlockerObject; // 0x58
		public Transform spawn; // 0x60
		public Transform portal; // 0x68
		public Transform stairWallL; // 0x70
		public Transform stairWallR; // 0x78
		public Transform stairL; // 0x80
		public Transform stairR; // 0x88
		public Transform stairsPortalL; // 0x90
		public Transform stairsPortalR; // 0x98
		public Transform stairsSpawnL; // 0xA0
		public Transform stairsSpawnR; // 0xA8
		public Transform floorNoStairs; // 0xB0
		public Transform bothStairs; // 0xB8
		public Transform stairsFloorL; // 0xC0
		public Transform stairsFloorR; // 0xC8
		public Transform wallNoStairs; // 0xD0
		public Transform stairBlockerR; // 0xD8

		// Constructors
		public Data(); // 0x0000000180BE4DC0-0x0000000180BE4F10
	}

	// Constructors
	public SanctuaryIndoorRoom(); // 0x0000000180BEA250-0x0000000180BEA510

	// Methods
	public override void MStart(); // 0x0000000180BE7400-0x0000000180BE74A0
	public override void MOnDestroy(); // 0x0000000180BE7360-0x0000000180BE7400
	private void OnSanctuaryStateChangeMessage(SanctuaryStateChangeMessage inMessage); // 0x0000000180BE74A0-0x0000000180BE7540
	public void Setup(SanctuaryLayoutData inLayoutData); // 0x0000000180BE90C0-0x0000000180BEA250
	public void SetRoomBoxCollider(BoxCollider inBoxCollider); // 0x0000000180419170-0x0000000180419180
	private void SetPortal(GameObject inGameObject, Vector3? size = default, Vector3? center = default); // 0x0000000180BE7B40-0x0000000180BE7CF0
	public void SetMaterial(SanctuaryItemCategory inCategory, Material inMaterial, SanctuaryObjectBase inSanctuaryObjectBase); // 0x0000000180BE7720-0x0000000180BE7B40
	public void SetRoomAddOns(); // 0x0000000180BE7CF0-0x0000000180BE8E50
	private Data CreateObjectInfo(string inName, bool inEntryShown = false /* Metadata: 0x007BA332 */); // 0x0000000180BE5550-0x0000000180BE6B80
	private void OnTriggerEnter(Collider inCollider); // 0x0000000180BE7540-0x0000000180BE7630
	private void OnTriggerExit(Collider inCollider); // 0x0000000180BE7630-0x0000000180BE7720
	public void SetRoomData(SanctuaryLayoutData.RoomData inRoomData); // 0x00000001804794C0-0x00000001804794D0
	public void SetRoomIndex(int inRoomIdx); // 0x0000000180479490-0x00000001804794A0
	public void SetRoomSize(int inRoomSizeIdx); // 0x00000001804D99B0-0x00000001804D99C0
	public List<Transform> GetSafeSpawns(); // 0x0000000180BE6B80-0x0000000180BE7200
	public Transform GetSpawnToEntry(); // 0x0000000180BE7230-0x0000000180BE7250
	public Transform GetSpawnToRoomF(); // 0x0000000180BE7270-0x0000000180BE7290
	public Transform GetSpawnToRoomB(); // 0x0000000180BE7250-0x0000000180BE7270
	public Transform GetSpawnToRoomL(); // 0x0000000180BE7290-0x0000000180BE72B0
	public Transform GetSpawnToRoomR(); // 0x0000000180BE72B0-0x0000000180BE72D0
	public Transform GetSpawnToUpstairs(); // 0x0000000180BE72D0-0x0000000180BE7300
	public Transform GetSpawnToDownstairs(); // 0x0000000180BE7200-0x0000000180BE7230
	private void SetSurfaceInfo(SanctuaryLayoutData inLayoutData); // 0x0000000180BE8E50-0x0000000180BE8E80
	private void SetSurfaceInfos(int inStartIdx); // 0x0000000180BE8E80-0x0000000180BE90C0
	public bool HasSurface(SanctuarySurface inSanctuarySurface); // 0x0000000180BE7300-0x0000000180BE7360
}

