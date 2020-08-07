/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ManagedBehaviourManager] // 0x00000001801E3560-0x00000001801E3590
public class SanctuaryObjectBase : WorldObject<SanctuaryObjectBaseInfo> // TypeDefIndex: 13365
{
	// Fields
	private SanctuaryHouseDefComponent _sanctuaryHouseDefComponent; // 0x90
	private SanctuaryItemDefComponent _data; // 0x98
	private GameObject _model; // 0xA0
	private List<GameObject> _models; // 0xA8
	private string _inventoryId; // 0xB0
	private MeshFilter[] _meshFilters; // 0xB8
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private BoxCollider <touchCollider>k__BackingField; // 0xC0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
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
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private SanctuaryObjectBase <sanctuaryObjectParent>k__BackingField; // 0x130
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private SanctuarySurface <onSurface>k__BackingField; // 0x138
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <beingDestroyed>k__BackingField; // 0x140
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<States> <stateList>k__BackingField; // 0x148
	private bool _isSpawnedFromUI; // 0x150
	private int _interactableState; // 0x154
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Item <item>k__BackingField; // 0x158
	private ItemType? _itemType; // 0x160
	private string _defName; // 0x168
	private SanctuaryItemCategory? _itemCategory; // 0x170
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private SanctuaryItemDefComponent <sanctuaryItemDefComponent>k__BackingField; // 0x178
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <isDefault>k__BackingField; // 0x180

	// Properties
	public SanctuaryHouseDefComponent sanctuaryHouseDefComponent { get; } // 0x00000001803D6D80-0x00000001803D6D90 
	public SanctuaryItemDefComponent data { get; set; } // 0x0000000180BF4920-0x0000000180BF4A50 0x0000000180419170-0x0000000180419180
	public GameObject model { get; set; } // 0x00000001803D6D90-0x00000001803D6DA0 0x0000000180BF6100-0x0000000180BF6190
	public List<GameObject> models { get; set; } // 0x0000000180431310-0x0000000180431320 0x0000000180BF6190-0x0000000180BF61B0
	public string inventoryId { get; set; } // 0x0000000180BF4C20-0x0000000180BF4C70 0x0000000180BF60E0-0x0000000180BF60F0
	public MeshFilter[] meshFilters { get; } // 0x0000000180BF5EC0-0x0000000180BF5F60 
	public BoxCollider touchCollider { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180529360-0x0000000180529370 0x0000000180529410-0x0000000180529420
	public MeshCollider meshCollider { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001804AF400-0x00000001804AF410 0x00000001804AF520-0x00000001804AF530
	public Bounds meshColliderBounds { get; } // 0x0000000180BF5090-0x0000000180BF50E0 
	public Vector3 leftEdge { get; } // 0x0000000180BF4E10-0x0000000180BF4F20 
	public Vector3 rightEdge { get; } // 0x0000000180BF5F60-0x0000000180BF6050 
	public Vector3 forwardEdge { get; } // 0x0000000180BF4B10-0x0000000180BF4C10 
	public Vector3 backEdge { get; } // 0x0000000180BF47F0-0x0000000180BF4910 
	public Vector3 meshColliderCenter { get; } // 0x0000000180BF50E0-0x0000000180BF5160 
	public Vector3 meshColliderSize { get; } // 0x0000000180BF5B00-0x0000000180BF5EC0 
	public Vector3 meshColliderMinimum { get; } // 0x0000000180BF5630-0x0000000180BF5B00 
	public Vector3 meshColliderMaximum { get; } // 0x0000000180BF5160-0x0000000180BF5630 
	public SanctuaryObjectBase lastGoodSanctuaryObjectParent { get; } // 0x000000018037DDB0-0x000000018037DDC0 
	public Vector3 lastGoodPosition { get; } // 0x0000000180BF4DD0-0x0000000180BF4DF0 
	public Vector3 lastGoodRotation { get; } // 0x0000000180BF4DF0-0x0000000180BF4E10 
	public Vector3 localSurfacePosition { get; } // 0x0000000180BF4F20-0x0000000180BF5090 
	public int sanctuaryMaterialRoomIndex { get; set; } // 0x0000000180BF6050-0x0000000180BF60D0 0x0000000180BF61C0-0x0000000180BF6220
	public SanctuaryObjectBase hitSanctuaryObject { get; } // 0x00000001803EF180-0x00000001803EF190 
	public SanctuaryObjectBase sanctuaryObjectParent { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180383C00-0x0000000180383C10 0x000000018057C5C0-0x000000018057C5D0
	public SanctuarySurface onSurface { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803EF230-0x00000001803EF240 0x0000000180617A90-0x0000000180617AA0
	public bool beingDestroyed { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180BF4910-0x0000000180BF4920 0x0000000180BF60D0-0x0000000180BF60E0
	public bool isWallObject { get; } // 0x0000000180BF4CB0-0x0000000180BF4CD0 
	public bool isGroundObject { get; } // 0x0000000180BF4C80-0x0000000180BF4CB0 
	public List<States> stateList { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180616920-0x0000000180616930 0x000000018051D9F0-0x000000018051DA00
	public int interactableState { get; } // 0x0000000180BF4C10-0x0000000180BF4C20 
	public Item item { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803EF160-0x00000001803EF170 0x00000001803EF2A0-0x00000001803EF2B0
	private ItemType? itemType { get; } // 0x0000000180BF4D60-0x0000000180BF4DD0 
	private string defName { get; } // 0x0000000180BF4A50-0x0000000180BF4B10 
	public SanctuaryItemCategory? itemCategory { get; } // 0x0000000180BF4CD0-0x0000000180BF4D60 
	public SanctuaryItemDefComponent sanctuaryItemDefComponent { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803EF200-0x00000001803EF210 0x0000000180BF61B0-0x0000000180BF61C0
	public bool isDefault { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180BF4C70-0x0000000180BF4C80 0x0000000180BF60F0-0x0000000180BF6100

	// Nested types
	public class States // TypeDefIndex: 13366
	{
		// Fields
		public Transform parent; // 0x10

		// Constructors
		public States(); // 0x0000000180373240-0x0000000180373250
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 13367
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<GameObject> <>9__132_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180BFD660-0x0000000180BFD6C0
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <Build>b__132_0(GameObject gIsland); // 0x0000000180BFCA30-0x0000000180BFCB50
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <Build>d__132 : IEnumerator<object> // TypeDefIndex: 13368
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SanctuaryObjectBase <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <Build>d__132(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180BF6F50-0x0000000180BF74A0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180BF74A0-0x0000000180BF74F0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass138_0 // TypeDefIndex: 13369
	{
		// Fields
		public SanctuaryObjectBase <>4__this; // 0x10
		public Item inItem; // 0x18
		public Action<GameObject> inResult; // 0x20

		// Constructors
		public <>c__DisplayClass138_0(); // 0x0000000180373240-0x0000000180373250
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass138_1 // TypeDefIndex: 13370
	{
		// Fields
		public SanctuaryItemDefComponent cSanctuaryItemDefComponent; // 0x10
		public <>c__DisplayClass138_0 CS$<>8__locals1; // 0x18

		// Constructors
		public <>c__DisplayClass138_1(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <SpawnPlacedObject>b__0(GameObject gLoaded); // 0x0000000180BFCE00-0x0000000180BFD0B0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass138_2 // TypeDefIndex: 13371
	{
		// Fields
		public SanctuaryItemDefComponent cSanctuaryItemDefComponent; // 0x10
		public <>c__DisplayClass138_0 CS$<>8__locals2; // 0x18

		// Constructors
		public <>c__DisplayClass138_2(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <SpawnPlacedObject>b__1(GameObject gLoaded); // 0x0000000180BFD0B0-0x0000000180BFD360
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <SpawnPlacedObject>d__138 : IEnumerator<object> // TypeDefIndex: 13372
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <SpawnPlacedObject>d__138(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180BFC2C0-0x0000000180BFC9E0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180BFC9E0-0x0000000180BFCA30
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <SpawnHouseLook>d__139 : IEnumerator<object> // TypeDefIndex: 13373
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Item inItem; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <SpawnHouseLook>d__139(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180BFB780-0x0000000180BFB9E0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180BFB9E0-0x0000000180BFBA30
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass140_0 // TypeDefIndex: 13374
	{
		// Fields
		public SanctuaryObjectBase <>4__this; // 0x10
		public Item inItem; // 0x18
		public Action<List<GameObject>> inHouseBases; // 0x20

		// Constructors
		public <>c__DisplayClass140_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <SpawnHouse>b__0(List<GameObject> gLoaded); // 0x0000000180BFD360-0x0000000180BFD4E0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <SpawnHouse>d__140 : IEnumerator<object> // TypeDefIndex: 13375
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SanctuaryObjectBase <>4__this; // 0x20
		public Item inItem; // 0x28
		public Action<List<GameObject>> inHouseBases; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <SpawnHouse>d__140(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180BFBA30-0x0000000180BFBD30
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180BFBD30-0x0000000180BFBD80
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass141_0 // TypeDefIndex: 13376
	{
		// Fields
		public SanctuaryObjectBase <>4__this; // 0x10
		public Item inItem; // 0x18
		public Action<GameObject> inResult; // 0x20

		// Constructors
		public <>c__DisplayClass141_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <SpawnIsland>b__0(GameObject gLoaded); // 0x0000000180BFD4E0-0x0000000180BFD660
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <SpawnIsland>d__141 : IEnumerator<object> // TypeDefIndex: 13377
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SanctuaryObjectBase <>4__this; // 0x20
		public Item inItem; // 0x28
		public Action<GameObject> inResult; // 0x30
		private <>c__DisplayClass141_0 <>8__1; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <SpawnIsland>d__141(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180BFBD80-0x0000000180BFC270
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180BFC270-0x0000000180BFC2C0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <InitPlacedObject>d__150 : IEnumerator<object> // TypeDefIndex: 13378
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SanctuaryObjectBase <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <InitPlacedObject>d__150(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180BF98E0-0x0000000180BF9ED0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180BF9ED0-0x0000000180BF9F20
	}

	// Constructors
	public SanctuaryObjectBase(); // 0x0000000180BF46D0-0x0000000180BF47F0

	// Methods
	public int GetRoomIndex(); // 0x0000000180BF02A0-0x0000000180BF0400
	public void SetAsDefault(); // 0x0000000180BF2230-0x0000000180BF2240
	private void SetName(); // 0x0000000180BF2280-0x0000000180BF29B0
	public bool IsSpawnedFromUI(); // 0x000000018091EF30-0x000000018091EF40
	public void SetIsSpawnedFromUI(bool inValue); // 0x0000000180BF2240-0x0000000180BF2280
	public void MovePosition(Vector3 inPosition); // 0x0000000180BF11C0-0x0000000180BF1210
	public void MoveRotation(Quaternion inRotation); // 0x0000000180BF1210-0x0000000180BF1250
	public void SetStates(GameObject inParent, SanctuaryItemDefComponent inSanctuaryItemDefComponent); // 0x0000000180BF2BA0-0x0000000180BF2D70
	public void ChangeInteractableState(bool inInitInteractableState, int inInteractableState); // 0x0000000180BED1D0-0x0000000180BED370
	private void SaveInteractableState(bool inInitInteractableState); // 0x0000000180BF1C50-0x0000000180BF1C60
	private void UpdateInteractableState(); // 0x0000000180BF3E40-0x0000000180BF3F70
	public void SetupInteractableState(int inIndex, GameObject inGameObject); // 0x0000000180BF3040-0x0000000180BF31C0
	public bool ShouldTeleport(); // 0x0000000180BF36C0-0x0000000180BF39F0
	protected override void OnMoveMessage(WorldObjectMoveMessage inMessage); // 0x00000001803774A0-0x00000001803774B0
	private void InfoCreated(GameObject inGameObject, SanctuaryObjectBaseInfo inInfo); // 0x00000001803774A0-0x00000001803774B0
	public override void OnObjectInfo(WorldObjectInfoMessage inInfoMessage); // 0x0000000180BF1AA0-0x0000000180BF1B50
	[IteratorStateMachine] // 0x0000000180217810-0x0000000180217860
	public override IEnumerator Build(); // 0x0000000180BECEE0-0x0000000180BECF40
	public override void MStart(); // 0x0000000180BF1120-0x0000000180BF11C0
	private void OnSanctuaryStateChangeMessage(SanctuaryStateChangeMessage inMessage); // 0x0000000180BF1B50-0x0000000180BF1B70
	private void UpdateMeshCollider(SanctuaryController.EState inState); // 0x0000000180BF3F70-0x0000000180BF4180
	private static void RemoveTemp(SanctuaryObjectBase inSanctuaryObjectBase); // 0x0000000180BF1BE0-0x0000000180BF1C50
	public override void MOnDestroy(); // 0x0000000180BF0E40-0x0000000180BF1120
	[IteratorStateMachine] // 0x0000000180217AF0-0x0000000180217B40
	private IEnumerator SpawnPlacedObject(Item inItem, Action<GameObject> inResult); // 0x0000000180BF3B50-0x0000000180BF3BD0
	[IteratorStateMachine] // 0x0000000180217D50-0x0000000180217DA0
	private IEnumerator SpawnHouseLook(Item inItem); // 0x0000000180BF39F0-0x0000000180BF3A50
	[IteratorStateMachine] // 0x00000001802180A0-0x00000001802180F0
	private IEnumerator SpawnHouse(Item inItem, Action<List<GameObject>> inHouseBases); // 0x0000000180BF3A50-0x0000000180BF3AD0
	[IteratorStateMachine] // 0x0000000180218380-0x00000001802183D0
	private IEnumerator SpawnIsland(Item inItem, Action<GameObject> inResult); // 0x0000000180BF3AD0-0x0000000180BF3B50
	public void SetupHouse(List<GameObject> inModels, Item inItem, string inId, SanctuaryItemDefComponent inSanctuaryItemDefComponent, SanctuaryObjectBaseInfo inInfo); // 0x0000000180BF2FE0-0x0000000180BF3040
	public void SetupIsland(GameObject inModel, Item inItem, string inId, SanctuaryItemDefComponent inSanctuaryItemDefComponent, SanctuaryObjectBaseInfo inInfo); // 0x0000000180BF31C0-0x0000000180BF3210
	public void SetupPlacedObject(GameObject inModel, Item inItem, string inId, SanctuaryItemDefComponent inSanctuaryItemDefComponent, SanctuaryObjectBaseInfo inInfo); // 0x0000000180BF3210-0x0000000180BF36C0
	public void SetSanctuarySurface(SanctuarySurface inSanctuarySurface); // 0x0000000180BF2AF0-0x0000000180BF2BA0
	private void SetSanctuaryItemDefComponent(SanctuaryItemDefComponent inComponent); // 0x0000000180419170-0x0000000180419180
	public void SetSanctuaryObjectParent(SanctuaryObjectBase inSanctuaryObject); // 0x0000000180BF29B0-0x0000000180BF2AF0
	public bool DoesFit(Vector3 inNormal); // 0x0000000180BEEA30-0x0000000180BEEC20
	public void RefreshLastGoodPosition(); // 0x0000000180BF1B70-0x0000000180BF1BE0
	[IteratorStateMachine] // 0x00000001802185A0-0x00000001802185F0
	private IEnumerator InitPlacedObject(); // 0x0000000180BF0D80-0x0000000180BF0DE0
	public void OnCollisionEnter(Collision inCollision); // 0x00000001803774A0-0x00000001803774B0
	public bool BoxCast(int inLayermask, QueryTriggerInteraction inQueryTriggerInteraction, string inTag = "" /* Metadata: 0x007BA347 */); // 0x0000000180BECE70-0x0000000180BECEE0
	public bool EdgeCast(int inLayermask, QueryTriggerInteraction inQueryTriggerInteraction, string inTag = "" /* Metadata: 0x007BA34B */); // 0x0000000180BEEC20-0x0000000180BEF760
	public bool CornerCast(int inLayermask, QueryTriggerInteraction inQueryTriggerInteraction, string inTag = "" /* Metadata: 0x007BA34F */); // 0x0000000180BED8A0-0x0000000180BEE6D0
	public bool HittingRigidbodyObject(); // 0x0000000180BF0400-0x0000000180BF08B0
	public bool HittingStaticObject(out SanctuaryObjectBase outHitSanctuaryObject); // 0x0000000180BF08B0-0x0000000180BF0D80
	public bool CollidingWithObject(out SanctuaryObjectBase outHitSanctuaryObject); // 0x0000000180BED370-0x0000000180BED8A0
	public bool CanBePlaced(Vector3 inNormal); // 0x0000000180BECF40-0x0000000180BED1D0
	public bool DoesFit(out SanctuaryObjectBase outHitSanctuaryObject); // 0x0000000180BEE790-0x0000000180BEEA30
	private void OnDrawGizmosSelected(); // 0x0000000180BF1250-0x0000000180BF1AA0
	public bool FitsOnSurface(); // 0x0000000180BEF770-0x0000000180BF0140
	public void ServerUpdate(SanctuaryObjectBaseInfo inInfo); // 0x0000000180BF1C60-0x0000000180BF2230
	public void ExternalUpdateObject(bool inRemove = false /* Metadata: 0x007BA353 */); // 0x0000000180BEF760-0x0000000180BEF770
	private void UpdateObject(bool inRemove = false /* Metadata: 0x007BA354 */); // 0x0000000180BF4180-0x0000000180BF46D0
	public void UIChangeState(); // 0x0000000180BF3BD0-0x0000000180BF3CA0
	private BoxCollider CreateTouchCollider(); // 0x0000000180BEE730-0x0000000180BEE790
	private MeshCollider CreateMeshCollider(); // 0x0000000180BEE6D0-0x0000000180BEE730
	public void UpdateDayNight(SanctuaryController.ETime inTime); // 0x0000000180BF3CA0-0x0000000180BF3E40
	public Vector3 GetLastGoodPosition(Vector3 inNormal); // 0x0000000180BF0140-0x0000000180BF01F0
	public Vector3 GetLastGoodRotation(Vector3 inNormal); // 0x0000000180BF01F0-0x0000000180BF02A0
	public void SetTouchColliderActive(bool inActive); // 0x0000000180BF2D70-0x0000000180BF2FE0
	private bool Linecast(Vector3 inStart, Vector3 inEnd, int inLayermask, QueryTriggerInteraction inIgnore); // 0x0000000180BF0DE0-0x0000000180BF0E40
}

