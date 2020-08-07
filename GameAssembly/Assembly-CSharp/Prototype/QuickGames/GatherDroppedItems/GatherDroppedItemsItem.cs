/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype.QuickGames.GatherDroppedItems
{
	public class GatherDroppedItemsItem : UnityEngine.MonoBehaviour // TypeDefIndex: 15031
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
		internal enum EItemType // TypeDefIndex: 15032
		{
			ITEM = 0,
			EMBER = 1,
			RARE = 2
		}
	
		// Constructors
		public GatherDroppedItemsItem(); // 0x0000000180980510-0x0000000180980570
	
		// Methods
		private void Awake(); // 0x000000018097FF00-0x000000018097FF20
		internal void ItemUpdate(); // 0x000000018097FF20-0x0000000180980510
	}
}
