using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisGame
{
    public interface IShapeFactory
    {
        /// <summary>
        /// Deploys a new shape onto the board.
        /// </summary>
        /// <returns>Randomly generated shape.</returns>
        IShape DeployNewShape();
    }
}
