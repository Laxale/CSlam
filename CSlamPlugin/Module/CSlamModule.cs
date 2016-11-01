// Created by Laxale 01.11.2016
//
//


namespace CSlam.Module 
{
    using CSlam.Views;

    using Prism.Modularity;

    using Freengy.GamePlugin.Helpers;

    using Settings = CSlam.Settings;


    public class CSlamModule : IModule 
    {
        public void Initialize()
        {
            var validator = new PluginSettingsValidator(Settings.Default);

            validator.EnsureMainViewIsRegistered(typeof(MainView));
        }
    }
}