namespace ProyectoFinal.Models.Data.Repositories
{
    public class LotteryCardRepository : ILotteryCardRepository
    {
        private readonly List<LotteryCard> _lotteryCards = new List<LotteryCard>();
        public Random random = new Random(DateTime.Now.Millisecond);
        private int _count = 0;

        public IEnumerable<LotteryCard> GetAll()
        {
            return _lotteryCards;
        }

        public LotteryCard GetOrCreateLotteryCard(int? id)
        {
            if (id.HasValue)
            {
                return _lotteryCards[id.Value];
            }

            var createdId = CreateLotteryCard();
            PutSpacesLotteryCard(_lotteryCards[createdId - 1]);
            return _lotteryCards[createdId - 1];
        }

        #region PRIVATE METHODS
        private int CreateLotteryCard()
        {
            var random = new Random();
            var lotteryCard = new LotteryCard();

            lotteryCard.Id = ++_count;

            GenerateCard(random, lotteryCard);

            _lotteryCards.Add(lotteryCard);
            return lotteryCard.Id;
        }

        private void GenerateCard(Random random, LotteryCard lotteryCard)
        {
            for (int c = 0; c < 9; c++)
            {
                for (int f = 0; f < 3; f++)
                {
                    GenerateSquare(c, f, random, lotteryCard);
                }
            }
        }

        private void GenerateSquare(int col, int fila, Random random, LotteryCard lotteryCard)
        {
            int newNumber = 0;
            bool isNew = false;
            while (!isNew)
            {
                newNumber = col switch
                {
                    0 => random.Next(1, 10),                    //columna 1
                    8 => random.Next(80, 91),                   //columna 9
                    _ => random.Next(col * 10, col * 10 + 10)   //80 al 90
                };

                // si no encontro repetidos isNew sera verdadero y saldra del while
                isNew = SearchForRepeatedOnes(lotteryCard, col, newNumber);
            }

            lotteryCard.Matrix[fila, col] = newNumber;
        }

        private bool SearchForRepeatedOnes(LotteryCard lotteryCard, int col, int newNumber)
        {
            bool isNew = false;

            //buscamos si el numero existe en la columna                    
            for (int f2 = 0; f2 < 3; f2++)
            {
                if (lotteryCard.Matrix[f2, col] == newNumber)
                {
                    isNew = false;
                    break;
                }
                else
                {
                    isNew = true;
                }
            }

            return isNew;
        }
        private void PutSpacesLotteryCard(LotteryCard lotteryCard) //le pongo los espacios al carton generado
        {
            var deleted = 0;

            while (deleted < 12)
            {
                var rowToDelete = random.Next(0, 3);
                var columnToDelete = random.Next(0, 9);
                if (lotteryCard.Matrix[rowToDelete, columnToDelete] == 0)
                {
                    continue;
                }

                //contamos cuantos ceros hay en esta fila
                var zerosInRow = 0;
                for (int c = 0; c < 9; c++)
                {
                    if (lotteryCard.Matrix[rowToDelete, c] == 0)
                    {
                        zerosInRow++;
                    }
                }

                //contamos cuantos ceros hay en esta columna
                var zerosInColumn = 0;
                for (int f = 0; f < 3; f++)
                {
                    if (lotteryCard.Matrix[f, columnToDelete] == 0)
                    {
                        zerosInColumn++;
                    }
                }

                //contamos cuantos items tenemos en cada columna
                var itemsPerColumn = new int[9];
                for (int c = 0; c < 9; c++)
                {
                    for (int f = 0; f < 3; f++)
                    {
                        if (lotteryCard.Matrix[f, c] != 0)
                        {
                            itemsPerColumn[c]++;
                        }
                    }
                }

                //contamos cuantas columnas hay con un solo numero
                var columnsWithASingleNumber = 0;
                for (int c = 0; c < 9; c++)
                {
                    if (itemsPerColumn[c] == 1)
                        columnsWithASingleNumber++;


                }

                //si hay 4 ceros en la fila o 2 ceros en la columna
                //no hago nada
                if (zerosInRow == 4 || zerosInColumn == 2)
                    continue;

                //si hay 3 columnas con 1 solo numero a partir de ahora debo borrar las columnas que tiene 3 itemas
                if (columnsWithASingleNumber == 3 && itemsPerColumn[columnToDelete] != 3)
                    continue;

                // si no entro en las opciones anteriores borrar
                lotteryCard.Matrix[rowToDelete, columnToDelete] = 0;
                deleted++;

            }
        }
        #endregion
    }
}
