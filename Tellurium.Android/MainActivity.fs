﻿namespace Tellurium.Android
open Android.App
open Android.Content.PM
open Avalonia.Android
open Avalonia

[<Activity(Theme = "@style/MyTheme.NoActionBar", Icon = "@drawable/icon", LaunchMode = LaunchMode.SingleInstance, ConfigurationChanges = (ConfigChanges.Orientation ||| ConfigChanges.ScreenSize))>]
type MainActivity() =
    inherit AvaloniaMainActivity()