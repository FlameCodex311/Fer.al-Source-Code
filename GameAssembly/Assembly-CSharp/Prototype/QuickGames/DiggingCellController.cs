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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype.QuickGames
{
	public class DiggingCellController : MonoBehaviour // TypeDefIndex: 16100
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
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <IsRare>k__BackingField; // 0xA4
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <IsUncommon>k__BackingField; // 0xA5
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <IsDifficult>k__BackingField; // 0xA6
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <IsOpenable>k__BackingField; // 0xA7
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <IsOpen>k__BackingField; // 0xA8
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
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
		public bool IsRare { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018139F360-0x000000018139F370 0x000000018139F3C0-0x000000018139F3D0
		public bool IsUncommon { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018139F370-0x000000018139F380 0x000000018139F3D0-0x000000018139F3E0
		public bool IsDifficult { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018139F340-0x000000018139F350 0x000000018139F3A0-0x000000018139F3B0
		public bool IsOpenable { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018139F350-0x000000018139F360 0x000000018139F3B0-0x000000018139F3C0
		public bool IsOpen { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018073CF80-0x000000018073CF90 0x0000000180371FA0-0x0000000180371FB0
		public bool IsBomb { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180759E00-0x0000000180759E10 0x000000018139F390-0x000000018139F3A0
		public int EmberValue { get; set; } // 0x00000001806891F0-0x0000000180689200 0x000000018139F380-0x000000018139F390
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <OpenAndCollect>d__88 : IEnumerator<object> // TypeDefIndex: 16101
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DiggingCellController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <OpenAndCollect>d__88(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813A9B00-0x00000001813AA110
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813AA110-0x00000001813AA160
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <AnimateChestOpening>d__89 : IEnumerator<object> // TypeDefIndex: 16102
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DiggingCellController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <AnimateChestOpening>d__89(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813A72F0-0x00000001813A7370
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813A7370-0x00000001813A73C0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <AnimateEmberCollecting>d__90 : IEnumerator<object> // TypeDefIndex: 16103
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DiggingCellController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <AnimateEmberCollecting>d__90(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813A7550-0x00000001813A76D0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813A76D0-0x00000001813A7720
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <AnimateContentFading>d__91 : IEnumerator<object> // TypeDefIndex: 16104
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DiggingCellController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <AnimateContentFading>d__91(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813A73C0-0x00000001813A7500
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813A7500-0x00000001813A7550
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <AnimateInfoTextFading>d__92 : IEnumerator<object> // TypeDefIndex: 16105
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DiggingCellController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <AnimateInfoTextFading>d__92(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813A7720-0x00000001813A7860
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813A7860-0x00000001813A78B0
		}
	
		// Constructors
		public DiggingCellController(); // 0x000000018139F2E0-0x000000018139F340
		static DiggingCellController(); // 0x000000018139F290-0x000000018139F2E0
	
		// Methods
		private void Start(); // 0x000000018139EA30-0x000000018139F290
		public void ButtonClicked(); // 0x000000018139E2A0-0x000000018139E820
		public void SetContents(Sprite partial, Sprite exposed, bool isRare = false /* Metadata: 0x00785414 */, bool isUncommon = false /* Metadata: 0x00785415 */, int emberValue = 0 /* Metadata: 0x00785416 */); // 0x000000018139E990-0x000000018139E9C0
		public void MakeOpenable(Sprite sprite); // 0x000000018139E910-0x000000018139E930
		public void SetGameController(Digging controller); // 0x00000001804A22E0-0x00000001804A22F0
		private void MakeDifficult(); // 0x000000018139E8A0-0x000000018139E910
		private Sprite GetRandomSprite(List<Sprite> sprites); // 0x000000018139E820-0x000000018139E8A0
		private void StartCollection(); // 0x000000018139E9C0-0x000000018139EA30
		[IteratorStateMachine] // 0x000000018010B400-0x000000018010B450
		private IEnumerator OpenAndCollect(); // 0x000000018139E930-0x000000018139E990
		[IteratorStateMachine] // 0x000000018010B5D0-0x000000018010B620
		private IEnumerator AnimateChestOpening(); // 0x000000018139E120-0x000000018139E180
		[IteratorStateMachine] // 0x000000018010B910-0x000000018010B960
		private IEnumerator AnimateEmberCollecting(); // 0x000000018139E1E0-0x000000018139E240
		[IteratorStateMachine] // 0x000000018010B9F0-0x000000018010BA40
		private IEnumerator AnimateContentFading(); // 0x000000018139E180-0x000000018139E1E0
		[IteratorStateMachine] // 0x000000018010BC00-0x000000018010BC50
		private IEnumerator AnimateInfoTextFading(); // 0x000000018139E240-0x000000018139E2A0
	}
}
