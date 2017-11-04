using System;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.TextEngine
{
    public class TextController : MonoBehaviour
    {
        //The text controller we will use to display text to the player.
        public Text textControl;

        //Stores the progression of the state that the current play through is in.
        private Static.Enums.Cell.State _currentCellState = Static.Enums.Cell.State.cell;

        // Use this for initialization
        private void Start()
        {
            textControl.supportRichText = true;
            textControl.fontSize = 20;
        }

        // Update is called once per frame
        private void Update()
        {
            print(_currentCellState.state);
            Handle_State();
        }

        private void Handle_State()
        {
            textControl.text = _currentCellState.text;
            foreach (var nextState in _currentCellState.next_states)
            {
                Static.Enums.Cell.State nextCellState;
                switch (nextState)
                {
                    case Static.Enums.Cell.States.Cell:
                        nextCellState = Static.Enums.Cell.State.cell;
                        break;
                    case Static.Enums.Cell.States.Mirror:
                        nextCellState = Static.Enums.Cell.State.mirror;
                        break;
                    case Static.Enums.Cell.States.Sheets_0:
                        nextCellState = Static.Enums.Cell.State.sheets_0;
                        break;
                    case Static.Enums.Cell.States.Sheets_1:
                        nextCellState = Static.Enums.Cell.State.sheets_1;
                        break;
                    case Static.Enums.Cell.States.Lock_0:
                        nextCellState = Static.Enums.Cell.State.lock_0;
                        break;
                    case Static.Enums.Cell.States.Lock_1:
                        nextCellState = Static.Enums.Cell.State.lock_1;
                        break;
                    case Static.Enums.Cell.States.Cell_Mirror:
                        nextCellState = Static.Enums.Cell.State.cell_mirror;
                        break;
                    case Static.Enums.Cell.States.Freedom:
                        nextCellState = Static.Enums.Cell.State.freedom;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                if (!nextCellState.keyCodes.Any(nextKeyCode => Input.GetKeyDown(nextKeyCode))) continue;
                _currentCellState = nextCellState;
                break;
            }
        }
    }
}
