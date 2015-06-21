using System;


namespace SmallGiantGames.Core
{
    enum PublishingType
    {
        /// <summary>
        /// Component is automatically publised (made available for injection) as soon as 
        /// all required dependecies are injected and (optional) post-inject method called.
        /// </summary>
        Automatic,
        /// <summary>
        /// Component must be manually published via call to <code>Core.Publish</code> when ready.
        /// (Optional) post-inject method will still be called as soon as all required dependecies are injected.
        /// </summary>
        Manual
    }

    /// <summary>
    /// Central registry for components.
    /// </summary>
    class Core
    {

        /// <summary>
        /// Inject specified dependencies and call (optional) init method as soon as 
        /// all required dependecies are injected.
        /// </summary>
        /// <param name="dependencies">dependecies with setter methods</param>
        /// <param name="init">optional method that will be called as soon as 
        /// all required dependecies are injected</param>
        public static void Inject(Dependency[] dependencies, Action init = null)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Register component for dependecy injection and eventual publishing.
        /// Publishing (= making available to other components) can be either automatic (after all 
        /// required depencies injected and optional post-inject method called) or manual (via explicit call to 
        /// <code>Core.Publish</code> when component is ready.
        /// </summary>
        /// <typeparam name="T">public type of component</typeparam>
        /// <param name="component">actual component object. Must be assignable to <code>T</code>.</param>
        /// <param name="publishingType">publishing automatically?</param>
        /// <param name="dependencies">dependecies with setter methods</param>
        /// <param name="init">optional method to call once all required dependecies have been injected</param>
        public static void Register<T>(Object component, PublishingType publishingType, Dependency[] dependencies = null, Action init = null)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Manually publishes given component. Component must be already registered via <code>Core.Register</code>.
        /// </summary>
        public static void Publish(Object component)
        {
            throw new System.NotImplementedException();
        }

    }
}
