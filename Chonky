namespace Algorithms{

  public class Chonky{
        /// <summary>
        /// Splits a list into smaller lists by chunk size
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">List</param>
        /// <param name="chunkSize"></param>
        /// <returns></returns>
        public static List<List<T>> ChunkBy<T>(this List<T> source, int chunkSize)
        {
            return source
                .Select((x, i) => new { Index = i, Value = x })
                .GroupBy(x => x.Index / chunkSize)
                .Select(x => x.Select(v => v.Value).ToList())
                .ToList();
        }
     }
 }
