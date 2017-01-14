using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.IO;

namespace SgfReader
{
    class Game
    {
        /// <param name="path">Путь к открываемому SGF файлу</param>
        public Game(string path)
        {
            SGF = new FileStream(path, FileMode.Open);
        }

        // Номер текущего хода
        [DefaultValue(0)]
        public int Move { get; }

        // Текущая позиция на доске
        public int[,] Position { get; }


        // Поток файла партии
        private FileStream SGF;
    }
}
