namespace KSU.CIS300.TowerOfHanoi
{
    partial class UserInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Constructor for UserInterface.
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
            NewPuzzle((int)numDiscCount.Value);
        }

        /// <summary>
        /// Initializes the components and event handlers.
        /// </summary>
        private void InitializeComponent()
        {
            // Initialize controls (omitted for brevity)
            // Add event handlers
            btnNew.Click += ButtonNewPuzzle_Click;
            btnSolve.Click += ButtonSolve_Click;
        }
    }
}
