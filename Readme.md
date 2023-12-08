<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128654161/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T201415)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WPF Tiles - Create Windows-inspired Tile Layout

This example uses the [WPF TileLayoutControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.LayoutControl.TileLayoutControl) to create Windows-10 inspired tile layout. The Tile Layout Control is bound to a collection of `Agent` objects.

![WPF Tile Layout Control, DevExpress](https://raw.githubusercontent.com/DevExpress-Examples/how-to-create-a-tile-layout-control-t201415/22.2.2%2B/i/wpf-tile-control-devexpress.png)

The Tile Layout Control displays static and live tiles (`tile5`). Live tiles change their content in an infinite loop with an animation effect that follows a content change.

```xaml
<dxlc:TileLayoutControl Background="{x:Null}" Name="tileLayoutControl1">
    <dxlc:Tile Header="System Information" Name="tile1">
        <Image Name="image1" Stretch="None" Source="Images/System.png" />
    </dxlc:Tile>
    ...
    <dxlc:Tile Name="tile5" Size="Large"
                HorizontalHeaderAlignment="Center" Background="#FF666666"
                ContentSource="{Binding Agents}" ContentChangeInterval="00:00:03" AnimateContentChange="True">
        <dxlc:Tile.ContentTemplate>
            <DataTemplate>
                <Grid>
                    <TextBlock Text="{Binding AgentName}" HorizontalAlignment="Left" VerticalAlignment="Bottom"/>
                    <Image Source="{Binding PhotoSource}" Stretch="None" HorizontalAlignment="Right" VerticalAlignment="Top" />
                </Grid>
            </DataTemplate>
        </dxlc:Tile.ContentTemplate>
    </dxlc:Tile>
</dxlc:TileLayoutControl>
```


## Files to Review

* [MainWindow.xaml](./CS/WpfApplication12/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfApplication12/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/WpfApplication12/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WpfApplication12/MainWindow.xaml.vb))
