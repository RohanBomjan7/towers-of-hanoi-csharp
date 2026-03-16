///
/// TestCases.cs
/// Author: Josh Weese
///
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using KSU.CIS300.TowerOfHanoi;
using System;

namespace KSU.CIS300.TowerOfHanoi.Test
{
    /// <summary>
    /// Test cases for the Tower of Hanoi program.
    /// </summary>
    [TestFixture]
    public class TestCases
    {
        /// <summary>
        /// pr
        /// </summary>
        private UserInterface _ui;

        [SetUp]
        public void Setup()
        {
            _ui = new UserInterface();
            _ui.TestMode = true;
        }

        [TearDown]
        public void Teardown()
        {
            _ui?.Dispose();
            _ui = null;
        }

        [Test]
        [Category("A CheckMove")]
        public void CheckMoveFromEmpty()
        {
            Stack<int> from = new Stack<int>();
            Stack<int> to = new Stack<int>();
            Assert.That(_ui.CheckMove(from, to), Is.False);
        }

        [Test]
        [Category("A CheckMove")]
        public void CheckMoveToEmpty()
        {
            Stack<int> from = new Stack<int>();
            from.Push(1);
            Stack<int> to = new Stack<int>();
            Assert.That(_ui.CheckMove(from, to), Is.True);
        }

        [Test]
        [Category("B Move")]
        public void MoveValid()
        {
            Stack<int> from = new Stack<int>();
            from.Push(5);
            Stack<int> to = new Stack<int>();
            to.Push(10);
            bool result = _ui.MoveDisc(from, to, _ui.PegAPanel, _ui.PegBPanel);
            Assert.That(result, Is.True);
            Assert.That(_ui.Moves, Is.EqualTo(1));
            Assert.That(from.Count, Is.EqualTo(0));
            Assert.That(to.Count, Is.EqualTo(2));
            Assert.That(to.Pop(), Is.EqualTo(5));
            Assert.That(to.Pop(), Is.EqualTo(10));
        }

        [Test]
        [Category("C MoveEither")]
        public void MoveEitherX()
        {
            Stack<int> from = new Stack<int>();
            from.Push(5);
            Stack<int> to = new Stack<int>();
            to.Push(10);
            _ui.MoveEither(from, to, _ui.PegAPanel, _ui.PegBPanel);
            Assert.That(_ui.Moves, Is.EqualTo(1));
            Assert.That(from.Count, Is.EqualTo(0));
            Assert.That(to.Count, Is.EqualTo(2));
        }

        [Test]
        [Category("D Solve")]
        ///s
        public void SolveEven()
        {
            LoadPuzzle(6);
            _ui.Solve(_ui.PegB, _ui.PegC, 0);
            Assert.That(_ui.PegA.Count, Is.EqualTo(0));
            Assert.That(_ui.PegB.Count, Is.EqualTo(0));
            Assert.That(_ui.PegC.Count, Is.EqualTo(6));
            Assert.That(_ui.Moves, Is.EqualTo(Math.Pow(2, 6) - 1));
        }
        /// <summary>
        /// loas
        /// </summary>
        /// <param name="count"></param>
        private void LoadPuzzle(int count)
        {
            _ui.NewPuzzle(count);
        }
    }
}
