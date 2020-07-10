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

public class MinimapManager : SingletonManagerBase<MinimapManager> // TypeDefIndex: 10730
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private ERotationType _rotationType; // 0x60
	[RootSelector] // 0x00000001800BDAA0-0x00000001800BDB00
	public string blipCityFera; // 0x68
	[RootSelector] // 0x00000001800BDBD0-0x00000001800BDC30
	public string blipClothing; // 0x70
	[RootSelector] // 0x00000001800BDDC0-0x00000001800BDE20
	public string blipDye; // 0x78
	[RootSelector] // 0x00000001800BF1E0-0x00000001800BF240
	public string blipExpanse; // 0x80
	[RootSelector] // 0x00000001800BF400-0x00000001800BF460
	public string blipHarvestPoint; // 0x88
	[RootSelector] // 0x00000001800BF5F0-0x00000001800BF650
	public string blipMainQuest; // 0x90
	[RootSelector] // 0x00000001800BF7A0-0x00000001800BF800
	public string blipQuestGiver; // 0x98
	[RootSelector] // 0x00000001800BFA90-0x00000001800BFAF0
	public string blipParlorGame; // 0xA0
	[RootSelector] // 0x00000001800BFC10-0x00000001800BFC70
	public string blipPlayer; // 0xA8
	[RootSelector] // 0x00000001800BFE50-0x00000001800BFEB0
	public string blipFriend; // 0xB0
	[RootSelector] // 0x00000001800C0010-0x00000001800C0070
	public string blipNetworkPlayer; // 0xB8
	[RootSelector] // 0x00000001800C0280-0x00000001800C02E0
	public string blipPortal; // 0xC0
	[RootSelector] // 0x00000001800C0380-0x00000001800C03E0
	public string blipSideQuest; // 0xC8
	[RootSelector] // 0x00000001800C0580-0x00000001800C05E0
	public string blipSpecificLocation; // 0xD0
	[RootSelector] // 0x00000001800C0670-0x00000001800C06D0
	public string blipTradingPost; // 0xD8
	[RootSelector] // 0x00000001800C0850-0x00000001800C08B0
	public string blipTreasureChest; // 0xE0
	[RootSelector] // 0x00000001800C0A00-0x00000001800C0A60
	public string blipUnitOfCinder; // 0xE8
	[RootSelector] // 0x00000001800C0B70-0x00000001800C0BD0
	public string blipNpc; // 0xF0
	[RootSelector] // 0x00000001800C0CA0-0x00000001800C0D00
	public string blipArea; // 0xF8
	[RootSelector] // 0x00000001800C0DA0-0x00000001800C0E00
	public string blipBlackMarket; // 0x100
	[RootSelector] // 0x00000001800C0F30-0x00000001800C0F90
	public string blipLounge; // 0x108
	[RootSelector] // 0x00000001800C1160-0x00000001800C11C0
	public string blipSunkenThicket; // 0x110
	[RootSelector] // 0x00000001800C12E0-0x00000001800C1340
	public string blipUncrafting; // 0x118
	[RootSelector] // 0x00000001800C1590-0x00000001800C15F0
	public string blipFurniture; // 0x120
	[RootSelector] // 0x00000001800C1760-0x00000001800C17C0
	public string blipCasualGame; // 0x128
	[RootSelector] // 0x00000001800C19C0-0x00000001800C1A20
	public string blipDailyQuest; // 0x130
	[RootSelector] // 0x00000001800C1B60-0x00000001800C1BC0
	public string blipDailyQuestGiver; // 0x138
	public bool useNavMeshForMainQuest; // 0x140
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralAudioInfo _audioZoomIn; // 0x148
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralAudioInfo _audioZoomOut; // 0x150
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralAudioInfo _audioMap; // 0x158
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Material _minimapMaterial; // 0x160
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _colorFollowFavorite; // 0x168
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _colorFollow; // 0x178
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _colorNetworkPlayer; // 0x188
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _tooltipsOnBlips; // 0x198
	private GameObject _minimapCloned; // 0x1A0
	private float _screenWidth; // 0x1A8
	private float _screenHeight; // 0x1AC
	private float _screenMin; // 0x1B0
	private Vector3 _screenCenter; // 0x1B4
	public List<MinimapBlip> minimapBlips; // 0x1C0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private MinimapMap <minimapMap>k__BackingField; // 0x1C8
	private bool _showMap; // 0x1D0
	public MinimapDetails minimap; // 0x1D8
	public MinimapDetails minimapExpanded; // 0x1E0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _displayOffscreenRotationNudge; // 0x1E8
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private MinimapBlip <playerBlip>k__BackingField; // 0x1F0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private string <sceneName>k__BackingField; // 0x1F8
	private WeatherState? _lastWeatherState; // 0x200
	private string _weatherString; // 0x208
	public List<BlipPriorityParent> _priorityTransforms; // 0x210
	public List<BlipPriorityParent> _priorityTransformsExpanded; // 0x218

	// Properties
	public ERotationType rotationType { get; } // 0x00000001804A3730-0x00000001804A3740 
	public Color colorFollowFavorite { get; } // 0x00000001810B7BD0-0x00000001810B7BE0 
	public Color colorFollow { get; } // 0x00000001810B7BE0-0x00000001810B7BF0 
	public Color colorNetworkPlayer { get; } // 0x00000001810B7BF0-0x00000001810B7C00 
	public bool tooltipsOnBlips { get; } // 0x00000001810B8430-0x00000001810B8440 
	public Material minimapMaterial { get; } // 0x0000000180CB7670-0x0000000180CB7680 
	private Vector3 screenCenter { get; } // 0x00000001810B8330-0x00000001810B8430 
	public MinimapMap minimapMap { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001810B8240-0x00000001810B8250 0x00000001810B85C0-0x00000001810B85D0
	public float mapScale { get; } // 0x00000001810B8000-0x00000001810B80C0 
	public float blipAreaScale { get; } // 0x00000001810B7A50-0x00000001810B7B10 
	public float blipScale { get; } // 0x00000001810B7B10-0x00000001810B7BD0 
	public float indicatorScale { get; } // 0x00000001810B7FD0-0x00000001810B8000 
	public float indicatorEdgeBuffer { get; } // 0x00000001810B7FA0-0x00000001810B7FD0 
	public float radius { get; } // 0x00000001810B8260-0x00000001810B8320 
	public float zoom { get; set; } // 0x00000001810B8500-0x00000001810B85C0 0x00000001810B85D0-0x00000001810B86A0
	public float minZoom { get; } // 0x00000001810B8180-0x00000001810B8240 
	public float maxZoom { get; } // 0x00000001810B80C0-0x00000001810B8180 
	public float zoomAmount { get; } // 0x00000001810B8440-0x00000001810B8500 
	public MinimapBlip playerBlip { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001810B8250-0x00000001810B8260 0x0000000180E2E910-0x0000000180E2E920
	public string sceneName { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001810B8320-0x00000001810B8330 0x0000000180E2E920-0x0000000180E2E930
	public string currentTime { get; } // 0x00000001810B7C00-0x00000001810B7C80 
	public string currentWeather { get; } // 0x00000001810B7C80-0x00000001810B7FA0 

	// Nested types
	public enum ERotationType // TypeDefIndex: 10731
	{
		RotateMap = 0,
		RotatePlayer = 1
	}

	public enum EBlipType // TypeDefIndex: 10732
	{
		None = 0,
		CityFera = 1,
		Clothing = 2,
		Dye = 3,
		Expanse = 4,
		HarvestPoint = 5,
		MainQuest = 6,
		CasualGame = 7,
		Player = 8,
		Friend = 9,
		NetworkPlayer = 10,
		Portal = 11,
		SideQuest = 12,
		SpecificLocation = 13,
		TradingPost = 14,
		TreasureChest = 15,
		UnitOfCinder = 16,
		Npc = 17,
		Area = 18,
		BlackMarket = 19,
		Lounge = 20,
		SunkenThicket = 21,
		Uncrafting = 22,
		Furniture = 23,
		ParlorGame = 24,
		QuestGiver = 25,
		DailyQuest = 26,
		DailyQuestGiver = 27
	}

	[Serializable]
	public class MinimapDetails // TypeDefIndex: 10733
	{
		// Fields
		public float blipScale; // 0x10
		public float blipAreaScale; // 0x14
		public float indicatorScale; // 0x18
		public float indicatorEdgeBuffer; // 0x1C
		public float mapScale; // 0x20
		public float radius; // 0x24
		public float zoomAmount; // 0x28
		public float zoom; // 0x2C
		public float zoomMin; // 0x30
		public float zoomMax; // 0x34

		// Constructors
		public MinimapDetails(); // 0x00000001810B17E0-0x00000001810B1830
	}

	public class BlipPriorityParent // TypeDefIndex: 10734
	{
		// Fields
		public int priority; // 0x10
		public RectTransform rectTransform; // 0x18

		// Constructors
		public BlipPriorityParent(); // 0x00000001803A2BC0-0x00000001803A2BD0
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 10735
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action <>9__109_0; // 0x08

		// Constructors
		static <>c(); // 0x00000001810BDA70-0x00000001810BDAD0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <LoadMinimapViaBundlePath>b__109_0(); // 0x00000001810BD260-0x00000001810BD2B0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass110_0 // TypeDefIndex: 10736
	{
		// Fields
		public Action<MinimapBlipData> Callback; // 0x10

		// Constructors
		public <>c__DisplayClass110_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <GetMinimapBlipData>b__0(MinimapBlipData cb); // 0x00000001810BD480-0x00000001810BD4D0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass111_0 // TypeDefIndex: 10737
	{
		// Fields
		public MinimapBlipData cMinimapBlipData; // 0x10

		// Constructors
		public <>c__DisplayClass111_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <GetMinimapBlipDataRoutine>b__0(MinimapBlipData loadedAsset); // 0x000000018036B1E0-0x000000018036B1F0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <GetMinimapBlipDataRoutine>d__111 : IEnumerator<object> // TypeDefIndex: 10738
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public MinimapBlip inMinimapBlip; // 0x20
		public MinimapManager <>4__this; // 0x28
		public Action<MinimapBlipData> Callback; // 0x30
		private <>c__DisplayClass111_0 <>8__1; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <GetMinimapBlipDataRoutine>d__111(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001810BC260-0x00000001810BC880
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001810BC880-0x00000001810BC8D0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass142_0 // TypeDefIndex: 10739
	{
		// Fields
		public MinimapBlip inMinimapBlip; // 0x10
		public MinimapManager <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass142_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <Add>b__0(MinimapBlipData cb); // 0x00000001810BD4D0-0x00000001810BD550
	}

	// Constructors
	public MinimapManager(); // 0x00000001810B76D0-0x00000001810B7A50

	// Methods
	public override void MStart(); // 0x00000001810B3AA0-0x00000001810B3C00
	public override void MOnDestroy(); // 0x00000001810B3940-0x00000001810B3AA0
	private void OnLevelLoaded(Message inMessage); // 0x00000001810B3DE0-0x00000001810B4000
	private void OnLoadingStarted(Message inMessage); // 0x00000001810B4000-0x00000001810B4010
	private void OnLoadingFinished(Message inMessage); // 0x00000001803581E0-0x00000001803581F0
	private void OnHideHUDCommand(HideHUDCommand inCommand); // 0x00000001810B3D80-0x00000001810B3DE0
	public void LoadMinimapViaBundlePath(string inBundleIdDefId, bool inCloseMinimapWindow = true /* Metadata: 0x00781F94 */); // 0x00000001810B35C0-0x00000001810B3940
	public void GetMinimapBlipData(MinimapBlip inMinimapBlip, Action<MinimapBlipData> Callback); // 0x00000001810B2960-0x00000001810B2A60
	[IteratorStateMachine] // 0x00000001800C32A0-0x00000001800C32F0
	private IEnumerator GetMinimapBlipDataRoutine(MinimapBlip inMinimapBlip, Action<MinimapBlipData> Callback); // 0x00000001810B28E0-0x00000001810B2960
	private void LateUpdate(); // 0x00000001810B3140-0x00000001810B35C0
	private BlipPriorityParent CreateTransformParent(RectTransform inParent, bool inExpandedMap, int inPriority, bool inMasked, out bool oAdded); // 0x00000001810B1DF0-0x00000001810B2240
	private void ClearNulls(bool inExpandedMap); // 0x00000001810B1B90-0x00000001810B1DF0
	public void UpdateElements(bool inExpandedMap, RectTransform inMapContainer, RectTransform inElementContainerMasked, RectTransform inIndicatorContainer, GameObject inBlipPrefab, GameObject inIndicatorPrefab, ERotationType inRotationType); // 0x00000001810B5830-0x00000001810B6820
	private int SortPriority(BlipPriorityParent inTA, BlipPriorityParent inTB); // 0x00000001810B4070-0x00000001810B4090
	private void SortPriority(bool inExpandedMap); // 0x00000001810B4090-0x00000001810B4530
	private void UpdateIndicator(RectTransform inIndicatorContainer, MinimapBlip inBlip, Vector3 inScreenPosition, float inDistance, Transform inPlayer); // 0x00000001810B6820-0x00000001810B6F20
	private void UpdateBlip(bool inExpandedMap, RectTransform inMapContainer, RectTransform inElementContainer, ERotationType inRotationType, MinimapBlip inBlip, Vector3 inScreenPosition, float inDistance, Transform inPlayer); // 0x00000001810B4640-0x00000001810B5830
	public int GetBlipMinimapLevel(MinimapBlip inBlip); // 0x00000001810B22F0-0x00000001810B23B0
	public int GetPlayerMinimapLevel(); // 0x00000001810B2A60-0x00000001810B2B30
	private int GetMapIndex(float inBlipY); // 0x00000001810B27B0-0x00000001810B28E0
	public string GetRoomName(); // 0x00000001810B2D80-0x00000001810B2E10
	private Quaternion GetEdgeOfMapRotation(Vector3 inPosition); // 0x00000001810B2680-0x00000001810B27B0
	public void UpdateMinimap(bool inExpandedMap, RectTransform inMapPanel, RectTransform inMapContainer, RectTransform inMapRotator, Transform inMapNorth, Transform inRotationReference, ERotationType inRotationType, Transform inPlayerTransform); // 0x00000001810B6F20-0x00000001810B7630
	public Transform GetPlayerTransform(); // 0x00000001810B2B30-0x00000001810B2BD0
	public Transform GetRotationReference(); // 0x00000001810B2E10-0x00000001810B2EB0
	public static Vector3 MinimapRotationOffset(Transform inTransform, Vector3 inPosition); // 0x00000001810B3C00-0x00000001810B3D80
	public static Vector3 KeepInRectBounds(RectTransform inRect, Vector3 inPosition, out bool outOfBounds); // 0x00000001810B2F50-0x00000001810B3140
	public static Vector3 GetPositionOffset(Transform inTransform, Transform inOtherTransform); // 0x00000001810B2BD0-0x00000001810B2CD0
	public static Vector3 GetPositionOffset(Vector3 inPosition, Vector3 inOtherPosition); // 0x00000001810B2CD0-0x00000001810B2D80
	public static bool IsVisibleOnScreen(Vector3 inScreenPosition); // 0x00000001810B2EB0-0x00000001810B2F50
	public static float GetDistance(Transform inBlipTransform, Transform inPlayerTransform); // 0x00000001810B2560-0x00000001810B2680
	public static float GetBlipRadius(RectTransform inRectTransform); // 0x00000001810B23B0-0x00000001810B2560
	public void ZoomIn(); // 0x00000001810B7630-0x00000001810B7680
	public void ZoomOut(); // 0x00000001810B7680-0x00000001810B76D0
	public void ExpandMinimap(); // 0x00000001810B2240-0x00000001810B22F0
	private void ClampZoom(); // 0x00000001810B19A0-0x00000001810B1B90
	public void Add(MinimapBlip inMinimapBlip); // 0x00000001810B1830-0x00000001810B19A0
	public void Remove(MinimapBlip inMinimapBlip); // 0x00000001810B4010-0x00000001810B4070
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <LoadMinimapViaBundlePath>b__109_1(GameObject gLoaded); // 0x00000001810B4530-0x00000001810B4640
}

