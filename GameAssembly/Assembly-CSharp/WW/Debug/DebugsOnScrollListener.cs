/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.Debug
{
	public class DebugsOnScrollListener : MonoBehaviour, IScrollHandler, IBeginDragHandler, IEndDragHandler // TypeDefIndex: 16271
	{
		// Fields
		public ScrollRect debugsScrollRect; // 0x20
		public DebugPanel debugPanel; // 0x28
	
		// Constructors
		public DebugsOnScrollListener(); // 0x00000001803743C0-0x00000001803743D0
	
		// Methods
		public void OnScroll(PointerEventData data); // 0x000000018096E670-0x000000018096E6D0
		public void OnBeginDrag(PointerEventData data); // 0x000000018096E650-0x000000018096E670
		public void OnEndDrag(PointerEventData data); // 0x000000018096E650-0x000000018096E670
		public void OnScrollbarDragStart(BaseEventData data); // 0x000000018096E650-0x000000018096E670
		public void OnScrollbarDragEnd(BaseEventData data); // 0x000000018096E670-0x000000018096E6D0
		private bool IsScrollbarAtBottom(); // 0x000000018096E620-0x000000018096E650
	}
}
