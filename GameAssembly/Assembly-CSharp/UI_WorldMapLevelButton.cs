/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_WorldMapLevelButton : UI_WorldMapButton // TypeDefIndex: 14233
{
	// Fields
	[RootSelector] // 0x00000001801EE1F0-0x00000001801EE270
	[SerializeField] // 0x00000001801EE1F0-0x00000001801EE270
	private string _levelDefId; // 0x48
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _expanse; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private SocialExpanseArea _socialExpanseArea; // 0x54
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _subButtonParent; // 0x58
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _levelImage; // 0x60
	private LevelDefComponent.WorldMapInfo _worldMapInfo; // 0x68
	private GameObject _subLevelButton; // 0x70
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <FinishedLoading>k__BackingField; // 0x78

	// Properties
	public bool FinishedLoading { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180453D00-0x0000000180453D10 0x0000000180453D10-0x0000000180453D20

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <Init>d__9 : IEnumerator<object> // TypeDefIndex: 14234
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public UI_WorldMapLevelButton <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <Init>d__9(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001804443C0-0x0000000180444860
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180444860-0x0000000180445150
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass16_0 // TypeDefIndex: 14235
	{
		// Fields
		public GameObject gClone; // 0x10
		public UI_WorldMapLevelButton <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass16_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <WorldMapDataSet>b__0(Sprite sp); // 0x0000000180447470-0x0000000180447610
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass18_0 // TypeDefIndex: 14236
	{
		// Fields
		public Action<Sprite> inSprite; // 0x10

		// Constructors
		public <>c__DisplayClass18_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <GetSprite>b__0(Sprite sp); // 0x0000000180447610-0x0000000180447660
	}

	// Constructors
	public UI_WorldMapLevelButton(); // 0x0000000180453C40-0x0000000180453D00

	// Methods
	public void SetLevelDetails(LevelDefComponent.WorldMapInfo inWorldMapInfo, Transform inParent); // 0x0000000180453400-0x0000000180453430
	private void Start(); // 0x00000001804536E0-0x0000000180453750
	[IteratorStateMachine] // 0x00000001801EECA0-0x00000001801EECF0
	private IEnumerator Init(); // 0x0000000180453350-0x00000001804533B0
	private void FadeOutImmediate(); // 0x0000000180452D10-0x0000000180452DA0
	public void FadeIn(); // 0x0000000180452C80-0x0000000180452D10
	private void WorldMapDataSet(List<LevelDefComponent.WorldMapInfo> inWorldMapInfos, Transform inParent, bool inExpanse); // 0x0000000180453780-0x0000000180453C40
	private string GetLocalizationId(LevelDefComponent.WorldMapInfo inWorldMapInfo); // 0x0000000180452DA0-0x0000000180452F10
	private void GetSprite(LevelDefComponent.WorldMapInfo inWorldMapInfo, Action<Sprite> inSprite); // 0x0000000180452F10-0x0000000180453200
	private string GetTooltipDefId(LevelDefComponent.WorldMapInfo inWorldMapInfo); // 0x0000000180453200-0x00000001804532E0
	private void SetSprite(GameObject inGameObject, Sprite inSprite); // 0x0000000180453550-0x00000001804536E0
	private void SetLocalizedName(GameObject inGameObject, string inLocDefId); // 0x0000000180453430-0x0000000180453550
	public override void GoToLevel(); // 0x00000001804532E0-0x0000000180453350
	public override void Scroll(BaseEventData inBaseEventData); // 0x00000001804533B0-0x0000000180453400
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Init>b__9_0(Sprite inSprite); // 0x0000000180453750-0x0000000180453780
}

