/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class Grasshoppers : ManagedBehaviour // TypeDefIndex: 11403
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _model; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _scale; // 0x58
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int _amount; // 0x5C
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private NavMeshAgent _agent; // 0x60
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _spawnRadius; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _runAwayRadius; // 0x6C
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _runAwayDistance; // 0x70
	private List<AgentInfo> _agentInfos; // 0x78

	// Nested types
	public class AgentInfo // TypeDefIndex: 11404
	{
		// Fields
		public NavMeshAgent agent; // 0x10
		public Vector3 position; // 0x18
		public Quaternion rotation; // 0x24

		// Constructors
		public AgentInfo(); // 0x0000000180373240-0x0000000180373250
	}

	// Constructors
	public Grasshoppers(); // 0x0000000180684620-0x00000001806846C0

	// Methods
	public override void MStart(); // 0x0000000180683F30-0x00000001806841C0
	public override void MUpdate(); // 0x00000001806841C0-0x00000001806843F0
	private void SetDestination(AgentInfo inAgentInfo); // 0x0000000180684460-0x0000000180684620
	private void OnDrawGizmos(); // 0x00000001806843F0-0x0000000180684460
	private bool GetValidSpawn(AgentInfo inAgentInfo); // 0x0000000180683CA0-0x0000000180683F30
}

