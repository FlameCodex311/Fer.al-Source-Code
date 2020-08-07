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

public class BuildersFollyInputManager : MonoBehaviour // TypeDefIndex: 10467
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
	internal ETileMode TileMode { set; } // 0x0000000180A8E080-0x0000000180A8E090
	internal BuildersFollyTile LastTileUnderMouse { set; } // 0x00000001804296B0-0x00000001804296C0
	internal BuildersFollyData.ETileTypes DraggedTileType { get; set; } // 0x0000000180D11D30-0x0000000180D11D40 0x0000000180D11DB0-0x0000000180D11DC0
	internal BuildersFollyTile SelectedTile { set; } // 0x000000018214A190-0x000000018214A210
	private bool Dragging { set; } // 0x000000018214A180-0x000000018214A190

	// Nested types
	internal enum ETileMode // TypeDefIndex: 10468
	{
		Drag = 0,
		Path = 1,
		Straight = 2,
		Corner = 3
	}

	internal enum EDir // TypeDefIndex: 10469
	{
		Left = 0,
		Right = 1,
		Above = 2,
		Below = 3,
		None = 4
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <HoldChq>d__60 : IEnumerator<object> // TypeDefIndex: 10470
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public BuildersFollyInputManager <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <HoldChq>d__60(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180ACA1A0-0x0000000180ACA390
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180ACA390-0x0000000180ACA3E0
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 10471
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action <>9__64_1; // 0x08
		public static Action <>9__71_0; // 0x10

		// Constructors
		static <>c(); // 0x0000000180ACC580-0x0000000180ACC5E0
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <ClearClicked>b__64_1(); // 0x0000000180ACC540-0x0000000180ACC550
		internal void <ValidPathChq>b__71_0(); // 0x0000000180ACC540-0x0000000180ACC550
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <NotValid>d__72 : IEnumerator<object> // TypeDefIndex: 10472
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <NotValid>d__72(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180ACA3E0-0x0000000180ACAA30
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180ACAA30-0x0000000180ACAA80
	}

	// Constructors
	public BuildersFollyInputManager(); // 0x000000018214A0F0-0x000000018214A180

	// Methods
	private void Start(); // 0x0000000182149180-0x00000001821492F0
	private void Update(); // 0x00000001821494F0-0x0000000182149990
	private void SetHighlight(BuildersFollyData.ETileTypes inTileType); // 0x0000000182148CD0-0x0000000182149180
	private void MouseOver(); // 0x0000000182146300-0x0000000182146540
	private void ResetTrackedFields(); // 0x0000000182148680-0x00000001821486B0
	private void MouseUp(); // 0x0000000182146540-0x00000001821473C0
	private bool IsConnectedRight(); // 0x0000000182142F90-0x0000000182143430
	private bool AutoConnectEnd(); // 0x000000018213DB70-0x000000018213E6A0
	private BuildersFollyTile GetPotentialTile(BuildersFollyTile inTileToExclude = null); // 0x0000000182142520-0x0000000182142C20
	private bool AutoConnectStart(BuildersFollyTile inTileToExclude = null); // 0x000000018213E6A0-0x000000018213EB70
	private void MouseDown(); // 0x0000000182143EA0-0x0000000182146300
	private void SwitchToPathMode(); // 0x00000001821492F0-0x0000000182149320
	[IteratorStateMachine] // 0x00000001801FD810-0x00000001801FD860
	private IEnumerator HoldChq(); // 0x0000000182142F20-0x0000000182142F90
	private bool CanConnectToExistingPath(BuildersFollyTile inTile); // 0x000000018213EB70-0x000000018213EF10
	private bool PathPointIsConnectedToStation(Transform inTrans, BuildersFollyStationTile inStationTile); // 0x0000000182147770-0x0000000182147BF0
	private void FindConnectedPath(BuildersFollyTile inTile, ref List<BuildersFollyTile> refTiles); // 0x0000000182141D30-0x0000000182142520
	private void ClearClicked(); // 0x000000018213EF10-0x000000018213F440
	internal void ResetInput(); // 0x0000000182148630-0x0000000182148680
	private void DragTile(); // 0x00000001821414F0-0x0000000182141B30
	private void DragPathMakeTileChq(); // 0x000000018213F440-0x00000001821414F0
	private bool OtherPossibleConnection(); // 0x0000000182147440-0x0000000182147770
	private bool AtValidStationConnectionPoint(BuildersFollyTile inStationTile, Vector3 inPathPoint, float inAdjustment = 1f /* Metadata: 0x0077BCB4 */); // 0x000000018213D6B0-0x000000018213DB70
	internal void TilePathChq(); // 0x0000000182149320-0x00000001821494C0
	private bool ValidPathChq(BuildersFollyTile inPathTile, BuildersFollyTile inStationTile, bool inForceInvalid = false /* Metadata: 0x0077BCB8 */); // 0x0000000182149990-0x000000018214A0F0
	[IteratorStateMachine] // 0x00000001801FDC30-0x00000001801FDC80
	private IEnumerator NotValid(BuildersFollyTile inTile); // 0x00000001821473C0-0x0000000182147440
	private void FillInPaths(); // 0x0000000182141B30-0x0000000182141D30
	private void MakePathTile_Tool(); // 0x0000000182143970-0x0000000182143C50
	private void MakePathAndReplace(); // 0x0000000182143430-0x0000000182143970
	private void SetClosestGridSpotWhenSelected(BuildersFollyTile inTile); // 0x00000001821486B0-0x0000000182148800
	private void ReplacePath(BuildersFollyData.ETileTypes inTileType, int inRotationTimes); // 0x0000000182147BF0-0x0000000182148630
	private BuildersFollyTile MakePathTile(BuildersFollyData.ETileTypes inTileType); // 0x0000000182143C50-0x0000000182143EA0
	private EDir GetTileDir(BuildersFollyGridSpot inSpot, BuildersFollyGridSpot inPreviousSpot); // 0x0000000182142C20-0x0000000182142C70
	private void SetDragPoint(); // 0x0000000182148800-0x00000001821488D0
	private void SetDropPoint(BuildersFollyGridSpot[,] inGridPositions); // 0x00000001821488D0-0x0000000182148CD0
	internal BuildersFollyTile GetTileUnderMouse(); // 0x0000000182142C70-0x0000000182142F20
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <ClearClicked>b__64_0(); // 0x00000001821494C0-0x00000001821494F0
}

