using System;


namespace SmallGiantGames.Core
{
    class Dependency
    {
        /// <summary>
        /// Creates mandatory dependency. Component will not be auto-published (= made available to others) until 
        /// all required dependencies are injected and (optional) post-inject method called.
        /// </summary>
        /// <typeparam name="T">type of dependency</typeparam>
        /// <param name="setter">injector function (usually setter in lambda form)</param>
        public static Dependency Required<T>(Action<T> setter)
        {
            return null;
        }

        /// <summary>
        /// Creates optional dependency. Optional dependecies will be injected as soon as they are available,
        /// however they do not affect calling post-inject method and auto-publishing.
        /// </summary>
        /// <typeparam name="T">type of dependency</typeparam>
        /// <param name="setter">injector function (usually setter in lambda form)</param>
        public static Dependency Optional<T>(Action<T> setter)
        {
            return null;
        }
    }
}
