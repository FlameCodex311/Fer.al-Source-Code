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

[ChartComponent] // 0x0000000180226EA0-0x0000000180226ED0
public class SanctuaryHouseGetModelDefComponent : GetModelDefComponent // TypeDefIndex: 12096
{
	// Nested types
	public enum EHouseMod // TypeDefIndex: 12097
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

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass2_0 // TypeDefIndex: 12098
	{
		// Fields
		public SanctuaryHouseGetModelDefComponent <>4__this; // 0x10
		public GameObject gHouseContainer; // 0x18
		public Action<GameObject> inResult; // 0x20

		// Constructors
		public <>c__DisplayClass2_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <GetModelRoutine>b__0(List<GameObject> houseObjects); // 0x00000001807C2D50-0x00000001807C2DC0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass4_0 // TypeDefIndex: 12099
	{
		// Fields
		public Action<GameObject> inGameObject; // 0x10

		// Constructors
		public <>c__DisplayClass4_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <GetHouseMod>b__0(GameObject gObject); // 0x00000001807C31F0-0x00000001807C3240
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass5_0 // TypeDefIndex: 12100
	{
		// Fields
		public GameObject gModObject; // 0x10

		// Constructors
		public <>c__DisplayClass5_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <GetHouseModsRoutine>b__0(GameObject gObject); // 0x0000000180379F20-0x0000000180379F30
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <GetHouseModsRoutine>d__5 : IEnumerator<object> // TypeDefIndex: 12101
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <GetHouseModsRoutine>d__5(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807BB770-0x00000001807BBB10
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807BBB10-0x00000001807BBB60
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass6_0 // TypeDefIndex: 12102
	{
		// Fields
		public GameObject gModObject; // 0x10

		// Constructors
		public <>c__DisplayClass6_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <LoadHouseModComponent>b__0(List<GameObject> gObjects); // 0x00000001807C34A0-0x00000001807C3500
		internal void <LoadHouseModComponent>b__1(List<GameObject> gObjects); // 0x00000001807C3500-0x00000001807C3560
		internal void <LoadHouseModComponent>b__2(List<GameObject> gObjects); // 0x00000001807C3560-0x00000001807C35C0
		internal void <LoadHouseModComponent>b__3(List<GameObject> gObjects); // 0x00000001807C35C0-0x00000001807C3620
		internal void <LoadHouseModComponent>b__4(List<GameObject> gObjects); // 0x00000001807C3620-0x00000001807C3680
		internal void <LoadHouseModComponent>b__5(List<GameObject> gObjects); // 0x00000001807C3680-0x00000001807C36E0
		internal void <LoadHouseModComponent>b__6(List<GameObject> gObjects); // 0x00000001807C36E0-0x00000001807C3740
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <LoadHouseModComponent>d__6 : IEnumerator<object> // TypeDefIndex: 12103
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <LoadHouseModComponent>d__6(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807BF0B0-0x00000001807BF740
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807BF740-0x00000001807BF790
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass7_0 // TypeDefIndex: 12104
	{
		// Fields
		public Action<List<GameObject>> inBases; // 0x10

		// Constructors
		public <>c__DisplayClass7_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <GetModel>b__0(List<GameObject> cLoaded); // 0x00000001807C3740-0x00000001807C3790
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass8_0 // TypeDefIndex: 12105
	{
		// Fields
		public List<GameObject> aBases; // 0x10

		// Constructors
		public <>c__DisplayClass8_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <GetModelRoutine>b__0(List<GameObject> cLoaded); // 0x0000000180379F20-0x0000000180379F30
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <GetModelRoutine>d__8 : IEnumerator<object> // TypeDefIndex: 12106
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <GetModelRoutine>d__8(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807BC3E0-0x00000001807BCFB0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807BCFB0-0x00000001807BD000
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass9_0 // TypeDefIndex: 12107
	{
		// Fields
		public SanctuaryLayoutData cSanctuaryLayoutData; // 0x10

		// Constructors
		public <>c__DisplayClass9_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <LoadLayoutData>b__0(SanctuaryLayoutData loadedAsset); // 0x0000000180379F20-0x0000000180379F30
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <LoadLayoutData>d__9 : IEnumerator<object> // TypeDefIndex: 12108
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <LoadLayoutData>d__9(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807BF790-0x00000001807BFBB0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807BFBB0-0x00000001807BFC00
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <LoadHouseComponents>d__10 : IEnumerator<object> // TypeDefIndex: 12109
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <LoadHouseComponents>d__10(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807BEC10-0x00000001807BF060
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807BF060-0x00000001807BF0B0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass14_0 // TypeDefIndex: 12110
	{
		// Fields
		public List<GameObject> gObjects; // 0x10
		public Action<GameObject> <>9__0; // 0x18

		// Constructors
		public <>c__DisplayClass14_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <BuildBases>b__0(GameObject gObject); // 0x00000001807C25E0-0x00000001807C2640
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <BuildBases>d__14 : IEnumerator<object> // TypeDefIndex: 12111
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <BuildBases>d__14(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807B8880-0x00000001807B8B50
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807B8B50-0x00000001807B8BA0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass15_0 // TypeDefIndex: 12112
	{
		// Fields
		public List<GameObject> gObjects; // 0x10
		public Action<GameObject> <>9__0; // 0x18

		// Constructors
		public <>c__DisplayClass15_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <BuildEdges>b__0(GameObject gObject); // 0x00000001807C2640-0x00000001807C26A0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <BuildEdges>d__15 : IEnumerator<object> // TypeDefIndex: 12113
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <BuildEdges>d__15(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807B9640-0x00000001807B9B40
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807B9B40-0x00000001807B9B90
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass16_0 // TypeDefIndex: 12114
	{
		// Fields
		public List<GameObject> gObjects; // 0x10
		public Action<GameObject> <>9__0; // 0x18

		// Constructors
		public <>c__DisplayClass16_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <BuildShrubs>b__0(GameObject gObject); // 0x00000001807C26A0-0x00000001807C2700
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <BuildShrubs>d__16 : IEnumerator<object> // TypeDefIndex: 12115
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <BuildShrubs>d__16(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807BA550-0x00000001807BAA50
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807BAA50-0x00000001807BAAA0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass17_0 // TypeDefIndex: 12116
	{
		// Fields
		public List<GameObject> gObjects; // 0x10
		public Action<GameObject> <>9__0; // 0x18

		// Constructors
		public <>c__DisplayClass17_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <BuildDecor>b__0(GameObject gObject); // 0x00000001807C27A0-0x00000001807C2800
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <BuildDecor>d__17 : IEnumerator<object> // TypeDefIndex: 12117
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <BuildDecor>d__17(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807B8BA0-0x00000001807B90A0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807B90A0-0x00000001807B90F0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass18_0 // TypeDefIndex: 12118
	{
		// Fields
		public List<GameObject> gObjects; // 0x10
		public Action<GameObject> <>9__0; // 0x18

		// Constructors
		public <>c__DisplayClass18_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <BuildDoors>b__0(GameObject gObject); // 0x00000001807C2800-0x00000001807C2890
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <BuildDoors>d__18 : IEnumerator<object> // TypeDefIndex: 12119
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <BuildDoors>d__18(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807B90F0-0x00000001807B95F0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807B95F0-0x00000001807B9640
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass19_0 // TypeDefIndex: 12120
	{
		// Fields
		public List<GameObject> gObjects; // 0x10
		public Action<GameObject> <>9__0; // 0x18

		// Constructors
		public <>c__DisplayClass19_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <BuildLights>b__0(GameObject gObject); // 0x00000001807C2A10-0x00000001807C2A70
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <BuildLights>d__19 : IEnumerator<object> // TypeDefIndex: 12121
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <BuildLights>d__19(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807B9B90-0x00000001807BA090
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807BA090-0x00000001807BA0E0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass20_0 // TypeDefIndex: 12122
	{
		// Fields
		public List<GameObject> gObjects; // 0x10
		public Action<GameObject> <>9__0; // 0x18

		// Constructors
		public <>c__DisplayClass20_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <BuildRoofs>b__0(GameObject gObject); // 0x00000001807C2C90-0x00000001807C2CF0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <BuildRoofs>d__20 : IEnumerator<object> // TypeDefIndex: 12123
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <BuildRoofs>d__20(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807BA0E0-0x00000001807BA500
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807BA500-0x00000001807BA550
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass21_0 // TypeDefIndex: 12124
	{
		// Fields
		public List<GameObject> gObjects; // 0x10
		public Action<GameObject> <>9__0; // 0x18

		// Constructors
		public <>c__DisplayClass21_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <BuildWindows>b__0(GameObject gObject); // 0x00000001807C2CF0-0x00000001807C2D50
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <BuildWindows>d__21 : IEnumerator<object> // TypeDefIndex: 12125
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <BuildWindows>d__21(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807BAAA0-0x00000001807BAFF0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807BAFF0-0x00000001807BB040
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass22_0 // TypeDefIndex: 12126
	{
		// Fields
		public GameObject gResult; // 0x10

		// Constructors
		public <>c__DisplayClass22_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <SpawnComponent>b__0(GameObject gModel); // 0x0000000180379F20-0x0000000180379F30
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <SpawnComponent>d__22 : IEnumerator<object> // TypeDefIndex: 12127
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <SpawnComponent>d__22(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807C0A70-0x00000001807C0E90
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807C0E90-0x00000001807C0EE0
	}

	// Constructors
	public SanctuaryHouseGetModelDefComponent(); // 0x00000001803FE710-0x00000001803FE720

	// Methods
	private int ModifyIdx(int inIdx, int inMax); // 0x00000001807B8180-0x00000001807B81F0
	protected override IEnumerator GetModelRoutine(GameObject inTargetGameObject, Transform inParentTransform, Action<GameObject> inResult, Item inItem = null, BaseDef inDef = null, BaseInfo inInfo = null, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x007B9503 */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x007B9507 */); // 0x00000001807B7D20-0x00000001807B7E80
	private void ChangeFromStandardShaderToFeralUnlit(GameObject inGameObject); // 0x00000001807B6DE0-0x00000001807B7600
	public QRoutine GetHouseMod(GameObject inTargetGameObject, Transform inParentTransform, EHouseMod inType, Action<GameObject> inGameObject, Item inItem = null, BaseDef inDef = null, int inModIndex = -1 /* Metadata: 0x007B950B */); // 0x00000001807B76D0-0x00000001807B7810
	[IteratorStateMachine] // 0x0000000180227070-0x00000001802270C0
	private IEnumerator GetHouseModsRoutine(GameObject inTargetGameObject, Transform inParentTransform, EHouseMod inType, Action<GameObject> inGameObject, Item inItem = null, BaseDef inDef = null, int inModIndex = -1 /* Metadata: 0x007B950F */); // 0x00000001807B7810-0x00000001807B78C0
	[IteratorStateMachine] // 0x00000001802273A0-0x00000001802273F0
	private IEnumerator LoadHouseModComponent(SanctuaryHouseDefComponent inSanctuaryHouseDefComponent, GameObject inTargetGameObject, Transform inParentTransform, EHouseMod inType, Action<GameObject> inGameObject, int inModIndex = -1 /* Metadata: 0x007B9513 */); // 0x00000001807B8050-0x00000001807B8100
	public QRoutine GetModel(GameObject inTargetGameObject, Transform inParentTransform, Action<List<GameObject>> inBases, Item inItem = null, BaseDef inDef = null, bool inInSanctuary = false /* Metadata: 0x007B9517 */, int inModIndex = -1 /* Metadata: 0x007B9518 */); // 0x00000001807B7E80-0x00000001807B7FA0
	[IteratorStateMachine] // 0x0000000180227540-0x0000000180227590
	private IEnumerator GetModelRoutine(GameObject inTargetGameObject, Transform inParentTransform, Action<List<GameObject>> inBases, Item inItem = null, BaseDef inDef = null, bool inInSanctuary = false /* Metadata: 0x007B951C */, int inModIndex = -1 /* Metadata: 0x007B951D */); // 0x00000001807B7C70-0x00000001807B7D20
	[IteratorStateMachine] // 0x0000000180228AA0-0x0000000180228AF0
	private IEnumerator LoadLayoutData(SanctuaryHouseDefComponent inSanctuaryHouseDefComponent, HouseItemComponent inHouseItemComponent, GameObject inTargetGameObject); // 0x00000001807B8100-0x00000001807B8180
	[IteratorStateMachine] // 0x0000000180228E30-0x0000000180228E80
	private IEnumerator LoadHouseComponents(SanctuaryHouseDefComponent inSanctuaryHouseDefComponent, GameObject inTargetGameObject, Transform inParentTransform, bool inInSanctuary, int inExpansionIndex, int inModIndex); // 0x00000001807B7FA0-0x00000001807B8050
	private bool ValidNameAndIndex(Transform inTransform, int inIdx); // 0x00000001807B8280-0x00000001807B8310
	private SanctuaryHouseDefComponent.Expansion GetExpansionIndex(List<SanctuaryHouseDefComponent.Expansion> inExpansion, int inIndex); // 0x00000001807B7600-0x00000001807B76D0
	private bool GetLocatorEnabled(Transform inTransform, int inExpansionIndex); // 0x00000001807B79A0-0x00000001807B7C70
	[IteratorStateMachine] // 0x0000000180229220-0x0000000180229270
	private IEnumerator BuildBases(SanctuaryHouseDefComponent inSanctuaryHouseDefComponent, GameObject inParent, int inExpansionIdx, Action<List<GameObject>> inGameObjects, int inModIndex = -1 /* Metadata: 0x007B9521 */); // 0x00000001807B68E0-0x00000001807B6980
	[IteratorStateMachine] // 0x0000000180229540-0x0000000180229590
	private IEnumerator BuildEdges(SanctuaryHouseDefComponent inSanctuaryHouseDefComponent, GameObject inBase, int inExpansionIdx, Action<List<GameObject>> inGameObjects, int inModIndex = -1 /* Metadata: 0x007B9525 */); // 0x00000001807B6AC0-0x00000001807B6B60
	[IteratorStateMachine] // 0x0000000180229850-0x00000001802298A0
	private IEnumerator BuildShrubs(SanctuaryHouseDefComponent inSanctuaryHouseDefComponent, GameObject inBase, int inExpansionIdx, Action<List<GameObject>> inGameObjects, int inModIndex = -1 /* Metadata: 0x007B9529 */); // 0x00000001807B6CA0-0x00000001807B6D40
	[IteratorStateMachine] // 0x0000000180229B50-0x0000000180229BA0
	private IEnumerator BuildDecor(SanctuaryHouseDefComponent inSanctuaryHouseDefComponent, GameObject inBase, int inExpansionIdx, Action<List<GameObject>> inGameObjects, int inModIndex = -1 /* Metadata: 0x007B952D */); // 0x00000001807B6980-0x00000001807B6A20
	[IteratorStateMachine] // 0x0000000180229FE0-0x000000018022A030
	private IEnumerator BuildDoors(SanctuaryHouseDefComponent inSanctuaryHouseDefComponent, GameObject inBase, bool inInSanctuary, int inExpansionIdx, Action<List<GameObject>> inGameObjects, int inModIndex = -1 /* Metadata: 0x007B9531 */); // 0x00000001807B6A20-0x00000001807B6AC0
	[IteratorStateMachine] // 0x000000018022A250-0x000000018022A2A0
	private IEnumerator BuildLights(SanctuaryHouseDefComponent inSanctuaryHouseDefComponent, GameObject inBase, int inExpansionIdx, Action<List<GameObject>> inGameObjects, int inModIndex = -1 /* Metadata: 0x007B9535 */); // 0x00000001807B6B60-0x00000001807B6C00
	[IteratorStateMachine] // 0x000000018022A500-0x000000018022A550
	private IEnumerator BuildRoofs(SanctuaryHouseDefComponent inSanctuaryHouseDefComponent, GameObject inBase, int inExpansionIdx, Action<List<GameObject>> inGameObjects, int inModIndex = -1 /* Metadata: 0x007B9539 */); // 0x00000001807B6C00-0x00000001807B6CA0
	[IteratorStateMachine] // 0x000000018022A670-0x000000018022A6C0
	private IEnumerator BuildWindows(SanctuaryHouseDefComponent inSanctuaryHouseDefComponent, GameObject inBase, int inExpansionIdx, Action<List<GameObject>> inGameObjects, int inModIndex = -1 /* Metadata: 0x007B953D */); // 0x00000001807B6D40-0x00000001807B6DE0
	[IteratorStateMachine] // 0x000000018022A7E0-0x000000018022A830
	private IEnumerator SpawnComponent(SanctuaryHouseDefComponent inSanctuaryHouseDefComponent, GameObject inTargetGameObject, Transform inParentTransform, ChartDef inChartDef, int iExpansionIndex, Action<GameObject> inResult = null, int inModIndex = -1 /* Metadata: 0x007B9541 */); // 0x00000001807B81F0-0x00000001807B8280
	public static int GetIndex(Transform inTransform); // 0x00000001807B78C0-0x00000001807B79A0
}

