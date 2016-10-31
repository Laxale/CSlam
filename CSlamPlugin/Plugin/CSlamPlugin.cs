// Created by Laxale 31.10.2016
//
//


using System;


namespace CSlamPlugin.Plugin 
{
    using Freengy.Base;
    using Freengy.GamePlugin;
    using Freengy.GamePlugin.Interfaces;


    /// <summary>
    /// <see cref="IGamePlugin"/> implementer
    /// </summary>
    public class CSlamPlugin : IGamePlugin 
    {
        public Type ExportedViewType { get; }

        public string Name { get; }

        public string DisplayedName { get; }

        public Guid Id { get; }

        public string GameIconSource { get; }
    }
}