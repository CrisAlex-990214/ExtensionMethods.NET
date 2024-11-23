namespace ExtensionMethods.NET
{
    public static class LINQExtensions
    {
        /// <summary>
        /// Sort list by created date
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static IEnumerable<T> OrderByCreatedDate<T>(this IEnumerable<T> list)
        {
            return list.OrderByDescending(x => typeof(T).GetProperty("CreatedDate").GetValue(x, null));
        }

        public static IEnumerable<T> OrderBy<T>(this IEnumerable<T> list) => OrderByCreatedDate(list);
    }
}
