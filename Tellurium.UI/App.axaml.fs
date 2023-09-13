namespace Tellurium

open Avalonia
open Avalonia.Controls.ApplicationLifetimes
open Avalonia.Markup.Xaml

open Tellurium.Views

[<Sealed>]
type public App() =
    inherit Application()

    override self.Initialize() =
        AvaloniaXamlLoader.Load self

    override self.OnFrameworkInitializationCompleted() =
        match self.ApplicationLifetime with
        | :? IClassicDesktopStyleApplicationLifetime as desktop ->
            desktop.MainWindow <- new MainWindow()
        | :? ISingleViewApplicationLifetime as singleViewPlatform ->
            singleViewPlatform.MainView <- new MainView()
        | _ -> ()

        base.OnFrameworkInitializationCompleted()
