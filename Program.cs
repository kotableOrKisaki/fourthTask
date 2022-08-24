using System;

namespace fourthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int imagesInRow = 3;
            int totalAlbumImages = 52;
            int filledRowsCount;
            int overageImages;

            filledRowsCount = totalAlbumImages / imagesInRow;
            overageImages = totalAlbumImages % imagesInRow;

            Console.WriteLine("Полностью заполненных картинками рядов: {0}", filledRowsCount);
            Console.WriteLine("Картинок сверх меры: {0}", overageImages);
        }
    }
}
