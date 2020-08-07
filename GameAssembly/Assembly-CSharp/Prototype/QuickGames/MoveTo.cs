/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype.QuickGames
{
	public class MoveTo : QuickGamesBase // TypeDefIndex: 14924
	{
		// Fields
		[Tooltip] // 0x000000018025FC10-0x000000018025FC40
		public Transform thingToMove; // 0xF0
		[Tooltip] // 0x000000018025FD80-0x000000018025FDB0
		public float moveDistnceMaxX; // 0xF8
		[Tooltip] // 0x000000018025FD80-0x000000018025FDB0
		public float moveDistnceMaxY; // 0xFC
		[Tooltip] // 0x0000000180260070-0x00000001802600A0
		public Texture targetHitIMG_WIN; // 0x100
		public Texture targetHitIMG_LOSE; // 0x108
		[Tooltip] // 0x0000000180260160-0x0000000180260190
		public float targetHitDistance; // 0x110
		[Tooltip] // 0x0000000180260300-0x0000000180260330
		public bool hitTargetsToWin; // 0x114
		[Header] // 0x0000000180260400-0x0000000180260430
		public List<Transform> targetLocators; // 0x118
		public List<Transform> nonTargetLocators; // 0x120
		[Header] // 0x0000000180260670-0x00000001802606D0
		[Tooltip] // 0x0000000180260670-0x00000001802606D0
		public bool clickTargetToHit; // 0x128
		[Tooltip] // 0x00000001802609B0-0x00000001802609E0
		public Texture targetOverIMG; // 0x130
		[Header] // 0x0000000180260B90-0x0000000180260BC0
		public bool randomizeLocatorsPositions; // 0x138
		[Tooltip] // 0x0000000180260C70-0x0000000180260CA0
		public float minRndTargetDist; // 0x13C
		public float maxRndTargetDist; // 0x140
		[Header] // 0x0000000180260E50-0x0000000180260E80
		public bool targetsMove; // 0x144
		public float targetMoveSpeedMin; // 0x148
		public float targetMoveSpeedMax; // 0x14C
		public ETargetMoveType targetMoveType; // 0x150
		private bool _targetOverX; // 0x154
		private bool _targetOverY; // 0x155
		private float _avoidDistance; // 0x158
		private float _dTime; // 0x15C
		private float _targetSizeX; // 0x160
		private float _targetSizeY; // 0x164
		private float _cursorSizeX; // 0x168
		private float _cursorSizeY; // 0x16C
		private float _playAreaBorderMaxX; // 0x170
		private float _playAreaBorderMaxY; // 0x174
		private float _playAreaBorderMinX; // 0x178
		private float _playAreaBorderMinY; // 0x17C
		private int _oldTargetIndex; // 0x180
		private int _overTargetIndex; // 0x184
		private int _targetIndex; // 0x188
		private int _targetsToHit; // 0x18C
		private Vector3 _tmpV3; // 0x190
		private Vector3 _lastMousePosition; // 0x19C
		private Vector3 _currentMousePosition; // 0x1A8
		private Vector3 _originaCursorPosition; // 0x1B4
		private Vector3 _thingToMovePosition; // 0x1C0
		private List<Vector3> _targetmoveDirs; // 0x1D0
		private List<Vector3> _nonTargetmoveDirs; // 0x1D8
		private List<float> _targetMoveSpeed; // 0x1E0
		private List<float> _nonTargetMoveSpeed; // 0x1E8
		private List<bool> _targetCornered; // 0x1F0
		private List<Transform> _placedTargets; // 0x1F8
		private Texture _targetNotOverIMG; // 0x200
		private RawImage _thingToMoveRawImage; // 0x208
	
		// Nested types
		public enum ETargetMoveType // TypeDefIndex: 14925
		{
			STRAIGHT = 0,
			PLAYER_BASED = 1
		}
	
		// Constructors
		public MoveTo(); // 0x0000000180A4D410-0x0000000180A4D480
	
		// Methods
		public override void MStart(); // 0x0000000180A4AFA0-0x0000000180A4B1D0
		private void PlaceTargets(); // 0x0000000180A4C420-0x0000000180A4C760
		private Vector3 GetRndPosition(); // 0x0000000180A4AB60-0x0000000180A4AFA0
		private void SetupMovingTargets(); // 0x0000000180A4CBC0-0x0000000180A4D280
		public override void QuickGameUpdate(); // 0x0000000180A4C760-0x0000000180A4CBC0
		private void MoveThingToMove(); // 0x0000000180A4BFF0-0x0000000180A4C270
		private void OverTargetCheck(); // 0x0000000180A4C270-0x0000000180A4C420
		private void MoveTargets(); // 0x0000000180A4B1D0-0x0000000180A4BFF0
		private void TargetHit(); // 0x0000000180A4D280-0x0000000180A4D410
	}
}
