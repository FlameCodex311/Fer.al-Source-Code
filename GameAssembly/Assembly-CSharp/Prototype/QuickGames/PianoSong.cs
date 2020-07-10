/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype.QuickGames
{
	public class PianoSong // TypeDefIndex: 16200
	{
		// Fields
		public int bpm; // 0x10
		public int beat_unit; // 0x14
		public int beats_per_bar; // 0x18
		public int numBars; // 0x1C
		public Bar[] bars; // 0x20
	
		// Nested types
		public enum Pitch // TypeDefIndex: 16201
		{
			NONE = 0,
			C = 1,
			C_SHARP = 2,
			D = 3,
			D_SHARP = 4,
			E = 5,
			F = 6,
			F_SHARP = 7,
			G = 8,
			G_SHARP = 9,
			A = 10,
			A_SHARP = 11,
			B = 12
		}
	
		public class Note // TypeDefIndex: 16202
		{
			// Fields
			public Pitch pitch; // 0x10
			public int length; // 0x14
			public int index; // 0x18
	
			// Constructors
			public Note(int l); // 0x000000018152AEA0-0x000000018152AED0
	
			// Methods
			public void Set(Pitch p, int l, int idx); // 0x000000018152AE90-0x000000018152AEA0
		}
	
		public class Beat // TypeDefIndex: 16203
		{
			// Fields
			public int number; // 0x10
			public List<Note> notes; // 0x18
	
			// Constructors
			public Beat(int n); // 0x0000000181525C10-0x0000000181525D70
	
			// Methods
			public void Add(Pitch pitch, int length, int noteIndex); // 0x0000000181525B80-0x0000000181525C10
		}
	
		public class Bar // TypeDefIndex: 16204
		{
			// Fields
			public int numBeats; // 0x10
			public Beat[] beats; // 0x18
	
			// Constructors
			public Bar(int n); // 0x0000000181525950-0x0000000181525B80
	
			// Methods
			public void Add(int beatNumber, Pitch pitch, int length, int noteIndex); // 0x0000000181525880-0x0000000181525950
		}
	
		// Constructors
		public PianoSong(int beat_unit, int beats_per_bar, int numBars, int bpm); // 0x000000018152E290-0x000000018152E3B0
	
		// Methods
		public void Add(int bar, int beat, Pitch pitch, int length, int noteIndex); // 0x000000018152E170-0x000000018152E290
	}
}
