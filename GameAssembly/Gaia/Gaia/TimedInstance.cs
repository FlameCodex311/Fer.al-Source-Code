/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia
{
	public class TimedInstance : Stopwatch // TypeDefIndex: 9096
	{
		// Fields
		public long nanosecPerTick; // 0x28
		public string m_name; // 0x30
		public int m_iterations; // 0x38
	
		// Constructors
		public TimedInstance(string name, bool start = true /* Metadata: 0x00744270 */); // 0x0000000181C03C90-0x0000000181C03D30
	
		// Methods
		public new void Start(); // 0x0000000181C03BB0-0x0000000181C03BC0
		public new void Reset(); // 0x0000000181C03BA0-0x0000000181C03BB0
		public void IncIterations(); // 0x0000000180BAF490-0x0000000180BAF4A0
		public float GetAvgMs(); // 0x0000000181C03B30-0x0000000181C03B60
		public float GetAvgS(); // 0x0000000181C03B60-0x0000000181C03BA0
		public override string ToString(); // 0x0000000181C03BC0-0x0000000181C03C90
	}
}
