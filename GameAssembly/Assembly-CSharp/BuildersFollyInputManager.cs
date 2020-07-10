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

public class BuildersFollyInputManager : MonoBehaviour // TypeDefIndex: 12809
{
	// Fields
	private BuildersFollyGame _game; // 0x20
	public Camera gameCamera; // 0x28
	public float minMoveDistance; // 0x30
	public float pulseTileTime; // 0x34
	public float clearTileTime; // 0x38
	public float holdTime; // 0x3C
	public GraphicRaycaster raycaster; // 0x40
	internal float minSnapWidth; // 0x48
	internal ETileMode tileMode; // 0x4C
	private int _fastX; // 0x50
	private int _fastZ; // 0x54
	private int tmp; // 0x58
	private int _gridXspot; // 0x5C
	private int _gridZspot; // 0x60
	private bool _overGrid; // 0x64
	private bool _pathMaking; // 0x65
	private float _gridPosZ_row; // 0x68
	private float _gridPosX_col; // 0x6C
	private Vector3 _lastPosition; // 0x70
	private Vector3 _dropPoint; // 0x7C
	private Vector3 _dragPoint; // 0x88
	private List<RaycastResult> _UIClickResults; // 0x98
	private PointerEventData _pointerEventData; // 0xA0
	private Plane _intersectPlane; // 0xA8
	private Ray _dragRay; // 0xB8
	private BuildersFollyTileManager _tileManager; // 0xD0
	private BuildersFollyGridManager _gridManager; // 0xD8
	private BuildersFollyUIManager _uiManager; // 0xE0
	private BuildersFollyTile _lastTileUnderMouse; // 0xE8
	internal BuildersFollyTile tileUnderMouse; // 0xF0
	internal BuildersFollyData.ETileTypes _draggedTileType; // 0xF8
	internal BuildersFollyTile selectedTile; // 0x100
	private bool _dragging; // 0x108
	private int _pathDeleteTileIndex; // 0x10C
	private BuildersFollyData.ETileTypes stationButtonTileType; // 0x110

	// Properties
	internal ETileMode TileMode { set; } // 0x00000001804D0B70-0x00000001804D0B80
	internal BuildersFollyTile LastTileUnderMouse { set; } // 0x000000018037AA30-0x000000018037AA40
	internal BuildersFollyData.ETileTypes DraggedTileType { get; set; } // 0x0000000180E36630-0x0000000180E36640 0x0000000180E3A060-0x0000000180E3A070
	internal BuildersFollyTile SelectedTile { set; } // 0x00000001814EA5A0-0x00000001814EA620
	private bool Dragging { set; } // 0x00000001814EA590-0x00000001814EA5A0

	// Nested types
	internal enum ETileMode // TypeDefIndex: 12810
	{
		Drag = 0,
		Path = 1,
		Straight = 2,
		Corner = 3
	}

	internal enum EDir // TypeDefIndex: 12811
	{
		Left = 0,
		Right = 1,
		Above = 2,
		Below = 3,
		None = 4
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <HoldChq>d__60 : IEnumerator<object> // TypeDefIndex: 12812
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public BuildersFollyInputManager <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <HoldChq>d__60(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001814ED160-0x00000001814ED310
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001814ED310-0x00000001814ED360
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12813
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action <>9__64_1; // 0x08
		public static Action <>9__71_0; // 0x10

		// Constructors
		static <>c(); // 0x00000001814EF160-0x00000001814EF1C0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <ClearClicked>b__64_1(); // 0x00000001814EEF90-0x00000001814EEFA0
		internal void <ValidPathChq>b__71_0(); // 0x00000001814EEF90-0x00000001814EEFA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <NotValid>d__72 : IEnumerator<object> // TypeDefIndex: 12814
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public BuildersFollyTile inTile; // 0x20
		public BuildersFollyInputManager <>4__this; // 0x28
		private Vector3 <startScale>5__2; // 0x30
		private Vector3 <endScale>5__3; // 0x3C
		private Vector3 <startPos>5__4; // 0x48
		private Vector3 <endPos>5__5; // 0x54
		private float <halfTime>5__6; // 0x60
		private float <t>5__7; // 0x64

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <NotValid>d__72(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001814ED360-0x00000001814ED9C0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001814ED9C0-0x00000001814EDA10
	}

	// Constructors
	public BuildersFollyInputManager(); // 0x00000001814EA500-0x00000001814EA590

	// Methods
	private void Start(); // 0x00000001814E94D0-0x00000001814E9640
	private void Update(); // 0x00000001814E9850-0x00000001814E9D10
	private void SetHighlight(BuildersFollyData.ETileTypes inTileType); // 0x00000001814E8FF0-0x00000001814E94D0
	private void MouseOver(); // 0x00000001814E64B0-0x00000001814E66F0
	private void ResetTrackedFields(); // 0x00000001814E8970-0x00000001814E89A0
	private void MouseUp(); // 0x00000001814E66F0-0x00000001814E75E0
	private bool IsConnectedRight(); // 0x00000001814E2F80-0x00000001814E3460
	private bool AutoConnectEnd(); // 0x00000001814DD830-0x00000001814DE3D0
	private BuildersFollyTile GetPotentialTile(BuildersFollyTile inTileToExclude = null); // 0x00000001814E24C0-0x00000001814E2C00
	private bool AutoConnectStart(BuildersFollyTile inTileToExclude = null); // 0x00000001814DE3D0-0x00000001814DE8D0
	private void MouseDown(); // 0x00000001814E3F20-0x00000001814E64B0
	private void SwitchToPathMode(); // 0x00000001814E9640-0x00000001814E9670
	[IteratorStateMachine] // 0x0000000180128D60-0x0000000180128DB0
	private IEnumerator HoldChq(); // 0x00000001814E2F20-0x00000001814E2F80
	private bool CanConnectToExistingPath(BuildersFollyTile inTile); // 0x00000001814DE8D0-0x00000001814DECA0
	private bool PathPointIsConnectedToStation(Transform inTrans, BuildersFollyStationTile inStationTile); // 0x00000001814E79A0-0x00000001814E7E70
	private void FindConnectedPath(BuildersFollyTile inTile, ref List<BuildersFollyTile> refTiles); // 0x00000001814E1C50-0x00000001814E24C0
	private void ClearClicked(); // 0x00000001814DECA0-0x00000001814DF1C0
	internal void ResetInput(); // 0x00000001814E8920-0x00000001814E8970
	private void DragTile(); // 0x00000001814E13B0-0x00000001814E1A30
	private void DragPathMakeTileChq(); // 0x00000001814DF1C0-0x00000001814E13B0
	private bool OtherPossibleConnection(); // 0x00000001814E7650-0x00000001814E79A0
	private bool AtValidStationConnectionPoint(BuildersFollyTile inStationTile, Vector3 inPathPoint, float inAdjustment = 1f /* Metadata: 0x00783209 */); // 0x00000001814DD330-0x00000001814DD830
	internal void TilePathChq(); // 0x00000001814E9670-0x00000001814E9820
	private bool ValidPathChq(BuildersFollyTile inPathTile, BuildersFollyTile inStationTile, bool inForceInvalid = false /* Metadata: 0x0078320D */); // 0x00000001814E9D10-0x00000001814EA500
	[IteratorStateMachine] // 0x0000000180128FB0-0x0000000180129000
	private IEnumerator NotValid(BuildersFollyTile inTile); // 0x00000001814E75E0-0x00000001814E7650
	private void FillInPaths(); // 0x00000001814E1A30-0x00000001814E1C50
	private void MakePathTile_Tool(); // 0x00000001814E39D0-0x00000001814E3CC0
	private void MakePathAndReplace(); // 0x00000001814E3460-0x00000001814E39D0
	private void SetClosestGridSpotWhenSelected(BuildersFollyTile inTile); // 0x00000001814E89A0-0x00000001814E8B10
	private void ReplacePath(BuildersFollyData.ETileTypes inTileType, int inRotationTimes); // 0x00000001814E7E70-0x00000001814E8920
	private BuildersFollyTile MakePathTile(BuildersFollyData.ETileTypes inTileType); // 0x00000001814E3CC0-0x00000001814E3F20
	private EDir GetTileDir(BuildersFollyGridSpot inSpot, BuildersFollyGridSpot inPreviousSpot); // 0x00000001814E2C00-0x00000001814E2C50
	private void SetDragPoint(); // 0x00000001814E8B10-0x00000001814E8BE0
	private void SetDropPoint(BuildersFollyGridSpot[,] inGridPositions); // 0x00000001814E8BE0-0x00000001814E8FF0
	internal BuildersFollyTile GetTileUnderMouse(); // 0x00000001814E2C50-0x00000001814E2F20
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <ClearClicked>b__64_0(); // 0x00000001814E9820-0x00000001814E9850
}

