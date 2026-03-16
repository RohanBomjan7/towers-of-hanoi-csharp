///
/// Project: Homework 1 - Tower of Hanoi
/// Author: 
///
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;


namespace KSU.CIS300.TowerOfHanoi
{
    /// <summary>
    /// u
    /// </summary>
    public partial class UserInterface : Form
    {
        /// <summary>
        /// h
        /// </summary>
        public FlowLayoutPanel PegAPanel => pegA;
        /// <summary>
        /// p
        /// </summary>
        public FlowLayoutPanel PegBPanel => pegB;
        /// <summary>
        /// v
        /// </summary>
        public FlowLayoutPanel PegCPanel => pegC;
        /// <summary>
        /// g
        /// </summary>
        public int Moves { get; private set; } 
        /// <summary>
        /// Tracks the number of moves made
        /// </summary>
        public bool TestMode { get; set; } 
        /// <summary>
        /// Determines if the program is in test mode
        /// </summary>
        public Stack<int> PegA { get; set; } 
        /// <summary>
        /// Stack for Peg A
        /// </summary>
        public Stack<int> PegB { get; set; } 
        /// <summary>
        /// Stack for Peg B
        /// </summary>
        public Stack<int> PegC { get; set; } 
        /// <summary>
        /// Stack for Peg C
        /// </summary>
        private int _discCount; // Stores the number of discs

        /// <summary>
        /// UI Components
        /// </summary>
        private NumericUpDown numDiscCount, numSolveSpeed; 
        /// <summary>
        /// Controls for disc count and solving speed
        /// </summary>
        private Label lblMoves; 
        /// <summary>
        /// Displays the number of moves
        /// </summary>
        private FlowLayoutPanel pegA, pegB, pegC; 
        /// <summary>
        /// Panels representing the pegs
        /// </summary>
        private Button btnNew, btnSolve; 
        
        /// Buttons for new puzzle and solving
        /// <summary>
        /// Initializes a new puzzle with the specified number of discs.
        /// </summary>
        public void NewPuzzle(int count)
        {
            Moves = 0;
            lblMoves.Text = "0";
            _discCount = count;
            PegA = new Stack<int>();
            PegB = new Stack<int>();
            PegC = new Stack<int>();
            CleanPanel(pegA);
            CleanPanel(pegB);
            CleanPanel(pegC);
            for (int i = count; i > 0; i--)
            {
                PegA.Push(i);
                DrawDisc(i, pegA);
            }
        }

        /// <summary>
        /// Draws a disc and adds it to the specified panel.
        /// </summary>
        private void DrawDisc(int number, FlowLayoutPanel panel)
        {
            Label disc = new Label
            {
                Width = (int)(panel.Width / (_discCount - number + 1.25)),
                Height = 20,
                BackColor = number % 2 == 0 ? System.Drawing.Color.Red : System.Drawing.Color.Gray,
                Text = number.ToString(),
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            };
            panel.Controls.Add(disc);
        }

        /// <summary>
        /// Clears all controls from the specified panel.
        /// </summary>
        private void CleanPanel(FlowLayoutPanel panel)
        {
            while (panel.Controls.Count > 0)
            {
                Control control = panel.Controls[0];
                panel.Controls.Remove(control);
                control.Dispose();
            }
        }

        /// <summary>
        /// Checks if a move is valid.
        /// </summary>
        public bool CheckMove(Stack<int> from, Stack<int> to)
        {
            return from.Count > 0 && (to.Count == 0 || from.Peek() < to.Peek());
        }

        /// <summary>
        /// Moves a disc from one stack to another.
        /// </summary>
        public bool MoveDisc(Stack<int> from, Stack<int> to, FlowLayoutPanel fromPanel, FlowLayoutPanel toPanel)
        {
            if (!CheckMove(from, to)) return false;
            int disc = from.Pop();
            to.Push(disc);
            UpdatePanels();
            Moves++;
            lblMoves.Text = Moves.ToString();
            return true;
        }

        /// <summary>
        /// Updates the peg panels to reflect the stacks.
        /// </summary>
        private void UpdatePanels()
        {
            UpdatePanelHelper(pegA, PegA);
            UpdatePanelHelper(pegB, PegB);
            UpdatePanelHelper(pegC, PegC);
        }

        /// <summary>
        /// Updates a specific panel based on the corresponding stack.
        /// </summary>
        private void UpdatePanelHelper(FlowLayoutPanel panel, Stack<int> stack)
        {
            if (panel.Controls.Count != stack.Count)
            {
                CleanPanel(panel);
                foreach (int disc in stack)
                    DrawDisc(disc, panel);
            }
            panel.Update();
        }

        /// <summary>
        /// Moves a disc between two stacks.
        /// </summary>
        public void MoveEither(Stack<int> x, Stack<int> y, FlowLayoutPanel xPanel, FlowLayoutPanel yPanel)
        {
            if (!MoveDisc(x, y, xPanel, yPanel))
                MoveDisc(y, x, yPanel, xPanel);
        }

        /// <summary>
        /// Solves the Tower of Hanoi puzzle automatically.
        /// </summary>
        public void Solve(Stack<int> x, Stack<int> y, int delay)
        {
            while (PegC.Count != _discCount)
            {
                MoveEither(PegA, x, pegA, pegB);
                Thread.Sleep(delay);
                MoveEither(PegA, y, pegA, pegC);
                Thread.Sleep(delay);
                MoveEither(PegB, PegC, pegB, pegC);
                Thread.Sleep(delay);
            }
        }
        /// <summary>
        /// gcgc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonNewPuzzle_Click(object sender, EventArgs e)
        {
            NewPuzzle((int)numDiscCount.Value);
        }

        /// <summary>
        /// Event handler for solving the puzzle automatically.
        /// </summary>
        private void ButtonSolve_Click(object sender, EventArgs e)
        {
            int delay = (int)numSolveSpeed.Value;
            if (_discCount % 2 == 0)
                Solve(PegB, PegC, delay);
            else
                Solve(PegC, PegB, delay);
        }

        /// <summary>
        /// Checks if the puzzle is solved and displays a message.
        /// </summary>
        private void FlowLayoutPanelPegC_ControlAdded(object sender, ControlEventArgs e)
        {
            if (PegC.Count == _discCount && PegA.Count == 0 && PegB.Count == 0)
            {
                int optimalMoves = (int)Math.Pow(2, _discCount) - 1;
                string message = Moves == optimalMoves ? "Congratulations! You solved it optimally!" : "You solved it! Try again for optimal moves!";
                if (!TestMode) MessageBox.Show(message);
            }
        }
    }
}
