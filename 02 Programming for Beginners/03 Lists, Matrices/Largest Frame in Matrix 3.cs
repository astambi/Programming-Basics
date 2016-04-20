using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Frame_in_Matrix
{
    class Largest_Frame_in_Matrix
    {
        static void Main(string[] args)
        {
            int[,] matrix = GetMatrix();

            // find all max-size frames of equal elements
            List<string> largestFrames = new List<string>();
            int maxSize = matrix.GetLength(0) * matrix.GetLength(1); // rows * cols = largest frame possible
            bool foundFramesOfMaxSize = false;

            while(!foundFramesOfMaxSize) // at least 1 element (top = bottom), (left = right) has a size of 1
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
                                bool isFrameOfMaxSize = IsFrameOfMaxSize(top, left, bottom, right, maxSize);
                                if (isEqualElementsFrame && isFrameOfMaxSize)
                                {
                                    largestFrames.Add(GetFrameDimensions(top, left, bottom, right));
                                    foundFramesOfMaxSize = true;
                                }
                            }
                        }
                    }
                } 
                maxSize--; // if frames of max size not found => reduce max size by 1 (1 element in matrix) & search again
            }
            // print (in ascending order) list of all frames having max size and equal elements
            largestFrames.Sort();
            Console.WriteLine(string.Join(", ", largestFrames));
        }

        static string GetFrameDimensions(int top, int left, int bottom, int right)
        {
            int frameWidth = right - left + 1;
            int frameHeight = bottom - top + 1;
            return string.Join("x", frameHeight, frameWidth);
        }

        static bool IsFrameOfMaxSize(int top, int left, int bottom, int right, int maxSize)
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
                    Console.Write("{0} ", matrix[row, col]);
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
                    matrix[row, col] = elements[col];
            }
            return matrix;
        }
    }
}