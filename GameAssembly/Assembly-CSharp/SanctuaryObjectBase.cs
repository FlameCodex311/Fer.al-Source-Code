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

[ManagedBehaviourManager] // 0x0000000180106CD0-0x0000000180106D00
public class SanctuaryObjectBase : WorldObject<SanctuaryObjectBaseInfo> // TypeDefIndex: 11833
{
	// Fields
	private SanctuaryHouseDefComponent _sanctuaryHouseDefComponent; // 0x90
	private SanctuaryItemDefComponent _data; // 0x98
	private GameObject _model; // 0xA0
	private List<GameObject> _models; // 0xA8
	private string _inventoryId; // 0xB0
	private MeshFilter[] _meshFilters; // 0xB8
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private BoxCollider <touchCollider>k__BackingField; // 0xC0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private MeshCollider <meshCollider>k__BackingField; // 0xC8
	private Color _gizmoColor; // 0xD0
	private Transform _dayGroup; // 0xE0
	private Transform _nightGroup; // 0xE8
	private SanctuaryObjectBase _lastGoodSanctuaryObjectParent; // 0xF0
	private Vector3 _lastGoodPosition; // 0xF8
	private Vector3 _lastGoodRotation; // 0x104
	private Vector3 _localSurfacePosition; // 0x110
	private int? _sanctuaryMaterialRoomIndex; // 0x11C
	private SanctuaryObjectBase _hitSanctuaryObject; // 0x128
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private SanctuaryObjectBase <sanctuaryObjectParent>k__BackingField; // 0x130
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private SanctuarySurface <onSurface>k__BackingField; // 0x138
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <beingDestroyed>k__BackingField; // 0x140
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private List<States> <stateList>k__BackingField; // 0x148
	private bool _isSpawnedFromUI; // 0x150
	private int _interactableState; // 0x154
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private Item <item>k__BackingField; // 0x158
	private ItemType? _itemType; // 0x160
	private string _defName; // 0x168
	private SanctuaryItemCategory? _itemCategory; // 0x170
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private SanctuaryItemDefComponent <sanctuaryItemDefComponent>k__BackingField; // 0x178
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <isDefault>k__BackingField; // 0x180

	// Properties
	public SanctuaryHouseDefComponent sanctuaryHouseDefComponent { get; } // 0x0000000180382A80-0x0000000180382A90 
	public SanctuaryItemDefComponent data { get; set; } // 0x000000018136C270-0x000000018136C3A0 0x000000018036A3D0-0x000000018036A3E0
	public GameObject model { get; set; } // 0x0000000180382AA0-0x0000000180382AB0 0x000000018136DA90-0x000000018136DB20
	public List<GameObject> models { get; set; } // 0x0000000180382A90-0x0000000180382AA0 0x000000018136DB20-0x000000018136DB40
	public string inventoryId { get; set; } // 0x000000018136C560-0x000000018136C5B0 0x000000018136DA70-0x000000018136DA80
	public MeshFilter[] meshFilters { get; } // 0x000000018136D840-0x000000018136D8F0 
	public BoxCollider touchCollider { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001804A1050-0x00000001804A1060 0x00000001804A0A80-0x00000001804A0A90
	public MeshCollider meshCollider { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001804A2590-0x00000001804A25A0 0x00000001804A22E0-0x00000001804A22F0
	public Bounds meshColliderBounds { get; } // 0x000000018136C9E0-0x000000018136CA30 
	public Vector3 leftEdge { get; } // 0x000000018136C760-0x000000018136C870 
	public Vector3 rightEdge { get; } // 0x000000018136D8F0-0x000000018136D9E0 
	public Vector3 forwardEdge { get; } // 0x000000018136C460-0x000000018136C560 
	public Vector3 backEdge { get; } // 0x000000018136C150-0x000000018136C270 
	public Vector3 meshColliderCenter { get; } // 0x000000018136CA30-0x000000018136CAB0 
	public Vector3 meshColliderSize { get; } // 0x000000018136D470-0x000000018136D840 
	public Vector3 meshColliderMinimum { get; } // 0x000000018136CF90-0x000000018136D470 
	public Vector3 meshColliderMaximum { get; } // 0x000000018136CAB0-0x000000018136CF90 
	public SanctuaryObjectBase lastGoodSanctuaryObjectParent { get; } // 0x00000001803BD320-0x00000001803BD330 
	public Vector3 lastGoodPosition { get; } // 0x000000018136C720-0x000000018136C740 
	public Vector3 lastGoodRotation { get; } // 0x000000018136C740-0x000000018136C760 
	public Vector3 localSurfacePosition { get; } // 0x000000018136C870-0x000000018136C9E0 
	public int sanctuaryMaterialRoomIndex { get; set; } // 0x000000018136D9E0-0x000000018136DA60 0x000000018136DB40-0x000000018136DBA0
	public SanctuaryObjectBase hitSanctuaryObject { get; } // 0x00000001803BD350-0x00000001803BD360 
	public SanctuaryObjectBase sanctuaryObjectParent { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803BD390-0x00000001803BD3A0 0x00000001803BE5B0-0x00000001803BE5C0
	public SanctuarySurface onSurface { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803BD3B0-0x00000001803BD3C0 0x00000001803BE5D0-0x00000001803BE5E0
	public bool beingDestroyed { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180AE8270-0x0000000180AE8280 0x000000018136DA60-0x000000018136DA70
	public bool isWallObject { get; } // 0x000000018136C5F0-0x000000018136C620 
	public bool isGroundObject { get; } // 0x000000018136C5C0-0x000000018136C5F0 
	public List<States> stateList { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803BD360-0x00000001803BD370 0x00000001803BE580-0x00000001803BE590
	public int interactableState { get; } // 0x00000001810E1F20-0x00000001810E1F30 
	public Item item { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803BD330-0x00000001803BD340 0x00000001803BE550-0x00000001803BE560
	private ItemType? itemType { get; } // 0x000000018136C6B0-0x000000018136C720 
	private string defName { get; } // 0x000000018136C3A0-0x000000018136C460 
	public SanctuaryItemCategory? itemCategory { get; } // 0x000000018136C620-0x000000018136C6B0 
	public SanctuaryItemDefComponent sanctuaryItemDefComponent { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018081E150-0x000000018081E160 0x00000001807E5570-0x00000001807E5580
	public bool isDefault { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018136C5B0-0x000000018136C5C0 0x000000018136DA80-0x000000018136DA90

	// Nested types
	public class States // TypeDefIndex: 11834
	{
		// Fields
		public Transform parent; // 0x10

		// Constructors
		public States(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 11835
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<GameObject> <>9__132_0; // 0x08

		// Constructors
		static <>c(); // 0x000000018137A820-0x000000018137A880
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <Build>b__132_0(GameObject gIsland); // 0x00000001813797F0-0x0000000181379910
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <Build>d__132 : IEnumerator<object> // TypeDefIndex: 11836
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SanctuaryObjectBase <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <Build>d__132(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181371A60-0x0000000181371FC0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181371FC0-0x0000000181372010
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass138_0 // TypeDefIndex: 11837
	{
		// Fields
		public SanctuaryObjectBase <>4__this; // 0x10
		public Item inItem; // 0x18
		public Action<GameObject> inResult; // 0x20

		// Constructors
		public <>c__DisplayClass138_0(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass138_1 // TypeDefIndex: 11838
	{
		// Fields
		public SanctuaryItemDefComponent cSanctuaryItemDefComponent; // 0x10
		public <>c__DisplayClass138_0 CS$<>8__locals1; // 0x18

		// Constructors
		public <>c__DisplayClass138_1(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <SpawnPlacedObject>b__0(GameObject gLoaded); // 0x0000000181379BE0-0x0000000181379EB0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass138_2 // TypeDefIndex: 11839
	{
		// Fields
		public SanctuaryItemDefComponent cSanctuaryItemDefComponent; // 0x10
		public <>c__DisplayClass138_0 CS$<>8__locals2; // 0x18

		// Constructors
		public <>c__DisplayClass138_2(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <SpawnPlacedObject>b__1(GameObject gLoaded); // 0x0000000181379EB0-0x000000018137A180
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <SpawnPlacedObject>d__138 : IEnumerator<object> // TypeDefIndex: 11840
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SanctuaryObjectBase <>4__this; // 0x20
		public Item inItem; // 0x28
		public Action<GameObject> inResult; // 0x30
		private <>c__DisplayClass138_0 <>8__1; // 0x38
		private <>c__DisplayClass138_1 <>8__2; // 0x40

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <SpawnPlacedObject>d__138(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181378D90-0x00000001813794D0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001813794D0-0x00000001813797F0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <SpawnHouseLook>d__139 : IEnumerator<object> // TypeDefIndex: 11841
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Item inItem; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <SpawnHouseLook>d__139(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181378210-0x0000000181378480
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181378480-0x00000001813784D0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass140_0 // TypeDefIndex: 11842
	{
		// Fields
		public SanctuaryObjectBase <>4__this; // 0x10
		public Item inItem; // 0x18
		public Action<List<GameObject>> inHouseBases; // 0x20

		// Constructors
		public <>c__DisplayClass140_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <SpawnHouse>b__0(List<GameObject> gLoaded); // 0x000000018137A180-0x000000018137A310
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <SpawnHouse>d__140 : IEnumerator<object> // TypeDefIndex: 11843
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SanctuaryObjectBase <>4__this; // 0x20
		public Item inItem; // 0x28
		public Action<List<GameObject>> inHouseBases; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <SpawnHouse>d__140(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001813784D0-0x00000001813787E0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001813787E0-0x0000000181378830
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass141_0 // TypeDefIndex: 11844
	{
		// Fields
		public SanctuaryObjectBase <>4__this; // 0x10
		public Item inItem; // 0x18
		public Action<GameObject> inResult; // 0x20

		// Constructors
		public <>c__DisplayClass141_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <SpawnIsland>b__0(GameObject gLoaded); // 0x000000018137A310-0x000000018137A490
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <SpawnIsland>d__141 : IEnumerator<object> // TypeDefIndex: 11845
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SanctuaryObjectBase <>4__this; // 0x20
		public Item inItem; // 0x28
		public Action<GameObject> inResult; // 0x30
		private <>c__DisplayClass141_0 <>8__1; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <SpawnIsland>d__141(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181378830-0x0000000181378D40
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181378D40-0x0000000181378D90
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <InitPlacedObject>d__150 : IEnumerator<object> // TypeDefIndex: 11846
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SanctuaryObjectBase <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <InitPlacedObject>d__150(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001813759C0-0x0000000181375FC0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181375FC0-0x0000000181376010
	}

	// Constructors
	public SanctuaryObjectBase(); // 0x000000018136C030-0x000000018136C150

	// Methods
	public int GetRoomIndex(); // 0x0000000181367B30-0x0000000181367CA0
	public void SetAsDefault(); // 0x0000000181369AE0-0x0000000181369AF0
	private void SetName(); // 0x0000000181369B30-0x000000018136A2C0
	public bool IsSpawnedFromUI(); // 0x000000018081DD30-0x000000018081DD40
	public void SetIsSpawnedFromUI(bool inValue); // 0x0000000181369AF0-0x0000000181369B30
	public void MovePosition(Vector3 inPosition); // 0x00000001812D2380-0x00000001812D23D0
	public void MoveRotation(Quaternion inRotation); // 0x0000000181368A90-0x0000000181368AD0
	public void SetStates(GameObject inParent, SanctuaryItemDefComponent inSanctuaryItemDefComponent); // 0x000000018136A4B0-0x000000018136A690
	public void ChangeInteractableState(bool inInitInteractableState, int inInteractableState); // 0x00000001813649A0-0x0000000181364B50
	private void SaveInteractableState(bool inInitInteractableState); // 0x00000001813694E0-0x00000001813694F0
	private void UpdateInteractableState(); // 0x000000018136B780-0x000000018136B8B0
	public void SetupInteractableState(int inIndex, GameObject inGameObject); // 0x000000018136A960-0x000000018136AAE0
	public bool ShouldTeleport(); // 0x000000018136AFF0-0x000000018136B330
	protected override void OnMoveMessage(WorldObjectMoveMessage inMessage); // 0x00000001803581E0-0x00000001803581F0
	private void InfoCreated(GameObject inGameObject, SanctuaryObjectBaseInfo inInfo); // 0x00000001803581E0-0x00000001803581F0
	public override void OnObjectInfo(WorldObjectInfoMessage inInfoMessage); // 0x0000000181369330-0x00000001813693E0
	[IteratorStateMachine] // 0x0000000180132570-0x00000001801325C0
	public override IEnumerator Build(); // 0x00000001813646A0-0x0000000181364700
	public override void MStart(); // 0x00000001813689F0-0x0000000181368A90
	private void OnSanctuaryStateChangeMessage(SanctuaryStateChangeMessage inMessage); // 0x00000001813693E0-0x0000000181369400
	private void UpdateMeshCollider(SanctuaryController.EState inState); // 0x000000018136B8B0-0x000000018136BAC0
	private static void RemoveTemp(SanctuaryObjectBase inSanctuaryObjectBase); // 0x0000000181369470-0x00000001813694E0
	public override void MOnDestroy(); // 0x0000000181368710-0x00000001813689F0
	[IteratorStateMachine] // 0x00000001801327C0-0x0000000180132810
	private IEnumerator SpawnPlacedObject(Item inItem, Action<GameObject> inResult); // 0x000000018136B490-0x000000018136B510
	[IteratorStateMachine] // 0x0000000180132AD0-0x0000000180132B20
	private IEnumerator SpawnHouseLook(Item inItem); // 0x000000018136B330-0x000000018136B390
	[IteratorStateMachine] // 0x0000000180132DC0-0x0000000180132E10
	private IEnumerator SpawnHouse(Item inItem, Action<List<GameObject>> inHouseBases); // 0x000000018136B390-0x000000018136B410
	[IteratorStateMachine] // 0x00000001801330F0-0x0000000180133140
	private IEnumerator SpawnIsland(Item inItem, Action<GameObject> inResult); // 0x000000018136B410-0x000000018136B490
	public void SetupHouse(List<GameObject> inModels, Item inItem, string inId, SanctuaryItemDefComponent inSanctuaryItemDefComponent, SanctuaryObjectBaseInfo inInfo); // 0x000000018136A900-0x000000018136A960
	public void SetupIsland(GameObject inModel, Item inItem, string inId, SanctuaryItemDefComponent inSanctuaryItemDefComponent, SanctuaryObjectBaseInfo inInfo); // 0x000000018136AAE0-0x000000018136AB30
	public void SetupPlacedObject(GameObject inModel, Item inItem, string inId, SanctuaryItemDefComponent inSanctuaryItemDefComponent, SanctuaryObjectBaseInfo inInfo); // 0x000000018136AB30-0x000000018136AFF0
	public void SetSanctuarySurface(SanctuarySurface inSanctuarySurface); // 0x000000018136A400-0x000000018136A4B0
	private void SetSanctuaryItemDefComponent(SanctuaryItemDefComponent inComponent); // 0x000000018036A3D0-0x000000018036A3E0
	public void SetSanctuaryObjectParent(SanctuaryObjectBase inSanctuaryObject); // 0x000000018136A2C0-0x000000018136A400
	public bool DoesFit(Vector3 inNormal); // 0x0000000181366270-0x0000000181366460
	public void RefreshLastGoodPosition(); // 0x0000000181369400-0x0000000181369470
	[IteratorStateMachine] // 0x0000000180133400-0x0000000180133450
	private IEnumerator InitPlacedObject(); // 0x0000000181368650-0x00000001813686B0
	public void OnCollisionEnter(Collision inCollision); // 0x00000001803581E0-0x00000001803581F0
	public bool BoxCast(int inLayermask, QueryTriggerInteraction inQueryTriggerInteraction, string inTag = "" /* Metadata: 0x00782C49 */); // 0x0000000181364630-0x00000001813646A0
	public bool EdgeCast(int inLayermask, QueryTriggerInteraction inQueryTriggerInteraction, string inTag = "" /* Metadata: 0x00782C4D */); // 0x0000000181366460-0x0000000181366FE0
	public bool CornerCast(int inLayermask, QueryTriggerInteraction inQueryTriggerInteraction, string inTag = "" /* Metadata: 0x00782C51 */); // 0x00000001813650A0-0x0000000181365F10
	public bool HittingRigidbodyObject(); // 0x0000000181367CA0-0x0000000181368160
	public bool HittingStaticObject(out SanctuaryObjectBase outHitSanctuaryObject); // 0x0000000181368160-0x0000000181368650
	public bool CollidingWithObject(out SanctuaryObjectBase outHitSanctuaryObject); // 0x0000000181364B50-0x00000001813650A0
	public bool CanBePlaced(Vector3 inNormal); // 0x0000000181364700-0x00000001813649A0
	public bool DoesFit(out SanctuaryObjectBase outHitSanctuaryObject); // 0x0000000181365FD0-0x0000000181366270
	private void OnDrawGizmosSelected(); // 0x0000000181368AD0-0x0000000181369330
	public bool FitsOnSurface(); // 0x0000000181366FF0-0x00000001813679C0
	public void ServerUpdate(SanctuaryObjectBaseInfo inInfo); // 0x00000001813694F0-0x0000000181369AE0
	public void ExternalUpdateObject(bool inRemove = false /* Metadata: 0x00782C55 */); // 0x0000000181366FE0-0x0000000181366FF0
	private void UpdateObject(bool inRemove = false /* Metadata: 0x00782C56 */); // 0x000000018136BAC0-0x000000018136C030
	public void UIChangeState(); // 0x000000018136B510-0x000000018136B5E0
	private BoxCollider CreateTouchCollider(); // 0x0000000181365F70-0x0000000181365FD0
	private MeshCollider CreateMeshCollider(); // 0x0000000181365F10-0x0000000181365F70
	public void UpdateDayNight(SanctuaryController.ETime inTime); // 0x000000018136B5E0-0x000000018136B780
	public Vector3 GetLastGoodPosition(Vector3 inNormal); // 0x00000001813679C0-0x0000000181367A80
	public Vector3 GetLastGoodRotation(Vector3 inNormal); // 0x0000000181367A80-0x0000000181367B30
	public void SetTouchColliderActive(bool inActive); // 0x000000018136A690-0x000000018136A900
	private bool Linecast(Vector3 inStart, Vector3 inEnd, int inLayermask, QueryTriggerInteraction inIgnore); // 0x00000001813686B0-0x0000000181368710
}

