using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkers
{
    public partial class Form1 : Form
    {
        //Создаем экземпляр класса
        Game game = new Game();        

        public Form1()
        {
            InitializeComponent();

        }
        //Вызываем метод перемещенния шашки и перезаписываем счет
        private void button1_Click(object sender, EventArgs e)
        {
            game.CheckersMove(dgvMap, fromX, fromY, ToX, ToY, lblPlayer);
            WhiteScore.Text = game.WhiteScore.ToString();
            BlackScore.Text = game.BlackScore.ToString();
        }
        
        //Задаем начальные свойства для карты и загружаем ее
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvMap.ColumnCount = 8;
            dgvMap.RowCount = 8;
            game.CreateMap();
            dgvMap.AutoResizeRows();
            dgvMap.AutoResizeColumns();
            dgvMap.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvMap.RowHeadersWidth = 50;
            foreach (DataGridViewColumn column in dgvMap.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            game.Headers(dgvMap);

            game.ReloadMap(dgvMap);
            
        }
        //Вызываем метод для обработки клика по карте
        private void dgvMap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            game.SelectedCell(dgvMap, fromX, fromY,ToX,ToY);
        }

        //Перезагружаем игру
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            game.CreateMap();
            game.ReloadMap(dgvMap);

            game.WhiteScore = 0;
            game.BlackScore = 0;
            game.CurrentPlayer = 'w';

            WhiteScore.Text = game.WhiteScore.ToString();
            BlackScore.Text = game.BlackScore.ToString();
        }
    }
}
