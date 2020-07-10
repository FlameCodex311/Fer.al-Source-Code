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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_WorldMapLevelButton : UI_WorldMapButton // TypeDefIndex: 12631
{
	// Fields
	[RootSelector] // 0x00000001800FA2F0-0x00000001800FA370
	[SerializeField] // 0x00000001800FA2F0-0x00000001800FA370
	private string _levelDefId; // 0x48
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _expanse; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private SocialExpanseArea _socialExpanseArea; // 0x54
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform _subButtonParent; // 0x58
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _levelImage; // 0x60
	private LevelDefComponent.WorldMapInfo _worldMapInfo; // 0x68
	private GameObject _subLevelButton; // 0x70
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <FinishedLoading>k__BackingField; // 0x78

	// Properties
	public bool FinishedLoading { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001804A2540-0x00000001804A2550 0x0000000180933270-0x0000000180933280

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <Init>d__9 : IEnumerator<object> // TypeDefIndex: 12632
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public UI_WorldMapLevelButton <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <Init>d__9(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180F78470-0x0000000180F78920
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180F78920-0x0000000180F78AB0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass16_0 // TypeDefIndex: 12633
	{
		// Fields
		public GameObject gClone; // 0x10
		public UI_WorldMapLevelButton <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass16_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <WorldMapDataSet>b__0(Sprite sp); // 0x0000000180F7AA00-0x0000000180F7ABA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass18_0 // TypeDefIndex: 12634
	{
		// Fields
		public Action<Sprite> inSprite; // 0x10

		// Constructors
		public <>c__DisplayClass18_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <GetSprite>b__0(Sprite sp); // 0x0000000180F7ABA0-0x0000000180F7ABF0
	}

	// Constructors
	public UI_WorldMapLevelButton(); // 0x0000000180F87DE0-0x0000000180F87EA0

	// Methods
	public void SetLevelDetails(LevelDefComponent.WorldMapInfo inWorldMapInfo, Transform inParent); // 0x0000000180F87590-0x0000000180F875C0
	private void Start(); // 0x0000000180F87880-0x0000000180F878F0
	[IteratorStateMachine] // 0x00000001800FABD0-0x00000001800FAC20
	private IEnumerator Init(); // 0x0000000180F874E0-0x0000000180F87540
	private void FadeOutImmediate(); // 0x0000000180F86E90-0x0000000180F86F20
	public void FadeIn(); // 0x0000000180F86E00-0x0000000180F86E90
	private void WorldMapDataSet(List<LevelDefComponent.WorldMapInfo> inWorldMapInfos, Transform inParent, bool inExpanse); // 0x0000000180F87920-0x0000000180F87DE0
	private string GetLocalizationId(LevelDefComponent.WorldMapInfo inWorldMapInfo); // 0x0000000180F86F20-0x0000000180F87090
	private void GetSprite(LevelDefComponent.WorldMapInfo inWorldMapInfo, Action<Sprite> inSprite); // 0x0000000180F87090-0x0000000180F87390
	private string GetTooltipDefId(LevelDefComponent.WorldMapInfo inWorldMapInfo); // 0x0000000180F87390-0x0000000180F87470
	private void SetSprite(GameObject inGameObject, Sprite inSprite); // 0x0000000180F876F0-0x0000000180F87880
	private void SetLocalizedName(GameObject inGameObject, string inLocDefId); // 0x0000000180F875C0-0x0000000180F876F0
	public override void GoToLevel(); // 0x0000000180F87470-0x0000000180F874E0
	public override void Scroll(BaseEventData inBaseEventData); // 0x0000000180F87540-0x0000000180F87590
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Init>b__9_0(Sprite inSprite); // 0x0000000180F878F0-0x0000000180F87920
}

