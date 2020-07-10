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

[ChartComponent] // 0x0000000180146010-0x0000000180146040
public class SanctuaryHouseGetModelDefComponent : GetModelDefComponent // TypeDefIndex: 10595
{
	// Nested types
	public enum EHouseMod // TypeDefIndex: 10596
	{
		None = 0,
		Base = 1,
		Edge = 2,
		Decor = 3,
		Shrub = 4,
		Door = 5,
		Light = 6,
		Roof = 7,
		Window = 8
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass2_0 // TypeDefIndex: 10597
	{
		// Fields
		public SanctuaryHouseGetModelDefComponent <>4__this; // 0x10
		public GameObject gHouseContainer; // 0x18
		public Action<GameObject> inResult; // 0x20

		// Constructors
		public <>c__DisplayClass2_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <GetModelRoutine>b__0(List<GameObject> houseObjects); // 0x000000018129FCC0-0x000000018129FD30
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass4_0 // TypeDefIndex: 10598
	{
		// Fields
		public Action<GameObject> inGameObject; // 0x10

		// Constructors
		public <>c__DisplayClass4_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <GetHouseMod>b__0(GameObject gObject); // 0x00000001812A03C0-0x00000001812A0410
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass5_0 // TypeDefIndex: 10599
	{
		// Fields
		public GameObject gModObject; // 0x10

		// Constructors
		public <>c__DisplayClass5_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <GetHouseModsRoutine>b__0(GameObject gObject); // 0x000000018036B1E0-0x000000018036B1F0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <GetHouseModsRoutine>d__5 : IEnumerator<object> // TypeDefIndex: 10600
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Item inItem; // 0x20
		public BaseDef inDef; // 0x28
		public Action<GameObject> inGameObject; // 0x30
		public GameObject inTargetGameObject; // 0x38
		public SanctuaryHouseGetModelDefComponent <>4__this; // 0x40
		public Transform inParentTransform; // 0x48
		public EHouseMod inType; // 0x50
		public int inModIndex; // 0x54
		private <>c__DisplayClass5_0 <>8__1; // 0x58

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <GetHouseModsRoutine>d__5(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181296CC0-0x0000000181297060
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181297060-0x00000001812970B0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass6_0 // TypeDefIndex: 10601
	{
		// Fields
		public GameObject gModObject; // 0x10

		// Constructors
		public <>c__DisplayClass6_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <LoadHouseModComponent>b__0(List<GameObject> gObjects); // 0x00000001812A0410-0x00000001812A0470
		internal void <LoadHouseModComponent>b__1(List<GameObject> gObjects); // 0x00000001812A0470-0x00000001812A04D0
		internal void <LoadHouseModComponent>b__2(List<GameObject> gObjects); // 0x00000001812A04D0-0x00000001812A0530
		internal void <LoadHouseModComponent>b__3(List<GameObject> gObjects); // 0x00000001812A0530-0x00000001812A0590
		internal void <LoadHouseModComponent>b__4(List<GameObject> gObjects); // 0x00000001812A0590-0x00000001812A05F0
		internal void <LoadHouseModComponent>b__5(List<GameObject> gObjects); // 0x00000001812A05F0-0x00000001812A0650
		internal void <LoadHouseModComponent>b__6(List<GameObject> gObjects); // 0x00000001812A0650-0x00000001812A06B0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <LoadHouseModComponent>d__6 : IEnumerator<object> // TypeDefIndex: 10602
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public EHouseMod inType; // 0x20
		public GameObject inTargetGameObject; // 0x28
		public SanctuaryHouseGetModelDefComponent <>4__this; // 0x30
		public SanctuaryHouseDefComponent inSanctuaryHouseDefComponent; // 0x38
		public Transform inParentTransform; // 0x40
		public int inModIndex; // 0x48
		public Action<GameObject> inGameObject; // 0x50
		private <>c__DisplayClass6_0 <>8__1; // 0x58

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <LoadHouseModComponent>d__6(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x000000018129C870-0x000000018129CF10
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x000000018129CF10-0x000000018129CF60
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass7_0 // TypeDefIndex: 10603
	{
		// Fields
		public Action<List<GameObject>> inBases; // 0x10

		// Constructors
		public <>c__DisplayClass7_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <GetModel>b__0(List<GameObject> cLoaded); // 0x00000001812A06B0-0x00000001812A0700
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass8_0 // TypeDefIndex: 10604
	{
		// Fields
		public List<GameObject> aBases; // 0x10

		// Constructors
		public <>c__DisplayClass8_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <GetModelRoutine>b__0(List<GameObject> cLoaded); // 0x000000018036B1E0-0x000000018036B1F0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <GetModelRoutine>d__8 : IEnumerator<object> // TypeDefIndex: 10605
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Item inItem; // 0x20
		public BaseDef inDef; // 0x28
		public Action<List<GameObject>> inBases; // 0x30
		public bool inInSanctuary; // 0x38
		public GameObject inTargetGameObject; // 0x40
		public SanctuaryHouseGetModelDefComponent <>4__this; // 0x48
		public Transform inParentTransform; // 0x50
		private <>c__DisplayClass8_0 <>8__1; // 0x58
		public int inModIndex; // 0x60
		private HouseItemComponent <cHouseItemComponent>5__2; // 0x68
		private SanctuaryHouseDefComponent <cSanctuaryHouseDefComponent>5__3; // 0x70
		private int <iExpansionIndex>5__4; // 0x78
		private string <sAttachName>5__5; // 0x80
		private GameObject <gHouseAttachment>5__6; // 0x88

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <GetModelRoutine>d__8(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001812992F0-0x0000000181299EE0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181299EE0-0x0000000181299F30
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass9_0 // TypeDefIndex: 10606
	{
		// Fields
		public SanctuaryLayoutData cSanctuaryLayoutData; // 0x10

		// Constructors
		public <>c__DisplayClass9_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <LoadLayoutData>b__0(SanctuaryLayoutData loadedAsset); // 0x000000018036B1E0-0x000000018036B1F0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <LoadLayoutData>d__9 : IEnumerator<object> // TypeDefIndex: 10607
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		private <>c__DisplayClass9_0 <>8__1; // 0x20
		public GameObject inTargetGameObject; // 0x28
		public SanctuaryHouseDefComponent inSanctuaryHouseDefComponent; // 0x30
		public HouseItemComponent inHouseItemComponent; // 0x38
		private int <iPurchasedStages>5__2; // 0x40
		private List<int> <iPurchasedAreas>5__3; // 0x48

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <LoadLayoutData>d__9(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x000000018129CF60-0x000000018129D3A0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x000000018129D3A0-0x000000018129D3F0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <LoadHouseComponents>d__10 : IEnumerator<object> // TypeDefIndex: 10608
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public int inModIndex; // 0x20
		public GameObject inTargetGameObject; // 0x28
		public SanctuaryHouseGetModelDefComponent <>4__this; // 0x30
		public SanctuaryHouseDefComponent inSanctuaryHouseDefComponent; // 0x38
		public Transform inParentTransform; // 0x40
		public int inExpansionIndex; // 0x48
		public bool inInSanctuary; // 0x4C
		private int <iEdgeModIndex>5__2; // 0x50
		private int <iShrubModIndex>5__3; // 0x54
		private int <iDecorModIndex>5__4; // 0x58
		private int <iDoorModIndex>5__5; // 0x5C
		private int <iLightModIndex>5__6; // 0x60
		private int <iWindowModIndex>5__7; // 0x64

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <LoadHouseComponents>d__10(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x000000018129C3C0-0x000000018129C820
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x000000018129C820-0x000000018129C870
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass14_0 // TypeDefIndex: 10609
	{
		// Fields
		public List<GameObject> gObjects; // 0x10
		public Action<GameObject> <>9__0; // 0x18

		// Constructors
		public <>c__DisplayClass14_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <BuildBases>b__0(GameObject gObject); // 0x000000018129F730-0x000000018129F790
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <BuildBases>d__14 : IEnumerator<object> // TypeDefIndex: 10610
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SanctuaryHouseGetModelDefComponent <>4__this; // 0x20
		public SanctuaryHouseDefComponent inSanctuaryHouseDefComponent; // 0x28
		public int inExpansionIdx; // 0x30
		public int inModIndex; // 0x34
		public GameObject inParent; // 0x38
		private <>c__DisplayClass14_0 <>8__1; // 0x40
		public Action<List<GameObject>> inGameObjects; // 0x48
		private SanctuaryHouseDefComponent.Expansion <cExpansion>5__2; // 0x50
		private int <ii>5__3; // 0x58

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <BuildBases>d__14(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181293D90-0x0000000181294070
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181294070-0x00000001812940C0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass15_0 // TypeDefIndex: 10611
	{
		// Fields
		public List<GameObject> gObjects; // 0x10
		public Action<GameObject> <>9__0; // 0x18

		// Constructors
		public <>c__DisplayClass15_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <BuildEdges>b__0(GameObject gObject); // 0x000000018129F790-0x000000018129F7F0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <BuildEdges>d__15 : IEnumerator<object> // TypeDefIndex: 10612
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SanctuaryHouseGetModelDefComponent <>4__this; // 0x20
		public SanctuaryHouseDefComponent inSanctuaryHouseDefComponent; // 0x28
		public int inExpansionIdx; // 0x30
		public GameObject inBase; // 0x38
		private <>c__DisplayClass15_0 <>8__1; // 0x40
		public int inModIndex; // 0x48
		public Action<List<GameObject>> inGameObjects; // 0x50
		private SanctuaryHouseDefComponent.Expansion <cExpansion>5__2; // 0x58
		private List<Transform> <cTransforms>5__3; // 0x60
		private int <ii>5__4; // 0x68

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <BuildEdges>d__15(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181294BA0-0x00000001812950C0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001812950C0-0x0000000181295110
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass16_0 // TypeDefIndex: 10613
	{
		// Fields
		public List<GameObject> gObjects; // 0x10
		public Action<GameObject> <>9__0; // 0x18

		// Constructors
		public <>c__DisplayClass16_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <BuildShrubs>b__0(GameObject gObject); // 0x000000018129F7F0-0x000000018129F850
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <BuildShrubs>d__16 : IEnumerator<object> // TypeDefIndex: 10614
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SanctuaryHouseGetModelDefComponent <>4__this; // 0x20
		public SanctuaryHouseDefComponent inSanctuaryHouseDefComponent; // 0x28
		public int inExpansionIdx; // 0x30
		public GameObject inBase; // 0x38
		private <>c__DisplayClass16_0 <>8__1; // 0x40
		public int inModIndex; // 0x48
		public Action<List<GameObject>> inGameObjects; // 0x50
		private SanctuaryHouseDefComponent.Expansion <cExpansion>5__2; // 0x58
		private List<Transform> <cTransforms>5__3; // 0x60
		private int <ii>5__4; // 0x68

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <BuildShrubs>d__16(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181295B10-0x0000000181296030
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181296030-0x0000000181296080
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass17_0 // TypeDefIndex: 10615
	{
		// Fields
		public List<GameObject> gObjects; // 0x10
		public Action<GameObject> <>9__0; // 0x18

		// Constructors
		public <>c__DisplayClass17_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <BuildDecor>b__0(GameObject gObject); // 0x000000018129F850-0x000000018129F8B0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <BuildDecor>d__17 : IEnumerator<object> // TypeDefIndex: 10616
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SanctuaryHouseGetModelDefComponent <>4__this; // 0x20
		public SanctuaryHouseDefComponent inSanctuaryHouseDefComponent; // 0x28
		public int inExpansionIdx; // 0x30
		public GameObject inBase; // 0x38
		private <>c__DisplayClass17_0 <>8__1; // 0x40
		public int inModIndex; // 0x48
		public Action<List<GameObject>> inGameObjects; // 0x50
		private SanctuaryHouseDefComponent.Expansion <cExpansion>5__2; // 0x58
		private List<Transform> <cTransforms>5__3; // 0x60
		private int <ii>5__4; // 0x68

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <BuildDecor>d__17(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001812940C0-0x00000001812945E0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001812945E0-0x0000000181294630
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass18_0 // TypeDefIndex: 10617
	{
		// Fields
		public List<GameObject> gObjects; // 0x10
		public Action<GameObject> <>9__0; // 0x18

		// Constructors
		public <>c__DisplayClass18_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <BuildDoors>b__0(GameObject gObject); // 0x000000018129F8B0-0x000000018129F940
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <BuildDoors>d__18 : IEnumerator<object> // TypeDefIndex: 10618
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SanctuaryHouseGetModelDefComponent <>4__this; // 0x20
		public SanctuaryHouseDefComponent inSanctuaryHouseDefComponent; // 0x28
		public int inExpansionIdx; // 0x30
		public GameObject inBase; // 0x38
		private <>c__DisplayClass18_0 <>8__1; // 0x40
		public int inModIndex; // 0x48
		public Action<List<GameObject>> inGameObjects; // 0x50
		private SanctuaryHouseDefComponent.Expansion <cExpansion>5__2; // 0x58
		private List<Transform> <cTransforms>5__3; // 0x60
		private int <ii>5__4; // 0x68

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <BuildDoors>d__18(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181294630-0x0000000181294B50
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181294B50-0x0000000181294BA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass19_0 // TypeDefIndex: 10619
	{
		// Fields
		public List<GameObject> gObjects; // 0x10
		public Action<GameObject> <>9__0; // 0x18

		// Constructors
		public <>c__DisplayClass19_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <BuildLights>b__0(GameObject gObject); // 0x000000018129F940-0x000000018129F9A0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <BuildLights>d__19 : IEnumerator<object> // TypeDefIndex: 10620
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SanctuaryHouseGetModelDefComponent <>4__this; // 0x20
		public SanctuaryHouseDefComponent inSanctuaryHouseDefComponent; // 0x28
		public int inExpansionIdx; // 0x30
		public GameObject inBase; // 0x38
		private <>c__DisplayClass19_0 <>8__1; // 0x40
		public int inModIndex; // 0x48
		public Action<List<GameObject>> inGameObjects; // 0x50
		private SanctuaryHouseDefComponent.Expansion <cExpansion>5__2; // 0x58
		private List<Transform> <cTransforms>5__3; // 0x60
		private int <ii>5__4; // 0x68

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <BuildLights>d__19(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181295110-0x0000000181295630
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181295630-0x0000000181295680
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass20_0 // TypeDefIndex: 10621
	{
		// Fields
		public List<GameObject> gObjects; // 0x10
		public Action<GameObject> <>9__0; // 0x18

		// Constructors
		public <>c__DisplayClass20_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <BuildRoofs>b__0(GameObject gObject); // 0x000000018129FC00-0x000000018129FC60
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <BuildRoofs>d__20 : IEnumerator<object> // TypeDefIndex: 10622
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public GameObject inBase; // 0x20
		public SanctuaryHouseGetModelDefComponent <>4__this; // 0x28
		public SanctuaryHouseDefComponent inSanctuaryHouseDefComponent; // 0x30
		public int inExpansionIdx; // 0x38
		private <>c__DisplayClass20_0 <>8__1; // 0x40
		public int inModIndex; // 0x48
		public Action<List<GameObject>> inGameObjects; // 0x50
		private SanctuaryHouseDefComponent.Expansion <cExpansion>5__2; // 0x58
		private GameObject <gRoofsParent>5__3; // 0x60
		private int <ii>5__4; // 0x68

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <BuildRoofs>d__20(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181295680-0x0000000181295AC0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181295AC0-0x0000000181295B10
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass21_0 // TypeDefIndex: 10623
	{
		// Fields
		public List<GameObject> gObjects; // 0x10
		public Action<GameObject> <>9__0; // 0x18

		// Constructors
		public <>c__DisplayClass21_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <BuildWindows>b__0(GameObject gObject); // 0x000000018129FC60-0x000000018129FCC0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <BuildWindows>d__21 : IEnumerator<object> // TypeDefIndex: 10624
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SanctuaryHouseGetModelDefComponent <>4__this; // 0x20
		public SanctuaryHouseDefComponent inSanctuaryHouseDefComponent; // 0x28
		public int inExpansionIdx; // 0x30
		public GameObject inBase; // 0x38
		private <>c__DisplayClass21_0 <>8__1; // 0x40
		public int inModIndex; // 0x48
		public Action<List<GameObject>> inGameObjects; // 0x50
		private SanctuaryHouseDefComponent.Expansion <cExpansion>5__2; // 0x58
		private List<Transform> <cTransforms>5__3; // 0x60
		private int <ii>5__4; // 0x68

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <BuildWindows>d__21(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181296080-0x00000001812965F0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001812965F0-0x0000000181296640
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass22_0 // TypeDefIndex: 10625
	{
		// Fields
		public GameObject gResult; // 0x10

		// Constructors
		public <>c__DisplayClass22_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <SpawnComponent>b__0(GameObject gModel); // 0x000000018036B1E0-0x000000018036B1F0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <SpawnComponent>d__22 : IEnumerator<object> // TypeDefIndex: 10626
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ChartDef inChartDef; // 0x20
		public int inModIndex; // 0x28
		public Transform inParentTransform; // 0x30
		public GameObject inTargetGameObject; // 0x38
		private <>c__DisplayClass22_0 <>8__1; // 0x40
		public Action<GameObject> inResult; // 0x48

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <SpawnComponent>d__22(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x000000018129E2A0-0x000000018129E6D0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x000000018129E6D0-0x000000018129E720
	}

	// Constructors
	public SanctuaryHouseGetModelDefComponent(); // 0x000000018128AF80-0x000000018128AF90

	// Methods
	private int ModifyIdx(int inIdx, int inMax); // 0x000000018128E590-0x000000018128E600
	protected override IEnumerator GetModelRoutine(GameObject inTargetGameObject, Transform inParentTransform, Action<GameObject> inResult, Item inItem = null, BaseDef inDef = null, BaseInfo inInfo = null, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x00781E40 */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x00781E44 */); // 0x000000018128E120-0x000000018128E290
	private void ChangeFromStandardShaderToFeralUnlit(GameObject inGameObject); // 0x000000018128D160-0x000000018128D9E0
	public QRoutine GetHouseMod(GameObject inTargetGameObject, Transform inParentTransform, EHouseMod inType, Action<GameObject> inGameObject, Item inItem = null, BaseDef inDef = null, int inModIndex = -1 /* Metadata: 0x00781E48 */); // 0x000000018128DAB0-0x000000018128DBF0
	[IteratorStateMachine] // 0x00000001801461E0-0x0000000180146230
	private IEnumerator GetHouseModsRoutine(GameObject inTargetGameObject, Transform inParentTransform, EHouseMod inType, Action<GameObject> inGameObject, Item inItem = null, BaseDef inDef = null, int inModIndex = -1 /* Metadata: 0x00781E4C */); // 0x000000018128DBF0-0x000000018128DCA0
	[IteratorStateMachine] // 0x00000001801464D0-0x0000000180146520
	private IEnumerator LoadHouseModComponent(SanctuaryHouseDefComponent inSanctuaryHouseDefComponent, GameObject inTargetGameObject, Transform inParentTransform, EHouseMod inType, Action<GameObject> inGameObject, int inModIndex = -1 /* Metadata: 0x00781E50 */); // 0x000000018128E460-0x000000018128E510
	public QRoutine GetModel(GameObject inTargetGameObject, Transform inParentTransform, Action<List<GameObject>> inBases, Item inItem = null, BaseDef inDef = null, bool inInSanctuary = false /* Metadata: 0x00781E54 */, int inModIndex = -1 /* Metadata: 0x00781E55 */); // 0x000000018128E290-0x000000018128E3B0
	[IteratorStateMachine] // 0x0000000180146740-0x0000000180146790
	private IEnumerator GetModelRoutine(GameObject inTargetGameObject, Transform inParentTransform, Action<List<GameObject>> inBases, Item inItem = null, BaseDef inDef = null, bool inInSanctuary = false /* Metadata: 0x00781E59 */, int inModIndex = -1 /* Metadata: 0x00781E5A */); // 0x000000018128E070-0x000000018128E120
	[IteratorStateMachine] // 0x0000000180146800-0x0000000180146850
	private IEnumerator LoadLayoutData(SanctuaryHouseDefComponent inSanctuaryHouseDefComponent, HouseItemComponent inHouseItemComponent, GameObject inTargetGameObject); // 0x000000018128E510-0x000000018128E590
	[IteratorStateMachine] // 0x0000000180146A70-0x0000000180146AC0
	private IEnumerator LoadHouseComponents(SanctuaryHouseDefComponent inSanctuaryHouseDefComponent, GameObject inTargetGameObject, Transform inParentTransform, bool inInSanctuary, int inExpansionIndex, int inModIndex); // 0x000000018128E3B0-0x000000018128E460
	private bool ValidNameAndIndex(Transform inTransform, int inIdx); // 0x000000018128E690-0x000000018128E730
	private SanctuaryHouseDefComponent.Expansion GetExpansionIndex(List<SanctuaryHouseDefComponent.Expansion> inExpansion, int inIndex); // 0x000000018128D9E0-0x000000018128DAB0
	private bool GetLocatorEnabled(Transform inTransform, int inExpansionIndex); // 0x000000018128DD80-0x000000018128E070
	[IteratorStateMachine] // 0x0000000180146DF0-0x0000000180146E40
	private IEnumerator BuildBases(SanctuaryHouseDefComponent inSanctuaryHouseDefComponent, GameObject inParent, int inExpansionIdx, Action<List<GameObject>> inGameObjects, int inModIndex = -1 /* Metadata: 0x00781E5E */); // 0x000000018128CC60-0x000000018128CD00
	[IteratorStateMachine] // 0x0000000180147040-0x0000000180147090
	private IEnumerator BuildEdges(SanctuaryHouseDefComponent inSanctuaryHouseDefComponent, GameObject inBase, int inExpansionIdx, Action<List<GameObject>> inGameObjects, int inModIndex = -1 /* Metadata: 0x00781E62 */); // 0x000000018128CE40-0x000000018128CEE0
	[IteratorStateMachine] // 0x00000001801472C0-0x0000000180147310
	private IEnumerator BuildShrubs(SanctuaryHouseDefComponent inSanctuaryHouseDefComponent, GameObject inBase, int inExpansionIdx, Action<List<GameObject>> inGameObjects, int inModIndex = -1 /* Metadata: 0x00781E66 */); // 0x000000018128D020-0x000000018128D0C0
	[IteratorStateMachine] // 0x0000000180147650-0x00000001801476A0
	private IEnumerator BuildDecor(SanctuaryHouseDefComponent inSanctuaryHouseDefComponent, GameObject inBase, int inExpansionIdx, Action<List<GameObject>> inGameObjects, int inModIndex = -1 /* Metadata: 0x00781E6A */); // 0x000000018128CD00-0x000000018128CDA0
	[IteratorStateMachine] // 0x0000000180147900-0x0000000180147950
	private IEnumerator BuildDoors(SanctuaryHouseDefComponent inSanctuaryHouseDefComponent, GameObject inBase, bool inInSanctuary, int inExpansionIdx, Action<List<GameObject>> inGameObjects, int inModIndex = -1 /* Metadata: 0x00781E6E */); // 0x000000018128CDA0-0x000000018128CE40
	[IteratorStateMachine] // 0x0000000180147C30-0x0000000180147C80
	private IEnumerator BuildLights(SanctuaryHouseDefComponent inSanctuaryHouseDefComponent, GameObject inBase, int inExpansionIdx, Action<List<GameObject>> inGameObjects, int inModIndex = -1 /* Metadata: 0x00781E72 */); // 0x000000018128CEE0-0x000000018128CF80
	[IteratorStateMachine] // 0x0000000180147EA0-0x0000000180147EF0
	private IEnumerator BuildRoofs(SanctuaryHouseDefComponent inSanctuaryHouseDefComponent, GameObject inBase, int inExpansionIdx, Action<List<GameObject>> inGameObjects, int inModIndex = -1 /* Metadata: 0x00781E76 */); // 0x000000018128CF80-0x000000018128D020
	[IteratorStateMachine] // 0x00000001801482F0-0x0000000180148340
	private IEnumerator BuildWindows(SanctuaryHouseDefComponent inSanctuaryHouseDefComponent, GameObject inBase, int inExpansionIdx, Action<List<GameObject>> inGameObjects, int inModIndex = -1 /* Metadata: 0x00781E7A */); // 0x000000018128D0C0-0x000000018128D160
	[IteratorStateMachine] // 0x0000000180148660-0x00000001801486B0
	private IEnumerator SpawnComponent(SanctuaryHouseDefComponent inSanctuaryHouseDefComponent, GameObject inTargetGameObject, Transform inParentTransform, ChartDef inChartDef, int iExpansionIndex, Action<GameObject> inResult = null, int inModIndex = -1 /* Metadata: 0x00781E7E */); // 0x000000018128E600-0x000000018128E690
	private int GetIndex(Transform inTransform); // 0x000000018128DCA0-0x000000018128DD80
}

