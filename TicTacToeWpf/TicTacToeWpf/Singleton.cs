using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeWpf
{
    public class Singleton
    {
        // True = X; False = O;
        public static bool cellState { get; set; } = true;

        public static List<Cell> matrix;
    }
}
