using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkers
{
    public class Game
    {
        const char w = 'W'; //Переменная означающая белую фишку
        const char b = 'B'; //Переменная означающая черную фишку
        //Переменные для ведения подсчета съеденных фишек
        public int WhiteScore = 0;
        public int BlackScore = 0;
        //Строки с названием заголовков
        const string columnsName = "ABCDEFGH";
        const string rowsName = "12345678";
        public char CurrentPlayer = 'w'; //Задаем начального игрока
        char[,] map;

        bool IsMoving = false;

        //Создание начальной карты
        public void CreateMap()
        {
            map = new char[8, 8] {
                { ' ',w,' ',w,' ',w,' ',w },
                { w,' ',w,' ',w,' ',w,' ' },
                { ' ',w,' ',w,' ',w,' ',w },
                { ' ',' ',' ',' ',' ',' ',' ',' ' },
                { ' ',' ',' ',' ',' ',' ',' ',' ' },
                { b,' ',b,' ',b,' ',b,' ' },
                { ' ',b,' ',b,' ',b,' ',b },
                { b,' ',b,' ',b,' ',b,' ' }
            };
        }

        //Перезагрузка карты в datagridview
        public void ReloadMap(DataGridView dgv)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    dgv.Rows[i].Cells[j].Value = map[i, j];
                }
            }
        }

        //Заполняем заголовки в datagridview
        public void Headers(DataGridView dgv)
        {
            for(int i = 0; i < 8; i++)
            {
                dgv.Columns[i].HeaderText = columnsName[i].ToString();
                dgv.Rows[i].HeaderCell.Value = rowsName[i].ToString();
            }
        }


        public void SelectedCell(DataGridView dgv, TextBox FromX, TextBox FromY, TextBox ToX,TextBox ToY)
        {
            //Записываем координаты выбранной клетки в переменные
            int ColumnId = dgv.CurrentCell.ColumnIndex;
            int RowId = dgv.CurrentCell.RowIndex;
            //Проверка на перемещение или выбор шашки
            if (IsMoving == false)
            {
                //Проверка на выбор поля без шашки
                if (dgv.CurrentCell.Value == " ")
                {
                    return;
                }
                //Проверка на шашку текущего игрока
                else if (CurrentPlayer == 'w' & map[RowId,ColumnId] != w)
                {
                    MessageBox.Show("Сейчас ход белых");
                    return;
                }
                else if (CurrentPlayer == 'b' &map[RowId, ColumnId] != b)
                {
                    MessageBox.Show("Сейчас ход черных");
                    return;

                }
                //Если прошлые проверки были пройденны записываем координаты шашки в textbox
                else
                {
                    FromX.Text = columnsName[ColumnId].ToString();
                    FromY.Text = rowsName[RowId].ToString();
                    IsMoving = true;
                }
            }
            else
            {   
                //Если выбранная клетка равна ранее выбранной шашке, то выбор этой шашки снимается
                if (FromX.Text == columnsName[ColumnId].ToString() & FromY.Text == rowsName[RowId].ToString())
                {
                    IsMoving = false;
                    FromX.Text = "";
                    FromY.Text = "";
                    ToX.Text = "";
                    ToY.Text = "";
                    return;
                }
                else
                {
                    ToX.Text = columnsName[ColumnId].ToString();
                    ToY.Text = rowsName[RowId].ToString();
                    int indexToX = columnsName.IndexOf(ToX.Text);
                    int indexToY = rowsName.IndexOf(ToY.Text);
                    int indexFromX = columnsName.IndexOf(FromX.Text);
                    int indexFromY = rowsName.IndexOf(FromY.Text);

                    
                    if (CurrentPlayer == 'w')
                    {
                        //Проверка на наличие вражеской фишки в поле для перемещения
                        if(map[indexToY, indexToX] == b)
                        {
                            //Определяем координаты для перемещения фишки для поедания вражеской
                            if (indexToX == indexFromX - 1 & indexToY == indexFromY - 1)
                            {
                                ToX.Text = columnsName[ColumnId - 1].ToString();
                                ToY.Text = rowsName[RowId - 1].ToString();
                            }
                            else if (indexToX == indexFromX + 1 & indexToY == indexFromY - 1)
                            {
                                ToX.Text = columnsName[ColumnId + 1].ToString();
                                ToY.Text = rowsName[RowId - 1].ToString();
                            }
                            else if (indexToX == indexFromX - 1 & indexToY == indexFromY + 1)
                            {
                                ToX.Text = columnsName[ColumnId - 1].ToString();
                                ToY.Text = rowsName[RowId + 1].ToString();
                            }
                            else if (indexToX == indexFromX + 1 & indexToY == indexFromY + 1)
                            {
                                ToX.Text = columnsName[ColumnId + 1].ToString();
                                ToY.Text = rowsName[RowId + 1].ToString();
                            }
                            else
                            {
                                ToX.Text = "";
                                ToY.Text = "";
                            }
                            
                        }
                        else if (indexToX == indexFromX - 1 & indexToY == indexFromY + 1 | indexToX == indexFromX + 1 & indexToY == indexFromY + 1)
                        {
                            return;
                        }
                        else
                        {
                            ToX.Text = "";
                            ToY.Text = "";
                            return;
                        }
                    }
                    else if(CurrentPlayer == 'b')
                    {
                        if (map[indexToY, indexToX] == w)
                        {
                            if (indexToX == indexFromX - 1 & indexToY == indexFromY - 1)
                            {
                                ToX.Text = columnsName[ColumnId - 1].ToString();
                                ToY.Text = rowsName[RowId - 1].ToString();
                            }
                            else if (indexToX == indexFromX + 1 & indexToY == indexFromY - 1)
                            {
                                ToX.Text = columnsName[ColumnId + 1].ToString();
                                ToY.Text = rowsName[RowId - 1].ToString();
                            }
                            else if (indexToX == indexFromX - 1 & indexToY == indexFromY + 1)
                            {
                                ToX.Text = columnsName[ColumnId - 1].ToString();
                                ToY.Text = rowsName[RowId + 1].ToString();
                            }
                            else if (indexToX == indexFromX + 1 & indexToY == indexFromY + 1)
                            {
                                ToX.Text = columnsName[ColumnId + 1].ToString();
                                ToY.Text = rowsName[RowId + 1].ToString();
                            }
                            else
                            {
                                ToX.Text = "";
                                ToY.Text = "";
                            }
                        }

                        else if (indexToX == indexFromX - 1 & indexToY == indexFromY - 1 | indexToX == indexFromX + 1 & indexToY == indexFromY - 1)
                        {
                            return;
                        }
                        
                        else
                        {
                            ToX.Text = "";
                            ToY.Text = "";
                            return;
                        }
                        
                    }
                }
            }
        }

        //Метод описывающий перемещение шашки по выбранным координатам
        public void CheckersMove(DataGridView dgv, TextBox FromX, TextBox FromY, TextBox ToX, TextBox ToY, Label label)
        {
            int indexToX = columnsName.IndexOf(ToX.Text);
            int indexToY = rowsName.IndexOf(ToY.Text);
            int indexFromX = columnsName.IndexOf(FromX.Text);
            int indexFromY = rowsName.IndexOf(FromY.Text);
            //Проверяем наличие выбранных ранее координат
            if(ToX.Text == "" | ToY.Text == "" | FromX.Text =="" | FromY.Text == "")
            {
                return;
            }
            //Проверяем есть ли в клетке шашки
            if(map[indexToY, indexToX] == ' ')
            {
                //Убираем шашку из старой клетки
                map[indexFromY, indexFromX] = ' ';
                //Проверка на текущего игрока
                if (CurrentPlayer == 'w')
                {
                    //Проверка на ход с целью поедания чужой шашки
                    if(indexToY - indexFromY == 2)
                    {
                        if(indexToX - indexFromX == 2)
                        {
                            map[indexToY-1, indexToX-1] = ' ';
                            WhiteScore++;
                        }
                        else
                        {
                            map[indexToY - 1, indexToX + 1] = ' ';
                            WhiteScore++;
                        }
                    }
                    else if (indexToY - indexFromY == -2)
                    {
                        if (indexToX - indexFromX == 2)
                        {
                            map[indexToY + 1, indexToX - 1] = ' ';
                            WhiteScore++;
                        }
                        else
                        {
                            map[indexToY + 1, indexToX + 1] = ' ';
                            WhiteScore++;
                        }
                    }
                    //Перемещаем шашку
                    map[indexToY, indexToX] = w;
                    label.Text = "Ход черных";
                    //Перезагружаем карту
                    ReloadMap(dgv);
                }
                else if (CurrentPlayer == 'b')
                {
                    if (indexToY - indexFromY == -2)
                    {
                        if (indexToX - indexFromX == 2)
                        {
                            map[indexToY + 1, indexToX - 1] = ' ';
                            BlackScore++;
                        }
                        else
                        {
                            map[indexToY + 1, indexToX + 1] = ' ';
                            BlackScore++;
                        }
                    }
                    else if(indexToY - indexFromY == 2)
                    {
                        if (indexToX - indexFromX == 2)
                        {
                            map[indexToY - 1, indexToX - 1] = ' ';
                            BlackScore++;
                        }
                        else
                        {
                            map[indexToY - 1, indexToX + 1] = ' ';
                            BlackScore++;
                        }
                    }
                    map[indexToY, indexToX] = b;
                    label.Text = "Ход белых";
                    ReloadMap(dgv);
                }
                //Ставим режим выбора шашки
                IsMoving = false;
                
                //Очищаем выбранные координаты
                ToX.Text = "";
                ToY.Text = "";
                FromX.Text = "";
                FromY.Text = "";

                //Смена текущего игрока
                if (CurrentPlayer == 'w')
                {
                    CurrentPlayer = 'b';
                }
                else
                {
                    CurrentPlayer = 'w';
                }
                return;
            }
            //Если в клетке уже стоит шашка показываем сообщение
            else
            {
                MessageBox.Show("В данной клетке уже есть фишка");
                IsMoving = false;

                ToX.Text = "";
                ToY.Text = "";
                FromX.Text = "";
                FromY.Text = "";

            }
           //Проверяем количество съеденных шашек для выявления победителя
            if(WhiteScore == 12)
            {
                MessageBox.Show("Победа белых!");
            }
            else if  (BlackScore == 12)
            {
                MessageBox.Show("Победа черных!");
            }
            
        }

}
}
