﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class WorldObjectMover<T> : WorldObject<T> // TypeDefIndex: 11460
	where T : WorldObjectInfo
{
	// Fields
	protected List<WorldObjectMoverNode> _moverNodeQueue;
	private float _navCurrentTraveledDist;
	private float _navCurrentSegmentTraveledDist;
	private const float _navRotateSmoothTime = 0.25f; // Metadata: 0x00782A47
	private float _navRotateSmoothVelocity;
	private float NavStartTimer;

	// Constructors
	public WorldObjectMover();

	// Methods
	public void DummyMoveMessage(WorldObjectMoveMessage inMessage);
	protected override void OnMoveMessage(WorldObjectMoveMessage inMessage);
	private void ResetNavStartTimer();
	private void UpdateNavStartTimer();
	protected virtual void MUpdateMoverNodeQueue();
	protected virtual void HandleNodeType(WorldObjectMoverNode node);
}

