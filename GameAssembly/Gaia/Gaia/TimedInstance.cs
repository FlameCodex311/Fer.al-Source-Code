/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia
{
	public class TimedInstance : Stopwatch // TypeDefIndex: 9262
	{
		// Fields
		public long nanosecPerTick; // 0x28
		public string m_name; // 0x30
		public int m_iterations; // 0x38
	
		// Constructors
		public TimedInstance(string name, bool start = true /* Metadata: 0x00778F5E */); // 0x00000001816F9970-0x00000001816F9A10
	
		// Methods
		public new void Start(); // 0x00000001816F9890-0x00000001816F98A0
		public new void Reset(); // 0x00000001816F9880-0x00000001816F9890
		public void IncIterations(); // 0x00000001816F9870-0x00000001816F9880
		public float GetAvgMs(); // 0x00000001816F9800-0x00000001816F9830
		public float GetAvgS(); // 0x00000001816F9830-0x00000001816F9870
		public override string ToString(); // 0x00000001816F98A0-0x00000001816F9970
	}
}
