/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using World_Challenge.Casual_Game;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace World_Challenge.Casual_Game.Terra_Farming
{
	public class TerraFarming : CasualGame // TypeDefIndex: 14781
	{
		// Fields
		[Header] // 0x0000000180202930-0x0000000180202990
		[Header] // 0x0000000180202930-0x0000000180202990
		public CanvasGroup uiCanvasGroup; // 0x78
		public UnityEngine.UI.Text totalScoreText; // 0x80
		public UnityEngine.UI.Text colorsMatchedMultiplyerText; // 0x88
		public Texture collectorImage; // 0x90
		public Texture[] elementImages; // 0x98
		public Color[] elementColors; // 0xA0
		public UnityEngine.UI.Text[] turnScoreTexts; // 0xA8
		public UnityEngine.UI.Text[] collectorTexts; // 0xB0
		public UnityEngine.UI.Text[] progressTexts; // 0xB8
		public RawImage[] uiImages; // 0xC0
		public Image[] fillImages; // 0xC8
		public GameObject[] collectorEarnedImages; // 0xD0
		[Header] // 0x0000000180202DA0-0x0000000180202DD0
		public float blockGroupInSpeed; // 0xD8
		public Transform[] blockGroupStarts; // 0xE0
		public Transform[] blockGroupEnds; // 0xE8
		[Header] // 0x0000000180202F10-0x0000000180202F70
		[Tooltip] // 0x0000000180202F10-0x0000000180202F70
		public float turnScoreShowTime; // 0xF0
		public int[] scoreThreshholds; // 0xF8
		[Header] // 0x00000001801CF440-0x00000001801CF470
		public ParticleSystem[] fXBlockToScore; // 0x100
		public ParticleSystem[] fXScoreBurst; // 0x108
		public ParticleSystem[] fXCollectorEarned; // 0x110
		public ParticleSystem[] fXBlockLinked; // 0x118
		public ParticleSystem[] fXBlockCollected; // 0x120
		[Header] // 0x0000000180203500-0x0000000180203530
		public float blockPulseScaler; // 0x128
		public float blockPulseTime; // 0x12C
		public float pulseDelay; // 0x130
		public float blockToCollectorTime; // 0x134
		[Tooltip] // 0x00000001802037B0-0x00000001802037E0
		public float minMoveDist; // 0x138
		[Tooltip] // 0x0000000180203A60-0x0000000180203A90
		public float moveMaxX; // 0x13C
		[Tooltip] // 0x0000000180203A60-0x0000000180203A90
		public float moveMaxZ; // 0x140
		[Tooltip] // 0x00000001802051D0-0x0000000180205200
		public float selectedBlockYoffset; // 0x144
		[Tooltip] // 0x0000000180205440-0x0000000180205470
		public float placeBlockGroupTime; // 0x148
		[Tooltip] // 0x0000000180205670-0x00000001802056A0
		public float minBlockDistanceScaler; // 0x14C
		[Tooltip] // 0x0000000180205860-0x0000000180205890
		public float colorToggleSpeed; // 0x150
		internal TerrafarmingGrid grid; // 0x158
		private float _distanceToTouchPlane; // 0x160
		private float _minBlockDist; // 0x164
		private int[] _scoreThreshholdIndexes; // 0x168
		private int[] _scores; // 0x170
		private int _numColorsMatched; // 0x178
		private int[] _turnScores; // 0x180
		private bool _collecting; // 0x188
		private int _totalScore; // 0x18C
		private int _nextToGridSideIndex; // 0x190
		private int _nextToDroppedSideIndex; // 0x194
		private Vector3 _selectionOffset; // 0x198
		private Vector3 _selectedPos; // 0x1A4
		private Vector3 _lastPos; // 0x1B0
		private Vector3 _mousePos; // 0x1BC
		private Vector3 _pointAlongPlane; // 0x1C8
		private Ray _mouseScreenPointToRay; // 0x1D4
		private Plane _touchPlane; // 0x1EC
		private TerrafarmingBlockGroup _selectedBlockGroup; // 0x200
		private Transform[] _draggableBlockGroupTransforms; // 0x208
		private TerrafarmingBlockGroup[] _draggableBlockGroups; // 0x210
		private List<TerrafarmingGridGroup> _gridBlockGroups; // 0x218
		private List<int> _gatherBlocksEarned; // 0x220
		private List<TerrafarmingBlockGroup> _blockGroupsForSpawning; // 0x228
		public Queue<RuneType> queuedCycloneTiles; // 0x230
	
		// Nested types
		private struct TerrafarmingGridGroup // TypeDefIndex: 14782
		{
			// Fields
			internal int gridGroupColorIndex; // 0x00
			internal List<TerrafarmingBlock> groupBlocks; // 0x08
	
			// Constructors
			public TerrafarmingGridGroup(int inColorIndex, TerrafarmingBlock inBlock); // 0x00000001800A43B0-0x00000001800A44E0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <FadeInUI>d__62 : IEnumerator<object> // TypeDefIndex: 14783
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public TerraFarming <>4__this; // 0x20
			private float <t>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <FadeInUI>d__62(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180E7B560-0x0000000180E7B640
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E7B640-0x0000000180E7B690
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <MoveBlockGroupToSelectionPoint>d__65 : IEnumerator<object> // TypeDefIndex: 14784
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public TerraFarming <>4__this; // 0x20
			public int inIndex; // 0x28
			public bool inDoGameOverCheck; // 0x2C
			private Vector3 <startPos>5__2; // 0x30
			private float <t>5__3; // 0x3C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <MoveBlockGroupToSelectionPoint>d__65(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180E7D290-0x0000000180E7D6A0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E7D6A0-0x0000000180E7D6F0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <BlockGroupOut>d__66 : IEnumerator<object> // TypeDefIndex: 14785
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public TerraFarming <>4__this; // 0x20
			public int inIndex; // 0x28
			private Vector3 <startPos>5__2; // 0x2C
			private float <t>5__3; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <BlockGroupOut>d__66(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180E78EE0-0x0000000180E79230
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E79230-0x0000000180E79280
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <PlaceDropBlockGroup>d__70 : IEnumerator<object> // TypeDefIndex: 14786
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public TerrafarmingBlockGroup inDropBlockGroup; // 0x20
			public TerraFarming <>4__this; // 0x28
			private Vector3 <startPos>5__2; // 0x30
			private Vector3 <endPos>5__3; // 0x3C
			private float <t>5__4; // 0x48
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <PlaceDropBlockGroup>d__70(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180E7DFA0-0x0000000180E7E3B0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E7E3B0-0x0000000180E7E400
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <BlockGroupPlaced>d__75 : IEnumerator<object> // TypeDefIndex: 14787
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public TerraFarming <>4__this; // 0x20
			public TerrafarmingBlockGroup inDropBlockGroup; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <BlockGroupPlaced>d__75(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180E79280-0x0000000180E79AE0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E79AE0-0x0000000180E79B30
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <CollectorPulse>d__79 : IEnumerator<object> // TypeDefIndex: 14788
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public TerrafarmingBlock inCollectorBlock; // 0x20
			public TerraFarming <>4__this; // 0x28
			private Vector3 <startScale>5__2; // 0x30
			private Vector3 <endScale>5__3; // 0x3C
			private float <halfTime>5__4; // 0x48
			private float <td>5__5; // 0x4C
			private float <t>5__6; // 0x50
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <CollectorPulse>d__79(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180E7A680-0x0000000180E7AAC0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E7AAC0-0x0000000180E7AB10
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <StartCollectorPulse>d__80 : IEnumerator<object> // TypeDefIndex: 14789
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public TerrafarmingBlock inDropBlock; // 0x20
			public TerraFarming <>4__this; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <StartCollectorPulse>d__80(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180E828F0-0x0000000180E82F40
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E82F40-0x0000000180E82F90
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowTurnScore>d__84 : IEnumerator<object> // TypeDefIndex: 14790
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public UnityEngine.UI.Text inText; // 0x20
			public TerraFarming <>4__this; // 0x28
			private Color <endColor>5__2; // 0x30
			private Color <startColor>5__3; // 0x40
			private float <halfTime>5__4; // 0x50
			private float <td>5__5; // 0x54
			private float <t>5__6; // 0x58
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowTurnScore>d__84(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180E82090-0x0000000180E822C0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E822C0-0x0000000180E82310
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <PulseCollectorText>d__85 : IEnumerator<object> // TypeDefIndex: 14791
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public UnityEngine.UI.Text inText; // 0x20
			public TerraFarming <>4__this; // 0x28
			private Vector3 <startSize>5__2; // 0x30
			private Vector3 <endSize>5__3; // 0x3C
			private float <halfTime>5__4; // 0x48
			private float <td>5__5; // 0x4C
			private float <t>5__6; // 0x50
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <PulseCollectorText>d__85(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180E7E400-0x0000000180E7E7C0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E7E7C0-0x0000000180E7E810
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <CleanupAndReset>d__89 : IEnumerator<object> // TypeDefIndex: 14792
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public TerraFarming <>4__this; // 0x20
			private int <i>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <CleanupAndReset>d__89(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180E79F20-0x0000000180E7A320
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E7A320-0x0000000180E7A370
		}
	
		// Constructors
		public TerraFarming(); // 0x00000001805DBA70-0x00000001805DBF50
	
		// Methods
		public override void Start(); // 0x00000001805DB150-0x00000001805DB3A0
		private void InitBlockGroups(); // 0x00000001805D91E0-0x00000001805D94E0
		private void ResetUI(); // 0x00000001805DA360-0x00000001805DA800
		[IteratorStateMachine] // 0x0000000180205A70-0x0000000180205AC0
		private IEnumerator FadeInUI(); // 0x00000001805D9170-0x00000001805D91E0
		internal override void Intro(); // 0x00000001805D94E0-0x00000001805D9570
		private void SpawnBlockGroup(int inSpawnIndex, bool inInitial = false /* Metadata: 0x007BAF80 */, int inCollectorColor = -1 /* Metadata: 0x007BAF81 */); // 0x00000001805DACF0-0x00000001805DAF80
		[IteratorStateMachine] // 0x0000000180205C80-0x0000000180205CD0
		private IEnumerator MoveBlockGroupToSelectionPoint(int inIndex, bool inDoGameOverCheck = false /* Metadata: 0x007BAF85 */); // 0x00000001805D9EC0-0x00000001805D9F50
		[IteratorStateMachine] // 0x0000000180205F40-0x0000000180205F90
		private IEnumerator BlockGroupOut(int inIndex); // 0x00000001805D8480-0x00000001805D84F0
		public void Update(); // 0x00000001805DB550-0x00000001805DBA70
		private void CheckGrid(); // 0x00000001805D8AF0-0x00000001805D9080
		internal void BlockGroupSelected(TerrafarmingBlockGroup inBlockGroup = null); // 0x00000001805D8570-0x00000001805D8AF0
		[IteratorStateMachine] // 0x00000001802061D0-0x0000000180206220
		private IEnumerator PlaceDropBlockGroup(TerrafarmingBlockGroup inDropBlockGroup); // 0x00000001805DA1C0-0x00000001805DA240
		private void SetGridBlockColorsFromDropBlock(TerrafarmingBlock inDropBlock); // 0x00000001805DA870-0x00000001805DAA20
		private int AddDropBlockToGridBlockGroup(TerrafarmingBlock inDropBlock); // 0x00000001805D7850-0x00000001805D7B30
		public void UpdateScore(Dictionary<RuneType, int> turnScores, int comboMultiplier, Vector3 dropPosition); // 0x00000001805DB3A0-0x00000001805DB550
		private void AdjustScore(Vector3 inColorsMatchedMultiplierPos); // 0x00000001805D7B30-0x00000001805D8480
		[IteratorStateMachine] // 0x0000000180206510-0x0000000180206560
		private IEnumerator BlockGroupPlaced(TerrafarmingBlockGroup inDropBlockGroup); // 0x00000001805D84F0-0x00000001805D8570
		private void QueueGatherBlock(int colorIndex); // 0x00000001805DA2C0-0x00000001805DA350
		public void OnGatherBlockSpawned(); // 0x00000001805DA0F0-0x00000001805DA1C0
		private void SpawnNext(int inSpawnIndex); // 0x00000001805DAF80-0x00000001805DB0D0
		[IteratorStateMachine] // 0x00000001802066F0-0x0000000180206740
		private IEnumerator CollectorPulse(TerrafarmingBlock inCollectorBlock); // 0x00000001805D90F0-0x00000001805D9170
		[IteratorStateMachine] // 0x0000000180206980-0x00000001802069D0
		private IEnumerator StartCollectorPulse(TerrafarmingBlock inDropBlock); // 0x00000001805DB0D0-0x00000001805DB150
		private void SetPulseIndexes(TerrafarmingBlock inBlock, TerrafarmingGridGroup inTerrafarmingGridGroup); // 0x00000001805DAA20-0x00000001805DAC70
		private bool IsGridBlockEmpty(Vector3 inGridBlockLocation); // 0x00000001805D9B30-0x00000001805D9D10
		private bool IsGameOverCheck(); // 0x00000001805D9570-0x00000001805D9B30
		[IteratorStateMachine] // 0x0000000180206CB0-0x0000000180206D00
		private IEnumerator ShowTurnScore(UnityEngine.UI.Text inText); // 0x00000001805DAC70-0x00000001805DACF0
		[IteratorStateMachine] // 0x0000000180207110-0x0000000180207160
		private IEnumerator PulseCollectorText(UnityEngine.UI.Text inText); // 0x00000001805DA240-0x00000001805DA2C0
		private bool IsNextTo(TerrafarmingBlock inGridBlock, TerrafarmingBlock inDropBlock); // 0x00000001805D9D10-0x00000001805D9EC0
		private bool NextToCheckAndColorSides(TerrafarmingBlock inGridBlock, TerrafarmingBlock inDropBlock); // 0x00000001805D9F50-0x00000001805DA0F0
		internal override void ResultsDone(); // 0x00000001805DA800-0x00000001805DA870
		[IteratorStateMachine] // 0x00000001802074D0-0x0000000180207520
		private IEnumerator CleanupAndReset(); // 0x00000001805D9080-0x00000001805D90F0
		public void ResetGame(); // 0x00000001805DA350-0x00000001805DA360
	}
}
