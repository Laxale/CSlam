// Created by Laxale 31.10.2016
//
//


namespace CSlam.Plugin 
{
    using System;

    using CSlam.Views;

    using Freengy.GamePlugin.Interfaces;


    /// <summary>
    /// <see cref="IGamePlugin"/> implementer
    /// </summary>
    public class CSlamPlugin : IGamePlugin 
    {
        public Type ExportedViewType { get; } = typeof(MainView);

        public string Name => "Sea Slam!";

        public string DisplayedName => "Sea-slaming mosh";

        public Guid Id { get; } = Guid.NewGuid();

        public string GameIconSource { get; } = null;
    }
}