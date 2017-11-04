using System.Collections.Generic;
using UnityEngine;

namespace Assets.TextEngine.Static.Enums
{
    public class Cell
    {
        public enum States
        {
            Cell,
            Mirror,
            Sheets_0,
            Sheets_1,
            Lock_0,
            Lock_1,
            Cell_Mirror,
            Freedom
        }

        public class State
        {
            public States state { get; set; }
            public List<States> next_states { get; set; }
            public List<KeyCode> keyCodes { get; set; }
            public string text { get; set; }

            /// <summary>
            /// Options:
            /// Look at the sheets
            /// Look at the mirror
            /// Look at the lock
            /// </summary>
            public static State cell = new State
            {
                state = States.Cell,
                keyCodes = new List<KeyCode> { KeyCode.R, KeyCode.P },
                text = Constants.Cell.cellText,
                next_states = new List<States> { States.Sheets_0, States.Mirror, States.Lock_0 }
            };

            /// <summary>
            /// Options:
            /// Return to Cell
            /// Take the mirror
            /// </summary>
            public static State mirror = new State
            {
                state = States.Mirror,
                keyCodes = new List<KeyCode> { KeyCode.M },
                text = Constants.Cell.mirrorText,
                next_states = new List<States> { States.Cell, States.Cell_Mirror }
            };

            /// <summary>
            /// Options:
            /// Return to the cell
            /// </summary>
            public static State sheets_0 = new State
            {
                state = States.Sheets_0,
                keyCodes = new List<KeyCode> { KeyCode.S },
                text = Constants.Cell.sheets0Text,
                next_states = new List<States> { States.Cell }
            };

            /// <summary>
            /// Options:
            /// Return to Cell (holding mirror)
            /// </summary>
            public static State sheets_1 = new State
            {
                state = States.Sheets_1,
                keyCodes = new List<KeyCode> { KeyCode.S },
                text = Constants.Cell.sheets1Text,
                next_states = new List<States> { States.Cell_Mirror }
            };

            /// <summary>
            /// Options:
            /// Return to cell
            /// </summary>
            public static State lock_0 = new State
            {
                state = States.Lock_0,
                keyCodes = new List<KeyCode> { KeyCode.L },
                text = Constants.Cell.lock0Text,
                next_states = new List<States> { States.Cell }
            };

            /// <summary>
            /// Options:
            /// Return to cell
            /// Open with the mirror
            /// </summary>
            public static State lock_1 = new State
            {
                state = States.Lock_1,
                keyCodes = new List<KeyCode> { KeyCode.L },
                text = Constants.Cell.lock1Text,
                next_states = new List<States> { States.Cell_Mirror, States.Freedom }
            };

            /// <summary>
            /// Options:
            /// Look at the sheets
            /// Look at the lock
            /// </summary>
            public static State cell_mirror = new State
            {
                state = States.Cell_Mirror,
                keyCodes = new List<KeyCode> { KeyCode.R, KeyCode.T },
                text = Constants.Cell.cellMirrorText,
                next_states = new List<States> { States.Sheets_1, States.Lock_1 }
            };

            /// <summary>
            /// Options:
            /// Restart the game
            /// </summary>
            public static State freedom = new State
            {
                state = States.Freedom,
                keyCodes = new List<KeyCode> { KeyCode.O },
                text = Constants.Cell.freedomText,
                next_states = new List<States> { States.Cell }
            };
        }
    }
}
