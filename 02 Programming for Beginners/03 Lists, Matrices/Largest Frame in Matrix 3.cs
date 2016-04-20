using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = GetMatrix();

            // find all max-size frames of equal elements
            List<string> validFrames = new List<string>();
            int maxSize = matrix.GetLength(0) * matrix.GetLength(1); // rows * cols
            bool foundFramesOfMaxSize = false;

            while(!foundFramesOfMaxSize) // no need to check if maxSize > 0, at least 1 element (top = bottom), (left = right) has a size of 1
            {
                // search for frames with coordinates: (top, left) & (bottom, right)
                for (int top = 0; top < matrix.GetLength(0); top++)
                {
                    for (int left = 0; left < matrix.GetLength(1); left++)
                    {
                        for (int bottom = matrix.GetLength(0) - 1; bottom >= top; bottom--)
                        {
                            for (int right = matrix.GetLength(1) - 1; right >= left; right--)
                            {
                                bool isEqualElementsFrame = IsEqualElementsFrame(matrix, top, left, bottom, right);
                                bool isFrameOfMaxSize = IsFrameOfMaxSize(matrix, top, left, bottom, right, maxSize);
                                if (isEqualElementsFrame && isFrameOfMaxSize)
                                {
                                    validFrames.Add(GetFrameDimensions(top, left, bottom, right));
                                    foundFramesOfMaxSize = true;
                                }
                            }
                        }
                    }
                }
                // if frames of max size not found => reduce max size by 1 (1 element size in matrix) and search again
                maxSize--; 
            }
            // print list of all frames of max size and equal elements (in ascending order)
            validFrames.Sort();
            Console.WriteLine(string.Join(", ", validFrames));
        }

        static string GetFrameDimensions(int top, int left, int bottom, int right)
        {
            int frameWidth = right - left + 1;
            int frameHeight = bottom - top + 1;
            string frame = string.Join("x", frameHeight, frameWidth);
            return frame;
        }

        static bool IsFrameOfMaxSize(int[,] matrix, int top, int left, int bottom, int right, int maxSize)
        {
            int frameWidth = right - left + 1;
            int frameHeight = bottom - top + 1;
            int frameSize = frameHeight * frameWidth;
            return frameSize == maxSize;
        }

        static bool IsEqualElementsFrame(int[,] matrix, int top, int left, int bottom, int right)
        {
            int currentElement = matrix[top, left];
            for (int col = left; col <= right; col++) // check elements on top/ bottom row in frame
            {
                if (currentElement != matrix[top, col] ||
                    currentElement != matrix[bottom, col])
                    return false;
            }
            for (int row = top; row <= bottom; row++) // check elements on left/ right col in frame
            {
                if (currentElement != matrix[row, left] ||
                    currentElement != matrix[row, right])
                    return false;
            }           
            return true;
        }

        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        static int[,] GetMatrix()
        {
            int[] matrixDimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = matrixDimensions[0];
            int cols = matrixDimensions[1];
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                int[] elements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = elements[col];
                }
            }
            return matrix;
        }
    }
}
