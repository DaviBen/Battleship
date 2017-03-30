using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;
namespace Battleship
{
	/// <summary>
	/// The direction the ship can be oriented.
	/// </summary>
	public enum Direction
	{
		/// <summary>
		/// The ship is oriented left/right
		/// </summary>
		LeftRight,

		/// <summary>
		/// The ship is oriented up/down
		/// </summary>
		UpDown
	}
}
