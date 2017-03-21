﻿namespace GMaster.Views.Commands
{
    using System.Diagnostics;
    using Windows.UI.Xaml.Controls;

    public class OpenSplitViewCommand : AbstractSimpleParameterCommand
    {
        public override void Execute(object parameter)
        {
            var model = parameter as MainPageModel;
            Debug.Assert(model != null, "splitview != null");
            model.IsMainMenuOpened = !model.IsMainMenuOpened;
        }
    }
}