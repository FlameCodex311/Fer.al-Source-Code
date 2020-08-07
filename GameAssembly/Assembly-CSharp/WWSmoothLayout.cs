/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.DeInspektor.Attributes;
using DG.Tweening;
using Unitilities.Tuples;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using WW.Waiters;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class WWSmoothLayout : MonoBehaviour // TypeDefIndex: 11284
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RectTransform _targetParent; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RectTransform _srcParent; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _initFromExistingHeirarchy; // 0x30
	[FormerlySerializedAs] // 0x00000001802780B0-0x00000001802780F0
	[SerializeField] // 0x00000001802780B0-0x00000001802780F0
	private bool _animatedResizeSelf; // 0x31
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private ScrollRect _scrollRect; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _animationDuration; // 0x40
	private List<RectPair> _rectPairs; // 0x48
	private bool _isSetup; // 0x50
	private bool _isDirty; // 0x51
	private Waiter _markDirtyWaiter; // 0x58
	private float _quickMoveRequestTime; // 0x60
	private Tweener _scrollTween; // 0x68

	// Properties
	public ScrollRect ScrollRect { get; } // 0x00000001803743D0-0x00000001803743E0 
	public float AnimationDuration { get; } // 0x00000001805E1E70-0x00000001805E1EB0 
	public bool IsResizing { get; } // 0x00000001805E1EE0-0x00000001805E1F90 
	private bool DoQuickMove { get; } // 0x00000001805E1EB0-0x00000001805E1EE0 

	// Nested types
	public class RectPair : Tuple<RectTransform, RectTransform> // TypeDefIndex: 11285
	{
		// Fields
		private int _framesToSnap; // 0x20
		public bool _snapHeight; // 0x24
		public Vector2 targetAnchoredPosition; // 0x28
		public Vector2 targetSizeDelta; // 0x30

		// Properties
		public RectTransform TargetRect { get; } // 0x0000000180372440-0x0000000180372450 
		public RectTransform SrcRect { get; } // 0x0000000180372430-0x0000000180372440 
		public int FramesToSnap { get; set; } // 0x00000001803FB670-0x00000001803FB680 0x00000001804556D0-0x00000001804556E0

		// Constructors
		public RectPair(RectTransform inTargetRect, RectTransform inSrcRect); // 0x00000001805D75E0-0x00000001805D76D0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass25_0 // TypeDefIndex: 11286
	{
		// Fields
		public RectTransform inChild; // 0x10

		// Constructors
		public <>c__DisplayClass25_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <SetSiblingIndex>b__0(RectPair pair); // 0x00000001805DD3D0-0x00000001805DD4B0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass26_0 // TypeDefIndex: 11287
	{
		// Fields
		public RectTransform inChild; // 0x10

		// Constructors
		public <>c__DisplayClass26_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <SetAsLastSibling>b__0(RectPair pair); // 0x00000001805DD4B0-0x00000001805DD590
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass29_0 // TypeDefIndex: 11288
	{
		// Fields
		public RectTransform inChild; // 0x10
		public WWSmoothLayout <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass29_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <ScrollToItem>b__0(); // 0x00000001805DD6E0-0x00000001805DDD30
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass29_1 // TypeDefIndex: 11289
	{
		// Fields
		public RectTransform target; // 0x10

		// Constructors
		public <>c__DisplayClass29_1(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <ScrollToItem>b__1(RectPair pair); // 0x00000001805DDD30-0x00000001805DDE10
		internal bool <ScrollToItem>b__2(RectPair pair); // 0x00000001805DDE10-0x00000001805DDEF0
	}

	// Constructors
	public WWSmoothLayout(); // 0x00000001805E1E00-0x00000001805E1E70

	// Methods
	public void AddChild(RectTransform inChild); // 0x00000001805DFA30-0x00000001805E0020
	public void RemoveChild(int inChildIndex, bool inDestroy); // 0x00000001805E0DE0-0x00000001805E0E80
	public void RemoveChild(RectTransform inChild, bool inDestroy); // 0x00000001805E0E80-0x00000001805E1140
	public void SetChildActive(int inChildIndex, bool inActive, bool inSnapPosition = true /* Metadata: 0x0077C97D */); // 0x00000001805E13F0-0x00000001805E14A0
	public void SetChildActive(RectTransform inChild, bool inActive, bool inSnapPosition = true /* Metadata: 0x0077C97E */); // 0x00000001805E14A0-0x00000001805E17A0
	public void SetSiblingIndex(RectTransform inChild, int inChildIndex); // 0x00000001805E17A0-0x00000001805E19A0
	public void SetAsLastSibling(RectTransform inChild); // 0x00000001805E1270-0x00000001805E13F0
	public RectPair GetRectPair(int inChildIndex); // 0x00000001805E0020-0x00000001805E00C0
	public RectPair GetRectPair(RectTransform inChild); // 0x00000001805E00C0-0x00000001805E02B0
	public void ScrollToItem(RectTransform inChild); // 0x00000001805E11C0-0x00000001805E1270
	[DeMethodButton] // 0x00000001802784D0-0x0000000180278530
	public void MarkAsDirty(); // 0x00000001805E0D40-0x00000001805E0DE0
	public void RequestQuickTime(); // 0x00000001805E11A0-0x00000001805E11C0
	[DeMethodButton] // 0x0000000180278840-0x00000001802788A0
	public void RemoveFirstChild(); // 0x00000001805E1140-0x00000001805E1150
	[DeMethodButton] // 0x0000000180278C30-0x0000000180278C90
	public void RemoveLastChild(); // 0x00000001805E1150-0x00000001805E11A0
	private void Start(); // 0x00000001805E1DE0-0x00000001805E1DF0
	public void Setup(); // 0x00000001805E19A0-0x00000001805E1DE0
	private void LateUpdate(); // 0x00000001805E02B0-0x00000001805E0D40
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <MarkAsDirty>b__30_0(); // 0x00000001805E1DF0-0x00000001805E1E00
}

