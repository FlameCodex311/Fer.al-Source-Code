/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype.QuickGames.GatherDroppedItems
{
	public class GatherDroppedItemsMaker : UnityEngine.MonoBehaviour // TypeDefIndex: 16291
	{
		// Fields
		public bool showDbg; // 0x18
		[Tooltip] // 0x00000001800C1880-0x00000001800C18B0
		public float yMaxDist; // 0x1C
		[Tooltip] // 0x00000001800C1880-0x00000001800C18B0
		public float xMaxDist; // 0x20
		public int segmentsPerQuarter; // 0x24
		public float segmentQuarterArchHeight; // 0x28
		public int segmentsTravelMin; // 0x2C
		public int segmentsTravelMax; // 0x30
		public float segmentTimeMin; // 0x34
		public float segmentTimeMax; // 0x38
		public float segmentInnerScaler; // 0x3C
		public float startStopSpeedScaler; // 0x40
		public float speedScalerDampTime; // 0x44
		public float newItemTimeMin; // 0x48
		public float newItemTimeMax; // 0x4C
		internal GatherDroppedItems game; // 0x50
		internal Transform trans; // 0x58
		private int _pointListIndexMaster; // 0x60
		private float _currentMoveTime; // 0x64
		private float _currentItemTime; // 0x68
		private float _itemTime; // 0x6C
		private float _segmentTime; // 0x70
		private float _speedScaler; // 0x74
		private float _totalCurrentTime; // 0x78
		private float _speedScalerDampTime; // 0x7C
		private bool _dirControl; // 0x80
		private int _pointListIndexCurrent; // 0x84
		private List<Vector3> _allPointsList; // 0x88
		private List<Vector3> _currentPointsList; // 0x90
		private List<Transform> _goList; // 0x98
		public float timeBetweenRewardMin; // 0xA0
		public float timeBetweenRewardMax; // 0xA4
		public int embersBeforeRareMin; // 0xA8
		public int embersBeforeRareMax; // 0xAC
		private float _timeBetweenReward; // 0xB0
		private int _embersBeforeRare; // 0xB4
		private bool _rareSpawned; // 0xB8
	
		// Constructors
		public GatherDroppedItemsMaker(); // 0x00000001813EA430-0x00000001813EA4C0
	
		// Methods
		private void Awake(); // 0x00000001813E8F20-0x00000001813E8F40
		internal void Init(); // 0x00000001813E9120-0x00000001813E9270
		internal void ItemMakerUpdate(); // 0x00000001813E9270-0x00000001813E98E0
		private void GetNewCurrentPointsList(); // 0x00000001813E8F40-0x00000001813E9120
		private void MakeAllPointsList(bool inMakeGO); // 0x00000001813E98E0-0x00000001813EA080
		private void MakeGO(Vector3 inV3); // 0x00000001813EA080-0x00000001813EA210
		private void OnDrawGizmos(); // 0x00000001813EA210-0x00000001813EA430
	}
}
