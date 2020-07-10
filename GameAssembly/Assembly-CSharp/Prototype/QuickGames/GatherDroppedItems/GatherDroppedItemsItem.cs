/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype.QuickGames.GatherDroppedItems
{
	public class GatherDroppedItemsItem : UnityEngine.MonoBehaviour // TypeDefIndex: 16289
	{
		// Fields
		public RawImage rawImage; // 0x18
		internal bool gathered; // 0x20
		internal GatherDroppedItems game; // 0x28
		internal float lifeSpan; // 0x30
		internal float fadeOutTime; // 0x34
		internal EItemType itemType; // 0x38
		private Transform _trans; // 0x40
		private float _currentLifeSpan; // 0x48
		private float _fadeOutTime; // 0x4C
		private Color _transWhite; // 0x50
	
		// Nested types
		internal enum EItemType // TypeDefIndex: 16290
		{
			ITEM = 0,
			EMBER = 1,
			RARE = 2
		}
	
		// Constructors
		public GatherDroppedItemsItem(); // 0x00000001813E8EC0-0x00000001813E8F20
	
		// Methods
		private void Awake(); // 0x00000001813E8890-0x00000001813E88B0
		internal void ItemUpdate(); // 0x00000001813E88B0-0x00000001813E8EC0
	}
}
