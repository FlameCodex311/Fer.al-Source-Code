/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Prototype.QuickGames;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype.QuickGames.CatchThrownItems
{
	public class CatchThrownItemsItem : UnityEngine.MonoBehaviour // TypeDefIndex: 16310
	{
		// Fields
		public RawImage rawimage; // 0x18
		public float shadowScale; // 0x20
		internal EState state; // 0x24
		internal int archDir; // 0x28
		internal CatchThrownItems game; // 0x30
		internal float spawnTime; // 0x38
		internal bool isRare; // 0x3C
		private Vector3 _caughtPos; // 0x40
		private Vector3 _startScale; // 0x4C
		private int _itemPosIndex; // 0x58
		private Transform _shadow; // 0x60
		private bool _isScaled; // 0x68
		private bool _hasLanded; // 0x69
		private float _currentTime; // 0x6C
		private Vector3 _launchPoint; // 0x70
		private Vector3 _landPoint; // 0x7C
		private List<Vector3> _pointList; // 0x88
		private Vector2 _mousePos; // 0x90
		private Vector3 _shadowScale; // 0x98
	
		// Nested types
		internal enum EState // TypeDefIndex: 16311
		{
			SCALING = 0,
			THROW = 1,
			LAUNCH = 2,
			INAIR = 3,
			LANDED = 4,
			CAUGHT = 5,
			INBASKET = 6
		}
	
		// Constructors
		public CatchThrownItemsItem(); // 0x000000018139B030-0x000000018139B110
	
		// Methods
		internal void ItemUpdate(); // 0x0000000181399C40-0x000000018139B030
		internal void Init(); // 0x0000000181399AE0-0x0000000181399C40
		private void GetImage(RawImage inRawImage, QuickGamesBase.WinIngredient inWinIngredient); // 0x00000001803581E0-0x00000001803581F0
	}
}
