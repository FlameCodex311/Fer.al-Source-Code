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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype.QuickGames
{
	public class DiggingCellController : MonoBehaviour // TypeDefIndex: 14842
	{
		// Fields
		public List<Sprite> stateFiveSprites; // 0x20
		public List<Color> stateFiveColors; // 0x28
		public int stateFiveClicks; // 0x30
		public List<Sprite> stateFourSprites; // 0x38
		public List<Color> stateFourColors; // 0x40
		public int stateFourClicks; // 0x48
		public List<Sprite> stateThreeSprites; // 0x50
		public List<Color> stateThreeColors; // 0x58
		public int stateThreeClicks; // 0x60
		public List<Sprite> stateTwoSprites; // 0x68
		public List<Color> stateTwoColors; // 0x70
		public int stateTwoClicks; // 0x78
		public List<Sprite> stateOneSprites; // 0x80
		public List<Color> stateOneColors; // 0x88
		public int startingState; // 0x90
		public GameObject particleSystemPrefab; // 0x98
		public int particlesPerClick; // 0xA0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <IsRare>k__BackingField; // 0xA4
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <IsUncommon>k__BackingField; // 0xA5
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <IsDifficult>k__BackingField; // 0xA6
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <IsOpenable>k__BackingField; // 0xA7
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <IsOpen>k__BackingField; // 0xA8
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <IsBomb>k__BackingField; // 0xA9
		private int _emberValue; // 0xAC
		private int stateIdx; // 0xB0
		private bool exposed; // 0xB4
		private bool collected; // 0xB5
		private Button button; // 0xB8
		private Image buttonImage; // 0xC0
		private Digging gameController; // 0xC8
		private List<List<Sprite>> spriteLists; // 0xD0
		private List<Sprite> spriteList; // 0xD8
		private List<List<Color>> colorLists; // 0xE0
		private List<int> clickCounts; // 0xE8
		private int clickCount; // 0xF0
		private int ccMax; // 0xF4
		private Image contents; // 0xF8
		private RectTransform contentsRectTransform; // 0x100
		private GameObject contentsInfo; // 0x108
		private UnityEngine.UI.Text contentsInfoText; // 0x110
		private Sprite partialSprite; // 0x118
		private Sprite exposedSprite; // 0x120
		private Sprite openSprite; // 0x128
		private GameObject particleContainer; // 0x130
		private ParticleSystem particles; // 0x138
		private ParticleSystem subParticles; // 0x140
		private bool isOpening; // 0x148
		private float elapsedTime; // 0x14C
		private float emberCollectionTime; // 0x150
		private float fadeTime; // 0x154
		private float textFadeTime; // 0x158
		private static int MAX_NUM_STATES; // 0x00
		private static int PARTIAL_STATE; // 0x04
		private Vector2 posA; // 0x15C
		private Vector2 posB; // 0x164
		private Color colorA; // 0x16C
		private Color colorB; // 0x17C
		private Vector2 sizeA; // 0x18C
		private Vector2 sizeB; // 0x194
	
		// Properties
		public bool IsRare { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180A389A0-0x0000000180A389B0 0x0000000180A389B0-0x0000000180A389C0
		public bool IsUncommon { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180AD5820-0x0000000180AD5830 0x0000000180AD5870-0x0000000180AD5880
		public bool IsDifficult { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180AD5800-0x0000000180AD5810 0x0000000180AD5850-0x0000000180AD5860
		public bool IsOpenable { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180AD5810-0x0000000180AD5820 0x0000000180AD5860-0x0000000180AD5870
		public bool IsOpen { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180921730-0x0000000180921740 0x0000000180421050-0x0000000180421060
		public bool IsBomb { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180921720-0x0000000180921730 0x0000000180AD5840-0x0000000180AD5850
		public int EmberValue { get; set; } // 0x0000000180AD57F0-0x0000000180AD5800 0x0000000180AD5830-0x0000000180AD5840
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <OpenAndCollect>d__88 : IEnumerator<object> // TypeDefIndex: 14843
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DiggingCellController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <OpenAndCollect>d__88(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180AE0170-0x0000000180AE0770
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180AE0770-0x0000000180AE07C0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <AnimateChestOpening>d__89 : IEnumerator<object> // TypeDefIndex: 14844
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DiggingCellController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <AnimateChestOpening>d__89(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180ADDF90-0x0000000180ADE010
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180ADE010-0x0000000180ADE060
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <AnimateEmberCollecting>d__90 : IEnumerator<object> // TypeDefIndex: 14845
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DiggingCellController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <AnimateEmberCollecting>d__90(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180ADE1E0-0x0000000180ADE360
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180ADE360-0x0000000180ADE3B0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <AnimateContentFading>d__91 : IEnumerator<object> // TypeDefIndex: 14846
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DiggingCellController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <AnimateContentFading>d__91(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180ADE060-0x0000000180ADE190
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180ADE190-0x0000000180ADE1E0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <AnimateInfoTextFading>d__92 : IEnumerator<object> // TypeDefIndex: 14847
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DiggingCellController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <AnimateInfoTextFading>d__92(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180ADE3B0-0x0000000180ADE4E0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180ADE4E0-0x0000000180ADE530
		}
	
		// Constructors
		public DiggingCellController(); // 0x0000000180AD5790-0x0000000180AD57F0
		static DiggingCellController(); // 0x0000000180AD5740-0x0000000180AD5790
	
		// Methods
		private void Start(); // 0x0000000180AD4F20-0x0000000180AD5740
		public void ButtonClicked(); // 0x0000000180AD47C0-0x0000000180AD4D20
		public void SetContents(Sprite partial, Sprite exposed, bool isRare = false /* Metadata: 0x007BB006 */, bool isUncommon = false /* Metadata: 0x007BB007 */, int emberValue = 0 /* Metadata: 0x007BB008 */); // 0x0000000180AD4E80-0x0000000180AD4EB0
		public void MakeOpenable(Sprite sprite); // 0x0000000180AD4E00-0x0000000180AD4E20
		public void SetGameController(Digging controller); // 0x00000001804AF520-0x00000001804AF530
		private void MakeDifficult(); // 0x0000000180AD4D90-0x0000000180AD4E00
		private Sprite GetRandomSprite(List<Sprite> sprites); // 0x0000000180AD4D20-0x0000000180AD4D90
		private void StartCollection(); // 0x0000000180AD4EB0-0x0000000180AD4F20
		[IteratorStateMachine] // 0x000000018022C3B0-0x000000018022C400
		private IEnumerator OpenAndCollect(); // 0x0000000180AD4E20-0x0000000180AD4E80
		[IteratorStateMachine] // 0x000000018022C6E0-0x000000018022C730
		private IEnumerator AnimateChestOpening(); // 0x0000000180AD4640-0x0000000180AD46A0
		[IteratorStateMachine] // 0x000000018022C950-0x000000018022C9A0
		private IEnumerator AnimateEmberCollecting(); // 0x0000000180AD4700-0x0000000180AD4760
		[IteratorStateMachine] // 0x000000018022CC20-0x000000018022CC70
		private IEnumerator AnimateContentFading(); // 0x0000000180AD46A0-0x0000000180AD4700
		[IteratorStateMachine] // 0x000000018022D030-0x000000018022D080
		private IEnumerator AnimateInfoTextFading(); // 0x0000000180AD4760-0x0000000180AD47C0
	}
}
