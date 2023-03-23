<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/297755792/20.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T933640)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WPF Data Grid - Process Frequent Data Updates

This example demonstrates three different techniques to handle frequent updates in the [GridControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl):

1. Use the [ChunkList](https://docs.devexpress.com/WPF/DevExpress.Xpf.ChunkList.ChunkList-1) collection and [optimized summaries](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl.OptimizeSummaryCalculation) to improve the speed of individual updates.
2. Wrap data update batches in `BeginDataUpdate` and `EndDataUpdate` methods calls. The `BeginDataUpdate` method locks the `GridControl`'s UI and allows you to execute multiple updates. The `EndDataUpdate` call unlocks updates and refreshes the `GridControl`. In this example, a [custom MVVM service](https://docs.devexpress.com/WPF/16920/mvvm-framework/services/how-to-create-a-custom-service) calls these methods from the view model level (**GridUpdateService**).
3. Set the [AllowLiveDataShaping](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataControlBase.AllowLiveDataShaping) property to `false` and use a collection that doesn't support notifications (for example, `List<T>`) to ignore data shaping operations when data is changed. Call the [GridControl.RefreshData](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataControlBase.RefreshData) method to display all changes in the control. In this example, a [custom behavior](https://docs.devexpress.com/WPF/17458/mvvm-framework/behaviors/how-to-create-a-custom-behavior) refreshes the `GridControl` each second.
  
The **first** technique is effective when the number of updates is much fewer than the source size. Use the [ChunkList](https://docs.devexpress.com/WPF/DevExpress.Xpf.ChunkList.ChunkList-1) only when the data source contains at least several thousand items. With smaller sources, it is more efficient to use only optimized summaries.
  
The **second** and **third** techniques are useful when updates affect a significant part of your source. `RefreshData` and `EndDataUpdate` methods refresh GridControl with its data shaping operations (sort, filter, etc.). As a result, refresh speed does not depend on how many data changes you make in one update batch. 

Refer to the following help topic for more information: [Frequent Data Updates](https://docs.devexpress.com/WPF/115836/controls-and-libraries/data-grid/performance-improvement/frequent-data-updates).

## Files to Review

### ChunkAndOptSummariesExample

* [MainWindow.xaml](./CS/ChunkAndOptSummariesExample/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/ChunkAndOptSummariesExample/MainWindow.xaml))
* [ChunkAndOptSummariesViewModel.cs](./CS/ChunkAndOptSummariesExample/ViewModel/ChunkAndOptSummariesViewModel.cs) (VB: [ChunkAndOptSummariesViewModel.vb](./VB/ChunkAndOptSummariesExample/ViewModel/ChunkAndOptSummariesViewModel.vb))

### BeginEndDataUpdateExample

* [GridUpdateService.cs](./CS/BeginEndDataUpdateExample/GridUpdateService.cs) (VB: [GridUpdateService.vb](./VB/BeginEndDataUpdateExample/GridUpdateService.vb))
* [BeginEndUpdateViewModel.cs](./CS/BeginEndDataUpdateExample/ViewModel/BeginEndUpdateViewModel.cs) (VB: [BeginEndUpdateViewModel.vb](./VB/BeginEndDataUpdateExample/ViewModel/BeginEndUpdateViewModel.vb))
* [MainWindow.xaml](./CS/BeginEndDataUpdateExample/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/BeginEndDataUpdateExample/MainWindow.xaml))

### RefreshDataExample

* [GridTimerRefreshBehavior.cs](./CS/RefreshDataExample/GridTimerRefreshBehavior.cs) (VB: [GridTimerRefreshBehavior.vb](./VB/RefreshDataExample/GridTimerRefreshBehavior.vb))
* [RefreshDataViewModel.cs](./CS/RefreshDataExample/ViewModel/RefreshDataViewModel.cs) (VB: [RefreshDataViewModel.vb](./VB/RefreshDataExample/ViewModel/RefreshDataViewModel.vb))
* [MainWindow.xaml](./CS/RefreshDataExample/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/RefreshDataExample/MainWindow.xaml))

## Documentation

* [Frequent Data Updates](https://docs.devexpress.com/WPF/115836/controls-and-libraries/data-grid/performance-improvement/frequent-data-updates)
* [ChunkList](https://docs.devexpress.com/WPF/DevExpress.Xpf.ChunkList.ChunkList-1)
* [OptimizeSummaryCalculation](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl.OptimizeSummaryCalculation)
* [How to Create a Custom Service](https://docs.devexpress.com/WPF/16920/mvvm-framework/services/how-to-create-a-custom-service)
* [Create a Custom Behavior](https://docs.devexpress.com/WPF/17442/mvvm-framework/behaviors#create-a-custom-behavior)

## More Examples

* [WPF Data Grid - Call the BeginDataUpdate and EndDataUpdate Methods at the View Model Level](https://github.com/DevExpress-Examples/wpf-data-grid-call-begindataupdate-and-enddataupdate-at-view-model-level)
* [Data Grid for WPF - Refresh the Data Grid on a Timer](https://github.com/DevExpress-Examples/wpf-data-grid-refresh-on-timer)
