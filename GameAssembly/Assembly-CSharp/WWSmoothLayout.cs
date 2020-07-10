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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class WWSmoothLayout : MonoBehaviour // TypeDefIndex: 13617
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RectTransform _targetParent; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RectTransform _srcParent; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _initFromExistingHeirarchy; // 0x30
	[FormerlySerializedAs] // 0x00000001800DB820-0x00000001800DB860
	[SerializeField] // 0x00000001800DB820-0x00000001800DB860
	private bool _animatedResizeSelf; // 0x31
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private ScrollRect _scrollRect; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _animationDuration; // 0x40
	private List<RectPair> _rectPairs; // 0x48
	private bool _isSetup; // 0x50
	private bool _isDirty; // 0x51
	private Waiter _markDirtyWaiter; // 0x58
	private float _quickMoveRequestTime; // 0x60
	private Tweener _scrollTween; // 0x68

	// Properties
	public ScrollRect ScrollRect { get; } // 0x0000000180369BB0-0x0000000180369BC0 
	public float AnimationDuration { get; } // 0x0000000180FFAB50-0x0000000180FFAB90 
	public bool IsResizing { get; } // 0x0000000180FFABC0-0x0000000180FFAC70 
	private bool DoQuickMove { get; } // 0x0000000180FFAB90-0x0000000180FFABC0 

	// Nested types
	public class RectPair : Tuple<RectTransform, RectTransform> // TypeDefIndex: 13618
	{
		// Fields
		private int _framesToSnap; // 0x20
		public bool _snapHeight; // 0x24
		public Vector2 targetAnchoredPosition; // 0x28
		public Vector2 targetSizeDelta; // 0x30

		// Properties
		public RectTransform TargetRect { get; } // 0x000000018036AC80-0x000000018036AC90 
		public RectTransform SrcRect { get; } // 0x000000018038B150-0x000000018038B160 
		public int FramesToSnap { get; set; } // 0x00000001803C2700-0x00000001803C2710 0x00000001804886F0-0x0000000180488700

		// Constructors
		public RectPair(RectTransform inTargetRect, RectTransform inSrcRect); // 0x0000000180FEFB20-0x0000000180FEFC10
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass25_0 // TypeDefIndex: 13619
	{
		// Fields
		public RectTransform inChild; // 0x10

		// Constructors
		public <>c__DisplayClass25_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <SetSiblingIndex>b__0(RectPair pair); // 0x0000000180FF5DD0-0x0000000180FF5EB0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass26_0 // TypeDefIndex: 13620
	{
		// Fields
		public RectTransform inChild; // 0x10

		// Constructors
		public <>c__DisplayClass26_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <SetAsLastSibling>b__0(RectPair pair); // 0x0000000180FF5EB0-0x0000000180FF5F90
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass29_0 // TypeDefIndex: 13621
	{
		// Fields
		public RectTransform inChild; // 0x10
		public WWSmoothLayout <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass29_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <ScrollToItem>b__0(); // 0x0000000180FF60E0-0x0000000180FF6750
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass29_1 // TypeDefIndex: 13622
	{
		// Fields
		public RectTransform target; // 0x10

		// Constructors
		public <>c__DisplayClass29_1(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <ScrollToItem>b__1(RectPair pair); // 0x0000000180FF6750-0x0000000180FF6830
		internal bool <ScrollToItem>b__2(RectPair pair); // 0x0000000180FF6830-0x0000000180FF6910
	}

	// Constructors
	public WWSmoothLayout(); // 0x0000000180FFAAE0-0x0000000180FFAB50

	// Methods
	public void AddChild(RectTransform inChild); // 0x0000000180FF8670-0x0000000180FF8C70
	public void RemoveChild(int inChildIndex, bool inDestroy); // 0x0000000180FF9A70-0x0000000180FF9B20
	public void RemoveChild(RectTransform inChild, bool inDestroy); // 0x0000000180FF9B20-0x0000000180FF9DF0
	public void SetChildActive(int inChildIndex, bool inActive, bool inSnapPosition = true /* Metadata: 0x00783EBE */); // 0x0000000180FFA0A0-0x0000000180FFA150
	public void SetChildActive(RectTransform inChild, bool inActive, bool inSnapPosition = true /* Metadata: 0x00783EBF */); // 0x0000000180FFA150-0x0000000180FFA460
	public void SetSiblingIndex(RectTransform inChild, int inChildIndex); // 0x0000000180FFA460-0x0000000180FFA670
	public void SetAsLastSibling(RectTransform inChild); // 0x0000000180FF9F20-0x0000000180FFA0A0
	public RectPair GetRectPair(int inChildIndex); // 0x0000000180FF8C70-0x0000000180FF8D20
	public RectPair GetRectPair(RectTransform inChild); // 0x0000000180FF8D20-0x0000000180FF8F20
	public void ScrollToItem(RectTransform inChild); // 0x0000000180FF9E70-0x0000000180FF9F20
	[DeMethodButton] // 0x00000001800DBE50-0x00000001800DBEB0
	public void MarkAsDirty(); // 0x0000000180FF99D0-0x0000000180FF9A70
	public void RequestQuickTime(); // 0x0000000180FF9E50-0x0000000180FF9E70
	[DeMethodButton] // 0x00000001800DC0B0-0x00000001800DC110
	public void RemoveFirstChild(); // 0x0000000180FF9DF0-0x0000000180FF9E00
	[DeMethodButton] // 0x00000001800DC400-0x00000001800DC460
	public void RemoveLastChild(); // 0x0000000180FF9E00-0x0000000180FF9E50
	private void Start(); // 0x0000000180FFAAC0-0x0000000180FFAAD0
	public void Setup(); // 0x0000000180FFA670-0x0000000180FFAAC0
	private void LateUpdate(); // 0x0000000180FF8F20-0x0000000180FF99D0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <MarkAsDirty>b__30_0(); // 0x0000000180FFAAD0-0x0000000180FFAAE0
}

