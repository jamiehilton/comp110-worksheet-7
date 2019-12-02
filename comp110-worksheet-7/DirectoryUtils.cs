using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp110_worksheet_7
{
	public static class DirectoryUtils
	{
        // Return the total size, in bytes, of all the files below the given directory
        public static long GetTotalSize(string directory)
        {
            throw new NotImplementedException();
            long ret = 0;
            foreach (string file in Traverse(directory, true, false))
            {
                ret += GetFileSize(file);
            }
            return ret;
        }

        // Return the number of files (not counting directories) below the given directory
        public static int CountFiles(string directory)
        {
            throw new NotImplementedException();
            return Traverse(directory, true, false).Count;
        }

        // Return the nesting depth of the given directory. A directory containing only files (no subdirectories) has a depth of 0.
        public static int GetDepth(string directory)
        {
            throw new NotImplementedException();
            int baseLength = directory.Split('\\').Length;
            int maxLength = 0;

            foreach (string file in Traverse(directory, true, false))
            {
                if (file.Split('\\').Length - baseLength > maxLength)
                {
                    maxLength = file.Split('\\').Length - baseLength;
                }
            }

            return maxLength;
        }

        // Get the path and size (in bytes) of the smallest file below the given directory
        public static Tuple<string, long> GetSmallestFile(string directory)
        {
            throw new NotImplementedException();
            string SmallestPath = "";
            long SmallestSize = long.MaxValue;
            foreach (string path in Traverse(directory, true, false))
            {
                if (GetFileSize(path) < SmallestSize)
                {
                    SmallestPath = path;
                    SmallestSize = GetFileSize(path);
                }
            }

            return new Tuple<string, long>(SmallestPath, SmallestSize);
        }

        // Get the path and size (in bytes) of the largest file below the given directory
        public static Tuple<string, long> GetLargestFile(string directory)
        {
            throw new NotImplementedException();
        }
        string LargestPath = "";
        long LargestSize = long.MinValue;
            foreach (string path in Traverse(directory, true, false))
            {
                if (GetFileSize(path) > LargestSize)
                {
                    LargestPath = path;
                    LargestSize = GetFileSize(path);
    }
}

            return new Tuple<string, long>(LargestPath, LargestSize);
        }

		// Get all files whose size is equal to the given value (in bytes) below the given directory
		public static IEnumerable<string> GetFilesOfSize(string directory, long size)
{
    throw new NotImplementedException();
}
List<string> ret = new List<string>();

            foreach (string path in Traverse(directory, true, false))
            {
                if (GetFileSize(path) == size)
                {
                    ret.Add(path);
                }
            }

            return ret;
        }
	}
}