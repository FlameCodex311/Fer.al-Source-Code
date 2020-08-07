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

public class MinimapManager : SingletonManagerBase<MinimapManager> // TypeDefIndex: 12240
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private ERotationType _rotationType; // 0x60
	[RootSelector] // 0x000000018025A1E0-0x000000018025A240
	public string blipCityFera; // 0x68
	[RootSelector] // 0x000000018025A360-0x000000018025A3C0
	public string blipClothing; // 0x70
	[RootSelector] // 0x000000018025A560-0x000000018025A5C0
	public string blipDye; // 0x78
	[RootSelector] // 0x000000018025A6F0-0x000000018025A750
	public string blipExpanse; // 0x80
	[RootSelector] // 0x000000018025A8E0-0x000000018025A940
	public string blipHarvestPoint; // 0x88
	[RootSelector] // 0x000000018025BD60-0x000000018025BDC0
	public string blipMainQuest; // 0x90
	[RootSelector] // 0x000000018025BF60-0x000000018025BFC0
	public string blipQuestGiver; // 0x98
	[RootSelector] // 0x000000018025C170-0x000000018025C1D0
	public string blipParlorGame; // 0xA0
	[RootSelector] // 0x000000018025C2D0-0x000000018025C330
	public string blipPlayer; // 0xA8
	[RootSelector] // 0x000000018025C510-0x000000018025C570
	public string blipFriend; // 0xB0
	[RootSelector] // 0x000000018025C630-0x000000018025C690
	public string blipNetworkPlayer; // 0xB8
	[RootSelector] // 0x000000018025C870-0x000000018025C8D0
	public string blipPortal; // 0xC0
	[RootSelector] // 0x000000018025C950-0x000000018025C9B0
	public string blipSideQuest; // 0xC8
	[RootSelector] // 0x000000018025CA00-0x000000018025CA60
	public string blipSpecificLocation; // 0xD0
	[RootSelector] // 0x000000018025CB40-0x000000018025CBA0
	public string blipTradingPost; // 0xD8
	[RootSelector] // 0x000000018025CC50-0x000000018025CCB0
	public string blipTreasureChest; // 0xE0
	[RootSelector] // 0x000000018025CE70-0x000000018025CED0
	public string blipUnitOfCinder; // 0xE8
	[RootSelector] // 0x000000018025D060-0x000000018025D0C0
	public string blipNpc; // 0xF0
	[RootSelector] // 0x000000018025D1C0-0x000000018025D220
	public string blipArea; // 0xF8
	[RootSelector] // 0x000000018025D420-0x000000018025D480
	public string blipBlackMarket; // 0x100
	[RootSelector] // 0x000000018025D4E0-0x000000018025D540
	public string blipLounge; // 0x108
	[RootSelector] // 0x000000018025D630-0x000000018025D690
	public string blipSunkenThicket; // 0x110
	[RootSelector] // 0x000000018025D7E0-0x000000018025D840
	public string blipUncrafting; // 0x118
	[RootSelector] // 0x000000018025D8A0-0x000000018025D900
	public string blipFurniture; // 0x120
	[RootSelector] // 0x000000018025D9D0-0x000000018025DA30
	public string blipCasualGame; // 0x128
	[RootSelector] // 0x000000018025DAA0-0x000000018025DB00
	public string blipDailyQuest; // 0x130
	[RootSelector] // 0x000000018025DCE0-0x000000018025DD40
	public string blipDailyQuestGiver; // 0x138
	public bool useNavMeshForMainQuest; // 0x140
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralAudioInfo _audioZoomIn; // 0x148
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralAudioInfo _audioZoomOut; // 0x150
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralAudioInfo _audioMap; // 0x158
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Material _minimapMaterial; // 0x160
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _colorFollowFavorite; // 0x168
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _colorFollow; // 0x178
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _colorNetworkPlayer; // 0x188
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _tooltipsOnBlips; // 0x198
	private GameObject _minimapCloned; // 0x1A0
	private float _screenWidth; // 0x1A8
	private float _screenHeight; // 0x1AC
	private float _screenMin; // 0x1B0
	private Vector3 _screenCenter; // 0x1B4
	public List<MinimapBlip> minimapBlips; // 0x1C0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private MinimapMap <minimapMap>k__BackingField; // 0x1C8
	private bool _showMap; // 0x1D0
	public MinimapDetails minimap; // 0x1D8
	public MinimapDetails minimapExpanded; // 0x1E0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _displayOffscreenRotationNudge; // 0x1E8
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private MinimapBlip <playerBlip>k__BackingField; // 0x1F0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private string <sceneName>k__BackingField; // 0x1F8
	private WeatherState? _lastWeatherState; // 0x200
	private string _weatherString; // 0x208
	public List<BlipPriorityParent> _priorityTransforms; // 0x210
	public List<BlipPriorityParent> _priorityTransformsExpanded; // 0x218

	// Properties
	public ERotationType rotationType { get; } // 0x00000001804ADA80-0x00000001804ADA90 
	public Color colorFollowFavorite { get; } // 0x0000000180C06F20-0x0000000180C06F30 
	public Color colorFollow { get; } // 0x0000000180C06F30-0x0000000180C06F40 
	public Color colorNetworkPlayer { get; } // 0x0000000180C06F40-0x0000000180C06F50 
	public bool tooltipsOnBlips { get; } // 0x0000000180C07750-0x0000000180C07760 
	public Material minimapMaterial { get; } // 0x00000001803EF190-0x00000001803EF1A0 
	private Vector3 screenCenter { get; } // 0x0000000180C07650-0x0000000180C07750 
	public MinimapMap minimapMap { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180C07570-0x0000000180C07580 0x0000000180C078E0-0x0000000180C078F0
	public float mapScale { get; } // 0x0000000180C07330-0x0000000180C073F0 
	public float blipAreaScale { get; } // 0x0000000180C06DA0-0x0000000180C06E60 
	public float blipScale { get; } // 0x0000000180C06E60-0x0000000180C06F20 
	public float indicatorScale { get; } // 0x0000000180C07310-0x0000000180C07330 
	public float indicatorEdgeBuffer { get; } // 0x0000000180C072F0-0x0000000180C07310 
	public float radius { get; } // 0x0000000180C07590-0x0000000180C07650 
	public float zoom { get; set; } // 0x0000000180C07820-0x0000000180C078E0 0x0000000180C07900-0x0000000180C079D0
	public float minZoom { get; } // 0x0000000180C074B0-0x0000000180C07570 
	public float maxZoom { get; } // 0x0000000180C073F0-0x0000000180C074B0 
	public float zoomAmount { get; } // 0x0000000180C07760-0x0000000180C07820 
	public MinimapBlip playerBlip { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180C07580-0x0000000180C07590 0x0000000180C078F0-0x0000000180C07900
	public string sceneName { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001805CB4A0-0x00000001805CB4B0 0x000000018046D2C0-0x000000018046D2D0
	public string currentTime { get; } // 0x0000000180C06F50-0x0000000180C06FD0 
	public string currentWeather { get; } // 0x0000000180C06FD0-0x0000000180C072F0 

	// Nested types
	public enum ERotationType // TypeDefIndex: 12241
	{
		RotateMap = 0,
		RotatePlayer = 1
	}

	public enum EBlipType // TypeDefIndex: 12242
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
		DailyQuestGiver = 27,
		SpawnPoint = 28
	}

	[Serializable]
	public class MinimapDetails // TypeDefIndex: 12243
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
		public MinimapDetails(); // 0x0000000180C00CA0-0x0000000180C00CF0
	}

	public class BlipPriorityParent // TypeDefIndex: 12244
	{
		// Fields
		public int priority; // 0x10
		public RectTransform rectTransform; // 0x18

		// Constructors
		public BlipPriorityParent(); // 0x00000001805FC900-0x00000001805FC910
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 12245
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action <>9__109_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180C174E0-0x0000000180C17540
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <LoadMinimapViaBundlePath>b__109_0(); // 0x0000000180C17350-0x0000000180C173A0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass110_0 // TypeDefIndex: 12246
	{
		// Fields
		public Action<MinimapBlipData> Callback; // 0x10

		// Constructors
		public <>c__DisplayClass110_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <GetMinimapBlipData>b__0(MinimapBlipData cb); // 0x0000000180C173A0-0x0000000180C173F0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass111_0 // TypeDefIndex: 12247
	{
		// Fields
		public MinimapBlipData cMinimapBlipData; // 0x10

		// Constructors
		public <>c__DisplayClass111_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <GetMinimapBlipDataRoutine>b__0(MinimapBlipData loadedAsset); // 0x0000000180379F20-0x0000000180379F30
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <GetMinimapBlipDataRoutine>d__111 : IEnumerator<object> // TypeDefIndex: 12248
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public MinimapBlip inMinimapBlip; // 0x20
		public MinimapManager <>4__this; // 0x28
		public Action<MinimapBlipData> Callback; // 0x30
		private <>c__DisplayClass111_0 <>8__1; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <GetMinimapBlipDataRoutine>d__111(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180C13AE0-0x0000000180C140C0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180C140C0-0x0000000180C14110
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass142_0 // TypeDefIndex: 12249
	{
		// Fields
		public MinimapBlip inMinimapBlip; // 0x10
		public MinimapManager <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass142_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <Add>b__0(MinimapBlipData cb); // 0x0000000180C173F0-0x0000000180C17470
	}

	// Constructors
	public MinimapManager(); // 0x0000000180C06A20-0x0000000180C06DA0

	// Methods
	public override void MStart(); // 0x0000000180C02EF0-0x0000000180C03050
	public override void MOnDestroy(); // 0x0000000180C02D90-0x0000000180C02EF0
	private void OnLevelLoaded(Message inMessage); // 0x0000000180C03230-0x0000000180C03440
	private void OnLoadingStarted(Message inMessage); // 0x0000000180C03440-0x0000000180C03450
	private void OnLoadingFinished(Message inMessage); // 0x00000001803774A0-0x00000001803774B0
	private void OnHideHUDCommand(HideHUDCommand inCommand); // 0x0000000180C031D0-0x0000000180C03230
	public void LoadMinimapViaBundlePath(string inBundleIdDefId, bool inCloseMinimapWindow = true /* Metadata: 0x007B964F */); // 0x0000000180C02A20-0x0000000180C02D90
	public void GetMinimapBlipData(MinimapBlip inMinimapBlip, Action<MinimapBlipData> Callback); // 0x0000000180C01DE0-0x0000000180C01EE0
	[IteratorStateMachine] // 0x000000018025F4A0-0x000000018025F4F0
	private IEnumerator GetMinimapBlipDataRoutine(MinimapBlip inMinimapBlip, Action<MinimapBlipData> Callback); // 0x0000000180C01D60-0x0000000180C01DE0
	private void LateUpdate(); // 0x0000000180C025B0-0x0000000180C02A20
	private BlipPriorityParent CreateTransformParent(RectTransform inParent, bool inExpandedMap, int inPriority, bool inMasked, out bool oAdded); // 0x0000000180C012A0-0x0000000180C016F0
	private void ClearNulls(bool inExpandedMap); // 0x0000000180C01050-0x0000000180C012A0
	public void UpdateElements(bool inExpandedMap, RectTransform inMapContainer, RectTransform inElementContainerMasked, RectTransform inIndicatorContainer, GameObject inBlipPrefab, GameObject inIndicatorPrefab, ERotationType inRotationType); // 0x0000000180C04C10-0x0000000180C05BB0
	private int SortPriority(BlipPriorityParent inTA, BlipPriorityParent inTB); // 0x0000000180C034B0-0x0000000180C034D0
	private void SortPriority(bool inExpandedMap); // 0x0000000180C034D0-0x0000000180C03960
	private void UpdateIndicator(RectTransform inIndicatorContainer, MinimapBlip inBlip, Vector3 inScreenPosition, float inDistance, Transform inPlayer); // 0x0000000180C05BB0-0x0000000180C06290
	private void UpdateBlip(bool inExpandedMap, RectTransform inMapContainer, RectTransform inElementContainer, ERotationType inRotationType, MinimapBlip inBlip, Vector3 inScreenPosition, float inDistance, Transform inPlayer); // 0x0000000180C03A70-0x0000000180C04C10
	public int GetBlipMinimapLevel(MinimapBlip inBlip); // 0x0000000180C017A0-0x0000000180C01860
	public int GetPlayerMinimapLevel(); // 0x0000000180C01EE0-0x0000000180C01FA0
	private int GetMapIndex(float inBlipY); // 0x0000000180C01C50-0x0000000180C01D60
	public string GetRoomName(); // 0x0000000180C021F0-0x0000000180C02280
	private Quaternion GetEdgeOfMapRotation(Vector3 inPosition); // 0x0000000180C01B20-0x0000000180C01C50
	public void UpdateMinimap(bool inExpandedMap, RectTransform inMapPanel, RectTransform inMapContainer, RectTransform inMapRotator, Transform inMapNorth, Transform inRotationReference, ERotationType inRotationType, Transform inPlayerTransform); // 0x0000000180C06290-0x0000000180C06980
	public Transform GetPlayerTransform(); // 0x0000000180C01FA0-0x0000000180C02040
	public Transform GetRotationReference(); // 0x0000000180C02280-0x0000000180C02320
	public static Vector3 MinimapRotationOffset(Transform inTransform, Vector3 inPosition); // 0x0000000180C03050-0x0000000180C031D0
	public static Vector3 KeepInRectBounds(RectTransform inRect, Vector3 inPosition, out bool outOfBounds); // 0x0000000180C023C0-0x0000000180C025B0
	public static Vector3 GetPositionOffset(Transform inTransform, Transform inOtherTransform); // 0x0000000180C02040-0x0000000180C02140
	public static Vector3 GetPositionOffset(Vector3 inPosition, Vector3 inOtherPosition); // 0x0000000180C02140-0x0000000180C021F0
	public static bool IsVisibleOnScreen(Vector3 inScreenPosition); // 0x0000000180C02320-0x0000000180C023C0
	public static float GetDistance(Transform inBlipTransform, Transform inPlayerTransform); // 0x0000000180C01A00-0x0000000180C01B20
	public static float GetBlipRadius(RectTransform inRectTransform); // 0x0000000180C01860-0x0000000180C01A00
	public void ZoomIn(); // 0x0000000180C06980-0x0000000180C069D0
	public void ZoomOut(); // 0x0000000180C069D0-0x0000000180C06A20
	public void ExpandMinimap(); // 0x0000000180C016F0-0x0000000180C017A0
	private void ClampZoom(); // 0x0000000180C00E60-0x0000000180C01050
	public void Add(MinimapBlip inMinimapBlip); // 0x0000000180C00CF0-0x0000000180C00E60
	public void Remove(MinimapBlip inMinimapBlip); // 0x0000000180C03450-0x0000000180C034B0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <LoadMinimapViaBundlePath>b__109_1(GameObject gLoaded); // 0x0000000180C03960-0x0000000180C03A70
}

