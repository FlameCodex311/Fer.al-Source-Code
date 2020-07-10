/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ManagedBehaviourManager] // 0x0000000180106CD0-0x0000000180106D00
public class SanctuaryIndoorRoom : ManagedBehaviour // TypeDefIndex: 11792
{
	// Fields
	public Transform toExterior; // 0x50
	[Header] // 0x0000000180128A20-0x0000000180128A50
	public SanctuaryIndoorRoom toUpstairs; // 0x58
	public SanctuaryIndoorRoom toDownstairs; // 0x60
	[Header] // 0x0000000180128DB0-0x0000000180128DE0
	public SanctuaryIndoorRoom toRoomL; // 0x68
	public SanctuaryIndoorRoom toRoomR; // 0x70
	public SanctuaryIndoorRoom toRoomF; // 0x78
	public SanctuaryIndoorRoom toRoomB; // 0x80
	[Header] // 0x0000000180128F20-0x0000000180128F50
	public SanctuaryLayoutData.RoomData roomData; // 0x88
	private int _roomIndex; // 0x90
	private int _roomSizeIndex; // 0x94
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private BoxCollider <roomBoxCollider>k__BackingField; // 0x98
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private SanctuaryObjectBase <wallpaperBase>k__BackingField; // 0xA0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private SanctuaryObjectBase <flooringBase>k__BackingField; // 0xA8
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private SanctuaryObjectBase <trimBase>k__BackingField; // 0xB0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private SanctuaryObjectBase <ceilingBase>k__BackingField; // 0xB8
	public Naming naming; // 0xC0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private List<Transform> <allWalls>k__BackingField; // 0xC8
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private List<Transform> <allFloors>k__BackingField; // 0xD0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private List<Transform> <allTrims>k__BackingField; // 0xD8
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private List<Transform> <allCeilings>k__BackingField; // 0xE0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private List<Transform> <allFaders>k__BackingField; // 0xE8
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private List<Transform> <allBlacks>k__BackingField; // 0xF0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform <mainFloor>k__BackingField; // 0xF8
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform <mainCeiling>k__BackingField; // 0x100
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform <editline>k__BackingField; // 0x108
	public Data frontData; // 0x110
	public Data backData; // 0x118
	public Data leftData; // 0x120
	public Data rightData; // 0x128
	public Data entryData; // 0x130
	public Transform editLine; // 0x138
	[Header] // 0x0000000180129FC0-0x0000000180129FF0
	public List<SanctuarySurface> sanctuarySurfaces; // 0x140
	public List<SanctuarySurface> sanctuaryDoorSurfaces; // 0x148

	// Properties
	public bool locked { get; } // 0x0000000181293A30-0x0000000181293B00 
	public bool entry { get; } // 0x0000000181293A00-0x0000000181293A30 
	public int roomIndex { get; set; } // 0x00000001804A1060-0x00000001804A1070 0x00000001804AFEE0-0x00000001804AFEF0
	public int roomSizeIndex { get; set; } // 0x00000001804D0680-0x00000001804D0690 0x00000001804D0BB0-0x00000001804D0BC0
	public BoxCollider roomBoxCollider { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180369B70-0x0000000180369B80 0x000000018036A3D0-0x000000018036A3E0
	public SanctuaryObjectBase wallpaperBase { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180382AA0-0x0000000180382AB0 0x00000001803D8EE0-0x00000001803D8EF0
	public SanctuaryObjectBase flooringBase { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180382A90-0x0000000180382AA0 0x00000001804A1230-0x00000001804A1240
	public SanctuaryObjectBase trimBase { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803ED9D0-0x00000001803ED9E0 0x00000001804A0A60-0x00000001804A0A70
	public SanctuaryObjectBase ceilingBase { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803ED9C0-0x00000001803ED9D0 0x00000001803D8F00-0x00000001803D8F10
	public List<Transform> allWalls { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001804A2590-0x00000001804A25A0 0x00000001804A22E0-0x00000001804A22F0
	public List<Transform> allFloors { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001804A24D0-0x00000001804A24E0 0x00000001804A22C0-0x00000001804A22D0
	public List<Transform> allTrims { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001804E9920-0x00000001804E9930 0x00000001804BEA30-0x00000001804BEA40
	public List<Transform> allCeilings { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001804A0FC0-0x00000001804A0FD0 0x00000001804A0A50-0x00000001804A0A60
	public List<Transform> allFaders { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018037A250-0x000000018037A260 0x000000018037AA30-0x000000018037AA40
	public List<Transform> allBlacks { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803BD320-0x00000001803BD330 0x00000001803BE540-0x00000001803BE550
	public Transform mainFloor { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803BD310-0x00000001803BD320 0x00000001803BE530-0x00000001803BE540
	public Transform mainCeiling { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803BD370-0x00000001803BD380 0x00000001803BE590-0x00000001803BE5A0
	public Transform editline { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803BD3C0-0x00000001803BD3D0 0x00000001803BE5E0-0x00000001803BE5F0

	// Nested types
	public enum EWall // TypeDefIndex: 11793
	{
		FRONT = 0,
		BACK = 1,
		LEFT = 2,
		RIGHT = 3,
		ALL = 4
	}

	public class Naming // TypeDefIndex: 11794
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
		public Naming(); // 0x0000000181361990-0x0000000181361BA0
	}

	[Serializable]
	public class Data // TypeDefIndex: 11795
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
		public Data(); // 0x00000001813615A0-0x00000001813616F0
	}

	// Constructors
	public SanctuaryIndoorRoom(); // 0x0000000181293930-0x0000000181293A00

	// Methods
	public override void MStart(); // 0x00000001812909C0-0x0000000181290A60
	public override void MOnDestroy(); // 0x0000000181290920-0x00000001812909C0
	private void OnSanctuaryStateChangeMessage(SanctuaryStateChangeMessage inMessage); // 0x0000000181290A60-0x0000000181290B00
	public void Setup(SanctuaryLayoutData inLayoutData); // 0x00000001812926F0-0x0000000181293930
	public void SetRoomBoxCollider(BoxCollider inBoxCollider); // 0x000000018036A3D0-0x000000018036A3E0
	private void SetPortal(GameObject inGameObject, Vector3? size = default, Vector3? center = default); // 0x0000000181291100-0x00000001812912C0
	public void SetMaterial(SanctuaryItemCategory inCategory, Material inMaterial, SanctuaryObjectBase inSanctuaryObjectBase); // 0x0000000181290CE0-0x0000000181291100
	public void SetRoomAddOns(); // 0x00000001812912C0-0x0000000181292470
	private Data CreateObjectInfo(string inName, bool inEntryShown = false /* Metadata: 0x00782C24 */); // 0x000000018128EA80-0x00000001812900D0
	private void OnTriggerEnter(Collider inCollider); // 0x0000000181290B00-0x0000000181290BF0
	private void OnTriggerExit(Collider inCollider); // 0x0000000181290BF0-0x0000000181290CE0
	public void SetRoomData(SanctuaryLayoutData.RoomData inRoomData); // 0x000000018049D700-0x000000018049D710
	public void SetRoomIndex(int inRoomIdx); // 0x00000001804AFEE0-0x00000001804AFEF0
	public void SetRoomSize(int inRoomSizeIdx); // 0x00000001804D0BB0-0x00000001804D0BC0
	public List<Transform> GetSafeSpawns(); // 0x00000001812900D0-0x0000000181290770
	public Transform GetSpawnToEntry(); // 0x00000001812907A0-0x00000001812907D0
	public Transform GetSpawnToRoomF(); // 0x0000000181290800-0x0000000181290830
	public Transform GetSpawnToRoomB(); // 0x00000001812907D0-0x0000000181290800
	public Transform GetSpawnToRoomL(); // 0x0000000181290830-0x0000000181290860
	public Transform GetSpawnToRoomR(); // 0x0000000181290860-0x0000000181290890
	public Transform GetSpawnToUpstairs(); // 0x0000000181290890-0x00000001812908C0
	public Transform GetSpawnToDownstairs(); // 0x0000000181290770-0x00000001812907A0
	private void SetSurfaceInfo(SanctuaryLayoutData inLayoutData); // 0x0000000181292470-0x00000001812924A0
	private void SetSurfaceInfos(int inStartIdx); // 0x00000001812924A0-0x00000001812926F0
	public bool HasSurface(SanctuarySurface inSanctuarySurface); // 0x00000001812908C0-0x0000000181290920
}

