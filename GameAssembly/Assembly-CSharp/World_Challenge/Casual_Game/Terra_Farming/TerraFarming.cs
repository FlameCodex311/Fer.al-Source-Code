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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace World_Challenge.Casual_Game.Terra_Farming
{
	public class TerraFarming : CasualGame // TypeDefIndex: 15626
	{
		// Fields
		[Header] // 0x0000000180140100-0x0000000180140160
		[Header] // 0x0000000180140100-0x0000000180140160
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
		[Header] // 0x0000000180140220-0x0000000180140250
		public float blockGroupInSpeed; // 0xD8
		public Transform[] blockGroupStarts; // 0xE0
		public Transform[] blockGroupEnds; // 0xE8
		[Header] // 0x0000000180140360-0x00000001801403C0
		[Tooltip] // 0x0000000180140360-0x00000001801403C0
		public float turnScoreShowTime; // 0xF0
		public int[] scoreThreshholds; // 0xF8
		[Header] // 0x00000001800FD010-0x00000001800FD040
		public ParticleSystem[] fXBlockToScore; // 0x100
		public ParticleSystem[] fXScoreBurst; // 0x108
		public ParticleSystem[] fXCollectorEarned; // 0x110
		public ParticleSystem[] fXBlockLinked; // 0x118
		public ParticleSystem[] fXBlockCollected; // 0x120
		[Header] // 0x0000000180140880-0x00000001801408B0
		public float blockPulseScaler; // 0x128
		public float blockPulseTime; // 0x12C
		public float pulseDelay; // 0x130
		public float blockToCollectorTime; // 0x134
		[Tooltip] // 0x0000000180140930-0x0000000180140960
		public float minMoveDist; // 0x138
		[Tooltip] // 0x0000000180140A60-0x0000000180140A90
		public float moveMaxX; // 0x13C
		[Tooltip] // 0x0000000180140A60-0x0000000180140A90
		public float moveMaxZ; // 0x140
		[Tooltip] // 0x0000000180140CB0-0x0000000180140CE0
		public float selectedBlockYoffset; // 0x144
		[Tooltip] // 0x0000000180140EF0-0x0000000180140F20
		public float placeBlockGroupTime; // 0x148
		[Tooltip] // 0x0000000180141080-0x00000001801410B0
		public float minBlockDistanceScaler; // 0x14C
		[Tooltip] // 0x0000000180142500-0x0000000180142530
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
		private struct TerrafarmingGridGroup // TypeDefIndex: 15627
		{
			// Fields
			internal int gridGroupColorIndex; // 0x00
			internal List<TerrafarmingBlock> groupBlocks; // 0x08
	
			// Constructors
			public TerrafarmingGridGroup(int inColorIndex, TerrafarmingBlock inBlock); // 0x000000018028A2F0-0x000000018028A320
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <FadeInUI>d__62 : IEnumerator<object> // TypeDefIndex: 15628
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public TerraFarming <>4__this; // 0x20
			private float <t>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <FadeInUI>d__62(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001817179A0-0x0000000181717A90
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181717A90-0x0000000181717AE0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <MoveBlockGroupToSelectionPoint>d__65 : IEnumerator<object> // TypeDefIndex: 15629
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <MoveBlockGroupToSelectionPoint>d__65(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181719BE0-0x000000018171A020
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018171A020-0x000000018171A070
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <BlockGroupOut>d__66 : IEnumerator<object> // TypeDefIndex: 15630
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public TerraFarming <>4__this; // 0x20
			public int inIndex; // 0x28
			private Vector3 <startPos>5__2; // 0x2C
			private float <t>5__3; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <BlockGroupOut>d__66(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181715370-0x00000001817156E0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001817156E0-0x0000000181715730
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <PlaceDropBlockGroup>d__70 : IEnumerator<object> // TypeDefIndex: 15631
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <PlaceDropBlockGroup>d__70(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018171A960-0x000000018171AD90
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018171AD90-0x000000018171ADE0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <BlockGroupPlaced>d__75 : IEnumerator<object> // TypeDefIndex: 15632
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public TerraFarming <>4__this; // 0x20
			public TerrafarmingBlockGroup inDropBlockGroup; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <BlockGroupPlaced>d__75(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181715730-0x0000000181715FE0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181715FE0-0x0000000181716030
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <CollectorPulse>d__79 : IEnumerator<object> // TypeDefIndex: 15633
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <CollectorPulse>d__79(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181716BD0-0x0000000181717020
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181717020-0x0000000181717070
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <StartCollectorPulse>d__80 : IEnumerator<object> // TypeDefIndex: 15634
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public TerrafarmingBlock inDropBlock; // 0x20
			public TerraFarming <>4__this; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <StartCollectorPulse>d__80(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018171FCA0-0x0000000181720340
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181720340-0x0000000181720390
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowTurnScore>d__84 : IEnumerator<object> // TypeDefIndex: 15635
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowTurnScore>d__84(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018171F420-0x000000018171F650
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018171F650-0x000000018171F6A0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <PulseCollectorText>d__85 : IEnumerator<object> // TypeDefIndex: 15636
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <PulseCollectorText>d__85(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018171ADE0-0x000000018171B1A0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018171B1A0-0x000000018171B1F0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <CleanupAndReset>d__89 : IEnumerator<object> // TypeDefIndex: 15637
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public TerraFarming <>4__this; // 0x20
			private int <i>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <CleanupAndReset>d__89(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181716430-0x0000000181716850
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181716850-0x00000001817168A0
		}
	
		// Constructors
		public TerraFarming(); // 0x0000000180FF41E0-0x0000000180FF46D0
	
		// Methods
		public override void Start(); // 0x0000000180FF38A0-0x0000000180FF3B00
		private void InitBlockGroups(); // 0x0000000180FF1820-0x0000000180FF1B30
		private void ResetUI(); // 0x0000000180FF2A20-0x0000000180FF2F00
		[IteratorStateMachine] // 0x00000001801425F0-0x0000000180142640
		private IEnumerator FadeInUI(); // 0x0000000180FF17B0-0x0000000180FF1820
		internal override void Intro(); // 0x0000000180FF1B30-0x0000000180FF1BD0
		private void SpawnBlockGroup(int inSpawnIndex, bool inInitial = false /* Metadata: 0x00784D82 */, int inCollectorColor = -1 /* Metadata: 0x00784D83 */); // 0x0000000180FF3410-0x0000000180FF36C0
		[IteratorStateMachine] // 0x00000001801428B0-0x0000000180142900
		private IEnumerator MoveBlockGroupToSelectionPoint(int inIndex, bool inDoGameOverCheck = false /* Metadata: 0x00784D87 */); // 0x0000000180FF2570-0x0000000180FF2600
		[IteratorStateMachine] // 0x0000000180142DE0-0x0000000180142E30
		private IEnumerator BlockGroupOut(int inIndex); // 0x0000000180FF0A60-0x0000000180FF0AE0
		public void Update(); // 0x0000000180FF3CB0-0x0000000180FF41E0
		private void CheckGrid(); // 0x0000000180FF1100-0x0000000180FF16C0
		internal void BlockGroupSelected(TerrafarmingBlockGroup inBlockGroup = null); // 0x0000000180FF0B60-0x0000000180FF1100
		[IteratorStateMachine] // 0x0000000180143040-0x0000000180143090
		private IEnumerator PlaceDropBlockGroup(TerrafarmingBlockGroup inDropBlockGroup); // 0x0000000180FF2880-0x0000000180FF2900
		private void SetGridBlockColorsFromDropBlock(TerrafarmingBlock inDropBlock); // 0x0000000180FF2F70-0x0000000180FF3130
		private int AddDropBlockToGridBlockGroup(TerrafarmingBlock inDropBlock); // 0x0000000180FEFD90-0x0000000180FF0080
		public void UpdateScore(Dictionary<RuneType, int> turnScores, int comboMultiplier, Vector3 dropPosition); // 0x0000000180FF3B00-0x0000000180FF3CB0
		private void AdjustScore(Vector3 inColorsMatchedMultiplierPos); // 0x0000000180FF0080-0x0000000180FF0A60
		[IteratorStateMachine] // 0x0000000180143290-0x00000001801432E0
		private IEnumerator BlockGroupPlaced(TerrafarmingBlockGroup inDropBlockGroup); // 0x0000000180FF0AE0-0x0000000180FF0B60
		private void QueueGatherBlock(int colorIndex); // 0x0000000180FF2980-0x0000000180FF2A10
		public void OnGatherBlockSpawned(); // 0x0000000180FF27B0-0x0000000180FF2880
		private void SpawnNext(int inSpawnIndex); // 0x0000000180FF36C0-0x0000000180FF3820
		[IteratorStateMachine] // 0x00000001801434C0-0x0000000180143510
		private IEnumerator CollectorPulse(TerrafarmingBlock inCollectorBlock); // 0x0000000180FF1730-0x0000000180FF17B0
		[IteratorStateMachine] // 0x00000001801436B0-0x0000000180143700
		private IEnumerator StartCollectorPulse(TerrafarmingBlock inDropBlock); // 0x0000000180FF3820-0x0000000180FF38A0
		private void SetPulseIndexes(TerrafarmingBlock inBlock, TerrafarmingGridGroup inTerrafarmingGridGroup); // 0x0000000180FF3130-0x0000000180FF3390
		private bool IsGridBlockEmpty(Vector3 inGridBlockLocation); // 0x0000000180FF21D0-0x0000000180FF23C0
		private bool IsGameOverCheck(); // 0x0000000180FF1BD0-0x0000000180FF21D0
		[IteratorStateMachine] // 0x00000001801437E0-0x0000000180143830
		private IEnumerator ShowTurnScore(UnityEngine.UI.Text inText); // 0x0000000180FF3390-0x0000000180FF3410
		[IteratorStateMachine] // 0x0000000180143AA0-0x0000000180143AF0
		private IEnumerator PulseCollectorText(UnityEngine.UI.Text inText); // 0x0000000180FF2900-0x0000000180FF2980
		private bool IsNextTo(TerrafarmingBlock inGridBlock, TerrafarmingBlock inDropBlock); // 0x0000000180FF23C0-0x0000000180FF2570
		private bool NextToCheckAndColorSides(TerrafarmingBlock inGridBlock, TerrafarmingBlock inDropBlock); // 0x0000000180FF2600-0x0000000180FF27B0
		internal override void ResultsDone(); // 0x0000000180FF2F00-0x0000000180FF2F70
		[IteratorStateMachine] // 0x0000000180143BF0-0x0000000180143C40
		private IEnumerator CleanupAndReset(); // 0x0000000180FF16C0-0x0000000180FF1730
		public void ResetGame(); // 0x0000000180FF2A10-0x0000000180FF2A20
	}
}
