/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public abstract class QRoutineBehaviour : ManagedBehaviour // TypeDefIndex: 11249
{
	// Fields
	private static QRoutineGroup _defaultParentGroup; // 0x00
	private QRoutineGroup _parentGroup; // 0x50
	private QRoutineGroup _behaviourGroup; // 0x58

	// Properties
	private static QRoutineGroup DefaultParentGroup { get; } // 0x0000000180A2CAA0-0x0000000180A2CC60 
	protected QRoutineGroup ParentGroup { get; } // 0x0000000180A2CD70-0x0000000180A2CDA0 
	protected QRoutineGroup BehaviourGroup { get; } // 0x0000000180A2CD30-0x0000000180A2CD70 

	// Constructors
	protected QRoutineBehaviour(); // 0x0000000180A2CCD0-0x0000000180A2CD30

	// Methods
	public override void MOnEnable(); // 0x0000000180A2CA80-0x0000000180A2CAA0
	public override void MOnDisable(); // 0x0000000180A2CA10-0x0000000180A2CA80
	private void InitBehaviourGroup(); // 0x0000000180A2C7D0-0x0000000180A2CA10
	private void DeinitBehaviourGroup(); // 0x0000000180A2C770-0x0000000180A2C7D0
	public QRoutine StartQRoutine(IEnumerator inRoutine, Action<QRoutine> inFinishedAction = null); // 0x0000000180A2CC60-0x0000000180A2CCD0
	public virtual QRoutineGroup OverrideParentGroup(); // 0x0000000180A2CAA0-0x0000000180A2CC60
}

