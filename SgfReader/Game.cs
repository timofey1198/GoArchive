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
            StreamReader reader = new StreamReader(SGF);

            string settings1; // Первая строка настроек файла
            string settings2; // Вторая строка
            string settings3; // Третья строка
            settings1 = reader.ReadLine();
            settings2 = reader.ReadLine();
            settings3 = reader.ReadLine();
            Settings = settings1 + settings2 + settings3;

            string move;
            char chX;
            char chY;
            int x;
            int y;
            int parent = 0;
            int now = 1;
            GameTree = new Dictionary<int, List<int>>();
            GameTree.Add(0, new List<int>());
            GameTree[0].Add(-1); // x
            GameTree[0].Add(-1); // y
            GameTree[0].Add(-1); // parent
            do
            {
                move = reader.ReadLine();
                if (move != null)
                {
                    if (move[0] == ';' && move.Length > 5)
                    {
                        chX = move[3];
                        chY = move[4];
                        x = ToCoordinate(chX);
                        y = ToCoordinate(chY);

                        GameTree.Add(parent + 1, new List<int>());
                        GameTree[now].Add(x);
                        GameTree[now].Add(y);
                        GameTree[now].Add(parent);
                        GameTree[parent].Add(now);

                        parent++;
                    }
                }
                now++;
            } while (move != null);
        }

        // Номер текущего хода
        [DefaultValue(0)]
        public int Move { get; set; }

        // Текущая позиция на доске
        public int[,] Position { get; }

        // Полная запись дерева партии
        // {0:[-1, -1, -1, ...], 1:[X, Y, parentsKey, childsKey1, ...]}
        public Dictionary<int,List<int>> GameTree { get; set; }


        // Поток файла партии
        private FileStream SGF;

        private string Settings;

        private static int ToCoordinate(char x)
        {
            int coord = -1;
            switch (x)
            {
                case 'a': coord = 1; break;
                case 'b': coord = 2; break;
                case 'c': coord = 3; break;
                case 'd': coord = 4; break;
                case 'e': coord = 5; break;
                case 'f': coord = 6; break;
                case 'g': coord = 7; break;
                case 'h': coord = 8; break;
                case 'i': coord = 9; break;
            }
            return coord;
        }
    }
}