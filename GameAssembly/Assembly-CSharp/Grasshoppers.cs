/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class Grasshoppers : ManagedBehaviour // TypeDefIndex: 13730
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _model; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _scale; // 0x58
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private int _amount; // 0x5C
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private NavMeshAgent _agent; // 0x60
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _spawnRadius; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _runAwayRadius; // 0x6C
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _runAwayDistance; // 0x70
	private List<AgentInfo> _agentInfos; // 0x78

	// Nested types
	public class AgentInfo // TypeDefIndex: 13731
	{
		// Fields
		public NavMeshAgent agent; // 0x10
		public Vector3 position; // 0x18
		public Quaternion rotation; // 0x24

		// Constructors
		public AgentInfo(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	// Constructors
	public Grasshoppers(); // 0x0000000181058FD0-0x0000000181059070

	// Methods
	public override void MStart(); // 0x00000001810588C0-0x0000000181058B60
	public override void MUpdate(); // 0x0000000181058B60-0x0000000181058DA0
	private void SetDestination(AgentInfo inAgentInfo); // 0x0000000181058E10-0x0000000181058FD0
	private void OnDrawGizmos(); // 0x0000000181058DA0-0x0000000181058E10
	private bool GetValidSpawn(AgentInfo inAgentInfo); // 0x0000000181058630-0x00000001810588C0
}

