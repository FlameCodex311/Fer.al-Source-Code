/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public abstract class QRoutineBehaviour : ManagedBehaviour // TypeDefIndex: 13578
{
	// Fields
	private static QRoutineGroup _defaultParentGroup; // 0x00
	private QRoutineGroup _parentGroup; // 0x50
	private QRoutineGroup _behaviourGroup; // 0x58

	// Properties
	private static QRoutineGroup DefaultParentGroup { get; } // 0x00000001815EEEC0-0x00000001815EF080 
	protected QRoutineGroup ParentGroup { get; } // 0x00000001815EF190-0x00000001815EF1C0 
	protected QRoutineGroup BehaviourGroup { get; } // 0x00000001815EF150-0x00000001815EF190 

	// Constructors
	protected QRoutineBehaviour(); // 0x00000001815EF0F0-0x00000001815EF150

	// Methods
	public override void MOnEnable(); // 0x00000001815EEEA0-0x00000001815EEEC0
	public override void MOnDisable(); // 0x00000001815EEE30-0x00000001815EEEA0
	private void InitBehaviourGroup(); // 0x00000001815EEBE0-0x00000001815EEE30
	private void DeinitBehaviourGroup(); // 0x00000001815EEB80-0x00000001815EEBE0
	public QRoutine StartQRoutine(IEnumerator inRoutine, Action<QRoutine> inFinishedAction = null); // 0x00000001815EF080-0x00000001815EF0F0
	public virtual QRoutineGroup OverrideParentGroup(); // 0x00000001815EEEC0-0x00000001815EF080
}

