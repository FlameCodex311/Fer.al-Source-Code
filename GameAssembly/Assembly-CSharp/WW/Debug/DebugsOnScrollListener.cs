/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.Debug
{
	public class DebugsOnScrollListener : MonoBehaviour, IScrollHandler, IBeginDragHandler, IEndDragHandler // TypeDefIndex: 15719
	{
		// Fields
		public ScrollRect debugsScrollRect; // 0x20
		public DebugPanel debugPanel; // 0x28
	
		// Constructors
		public DebugsOnScrollListener(); // 0x0000000180E095D0-0x0000000180E095E0
	
		// Methods
		public void OnScroll(PointerEventData data); // 0x00000001811293D0-0x0000000181129430
		public void OnBeginDrag(PointerEventData data); // 0x00000001811293B0-0x00000001811293D0
		public void OnEndDrag(PointerEventData data); // 0x00000001811293B0-0x00000001811293D0
		public void OnScrollbarDragStart(BaseEventData data); // 0x00000001811293B0-0x00000001811293D0
		public void OnScrollbarDragEnd(BaseEventData data); // 0x00000001811293D0-0x0000000181129430
		private bool IsScrollbarAtBottom(); // 0x0000000181129380-0x00000001811293B0
	}
}
