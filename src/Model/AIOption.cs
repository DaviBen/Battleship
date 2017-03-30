using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
namespace BattleShip
{
	/// <summary>
	/// The different AI levels.
	/// </summary>
	public enum AIOption
	{
		/// <summary>
		/// Easy, total random shooting
		/// </summary>
		Easy,

		/// <summary>
		/// Medium, marks squares around hits
		/// </summary>
		Medium,

		/// <summary>
		/// As medium, but removes shots once it misses
		/// </summary>
		Hard
	}
}
